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
        private AlbumsManager m_AlbumsManager;
        private WallHanndler  m_WallHandler;
        private AppController m_AppController;
        private FilesUploader m_FilesUploader;
        private bool          m_firstLaunch = true;


        //Login Methods

        private void initializeLoginForm()
        {
            m_LoginForm = new LoginForm();
            m_LoginForm.LoginSucessListeners += m_LoginForm_LoginSucess;
            m_LoginForm.LoginFailedListeners += m_LoginForm_LoginFailed;
        }

        private void m_LoginForm_LoginFailed()
        {
            Close();
        }

        private void m_LoginForm_LoginSucess(User i_LoggedUser)
        {
            InitializeComponent();
            m_AppController = new AppController() { User = i_LoggedUser };
            m_AlbumsManager = new AlbumsManager(m_AppController.User);
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

        // init (Form/Tab) Methods

        private void InitializeFormTabs()
        {
            initializeAlbumsTab();
            initializeProfileTab();
            initializeFeedTab();
            initializeFriendsTab();
        }

        private void initializeFriendsTab()
        {
            m_friendProfileComponent.AttachAFile.Click += FriendTabAttachAFile_Click;
            m_friendProfileComponent.GetEvents.Click += FriendTabGetEvents_Click;
        }

        private void FriendTabGetEvents_Click(object sender, EventArgs e)
        {
            if (m_AppController.Friend == null)
            {
                MessageBox.Show("Please select a friend first!");
            }
            else
            {
                try
                {
                    m_friendProfileComponent.ComponentBindingSourceUpcomingEvents.DataSource = m_AppController.Friend.Events;
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
            }
        }

        private void FriendTabAttachAFile_Click(object sender, EventArgs e)
        {
            if(m_AppController.Friend == null)
            {
                MessageBox.Show("Please select a friend first!");
            }
            else
            {
                m_FilesUploader.UploadAPhotoToTimeline(m_AlbumsManager, m_AppController.Friend);
            }
        }

        private void ProfileTabAttachAFile_Click(object sender, EventArgs e)
        {
            m_FilesUploader.UploadAPhotoToTimeline(m_AlbumsManager, m_AppController.User);
        }

        private void initializeProfileTab()
        {
            m_FilesUploader = new FilesUploader();
            m_userProfileComponent.AttachAFile.Click += ProfileTabAttachAFile_Click;
            m_userProfileComponent.GetEvents.Click += ProfileTabGetEvents_Click;
            m_userProfileComponent.ComponentPictureBoxProfilePic.ImageLocation = m_AppController.User.PictureLargeURL;
            m_userProfileComponent.ComponentTextBoxUserInfo.Text = m_AppController.GetFacebookUserInfo(m_AppController.User);
        }

        private void ProfileTabGetEvents_Click(object sender, EventArgs e)
        {
            try
            {
                m_userProfileComponent.ComponentBindingSourceUpcomingEvents.DataSource = m_AppController.User.Events;
            }

            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void initializeAlbumsTab()
        {
            foreach (Album album in m_AppController.User.Albums)
            {
                m_comboBoxAlbums.Items.Add(album.Name);
            }
        }

        private void initializeFeedTab()
        {
            m_WallHandler                         = new WallHanndler(m_AppController.User.WallPosts);
            m_PB_TabMain_CoverPhoto.ImageLocation = m_AlbumsManager.GetLatestPhotoURL("Cover Photos");
            m_PB_TabMain_CoverPhoto.SizeMode      = PictureBoxSizeMode.StretchImage;
            m_PB_TabMain_ProfilePic.ImageLocation = m_AppController.User.PictureLargeURL;
            m_PB_TabMain_ProfilePic.SizeMode      = PictureBoxSizeMode.StretchImage;
            m_LinkLabel_TabMain_FullName.Text     = m_AppController.User.Name;
            m_Label_TabMain_Email.Text            = m_AppController.User.Email;
            m_Label_TabMain_Birth.Text            = m_AppController.User.Birthday;
            m_Label_TabMain_Gender.Text           = m_AppController.User.Gender.ToString();
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
            m_AlbumsManager.SetCurrentAlbum(albumName);
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
            User friend = m_AppController.User.Friends.Find(x => x.Name == i_FriendName);
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
                m_AppController.Friend = friend;
                m_friendProfileComponent.ComponentPictureBoxProfilePic.ImageLocation = friend.PictureLargeURL;
                m_friendProfileComponent.ComponentTextBoxUserInfo.Text = m_AppController.GetFacebookUserInfo(friend);
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
            String profileUrl = m_AppController.User.Link;
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

        public void StartLoginSession()
        {
            initializeLoginForm();
            m_LoginForm.StartLoginSession();
        }
    } 
}