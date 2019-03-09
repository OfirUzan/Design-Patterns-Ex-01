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
            m_User = FacebookService.Connect("EAAGaTwZCX7mkBALhG2IpO6nHDW8omIfWaZAT2CVemRYIZCzWazlx3e8quq7kZA9ZCnJ5FweoJx7KlXbum38u4blTPOPyzY4EZBVZCRrXkNaZBQabYq8DDOLfgEDIz8pcx0GT8jZBuC5HzfNlaxL3AUUMR8lQbraKLH2aVZBmZC2ZCPgrjgZDZD").LoggedInUser;
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
    } 
}
