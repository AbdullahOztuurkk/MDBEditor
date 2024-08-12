using MDBEditor.Controls;

namespace MDBEditor
{
    partial class MasterForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MasterForm));
            this.TC_Menu = new TabControl();
            this.TP_General = new TabPage();
            this.FLP_File = new FlowLayoutPanel();
            this.GB_File_Options = new GroupBox();
            this.TLP_File = new TableLayoutPanel();
            this.Btn_Open_File = new Button();
            this.Btn_New_Image = new Button();
            this.label7 = new Label();
            this.label6 = new Label();
            this.GB_Save_File = new GroupBox();
            this.FLP_Save_Image = new TableLayoutPanel();
            this.PB_Save_As_Image = new PictureBox();
            this.PB_Save_As_PNG = new PictureBox();
            this.PB_Save_As_JPG = new PictureBox();
            this.PB_Save_As_GIF = new PictureBox();
            this.GB_Print = new GroupBox();
            this.Btn_Print_Image = new Button();
            this.GB_Settings = new GroupBox();
            this.TLP_Features = new TableLayoutPanel();
            this.Btn_Features = new Button();
            this.label8 = new Label();
            this.label9 = new Label();
            this.TP_Prologue = new TabPage();
            this.FLP_Prologue = new FlowLayoutPanel();
            this.GB_Paste_Box = new GroupBox();
            this.Btn_Paste_Area = new Button();
            this.Btn_Paste_From_File = new Button();
            this.GB_Image_Area = new GroupBox();
            this.TLP_Image = new TableLayoutPanel();
            this.Btn_Crop_Image = new Button();
            this.Btn_Resize_Image = new Button();
            this.Btn_Rotate_Image = new Button();
            this.Btn_Select_Area = new Button();
            this.GB_Shape_Features = new GroupBox();
            this.TBL_Shape_Features = new TableLayoutPanel();
            this.label14 = new Label();
            this.CB_Shape_Border = new ComboBox();
            this.label16 = new Label();
            this.CB_Shape_Fill = new ComboBox();
            this.GB_Tools = new GroupBox();
            this.TLP_Tools = new TableLayoutPanel();
            this.Btn_Erase = new Button();
            this.Btn_Color_Picker = new Button();
            this.Btn_Pen = new Button();
            this.Btn_Zoom = new Button();
            this.Btn_Paint_All = new Button();
            this.Btn_Add_Text = new Button();
            this.GB_Shapes = new GroupBox();
            this.TC_Shape = new TabControl();
            this.TC_Shape_Page_1 = new TabPage();
            this.FLP_Shape_Page_1 = new FlowLayoutPanel();
            this.PB_Circle = new PictureBox();
            this.PB_Square = new PictureBox();
            this.PB_Rounded_Rectangle = new PictureBox();
            this.PB_Rectangle = new PictureBox();
            this.PB_Parallelogram = new PictureBox();
            this.PB_Trapezoid = new PictureBox();
            this.PB_Diamond = new PictureBox();
            this.PB_Right_Arrow = new PictureBox();
            this.PB_Left_Arrow = new PictureBox();
            this.PB_Six_Pointed_Star = new PictureBox();
            this.PB_Star = new PictureBox();
            this.PB_Four_Pointed_Star = new PictureBox();
            this.PB_Hexagon = new PictureBox();
            this.O = new PictureBox();
            this.TC_Shape_Page_2 = new TabPage();
            this.FLP_Shapes = new FlowLayoutPanel();
            this.PB_Triangle = new PictureBox();
            this.PB_Left_Triangle = new PictureBox();
            this.PB_Right_Triangle = new PictureBox();
            this.PB_Bottom_Triangle = new PictureBox();
            this.PB_Cube = new PictureBox();
            this.PB_Triangle_Pyramid = new PictureBox();
            this.PB_Plus = new PictureBox();
            this.PB_Note = new PictureBox();
            this.PB_Envelope = new PictureBox();
            this.PB_Eight_Pointed_Star = new PictureBox();
            this.GB_Colors = new GroupBox();
            this.FLP_Colors = new FlowLayoutPanel();
            this.label2 = new Label();
            this.label1 = new Label();
            this.Btn_Secondary_Color = new Button();
            this.Btn_Primary_Color = new Button();
            this.TP_View = new TabPage();
            this.FLP_View = new FlowLayoutPanel();
            this.GB_Zoom = new GroupBox();
            this.tableLayoutPanel1 = new TableLayoutPanel();
            this.Btn_Zoom_Normal = new Button();
            this.label3 = new Label();
            this.label4 = new Label();
            this.label5 = new Label();
            this.Btn_Zoom_Out = new Button();
            this.Btn_Zoom_In = new Button();
            this.GB_Show_Or_Hide = new GroupBox();
            this.TLP_Show_And_Hide = new TableLayoutPanel();
            this.CB_Ruler = new CheckBox();
            this.CB_Guidelines = new CheckBox();
            this.CB_Status_Bar = new CheckBox();
            this.TP_Text = new TabPage();
            this.FLP_Text = new FlowLayoutPanel();
            this.GB_Paste_Text = new GroupBox();
            this.TLP_Text_Operations = new TableLayoutPanel();
            this.Btn_Cut_To_Clipboard = new Button();
            this.Btn_Copy_To_Clipboard = new Button();
            this.Btn_Paste_From_Clipboard = new Button();
            this.GB_Text_Type = new GroupBox();
            this.TLP_Text_Type = new TableLayoutPanel();
            this.label13 = new Label();
            this.Txt_Text = new TextBox();
            this.PB_Font_Dialog = new Button();
            this.GB_Text_Colors = new GroupBox();
            this.FLP_Text_Colors = new FlowLayoutPanel();
            this.label11 = new Label();
            this.label12 = new Label();
            this.Btn_Text_Secondary_Color = new Button();
            this.Btn_Text_Primary_Color = new Button();
            this.button1 = new Button();
            this.button2 = new Button();
            this.button3 = new Button();
            this.button4 = new Button();
            this.button5 = new Button();
            this.button6 = new Button();
            this.button10 = new Button();
            this.button12 = new Button();
            this.button7 = new Button();
            this.button8 = new Button();
            this.button9 = new Button();
            this.button11 = new Button();
            this.Panel_Drawing_Board = new Panel();
            this.PB_Ruler_Top = new PictureBox();
            this.PB_Ruler_Left = new PictureBox();
            this.PB_Drawing_Board = new ResizablePictureBox();
            this.Status_Bar = new StatusStrip();
            this.Lbl_Mouse_Coordinates = new ToolStripStatusLabel();
            this.Lbl_Page_Size = new ToolStripStatusLabel();
            this.Color_Picker = new ColorDialog();
            this.groupBox3 = new GroupBox();
            this.groupBox4 = new GroupBox();
            this.tableLayoutPanel6 = new TableLayoutPanel();
            this.groupBox5 = new GroupBox();
            this.tableLayoutPanel7 = new TableLayoutPanel();
            this.groupBox6 = new GroupBox();
            this.tableLayoutPanel8 = new TableLayoutPanel();
            this.flowLayoutPanel1 = new FlowLayoutPanel();
            this.Font_Dialog = new FontDialog();
            this.Continuous_Checker = new Timer(this.components);
            this.TLP_Print = new TableLayoutPanel();
            this.Lbl_Print = new Label();
            this.TC_Menu.SuspendLayout();
            this.TP_General.SuspendLayout();
            this.FLP_File.SuspendLayout();
            this.GB_File_Options.SuspendLayout();
            this.TLP_File.SuspendLayout();
            this.GB_Save_File.SuspendLayout();
            this.FLP_Save_Image.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)this.PB_Save_As_Image).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.PB_Save_As_PNG).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.PB_Save_As_JPG).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.PB_Save_As_GIF).BeginInit();
            this.GB_Print.SuspendLayout();
            this.GB_Settings.SuspendLayout();
            this.TLP_Features.SuspendLayout();
            this.TP_Prologue.SuspendLayout();
            this.FLP_Prologue.SuspendLayout();
            this.GB_Paste_Box.SuspendLayout();
            this.GB_Image_Area.SuspendLayout();
            this.TLP_Image.SuspendLayout();
            this.GB_Shape_Features.SuspendLayout();
            this.TBL_Shape_Features.SuspendLayout();
            this.GB_Tools.SuspendLayout();
            this.TLP_Tools.SuspendLayout();
            this.GB_Shapes.SuspendLayout();
            this.TC_Shape.SuspendLayout();
            this.TC_Shape_Page_1.SuspendLayout();
            this.FLP_Shape_Page_1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)this.PB_Circle).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.PB_Square).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.PB_Rounded_Rectangle).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.PB_Rectangle).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.PB_Parallelogram).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.PB_Trapezoid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.PB_Diamond).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.PB_Right_Arrow).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.PB_Left_Arrow).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.PB_Six_Pointed_Star).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.PB_Star).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.PB_Four_Pointed_Star).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.PB_Hexagon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.O).BeginInit();
            this.TC_Shape_Page_2.SuspendLayout();
            this.FLP_Shapes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)this.PB_Triangle).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.PB_Left_Triangle).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.PB_Right_Triangle).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.PB_Bottom_Triangle).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.PB_Cube).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.PB_Triangle_Pyramid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.PB_Plus).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.PB_Note).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.PB_Envelope).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.PB_Eight_Pointed_Star).BeginInit();
            this.GB_Colors.SuspendLayout();
            this.TP_View.SuspendLayout();
            this.FLP_View.SuspendLayout();
            this.GB_Zoom.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.GB_Show_Or_Hide.SuspendLayout();
            this.TLP_Show_And_Hide.SuspendLayout();
            this.TP_Text.SuspendLayout();
            this.FLP_Text.SuspendLayout();
            this.GB_Paste_Text.SuspendLayout();
            this.TLP_Text_Operations.SuspendLayout();
            this.GB_Text_Type.SuspendLayout();
            this.TLP_Text_Type.SuspendLayout();
            this.GB_Text_Colors.SuspendLayout();
            this.Panel_Drawing_Board.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)this.PB_Ruler_Top).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.PB_Ruler_Left).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.PB_Drawing_Board).BeginInit();
            this.Status_Bar.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.TLP_Print.SuspendLayout();
            this.SuspendLayout();
            // 
            // TC_Menu
            // 
            this.TC_Menu.Controls.Add(this.TP_General);
            this.TC_Menu.Controls.Add(this.TP_Prologue);
            this.TC_Menu.Controls.Add(this.TP_View);
            this.TC_Menu.Controls.Add(this.TP_Text);
            this.TC_Menu.Dock = DockStyle.Top;
            this.TC_Menu.ItemSize = new Size(120, 40);
            this.TC_Menu.Location = new Point(0, 0);
            this.TC_Menu.Margin = new Padding(4, 3, 4, 3);
            this.TC_Menu.Name = "TC_Menu";
            this.TC_Menu.SelectedIndex = 0;
            this.TC_Menu.Size = new Size(1097, 171);
            this.TC_Menu.SizeMode = TabSizeMode.Fixed;
            this.TC_Menu.TabIndex = 1;
            // 
            // TP_General
            // 
            this.TP_General.BackColor = SystemColors.Control;
            this.TP_General.Controls.Add(this.FLP_File);
            this.TP_General.Location = new Point(4, 44);
            this.TP_General.Margin = new Padding(4, 3, 4, 3);
            this.TP_General.Name = "TP_General";
            this.TP_General.Padding = new Padding(4, 3, 4, 3);
            this.TP_General.Size = new Size(1089, 123);
            this.TP_General.TabIndex = 2;
            this.TP_General.Text = "File";
            // 
            // FLP_File
            // 
            this.FLP_File.Controls.Add(this.GB_File_Options);
            this.FLP_File.Controls.Add(this.GB_Save_File);
            this.FLP_File.Controls.Add(this.GB_Print);
            this.FLP_File.Controls.Add(this.GB_Settings);
            this.FLP_File.Dock = DockStyle.Fill;
            this.FLP_File.Location = new Point(4, 3);
            this.FLP_File.Margin = new Padding(4, 3, 4, 3);
            this.FLP_File.Name = "FLP_File";
            this.FLP_File.Size = new Size(1081, 117);
            this.FLP_File.TabIndex = 0;
            // 
            // GB_File_Options
            // 
            this.GB_File_Options.Controls.Add(this.TLP_File);
            this.GB_File_Options.Location = new Point(4, 3);
            this.GB_File_Options.Margin = new Padding(4, 3, 4, 3);
            this.GB_File_Options.Name = "GB_File_Options";
            this.GB_File_Options.Padding = new Padding(4, 3, 4, 3);
            this.GB_File_Options.Size = new Size(137, 113);
            this.GB_File_Options.TabIndex = 1;
            this.GB_File_Options.TabStop = false;
            this.GB_File_Options.Text = "File";
            // 
            // TLP_File
            // 
            this.TLP_File.ColumnCount = 5;
            this.TLP_File.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 27.78F));
            this.TLP_File.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 44F));
            this.TLP_File.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 44.44F));
            this.TLP_File.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 44F));
            this.TLP_File.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 27.78F));
            this.TLP_File.Controls.Add(this.Btn_Open_File, 1, 1);
            this.TLP_File.Controls.Add(this.Btn_New_Image, 3, 1);
            this.TLP_File.Controls.Add(this.label7, 3, 2);
            this.TLP_File.Controls.Add(this.label6, 0, 2);
            this.TLP_File.Dock = DockStyle.Fill;
            this.TLP_File.Location = new Point(4, 19);
            this.TLP_File.Name = "TLP_File";
            this.TLP_File.RowCount = 3;
            this.TLP_File.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            this.TLP_File.RowStyles.Add(new RowStyle(SizeType.Absolute, 44F));
            this.TLP_File.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            this.TLP_File.Size = new Size(129, 91);
            this.TLP_File.TabIndex = 0;
            // 
            // Btn_Open_File
            // 
            this.Btn_Open_File.BackgroundImage = Properties.Resources.open_file;
            this.Btn_Open_File.BackgroundImageLayout = ImageLayout.Stretch;
            this.Btn_Open_File.FlatAppearance.BorderSize = 0;
            this.Btn_Open_File.FlatStyle = FlatStyle.Flat;
            this.Btn_Open_File.Location = new Point(15, 30);
            this.Btn_Open_File.Margin = new Padding(4, 3, 4, 3);
            this.Btn_Open_File.Name = "Btn_Open_File";
            this.Btn_Open_File.Size = new Size(36, 37);
            this.Btn_Open_File.TabIndex = 1;
            this.Btn_Open_File.UseVisualStyleBackColor = true;
            this.Btn_Open_File.Click += this.Btn_Open_File_Click;
            // 
            // Btn_New_Image
            // 
            this.Btn_New_Image.BackgroundImage = Properties.Resources.blank_page;
            this.Btn_New_Image.BackgroundImageLayout = ImageLayout.Stretch;
            this.Btn_New_Image.FlatAppearance.BorderSize = 0;
            this.Btn_New_Image.FlatStyle = FlatStyle.Flat;
            this.Btn_New_Image.Location = new Point(77, 30);
            this.Btn_New_Image.Margin = new Padding(4, 3, 4, 3);
            this.Btn_New_Image.Name = "Btn_New_Image";
            this.Btn_New_Image.Size = new Size(36, 37);
            this.Btn_New_Image.TabIndex = 0;
            this.Btn_New_Image.UseVisualStyleBackColor = true;
            this.Btn_New_Image.Click += this.Btn_New_Image_Click;
            // 
            // label7
            // 
            this.TLP_File.SetColumnSpan(this.label7, 2);
            this.label7.Dock = DockStyle.Fill;
            this.label7.Location = new Point(77, 71);
            this.label7.Margin = new Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new Size(48, 20);
            this.label7.TabIndex = 3;
            this.label7.Text = "New";
            this.label7.TextAlign = ContentAlignment.MiddleLeft;
            this.label7.Click += this.Btn_New_Image_Click;
            // 
            // label6
            // 
            this.TLP_File.SetColumnSpan(this.label6, 2);
            this.label6.Dock = DockStyle.Fill;
            this.label6.Location = new Point(4, 71);
            this.label6.Margin = new Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new Size(47, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "Open";
            this.label6.TextAlign = ContentAlignment.MiddleRight;
            // 
            // GB_Save_File
            // 
            this.GB_Save_File.Controls.Add(this.FLP_Save_Image);
            this.GB_Save_File.Location = new Point(149, 3);
            this.GB_Save_File.Margin = new Padding(4, 3, 4, 3);
            this.GB_Save_File.Name = "GB_Save_File";
            this.GB_Save_File.Padding = new Padding(4, 3, 4, 3);
            this.GB_Save_File.Size = new Size(270, 113);
            this.GB_Save_File.TabIndex = 4;
            this.GB_Save_File.TabStop = false;
            this.GB_Save_File.Text = "Save";
            // 
            // FLP_Save_Image
            // 
            this.FLP_Save_Image.ColumnCount = 7;
            this.FLP_Save_Image.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 47F));
            this.FLP_Save_Image.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 23F));
            this.FLP_Save_Image.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 47F));
            this.FLP_Save_Image.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 23F));
            this.FLP_Save_Image.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 47F));
            this.FLP_Save_Image.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 23F));
            this.FLP_Save_Image.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 47F));
            this.FLP_Save_Image.Controls.Add(this.PB_Save_As_Image, 0, 1);
            this.FLP_Save_Image.Controls.Add(this.PB_Save_As_PNG, 2, 1);
            this.FLP_Save_Image.Controls.Add(this.PB_Save_As_JPG, 4, 1);
            this.FLP_Save_Image.Controls.Add(this.PB_Save_As_GIF, 6, 1);
            this.FLP_Save_Image.Location = new Point(4, 19);
            this.FLP_Save_Image.Margin = new Padding(4, 3, 4, 3);
            this.FLP_Save_Image.Name = "FLP_Save_Image";
            this.FLP_Save_Image.RowCount = 3;
            this.FLP_Save_Image.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            this.FLP_Save_Image.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            this.FLP_Save_Image.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            this.FLP_Save_Image.Size = new Size(262, 91);
            this.FLP_Save_Image.TabIndex = 0;
            // 
            // PB_Save_As_Image
            // 
            this.PB_Save_As_Image.BackgroundImage = Properties.Resources.save_as_file;
            this.PB_Save_As_Image.BackgroundImageLayout = ImageLayout.Stretch;
            this.PB_Save_As_Image.Location = new Point(4, 25);
            this.PB_Save_As_Image.Margin = new Padding(4, 3, 4, 3);
            this.PB_Save_As_Image.Name = "PB_Save_As_Image";
            this.PB_Save_As_Image.Size = new Size(38, 37);
            this.PB_Save_As_Image.SizeMode = PictureBoxSizeMode.StretchImage;
            this.PB_Save_As_Image.TabIndex = 0;
            this.PB_Save_As_Image.TabStop = false;
            this.PB_Save_As_Image.Click += this.Save_Image;
            // 
            // PB_Save_As_PNG
            // 
            this.PB_Save_As_PNG.Image = Properties.Resources.save_as_png;
            this.PB_Save_As_PNG.Location = new Point(74, 25);
            this.PB_Save_As_PNG.Margin = new Padding(4, 3, 4, 3);
            this.PB_Save_As_PNG.Name = "PB_Save_As_PNG";
            this.PB_Save_As_PNG.Size = new Size(38, 37);
            this.PB_Save_As_PNG.SizeMode = PictureBoxSizeMode.StretchImage;
            this.PB_Save_As_PNG.TabIndex = 1;
            this.PB_Save_As_PNG.TabStop = false;
            this.PB_Save_As_PNG.Click += this.Save_Image;
            // 
            // PB_Save_As_JPG
            // 
            this.PB_Save_As_JPG.Image = Properties.Resources.save_as_jpg;
            this.PB_Save_As_JPG.Location = new Point(144, 25);
            this.PB_Save_As_JPG.Margin = new Padding(4, 3, 4, 3);
            this.PB_Save_As_JPG.Name = "PB_Save_As_JPG";
            this.PB_Save_As_JPG.Size = new Size(38, 37);
            this.PB_Save_As_JPG.SizeMode = PictureBoxSizeMode.StretchImage;
            this.PB_Save_As_JPG.TabIndex = 2;
            this.PB_Save_As_JPG.TabStop = false;
            this.PB_Save_As_JPG.Click += this.Save_Image;
            // 
            // PB_Save_As_GIF
            // 
            this.PB_Save_As_GIF.Image = Properties.Resources.save_as_gif;
            this.PB_Save_As_GIF.Location = new Point(214, 25);
            this.PB_Save_As_GIF.Margin = new Padding(4, 3, 4, 3);
            this.PB_Save_As_GIF.Name = "PB_Save_As_GIF";
            this.PB_Save_As_GIF.Size = new Size(39, 37);
            this.PB_Save_As_GIF.SizeMode = PictureBoxSizeMode.StretchImage;
            this.PB_Save_As_GIF.TabIndex = 3;
            this.PB_Save_As_GIF.TabStop = false;
            this.PB_Save_As_GIF.Click += this.Save_Image;
            // 
            // GB_Print
            // 
            this.GB_Print.Controls.Add(this.TLP_Print);
            this.GB_Print.Location = new Point(427, 3);
            this.GB_Print.Margin = new Padding(4, 3, 4, 3);
            this.GB_Print.Name = "GB_Print";
            this.GB_Print.Padding = new Padding(4, 3, 4, 3);
            this.GB_Print.Size = new Size(75, 113);
            this.GB_Print.TabIndex = 5;
            this.GB_Print.TabStop = false;
            this.GB_Print.Text = "Print";
            // 
            // Btn_Print_Image
            // 
            this.Btn_Print_Image.BackgroundImage = Properties.Resources.print_file;
            this.Btn_Print_Image.BackgroundImageLayout = ImageLayout.Stretch;
            this.Btn_Print_Image.FlatAppearance.BorderSize = 0;
            this.Btn_Print_Image.FlatStyle = FlatStyle.Flat;
            this.Btn_Print_Image.Location = new Point(10, 21);
            this.Btn_Print_Image.Margin = new Padding(4, 3, 4, 3);
            this.Btn_Print_Image.Name = "Btn_Print_Image";
            this.Btn_Print_Image.Size = new Size(45, 48);
            this.Btn_Print_Image.TabIndex = 0;
            this.Btn_Print_Image.UseVisualStyleBackColor = true;
            this.Btn_Print_Image.Click += this.Btn_Print_Image_Click;
            // 
            // GB_Settings
            // 
            this.GB_Settings.Controls.Add(this.TLP_Features);
            this.GB_Settings.Location = new Point(510, 3);
            this.GB_Settings.Margin = new Padding(4, 3, 4, 3);
            this.GB_Settings.Name = "GB_Settings";
            this.GB_Settings.Padding = new Padding(4, 3, 4, 3);
            this.GB_Settings.Size = new Size(83, 113);
            this.GB_Settings.TabIndex = 4;
            this.GB_Settings.TabStop = false;
            this.GB_Settings.Text = "Features";
            // 
            // TLP_Features
            // 
            this.TLP_Features.ColumnCount = 3;
            this.TLP_Features.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            this.TLP_Features.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
            this.TLP_Features.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            this.TLP_Features.Controls.Add(this.Btn_Features, 1, 1);
            this.TLP_Features.Controls.Add(this.label8, 0, 2);
            this.TLP_Features.Controls.Add(this.label9, 0, 2);
            this.TLP_Features.Dock = DockStyle.Fill;
            this.TLP_Features.Location = new Point(4, 19);
            this.TLP_Features.Name = "TLP_Features";
            this.TLP_Features.RowCount = 3;
            this.TLP_Features.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            this.TLP_Features.RowStyles.Add(new RowStyle(SizeType.Percent, 60F));
            this.TLP_Features.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            this.TLP_Features.Size = new Size(75, 91);
            this.TLP_Features.TabIndex = 0;
            // 
            // Btn_Features
            // 
            this.Btn_Features.BackgroundImage = Properties.Resources.features;
            this.Btn_Features.BackgroundImageLayout = ImageLayout.Stretch;
            this.Btn_Features.Dock = DockStyle.Fill;
            this.Btn_Features.FlatAppearance.BorderSize = 0;
            this.Btn_Features.FlatStyle = FlatStyle.Flat;
            this.Btn_Features.Location = new Point(11, 21);
            this.Btn_Features.Margin = new Padding(4, 3, 4, 3);
            this.Btn_Features.Name = "Btn_Features";
            this.Btn_Features.Size = new Size(52, 48);
            this.Btn_Features.TabIndex = 4;
            this.Btn_Features.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.Dock = DockStyle.Fill;
            this.label8.Location = new Point(11, 72);
            this.label8.Margin = new Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new Size(52, 19);
            this.label8.TabIndex = 5;
            this.label8.Text = "Features";
            this.label8.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.Location = new Point(3, 72);
            this.label9.Name = "label9";
            this.label9.Size = new Size(1, 19);
            this.label9.TabIndex = 0;
            // 
            // TP_Prologue
            // 
            this.TP_Prologue.BackColor = SystemColors.Control;
            this.TP_Prologue.Controls.Add(this.FLP_Prologue);
            this.TP_Prologue.Location = new Point(4, 44);
            this.TP_Prologue.Margin = new Padding(4, 3, 4, 3);
            this.TP_Prologue.Name = "TP_Prologue";
            this.TP_Prologue.Padding = new Padding(4, 3, 4, 3);
            this.TP_Prologue.Size = new Size(1089, 123);
            this.TP_Prologue.TabIndex = 0;
            this.TP_Prologue.Text = "Prologue";
            // 
            // FLP_Prologue
            // 
            this.FLP_Prologue.Controls.Add(this.GB_Paste_Box);
            this.FLP_Prologue.Controls.Add(this.GB_Image_Area);
            this.FLP_Prologue.Controls.Add(this.GB_Shape_Features);
            this.FLP_Prologue.Controls.Add(this.GB_Tools);
            this.FLP_Prologue.Controls.Add(this.GB_Shapes);
            this.FLP_Prologue.Controls.Add(this.GB_Colors);
            this.FLP_Prologue.Dock = DockStyle.Fill;
            this.FLP_Prologue.Location = new Point(4, 3);
            this.FLP_Prologue.Margin = new Padding(4, 3, 4, 3);
            this.FLP_Prologue.Name = "FLP_Prologue";
            this.FLP_Prologue.Size = new Size(1081, 117);
            this.FLP_Prologue.TabIndex = 0;
            this.FLP_Prologue.WrapContents = false;
            // 
            // GB_Paste_Box
            // 
            this.GB_Paste_Box.Controls.Add(this.Btn_Paste_Area);
            this.GB_Paste_Box.Controls.Add(this.Btn_Paste_From_File);
            this.GB_Paste_Box.Location = new Point(4, 3);
            this.GB_Paste_Box.Margin = new Padding(4, 3, 4, 3);
            this.GB_Paste_Box.Name = "GB_Paste_Box";
            this.GB_Paste_Box.Padding = new Padding(4, 3, 4, 3);
            this.GB_Paste_Box.Size = new Size(106, 113);
            this.GB_Paste_Box.TabIndex = 0;
            this.GB_Paste_Box.TabStop = false;
            this.GB_Paste_Box.Text = "Paste";
            // 
            // Btn_Paste_Area
            // 
            this.Btn_Paste_Area.BackgroundImage = Properties.Resources.paste_file;
            this.Btn_Paste_Area.BackgroundImageLayout = ImageLayout.Stretch;
            this.Btn_Paste_Area.FlatAppearance.BorderSize = 0;
            this.Btn_Paste_Area.FlatStyle = FlatStyle.Flat;
            this.Btn_Paste_Area.Location = new Point(7, 42);
            this.Btn_Paste_Area.Margin = new Padding(4, 3, 4, 3);
            this.Btn_Paste_Area.Name = "Btn_Paste_Area";
            this.Btn_Paste_Area.Size = new Size(37, 37);
            this.Btn_Paste_Area.TabIndex = 0;
            this.Btn_Paste_Area.UseVisualStyleBackColor = true;
            // 
            // Btn_Paste_From_File
            // 
            this.Btn_Paste_From_File.BackgroundImage = Properties.Resources.paste_from_file;
            this.Btn_Paste_From_File.BackgroundImageLayout = ImageLayout.Stretch;
            this.Btn_Paste_From_File.FlatAppearance.BorderSize = 0;
            this.Btn_Paste_From_File.FlatStyle = FlatStyle.Flat;
            this.Btn_Paste_From_File.Location = new Point(62, 42);
            this.Btn_Paste_From_File.Margin = new Padding(4, 3, 4, 3);
            this.Btn_Paste_From_File.Name = "Btn_Paste_From_File";
            this.Btn_Paste_From_File.Size = new Size(37, 37);
            this.Btn_Paste_From_File.TabIndex = 1;
            this.Btn_Paste_From_File.UseVisualStyleBackColor = true;
            // 
            // GB_Image_Area
            // 
            this.GB_Image_Area.Controls.Add(this.TLP_Image);
            this.GB_Image_Area.Controls.Add(this.Btn_Select_Area);
            this.GB_Image_Area.Location = new Point(118, 3);
            this.GB_Image_Area.Margin = new Padding(4, 3, 4, 3);
            this.GB_Image_Area.Name = "GB_Image_Area";
            this.GB_Image_Area.Padding = new Padding(4, 3, 4, 3);
            this.GB_Image_Area.Size = new Size(140, 113);
            this.GB_Image_Area.TabIndex = 2;
            this.GB_Image_Area.TabStop = false;
            this.GB_Image_Area.Text = "Image";
            // 
            // TLP_Image
            // 
            this.TLP_Image.ColumnCount = 1;
            this.TLP_Image.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            this.TLP_Image.Controls.Add(this.Btn_Crop_Image, 0, 0);
            this.TLP_Image.Controls.Add(this.Btn_Resize_Image, 0, 1);
            this.TLP_Image.Controls.Add(this.Btn_Rotate_Image, 0, 2);
            this.TLP_Image.Location = new Point(51, 14);
            this.TLP_Image.Margin = new Padding(4, 3, 4, 3);
            this.TLP_Image.Name = "TLP_Image";
            this.TLP_Image.RowCount = 3;
            this.TLP_Image.RowStyles.Add(new RowStyle(SizeType.Percent, 33.33F));
            this.TLP_Image.RowStyles.Add(new RowStyle(SizeType.Percent, 33.34F));
            this.TLP_Image.RowStyles.Add(new RowStyle(SizeType.Percent, 33.33F));
            this.TLP_Image.Size = new Size(82, 92);
            this.TLP_Image.TabIndex = 1;
            // 
            // Btn_Crop_Image
            // 
            this.Btn_Crop_Image.BackgroundImageLayout = ImageLayout.Stretch;
            this.Btn_Crop_Image.Dock = DockStyle.Fill;
            this.Btn_Crop_Image.FlatAppearance.BorderSize = 0;
            this.Btn_Crop_Image.FlatStyle = FlatStyle.Flat;
            this.Btn_Crop_Image.Image = Properties.Resources.crop_image;
            this.Btn_Crop_Image.ImageAlign = ContentAlignment.MiddleLeft;
            this.Btn_Crop_Image.Location = new Point(4, 3);
            this.Btn_Crop_Image.Margin = new Padding(4, 3, 4, 3);
            this.Btn_Crop_Image.Name = "Btn_Crop_Image";
            this.Btn_Crop_Image.Size = new Size(74, 24);
            this.Btn_Crop_Image.TabIndex = 2;
            this.Btn_Crop_Image.Text = "Crop";
            this.Btn_Crop_Image.TextAlign = ContentAlignment.MiddleRight;
            this.Btn_Crop_Image.UseVisualStyleBackColor = true;
            // 
            // Btn_Resize_Image
            // 
            this.Btn_Resize_Image.BackgroundImageLayout = ImageLayout.None;
            this.Btn_Resize_Image.Dock = DockStyle.Fill;
            this.Btn_Resize_Image.FlatAppearance.BorderSize = 0;
            this.Btn_Resize_Image.FlatStyle = FlatStyle.Flat;
            this.Btn_Resize_Image.Image = Properties.Resources.resize_image;
            this.Btn_Resize_Image.ImageAlign = ContentAlignment.MiddleLeft;
            this.Btn_Resize_Image.Location = new Point(4, 33);
            this.Btn_Resize_Image.Margin = new Padding(4, 3, 4, 3);
            this.Btn_Resize_Image.Name = "Btn_Resize_Image";
            this.Btn_Resize_Image.Size = new Size(74, 24);
            this.Btn_Resize_Image.TabIndex = 3;
            this.Btn_Resize_Image.Text = "Resize";
            this.Btn_Resize_Image.TextAlign = ContentAlignment.MiddleRight;
            this.Btn_Resize_Image.UseVisualStyleBackColor = true;
            this.Btn_Resize_Image.Click += this.Resize_Modal_Show;
            // 
            // Btn_Rotate_Image
            // 
            this.Btn_Rotate_Image.BackgroundImageLayout = ImageLayout.Stretch;
            this.Btn_Rotate_Image.Dock = DockStyle.Fill;
            this.Btn_Rotate_Image.FlatAppearance.BorderSize = 0;
            this.Btn_Rotate_Image.FlatStyle = FlatStyle.Flat;
            this.Btn_Rotate_Image.Image = Properties.Resources.rotate_image;
            this.Btn_Rotate_Image.ImageAlign = ContentAlignment.MiddleLeft;
            this.Btn_Rotate_Image.Location = new Point(4, 63);
            this.Btn_Rotate_Image.Margin = new Padding(4, 3, 4, 3);
            this.Btn_Rotate_Image.Name = "Btn_Rotate_Image";
            this.Btn_Rotate_Image.Size = new Size(74, 26);
            this.Btn_Rotate_Image.TabIndex = 4;
            this.Btn_Rotate_Image.Text = "Rotate";
            this.Btn_Rotate_Image.TextAlign = ContentAlignment.MiddleRight;
            this.Btn_Rotate_Image.UseVisualStyleBackColor = true;
            this.Btn_Rotate_Image.Click += this.Btn_Rotate_Image_Click;
            // 
            // Btn_Select_Area
            // 
            this.Btn_Select_Area.BackgroundImage = Properties.Resources.selection;
            this.Btn_Select_Area.BackgroundImageLayout = ImageLayout.Stretch;
            this.Btn_Select_Area.FlatAppearance.BorderSize = 0;
            this.Btn_Select_Area.FlatStyle = FlatStyle.Flat;
            this.Btn_Select_Area.Location = new Point(7, 42);
            this.Btn_Select_Area.Margin = new Padding(4, 3, 4, 3);
            this.Btn_Select_Area.Name = "Btn_Select_Area";
            this.Btn_Select_Area.Size = new Size(37, 37);
            this.Btn_Select_Area.TabIndex = 0;
            this.Btn_Select_Area.Tag = "Select_Area";
            this.Btn_Select_Area.UseVisualStyleBackColor = true;
            this.Btn_Select_Area.Click += this.Select_Tool;
            // 
            // GB_Shape_Features
            // 
            this.GB_Shape_Features.Controls.Add(this.TBL_Shape_Features);
            this.GB_Shape_Features.Location = new Point(266, 3);
            this.GB_Shape_Features.Margin = new Padding(4, 3, 4, 3);
            this.GB_Shape_Features.Name = "GB_Shape_Features";
            this.GB_Shape_Features.Padding = new Padding(4, 3, 4, 3);
            this.GB_Shape_Features.Size = new Size(213, 113);
            this.GB_Shape_Features.TabIndex = 3;
            this.GB_Shape_Features.TabStop = false;
            this.GB_Shape_Features.Text = "RegularShape Features";
            // 
            // TBL_Shape_Features
            // 
            this.TBL_Shape_Features.ColumnCount = 2;
            this.TBL_Shape_Features.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 63F));
            this.TBL_Shape_Features.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            this.TBL_Shape_Features.Controls.Add(this.label14, 0, 0);
            this.TBL_Shape_Features.Controls.Add(this.CB_Shape_Border, 1, 0);
            this.TBL_Shape_Features.Controls.Add(this.label16, 0, 1);
            this.TBL_Shape_Features.Controls.Add(this.CB_Shape_Fill, 1, 1);
            this.TBL_Shape_Features.Location = new Point(8, 27);
            this.TBL_Shape_Features.Margin = new Padding(4, 3, 4, 3);
            this.TBL_Shape_Features.Name = "TBL_Shape_Features";
            this.TBL_Shape_Features.RowCount = 2;
            this.TBL_Shape_Features.RowStyles.Add(new RowStyle(SizeType.Percent, 33.33F));
            this.TBL_Shape_Features.RowStyles.Add(new RowStyle(SizeType.Percent, 33.34F));
            this.TBL_Shape_Features.Size = new Size(197, 63);
            this.TBL_Shape_Features.TabIndex = 1;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Dock = DockStyle.Fill;
            this.label14.Location = new Point(3, 0);
            this.label14.Name = "label14";
            this.label14.Size = new Size(57, 31);
            this.label14.TabIndex = 5;
            this.label14.Text = "FontSize";
            this.label14.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // CB_Shape_Border
            // 
            this.CB_Shape_Border.Dock = DockStyle.Fill;
            this.CB_Shape_Border.FlatStyle = FlatStyle.Flat;
            this.CB_Shape_Border.FormattingEnabled = true;
            this.CB_Shape_Border.Items.AddRange(new object[] { "Very Little", "Smaller", "Small", "Normal", "Big", "Bigger", "Huge" });
            this.CB_Shape_Border.Location = new Point(66, 3);
            this.CB_Shape_Border.Name = "CB_Shape_Border";
            this.CB_Shape_Border.Size = new Size(128, 23);
            this.CB_Shape_Border.TabIndex = 8;
            this.CB_Shape_Border.SelectedIndexChanged += this.CB_Shape_Corner_SelectedIndexChanged;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Dock = DockStyle.Fill;
            this.label16.Location = new Point(3, 31);
            this.label16.Name = "label16";
            this.label16.Size = new Size(57, 32);
            this.label16.TabIndex = 7;
            this.label16.Text = "Fill";
            this.label16.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // CB_Shape_Fill
            // 
            this.CB_Shape_Fill.Dock = DockStyle.Fill;
            this.CB_Shape_Fill.FlatStyle = FlatStyle.Flat;
            this.CB_Shape_Fill.FormattingEnabled = true;
            this.CB_Shape_Fill.Items.AddRange(new object[] { "No Fill", "Solid TargetColor" });
            this.CB_Shape_Fill.Location = new Point(66, 34);
            this.CB_Shape_Fill.Name = "CB_Shape_Fill";
            this.CB_Shape_Fill.Size = new Size(128, 23);
            this.CB_Shape_Fill.TabIndex = 10;
            this.CB_Shape_Fill.SelectedIndexChanged += this.CB_Shape_Fill_SelectedIndexChanged;
            // 
            // GB_Tools
            // 
            this.GB_Tools.Controls.Add(this.TLP_Tools);
            this.GB_Tools.Location = new Point(487, 3);
            this.GB_Tools.Margin = new Padding(4, 3, 4, 3);
            this.GB_Tools.Name = "GB_Tools";
            this.GB_Tools.Padding = new Padding(4, 3, 4, 3);
            this.GB_Tools.Size = new Size(148, 113);
            this.GB_Tools.TabIndex = 3;
            this.GB_Tools.TabStop = false;
            this.GB_Tools.Text = "Tools";
            // 
            // TLP_Tools
            // 
            this.TLP_Tools.ColumnCount = 3;
            this.TLP_Tools.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33F));
            this.TLP_Tools.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.34F));
            this.TLP_Tools.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33F));
            this.TLP_Tools.Controls.Add(this.Btn_Erase, 0, 1);
            this.TLP_Tools.Controls.Add(this.Btn_Color_Picker, 0, 1);
            this.TLP_Tools.Controls.Add(this.Btn_Pen, 0, 0);
            this.TLP_Tools.Controls.Add(this.Btn_Zoom, 0, 1);
            this.TLP_Tools.Controls.Add(this.Btn_Paint_All, 1, 0);
            this.TLP_Tools.Controls.Add(this.Btn_Add_Text, 2, 0);
            this.TLP_Tools.Location = new Point(7, 14);
            this.TLP_Tools.Margin = new Padding(4, 3, 4, 3);
            this.TLP_Tools.Name = "TLP_Tools";
            this.TLP_Tools.RowCount = 2;
            this.TLP_Tools.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            this.TLP_Tools.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            this.TLP_Tools.RowStyles.Add(new RowStyle(SizeType.Absolute, 23F));
            this.TLP_Tools.Size = new Size(133, 92);
            this.TLP_Tools.TabIndex = 1;
            // 
            // Btn_Erase
            // 
            this.Btn_Erase.BackgroundImageLayout = ImageLayout.Stretch;
            this.Btn_Erase.FlatAppearance.BorderSize = 0;
            this.Btn_Erase.FlatStyle = FlatStyle.Flat;
            this.Btn_Erase.Image = Properties.Resources.eraser;
            this.Btn_Erase.Location = new Point(6, 52);
            this.Btn_Erase.Margin = new Padding(6);
            this.Btn_Erase.Name = "Btn_Erase";
            this.Btn_Erase.Size = new Size(32, 34);
            this.Btn_Erase.TabIndex = 7;
            this.Btn_Erase.Tag = "Eraser";
            this.Btn_Erase.TextAlign = ContentAlignment.TopCenter;
            this.Btn_Erase.UseVisualStyleBackColor = true;
            this.Btn_Erase.Click += this.Select_Tool;
            // 
            // Btn_Color_Picker
            // 
            this.Btn_Color_Picker.BackgroundImageLayout = ImageLayout.Stretch;
            this.Btn_Color_Picker.FlatAppearance.BorderSize = 0;
            this.Btn_Color_Picker.FlatStyle = FlatStyle.Flat;
            this.Btn_Color_Picker.Image = Properties.Resources.color_picker;
            this.Btn_Color_Picker.Location = new Point(50, 52);
            this.Btn_Color_Picker.Margin = new Padding(6);
            this.Btn_Color_Picker.Name = "Btn_Color_Picker";
            this.Btn_Color_Picker.Size = new Size(32, 34);
            this.Btn_Color_Picker.TabIndex = 6;
            this.Btn_Color_Picker.Tag = "Color_Picker";
            this.Btn_Color_Picker.TextAlign = ContentAlignment.TopCenter;
            this.Btn_Color_Picker.UseVisualStyleBackColor = true;
            this.Btn_Color_Picker.Click += this.Select_Tool;
            // 
            // Btn_Pen
            // 
            this.Btn_Pen.BackgroundImageLayout = ImageLayout.Center;
            this.Btn_Pen.FlatAppearance.BorderSize = 0;
            this.Btn_Pen.FlatStyle = FlatStyle.Flat;
            this.Btn_Pen.Image = Properties.Resources.pen;
            this.Btn_Pen.Location = new Point(6, 6);
            this.Btn_Pen.Margin = new Padding(6);
            this.Btn_Pen.Name = "Btn_Pen";
            this.Btn_Pen.Size = new Size(32, 34);
            this.Btn_Pen.TabIndex = 2;
            this.Btn_Pen.Tag = "Pen";
            this.Btn_Pen.TextAlign = ContentAlignment.TopCenter;
            this.Btn_Pen.UseVisualStyleBackColor = true;
            this.Btn_Pen.Click += this.Select_Tool;
            // 
            // Btn_Zoom
            // 
            this.Btn_Zoom.BackgroundImageLayout = ImageLayout.Stretch;
            this.Btn_Zoom.FlatAppearance.BorderSize = 0;
            this.Btn_Zoom.FlatStyle = FlatStyle.Flat;
            this.Btn_Zoom.Image = Properties.Resources.zoom_general;
            this.Btn_Zoom.Location = new Point(92, 49);
            this.Btn_Zoom.Margin = new Padding(4, 3, 4, 3);
            this.Btn_Zoom.Name = "Btn_Zoom";
            this.Btn_Zoom.Size = new Size(37, 37);
            this.Btn_Zoom.TabIndex = 3;
            this.Btn_Zoom.Tag = "Zoom";
            this.Btn_Zoom.UseVisualStyleBackColor = true;
            this.Btn_Zoom.Click += this.Select_Tool;
            // 
            // Btn_Paint_All
            // 
            this.Btn_Paint_All.BackColor = SystemColors.Control;
            this.Btn_Paint_All.BackgroundImageLayout = ImageLayout.Center;
            this.Btn_Paint_All.FlatAppearance.BorderSize = 0;
            this.Btn_Paint_All.FlatStyle = FlatStyle.Flat;
            this.Btn_Paint_All.Image = Properties.Resources.paint_image;
            this.Btn_Paint_All.Location = new Point(50, 6);
            this.Btn_Paint_All.Margin = new Padding(6);
            this.Btn_Paint_All.Name = "Btn_Paint_All";
            this.Btn_Paint_All.Size = new Size(32, 34);
            this.Btn_Paint_All.TabIndex = 4;
            this.Btn_Paint_All.Tag = "Filler";
            this.Btn_Paint_All.TextAlign = ContentAlignment.TopCenter;
            this.Btn_Paint_All.UseVisualStyleBackColor = false;
            this.Btn_Paint_All.Click += this.Select_Tool;
            // 
            // Btn_Add_Text
            // 
            this.Btn_Add_Text.BackgroundImageLayout = ImageLayout.Stretch;
            this.Btn_Add_Text.FlatAppearance.BorderSize = 0;
            this.Btn_Add_Text.FlatStyle = FlatStyle.Flat;
            this.Btn_Add_Text.Image = Properties.Resources.text;
            this.Btn_Add_Text.Location = new Point(94, 6);
            this.Btn_Add_Text.Margin = new Padding(6);
            this.Btn_Add_Text.Name = "Btn_Add_Text";
            this.Btn_Add_Text.Size = new Size(33, 34);
            this.Btn_Add_Text.TabIndex = 5;
            this.Btn_Add_Text.Tag = "Text";
            this.Btn_Add_Text.TextAlign = ContentAlignment.TopCenter;
            this.Btn_Add_Text.UseVisualStyleBackColor = true;
            this.Btn_Add_Text.Click += this.Select_Tool;
            // 
            // GB_Shapes
            // 
            this.GB_Shapes.Controls.Add(this.TC_Shape);
            this.GB_Shapes.Location = new Point(643, 3);
            this.GB_Shapes.Margin = new Padding(4, 3, 4, 3);
            this.GB_Shapes.Name = "GB_Shapes";
            this.GB_Shapes.Padding = new Padding(4, 3, 4, 3);
            this.GB_Shapes.Size = new Size(208, 113);
            this.GB_Shapes.TabIndex = 4;
            this.GB_Shapes.TabStop = false;
            this.GB_Shapes.Text = "Shapes";
            // 
            // TC_Shape
            // 
            this.TC_Shape.Controls.Add(this.TC_Shape_Page_1);
            this.TC_Shape.Controls.Add(this.TC_Shape_Page_2);
            this.TC_Shape.Dock = DockStyle.Fill;
            this.TC_Shape.ItemSize = new Size(26, 20);
            this.TC_Shape.Location = new Point(4, 19);
            this.TC_Shape.Name = "TC_Shape";
            this.TC_Shape.SelectedIndex = 0;
            this.TC_Shape.Size = new Size(200, 91);
            this.TC_Shape.SizeMode = TabSizeMode.Fixed;
            this.TC_Shape.TabIndex = 0;
            // 
            // TC_Shape_Page_1
            // 
            this.TC_Shape_Page_1.BackColor = SystemColors.Control;
            this.TC_Shape_Page_1.Controls.Add(this.FLP_Shape_Page_1);
            this.TC_Shape_Page_1.Location = new Point(4, 24);
            this.TC_Shape_Page_1.Name = "TC_Shape_Page_1";
            this.TC_Shape_Page_1.Padding = new Padding(3);
            this.TC_Shape_Page_1.Size = new Size(192, 63);
            this.TC_Shape_Page_1.TabIndex = 0;
            this.TC_Shape_Page_1.Text = "1";
            // 
            // FLP_Shape_Page_1
            // 
            this.FLP_Shape_Page_1.Controls.Add(this.PB_Circle);
            this.FLP_Shape_Page_1.Controls.Add(this.PB_Square);
            this.FLP_Shape_Page_1.Controls.Add(this.PB_Rounded_Rectangle);
            this.FLP_Shape_Page_1.Controls.Add(this.PB_Rectangle);
            this.FLP_Shape_Page_1.Controls.Add(this.PB_Parallelogram);
            this.FLP_Shape_Page_1.Controls.Add(this.PB_Trapezoid);
            this.FLP_Shape_Page_1.Controls.Add(this.PB_Diamond);
            this.FLP_Shape_Page_1.Controls.Add(this.PB_Right_Arrow);
            this.FLP_Shape_Page_1.Controls.Add(this.PB_Left_Arrow);
            this.FLP_Shape_Page_1.Controls.Add(this.PB_Six_Pointed_Star);
            this.FLP_Shape_Page_1.Controls.Add(this.PB_Star);
            this.FLP_Shape_Page_1.Controls.Add(this.PB_Four_Pointed_Star);
            this.FLP_Shape_Page_1.Controls.Add(this.PB_Hexagon);
            this.FLP_Shape_Page_1.Controls.Add(this.O);
            this.FLP_Shape_Page_1.Dock = DockStyle.Fill;
            this.FLP_Shape_Page_1.Location = new Point(3, 3);
            this.FLP_Shape_Page_1.Name = "FLP_Shape_Page_1";
            this.FLP_Shape_Page_1.Size = new Size(186, 57);
            this.FLP_Shape_Page_1.TabIndex = 0;
            // 
            // PB_Circle
            // 
            this.PB_Circle.Image = Properties.Resources.shape_circle;
            this.PB_Circle.Location = new Point(3, 3);
            this.PB_Circle.Name = "PB_Circle";
            this.PB_Circle.Size = new Size(20, 20);
            this.PB_Circle.SizeMode = PictureBoxSizeMode.StretchImage;
            this.PB_Circle.TabIndex = 5;
            this.PB_Circle.TabStop = false;
            this.PB_Circle.Tag = "Circle";
            this.PB_Circle.Click += this.Select_Shape;
            // 
            // PB_Square
            // 
            this.PB_Square.Image = Properties.Resources.shape_square;
            this.PB_Square.Location = new Point(29, 3);
            this.PB_Square.Name = "PB_Square";
            this.PB_Square.Size = new Size(20, 20);
            this.PB_Square.SizeMode = PictureBoxSizeMode.StretchImage;
            this.PB_Square.TabIndex = 0;
            this.PB_Square.TabStop = false;
            this.PB_Square.Tag = "Square";
            this.PB_Square.Click += this.Select_Shape;
            // 
            // PB_Rounded_Rectangle
            // 
            this.PB_Rounded_Rectangle.Image = Properties.Resources.shape_rectangle;
            this.PB_Rounded_Rectangle.Location = new Point(55, 3);
            this.PB_Rounded_Rectangle.Name = "PB_Rounded_Rectangle";
            this.PB_Rounded_Rectangle.Size = new Size(20, 20);
            this.PB_Rounded_Rectangle.SizeMode = PictureBoxSizeMode.StretchImage;
            this.PB_Rounded_Rectangle.TabIndex = 18;
            this.PB_Rounded_Rectangle.TabStop = false;
            this.PB_Rounded_Rectangle.Tag = "RoundedRectangle";
            this.PB_Rounded_Rectangle.Click += this.Select_Shape;
            // 
            // PB_Rectangle
            // 
            this.PB_Rectangle.Image = Properties.Resources.shape_rectangle;
            this.PB_Rectangle.Location = new Point(81, 3);
            this.PB_Rectangle.Name = "PB_Rectangle";
            this.PB_Rectangle.Size = new Size(20, 20);
            this.PB_Rectangle.SizeMode = PictureBoxSizeMode.StretchImage;
            this.PB_Rectangle.TabIndex = 1;
            this.PB_Rectangle.TabStop = false;
            this.PB_Rectangle.Tag = "Rectangle";
            this.PB_Rectangle.Click += this.Select_Shape;
            // 
            // PB_Parallelogram
            // 
            this.PB_Parallelogram.Image = Properties.Resources.shape_parallelogram;
            this.PB_Parallelogram.Location = new Point(107, 3);
            this.PB_Parallelogram.Name = "PB_Parallelogram";
            this.PB_Parallelogram.Size = new Size(20, 20);
            this.PB_Parallelogram.SizeMode = PictureBoxSizeMode.StretchImage;
            this.PB_Parallelogram.TabIndex = 9;
            this.PB_Parallelogram.TabStop = false;
            this.PB_Parallelogram.Tag = "Parallelogram";
            this.PB_Parallelogram.Click += this.Select_Shape;
            // 
            // PB_Trapezoid
            // 
            this.PB_Trapezoid.Image = Properties.Resources.shape_trapezoid;
            this.PB_Trapezoid.Location = new Point(133, 3);
            this.PB_Trapezoid.Name = "PB_Trapezoid";
            this.PB_Trapezoid.Size = new Size(20, 20);
            this.PB_Trapezoid.SizeMode = PictureBoxSizeMode.StretchImage;
            this.PB_Trapezoid.TabIndex = 10;
            this.PB_Trapezoid.TabStop = false;
            this.PB_Trapezoid.Tag = "Trapezoid";
            this.PB_Trapezoid.Click += this.Select_Shape;
            // 
            // PB_Diamond
            // 
            this.PB_Diamond.Image = Properties.Resources.shape_diamond;
            this.PB_Diamond.Location = new Point(159, 3);
            this.PB_Diamond.Name = "PB_Diamond";
            this.PB_Diamond.Size = new Size(20, 20);
            this.PB_Diamond.SizeMode = PictureBoxSizeMode.StretchImage;
            this.PB_Diamond.TabIndex = 3;
            this.PB_Diamond.TabStop = false;
            this.PB_Diamond.Tag = "Diamond";
            this.PB_Diamond.Click += this.Select_Shape;
            // 
            // PB_Right_Arrow
            // 
            this.PB_Right_Arrow.Image = Properties.Resources.shape_right_arrow;
            this.PB_Right_Arrow.Location = new Point(3, 29);
            this.PB_Right_Arrow.Name = "PB_Right_Arrow";
            this.PB_Right_Arrow.Size = new Size(20, 20);
            this.PB_Right_Arrow.SizeMode = PictureBoxSizeMode.StretchImage;
            this.PB_Right_Arrow.TabIndex = 13;
            this.PB_Right_Arrow.TabStop = false;
            this.PB_Right_Arrow.Tag = "RightArrow";
            this.PB_Right_Arrow.Click += this.Select_Shape;
            // 
            // PB_Left_Arrow
            // 
            this.PB_Left_Arrow.Image = Properties.Resources.shape_left_arrow;
            this.PB_Left_Arrow.Location = new Point(29, 29);
            this.PB_Left_Arrow.Name = "PB_Left_Arrow";
            this.PB_Left_Arrow.Size = new Size(20, 20);
            this.PB_Left_Arrow.SizeMode = PictureBoxSizeMode.StretchImage;
            this.PB_Left_Arrow.TabIndex = 12;
            this.PB_Left_Arrow.TabStop = false;
            this.PB_Left_Arrow.Tag = "LeftArrow";
            this.PB_Left_Arrow.Click += this.Select_Shape;
            // 
            // PB_Six_Pointed_Star
            // 
            this.PB_Six_Pointed_Star.Image = Properties.Resources.shape_six_pointed_star;
            this.PB_Six_Pointed_Star.Location = new Point(55, 29);
            this.PB_Six_Pointed_Star.Name = "PB_Six_Pointed_Star";
            this.PB_Six_Pointed_Star.Size = new Size(20, 20);
            this.PB_Six_Pointed_Star.SizeMode = PictureBoxSizeMode.StretchImage;
            this.PB_Six_Pointed_Star.TabIndex = 11;
            this.PB_Six_Pointed_Star.TabStop = false;
            this.PB_Six_Pointed_Star.Tag = "SixPointedStar";
            this.PB_Six_Pointed_Star.Click += this.Select_Shape;
            // 
            // PB_Star
            // 
            this.PB_Star.Image = Properties.Resources.shape_star;
            this.PB_Star.Location = new Point(81, 29);
            this.PB_Star.Name = "PB_Star";
            this.PB_Star.Size = new Size(20, 20);
            this.PB_Star.SizeMode = PictureBoxSizeMode.StretchImage;
            this.PB_Star.TabIndex = 4;
            this.PB_Star.TabStop = false;
            this.PB_Star.Tag = "Star";
            this.PB_Star.Click += this.Select_Shape;
            // 
            // PB_Four_Pointed_Star
            // 
            this.PB_Four_Pointed_Star.Image = Properties.Resources.shape_four_pointed_star;
            this.PB_Four_Pointed_Star.Location = new Point(107, 29);
            this.PB_Four_Pointed_Star.Name = "PB_Four_Pointed_Star";
            this.PB_Four_Pointed_Star.Size = new Size(20, 20);
            this.PB_Four_Pointed_Star.SizeMode = PictureBoxSizeMode.StretchImage;
            this.PB_Four_Pointed_Star.TabIndex = 17;
            this.PB_Four_Pointed_Star.TabStop = false;
            this.PB_Four_Pointed_Star.Tag = "FourPointedStar";
            this.PB_Four_Pointed_Star.Click += this.Select_Shape;
            // 
            // PB_Hexagon
            // 
            this.PB_Hexagon.Image = Properties.Resources.shape_hexagon;
            this.PB_Hexagon.Location = new Point(133, 29);
            this.PB_Hexagon.Name = "PB_Hexagon";
            this.PB_Hexagon.Size = new Size(20, 20);
            this.PB_Hexagon.SizeMode = PictureBoxSizeMode.StretchImage;
            this.PB_Hexagon.TabIndex = 8;
            this.PB_Hexagon.TabStop = false;
            this.PB_Hexagon.Tag = "Hexagon";
            this.PB_Hexagon.Click += this.Select_Shape;
            // 
            // O
            // 
            this.O.Image = Properties.Resources.shape_pentagon;
            this.O.Location = new Point(159, 29);
            this.O.Name = "O";
            this.O.Size = new Size(20, 20);
            this.O.SizeMode = PictureBoxSizeMode.StretchImage;
            this.O.TabIndex = 7;
            this.O.TabStop = false;
            this.O.Tag = "Pentagon";
            this.O.Click += this.Select_Shape;
            // 
            // TC_Shape_Page_2
            // 
            this.TC_Shape_Page_2.BackColor = SystemColors.Control;
            this.TC_Shape_Page_2.Controls.Add(this.FLP_Shapes);
            this.TC_Shape_Page_2.Location = new Point(4, 24);
            this.TC_Shape_Page_2.Name = "TC_Shape_Page_2";
            this.TC_Shape_Page_2.Padding = new Padding(3);
            this.TC_Shape_Page_2.Size = new Size(192, 63);
            this.TC_Shape_Page_2.TabIndex = 1;
            this.TC_Shape_Page_2.Text = "2";
            // 
            // FLP_Shapes
            // 
            this.FLP_Shapes.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            this.FLP_Shapes.Controls.Add(this.PB_Triangle);
            this.FLP_Shapes.Controls.Add(this.PB_Left_Triangle);
            this.FLP_Shapes.Controls.Add(this.PB_Right_Triangle);
            this.FLP_Shapes.Controls.Add(this.PB_Bottom_Triangle);
            this.FLP_Shapes.Controls.Add(this.PB_Cube);
            this.FLP_Shapes.Controls.Add(this.PB_Triangle_Pyramid);
            this.FLP_Shapes.Controls.Add(this.PB_Plus);
            this.FLP_Shapes.Controls.Add(this.PB_Note);
            this.FLP_Shapes.Controls.Add(this.PB_Envelope);
            this.FLP_Shapes.Controls.Add(this.PB_Eight_Pointed_Star);
            this.FLP_Shapes.Dock = DockStyle.Fill;
            this.FLP_Shapes.Location = new Point(3, 3);
            this.FLP_Shapes.Name = "FLP_Shapes";
            this.FLP_Shapes.Size = new Size(186, 57);
            this.FLP_Shapes.TabIndex = 0;
            // 
            // PB_Triangle
            // 
            this.PB_Triangle.Image = Properties.Resources.shape_triangle;
            this.PB_Triangle.Location = new Point(3, 3);
            this.PB_Triangle.Name = "PB_Triangle";
            this.PB_Triangle.Size = new Size(20, 20);
            this.PB_Triangle.SizeMode = PictureBoxSizeMode.StretchImage;
            this.PB_Triangle.TabIndex = 2;
            this.PB_Triangle.TabStop = false;
            this.PB_Triangle.Tag = "Triangle";
            this.PB_Triangle.Click += this.Select_Shape;
            // 
            // PB_Left_Triangle
            // 
            this.PB_Left_Triangle.Image = Properties.Resources.shape_left_triangle;
            this.PB_Left_Triangle.Location = new Point(29, 3);
            this.PB_Left_Triangle.Name = "PB_Left_Triangle";
            this.PB_Left_Triangle.Size = new Size(20, 20);
            this.PB_Left_Triangle.SizeMode = PictureBoxSizeMode.StretchImage;
            this.PB_Left_Triangle.TabIndex = 15;
            this.PB_Left_Triangle.TabStop = false;
            this.PB_Left_Triangle.Tag = "LeftTriangle";
            this.PB_Left_Triangle.Click += this.Select_Shape;
            // 
            // PB_Right_Triangle
            // 
            this.PB_Right_Triangle.Image = Properties.Resources.shape_right_triangle;
            this.PB_Right_Triangle.Location = new Point(55, 3);
            this.PB_Right_Triangle.Name = "PB_Right_Triangle";
            this.PB_Right_Triangle.Size = new Size(20, 20);
            this.PB_Right_Triangle.SizeMode = PictureBoxSizeMode.StretchImage;
            this.PB_Right_Triangle.TabIndex = 16;
            this.PB_Right_Triangle.TabStop = false;
            this.PB_Right_Triangle.Tag = "RightTriangle";
            this.PB_Right_Triangle.Click += this.Select_Shape;
            // 
            // PB_Bottom_Triangle
            // 
            this.PB_Bottom_Triangle.Image = Properties.Resources.shape_bottom_triangle;
            this.PB_Bottom_Triangle.Location = new Point(81, 3);
            this.PB_Bottom_Triangle.Name = "PB_Bottom_Triangle";
            this.PB_Bottom_Triangle.Size = new Size(20, 20);
            this.PB_Bottom_Triangle.SizeMode = PictureBoxSizeMode.StretchImage;
            this.PB_Bottom_Triangle.TabIndex = 14;
            this.PB_Bottom_Triangle.TabStop = false;
            this.PB_Bottom_Triangle.Tag = "BottomTriangle";
            this.PB_Bottom_Triangle.Click += this.Select_Shape;
            // 
            // PB_Cube
            // 
            this.PB_Cube.Image = Properties.Resources.shape_cube;
            this.PB_Cube.Location = new Point(107, 3);
            this.PB_Cube.Name = "PB_Cube";
            this.PB_Cube.Size = new Size(20, 20);
            this.PB_Cube.SizeMode = PictureBoxSizeMode.StretchImage;
            this.PB_Cube.TabIndex = 6;
            this.PB_Cube.TabStop = false;
            this.PB_Cube.Tag = "Cube";
            this.PB_Cube.Click += this.Select_Shape;
            // 
            // PB_Triangle_Pyramid
            // 
            this.PB_Triangle_Pyramid.Image = Properties.Resources.shape_triangle_pyramid;
            this.PB_Triangle_Pyramid.Location = new Point(133, 3);
            this.PB_Triangle_Pyramid.Name = "PB_Triangle_Pyramid";
            this.PB_Triangle_Pyramid.Size = new Size(20, 20);
            this.PB_Triangle_Pyramid.SizeMode = PictureBoxSizeMode.StretchImage;
            this.PB_Triangle_Pyramid.TabIndex = 19;
            this.PB_Triangle_Pyramid.TabStop = false;
            this.PB_Triangle_Pyramid.Tag = "TrianglePyramid";
            this.PB_Triangle_Pyramid.Click += this.Select_Shape;
            // 
            // PB_Plus
            // 
            this.PB_Plus.Image = Properties.Resources.shape_plus;
            this.PB_Plus.Location = new Point(159, 3);
            this.PB_Plus.Name = "PB_Plus";
            this.PB_Plus.Size = new Size(20, 20);
            this.PB_Plus.SizeMode = PictureBoxSizeMode.StretchImage;
            this.PB_Plus.TabIndex = 20;
            this.PB_Plus.TabStop = false;
            this.PB_Plus.Tag = "Plus";
            this.PB_Plus.Click += this.Select_Shape;
            // 
            // PB_Note
            // 
            this.PB_Note.Image = Properties.Resources.shape_note;
            this.PB_Note.Location = new Point(3, 29);
            this.PB_Note.Name = "PB_Note";
            this.PB_Note.Size = new Size(20, 20);
            this.PB_Note.SizeMode = PictureBoxSizeMode.StretchImage;
            this.PB_Note.TabIndex = 21;
            this.PB_Note.TabStop = false;
            this.PB_Note.Tag = "Note";
            this.PB_Note.Click += this.Select_Shape;
            // 
            // PB_Envelope
            // 
            this.PB_Envelope.Image = Properties.Resources.shape_envelope;
            this.PB_Envelope.Location = new Point(29, 29);
            this.PB_Envelope.Name = "PB_Envelope";
            this.PB_Envelope.Size = new Size(20, 20);
            this.PB_Envelope.SizeMode = PictureBoxSizeMode.StretchImage;
            this.PB_Envelope.TabIndex = 22;
            this.PB_Envelope.TabStop = false;
            this.PB_Envelope.Tag = "Envelope";
            this.PB_Envelope.Click += this.Select_Shape;
            // 
            // PB_Eight_Pointed_Star
            // 
            this.PB_Eight_Pointed_Star.Image = Properties.Resources.shape_eight_pointed_star;
            this.PB_Eight_Pointed_Star.Location = new Point(55, 29);
            this.PB_Eight_Pointed_Star.Name = "PB_Eight_Pointed_Star";
            this.PB_Eight_Pointed_Star.Size = new Size(20, 20);
            this.PB_Eight_Pointed_Star.SizeMode = PictureBoxSizeMode.StretchImage;
            this.PB_Eight_Pointed_Star.TabIndex = 23;
            this.PB_Eight_Pointed_Star.TabStop = false;
            this.PB_Eight_Pointed_Star.Tag = "EightPointedStar";
            this.PB_Eight_Pointed_Star.Click += this.Select_Shape;
            // 
            // GB_Colors
            // 
            this.GB_Colors.Controls.Add(this.FLP_Colors);
            this.GB_Colors.Controls.Add(this.label2);
            this.GB_Colors.Controls.Add(this.label1);
            this.GB_Colors.Controls.Add(this.Btn_Secondary_Color);
            this.GB_Colors.Controls.Add(this.Btn_Primary_Color);
            this.GB_Colors.Location = new Point(859, 3);
            this.GB_Colors.Margin = new Padding(4, 3, 4, 3);
            this.GB_Colors.Name = "GB_Colors";
            this.GB_Colors.Padding = new Padding(4, 3, 4, 3);
            this.GB_Colors.Size = new Size(367, 113);
            this.GB_Colors.TabIndex = 2;
            this.GB_Colors.TabStop = false;
            this.GB_Colors.Text = "Colors";
            // 
            // FLP_Colors
            // 
            this.FLP_Colors.AutoScroll = true;
            this.FLP_Colors.Dock = DockStyle.Right;
            this.FLP_Colors.Location = new Point(122, 19);
            this.FLP_Colors.Margin = new Padding(4, 3, 4, 3);
            this.FLP_Colors.Name = "FLP_Colors";
            this.FLP_Colors.Size = new Size(241, 91);
            this.FLP_Colors.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new Point(48, 75);
            this.label2.Margin = new Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new Size(62, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Secondary";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new Point(4, 75);
            this.label1.Margin = new Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new Size(48, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Primary";
            // 
            // Btn_Secondary_Color
            // 
            this.Btn_Secondary_Color.BackColor = Color.White;
            this.Btn_Secondary_Color.BackgroundImageLayout = ImageLayout.Stretch;
            this.Btn_Secondary_Color.FlatAppearance.BorderSize = 0;
            this.Btn_Secondary_Color.FlatStyle = FlatStyle.Flat;
            this.Btn_Secondary_Color.Location = new Point(61, 34);
            this.Btn_Secondary_Color.Margin = new Padding(4, 3, 4, 3);
            this.Btn_Secondary_Color.Name = "Btn_Secondary_Color";
            this.Btn_Secondary_Color.Size = new Size(37, 37);
            this.Btn_Secondary_Color.TabIndex = 1;
            this.Btn_Secondary_Color.Tag = "SecondaryColor";
            this.Btn_Secondary_Color.UseVisualStyleBackColor = false;
            this.Btn_Secondary_Color.Click += this.Select_Color_From_Button;
            // 
            // Btn_Primary_Color
            // 
            this.Btn_Primary_Color.BackColor = Color.Black;
            this.Btn_Primary_Color.BackgroundImageLayout = ImageLayout.Stretch;
            this.Btn_Primary_Color.FlatAppearance.BorderSize = 0;
            this.Btn_Primary_Color.FlatStyle = FlatStyle.Flat;
            this.Btn_Primary_Color.Location = new Point(8, 35);
            this.Btn_Primary_Color.Margin = new Padding(4, 3, 4, 3);
            this.Btn_Primary_Color.Name = "Btn_Primary_Color";
            this.Btn_Primary_Color.Size = new Size(37, 37);
            this.Btn_Primary_Color.TabIndex = 0;
            this.Btn_Primary_Color.Tag = "PrimaryColor";
            this.Btn_Primary_Color.TextAlign = ContentAlignment.BottomCenter;
            this.Btn_Primary_Color.TextImageRelation = TextImageRelation.TextAboveImage;
            this.Btn_Primary_Color.UseVisualStyleBackColor = false;
            this.Btn_Primary_Color.Click += this.Select_Color_From_Button;
            // 
            // TP_View
            // 
            this.TP_View.BackColor = SystemColors.Control;
            this.TP_View.Controls.Add(this.FLP_View);
            this.TP_View.Location = new Point(4, 44);
            this.TP_View.Margin = new Padding(4, 3, 4, 3);
            this.TP_View.Name = "TP_View";
            this.TP_View.Padding = new Padding(4, 3, 4, 3);
            this.TP_View.Size = new Size(1089, 123);
            this.TP_View.TabIndex = 1;
            this.TP_View.Text = "View";
            // 
            // FLP_View
            // 
            this.FLP_View.Controls.Add(this.GB_Zoom);
            this.FLP_View.Controls.Add(this.GB_Show_Or_Hide);
            this.FLP_View.Dock = DockStyle.Fill;
            this.FLP_View.Location = new Point(4, 3);
            this.FLP_View.Margin = new Padding(4, 3, 4, 3);
            this.FLP_View.Name = "FLP_View";
            this.FLP_View.Size = new Size(1081, 117);
            this.FLP_View.TabIndex = 1;
            // 
            // GB_Zoom
            // 
            this.GB_Zoom.Controls.Add(this.tableLayoutPanel1);
            this.GB_Zoom.Location = new Point(4, 3);
            this.GB_Zoom.Margin = new Padding(4, 3, 4, 3);
            this.GB_Zoom.Name = "GB_Zoom";
            this.GB_Zoom.Padding = new Padding(4, 3, 4, 3);
            this.GB_Zoom.Size = new Size(313, 113);
            this.GB_Zoom.TabIndex = 0;
            this.GB_Zoom.TabStop = false;
            this.GB_Zoom.Text = "Zoom Settings";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33F));
            this.tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.34F));
            this.tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33F));
            this.tableLayoutPanel1.Controls.Add(this.Btn_Zoom_Normal, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label4, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label5, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.Btn_Zoom_Out, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.Btn_Zoom_In, 0, 0);
            this.tableLayoutPanel1.Location = new Point(7, 22);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 70F));
            this.tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            this.tableLayoutPanel1.Size = new Size(299, 84);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // Btn_Zoom_Normal
            // 
            this.Btn_Zoom_Normal.BackgroundImage = Properties.Resources.resize_normal;
            this.Btn_Zoom_Normal.BackgroundImageLayout = ImageLayout.Center;
            this.Btn_Zoom_Normal.Dock = DockStyle.Fill;
            this.Btn_Zoom_Normal.FlatAppearance.BorderSize = 0;
            this.Btn_Zoom_Normal.FlatStyle = FlatStyle.Flat;
            this.Btn_Zoom_Normal.Location = new Point(202, 3);
            this.Btn_Zoom_Normal.Margin = new Padding(4, 3, 4, 3);
            this.Btn_Zoom_Normal.Name = "Btn_Zoom_Normal";
            this.Btn_Zoom_Normal.Size = new Size(93, 52);
            this.Btn_Zoom_Normal.TabIndex = 4;
            this.Btn_Zoom_Normal.UseVisualStyleBackColor = true;
            this.Btn_Zoom_Normal.Click += this.Btn_Zoom_Normal_Click;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = DockStyle.Fill;
            this.label3.Location = new Point(4, 58);
            this.label3.Margin = new Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new Size(91, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "Zoom-In";
            this.label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = DockStyle.Fill;
            this.label4.Location = new Point(103, 58);
            this.label4.Margin = new Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new Size(91, 26);
            this.label4.TabIndex = 3;
            this.label4.Text = "Zoom-Out";
            this.label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Dock = DockStyle.Fill;
            this.label5.Location = new Point(202, 58);
            this.label5.Margin = new Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new Size(93, 26);
            this.label5.TabIndex = 5;
            this.label5.Text = "Zoom to 100%";
            this.label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Btn_Zoom_Out
            // 
            this.Btn_Zoom_Out.BackgroundImageLayout = ImageLayout.Stretch;
            this.Btn_Zoom_Out.Dock = DockStyle.Fill;
            this.Btn_Zoom_Out.FlatAppearance.BorderSize = 0;
            this.Btn_Zoom_Out.FlatStyle = FlatStyle.Flat;
            this.Btn_Zoom_Out.Image = Properties.Resources.zoom_out;
            this.Btn_Zoom_Out.Location = new Point(103, 3);
            this.Btn_Zoom_Out.Margin = new Padding(4, 3, 4, 3);
            this.Btn_Zoom_Out.Name = "Btn_Zoom_Out";
            this.Btn_Zoom_Out.Size = new Size(91, 52);
            this.Btn_Zoom_Out.TabIndex = 1;
            this.Btn_Zoom_Out.UseVisualStyleBackColor = true;
            this.Btn_Zoom_Out.Click += this.Btn_Zoom_Out_Click;
            // 
            // Btn_Zoom_In
            // 
            this.Btn_Zoom_In.BackgroundImage = Properties.Resources.zoom_in;
            this.Btn_Zoom_In.BackgroundImageLayout = ImageLayout.Center;
            this.Btn_Zoom_In.Dock = DockStyle.Fill;
            this.Btn_Zoom_In.FlatAppearance.BorderSize = 0;
            this.Btn_Zoom_In.FlatStyle = FlatStyle.Flat;
            this.Btn_Zoom_In.Location = new Point(4, 3);
            this.Btn_Zoom_In.Margin = new Padding(4, 3, 4, 3);
            this.Btn_Zoom_In.Name = "Btn_Zoom_In";
            this.Btn_Zoom_In.Size = new Size(91, 52);
            this.Btn_Zoom_In.TabIndex = 0;
            this.Btn_Zoom_In.UseVisualStyleBackColor = true;
            this.Btn_Zoom_In.Click += this.Btn_Zoom_In_Click;
            // 
            // GB_Show_Or_Hide
            // 
            this.GB_Show_Or_Hide.Controls.Add(this.TLP_Show_And_Hide);
            this.GB_Show_Or_Hide.Location = new Point(325, 3);
            this.GB_Show_Or_Hide.Margin = new Padding(4, 3, 4, 3);
            this.GB_Show_Or_Hide.Name = "GB_Show_Or_Hide";
            this.GB_Show_Or_Hide.Padding = new Padding(4, 3, 4, 3);
            this.GB_Show_Or_Hide.Size = new Size(145, 113);
            this.GB_Show_Or_Hide.TabIndex = 2;
            this.GB_Show_Or_Hide.TabStop = false;
            this.GB_Show_Or_Hide.Text = "Show or Hide";
            // 
            // TLP_Show_And_Hide
            // 
            this.TLP_Show_And_Hide.ColumnCount = 1;
            this.TLP_Show_And_Hide.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            this.TLP_Show_And_Hide.Controls.Add(this.CB_Ruler, 0, 0);
            this.TLP_Show_And_Hide.Controls.Add(this.CB_Guidelines, 0, 1);
            this.TLP_Show_And_Hide.Controls.Add(this.CB_Status_Bar, 0, 2);
            this.TLP_Show_And_Hide.Location = new Point(7, 22);
            this.TLP_Show_And_Hide.Margin = new Padding(4, 3, 4, 3);
            this.TLP_Show_And_Hide.Name = "TLP_Show_And_Hide";
            this.TLP_Show_And_Hide.RowCount = 3;
            this.TLP_Show_And_Hide.RowStyles.Add(new RowStyle(SizeType.Percent, 33.33F));
            this.TLP_Show_And_Hide.RowStyles.Add(new RowStyle(SizeType.Percent, 33.34F));
            this.TLP_Show_And_Hide.RowStyles.Add(new RowStyle(SizeType.Percent, 33.33F));
            this.TLP_Show_And_Hide.Size = new Size(130, 84);
            this.TLP_Show_And_Hide.TabIndex = 1;
            // 
            // CB_Ruler
            // 
            this.CB_Ruler.Location = new Point(4, 3);
            this.CB_Ruler.Margin = new Padding(4, 3, 4, 3);
            this.CB_Ruler.Name = "CB_Ruler";
            this.CB_Ruler.Size = new Size(122, 21);
            this.CB_Ruler.TabIndex = 0;
            this.CB_Ruler.Text = "Ruler";
            this.CB_Ruler.UseVisualStyleBackColor = true;
            this.CB_Ruler.CheckedChanged += this.CB_Ruler_CheckedChanged;
            // 
            // CB_Guidelines
            // 
            this.CB_Guidelines.Location = new Point(4, 30);
            this.CB_Guidelines.Margin = new Padding(4, 3, 4, 3);
            this.CB_Guidelines.Name = "CB_Guidelines";
            this.CB_Guidelines.Size = new Size(122, 21);
            this.CB_Guidelines.TabIndex = 1;
            this.CB_Guidelines.Text = "Grid Lines";
            this.CB_Guidelines.UseVisualStyleBackColor = true;
            this.CB_Guidelines.CheckedChanged += this.CB_Guidelines_CheckedChanged;
            // 
            // CB_Status_Bar
            // 
            this.CB_Status_Bar.Checked = true;
            this.CB_Status_Bar.CheckState = CheckState.Checked;
            this.CB_Status_Bar.Location = new Point(4, 58);
            this.CB_Status_Bar.Margin = new Padding(4, 3, 4, 3);
            this.CB_Status_Bar.Name = "CB_Status_Bar";
            this.CB_Status_Bar.Size = new Size(122, 21);
            this.CB_Status_Bar.TabIndex = 2;
            this.CB_Status_Bar.Text = "Status Bar";
            this.CB_Status_Bar.UseVisualStyleBackColor = true;
            this.CB_Status_Bar.CheckedChanged += this.CB_Status_Bar_CheckedChanged;
            // 
            // TP_Text
            // 
            this.TP_Text.BackColor = SystemColors.Control;
            this.TP_Text.Controls.Add(this.FLP_Text);
            this.TP_Text.Location = new Point(4, 44);
            this.TP_Text.Name = "TP_Text";
            this.TP_Text.Size = new Size(1089, 123);
            this.TP_Text.TabIndex = 3;
            this.TP_Text.Text = "Text";
            // 
            // FLP_Text
            // 
            this.FLP_Text.Controls.Add(this.GB_Paste_Text);
            this.FLP_Text.Controls.Add(this.GB_Text_Type);
            this.FLP_Text.Controls.Add(this.GB_Text_Colors);
            this.FLP_Text.Dock = DockStyle.Fill;
            this.FLP_Text.Location = new Point(0, 0);
            this.FLP_Text.Name = "FLP_Text";
            this.FLP_Text.Size = new Size(1089, 123);
            this.FLP_Text.TabIndex = 0;
            // 
            // GB_Paste_Text
            // 
            this.GB_Paste_Text.Controls.Add(this.TLP_Text_Operations);
            this.GB_Paste_Text.Controls.Add(this.Btn_Paste_From_Clipboard);
            this.GB_Paste_Text.Location = new Point(4, 3);
            this.GB_Paste_Text.Margin = new Padding(4, 3, 4, 3);
            this.GB_Paste_Text.Name = "GB_Paste_Text";
            this.GB_Paste_Text.Padding = new Padding(4, 3, 4, 3);
            this.GB_Paste_Text.Size = new Size(153, 113);
            this.GB_Paste_Text.TabIndex = 3;
            this.GB_Paste_Text.TabStop = false;
            this.GB_Paste_Text.Text = "Paste";
            // 
            // TLP_Text_Operations
            // 
            this.TLP_Text_Operations.ColumnCount = 1;
            this.TLP_Text_Operations.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            this.TLP_Text_Operations.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            this.TLP_Text_Operations.Controls.Add(this.Btn_Cut_To_Clipboard, 0, 0);
            this.TLP_Text_Operations.Controls.Add(this.Btn_Copy_To_Clipboard, 0, 1);
            this.TLP_Text_Operations.Location = new Point(52, 22);
            this.TLP_Text_Operations.Name = "TLP_Text_Operations";
            this.TLP_Text_Operations.RowCount = 2;
            this.TLP_Text_Operations.RowStyles.Add(new RowStyle(SizeType.Percent, 47.27273F));
            this.TLP_Text_Operations.RowStyles.Add(new RowStyle(SizeType.Percent, 52.72727F));
            this.TLP_Text_Operations.Size = new Size(94, 81);
            this.TLP_Text_Operations.TabIndex = 1;
            // 
            // Btn_Cut_To_Clipboard
            // 
            this.Btn_Cut_To_Clipboard.BackgroundImageLayout = ImageLayout.Stretch;
            this.Btn_Cut_To_Clipboard.Dock = DockStyle.Fill;
            this.Btn_Cut_To_Clipboard.FlatAppearance.BorderSize = 0;
            this.Btn_Cut_To_Clipboard.FlatStyle = FlatStyle.Flat;
            this.Btn_Cut_To_Clipboard.Image = Properties.Resources.cut_to_clipboard;
            this.Btn_Cut_To_Clipboard.ImageAlign = ContentAlignment.MiddleLeft;
            this.Btn_Cut_To_Clipboard.Location = new Point(4, 3);
            this.Btn_Cut_To_Clipboard.Margin = new Padding(4, 3, 4, 3);
            this.Btn_Cut_To_Clipboard.Name = "Btn_Cut_To_Clipboard";
            this.Btn_Cut_To_Clipboard.Size = new Size(86, 32);
            this.Btn_Cut_To_Clipboard.TabIndex = 2;
            this.Btn_Cut_To_Clipboard.Text = "Cut";
            this.Btn_Cut_To_Clipboard.Click += this.Clipboard_Events;
            // 
            // Btn_Copy_To_Clipboard
            // 
            this.Btn_Copy_To_Clipboard.BackgroundImageLayout = ImageLayout.Stretch;
            this.Btn_Copy_To_Clipboard.Dock = DockStyle.Fill;
            this.Btn_Copy_To_Clipboard.FlatAppearance.BorderSize = 0;
            this.Btn_Copy_To_Clipboard.FlatStyle = FlatStyle.Flat;
            this.Btn_Copy_To_Clipboard.Image = Properties.Resources.copy_to_clipboard;
            this.Btn_Copy_To_Clipboard.ImageAlign = ContentAlignment.MiddleLeft;
            this.Btn_Copy_To_Clipboard.Location = new Point(4, 41);
            this.Btn_Copy_To_Clipboard.Margin = new Padding(4, 3, 4, 3);
            this.Btn_Copy_To_Clipboard.Name = "Btn_Copy_To_Clipboard";
            this.Btn_Copy_To_Clipboard.Size = new Size(86, 37);
            this.Btn_Copy_To_Clipboard.TabIndex = 3;
            this.Btn_Copy_To_Clipboard.Text = "Copy";
            this.Btn_Copy_To_Clipboard.Click += this.Clipboard_Events;
            // 
            // Btn_Paste_From_Clipboard
            // 
            this.Btn_Paste_From_Clipboard.BackgroundImage = Properties.Resources.paste_file;
            this.Btn_Paste_From_Clipboard.BackgroundImageLayout = ImageLayout.Stretch;
            this.Btn_Paste_From_Clipboard.FlatAppearance.BorderSize = 0;
            this.Btn_Paste_From_Clipboard.FlatStyle = FlatStyle.Flat;
            this.Btn_Paste_From_Clipboard.Location = new Point(7, 42);
            this.Btn_Paste_From_Clipboard.Margin = new Padding(4, 3, 4, 3);
            this.Btn_Paste_From_Clipboard.Name = "Btn_Paste_From_Clipboard";
            this.Btn_Paste_From_Clipboard.Size = new Size(37, 37);
            this.Btn_Paste_From_Clipboard.TabIndex = 0;
            this.Btn_Paste_From_Clipboard.UseVisualStyleBackColor = true;
            this.Btn_Paste_From_Clipboard.Click += this.Clipboard_Events;
            // 
            // GB_Text_Type
            // 
            this.GB_Text_Type.Controls.Add(this.TLP_Text_Type);
            this.GB_Text_Type.Controls.Add(this.PB_Font_Dialog);
            this.GB_Text_Type.Location = new Point(165, 3);
            this.GB_Text_Type.Margin = new Padding(4, 3, 4, 3);
            this.GB_Text_Type.Name = "GB_Text_Type";
            this.GB_Text_Type.Padding = new Padding(4, 3, 4, 3);
            this.GB_Text_Type.Size = new Size(193, 113);
            this.GB_Text_Type.TabIndex = 4;
            this.GB_Text_Type.TabStop = false;
            this.GB_Text_Type.Text = "Text Type";
            // 
            // TLP_Text_Type
            // 
            this.TLP_Text_Type.ColumnCount = 1;
            this.TLP_Text_Type.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            this.TLP_Text_Type.Controls.Add(this.label13, 0, 1);
            this.TLP_Text_Type.Controls.Add(this.Txt_Text, 0, 3);
            this.TLP_Text_Type.Location = new Point(62, 14);
            this.TLP_Text_Type.Name = "TLP_Text_Type";
            this.TLP_Text_Type.RowCount = 5;
            this.TLP_Text_Type.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            this.TLP_Text_Type.RowStyles.Add(new RowStyle(SizeType.Percent, 35F));
            this.TLP_Text_Type.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            this.TLP_Text_Type.RowStyles.Add(new RowStyle(SizeType.Percent, 35F));
            this.TLP_Text_Type.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            this.TLP_Text_Type.Size = new Size(124, 89);
            this.TLP_Text_Type.TabIndex = 1;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Dock = DockStyle.Fill;
            this.label13.Location = new Point(3, 8);
            this.label13.Name = "label13";
            this.label13.Size = new Size(118, 31);
            this.label13.TabIndex = 0;
            this.label13.Text = "Your Text";
            this.label13.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Txt_Text
            // 
            this.Txt_Text.Dock = DockStyle.Fill;
            this.Txt_Text.Location = new Point(3, 50);
            this.Txt_Text.Name = "Txt_Text";
            this.Txt_Text.PlaceholderText = "Lorem Ipsum";
            this.Txt_Text.Size = new Size(118, 23);
            this.Txt_Text.TabIndex = 1;
            // 
            // PB_Font_Dialog
            // 
            this.PB_Font_Dialog.BackgroundImage = Properties.Resources.font;
            this.PB_Font_Dialog.BackgroundImageLayout = ImageLayout.Stretch;
            this.PB_Font_Dialog.FlatAppearance.BorderSize = 0;
            this.PB_Font_Dialog.FlatStyle = FlatStyle.Flat;
            this.PB_Font_Dialog.Location = new Point(18, 43);
            this.PB_Font_Dialog.Margin = new Padding(4, 3, 4, 3);
            this.PB_Font_Dialog.Name = "PB_Font_Dialog";
            this.PB_Font_Dialog.Size = new Size(37, 37);
            this.PB_Font_Dialog.TabIndex = 0;
            this.PB_Font_Dialog.UseVisualStyleBackColor = true;
            this.PB_Font_Dialog.Click += this.PB_Font_Dialog_Click;
            // 
            // GB_Text_Colors
            // 
            this.GB_Text_Colors.Controls.Add(this.FLP_Text_Colors);
            this.GB_Text_Colors.Controls.Add(this.label11);
            this.GB_Text_Colors.Controls.Add(this.label12);
            this.GB_Text_Colors.Controls.Add(this.Btn_Text_Secondary_Color);
            this.GB_Text_Colors.Controls.Add(this.Btn_Text_Primary_Color);
            this.GB_Text_Colors.Location = new Point(366, 3);
            this.GB_Text_Colors.Margin = new Padding(4, 3, 4, 3);
            this.GB_Text_Colors.Name = "GB_Text_Colors";
            this.GB_Text_Colors.Padding = new Padding(4, 3, 4, 3);
            this.GB_Text_Colors.Size = new Size(450, 113);
            this.GB_Text_Colors.TabIndex = 4;
            this.GB_Text_Colors.TabStop = false;
            this.GB_Text_Colors.Text = "Colors";
            // 
            // FLP_Text_Colors
            // 
            this.FLP_Text_Colors.AutoScroll = true;
            this.FLP_Text_Colors.Dock = DockStyle.Right;
            this.FLP_Text_Colors.Location = new Point(123, 19);
            this.FLP_Text_Colors.Margin = new Padding(4, 3, 4, 3);
            this.FLP_Text_Colors.Name = "FLP_Text_Colors";
            this.FLP_Text_Colors.Size = new Size(323, 91);
            this.FLP_Text_Colors.TabIndex = 4;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new Point(49, 75);
            this.label11.Margin = new Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new Size(62, 15);
            this.label11.TabIndex = 3;
            this.label11.Text = "Secondary";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new Point(5, 75);
            this.label12.Margin = new Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new Size(48, 15);
            this.label12.TabIndex = 2;
            this.label12.Text = "Primary";
            // 
            // Btn_Text_Secondary_Color
            // 
            this.Btn_Text_Secondary_Color.BackColor = Color.White;
            this.Btn_Text_Secondary_Color.BackgroundImageLayout = ImageLayout.Stretch;
            this.Btn_Text_Secondary_Color.FlatAppearance.BorderSize = 0;
            this.Btn_Text_Secondary_Color.FlatStyle = FlatStyle.Flat;
            this.Btn_Text_Secondary_Color.Location = new Point(61, 35);
            this.Btn_Text_Secondary_Color.Margin = new Padding(4, 3, 4, 3);
            this.Btn_Text_Secondary_Color.Name = "Btn_Text_Secondary_Color";
            this.Btn_Text_Secondary_Color.Size = new Size(37, 37);
            this.Btn_Text_Secondary_Color.TabIndex = 1;
            this.Btn_Text_Secondary_Color.Tag = "SecondaryColor";
            this.Btn_Text_Secondary_Color.UseVisualStyleBackColor = false;
            this.Btn_Text_Secondary_Color.Click += this.Select_Color_From_Button;
            // 
            // Btn_Text_Primary_Color
            // 
            this.Btn_Text_Primary_Color.BackColor = Color.Black;
            this.Btn_Text_Primary_Color.BackgroundImageLayout = ImageLayout.Stretch;
            this.Btn_Text_Primary_Color.FlatAppearance.BorderSize = 0;
            this.Btn_Text_Primary_Color.FlatStyle = FlatStyle.Flat;
            this.Btn_Text_Primary_Color.Location = new Point(8, 35);
            this.Btn_Text_Primary_Color.Margin = new Padding(4, 3, 4, 3);
            this.Btn_Text_Primary_Color.Name = "Btn_Text_Primary_Color";
            this.Btn_Text_Primary_Color.Size = new Size(37, 37);
            this.Btn_Text_Primary_Color.TabIndex = 0;
            this.Btn_Text_Primary_Color.Tag = "PrimaryColor";
            this.Btn_Text_Primary_Color.TextAlign = ContentAlignment.BottomCenter;
            this.Btn_Text_Primary_Color.TextImageRelation = TextImageRelation.TextAboveImage;
            this.Btn_Text_Primary_Color.UseVisualStyleBackColor = false;
            this.Btn_Text_Primary_Color.Click += this.Select_Color_From_Button;
            // 
            // button1
            // 
            this.button1.BackgroundImage = Properties.Resources.paste_from_file;
            this.button1.BackgroundImageLayout = ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = FlatStyle.Flat;
            this.button1.Location = new Point(62, 42);
            this.button1.Margin = new Padding(4, 3, 4, 3);
            this.button1.Name = "button1";
            this.button1.Size = new Size(37, 37);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.BackgroundImage = Properties.Resources.paste_file;
            this.button2.BackgroundImageLayout = ImageLayout.Stretch;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = FlatStyle.Flat;
            this.button2.Location = new Point(7, 42);
            this.button2.Margin = new Padding(4, 3, 4, 3);
            this.button2.Name = "button2";
            this.button2.Size = new Size(37, 37);
            this.button2.TabIndex = 0;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.BackgroundImageLayout = ImageLayout.Stretch;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = FlatStyle.Flat;
            this.button3.Image = Properties.Resources.crop_image;
            this.button3.ImageAlign = ContentAlignment.MiddleLeft;
            this.button3.Location = new Point(4, 3);
            this.button3.Margin = new Padding(4, 3, 4, 3);
            this.button3.Name = "button3";
            this.button3.Size = new Size(122, 24);
            this.button3.TabIndex = 2;
            this.button3.Text = "Crop";
            this.button3.TextAlign = ContentAlignment.TopCenter;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.BackgroundImageLayout = ImageLayout.None;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = FlatStyle.Flat;
            this.button4.Image = Properties.Resources.resize_image;
            this.button4.ImageAlign = ContentAlignment.MiddleLeft;
            this.button4.Location = new Point(4, 34);
            this.button4.Margin = new Padding(4, 3, 4, 3);
            this.button4.Name = "button4";
            this.button4.Size = new Size(122, 24);
            this.button4.TabIndex = 3;
            this.button4.Text = "Resize";
            this.button4.TextAlign = ContentAlignment.TopCenter;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.BackgroundImageLayout = ImageLayout.Stretch;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = FlatStyle.Flat;
            this.button5.Image = Properties.Resources.rotate_image;
            this.button5.ImageAlign = ContentAlignment.MiddleLeft;
            this.button5.Location = new Point(4, 66);
            this.button5.Margin = new Padding(4, 3, 4, 3);
            this.button5.Name = "button5";
            this.button5.Size = new Size(122, 24);
            this.button5.TabIndex = 4;
            this.button5.Text = "Rotate";
            this.button5.TextAlign = ContentAlignment.TopCenter;
            this.button5.TextImageRelation = TextImageRelation.ImageBeforeText;
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.BackgroundImage = Properties.Resources.selection;
            this.button6.BackgroundImageLayout = ImageLayout.Stretch;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = FlatStyle.Flat;
            this.button6.Location = new Point(7, 42);
            this.button6.Margin = new Padding(4, 3, 4, 3);
            this.button6.Name = "button6";
            this.button6.Size = new Size(37, 37);
            this.button6.TabIndex = 0;
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.BackgroundImageLayout = ImageLayout.Stretch;
            this.button10.FlatAppearance.BorderSize = 0;
            this.button10.FlatStyle = FlatStyle.Flat;
            this.button10.Image = Properties.Resources.zoom_general;
            this.button10.Location = new Point(105, 49);
            this.button10.Margin = new Padding(4, 3, 4, 3);
            this.button10.Name = "button10";
            this.button10.Size = new Size(43, 37);
            this.button10.TabIndex = 3;
            this.button10.UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            this.button12.BackgroundImageLayout = ImageLayout.Stretch;
            this.button12.FlatAppearance.BorderSize = 0;
            this.button12.FlatStyle = FlatStyle.Flat;
            this.button12.Image = Properties.Resources.text;
            this.button12.Location = new Point(107, 6);
            this.button12.Margin = new Padding(6);
            this.button12.Name = "button12";
            this.button12.Size = new Size(38, 34);
            this.button12.TabIndex = 5;
            this.button12.TextAlign = ContentAlignment.TopCenter;
            this.button12.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.BackgroundImageLayout = ImageLayout.Stretch;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = FlatStyle.Flat;
            this.button7.Image = Properties.Resources.eraser;
            this.button7.Location = new Point(6, 52);
            this.button7.Margin = new Padding(6);
            this.button7.Name = "button7";
            this.button7.Size = new Size(38, 34);
            this.button7.TabIndex = 7;
            this.button7.TextAlign = ContentAlignment.TopCenter;
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.BackgroundImageLayout = ImageLayout.Stretch;
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatStyle = FlatStyle.Flat;
            this.button8.Image = Properties.Resources.color_picker;
            this.button8.Location = new Point(56, 52);
            this.button8.Margin = new Padding(6);
            this.button8.Name = "button8";
            this.button8.Size = new Size(38, 34);
            this.button8.TabIndex = 6;
            this.button8.TextAlign = ContentAlignment.TopCenter;
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.BackgroundImageLayout = ImageLayout.Center;
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.FlatStyle = FlatStyle.Flat;
            this.button9.Image = Properties.Resources.pen;
            this.button9.Location = new Point(6, 6);
            this.button9.Margin = new Padding(6);
            this.button9.Name = "button9";
            this.button9.Size = new Size(38, 34);
            this.button9.TabIndex = 2;
            this.button9.TextAlign = ContentAlignment.TopCenter;
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            this.button11.BackgroundImageLayout = ImageLayout.Center;
            this.button11.FlatAppearance.BorderSize = 0;
            this.button11.FlatStyle = FlatStyle.Flat;
            this.button11.Image = Properties.Resources.paint_image;
            this.button11.Location = new Point(56, 6);
            this.button11.Margin = new Padding(6);
            this.button11.Name = "button11";
            this.button11.Size = new Size(38, 34);
            this.button11.TabIndex = 4;
            this.button11.TextAlign = ContentAlignment.TopCenter;
            this.button11.UseVisualStyleBackColor = true;
            // 
            // Panel_Drawing_Board
            // 
            this.Panel_Drawing_Board.AutoScroll = true;
            this.Panel_Drawing_Board.AutoScrollMargin = new Size(10, 10);
            this.Panel_Drawing_Board.AutoScrollMinSize = new Size(20, 20);
            this.Panel_Drawing_Board.AutoSize = true;
            this.Panel_Drawing_Board.Controls.Add(this.PB_Ruler_Top);
            this.Panel_Drawing_Board.Controls.Add(this.PB_Ruler_Left);
            this.Panel_Drawing_Board.Controls.Add(this.PB_Drawing_Board);
            this.Panel_Drawing_Board.Dock = DockStyle.Fill;
            this.Panel_Drawing_Board.Location = new Point(0, 171);
            this.Panel_Drawing_Board.Margin = new Padding(4, 3, 4, 3);
            this.Panel_Drawing_Board.Name = "Panel_Drawing_Board";
            this.Panel_Drawing_Board.Padding = new Padding(6);
            this.Panel_Drawing_Board.Size = new Size(1097, 589);
            this.Panel_Drawing_Board.TabIndex = 2;
            // 
            // PB_Ruler_Top
            // 
            this.PB_Ruler_Top.BackColor = SystemColors.Control;
            this.PB_Ruler_Top.Location = new Point(32, -1);
            this.PB_Ruler_Top.Name = "PB_Ruler_Top";
            this.PB_Ruler_Top.Size = new Size(1057, 26);
            this.PB_Ruler_Top.TabIndex = 2;
            this.PB_Ruler_Top.TabStop = false;
            this.PB_Ruler_Top.Visible = false;
            // 
            // PB_Ruler_Left
            // 
            this.PB_Ruler_Left.BackColor = SystemColors.Control;
            this.PB_Ruler_Left.Location = new Point(0, 28);
            this.PB_Ruler_Left.Name = "PB_Ruler_Left";
            this.PB_Ruler_Left.Size = new Size(26, 537);
            this.PB_Ruler_Left.TabIndex = 1;
            this.PB_Ruler_Left.TabStop = false;
            this.PB_Ruler_Left.Visible = false;
            // 
            // PB_Drawing_Board
            // 
            this.PB_Drawing_Board.BackColor = Color.White;
            this.PB_Drawing_Board.BorderStyle = BorderStyle.FixedSingle;
            this.PB_Drawing_Board.Location = new Point(32, 28);
            this.PB_Drawing_Board.Name = "PB_Drawing_Board";
            this.PB_Drawing_Board.Size = new Size(1057, 523);
            this.PB_Drawing_Board.TabIndex = 0;
            this.PB_Drawing_Board.TabStop = false;
            this.PB_Drawing_Board.SizeChanged += this.PB_Drawing_Board_SizeChanged;
            this.PB_Drawing_Board.MouseClick += this.PB_Drawing_Board_MouseClick;
            this.PB_Drawing_Board.MouseDown += this.PB_Drawing_Board_MouseDown;
            this.PB_Drawing_Board.MouseMove += this.PB_Drawing_Board_MouseMove;
            this.PB_Drawing_Board.MouseUp += this.PB_Drawing_Board_MouseUp;
            // 
            // Status_Bar
            // 
            this.Status_Bar.Items.AddRange(new ToolStripItem[] { this.Lbl_Mouse_Coordinates, this.Lbl_Page_Size });
            this.Status_Bar.LayoutStyle = ToolStripLayoutStyle.Flow;
            this.Status_Bar.Location = new Point(0, 739);
            this.Status_Bar.Name = "Status_Bar";
            this.Status_Bar.Padding = new Padding(1, 0, 16, 0);
            this.Status_Bar.RenderMode = ToolStripRenderMode.Professional;
            this.Status_Bar.Size = new Size(1097, 21);
            this.Status_Bar.SizingGrip = false;
            this.Status_Bar.TabIndex = 1;
            // 
            // Lbl_Mouse_Coordinates
            // 
            this.Lbl_Mouse_Coordinates.Image = Properties.Resources.location;
            this.Lbl_Mouse_Coordinates.Name = "Lbl_Mouse_Coordinates";
            this.Lbl_Mouse_Coordinates.Padding = new Padding(50, 0, 0, 0);
            this.Lbl_Mouse_Coordinates.Size = new Size(66, 16);
            this.Lbl_Mouse_Coordinates.Spring = true;
            // 
            // Lbl_Page_Size
            // 
            this.Lbl_Page_Size.Image = Properties.Resources.resize_status;
            this.Lbl_Page_Size.Name = "Lbl_Page_Size";
            this.Lbl_Page_Size.Padding = new Padding(50, 0, 0, 0);
            this.Lbl_Page_Size.Size = new Size(66, 16);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Location = new Point(4, 3);
            this.groupBox3.Margin = new Padding(4, 3, 4, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new Padding(4, 3, 4, 3);
            this.groupBox3.Size = new Size(106, 113);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Paste";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.tableLayoutPanel6);
            this.groupBox4.Controls.Add(this.button6);
            this.groupBox4.Location = new Point(4, 122);
            this.groupBox4.Margin = new Padding(4, 3, 4, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new Padding(4, 3, 4, 3);
            this.groupBox4.Size = new Size(188, 113);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Image";
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 1;
            this.tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            this.tableLayoutPanel6.Controls.Add(this.button3, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.button4, 0, 1);
            this.tableLayoutPanel6.Controls.Add(this.button5, 0, 2);
            this.tableLayoutPanel6.Location = new Point(51, 10);
            this.tableLayoutPanel6.Margin = new Padding(4, 3, 4, 3);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 3;
            this.tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 33.33F));
            this.tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 33.34F));
            this.tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 33.33F));
            this.tableLayoutPanel6.Size = new Size(130, 96);
            this.tableLayoutPanel6.TabIndex = 1;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.tableLayoutPanel7);
            this.groupBox5.Location = new Point(4, 241);
            this.groupBox5.Margin = new Padding(4, 3, 4, 3);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new Padding(4, 3, 4, 3);
            this.groupBox5.Size = new Size(167, 113);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Tools";
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 3;
            this.tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33F));
            this.tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.34F));
            this.tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33F));
            this.tableLayoutPanel7.Controls.Add(this.button7, 0, 1);
            this.tableLayoutPanel7.Controls.Add(this.button8, 0, 1);
            this.tableLayoutPanel7.Controls.Add(this.button9, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.button10, 0, 1);
            this.tableLayoutPanel7.Controls.Add(this.button11, 1, 0);
            this.tableLayoutPanel7.Controls.Add(this.button12, 2, 0);
            this.tableLayoutPanel7.Location = new Point(7, 14);
            this.tableLayoutPanel7.Margin = new Padding(4, 3, 4, 3);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 2;
            this.tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            this.tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            this.tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Absolute, 23F));
            this.tableLayoutPanel7.Size = new Size(153, 92);
            this.tableLayoutPanel7.TabIndex = 1;
            // 
            // groupBox6
            // 
            this.groupBox6.Location = new Point(0, 0);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new Size(200, 100);
            this.groupBox6.TabIndex = 0;
            this.groupBox6.TabStop = false;
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.ColumnCount = 5;
            this.tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            this.tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            this.tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            this.tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            this.tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            this.tableLayoutPanel8.Location = new Point(0, 0);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 2;
            this.tableLayoutPanel8.Size = new Size(200, 100);
            this.tableLayoutPanel8.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.groupBox3);
            this.flowLayoutPanel1.Controls.Add(this.groupBox4);
            this.flowLayoutPanel1.Controls.Add(this.groupBox5);
            this.flowLayoutPanel1.Location = new Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new Size(200, 100);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // Font_Dialog
            // 
            this.Font_Dialog.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            // 
            // Continuous_Checker
            // 
            this.Continuous_Checker.Enabled = true;
            this.Continuous_Checker.Interval = 250;
            this.Continuous_Checker.Tick += this.Continuous_Checker_Tick;
            // 
            // TLP_Print
            // 
            this.TLP_Print.ColumnCount = 3;
            this.TLP_Print.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            this.TLP_Print.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
            this.TLP_Print.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            this.TLP_Print.Controls.Add(this.Btn_Print_Image, 1, 1);
            this.TLP_Print.Controls.Add(this.Lbl_Print, 1, 2);
            this.TLP_Print.Dock = DockStyle.Fill;
            this.TLP_Print.Location = new Point(4, 19);
            this.TLP_Print.Name = "TLP_Print";
            this.TLP_Print.RowCount = 3;
            this.TLP_Print.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            this.TLP_Print.RowStyles.Add(new RowStyle(SizeType.Percent, 60F));
            this.TLP_Print.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            this.TLP_Print.Size = new Size(67, 91);
            this.TLP_Print.TabIndex = 1;
            // 
            // Lbl_Print
            // 
            this.Lbl_Print.AutoSize = true;
            this.Lbl_Print.Dock = DockStyle.Fill;
            this.Lbl_Print.Location = new Point(9, 72);
            this.Lbl_Print.Name = "Lbl_Print";
            this.Lbl_Print.Size = new Size(47, 19);
            this.Lbl_Print.TabIndex = 6;
            this.Lbl_Print.Text = "Print";
            this.Lbl_Print.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // MasterForm
            // 
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new Size(1097, 760);
            this.Controls.Add(this.Status_Bar);
            this.Controls.Add(this.Panel_Drawing_Board);
            this.Controls.Add(this.TC_Menu);
            this.DoubleBuffered = true;
            this.Icon = (Icon)resources.GetObject("$this.Icon");
            this.KeyPreview = true;
            this.Margin = new Padding(4, 3, 4, 3);
            this.Name = "MasterForm";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "MDBEditor";
            this.WindowState = FormWindowState.Maximized;
            this.KeyDown += this.Detect_Key;
            this.TC_Menu.ResumeLayout(false);
            this.TP_General.ResumeLayout(false);
            this.FLP_File.ResumeLayout(false);
            this.GB_File_Options.ResumeLayout(false);
            this.TLP_File.ResumeLayout(false);
            this.GB_Save_File.ResumeLayout(false);
            this.FLP_Save_Image.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)this.PB_Save_As_Image).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.PB_Save_As_PNG).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.PB_Save_As_JPG).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.PB_Save_As_GIF).EndInit();
            this.GB_Print.ResumeLayout(false);
            this.GB_Settings.ResumeLayout(false);
            this.TLP_Features.ResumeLayout(false);
            this.TP_Prologue.ResumeLayout(false);
            this.FLP_Prologue.ResumeLayout(false);
            this.GB_Paste_Box.ResumeLayout(false);
            this.GB_Image_Area.ResumeLayout(false);
            this.TLP_Image.ResumeLayout(false);
            this.GB_Shape_Features.ResumeLayout(false);
            this.TBL_Shape_Features.ResumeLayout(false);
            this.TBL_Shape_Features.PerformLayout();
            this.GB_Tools.ResumeLayout(false);
            this.TLP_Tools.ResumeLayout(false);
            this.GB_Shapes.ResumeLayout(false);
            this.TC_Shape.ResumeLayout(false);
            this.TC_Shape_Page_1.ResumeLayout(false);
            this.FLP_Shape_Page_1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)this.PB_Circle).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.PB_Square).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.PB_Rounded_Rectangle).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.PB_Rectangle).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.PB_Parallelogram).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.PB_Trapezoid).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.PB_Diamond).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.PB_Right_Arrow).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.PB_Left_Arrow).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.PB_Six_Pointed_Star).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.PB_Star).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.PB_Four_Pointed_Star).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.PB_Hexagon).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.O).EndInit();
            this.TC_Shape_Page_2.ResumeLayout(false);
            this.FLP_Shapes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)this.PB_Triangle).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.PB_Left_Triangle).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.PB_Right_Triangle).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.PB_Bottom_Triangle).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.PB_Cube).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.PB_Triangle_Pyramid).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.PB_Plus).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.PB_Note).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.PB_Envelope).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.PB_Eight_Pointed_Star).EndInit();
            this.GB_Colors.ResumeLayout(false);
            this.GB_Colors.PerformLayout();
            this.TP_View.ResumeLayout(false);
            this.FLP_View.ResumeLayout(false);
            this.GB_Zoom.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.GB_Show_Or_Hide.ResumeLayout(false);
            this.TLP_Show_And_Hide.ResumeLayout(false);
            this.TP_Text.ResumeLayout(false);
            this.FLP_Text.ResumeLayout(false);
            this.GB_Paste_Text.ResumeLayout(false);
            this.TLP_Text_Operations.ResumeLayout(false);
            this.GB_Text_Type.ResumeLayout(false);
            this.TLP_Text_Type.ResumeLayout(false);
            this.TLP_Text_Type.PerformLayout();
            this.GB_Text_Colors.ResumeLayout(false);
            this.GB_Text_Colors.PerformLayout();
            this.Panel_Drawing_Board.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)this.PB_Ruler_Top).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.PB_Ruler_Left).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.PB_Drawing_Board).EndInit();
            this.Status_Bar.ResumeLayout(false);
            this.Status_Bar.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.tableLayoutPanel7.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.TLP_Print.ResumeLayout(false);
            this.TLP_Print.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
        private System.Windows.Forms.TabControl TC_Menu;
        private System.Windows.Forms.TabPage TP_Prologue;
        private System.Windows.Forms.TabPage TP_View;
        private System.Windows.Forms.FlowLayoutPanel FLP_Prologue;
        private System.Windows.Forms.GroupBox GB_Paste_Box;
        private System.Windows.Forms.Button Btn_Paste_From_File;
        private System.Windows.Forms.Button Btn_Paste_Area;
        private System.Windows.Forms.GroupBox GB_Image_Area;
        private System.Windows.Forms.Button Btn_Select_Area;
        private System.Windows.Forms.TableLayoutPanel TLP_Image;
        private System.Windows.Forms.Button Btn_Crop_Image;
        private System.Windows.Forms.Button Btn_Resize_Image;
        private System.Windows.Forms.Button Btn_Rotate_Image;
        private System.Windows.Forms.Panel Panel_Drawing_Board;
        private System.Windows.Forms.GroupBox GB_Tools;
        private System.Windows.Forms.TableLayoutPanel TLP_Tools;
        private System.Windows.Forms.Button Btn_Pen;
        private System.Windows.Forms.Button Btn_Zoom;
        private System.Windows.Forms.Button Btn_Erase;
        private System.Windows.Forms.Button Btn_Color_Picker;
        private System.Windows.Forms.Button Btn_Paint_All;
        private System.Windows.Forms.Button Btn_Add_Text;
        private System.Windows.Forms.GroupBox GB_Shapes;
        private System.Windows.Forms.GroupBox GB_Colors;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel FLP_Colors;
        private System.Windows.Forms.FlowLayoutPanel FLP_View;
        private System.Windows.Forms.GroupBox GB_Zoom;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Btn_Zoom_Normal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Btn_Zoom_Out;
        private System.Windows.Forms.Button Btn_Zoom_In;
        private System.Windows.Forms.GroupBox GB_Show_Or_Hide;
        private System.Windows.Forms.TableLayoutPanel TLP_Show_And_Hide;
        private System.Windows.Forms.CheckBox CB_Ruler;
        private System.Windows.Forms.CheckBox CB_Guidelines;
        private System.Windows.Forms.CheckBox CB_Status_Bar;
        private System.Windows.Forms.TabPage TP_General;
        private System.Windows.Forms.FlowLayoutPanel FLP_File;
        private System.Windows.Forms.GroupBox GB_File_Options;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Btn_Open_File;
        private System.Windows.Forms.Button Btn_New_Image;
        private System.Windows.Forms.GroupBox GB_Save_File;
        private System.Windows.Forms.TableLayoutPanel FLP_Save_Image;
        private System.Windows.Forms.PictureBox PB_Save_As_Image;
        private System.Windows.Forms.PictureBox PB_Save_As_PNG;
        private System.Windows.Forms.PictureBox PB_Save_As_JPG;
        private System.Windows.Forms.PictureBox PB_Save_As_GIF;
        private System.Windows.Forms.GroupBox GB_Print;
        private System.Windows.Forms.Button Btn_Print_Image;
        private System.Windows.Forms.GroupBox GB_Settings;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ColorDialog Color_Picker;
        private System.Windows.Forms.StatusStrip Status_Bar;
        private System.Windows.Forms.ToolStripStatusLabel Lbl_Mouse_Coordinates;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TabPage TP_Text;
        private System.Windows.Forms.FlowLayoutPanel FLP_Text;
        private System.Windows.Forms.GroupBox GB_Paste_Text;
        private System.Windows.Forms.Button Btn_Paste_From_Clipboard;
        private System.Windows.Forms.GroupBox GB_Text_Colors;
        private System.Windows.Forms.FlowLayoutPanel FLP_Text_Colors;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TableLayoutPanel TLP_Text_Operations;
        private System.Windows.Forms.Button Btn_Cut_To_Clipboard;
        private System.Windows.Forms.FontDialog Font_Dialog;
        private System.Windows.Forms.Button Btn_Copy_To_Clipboard;
        private System.Windows.Forms.ToolStripStatusLabel Lbl_Page_Size;
        private ResizablePictureBox PB_Drawing_Board;
        private System.Windows.Forms.GroupBox GB_Text_Type;
        private System.Windows.Forms.Button PB_Font_Dialog;
        private System.Windows.Forms.PictureBox PB_Ruler_Top;
        private System.Windows.Forms.PictureBox PB_Ruler_Left;
        private System.Windows.Forms.TableLayoutPanel TLP_Features;
        private System.Windows.Forms.TableLayoutPanel TLP_File;
        private System.Windows.Forms.TableLayoutPanel TLP_Text_Type;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox Txt_Text;
        private System.Windows.Forms.Button Btn_Secondary_Color;
        private System.Windows.Forms.Button Btn_Primary_Color;
        private System.Windows.Forms.Button Btn_Text_Secondary_Color;
        private System.Windows.Forms.Button Btn_Text_Primary_Color;
        private System.Windows.Forms.Timer Continuous_Checker;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel FLP_Shapes;
        private System.Windows.Forms.PictureBox PB_Square;
        private System.Windows.Forms.PictureBox PB_Rectangle;
        private System.Windows.Forms.PictureBox PB_Triangle;
        private System.Windows.Forms.PictureBox PB_Diamond;
        private System.Windows.Forms.PictureBox PB_Star;
        private System.Windows.Forms.PictureBox PB_Circle;
        private System.Windows.Forms.PictureBox PB_Cube;
        private System.Windows.Forms.PictureBox O;
        private System.Windows.Forms.PictureBox PB_Hexagon;
        private System.Windows.Forms.PictureBox PB_Parallelogram;
        private System.Windows.Forms.PictureBox PB_Trapezoid;
        private System.Windows.Forms.PictureBox PB_Six_Pointed_Star;
        private System.Windows.Forms.PictureBox PB_Left_Arrow;
        private System.Windows.Forms.PictureBox PB_Right_Arrow;
        private System.Windows.Forms.PictureBox PB_Bottom_Triangle;
        private System.Windows.Forms.PictureBox PB_Left_Triangle;
        private System.Windows.Forms.PictureBox PB_Right_Triangle;
        private System.Windows.Forms.PictureBox PB_Four_Pointed_Star;
        private System.Windows.Forms.PictureBox PB_Rounded_Rectangle;
        private System.Windows.Forms.PictureBox PB_Triangle_Pyramid;
        private System.Windows.Forms.PictureBox PB_Plus;
        private System.Windows.Forms.TabControl TC_Shape;
        private System.Windows.Forms.TabPage TC_Shape_Page_1;
        private System.Windows.Forms.FlowLayoutPanel FLP_Shape_Page_1;
        private System.Windows.Forms.TabPage TC_Shape_Page_2;
        private System.Windows.Forms.PictureBox PB_Note;
        private System.Windows.Forms.PictureBox PB_Envelope;
        private System.Windows.Forms.GroupBox GB_Shape_Features;
        private System.Windows.Forms.TableLayoutPanel TBL_Shape_Features;
        private System.Windows.Forms.ComboBox CB_Shape_Fill;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox CB_Shape_Border;
        private System.Windows.Forms.PictureBox PB_Eight_Pointed_Star;
        private Button Btn_Features;
        private Label label8;
        private TableLayoutPanel TLP_Print;
        private Label Lbl_Print;
    }
}

