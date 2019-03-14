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
        #region Class Members / Properties

        private LoginForm       m_loginForm;
        private AppController   m_appController;
        private AlbumsManager   m_albumsManager;
        private WallManager     m_wallManager;
        private FilesUploader   m_filesUploader;
        private FaceRideManager m_faceRideManager;
        private RideForm        m_rideForm;
        private bool            m_firstLaunch = true;

        #endregion

        #region Login Methods
        private void initializeLoginForm()
        {
            m_loginForm = new LoginForm();
            m_loginForm.LoginSucessListeners += m_LoginForm_LoginSucess;
            m_loginForm.LoginFailedListeners += m_LoginForm_LoginFailed;
        }

        private void m_LoginForm_LoginFailed()
        {
            Close();
        }

        private void m_LoginForm_LoginSucess(User i_LoggedUser)
        {
            InitializeComponent();
            m_appController = new AppController() { User = i_LoggedUser };
            m_albumsManager = new AlbumsManager(m_appController.User);
            m_wallManager = new WallManager(m_appController.User.WallPosts);
            m_filesUploader = new FilesUploader();
            m_faceRideManager = new FaceRideManager();
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

        #endregion

        #region Tabs Init Methods

        private void InitializeFormTabs()
        {
            //Use threads to init each tab FAST !!!
            new System.Threading.Thread(() => initializeFeedTab()).Start();
            new System.Threading.Thread(() => initializeAlbumsTab()).Start();
            new System.Threading.Thread(() => initializeProfileTab()).Start();
            new System.Threading.Thread(() => initializeFriendsTab()).Start();
        }

        private void initializeFeedTab()
        {
            m_pictureBox_Feed_CoverPhoto.ImageLocation = m_albumsManager.GetLatestPhotoURL("Cover Photos");
            m_pictureBox_Feed_CoverPhoto.SizeMode = PictureBoxSizeMode.StretchImage;
            m_pictureBox_Feed_ProfilePic.ImageLocation = m_appController.User.PictureLargeURL;
            m_pictureBox_Feed_ProfilePic.SizeMode = PictureBoxSizeMode.StretchImage;
            m_linkLabel_Feed_FullName.Text = m_appController.User.Name;
            m_label_Feed_Email.Text = m_appController.User.Email;
            m_label_Feed_Birthday.Text = m_appController.User.Birthday;
            m_Label_TabMain_Gender.Text = m_appController.User.Gender.ToString();
            makeRoundPictureBox(m_pictureBox_Feed_ProfilePic, 3, 3);
            this.nextWallPost();
        }

        private void initializeAlbumsTab()
        {
            foreach (Album album in m_appController.User.Albums)
            {
                m_comboBox_Albums_AlbumsList.Items.Add(album.Name);
            }

            foreach(PictureBox pictureBox in m_userAlbumPicturesComponent_Albums.PictureBoxes)
            {
                pictureBox.Click += AlbumsTab_PictureBox_Click;
            }
        }

        private void initializeProfileTab()
        {
            m_userProfileComponent_Profile.ButtonAttachAFile.Click += ProfileTab_AttachAFile_Click;
            m_userProfileComponent_Profile.ButtonGetEvents.Click += ProfileTab_GetEvents_Click;
            m_userProfileComponent_Profile.ButtonPost.Click += ProfileTab_Post_Click;
            m_userProfileComponent_Profile.PictureBoxProfilePic.ImageLocation = m_appController.User.PictureLargeURL;
            m_userProfileComponent_Profile.TextBoxUserInfo.Text = m_appController.GetFacebookUserInfo(m_appController.User);
        }

        private void initializeFriendsTab()
        {
            m_userProfileComponent_Friends.ButtonAttachAFile.Click += FriendsTab_AttachAFile_Click;
            m_userProfileComponent_Friends.ButtonGetEvents.Click += FriendsTab_GetEvents_Click;
            m_userProfileComponent_Friends.ButtonPost.Click += FriendsTabButtonPost_Click;
        }

        #endregion

        #region Feed Tab Methods

        private void FeedTab_Logout_Click(object sender, EventArgs e)
        {
            Hide();
            initializeLoginForm();
            m_loginForm.LogoutUser();
        }

        private void FeedTab_NextComment_Click(object sender, EventArgs e)
        {
            nextPostComment();
        }

        private void FeedTab_NextPost_Click(object sender, EventArgs e)
        {
            nextWallPost();
        }

        private void FeedTab_FriendsButton_Click(object sender, EventArgs e)
        {
            m_tabsControl.SelectedTab = m_tabPage_Friends;
        }

        private void FeedTab_AlbumsButton_Click(object sender, EventArgs e)
        {
            m_tabsControl.SelectedTab = m_tabPage_Albums;
        }

        private void FeedTab_ProfileButton_Click(object sender, EventArgs e)
        {
            m_tabsControl.SelectedTab = m_tabPage_Profile;
        }

        private void FeedTab_FaceRideButton_Click(object sender, EventArgs e)
        {
            m_tabsControl.SelectedTab = m_tabPage_FaceRide;
        }

        private void FeedTab_linkLabelFullName_Click(object sender, LinkLabelLinkClickedEventArgs e)
        {
            launchBrowser(m_appController.User.Link);
        }

        private void FeedTab_linkLabelCommentInfo_Click(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string commentUrl = "https://www.facebook.com/" + m_wallManager.GetCommentID();
            launchBrowser(commentUrl);
        }

        private void FeedTab_linkLabelPostLink_Click(object sender, LinkLabelLinkClickedEventArgs e)
        {
            launchBrowser(m_wallManager.GetPostId());
        }

        private void nextWallPost()
        {
            Post p = m_wallManager.GetNextWallPost();
            Comment c = m_wallManager.GetNextCommentOfCurrentPost();
            m_pictureBox_Feed_PostPic.ImageLocation = p.PictureURL;
            m_pictureBox_Feed_PostPic.SizeMode = PictureBoxSizeMode.StretchImage;
            m_label_Feed_PostDate.Text = p.CreatedTime.ToString();
            m_label_Feed_PostName.Text = p.Name;
            m_richTextBox_Feed_PostDescription.Text = p.Message;
            nextPostComment();
        }

        private void nextPostComment()
        {
            Comment c = m_wallManager.GetNextCommentOfCurrentPost();
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

        #endregion

        #region Albums Tab Methods

        private void AlbumsTab_Next_Click(object sender, EventArgs e)
        {
            m_appController.UpdatePhotosOnAlbumsTab(updateNextUserPhotosOnAlbumsTab, m_userAlbumPicturesComponent_Albums.NumOfPictureBoxes);
        }

        private void AlbumsTab_Previous_Click(object sender, EventArgs e)
        {
            m_appController.UpdatePhotosOnAlbumsTab(updatePreviousUserPhotosOnAlbumsTab, m_userAlbumPicturesComponent_Albums.NumOfPictureBoxes);
        }

        private void AlbumsTab_PictureBox_Click(object sender, EventArgs e)
        {
            LargePhotoForm largePhotoForm = new LargePhotoForm();
            largePhotoForm.Picture.ImageLocation = (sender as PictureBox).ImageLocation;
            largePhotoForm.Show();
        }

        private void AlbumsTab_ComboBoxAlbums_AlbumSelected(object sender, EventArgs e)
        {
            foreach (PictureBox pictureBox in m_userAlbumPicturesComponent_Albums.PictureBoxes)
            {
                pictureBox.Cursor = Cursors.Hand;
            }
            m_button_Albums_Next.Enabled = true;
            m_button_Albums_Prevoius.Enabled = true;
            string albumName = m_comboBox_Albums_AlbumsList.SelectedItem.ToString();
            m_albumsManager.SetCurrentAlbum(albumName);
            m_appController.UpdatePhotosOnAlbumsTab(updateNextUserPhotosOnAlbumsTab, m_userAlbumPicturesComponent_Albums.NumOfPictureBoxes);
        }

        private void updateNextUserPhotosOnAlbumsTab(int i_PictureBoxIndex)
        {
            m_userAlbumPicturesComponent_Albums.PictureBoxes[i_PictureBoxIndex].ImageLocation = m_albumsManager.GetNextPhotoURL();
            m_userAlbumPicturesComponent_Albums.PictureBoxes[i_PictureBoxIndex].SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void updatePreviousUserPhotosOnAlbumsTab(int i_PictureBoxIndex)
        {
            m_userAlbumPicturesComponent_Albums.PictureBoxes[i_PictureBoxIndex].ImageLocation = m_albumsManager.GetPreviousPhotoURL();
            m_userAlbumPicturesComponent_Albums.PictureBoxes[i_PictureBoxIndex].SizeMode = PictureBoxSizeMode.StretchImage;
        }

        #endregion

        #region Profile Tab Methods

        private void ProfileTab_Post_Click(object sender, EventArgs e)
        {
            string postText = m_userProfileComponent_Profile.TextBoxPostText.Text;
            postToWall(m_appController.User, postText);
        }

        private void ProfileTab_GetEvents_Click(object sender, EventArgs e)
        {
            try
            {
                m_userProfileComponent_Profile.BindingSourceUpcomingEvents.DataSource = m_appController.User.Events;
            }

            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void ProfileTab_AttachAFile_Click(object sender, EventArgs e)
        {
            m_filesUploader.UploadAPhotoToTimeline(m_albumsManager, m_appController.User);
        }

        #endregion

        #region Friends Tab Methods

        private void FriendsTabButtonPost_Click(object sender, EventArgs e)
        {
            if (m_appController.Friend == null)
            {
                MessageBox.Show("Please select a friend first!");
            }
            else
            {
                string postText = m_userProfileComponent_Friends.TextBoxPostText.Text;
                postToWall(m_appController.Friend, postText);
            }
        }

        private void FriendsTab_GetEvents_Click(object sender, EventArgs e)
        {
            if (m_appController.Friend == null)
            {
                MessageBox.Show("Please select a friend first!");
            }
            else
            {
                try
                {
                    m_userProfileComponent_Friends.BindingSourceUpcomingEvents.DataSource = m_appController.Friend.Events;
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
            }
        }

        private void FriendsTab_AttachAFile_Click(object sender, EventArgs e)
        {
            if (m_appController.Friend == null)
            {
                MessageBox.Show("Please select a friend first!");
            }
            else
            {
                m_filesUploader.UploadAPhotoToTimeline(m_albumsManager, m_appController.Friend);
            }
        }

        private void FriendsTab_Search_Click(object sender, EventArgs e)
        {
            User friend = getAFriendOfTheUserByName(m_textBox_Friends_FriendName.Text);

            if (friend != null)
            {
                m_appController.Friend = friend;
                m_userProfileComponent_Friends.PictureBoxProfilePic.ImageLocation = friend.PictureLargeURL;
                m_userProfileComponent_Friends.TextBoxUserInfo.Text = m_appController.GetFacebookUserInfo(friend);
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

        #endregion

        #region FaceRide Tab Methods

        private void FaceRideTab_linkLabelLocation_Click(object sender, LinkLabelLinkClickedEventArgs e)
        {
            m_richTextBox_FaceRide_WhereFrom.Text = m_appController.User.Location.Name;
        }

        private void FaceRideTab_LetsRide_Click(object sender, EventArgs e)
        {
            if (validateAllFields())
            {
                string searchRadius = m_comboBox_FaceRide_Radius.SelectedItem.ToString();
                bool maleFriends = m_checkBox_FaceRide_Male.Checked;
                bool femaleFriends = m_checkBox_FaceRide_Female.Checked;

                try
                {
                    FacebookObjectCollection<User> possibleRideFriends = m_faceRideManager.GetPotentialRideFriends(m_appController.User, searchRadius, maleFriends, femaleFriends);
                    if (possibleRideFriends.Count != 0)
                    {
                        //OnDemand object creation.
                        m_rideForm = new RideForm();
                        m_rideForm.FriendsDataGridView.CellDoubleClick += FaceRideTab_FriendsDataGridView_CellDoubleClick;
                        m_rideForm.BindingSource.DataSource = m_appController.User.Friends;
                        m_rideForm.FriendsDataGridView.DataBindingComplete += FriendsDataGridView_DataBindingComplete;
                        m_rideForm.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("We are sorry but no available friends found :(");
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Error: No permission to get user and/or friends locations.");
                }
            }
        }

        private void FaceRideTab_linkLabelShowMap_Click(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (validateWhereToField())
            {
                MapForm mapForm = new MapForm();
                mapForm.ShowLocationOnMap(m_richTextBox_FaceRide_WhereTo.Text);
                mapForm.ShowDialog();
            }
        }

        private void FriendsDataGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            int rowIndex = 0;

            foreach (User friend in m_appController.User.Friends)
            {
                DataGridViewTextBoxCell dataGridViewTextBoxCell = new DataGridViewTextBoxCell()
                {
                    Value = friend.Location.Name
                };

                m_rideForm.FriendsDataGridView.Rows[rowIndex].Cells[m_rideForm.LocationColumn.Index] = dataGridViewTextBoxCell;
                ++rowIndex;
            }
        }

        //Implement message sending request to friend.
        private void FaceRideTab_FriendsDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView friendsDataGridView = sender as DataGridView;
            SelectedRideFriendForm selectedRideFriendForm = new SelectedRideFriendForm();
            //selectedRideFriendForm.FriendProfilePicture=friendsDataGridView.SelectedRows[0].Cells[0].Im
            //selectedRideFriendForm.FriendFirstName.Text = friendsDataGridView.SelectedRows[0].Cells[0].
            selectedRideFriendForm.ShowDialog();

        }

        private bool validateAllFields()
        {
            return validateWhereFromField() && validateWhereToField() && validateRadiusField() && validateGenderField();
        }

        private bool validateRadiusField()
        {
            bool isValid = true;

            if (m_comboBox_FaceRide_Radius.SelectedItem == null)
            {
                MessageBox.Show("Please Select Radius Of Search");
                isValid = false;
            }

            return isValid;
        }

        private bool validateWhereToField()
        {
            bool isValid = true;

            if (m_richTextBox_FaceRide_WhereTo.Text == string.Empty)
            {
                MessageBox.Show("Please Select Your Destination");
                isValid = false;
            }

            return isValid;
        }

        private bool validateWhereFromField()
        {
            bool isValid = true;

            if (m_richTextBox_FaceRide_WhereFrom.Text == string.Empty)
            {
                MessageBox.Show("Please Select Your Origin");
                isValid = false;
            }

            return isValid;
        }

        private bool validateGenderField()
        {
            bool isValid = true;

            if (!(m_checkBox_FaceRide_Male.Checked || m_checkBox_FaceRide_Female.Checked))
            {
                MessageBox.Show("Please Select A Gender Of Your Ride");
                isValid = false;
            }

            return isValid;

        }

        #endregion

        #region General Methods

        private User getAFriendOfTheUserByName(string i_FriendName)
        {
            return m_appController.User.Friends.Find(x => x.Name == i_FriendName);
        }

        private void makeRoundPictureBox(PictureBox pictureBox, int i_WidthRound, int i_HeightRound)
        {
            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            gp.AddEllipse(0, 0, pictureBox.Width - i_WidthRound, pictureBox.Height - i_HeightRound);
            Region rg = new Region(gp);
            pictureBox.Region = rg;
        }

        private void postToWall(User i_User, string i_postText)
        {
            if (i_postText != string.Empty && i_postText != "Do you want to say anything?")
            {
                try
                {
                    m_wallManager.PostToWall(i_User, i_postText);
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

        private void launchBrowser(string i_UrlToLaunch)
        {
            ProcessStartInfo sInfo = new ProcessStartInfo(i_UrlToLaunch);
            Process.Start(sInfo);
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            InitializeFormTabs();
        }

        public void StartLoginSession()
        {
            CheckForIllegalCrossThreadCalls = false;
            initializeLoginForm();
            m_loginForm.StartLoginSession();
        }

        #endregion
    }
}