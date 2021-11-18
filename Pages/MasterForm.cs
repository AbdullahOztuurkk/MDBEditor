using MDBEditor.Constants;
using MDBEditor.Controls;
using MDBEditor.Helpers;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace MDBEditor
{
    public partial class MasterForm : Form
    {
        private readonly PictureBoxWithGrid BoxWithGrid;

        public MasterForm()
        {
            InitializeComponent();
            FormHelper.Get_Colors_Into_The_Control(FLP_Colors,FLP_Text_Colors);
            Lbl_Page_Size.Text = PB_Drawing_Board.Width + " " + PB_Drawing_Board.Height;
            
            //Add grid control to drawing board
            BoxWithGrid = new PictureBoxWithGrid(PB_Drawing_Board.Size);
            PB_Drawing_Board.Controls.Add(BoxWithGrid);
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
            Open_File_Dialog.RestoreDirectory = true;
            if(DialogResult.OK == Open_File_Dialog.ShowDialog())
            {
                if(FormHelper.IsNullOrEmpty(PB_Drawing_Board))
                    PB_Drawing_Board.Image = new Bitmap(Open_File_Dialog.FileName);
                else
                {
                    if(DialogResult.Yes == 
                        MessageBox.Show("Kaydedilmemiş değişiklikler var. " +
                        "Yine de bu dosyayı açmak istiyor musunuz?",
                        "Unsaved changes",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                    {
                        PB_Drawing_Board.Image = new Bitmap(Open_File_Dialog.FileName);
                    }
                }
            }
        }
    }
}
