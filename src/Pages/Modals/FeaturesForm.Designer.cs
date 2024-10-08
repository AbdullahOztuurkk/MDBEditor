﻿
namespace MDBEditor.Pages.Modals
{
    partial class FeaturesForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FeaturesForm));
            this.Pnl_Form = new Panel();
            this.tableLayoutPanel3 = new TableLayoutPanel();
            this.Btn_Exit = new Button();
            this.Btn_Apply = new Button();
            this.groupBox3 = new GroupBox();
            this.Btn_Restore_Settings = new Button();
            this.MTxtVertical = new MaskedTextBox();
            this.MTxtHorizontal = new MaskedTextBox();
            this.label3 = new Label();
            this.label4 = new Label();
            this.groupBox2 = new GroupBox();
            this.tableLayoutPanel1 = new TableLayoutPanel();
            this.RB_Grayscale = new RadioButton();
            this.RB_Colored = new RadioButton();
            this.groupBox1 = new GroupBox();
            this.Lbl_Resolution = new Label();
            this.Lbl_Image_Name = new Label();
            this.label2 = new Label();
            this.label1 = new Label();
            this.tableLayoutPanel2 = new TableLayoutPanel();
            this.radioButton3 = new RadioButton();
            this.radioButton4 = new RadioButton();
            this.Pnl_Form.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Pnl_Form
            // 
            this.Pnl_Form.Controls.Add(this.tableLayoutPanel3);
            this.Pnl_Form.Controls.Add(this.groupBox3);
            this.Pnl_Form.Controls.Add(this.groupBox2);
            this.Pnl_Form.Controls.Add(this.groupBox1);
            this.Pnl_Form.Dock = DockStyle.Fill;
            this.Pnl_Form.Location = new Point(0, 0);
            this.Pnl_Form.Name = "Pnl_Form";
            this.Pnl_Form.Padding = new Padding(10);
            this.Pnl_Form.Size = new Size(344, 315);
            this.Pnl_Form.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33F));
            this.tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33F));
            this.tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.34F));
            this.tableLayoutPanel3.Controls.Add(this.Btn_Exit, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.Btn_Apply, 2, 0);
            this.tableLayoutPanel3.Dock = DockStyle.Bottom;
            this.tableLayoutPanel3.Location = new Point(10, 265);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new Size(324, 40);
            this.tableLayoutPanel3.TabIndex = 3;
            // 
            // Btn_Exit
            // 
            this.Btn_Exit.Dock = DockStyle.Fill;
            this.Btn_Exit.Location = new Point(110, 3);
            this.Btn_Exit.Name = "Btn_Exit";
            this.Btn_Exit.Size = new Size(101, 34);
            this.Btn_Exit.TabIndex = 0;
            this.Btn_Exit.Text = "Exit";
            this.Btn_Exit.UseVisualStyleBackColor = true;
            // 
            // Btn_Apply
            // 
            this.Btn_Apply.Dock = DockStyle.Fill;
            this.Btn_Apply.Location = new Point(217, 3);
            this.Btn_Apply.Name = "Btn_Apply";
            this.Btn_Apply.Size = new Size(104, 34);
            this.Btn_Apply.TabIndex = 1;
            this.Btn_Apply.Text = "Apply";
            this.Btn_Apply.UseVisualStyleBackColor = true;
            this.Btn_Apply.Click += this.Btn_Apply_Click;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Btn_Restore_Settings);
            this.groupBox3.Controls.Add(this.MTxtVertical);
            this.groupBox3.Controls.Add(this.MTxtHorizontal);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new Point(12, 158);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new Size(316, 101);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Image Size";
            // 
            // Btn_Restore_Settings
            // 
            this.Btn_Restore_Settings.Location = new Point(206, 72);
            this.Btn_Restore_Settings.Name = "Btn_Restore_Settings";
            this.Btn_Restore_Settings.Size = new Size(104, 23);
            this.Btn_Restore_Settings.TabIndex = 4;
            this.Btn_Restore_Settings.Text = "Restore Settings";
            this.Btn_Restore_Settings.UseVisualStyleBackColor = true;
            this.Btn_Restore_Settings.Click += this.Btn_Restore_Settings_Click;
            // 
            // MTxtVertical
            // 
            this.MTxtVertical.Location = new Point(152, 45);
            this.MTxtVertical.Mask = "0000";
            this.MTxtVertical.Name = "MTxtVertical";
            this.MTxtVertical.Size = new Size(158, 23);
            this.MTxtVertical.TabIndex = 3;
            this.MTxtVertical.TextAlign = HorizontalAlignment.Center;
            this.MTxtVertical.ValidatingType = typeof(int);
            // 
            // MTxtHorizontal
            // 
            this.MTxtHorizontal.Location = new Point(152, 20);
            this.MTxtHorizontal.Mask = "0000";
            this.MTxtHorizontal.Name = "MTxtHorizontal";
            this.MTxtHorizontal.Size = new Size(158, 23);
            this.MTxtHorizontal.TabIndex = 2;
            this.MTxtHorizontal.TextAlign = HorizontalAlignment.Center;
            this.MTxtHorizontal.ValidatingType = typeof(int);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new Point(7, 48);
            this.label3.Name = "label3";
            this.label3.Size = new Size(48, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Vertical:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new Point(7, 23);
            this.label4.Name = "label4";
            this.label4.Size = new Size(65, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Horizontal:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tableLayoutPanel1);
            this.groupBox2.Location = new Point(13, 98);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new Size(318, 55);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Colors";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.RB_Grayscale, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.RB_Colored, 0, 0);
            this.tableLayoutPanel1.Dock = DockStyle.Fill;
            this.tableLayoutPanel1.Location = new Point(3, 19);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 33F));
            this.tableLayoutPanel1.Size = new Size(312, 33);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // RB_Grayscale
            // 
            this.RB_Grayscale.Dock = DockStyle.Fill;
            this.RB_Grayscale.Location = new Point(159, 3);
            this.RB_Grayscale.Name = "RB_Grayscale";
            this.RB_Grayscale.Size = new Size(150, 27);
            this.RB_Grayscale.TabIndex = 1;
            this.RB_Grayscale.Text = "Grayscale";
            this.RB_Grayscale.UseVisualStyleBackColor = true;
            this.RB_Grayscale.Click += this.RB_Grayscale_Click;
            // 
            // RB_Colored
            // 
            this.RB_Colored.Checked = true;
            this.RB_Colored.Dock = DockStyle.Fill;
            this.RB_Colored.Location = new Point(3, 3);
            this.RB_Colored.Name = "RB_Colored";
            this.RB_Colored.Size = new Size(150, 27);
            this.RB_Colored.TabIndex = 0;
            this.RB_Colored.TabStop = true;
            this.RB_Colored.Text = "Colored";
            this.RB_Colored.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Lbl_Resolution);
            this.groupBox1.Controls.Add(this.Lbl_Image_Name);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new Size(320, 81);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Image Information";
            // 
            // Lbl_Resolution
            // 
            this.Lbl_Resolution.AutoSize = true;
            this.Lbl_Resolution.Location = new Point(152, 48);
            this.Lbl_Resolution.Name = "Lbl_Resolution";
            this.Lbl_Resolution.Size = new Size(58, 15);
            this.Lbl_Resolution.TabIndex = 3;
            this.Lbl_Resolution.Text = "Unknown";
            // 
            // Lbl_Image_Name
            // 
            this.Lbl_Image_Name.AutoSize = true;
            this.Lbl_Image_Name.Location = new Point(152, 23);
            this.Lbl_Image_Name.Name = "Lbl_Image_Name";
            this.Lbl_Image_Name.Size = new Size(58, 15);
            this.Lbl_Image_Name.TabIndex = 2;
            this.Lbl_Image_Name.Text = "Unknown";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new Point(7, 48);
            this.label2.Name = "label2";
            this.label2.Size = new Size(102, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Image Resolution:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new Point(7, 23);
            this.label1.Name = "label1";
            this.label1.Size = new Size(78, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Image Name:";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.radioButton3, 1, 0);
            this.tableLayoutPanel2.Dock = DockStyle.Fill;
            this.tableLayoutPanel2.Location = new Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new Size(200, 100);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // radioButton3
            // 
            this.radioButton3.Dock = DockStyle.Fill;
            this.radioButton3.Location = new Point(103, 3);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new Size(94, 94);
            this.radioButton3.TabIndex = 1;
            this.radioButton3.Text = "Grayscale";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.Checked = true;
            this.radioButton4.Dock = DockStyle.Fill;
            this.radioButton4.Location = new Point(3, 3);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new Size(94, 94);
            this.radioButton4.TabIndex = 0;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Colored";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // FeaturesForm
            // 
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(344, 315);
            this.Controls.Add(this.Pnl_Form);
            this.Icon = (Icon)resources.GetObject("$this.Icon");
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FeaturesForm";
            this.StartPosition = FormStartPosition.CenterParent;
            this.Text = "Image Features";
            this.Pnl_Form.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel Pnl_Form;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button Btn_Exit;
        private System.Windows.Forms.Button Btn_Apply;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button Btn_Restore_Settings;
        private System.Windows.Forms.MaskedTextBox MTxtVertical;
        private System.Windows.Forms.MaskedTextBox MTxtHorizontal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton RB_Grayscale;
        private System.Windows.Forms.RadioButton RB_Colored;
        private System.Windows.Forms.Label Lbl_Resolution;
        private System.Windows.Forms.Label Lbl_Image_Name;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
    }
}