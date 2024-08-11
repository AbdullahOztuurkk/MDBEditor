using System.Drawing;

namespace MDBEditor.Helpers;

public static class OpenImageHelper
{
    public static void OpenImage(this PictureBox pictureBox, Form form)
    {
        string fileName = string.Empty;
        using OpenFileDialog openFileDialog = new OpenFileDialog();
        openFileDialog.Title = SettingProvider.OpenFileTitle;
        openFileDialog.Filter = SettingProvider.OpenFileFilter;
        openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

        if (DialogResult.OK == openFileDialog.ShowDialog())
        {
            fileName = openFileDialog.SafeFileName.Substring(0, openFileDialog.SafeFileName.LastIndexOf('.'));
            if (pictureBox.IsPictureBoxEmptyOrNull())
            {
                pictureBox.Image = new Bitmap(openFileDialog.FileName);
            }
            else
            {
                if (DialogResult.Yes ==  MessageBox.Show(MessageProvider.OpenFileWhileUnsavedChanges, SettingProvider.OpenFileDialogTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                {
                    pictureBox.Image = new Bitmap(openFileDialog.FileName);
                }
            }
        }

        if (string.IsNullOrEmpty(fileName))
        {
            form.Text = string.Format(format: "{0} - {1}", SettingProvider.ApplicationName, fileName);
        }
    }

    public static void NewImage(this PictureBox pictureBox, Form form)
    {
        var isNewImage = false;
        if (pictureBox.IsPictureBoxEmptyOrNull())
        {
            pictureBox.Image = new Bitmap(pictureBox.Width, pictureBox.Height); ;
            isNewImage = true;
        }
        else
        {
            if (DialogResult.Yes == MessageBox.Show(MessageProvider.OpenFileWhileUnsavedChanges,SettingProvider.OpenFileDialogTitle,MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
            {
                pictureBox.Image = new Bitmap(pictureBox.Width, pictureBox.Height); ;
                isNewImage = true;
            }
        }

        if (isNewImage)
        {
            form.Text = string.Format(format: "{0} - {1}", SettingProvider.ApplicationName, SettingProvider.Untitled);
        }
    }
}
