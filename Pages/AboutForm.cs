using System.Diagnostics;
using System.Windows.Forms;

namespace MDBEditor.Pages
{
    public partial class AboutForm : Form
    {
        private readonly string ProjectUrl = "https://github.com/AbdullahOztuurkk/MDBEditor";
        public AboutForm()
        {
            InitializeComponent();
            Lbl_Contribute.LinkClicked += (sender, e) => Process.Start("explorer.exe", ProjectUrl);
            Lbl_Website.LinkClicked += (sender, e) => Process.Start("explorer.exe", ProjectUrl);
        }
    }
}
