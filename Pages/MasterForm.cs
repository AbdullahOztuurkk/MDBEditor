using MDBEditor.Constants;
using MDBEditor.Constants.Enums;
using MDBEditor.Controls;
using MDBEditor.Helpers;
using MDBEditor.Models;
using MDBEditor.Pages;
using MDBEditor.Pages.Modals;
using MDBEditor.Shapes;
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
        private Point StartPoint;

        //Colors
        public static Color primaryColor = Color.Black;
        public static Color secondaryColor = Color.White;

        //Tools
        private GeometricalShape? currentShape;
        private DrawingTool currentTool;
        private PenTool penTool;
        private EraserTool eraserTool;
        private ColorPickerTool colorPickerTool;
        private FillerTool fillerTool;
        private TextTool textTool;
        private ZoomTool zoomTool;
        private SelectAreaTool selectAreaTool;

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
            CB_Shape_Border.SelectedIndex = 3; //Normal Size
            CB_Shape_Fill.SelectedIndex = 0; //No Fill

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
            zoomTool = new ZoomTool(PB_Drawing_Board);
            selectAreaTool = new SelectAreaTool();
        }
        
        public void Select_Color_From_Button(object sender, EventArgs e)
        {
            Button selectedButton = sender as Button;
            if (Color_Picker.ShowDialog() == DialogResult.OK)
            {
                selectedButton.BackColor = Color_Picker.Color;
                switch (selectedButton.Tag)
                {
                    case "PrimaryColor":
                        primaryColor = Color_Picker.Color; break;
                    case "SecondaryColor":
                        secondaryColor = Color_Picker.Color; break;
                }
            }
        }

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

        private void Btn_Open_File_Click(object sender, EventArgs e)
        {
            PB_Drawing_Board.OpenImage(this);
            zoomTool = new ZoomTool(PB_Drawing_Board);
        }

        /// <summary>
        /// Set visible of Ruler in drawing board
        /// </summary>
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
                    case DrawingTool.Select_Area:
                        if (e.Button == MouseButtons.Left)
                        {
                            selectAreaTool.SelectedRect = new Rectangle(
                                Math.Min(StartPoint.X,  e.Location.X), 
                                Math.Min(StartPoint.Y,  e.Location.Y),
                                Math.Abs(StartPoint.X - e.Location.X), 
                                Math.Abs(StartPoint.Y - e.Location.Y));
                            //Preview shape and rubber band box
                            using (Graphics g = PB_Drawing_Board.CreateGraphics())
                            {
                                g.DrawRectangle(Pens.Red, selectAreaTool.SelectedRect);
                                if (currentShape != null && selectAreaTool.SelectedRect.Width > 1)
                                {
                                    if(ShapeOptions.IsFilled == true)
                                        ShapeFactory.Create((GeometricalShape)currentShape)
                                            .Fill(g, selectAreaTool.SelectedRect, new SolidBrush(primaryColor));
                                    else
                                        ShapeFactory.Create((GeometricalShape)currentShape)
                                            .Draw(g, selectAreaTool.SelectedRect, new Pen(primaryColor, ShapeOptions.BorderSize));
                                }
                            }
                        }
                        break;
                }
                PB_Drawing_Board.Refresh();
            }
        }

        private void PB_Drawing_Board_MouseDown(object sender, MouseEventArgs e)
        {
            IsMouseDown = true;
            lastPoint = e.Location;
            undoRedoStack.Save(PB_Drawing_Board.TakeSnapshot());
            switch (currentTool)
            {
                case DrawingTool.Color_Picker:
                    colorPickerTool.Loc = e.Location;
                    colorPickerTool.Handle();
                    primaryColor = colorPickerTool.DetectedColor;
                    break;
                case DrawingTool.Text:
                    textTool.Loc = e.Location;
                    textTool.ForeColor = primaryColor;
                    textTool.SideColor = secondaryColor;
                    textTool.Text = Txt_Text.Text;
                    textTool.Font = Font_Dialog.Font;
                    textTool.Handle();
                    PB_Drawing_Board.Refresh();
                    break;
                case DrawingTool.Zoom:
                    if (e.Button == MouseButtons.Left)
                        ZoomToImage(ZoomStatus.ZoomIn);
                    else if (e.Button == MouseButtons.Right)
                        ZoomToImage(ZoomStatus.ZoomOut);
                    break;
                case DrawingTool.Select_Area:
                    if (e.Button == MouseButtons.Left)
                    {
                        Cursor = Cursors.Cross;
                        StartPoint = e.Location;
                    }
                    PB_Drawing_Board.Refresh();
                    break;
            }
        }

        private void PB_Drawing_Board_MouseUp(object sender, MouseEventArgs e)
        {
            if(currentTool == DrawingTool.Select_Area)
            {
                if (currentShape != null && selectAreaTool.SelectedRect.Width > 1)
                {
                    undoRedoStack.Save(PB_Drawing_Board.TakeSnapshot());
                    if (ShapeOptions.IsFilled == true)
                        ShapeFactory.Create((GeometricalShape)currentShape)
                            .Fill(BoardGraphics, selectAreaTool.SelectedRect, new SolidBrush(primaryColor));
                    else 
                        ShapeFactory.Create((GeometricalShape)currentShape)
                            .Draw(BoardGraphics, selectAreaTool.SelectedRect, new Pen(primaryColor, ShapeOptions.BorderSize));
                    selectAreaTool.Clear();
                }
            }
            lastPoint = e.Location;
            IsMouseDown = false;
            PB_Drawing_Board.Refresh();
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
                Btn_Pen,
                Btn_Erase,
                Btn_Zoom,
                Btn_Color_Picker,
                Btn_Add_Text,
                Btn_Paint_All,
                Btn_Select_Area
            };
            buttonArr.ForEach(p => p.BackColor = AppSettings.DEFAULT_TOOL_COLOR);
            Button btn = sender as Button;
            
            //Select drawing tool by sender's tag
            currentTool = (DrawingTool)Enum.Parse(typeof(DrawingTool), btn.Tag.ToString());
            btn.BackColor = AppSettings.CURRENT_TOOL_COLOR;

            //Toggle Text Tab
            if (currentTool == DrawingTool.Text)
            {
                TC_Menu.TabPages.Add(TP_Text);
                TC_Menu.SelectedTab = TP_Text;
            }
            else
                TC_Menu.TabPages.Remove(TP_Text);
        }
        private void Check_Gridlines_Before_Save(Action SaveAction)
        {
            ZoomToImage(ZoomStatus.ZoomToNormal);
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

        private void UpdateGraphics()
        {
            BoardGraphics = Graphics.FromImage((Bitmap)PB_Drawing_Board.Image);
            penTool = new PenTool(BoardGraphics);
            eraserTool = new EraserTool(BoardGraphics);
            textTool = new TextTool(BoardGraphics);
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
                        PB_Drawing_Board.OpenImage(this);
                        zoomTool = new ZoomTool(PB_Drawing_Board); break;
                    case Keys.Z:
                        if (undoRedoStack.CanUndo){
                            undoRedoStack.Undo();
                            UpdateGraphics();
                        }
                        break;
                    case Keys.Y:
                        if (undoRedoStack.CanRedo){
                            undoRedoStack.Redo();
                            UpdateGraphics();
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

        private void Resize_Modal_Show(object sender, EventArgs e)
        {
            using ResizeForm resizeForm = new ResizeForm(PB_Drawing_Board);
            resizeForm.ShowDialog();
            PB_Drawing_Board.Size = resizeForm.sourceBitmap.Size;
            PB_Drawing_Board.SetImage(resizeForm.sourceBitmap);
            UpdateGraphics();

        }
        #region Methods with lambda expression

        private void CB_Status_Bar_CheckedChanged(object sender, EventArgs e) => Status_Bar.Visible = CB_Status_Bar.Checked == true;
        private void CB_Guidelines_CheckedChanged(object sender, EventArgs e) => BoxWithGrid.Visible = !BoxWithGrid.Visible;
        private void PB_Font_Dialog_Click(object sender, EventArgs e) => Font_Dialog.ShowDialog();
        private void CB_Ruler_CheckedChanged(object sender, EventArgs e) => ToggleRuler();
        private void Btn_Print_Image_Click(object sender, EventArgs e) => PB_Drawing_Board.PrintImage();
        private void Show_About_Box(object sender, EventArgs e) => new AboutForm().ShowDialog();
        private void Btn_New_Image_Click(object sender, EventArgs e) => PB_Drawing_Board.NewImage(this);
        private void Btn_Zoom_In_Click(object sender, EventArgs e) => ZoomToImage(ZoomStatus.ZoomIn);
        private void Btn_Zoom_Out_Click(object sender, EventArgs e) => ZoomToImage(ZoomStatus.ZoomOut);
        private void Btn_Zoom_Normal_Click(object sender, EventArgs e) => ZoomToImage(ZoomStatus.ZoomToNormal);

        #endregion

        private void ZoomToImage(ZoomStatus status)
        {
            switch (status)
            {
                case ZoomStatus.ZoomIn: zoomTool.ZoomIn(); break;
                case ZoomStatus.ZoomOut: zoomTool.ZoomOut(); break;
                case ZoomStatus.ZoomToNormal: zoomTool.ZoomToNormal(); break;
            }
            zoomTool.Handle();
            PB_Drawing_Board.SetImage(zoomTool.ZoomedImage);
            UpdateGraphics();
        }

        private void Btn_Features_Click(object sender, EventArgs e)
        {
            using FeaturesForm featuresForm = new FeaturesForm(PB_Drawing_Board,
                new ImageInformation(
                    (int)((Bitmap)PB_Drawing_Board.Image).HorizontalResolution));
            featuresForm.ShowDialog();
            PB_Drawing_Board.Size = featuresForm.sourceBitmap.Size;
            PB_Drawing_Board.SetImage(featuresForm.sourceBitmap);
            UpdateGraphics();
        }

        private void Btn_Rotate_Image_Click(object sender, EventArgs e)
        {
            Bitmap rotatedImg = (Bitmap)PB_Drawing_Board.Image;
            rotatedImg.RotateFlip(RotateFlipType.Rotate90FlipNone);
            PB_Drawing_Board.SetImage(rotatedImg);
            UpdateGraphics();
        }

        private void Select_Shape(object sender, EventArgs e)
        {
            PictureBox pb = sender as PictureBox;
            currentShape = (GeometricalShape)Enum.Parse(typeof(GeometricalShape), pb.Tag.ToString());
            currentTool = DrawingTool.Select_Area;
        }

        private void CB_Shape_Fill_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShapeOptions.IsFilled = CB_Shape_Fill.SelectedIndex == 1;
        }

        private void CB_Shape_Corner_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShapeOptions.BorderStatus = (ShapeBorderStatus)CB_Shape_Border.SelectedIndex;
        }
    }
}
