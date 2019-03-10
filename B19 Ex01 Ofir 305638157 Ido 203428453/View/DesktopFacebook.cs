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
        private int m_nextCounter;
        private User m_User;
        private AlbumsManager m_AlbumsManager;
        private bool m_firstLaunch = true;

        private void initializeLoginForm()
        {
            m_LoginForm = new LoginForm();
            m_LoginForm.LoginSucessListeners += m_LoginForm_LoginSucess;
            m_LoginForm.LoginFailedListeners += m_LoginForm_LoginFailed;
        }

        public void StartLoginSession()
        {
            initializeLoginForm();
            m_LoginForm.StartLoginSession();
        }

        private void m_LoginForm_LoginFailed(User i_User)
        {
            Close();
        }

        private void m_LoginForm_LoginSucess(User i_LoggedUser)
        {
            m_User = i_LoggedUser;
            InitializeComponent();
            m_AlbumsManager = new AlbumsManager(m_User);
            InitializeFormTabs();
            if (m_firstLaunch)
            {
                m_firstLaunch = false;
                ShowDialog();
            }
            else
            {
                Show();
            }
        }

        private void InitializeFormTabs()
        {
            initializeProfileTab();
            initializeMyAlbumsTab();
        }

        private void initializeMyAlbumsTab()
        {
            foreach (Album album in m_User.Albums)
            {
                m_comboBoxAlbums.Items.Add(album.Name);
            }
        }

        private void initializeProfileTab()
        {
            m_PB_TabProfile_CoverPhoto.ImageLocation = m_AlbumsManager.GetLatestPhotoURL("Cover Photos");
            m_PB_TabProfile_CoverPhoto.SizeMode = PictureBoxSizeMode.StretchImage;
            m_PB_TabProfile_ProfilePic.ImageLocation = m_User.PictureLargeURL;
            m_PB_TabProfile_ProfilePic.SizeMode = PictureBoxSizeMode.StretchImage;
            m_LinkLabel_TabProfile_FullName.Text = m_User.Name;

            m_Label_TabProfile_Email.Text = m_User.Email;
            //m_Label_TabProfile_Lives.Text = m_User.Hometown.Name;
            m_Label_TabProfile_Birth.Text = m_User.Birthday;
            m_Label_TabProfile_Relationship.Text = m_User.RelationshipStatus.ToString();
            m_Label_TabProfile_About.Text = m_User.About;
        }

        private void m_comboBoxAlbums_SelectedIndexChanged(object sender, EventArgs e)
        {
            m_nextCounter = 1;
            string albumName = m_comboBoxAlbums.SelectedItem.ToString();
            m_AlbumsManager.setCurrentAlbum(albumName);
            m_pictureBoxCurrentPic.ImageLocation = m_AlbumsManager.GetLatestPhotoURL(albumName);
            m_pictureBoxCurrentPic.SizeMode = PictureBoxSizeMode.StretchImage;
            m_labelPicNumber.Text = m_nextCounter.ToString() + " / " + m_AlbumsManager.CurrentAlbumPhotosURL.Count.ToString();
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            m_nextCounter = (m_nextCounter + 1) % m_AlbumsManager.CurrentAlbumPhotosURL.Count;
            string nextPhotoUrl = m_AlbumsManager.GetNextPhotoURL();
            m_pictureBoxCurrentPic.ImageLocation = nextPhotoUrl;
            m_labelPicNumber.Text = m_nextCounter.ToString() + " / " + m_AlbumsManager.CurrentAlbumPhotosURL.Count.ToString();
        }

        private void m_buttonPrevoiusPic_Click(object sender, EventArgs e)
        {
            m_nextCounter = (m_nextCounter - 1) % m_AlbumsManager.CurrentAlbumPhotosURL.Count;
            string previousPhotoUrl = m_AlbumsManager.GetPreviousPhotoURL();
            m_pictureBoxCurrentPic.ImageLocation = previousPhotoUrl;
            m_labelPicNumber.Text = m_nextCounter.ToString() + " / " + m_AlbumsManager.CurrentAlbumPhotosURL.Count.ToString();
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

        private void m_buttonLogout_Click(object sender, EventArgs e)
        {
            Hide();
            initializeLoginForm();
            m_LoginForm.LogoutUser();
        }
    } 
}