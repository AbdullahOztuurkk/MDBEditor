
namespace MDBEditor.Pages.Modals
{
    partial class ResizeForm
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
            this.Pnl_Form = new System.Windows.Forms.Panel();
            this.GB_Resize = new System.Windows.Forms.GroupBox();
            this.NUD_Vertical = new System.Windows.Forms.NumericUpDown();
            this.NUD_Horizontal = new System.Windows.Forms.NumericUpDown();
            this.Btn_Apply = new System.Windows.Forms.Button();
            this.Btn_Exit = new System.Windows.Forms.Button();
            this.CB_Keep_Aspect_Ratio = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PB_Vertical = new System.Windows.Forms.PictureBox();
            this.PB_Horizontal = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.RB_Pixel = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.RB_Percentage = new System.Windows.Forms.RadioButton();
            this.Pnl_Form.SuspendLayout();
            this.GB_Resize.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Vertical)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Horizontal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Vertical)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Horizontal)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Pnl_Form
            // 
            this.Pnl_Form.Controls.Add(this.GB_Resize);
            this.Pnl_Form.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pnl_Form.Location = new System.Drawing.Point(0, 0);
            this.Pnl_Form.Name = "Pnl_Form";
            this.Pnl_Form.Padding = new System.Windows.Forms.Padding(10);
            this.Pnl_Form.Size = new System.Drawing.Size(264, 275);
            this.Pnl_Form.TabIndex = 0;
            // 
            // GB_Resize
            // 
            this.GB_Resize.Controls.Add(this.NUD_Vertical);
            this.GB_Resize.Controls.Add(this.NUD_Horizontal);
            this.GB_Resize.Controls.Add(this.Btn_Apply);
            this.GB_Resize.Controls.Add(this.Btn_Exit);
            this.GB_Resize.Controls.Add(this.CB_Keep_Aspect_Ratio);
            this.GB_Resize.Controls.Add(this.label3);
            this.GB_Resize.Controls.Add(this.label2);
            this.GB_Resize.Controls.Add(this.PB_Vertical);
            this.GB_Resize.Controls.Add(this.PB_Horizontal);
            this.GB_Resize.Controls.Add(this.tableLayoutPanel1);
            this.GB_Resize.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GB_Resize.Location = new System.Drawing.Point(10, 10);
            this.GB_Resize.Name = "GB_Resize";
            this.GB_Resize.Size = new System.Drawing.Size(244, 255);
            this.GB_Resize.TabIndex = 0;
            this.GB_Resize.TabStop = false;
            this.GB_Resize.Text = "Image Settings";
            // 
            // NUD_Vertical
            // 
            this.NUD_Vertical.Location = new System.Drawing.Point(144, 133);
            this.NUD_Vertical.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.NUD_Vertical.Name = "NUD_Vertical";
            this.NUD_Vertical.Size = new System.Drawing.Size(93, 23);
            this.NUD_Vertical.TabIndex = 11;
            this.NUD_Vertical.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NUD_Vertical.ValueChanged += new System.EventHandler(this.Value_Changed);
            // 
            // NUD_Horizontal
            // 
            this.NUD_Horizontal.Location = new System.Drawing.Point(144, 82);
            this.NUD_Horizontal.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.NUD_Horizontal.Name = "NUD_Horizontal";
            this.NUD_Horizontal.Size = new System.Drawing.Size(93, 23);
            this.NUD_Horizontal.TabIndex = 10;
            this.NUD_Horizontal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NUD_Horizontal.ValueChanged += new System.EventHandler(this.Value_Changed);
            // 
            // Btn_Apply
            // 
            this.Btn_Apply.Location = new System.Drawing.Point(147, 219);
            this.Btn_Apply.Name = "Btn_Apply";
            this.Btn_Apply.Size = new System.Drawing.Size(90, 30);
            this.Btn_Apply.TabIndex = 9;
            this.Btn_Apply.Text = "Apply";
            this.Btn_Apply.UseVisualStyleBackColor = true;
            this.Btn_Apply.Click += new System.EventHandler(this.Apply_Resize);
            // 
            // Btn_Exit
            // 
            this.Btn_Exit.Location = new System.Drawing.Point(6, 219);
            this.Btn_Exit.Name = "Btn_Exit";
            this.Btn_Exit.Size = new System.Drawing.Size(90, 30);
            this.Btn_Exit.TabIndex = 8;
            this.Btn_Exit.Text = "Close";
            this.Btn_Exit.UseVisualStyleBackColor = true;
            // 
            // CB_Keep_Aspect_Ratio
            // 
            this.CB_Keep_Aspect_Ratio.AutoSize = true;
            this.CB_Keep_Aspect_Ratio.Location = new System.Drawing.Point(9, 177);
            this.CB_Keep_Aspect_Ratio.Name = "CB_Keep_Aspect_Ratio";
            this.CB_Keep_Aspect_Ratio.Size = new System.Drawing.Size(116, 19);
            this.CB_Keep_Aspect_Ratio.TabIndex = 7;
            this.CB_Keep_Aspect_Ratio.Text = "Keep aspect ratio";
            this.CB_Keep_Aspect_Ratio.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(73, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Vertical:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Horizontal:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PB_Vertical
            // 
            this.PB_Vertical.Image = global::MDBEditor.Properties.Resources.vertical_resize;
            this.PB_Vertical.Location = new System.Drawing.Point(22, 127);
            this.PB_Vertical.Name = "PB_Vertical";
            this.PB_Vertical.Size = new System.Drawing.Size(30, 30);
            this.PB_Vertical.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PB_Vertical.TabIndex = 2;
            this.PB_Vertical.TabStop = false;
            // 
            // PB_Horizontal
            // 
            this.PB_Horizontal.Image = global::MDBEditor.Properties.Resources.horizontal_resize;
            this.PB_Horizontal.Location = new System.Drawing.Point(22, 76);
            this.PB_Horizontal.Name = "PB_Horizontal";
            this.PB_Horizontal.Size = new System.Drawing.Size(30, 30);
            this.PB_Horizontal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PB_Horizontal.TabIndex = 1;
            this.PB_Horizontal.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36F));
            this.tableLayoutPanel1.Controls.Add(this.RB_Pixel, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.RB_Percentage, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 22);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(231, 31);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // RB_Pixel
            // 
            this.RB_Pixel.AutoSize = true;
            this.RB_Pixel.Checked = true;
            this.RB_Pixel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RB_Pixel.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RB_Pixel.Location = new System.Drawing.Point(150, 4);
            this.RB_Pixel.Name = "RB_Pixel";
            this.RB_Pixel.Size = new System.Drawing.Size(77, 23);
            this.RB_Pixel.TabIndex = 2;
            this.RB_Pixel.TabStop = true;
            this.RB_Pixel.Text = "Pixel";
            this.RB_Pixel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.RB_Pixel.UseVisualStyleBackColor = true;
            this.RB_Pixel.CheckedChanged += new System.EventHandler(this.RB_Pixel_CheckedChanged);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(4, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Criteria:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RB_Percentage
            // 
            this.RB_Percentage.AutoSize = true;
            this.RB_Percentage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RB_Percentage.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RB_Percentage.Location = new System.Drawing.Point(68, 4);
            this.RB_Percentage.Name = "RB_Percentage";
            this.RB_Percentage.Size = new System.Drawing.Size(75, 23);
            this.RB_Percentage.TabIndex = 1;
            this.RB_Percentage.Text = "Percentage";
            this.RB_Percentage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.RB_Percentage.UseVisualStyleBackColor = true;
            this.RB_Percentage.CheckedChanged += new System.EventHandler(this.RB_Percentage_CheckedChanged);
            // 
            // ResizeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 275);
            this.Controls.Add(this.Pnl_Form);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ResizeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Resize Image";
            this.Pnl_Form.ResumeLayout(false);
            this.GB_Resize.ResumeLayout(false);
            this.GB_Resize.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Vertical)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Horizontal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Vertical)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Horizontal)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Pnl_Form;
        private System.Windows.Forms.GroupBox GB_Resize;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox PB_Vertical;
        private System.Windows.Forms.PictureBox PB_Horizontal;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.RadioButton RB_Pixel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton RB_Percentage;
        private System.Windows.Forms.CheckBox CB_Keep_Aspect_Ratio;
        private System.Windows.Forms.Button Btn_Apply;
        private System.Windows.Forms.Button Btn_Exit;
        private System.Windows.Forms.NumericUpDown NUD_Vertical;
        private System.Windows.Forms.NumericUpDown NUD_Horizontal;
    }
}