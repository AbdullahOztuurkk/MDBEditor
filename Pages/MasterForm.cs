using MDBEditor.Constants;
using MDBEditor.Constants.Enums;
using MDBEditor.Controls;
using MDBEditor.Helpers;
using MDBEditor.Pages;
using MDBEditor.Tools.Concrete;
using MDBEditor.Utils;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace MDBEditor
{
    public partial class MasterForm : Form
    {
        private readonly PictureBoxWithGrid BoxWithGrid;
        private UndoRedoStack undoRedoStack;
        private Graphics BoardGraphics;

        //Mouse event properties
        bool IsMouseDown = false;
        private Point lastPoint;

        //Colors
        public static Color primaryColor = Color.Black;
        public static Color secondaryColor = Color.White;

        //Tools
        public DrawingTool currentTool;
        private PenTool penTool;
        private EraserTool eraserTool;
        private ColorPickerTool colorPickerTool;
        private readonly FillerTool fillerTool;
        private TextTool textTool;

        public MasterForm()
        {
            InitializeComponent();
            PB_Drawing_Board.Image = new Bitmap(PB_Drawing_Board.Width, PB_Drawing_Board.Height);
            BoardGraphics = Graphics.FromImage(PB_Drawing_Board.Image);
            undoRedoStack = new UndoRedoStack(PB_Drawing_Board);
            FLP_Colors.Get_Colors();
            FLP_Text_Colors.Get_Colors();
            Lbl_Page_Size.Text = PB_Drawing_Board.Width + " " + PB_Drawing_Board.Height;
            TC_Menu.TabPages.Remove(TP_Text);

            //Add grid control to drawing board
            BoxWithGrid = new PictureBoxWithGrid(PB_Drawing_Board.Size);
            PB_Drawing_Board.Controls.Add(BoxWithGrid);

            //Set location of drawing board before checked ruler checkbox
            PB_Drawing_Board.Location = new Point(12, 9);

            //Add rulers to pictureboxes
            PB_Ruler_Left.Controls.Add(new RulerPictureBox(BoxAlignment.Vertical));
            PB_Ruler_Top.Controls.Add(new RulerPictureBox());
            this.Size = AppSettings.RULER_CLOSED_COORDINATE;

            //Tools
            penTool = new PenTool(BoardGraphics);
            eraserTool = new EraserTool(BoardGraphics);
            fillerTool = new FillerTool(new Bitmap(PB_Drawing_Board.Width, PB_Drawing_Board.Height));
            colorPickerTool = new ColorPickerTool(PB_Drawing_Board);
            textTool = new TextTool(BoardGraphics);
        }

        public void Select_Color_From_Button(object sender, EventArgs e)
        {
            Button selectedButton = sender as Button;
            if (Color_Picker.ShowDialog() == DialogResult.OK)
            {
                selectedButton.BackColor = Color_Picker.Color;
                switch (selectedButton.Name)
                {
                    case nameof(Btn_Primary_Color):
                    case nameof(Btn_Text_Primary_Color):
                        primaryColor = Color_Picker.Color; break;
                    case nameof(Btn_Secondary_Color):
                    case nameof(Btn_Text_Secondary_Color):
                        secondaryColor = Color_Picker.Color; break;
                }
            }
        }

        /// <summary>
        /// Set toggleable status bar 
        /// </summary>
        private void CB_Status_Bar_CheckedChanged(object sender, EventArgs e) => Status_Bar.Visible = CB_Status_Bar.Checked == true;

        /// <summary>
        /// Get drawing board size for status bar
        /// </summary>
        private void PB_Drawing_Board_SizeChanged(object sender, EventArgs e)
        {
            Lbl_Page_Size.Text = PB_Drawing_Board.Width + " " + PB_Drawing_Board.Height;
            PB_Ruler_Left.Height = PB_Drawing_Board.Height;
            PB_Ruler_Top.Width = PB_Drawing_Board.Width;
            BoxWithGrid.Size = PB_Drawing_Board.Size;
        }

        /// <summary>
        /// Set toggleable gridlines on drawing board
        /// </summary>
        private void CB_Guidelines_CheckedChanged(object sender, EventArgs e) => BoxWithGrid.Visible = !BoxWithGrid.Visible;
        private void PB_Font_Dialog_Click(object sender, EventArgs e) => Font_Dialog.ShowDialog();
        private void Btn_Open_File_Click(object sender, EventArgs e) => PB_Drawing_Board.OpenImage(this);

        /// <summary>
        /// Set visible of Ruler in drawing board
        /// </summary>
        private void CB_Ruler_CheckedChanged(object sender, EventArgs e) => ToggleRuler();

        private void ToggleRuler()
        {
            //Drawing board location is 12,9 -> new location is 32,28
            if (PB_Ruler_Left.Visible == false || PB_Ruler_Top.Visible == false)
            {
                PB_Ruler_Left.Visible = true;
                PB_Ruler_Top.Visible = true;
                PB_Drawing_Board.Location = AppSettings.NEW_DRAWING_BOARD_COORDINATE;
                this.Size = AppSettings.RULER_OPENED_COORDINATE;
            }
            else
            {
                PB_Ruler_Left.Visible = false;
                PB_Ruler_Top.Visible = false;
                PB_Drawing_Board.Location = AppSettings.OLD_DRAWING_BOARD_COORDINATE;
                this.Size = AppSettings.RULER_CLOSED_COORDINATE;
            }
        }

        #region Mouse Events

        /// <summary>
        /// Get mouse positions for status bar
        /// </summary>
        private void PB_Drawing_Board_MouseMove(object sender, MouseEventArgs e)
        {
            Lbl_Mouse_Coordinates.Text = e.X + "," + e.Y + " px";
            if (IsMouseDown == true)
            {
                switch (currentTool)
                {
                    case DrawingTool.Pen:
                        if (lastPoint != null)
                        {
                            penTool.Loc = e.Location;
                            penTool.BackColor = primaryColor;
                            penTool.LastPoint = lastPoint;
                            penTool.Handle();
                            lastPoint = e.Location;
                        }
                        break;
                    case DrawingTool.Eraser:
                        if (lastPoint != null)
                        {
                            eraserTool.Loc = e.Location;
                            eraserTool.LastPoint = lastPoint;
                            eraserTool.Handle();
                            lastPoint = e.Location;
                        }
                        break;
                    case DrawingTool.Filler:
                        fillerTool.BackColor = Color.Blue;
                        fillerTool.Loc = e.Location;
                        fillerTool.Handle();
                        //TODO:Needs Flood Fill Algorithm
                        break;
                }
                PB_Drawing_Board.Refresh();
            }
        }

        private void PB_Drawing_Board_MouseDown(object sender, MouseEventArgs e)
        {
            IsMouseDown = true;
            lastPoint = e.Location;
            Bitmap bmp = new Bitmap(PB_Drawing_Board.Width, PB_Drawing_Board.Height);
            PB_Drawing_Board.DrawToBitmap(bmp, PB_Drawing_Board.ClientRectangle);
            undoRedoStack.Save(bmp);
            if (currentTool == DrawingTool.Color_Picker)
            {
                colorPickerTool.Loc = e.Location;
                colorPickerTool.Handle();
                primaryColor = colorPickerTool.DetectedColor;
                Btn_Primary_Color.BackColor = primaryColor;
            }
            if (currentTool == DrawingTool.Text)
            {
                textTool.Loc = e.Location;
                textTool.ForeColor = primaryColor;
                textTool.SideColor = secondaryColor;
                textTool.Text = Txt_Text.Text;
                textTool.Font = Font_Dialog.Font;
                textTool.Handle();
                PB_Drawing_Board.Refresh();
            }
        }

        private void PB_Drawing_Board_MouseUp(object sender, MouseEventArgs e)
        {
            lastPoint = e.Location;
            IsMouseDown = false;
        }

        #endregion

        /// <summary>
        /// Get tool name with sender func
        /// </summary>
        /// <param name="sender">Any Prologue Tool</param>
        /// <param name="e">Event Args</param>
        private void Select_Tool(object sender, EventArgs e)
        {
            List<Button> buttonArr = new List<Button>
            {
                Btn_Pen,Btn_Erase,Btn_Zoom,Btn_Color_Picker,Btn_Add_Text,Btn_Paint_All
            };
            buttonArr.ForEach(p => p.BackColor = AppSettings.DEFAULT_TOOL_COLOR);
            Button btn = sender as Button;
            switch (btn.Name)
            {
                case nameof(Btn_Pen):
                    currentTool = DrawingTool.Pen;
                    break;
                case nameof(Btn_Erase):
                    currentTool = DrawingTool.Eraser;
                    break;
                case nameof(Btn_Zoom):
                    currentTool = DrawingTool.Zoom;
                    break;
                case nameof(Btn_Color_Picker):
                    currentTool = DrawingTool.Color_Picker;
                    break;
                case nameof(Btn_Add_Text):
                    currentTool = DrawingTool.Text;
                    break;
                case nameof(Btn_Paint_All):
                    currentTool = DrawingTool.Filler;
                    break;
            }
            btn.BackColor = AppSettings.CURRENT_TOOL_COLOR;

            //Toggle Text Tab
            if (currentTool == DrawingTool.Text)
            {
                TC_Menu.TabPages.Add(TP_Text);
                TC_Menu.SelectedTab = TP_Text;
            }
            else
            {
                TC_Menu.TabPages.Remove(TP_Text);
            }
        }
        private void Check_Gridlines_Before_Save(Action SaveAction)
        {
            if (CB_Guidelines.Checked)
                BoxWithGrid.Visible = false;
            SaveAction();
            if (CB_Guidelines.Checked)
                BoxWithGrid.Visible = true;
        }
        private void Save_Image(object sender, EventArgs e)
        {
            Check_Gridlines_Before_Save(() =>
            {
                PictureBox pictureBox = sender as PictureBox;
                switch (pictureBox.Name)
                {
                    case nameof(PB_Save_As_BMP):
                        PB_Drawing_Board.SaveImage(ImageFormat.Bmp); break;
                    case nameof(PB_Save_As_GIF):
                        PB_Drawing_Board.SaveImage(ImageFormat.Gif); break;
                    case nameof(PB_Save_As_JPG):
                        PB_Drawing_Board.SaveImage(ImageFormat.Jpeg); break;
                    case nameof(PB_Save_As_PNG):
                        PB_Drawing_Board.SaveImage(ImageFormat.Png); break;
                    default: PB_Drawing_Board.SaveImage(); break;
                }
            });
        }

        /// <summary>
        /// Detect changed variables and run some processes
        /// </summary>
        private void Continuous_Checker_Tick(object sender, EventArgs e)
        {
            #region Color Buttons
            Btn_Text_Primary_Color.BackColor = primaryColor;
            Btn_Primary_Color.BackColor = primaryColor;
            Btn_Text_Secondary_Color.BackColor = secondaryColor;
            Btn_Secondary_Color.BackColor = secondaryColor;
            #endregion
        }

        //Shortcut Helper method
        private void Detect_Key(object sender, KeyEventArgs e)
        {
            if (e.Modifiers == Keys.Control)
            {
                switch (e.KeyCode)
                {
                    case Keys.S:
                        Check_Gridlines_Before_Save(() => { PB_Drawing_Board.SaveImage(); });
                        break;
                    case Keys.R:
                        ToggleRuler(); break;
                    case Keys.G:
                        BoxWithGrid.Visible = !BoxWithGrid.Visible; break;
                    case Keys.O:
                    case Keys.N:
                        PB_Drawing_Board.OpenImage(this); break;
                    case Keys.Z:
                        if (undoRedoStack.CanUndo)
                        {
                            undoRedoStack.Undo();
                            BoardGraphics = Graphics.FromImage(PB_Drawing_Board.Image);
                            penTool = new PenTool(BoardGraphics);
                            eraserTool = new EraserTool(BoardGraphics);
                            textTool = new TextTool(BoardGraphics);
                        }
                        break;
                    case Keys.Y:
                        if (undoRedoStack.CanRedo)
                        {
                            undoRedoStack.Redo();
                            BoardGraphics = Graphics.FromImage(PB_Drawing_Board.Image);
                            penTool = new PenTool(BoardGraphics);
                            eraserTool = new EraserTool(BoardGraphics);
                            textTool = new TextTool(BoardGraphics);
                        }
                        break;
                    case Keys.P:
                        PB_Drawing_Board.PrintImage();
                        break;
                    case Keys.Add:
                        penTool.IncreaseSize();
                        eraserTool.IncreaseSize();
                        break;
                    case Keys.Subtract:
                        penTool.DescreaseSize();
                        eraserTool.DescreaseSize();
                        break;
                }
            }
        }

        private void Btn_Print_Image_Click(object sender, EventArgs e) => PB_Drawing_Board.PrintImage();

        private void Clipboard_Events(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            switch (btn.Name)
            {
                case nameof(Btn_Copy_To_Clipboard):
                    Clipboard.SetText(Txt_Text.Text); break;
                case nameof(Btn_Cut_To_Clipboard):
                    Clipboard.SetText(Txt_Text.Text);
                    Txt_Text.Clear();
                    break;
                case nameof(Btn_Paste_From_Clipboard):
                    Txt_Text.Text = Clipboard.GetText();
                    break;
            }
        }

        private void Show_About_Box(object sender, EventArgs e) => new AboutForm().ShowDialog();
    }
}
