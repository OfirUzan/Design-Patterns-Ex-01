﻿using System;
using System.Collections.Generic;
using System.Drawing;
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
        private WallHanndler m_WallHandler;

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
            initializeMyProfileTab();
            m_WallHandler = new WallHanndler(m_User.WallPosts);

        }

        private void initializeMyProfileTab()
        {
            m_userProfileComponent.ComponentPictureBoxProfilePic.ImageLocation = m_User.PictureLargeURL;
            m_userProfileComponent.ComponentTextBoxUserInfo.Text
                = string.Format(
@"Name: {0}
Gender: {1}
Birthday: {2}
Email: {3}
City: {4}
Education: {5}
Work: {6}
Status: {7}
About: {8}",
                m_User.Name,
                m_User.Gender,
                m_User.Birthday,
                m_User.Email,
                m_User.Hometown?.Name,
                m_User.Educations?[0].School?.Name,
                m_User.WorkExperiences?[0].Name,
                m_User.RelationshipStatus,
                m_User.About
);
            //Following code line is on comment to prevent an error and suppose to get user's events.
            //m_userProfileComponent.ComponentBindingSourceUpcomingEvents.DataSource = m_User.Events;
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
            makeRoundPictureBox(m_PB_TabProfile_ProfilePic, 3, 3);
            m_Label_TabProfile_Email.Text = m_User.Email;
            m_Label_TabProfile_Birth.Text = m_User.Birthday;
            Label_TabProfile_Gender.Text = m_User.Gender.ToString();
        }
        private void makeRoundPictureBox(PictureBox pictureBox, int i_WidthRound, int i_HeightRound)
        {
            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            gp.AddEllipse(0, 0, pictureBox.Width - i_WidthRound, pictureBox.Height - i_HeightRound);
            Region rg = new Region(gp);
            pictureBox.Region = rg;
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

        private User getAFriendOfTheUserByName(string i_FriendName)
        {
            User friend = m_User.Friends.Find(x => x.Name == i_FriendName);
            return friend;
        }

        private void m_buttonSearchAFriend_Click(object sender, EventArgs e)
        {
            User friend = getAFriendOfTheUserByName(m_textBoxFriendName.Text);

            if (friend != null)
            {
                m_friendProfileComponent.ComponentPictureBoxProfilePic.ImageLocation = friend.PictureLargeURL;
                m_friendProfileComponent.ComponentTextBoxUserInfo.Text
                    = string.Format(
    @"Name: {0}
Gender: {1}
Birthday: {2}
Email: {3}
City: {4}
Education: {5}
Work: {6}
Status: {7}
About: {8}",
                    friend.Name,
                    friend.Gender,
                    friend.Birthday,
                    friend.Email,
                    friend.Hometown?.Name,
                    friend.Educations?[0].School?.Name,
                    friend.WorkExperiences?[0].Name,
                    friend.RelationshipStatus,
                    friend.About
    );
                //Following code line is on comment to prevent an error and suppose to get user's events.
                //m_userProfileComponent.ComponentBindingSourceUpcomingEvents.DataSource = m_User.Events;
            }
            else
            {
                MessageBox.Show("Friend was not found.");
            }
        }

        private void m_textBoxFriendName_Click(object sender, EventArgs e)
        {
            m_textBoxFriendName.Text = string.Empty;
            (sender as TextBox).Click -= m_textBoxFriendName_Click;
        }

        private void m_Label_TabProfile_About_Click(object sender, EventArgs e)
        {

        }


        private void nextWallPost()
        {
            Post p = m_WallHandler.getNextWallPost();
            Comment c = m_WallHandler.getNextCommentOfCurrentPost();
            m_PB_Wall.ImageLocation = p.PictureURL;
            m_PB_Wall.SizeMode = PictureBoxSizeMode.StretchImage;
            m_Label_Wall_Date.Text = p.CreatedTime.ToString();
            m_Label_Wall_Name.Text = p.Name;
            m_RTB_Wall_Description.Text = p.Message;
            nextPostComment();
        }

        private void nextPostComment()
        {
            Comment c = m_WallHandler.getNextCommentOfCurrentPost();
            if (c == null)
            {
                m_RTB_Wall_Comment.Text = "No Comments";
            }
            else
            {
                m_RTB_Wall_Comment.Text = c.Message;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            nextPostComment();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            nextWallPost();

        }
    } 
}