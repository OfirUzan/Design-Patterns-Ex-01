using System;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using Model;

namespace View
{
    public partial class FilesUploadForm : Form
    {
        #region Class Members / Properties
        private const string k_imageFilesStr = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
        private const string k_UploadTitle = "Select a picture";
        #endregion

        #region Class Methods
        public FilesUploadForm()
        {
            InitializeComponent();
        }

        public static void UploadAPhotoToTimeline(User i_User)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = k_UploadTitle;
            openFileDialog.Filter = k_imageFilesStr;

            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    AppFacade.UploadAPhotoToTimeline(i_User, openFileDialog.FileName);
                }
                catch (Exception uploadException)
                {
                    MessageBox.Show(uploadException.Message);
                }
            }
        }
        #endregion
    }
}
