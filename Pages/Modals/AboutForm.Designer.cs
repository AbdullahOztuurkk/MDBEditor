
namespace MDBEditor.Pages
{
    partial class AboutForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutForm));
            this.TLP_About = new System.Windows.Forms.TableLayoutPanel();
            this.PB_Logo = new System.Windows.Forms.PictureBox();
            this.GB_About = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Lbl_Website = new System.Windows.Forms.LinkLabel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Lbl_Contribute = new System.Windows.Forms.LinkLabel();
            this.TLP_About.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Logo)).BeginInit();
            this.GB_About.SuspendLayout();
            this.SuspendLayout();
            // 
            // TLP_About
            // 
            this.TLP_About.ColumnCount = 2;
            this.TLP_About.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.TLP_About.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55F));
            this.TLP_About.Controls.Add(this.PB_Logo, 0, 0);
            this.TLP_About.Controls.Add(this.GB_About, 1, 0);
            this.TLP_About.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TLP_About.Location = new System.Drawing.Point(0, 0);
            this.TLP_About.Name = "TLP_About";
            this.TLP_About.RowCount = 1;
            this.TLP_About.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TLP_About.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TLP_About.Size = new System.Drawing.Size(608, 375);
            this.TLP_About.TabIndex = 0;
            // 
            // PB_Logo
            // 
            this.PB_Logo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PB_Logo.Image = global::MDBEditor.Properties.Resources.logo_with_text;
            this.PB_Logo.Location = new System.Drawing.Point(3, 3);
            this.PB_Logo.Name = "PB_Logo";
            this.PB_Logo.Size = new System.Drawing.Size(267, 369);
            this.PB_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PB_Logo.TabIndex = 0;
            this.PB_Logo.TabStop = false;
            // 
            // GB_About
            // 
            this.GB_About.Controls.Add(this.Lbl_Contribute);
            this.GB_About.Controls.Add(this.label2);
            this.GB_About.Controls.Add(this.richTextBox1);
            this.GB_About.Controls.Add(this.Lbl_Website);
            this.GB_About.Controls.Add(this.label1);
            this.GB_About.Location = new System.Drawing.Point(276, 3);
            this.GB_About.Name = "GB_About";
            this.GB_About.Size = new System.Drawing.Size(322, 369);
            this.GB_About.TabIndex = 1;
            this.GB_About.TabStop = false;
            this.GB_About.Text = "About";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(308, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "MDB Editor is open source image manipulation program.\r\nIts produced for alternati" +
    "ve of MSPaint.";
            // 
            // Lbl_Website
            // 
            this.Lbl_Website.AutoSize = true;
            this.Lbl_Website.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.Lbl_Website.Location = new System.Drawing.Point(6, 348);
            this.Lbl_Website.Name = "Lbl_Website";
            this.Lbl_Website.Size = new System.Drawing.Size(154, 15);
            this.Lbl_Website.TabIndex = 1;
            this.Lbl_Website.TabStop = true;
            this.Lbl_Website.Text = "Visit the MDBEditor Website";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Location = new System.Drawing.Point(7, 109);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(307, 227);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Contribute the MDBEditor Project";
            // 
            // Lbl_Contribute
            // 
            this.Lbl_Contribute.AutoSize = true;
            this.Lbl_Contribute.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.Lbl_Contribute.Location = new System.Drawing.Point(7, 83);
            this.Lbl_Contribute.Name = "Lbl_Contribute";
            this.Lbl_Contribute.Size = new System.Drawing.Size(68, 15);
            this.Lbl_Contribute.TabIndex = 4;
            this.Lbl_Contribute.TabStop = true;
            this.Lbl_Contribute.Text = "Github Link";
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 375);
            this.Controls.Add(this.TLP_About);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AboutForm";
            this.TLP_About.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PB_Logo)).EndInit();
            this.GB_About.ResumeLayout(false);
            this.GB_About.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TLP_About;
        private System.Windows.Forms.PictureBox PB_Logo;
        private System.Windows.Forms.GroupBox GB_About;
        private System.Windows.Forms.LinkLabel Lbl_Website;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel Lbl_Contribute;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}