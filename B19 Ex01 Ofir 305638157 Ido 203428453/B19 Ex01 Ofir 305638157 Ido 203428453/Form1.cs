using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FacebookWrapper;

namespace B19_Ex01_Ofir_305638157_Ido_203428453
{
    public partial class Form1 : Form
    {
        private User m_User;
        private AlbumsManager m_AlbumsManager;
        private LinkedList<string> m_CurrentAlbumPhotosURL;

        public Form1()
        {
            InitializeComponent();
            //FacebookWrapper.FacebookService.s_CollectionLimit = 200;
            //FacebookWrapper.FacebookService.s_FbApiVersion = 2.8f;
        }

        private void loginAndInit()
        {
            //LoginResult res = FacebookService.Login("451139335614057", "public_profile", "email", "user_friends", "user_photos", "user_birthday", "user_likes", "manage_pages", "user_events", "user_hometown", "user_posts", "user_tagged_places", "user_location");
           
            m_User = FacebookService.Connect("EAAGaTwZCX7mkBABYUROUeIUZCn3DxkhqDkP4ZBEfkGptrWSWkqhsrJfZCYMlbtRWz8FhtdcXZA2ByMqOVx7n7ktg8zHecBc170pw7En2Ohg1EgV7ErRrz1mEzDi0sykK8D6IDnVuAKQXjSsZCSkpTDQ4PjH61288pqyOoMSQZAGQQZDZD").LoggedInUser;
            m_AlbumsManager = new AlbumsManager(m_User);
            m_PB_UserProfilePic.LoadAsync(m_User.PictureNormalURL);
            label1.Text = m_User.FirstName;
            label2.Text = m_User.LastName;
        }

        private void fetchAlbums()
        {
            foreach (Album album in m_User.Albums)
            {
                m_comboBoxAlbums.Items.Add(album.Name);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            loginAndInit();
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
