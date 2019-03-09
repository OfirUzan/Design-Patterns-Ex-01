using System;
using System.Collections.Generic;
using System.Windows.Forms;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;
using Model;

namespace View
{
    public partial class DesktopFacebook : Form
    {
        private LoginForm m_LoginForm;
        public DesktopFacebook()
        {
            m_LoginForm = new LoginForm();
            m_LoginForm.LoginSucess += m_LoginForm_LoginSucess;
            m_LoginForm.LoginFailed += m_LoginForm_LoginFailed;
        }

        public void StartLoginSession()
        {
            m_LoginForm.ShowDialog();
        }

        private void m_LoginForm_LoginFailed()
        {
            Close();
        }

        private void m_LoginForm_LoginSucess()
        {
            InitializeComponent();
            m_AlbumsManager = new AlbumsManager(m_User);
            ShowDialog();
        }

        private User m_User;
        private AlbumsManager m_AlbumsManager;
        private LinkedList<string> m_CurrentAlbumPhotosURL;

        private void fetchAlbums()
        {
            foreach (Album album in m_User.Albums)
            {
                m_comboBoxAlbums.Items.Add(album.Name);
            }
        }

        private void m_comboBoxAlbums_SelectedIndexChanged(object sender, EventArgs e)
        {
            string albumName = m_comboBoxAlbums.SelectedItem.ToString();
            m_AlbumsManager.setCurrentAlbum(albumName);
            m_pictureBoxCurrentPic.ImageLocation = m_AlbumsManager.GetLatestPhotoURL(albumName);
            m_pictureBoxCurrentPic.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            string nextPhotoUrl = m_AlbumsManager.GetNextPhotoURL();
            m_pictureBoxCurrentPic.ImageLocation = nextPhotoUrl;
        }

        private void m_buttonPrevoiusPic_Click(object sender, EventArgs e)
        {
            string previousPhotoUrl = m_AlbumsManager.GetPreviousPhotoURL();
            m_pictureBoxCurrentPic.ImageLocation = previousPhotoUrl;
        }

        private void tabProfile_Click(object sender, EventArgs e)
        {
            m_PB_TabProfile_CoverPhoto.ImageLocation = m_AlbumsManager.GetLatestPhotoURL("Cover Photos");
            m_PB_TabProfile_CoverPhoto.SizeMode = PictureBoxSizeMode.StretchImage;
            m_PB_TabProfile_ProfilePic.ImageLocation = m_User.PictureLargeURL;
            m_PB_TabProfile_ProfilePic.SizeMode = PictureBoxSizeMode.StretchImage;
            m_LinkLabel_TabProfile_FullName.Text = m_User.Name;

            m_Label_TabProfile_Email.Text = m_User.Email;
            m_Label_TabProfile_Lives.Text = m_User.Hometown.Name;
            m_Label_TabProfile_Birth.Text = m_User.Birthday;
            m_Label_TabProfile_Relationship.Text = m_User.RelationshipStatus.ToString();
            m_Label_TabProfile_About.Text = m_User.About;
        }

        private void tabAlbum_Click(object sender, EventArgs e)
        {
            fetchAlbums();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab.Text == "Profile")
            {
                tabProfile_Click(sender, e);
            }

            else
            {
                tabAlbum_Click(sender, e);
            }
        }

        private void m_buttonUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Select a picture";
            openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";

            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    MessageBox.Show("Uploaded successfuly!");
                }
                catch (Exception uploadException)
                {
                    MessageBox.Show(uploadException.Message);
                }
            }
        }
    } 
}
