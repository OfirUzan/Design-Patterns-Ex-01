using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Model;

namespace View
{
    public partial class FilesUploader : Form
    {
        private static readonly string sr_imageFilesStr = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";

        public FilesUploader()
        {
            InitializeComponent();
        }

        public void UploadAPhotoToTimeline(AlbumsManager i_AlbumsManager, User i_User)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Select a picture";
            openFileDialog.Filter = sr_imageFilesStr;

            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    i_AlbumsManager.UploadAPhotoToTimeline(i_User, openFileDialog.FileName);
                }
                catch (Exception uploadException)
                {
                    MessageBox.Show(uploadException.Message);
                }
            }
        }
    }
}
