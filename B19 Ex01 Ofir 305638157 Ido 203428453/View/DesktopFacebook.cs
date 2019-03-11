using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;
using Model;

namespace View
{
    public partial class DesktopFacebook : Form
    {
        private LoginForm     m_LoginForm;
        private User          m_User;
        private AlbumsManager m_AlbumsManager;
        private bool          m_firstLaunch = true;
        private WallHanndler  m_WallHandler;


        //Login Methods

        private void initializeLoginForm()
        {
            m_LoginForm = new LoginForm();
            m_LoginForm.LoginSucessListeners += m_LoginForm_LoginSucess;
            m_LoginForm.LoginFailedListeners += m_LoginForm_LoginFailed;
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

        public void StartLoginSession()
        {
            initializeLoginForm();
            m_LoginForm.StartLoginSession();
        }

        // init (Form/Tab) Methods

        private void InitializeFormTabs()
        {
            
            initializeMyAlbumsTab();
            initializeMyProfileTab();
            initializeTabMain();
            

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

        private void initializeTabMain()
        {
            m_WallHandler                         = new WallHanndler(m_User.WallPosts);
            m_PB_TabMain_CoverPhoto.ImageLocation = m_AlbumsManager.GetLatestPhotoURL("Cover Photos");
            m_PB_TabMain_CoverPhoto.SizeMode      = PictureBoxSizeMode.StretchImage;
            m_PB_TabMain_ProfilePic.ImageLocation = m_User.PictureLargeURL;
            m_PB_TabMain_ProfilePic.SizeMode      = PictureBoxSizeMode.StretchImage;
            m_LinkLabel_TabMain_FullName.Text     = m_User.Name;
            m_Label_TabMain_Email.Text            = m_User.Email;
            m_Label_TabMain_Birth.Text            = m_User.Birthday;
            m_Label_TabMain_Gender.Text           = m_User.Gender.ToString();
            makeRoundPictureBox(m_PB_TabMain_ProfilePic, 3, 3);
            this.nextWallPost();
        }

        // UI Methods
        private void makeRoundPictureBox(PictureBox pictureBox, int i_WidthRound, int i_HeightRound)
        {
            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            gp.AddEllipse(0, 0, pictureBox.Width - i_WidthRound, pictureBox.Height - i_HeightRound);
            Region rg = new Region(gp);
            pictureBox.Region = rg;
        }

        // Other Tab Methods

        private void m_comboBoxAlbums_SelectedIndexChanged(object sender, EventArgs e)
        {
            m_buttonNextPic.Enabled = true;
            m_buttonPrevoiusPic.Enabled = true;
            string albumName = m_comboBoxAlbums.SelectedItem.ToString();
            m_AlbumsManager.setCurrentAlbum(albumName);
            createThreadsForAlbumPhotosNextClick();
        }

        private void createThreadsForAlbumPhotosNextClick()
        {
            PictureBoxThread[] pictureBoxThreads = new PictureBoxThread[8];

            for (int i = 0; i < m_userAlbumPicturesComponent.NumOfPictureBoxes; ++i)
            {
                pictureBoxThreads[i] = new PictureBoxThread();
                pictureBoxThreads[i].PictureBoxIndex = i;
            }

            foreach (PictureBoxThread pictureBoxThread in pictureBoxThreads)
            {
                pictureBoxThread.Thread = new System.Threading.Thread(() => updateUserPhotoOnAlbumNextClick(pictureBoxThread.PictureBoxIndex));
                pictureBoxThread.Thread.Start();
            }
        }

        private void createThreadsForAlbumPhotosPreviousClick()
        {
            PictureBoxThread[] pictureBoxThreads = new PictureBoxThread[8];

            for (int i = 0; i < m_userAlbumPicturesComponent.NumOfPictureBoxes; ++i)
            {
                pictureBoxThreads[i] = new PictureBoxThread();
                pictureBoxThreads[i].PictureBoxIndex = i;
            }

            foreach (PictureBoxThread pictureBoxThread in pictureBoxThreads)
            {
                pictureBoxThread.Thread = new System.Threading.Thread(() => updateUserPhotoOnAlbumPreviousClick(pictureBoxThread.PictureBoxIndex));
                pictureBoxThread.Thread.Start();
            }
        }

        private void updateUserPhotoOnAlbumNextClick(int i_PictureBoxIndex)
        {
            m_userAlbumPicturesComponent.PictureBoxes[i_PictureBoxIndex].ImageLocation = m_AlbumsManager.GetNextPhotoURL();
            m_userAlbumPicturesComponent.PictureBoxes[i_PictureBoxIndex].SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void updateUserPhotoOnAlbumPreviousClick(int i_PictureBoxIndex)
        {
            m_userAlbumPicturesComponent.PictureBoxes[i_PictureBoxIndex].ImageLocation = m_AlbumsManager.GetPreviousPhotoURL();
            m_userAlbumPicturesComponent.PictureBoxes[i_PictureBoxIndex].SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            createThreadsForAlbumPhotosNextClick();
        }

        private void m_buttonPrevoiusPic_Click(object sender, EventArgs e)
        {
            createThreadsForAlbumPhotosPreviousClick();
        }

        private User getAFriendOfTheUserByName(string i_FriendName)
        {
            User friend = m_User.Friends.Find(x => x.Name == i_FriendName);
            return friend;
        }

        // Wall Methods

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
                m_Label_Wall_Comment_Date.Text = "";
                m_LinkLabel_Wall_CommentInfo.Visible = false;


            }
            else
            {
                m_RTB_Wall_Comment.Text = c.Message;
                m_Label_Wall_Comment_Date.Text = c.CreatedTime.ToString();
                m_LinkLabel_Wall_CommentInfo.Visible = true;
            }
        }
        
        // on Click Methods
        private void buttonLogout_Click(object sender, EventArgs e)
        {
            Hide();
            initializeLoginForm();
            m_LoginForm.LogoutUser();
        }

        private void buttonUpload_Click(object sender, EventArgs e)
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

        private void label_TabProfile_About_Click(object sender, EventArgs e)
        {

        }

        private void textBoxFriendName_Click(object sender, EventArgs e)
        {
            m_textBoxFriendName.Text = string.Empty;
            (sender as TextBox).Click -= textBoxFriendName_Click;
        }

        private void button_Wall_NextComment_Click(object sender, EventArgs e)
        {
            nextPostComment();
        }

        private void button_SearchAFriend_Click(object sender, EventArgs e)
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

        private void button_Wall_NextPost_Click(object sender, EventArgs e)
        {          
           
            nextWallPost();

        }

        private void button_TabMain_Friends_Click(object sender, EventArgs e)
        {
            m_tabsControl.SelectedTab = m_TabFriends;
        }

        private void button_TabMain_Albums_Click(object sender, EventArgs e)
        {
            m_tabsControl.SelectedTab = m_TabAlbums;
        }

        private void button_TabMain_Profile_Click(object sender, EventArgs e)
        {
            m_tabsControl.SelectedTab = m_TabProfile;
        }

        private void linkLabel_TabMain_FullName_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            String profileUrl = m_User.Link;
            ProcessStartInfo sInfo = new ProcessStartInfo(profileUrl);
            Process.Start(sInfo);
        }

        private void linkLabel_Wall_CommentInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            String commentUrl = "https://www.facebook.com/" + m_WallHandler.getCommentID();
            ProcessStartInfo sInfo = new ProcessStartInfo(commentUrl);
            Process.Start(sInfo);
        }

        private void linkLabel_Wall_PostLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ProcessStartInfo sInfo = new ProcessStartInfo(m_WallHandler.getPostId());
            Process.Start(sInfo);
        }
    } 
}