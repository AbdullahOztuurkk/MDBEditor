using MDBEditor.Constants;
using MDBEditor.Constants.Enums;
using MDBEditor.Controls;
using MDBEditor.Helpers;
using System;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;

namespace MDBEditor
{
    public partial class MasterForm : Form
    {
        private readonly PictureBoxWithGrid BoxWithGrid;

        public MasterForm()
        {
            InitializeComponent();
            FormHelper.Get_Colors_Into_The_Control(FLP_Colors);
            FormHelper.Get_Colors_Into_The_Control(FLP_Text_Colors);
            Lbl_Page_Size.Text = PB_Drawing_Board.Width + " " + PB_Drawing_Board.Height;
            
            //Add grid control to drawing board
            BoxWithGrid = new PictureBoxWithGrid(PB_Drawing_Board.Size);
            PB_Drawing_Board.Controls.Add(BoxWithGrid);

            //Set location of drawing board before checked ruler checkbox
            PB_Drawing_Board.Location = new Point(12, 9);

            //Add rulers to pictureboxes
            PB_Ruler_Left.Controls.Add(new RulerPictureBox(BoxAlignment.Vertical));
            PB_Ruler_Top.Controls.Add(new RulerPictureBox());
        }

        public void Select_Color_From_Button(object sender, EventArgs e)
        {
            Button selectedButton = sender as Button;
            if (Color_Picker.ShowDialog() == DialogResult.OK)
            {
                selectedButton.BackColor = Color_Picker.Color;
                //TODO: select color for primary and secondary color
            }
        }

        /// <summary>
        /// Get mouse positions for status bar
        /// </summary>
        private void PB_Drawing_Board_MouseMove(object sender, MouseEventArgs e)
        {
            Lbl_Mouse_Coordinates.Text = e.X + "," + e.Y + " px";
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
            if(DialogResult.OK == Open_File_Dialog.ShowDialog())
            {
                string original_file_name = Open_File_Dialog.SafeFileName.Substring(0, Open_File_Dialog.SafeFileName.LastIndexOf('.'));
                if (PB_Drawing_Board.IsNullOrEmpty())
                {
                    PB_Drawing_Board.Image = new Bitmap(Open_File_Dialog.FileName);
                    this.Text = "MDBEditor - " + original_file_name;
                }
                else
                {
                    if(DialogResult.Yes == 
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
            if(CB_Ruler.CheckState == CheckState.Checked)
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
    }
}
