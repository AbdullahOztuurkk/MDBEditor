using MDBEditor.Constants.Enums;
using MDBEditor.Controls;
using MDBEditor.Helpers;
using MDBEditor.Tools.Concrete;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace MDBEditor
{
    public partial class MasterForm : Form
    {
        private readonly PictureBoxWithGrid BoxWithGrid;

        //Mouse event properties
        bool IsMouseDown = false;
        private Point lastPoint;

        //Colors
        private Color primaryColor = Color.Black;
        private Color secondaryColor = Color.White;

        //Tools
        public DrawingTool currentTool;
        private readonly PenTool penTool;
        private readonly EraserTool eraserTool;
        private ColorPickerTool colorPickerTool;
        private readonly FillerTool fillerTool;
        private readonly TextTool textTool;

        public MasterForm()
        {
            InitializeComponent();
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

            //Tools
            penTool = new PenTool(PB_Drawing_Board.CreateGraphics());
            eraserTool = new EraserTool(PB_Drawing_Board.CreateGraphics());
            fillerTool = new FillerTool(new Bitmap(PB_Drawing_Board.Width,PB_Drawing_Board.Height));
            colorPickerTool = new ColorPickerTool(PB_Drawing_Board);
            textTool = new TextTool(PB_Drawing_Board.CreateGraphics());
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
                            penTool.Size = 3;
                            penTool.LastPoint = lastPoint;
                            penTool.Handle();
                            lastPoint = e.Location;
                        }
                        break;
                    case DrawingTool.Eraser:
                        if (lastPoint != null)
                        {
                            eraserTool.Loc = e.Location;
                            eraserTool.Size = 10;
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

            }
        }

        /// <summary>
        /// Set toggleable status bar 
        /// </summary>
        private void CB_Status_Bar_CheckedChanged(object sender, EventArgs e)
        {
            Status_Bar.Visible = CB_Status_Bar.Checked == true ? true : false;
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
            //TODO: Use the undo-redo stack to avoid the hassle of clearing the drawing board when resized.
        }

        /// <summary>
        /// Set toggleable gridlines on drawing board
        /// </summary>
        private void CB_Guidelines_CheckedChanged(object sender, EventArgs e)
        {
            BoxWithGrid.Visible = !BoxWithGrid.Visible;
        }

        private void PB_Font_Dialog_Click(object sender, EventArgs e)
        {
            //TODO: Detect selected text and apply font to text
            Font_Dialog.ShowDialog();
        }

        private void Btn_Open_File_Click(object sender, EventArgs e)
        {
            if (DialogResult.OK == Open_File_Dialog.ShowDialog())
            {
                string original_file_name = Open_File_Dialog.SafeFileName.Substring(0, Open_File_Dialog.SafeFileName.LastIndexOf('.'));
                if (PB_Drawing_Board.IsNullOrEmpty())
                {
                    PB_Drawing_Board.Image = new Bitmap(Open_File_Dialog.FileName);
                    this.Text = "MDBEditor - " + original_file_name;
                }
                else
                {
                    if (DialogResult.Yes ==
                        MessageBox.Show("There are unsaved changes. Do you still want to open this file?",
                        "Unsaved changes",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                    {
                        PB_Drawing_Board.Image = new Bitmap(Open_File_Dialog.FileName);
                        this.Text = "MDBEditor - " + original_file_name;
                    }
                    //TODO: Check if page saved according to picturebox availability
                }
            }
        }

        /// <summary>
        /// Set visible of Ruler in drawing board
        /// </summary>
        private void CB_Ruler_CheckedChanged(object sender, EventArgs e)
        {
            //Drawing board location is 12,9 -> new location is 32,28
            if (CB_Ruler.CheckState == CheckState.Checked)
            {
                PB_Ruler_Left.Visible = true;
                PB_Ruler_Top.Visible = true;
                PB_Drawing_Board.Location = new Point(32, 28);
            }
            else
            {
                PB_Ruler_Left.Visible = false;
                PB_Ruler_Top.Visible = false;
                PB_Drawing_Board.Location = new Point(12, 9);
            }
        }

        private void PB_Drawing_Board_MouseDown(object sender, MouseEventArgs e)
        {
            IsMouseDown = true;
            lastPoint = e.Location;
            if(currentTool == DrawingTool.Color_Picker)
            {
                colorPickerTool.Loc = e.Location;
                colorPickerTool.Handle();
                primaryColor = colorPickerTool.DetectedColor;
                Btn_Primary_Color.BackColor = primaryColor;
            }
            if(currentTool == DrawingTool.Text)
            {
                textTool.Loc = e.Location;
                textTool.ForeColor = primaryColor;
                textTool.SideColor = secondaryColor;
                textTool.Text = Txt_Text.Text;
                textTool.Font = Font_Dialog.Font;
                textTool.Handle();
            }
        }

        private void PB_Drawing_Board_MouseUp(object sender, MouseEventArgs e)
        {
            lastPoint = e.Location;
            IsMouseDown = false;
        }

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
            buttonArr.ForEach(p => p.BackColor = SystemColors.Control);
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
            btn.BackColor = SystemColors.ControlLight;

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

    }
}
