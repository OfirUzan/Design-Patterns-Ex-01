using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using Model;

namespace View
{
    public partial class DesktopFacebook : Form
    {
        // ** Class Properties ** //
        public LoginForm LoginForm { get; set; }
        public AppController AppController { get; set; }
        public AlbumsManager AlbumsManager { get; set; }
        public WallManager WallManager{ get; set; }
        public FilesUploader FilesUploader { get; set; }
        public BrowserLauncher BrowserLauncher { get; set; }
        private bool          m_firstLaunch = true;


        // ** Login Methods ** //
        private void initializeLoginForm()
        {
            LoginForm = new LoginForm();
            LoginForm.LoginSucessListeners += m_LoginForm_LoginSucess;
            LoginForm.LoginFailedListeners += m_LoginForm_LoginFailed;
        }

        private void m_LoginForm_LoginFailed()
        {
            Close();
        }

        private void m_LoginForm_LoginSucess(User i_LoggedUser)
        {
            InitializeComponent();
            AppController = new AppController() { User = i_LoggedUser };
            AlbumsManager = new AlbumsManager(AppController.User);
            WallManager = new WallManager(AppController.User.WallPosts);
            FilesUploader = new FilesUploader();
            BrowserLauncher = new BrowserLauncher();
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


        // ** Tabs Init Methods** //
        private void InitializeFormTabs()
        {
            initializeFeedTab();
            initializeAlbumsTab();
            initializeProfileTab();
            initializeFriendsTab();
        }

        private void initializeFeedTab()
        {
            m_pictureBox_Feed_CoverPhoto.ImageLocation = AlbumsManager.GetLatestPhotoURL("Cover Photos");
            m_pictureBox_Feed_CoverPhoto.SizeMode = PictureBoxSizeMode.StretchImage;
            m_pictureBox_Feed_ProfilePic.ImageLocation = AppController.User.PictureLargeURL;
            m_pictureBox_Feed_ProfilePic.SizeMode = PictureBoxSizeMode.StretchImage;
            m_linkLabel_Feed_FullName.Text = AppController.User.Name;
            m_label_Feed_Email.Text = AppController.User.Email;
            m_label_Feed_Birthday.Text = AppController.User.Birthday;
            m_Label_TabMain_Gender.Text = AppController.User.Gender.ToString();
            makeRoundPictureBox(m_pictureBox_Feed_ProfilePic, 3, 3);
            this.nextWallPost();
        }

        private void initializeAlbumsTab()
        {
            foreach (Album album in AppController.User.Albums)
            {
                m_comboBox_Albums_AlbumsList.Items.Add(album.Name);
            }
        }

        private void initializeProfileTab()
        {
            m_userProfileComponent_Profile.ButtonAttachAFile.Click += ProfileTab_AttachAFile_Click;
            m_userProfileComponent_Profile.ButtonGetEvents.Click += ProfileTab_GetEvents_Click;
            m_userProfileComponent_Profile.ButtonPost.Click += ProfileTab_Post_Click;
            m_userProfileComponent_Profile.PictureBoxProfilePic.ImageLocation = AppController.User.PictureLargeURL;
            m_userProfileComponent_Profile.TextBoxUserInfo.Text = AppController.GetFacebookUserInfo(AppController.User);
        }

        private void initializeFriendsTab()
        {
            m_userProfileComponent_Friends.ButtonAttachAFile.Click += FriendsTab_AttachAFile_Click;
            m_userProfileComponent_Friends.ButtonGetEvents.Click += FriendsTab_GetEvents_Click;
            m_userProfileComponent_Friends.ButtonPost.Click += FriendsTabButtonPost_Click;
        }


        // ** OnClick Methods ** //
        private void FeedTab_Logout_Click(object sender, EventArgs e)
        {
            Hide();
            initializeLoginForm();
            LoginForm.LogoutUser();
        }

        private void FeedTab_NextComment_Click(object sender, EventArgs e)
        {
            nextPostComment();
        }

        private void FeedTab_NextPost_Click(object sender, EventArgs e)
        {
            nextWallPost();
        }

        private void FeedTab_Friends_Click(object sender, EventArgs e)
        {
            m_tabsControl.SelectedTab = m_tabPage_Friends;
        }

        private void FeedTab_Albums_Click(object sender, EventArgs e)
        {
            m_tabsControl.SelectedTab = m_tabPage_Albums;
        }

        private void FeedTab_Profile_Click(object sender, EventArgs e)
        {
            m_tabsControl.SelectedTab = m_tabPage_Profile;
        }

        private void FeedTab_linkLabelFullName_Click(object sender, LinkLabelLinkClickedEventArgs e)
        {
            BrowserLauncher.LaunchBrowser(AppController.User.Link);
        }

        private void FeedTab_linkLabelCommentInfo_Click(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string commentUrl = "https://www.facebook.com/" + WallManager.GetCommentID();
            BrowserLauncher.LaunchBrowser(commentUrl);
        }

        private void FeedTab_linkLabelPostLink_Click(object sender, LinkLabelLinkClickedEventArgs e)
        {
            BrowserLauncher.LaunchBrowser(WallManager.GetPostId());
        }

        private void AlbumsTab_Next_Click(object sender, EventArgs e)
        {
            AppController.UpdatePhotosOnAlbumsTab(updateNextUserPhotosOnAlbumsTab, m_userAlbumPicturesComponent_Albums.NumOfPictureBoxes);
        }

        private void AlbumsTab_Previous_Click(object sender, EventArgs e)
        {
            AppController.UpdatePhotosOnAlbumsTab(updatePreviousUserPhotosOnAlbumsTab, m_userAlbumPicturesComponent_Albums.NumOfPictureBoxes);
        }

        private void ProfileTab_Post_Click(object sender, EventArgs e)
        {
            string postText = m_userProfileComponent_Profile.TextBoxPostText.Text;
            postToWall(AppController.User, postText);
        }

        private void ProfileTab_GetEvents_Click(object sender, EventArgs e)
        {
            try
            {
                m_userProfileComponent_Profile.BindingSourceUpcomingEvents.DataSource = AppController.User.Events;
            }

            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void ProfileTab_AttachAFile_Click(object sender, EventArgs e)
        {
            FilesUploader.UploadAPhotoToTimeline(AlbumsManager, AppController.User);
        }

        private void FriendsTabButtonPost_Click(object sender, EventArgs e)
        {
            if (AppController.Friend == null)
            {
                MessageBox.Show("Please select a friend first!");
            }
            else
            {
                string postText = m_userProfileComponent_Friends.TextBoxPostText.Text;
                postToWall(AppController.Friend, postText);
            }
        }

        private void FriendsTab_GetEvents_Click(object sender, EventArgs e)
        {
            if (AppController.Friend == null)
            {
                MessageBox.Show("Please select a friend first!");
            }
            else
            {
                try
                {
                    m_userProfileComponent_Friends.BindingSourceUpcomingEvents.DataSource = AppController.Friend.Events;
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
            }
        }

        private void FriendsTab_AttachAFile_Click(object sender, EventArgs e)
        {
            if (AppController.Friend == null)
            {
                MessageBox.Show("Please select a friend first!");
            }
            else
            {
                FilesUploader.UploadAPhotoToTimeline(AlbumsManager, AppController.Friend);
            }
        }

        private void FriendsTab_Search_Click(object sender, EventArgs e)
        {
            User friend = getAFriendOfTheUserByName(m_textBox_Friends_FriendName.Text);

            if (friend != null)
            {
                AppController.Friend = friend;
                m_userProfileComponent_Friends.PictureBoxProfilePic.ImageLocation = friend.PictureLargeURL;
                m_userProfileComponent_Friends.TextBoxUserInfo.Text = AppController.GetFacebookUserInfo(friend);
            }
            else
            {
                MessageBox.Show("Friend was not found.");
            }
        }

        private void FriendsTab_textBoxFriendName_Click(object sender, EventArgs e)
        {
            m_textBox_Friends_FriendName.Text = string.Empty;
            (sender as TextBox).Click -= FriendsTab_textBoxFriendName_Click;
        }


        // ** OnItemSelected Methods ** //
        private void AlbumsTab_ComboBoxAlbums_AlbumSelected(object sender, EventArgs e)
        {
            m_button_Albums_Next.Enabled = true;
            m_button_Albums_Prevoius.Enabled = true;
            string albumName = m_comboBox_Albums_AlbumsList.SelectedItem.ToString();
            AlbumsManager.SetCurrentAlbum(albumName);
            AppController.UpdatePhotosOnAlbumsTab(updateNextUserPhotosOnAlbumsTab, m_userAlbumPicturesComponent_Albums.NumOfPictureBoxes);
        }


        // ** Class Methods ** //
        private void makeRoundPictureBox(PictureBox pictureBox, int i_WidthRound, int i_HeightRound)
        {
            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            gp.AddEllipse(0, 0, pictureBox.Width - i_WidthRound, pictureBox.Height - i_HeightRound);
            Region rg = new Region(gp);
            pictureBox.Region = rg;
        }

        private User getAFriendOfTheUserByName(string i_FriendName)
        {
            return AppController.User.Friends.Find(x => x.Name == i_FriendName);
        }

        private void updateNextUserPhotosOnAlbumsTab(int i_PictureBoxIndex)
        {
            m_userAlbumPicturesComponent_Albums.PictureBoxes[i_PictureBoxIndex].ImageLocation = AlbumsManager.GetNextPhotoURL();
            m_userAlbumPicturesComponent_Albums.PictureBoxes[i_PictureBoxIndex].SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void updatePreviousUserPhotosOnAlbumsTab(int i_PictureBoxIndex)
        {
            m_userAlbumPicturesComponent_Albums.PictureBoxes[i_PictureBoxIndex].ImageLocation = AlbumsManager.GetPreviousPhotoURL();
            m_userAlbumPicturesComponent_Albums.PictureBoxes[i_PictureBoxIndex].SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void nextWallPost()
        {
            Post p = WallManager.GetNextWallPost();
            Comment c = WallManager.GetNextCommentOfCurrentPost();
            m_pictureBox_Feed_PostPic.ImageLocation = p.PictureURL;
            m_pictureBox_Feed_PostPic.SizeMode = PictureBoxSizeMode.StretchImage;
            m_label_Feed_PostDate.Text = p.CreatedTime.ToString();
            m_label_Feed_PostName.Text = p.Name;
            m_richTextBox_Feed_PostDescription.Text = p.Message;
            nextPostComment();
        }

        private void nextPostComment()
        {
            Comment c = WallManager.GetNextCommentOfCurrentPost();
            if (c == null)
            {
                m_richTextBox_Feed_CommentText.Text = "No Comments";
                m_label_Feed_CommentDate.Text = "";
                m_linkLabel_Feed_PostInfo.Visible = false;


            }
            else
            {
                m_richTextBox_Feed_CommentText.Text = c.Message;
                m_label_Feed_CommentDate.Text = c.CreatedTime.ToString();
                m_linkLabel_Feed_PostInfo.Visible = true;
            }
        }

        private void postToWall(User i_User, string i_postText)
        {
            if (i_postText != string.Empty && i_postText != "Do you want to say anything?")
            {
                try
                {
                    WallManager.PostToWall(i_User, i_postText);
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
            }
            else
            {
                MessageBox.Show("Please insert a text to post!");
            }
        }
        
        public void StartLoginSession()
        {
            initializeLoginForm();
            LoginForm.StartLoginSession();
        }
    } 
}