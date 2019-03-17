using System;
using System.Diagnostics;
using System.Drawing;
using System.Collections.Generic;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using Model;
using System.IO;
using System.Data;
using System.Text;

namespace View
{
    public partial class DesktopFacebook : Form
    {
        #region Class Members / Properties

        private LoginForm                 m_LoginForm;
        private AppController             m_AppController;
        private AlbumsManager             m_AlbumsManager;
        private WallManager               m_WallManager;
        private FilesUploader             m_FilesUploader;
        private FaceRideManager           m_FaceRideManager;
        private RideForm                  m_RideForm;
        private SelectedRideFriendForm    m_SelectedRideFriendForm;
        private UserEventsForm            m_UserEventsForm;
        private bool                      m_FirstLaunch = true;
        private LinkedList<GoogleContact> m_Contacts;
        private readonly string           r_SaveDialog_CsvFilter = "CSV (*.csv)|*.csv";
        private readonly string           r_DeafultCsvOutputName = "Contacts_Output.csv";
        private readonly string           r_NotifyWhenDoneMessage = "Data will be exported and you will be notified when it is ready.";
        private readonly string           r_CsvErrorMakingFile = "It wasn't possible to write the data to the disk.";
        private readonly string           r_CsvMakeFileOk = "Your file was generated and its ready for use.";
        private readonly string           r_GoogleUploadContactsLink = "https://contacts.google.com/";



        #endregion

        #region Login Methods
        private void initializeLoginForm()
        {
            m_LoginForm = new LoginForm();
            m_LoginForm.LoginSucessListeners += loginForm_LoginSucess;
            m_LoginForm.LoginFailedListeners += loginForm_LoginFailed;
        }

        private void loginForm_LoginFailed()
        {
            Close();
        }

        private void loginForm_LoginSucess(User i_LoggedUser)
        {
            InitializeComponent();
            m_AppController = new AppController() { User = i_LoggedUser };
            m_AlbumsManager = new AlbumsManager(m_AppController.User);
            m_WallManager = new WallManager(m_AppController.User.WallPosts);
            m_FilesUploader = new FilesUploader();
            m_FaceRideManager = new FaceRideManager();
            if (m_FirstLaunch)
            {
                m_FirstLaunch = false;
                ShowDialog();
            }
            else
            {
                Show();
            }
        }

        #endregion

        #region Tabs Init Methods

        private void initializeTabForm()
        {
            //Use threads to init each tab FAST !!!
            new System.Threading.Thread(() => initializeTabFeed()).Start();
            new System.Threading.Thread(() => initializeTabAlbums()).Start();
            new System.Threading.Thread(() => initializeTabProfile()).Start();
            new System.Threading.Thread(() => initializeTabFriends()).Start();
        }

        private void initializeTabFeed()
        {
            pictureBox_TabFeed_CoverPhoto.ImageLocation = m_AlbumsManager.GetLatestPhotoURL("Cover Photos");
            pictureBox_TabFeed_CoverPhoto.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox_TabFeed_ProfilePic.ImageLocation = m_AppController.User.PictureLargeURL;
            pictureBox_TabFeed_ProfilePic.SizeMode = PictureBoxSizeMode.StretchImage;
            linkLabel_TabFeed_FullName.Text = m_AppController.User.Name;
            label_TabFeed_Email.Text = m_AppController.User.Email;
            label_TabFeed_Birthday.Text = m_AppController.User.Birthday;
            label_TabMain_Gender.Text = m_AppController.User.Gender.ToString();
            makeRoundPictureBox(pictureBox_TabFeed_ProfilePic, 3, 3);
            this.nextWallPost();
        }

        private void initializeTabAlbums()
        {
            foreach (Album album in m_AppController.User.Albums)
            {
                comboBox_TabAlbums_AlbumsList.Items.Add(album.Name);
            }

            foreach(PictureBox pictureBox in userAlbumPicturesComponent_TabAlbums.PictureBoxes)
            {
                pictureBox.Click += tabAlbum_PictureBox_Click;
            }
        }

        private void initializeTabProfile()
        {
            m_userProfileComponent_TabProfile.ButtonAttachAFile.Click += tabProfile_AttachAFile_Click;
            m_userProfileComponent_TabProfile.ButtonGetEvents.Click += tabProfile_GetEvents_Click;
            m_userProfileComponent_TabProfile.ButtonPost.Click += tabProfile_Post_Click;
            m_userProfileComponent_TabProfile.PictureBoxProfilePic.ImageLocation = m_AppController.User.PictureLargeURL;
            m_userProfileComponent_TabProfile.TextBoxUserInfo.Text = m_AppController.GetFacebookUserInfo(m_AppController.User);
        }

        private void initializeTabFriends()
        {
            userProfileComponent_TabFriends.ButtonAttachAFile.Click += tabFriend_AttachAFile_Click;
            userProfileComponent_TabFriends.ButtonGetEvents.Click += tabFriend_GetEvents_Click;
            userProfileComponent_TabFriends.ButtonPost.Click += tabFriend_ButtonPost_Click;
        }

        private void initiaozeTabContacts()
        {
            User user = m_AppController.User;
            m_Contacts = new LinkedList<GoogleContact>();
            foreach (User friend in user.Friends)
            {
                try
                {
                    GoogleContact contact = new GoogleContact();
                    contact.PopulateContactFromFacebookUser(friend);
                    m_Contacts.AddLast(contact);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error is " + ex.ToString());
                }
            }
        }

        #endregion

        #region Feed Tab Methods

        private void tabFeed_Logout_Click(object sender, EventArgs e)
        {
            Hide();
            initializeLoginForm();
            m_LoginForm.LogoutUser();
        }

        private void tabFeed_NextComment_Click(object sender, EventArgs e)
        {
            nextPostComment();
        }

        private void tabFeed_NextPost_Click(object sender, EventArgs e)
        {
            nextWallPost();
        }

        private void tabFeed_FriendsButton_Click(object sender, EventArgs e)
        {
            tabsControl.SelectedTab = tabPage_Friends;
        }

        private void tabFeed_AlbumsButton_Click(object sender, EventArgs e)
        {
            tabsControl.SelectedTab = tabPage_Albums;
        }

        private void tabFeed_ProfileButton_Click(object sender, EventArgs e)
        {
            tabsControl.SelectedTab = tabPage_Profile;
        }

        private void tabFeed_FaceRideButton_Click(object sender, EventArgs e)
        {
            tabsControl.SelectedTab = tabPage_FaceRide;
        }

        private void tabFeed_linkLabelFullName_Click(object sender, LinkLabelLinkClickedEventArgs e)
        {
            launchBrowser(m_AppController.User.Link);
        }

        private void tabFeed_linkLabelCommentInfo_Click(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string commentUrl = "https://www.facebook.com/" + m_WallManager.GetCommentID();
            launchBrowser(commentUrl);
        }

        private void tabFeed_linkLabelPostLink_Click(object sender, LinkLabelLinkClickedEventArgs e)
        {
            launchBrowser(m_WallManager.GetPostId());
        }

        private void nextWallPost()
        {
            Post p = m_WallManager.GetNextWallPost();
            Comment c = m_WallManager.GetNextCommentOfCurrentPost();
            pictureBox_TabFeed_PostPic.ImageLocation = p.PictureURL;
            pictureBox_TabFeed_PostPic.SizeMode = PictureBoxSizeMode.StretchImage;
            label_TabFeed_PostDate.Text = p.CreatedTime.ToString();
            label_TabFeed_PostName.Text = p.Name;
            richTextBox_TabFeed_PostDescription.Text = p.Message;
            nextPostComment();
        }

        private void nextPostComment()
        {
            Comment c = m_WallManager.GetNextCommentOfCurrentPost();
            if (c == null)
            {
                richTextBox_TabFeed_CommentText.Text = "No Comments";
                label_TabFeed_CommentDate.Text = "";
                linkLabel_TabFeed_PostInfo.Visible = false;


            }
            else
            {
                richTextBox_TabFeed_CommentText.Text = c.Message;
                label_TabFeed_CommentDate.Text = c.CreatedTime.ToString();
                linkLabel_TabFeed_PostInfo.Visible = true;
            }
        }

        #endregion

        #region Albums Tab Methods

        private void tabAlbum_Next_Click(object sender, EventArgs e)
        {
            m_AppController.UpdatePhotosOnAlbumsTab(updateNextUserPhotosOnTabAlbum, userAlbumPicturesComponent_TabAlbums.NumOfPictureBoxes);
        }

        private void tabAlbum_Previous_Click(object sender, EventArgs e)
        {
            m_AppController.UpdatePhotosOnAlbumsTab(updatePreviousUserPhotosOnTabAlbum, userAlbumPicturesComponent_TabAlbums.NumOfPictureBoxes);
        }

        private void tabAlbum_PictureBox_Click(object sender, EventArgs e)
        {
            LargePhotoForm largePhotoForm = new LargePhotoForm();
            largePhotoForm.Picture.ImageLocation = (sender as PictureBox).ImageLocation;
            largePhotoForm.Show();
        }

        private void tabAlbum_ComboBoxAlbums_AlbumSelected(object sender, EventArgs e)
        {
            foreach (PictureBox pictureBox in userAlbumPicturesComponent_TabAlbums.PictureBoxes)
            {
                pictureBox.Cursor = Cursors.Hand;
            }
            button_TabAlbums_Next.Enabled = true;
            button_TabAlbums_Prevoius.Enabled = true;
            string albumName = comboBox_TabAlbums_AlbumsList.SelectedItem.ToString();
            m_AlbumsManager.SetCurrentAlbum(albumName);
            m_AppController.UpdatePhotosOnAlbumsTab(updateNextUserPhotosOnTabAlbum, userAlbumPicturesComponent_TabAlbums.NumOfPictureBoxes);
        }

        private void updateNextUserPhotosOnTabAlbum(int i_PictureBoxIndex)
        {
            userAlbumPicturesComponent_TabAlbums.PictureBoxes[i_PictureBoxIndex].ImageLocation = m_AlbumsManager.GetNextPhotoURL();
            userAlbumPicturesComponent_TabAlbums.PictureBoxes[i_PictureBoxIndex].SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void updatePreviousUserPhotosOnTabAlbum(int i_PictureBoxIndex)
        {
            userAlbumPicturesComponent_TabAlbums.PictureBoxes[i_PictureBoxIndex].ImageLocation = m_AlbumsManager.GetPreviousPhotoURL();
            userAlbumPicturesComponent_TabAlbums.PictureBoxes[i_PictureBoxIndex].SizeMode = PictureBoxSizeMode.StretchImage;
        }

        #endregion

        #region Profile Tab Methods

        private void tabProfile_Post_Click(object sender, EventArgs e)
        {
            string postText = m_userProfileComponent_TabProfile.TextBoxPostText.Text;
            postToWall(m_AppController.User, postText);
        }

        private void tabProfile_GetEvents_Click(object sender, EventArgs e)
        {
            try
            {
                m_userProfileComponent_TabProfile.BindingSourceUpcomingEvents.DataSource = m_AppController.User.Events;
            }

            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void tabProfile_AttachAFile_Click(object sender, EventArgs e)
        {
            m_FilesUploader.UploadAPhotoToTimeline(m_AlbumsManager, m_AppController.User);
        }

        #endregion

        #region Friends Tab Methods

        private void tabFriend_ButtonPost_Click(object sender, EventArgs e)
        {
            if (m_AppController.Friend == null)
            {
                MessageBox.Show("Please select a friend first!");
            }
            else
            {
                string postText = userProfileComponent_TabFriends.TextBoxPostText.Text;
                postToWall(m_AppController.Friend, postText);
            }
        }

        private void tabFriend_GetEvents_Click(object sender, EventArgs e)
        {
            if (m_AppController.Friend == null)
            {
                MessageBox.Show("Please select a friend first!");
            }
            else
            {
                try
                {
                    userProfileComponent_TabFriends.BindingSourceUpcomingEvents.DataSource = m_AppController.Friend.Events;
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
            }
        }

        private void tabFriend_AttachAFile_Click(object sender, EventArgs e)
        {
            if (m_AppController.Friend == null)
            {
                MessageBox.Show("Please select a friend first!");
            }
            else
            {
                m_FilesUploader.UploadAPhotoToTimeline(m_AlbumsManager, m_AppController.Friend);
            }
        }

        private void tabFriend_Search_Click(object sender, EventArgs e)
        {
            User friend = getAFriendOfTheUserByName(textBox_TabFriends_FriendName.Text);

            if (friend != null)
            {
                m_AppController.Friend = friend;
                userProfileComponent_TabFriends.PictureBoxProfilePic.ImageLocation = friend.PictureLargeURL;
                userProfileComponent_TabFriends.TextBoxUserInfo.Text = m_AppController.GetFacebookUserInfo(friend);
            }
            else
            {
                MessageBox.Show("Friend was not found.");
            }
        }

        private void tabFriend_textBoxFriendName_Click(object sender, EventArgs e)
        {
            textBox_TabFriends_FriendName.Text = string.Empty;
            (sender as TextBox).Click -= tabFriend_textBoxFriendName_Click;
        }

        #endregion

        #region FaceRide Tab Methods

        private void tabFaceRide_linkLabelLocation_Click(object sender, LinkLabelLinkClickedEventArgs e)
        {
            richTextBox_TabFaceRide_WhereFrom.Text = m_AppController.User.Location.Name;
        }

        private void tabFaceRide_linkLabel_GetFromEvent_Click(object sender, LinkLabelLinkClickedEventArgs e)
        {
            m_UserEventsForm = new UserEventsForm();
            m_UserEventsForm.DataGridView.CellDoubleClick += userEventsForm_DataGridView_CellDoubleClick;
            m_UserEventsForm.ButtonGetEvents.Click += userEventsForm_GetEvents_Click;
            m_UserEventsForm.ShowDialog();
        }

        private void tabFaceRide_linkLabelShowMap_Click(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (validateWhereToField())
            {
                MapForm mapForm = new MapForm();
                mapForm.ShowLocationOnMap(richTextBox_TabFaceRide_WhereTo.Text);
                mapForm.ShowDialog();
            }
        }

        private void tabFaceRide_FriendsDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            m_FaceRideManager.ChosenFriend = m_FaceRideManager.PossibleRideFriends[e.RowIndex];
            createAndShowSelectedRideFriendForm();
        }

        private void tabFaceRide_SendViaMessanger_Click(object sender, EventArgs e)
        {
            launchBrowser("https://www.facebook.com/messages/t/" + m_FaceRideManager.ChosenFriend.Id);
        }

        private void tabFaceRide_PostOnWall_Click(object sender, EventArgs e)
        {
            try
            {
                m_FaceRideManager.ChosenFriend.PostStatus(m_SelectedRideFriendForm.RequestMessage.Text);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tabFaceRide_LetsRide_Click(object sender, EventArgs e)
        {
            if (validateAllFields())
            {
                string searchRadius = comboBox_TabFaceRide_Radius.SelectedItem.ToString();
                bool maleFriends = checkBox_TabFaceRide_Male.Checked;
                bool femaleFriends = checkBox_TabFaceRide_Female.Checked;

                try
                {
                    FacebookObjectCollection<User> potentialRideFriends = m_FaceRideManager.GetPotentialRideFriends(m_AppController.User, searchRadius, maleFriends, femaleFriends);

                    if (potentialRideFriends.Count != 0)
                    {
                        //OnDemand object creation.
                        createAndShowRideForm();
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

        private void userEventsForm_DataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int locationCellIndex = m_UserEventsForm.LocationColumn.Index;
            DataGridView eventsGridView = sender as DataGridView;
            richTextBox_TabFaceRide_WhereTo.Text = (string)eventsGridView.Rows[e.RowIndex].Cells[locationCellIndex].Value;
        }

        private void userEventsForm_GetEvents_Click(object sender, EventArgs e)
        {
            try
            {
                m_UserEventsForm.BindingSource.DataSource = m_AppController.User.Events;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void createAndShowRideForm()
        {
            m_RideForm = new RideForm();
            m_RideForm.FriendsDataGridView.CellDoubleClick += tabFaceRide_FriendsDataGridView_CellDoubleClick;
            m_RideForm.BindingSource.DataSource = m_AppController.User.Friends;
            m_RideForm.FriendsDataGridView.DataBindingComplete += friendsDataGridView_DataBindingComplete;
            m_RideForm.ShowDialog();
        }

        private void friendsDataGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            int rowIndex = 0;

            foreach (User friend in m_AppController.User.Friends)
            {
                DataGridViewTextBoxCell dataGridViewTextBoxCell = new DataGridViewTextBoxCell()
                {
                    Value = friend.Location.Name
                };

                m_RideForm.FriendsDataGridView.Rows[rowIndex].Cells[m_RideForm.LocationColumn.Index] = dataGridViewTextBoxCell;
                ++rowIndex;
            }
        }

        private void createAndShowSelectedRideFriendForm()
        {
            m_SelectedRideFriendForm = new SelectedRideFriendForm();
            m_SelectedRideFriendForm.FriendProfilePicture.Image = m_FaceRideManager.ChosenFriend.ImageNormal;
            m_SelectedRideFriendForm.FriendFirstName.Text = m_FaceRideManager.ChosenFriend.FirstName;
            m_SelectedRideFriendForm.FriendLastName.Text = m_FaceRideManager.ChosenFriend.LastName;
            m_SelectedRideFriendForm.RequestMessage.Text =
            string.Format("Hey {0}!{1}I would like to take a ride with you to {2}!{3}What do you say?",
                          m_SelectedRideFriendForm.FriendFirstName.Text, Environment.NewLine, richTextBox_TabFaceRide_WhereTo.Text, Environment.NewLine);
            m_SelectedRideFriendForm.FriendFirstName.ReadOnly = true;
            m_SelectedRideFriendForm.FriendLastName.ReadOnly = true;
            m_SelectedRideFriendForm.ButtonPostOnWall.Click += tabFaceRide_PostOnWall_Click;
            m_SelectedRideFriendForm.ButtonPostOnMessanger.Click += tabFaceRide_SendViaMessanger_Click;
            m_SelectedRideFriendForm.ShowDialog();
        }

        private bool validateAllFields()
        {
            return validateWhereFromField() && validateWhereToField() && validateRadiusField() && validateGenderField();
        }

        private bool validateRadiusField()
        {
            bool isValid = true;

            if (comboBox_TabFaceRide_Radius.SelectedItem == null)
            {
                MessageBox.Show("Please Select Radius Of Search");
                isValid = false;
            }

            return isValid;
        }

        private bool validateWhereToField()
        {
            bool isValid = true;

            if (richTextBox_TabFaceRide_WhereTo.Text == string.Empty)
            {
                MessageBox.Show("Please Select Your Destination");
                isValid = false;
            }

            return isValid;
        }

        private bool validateWhereFromField()
        {
            bool isValid = true;

            if (richTextBox_TabFaceRide_WhereFrom.Text == string.Empty)
            {
                MessageBox.Show("Please Select Your Origin");
                isValid = false;
            }

            return isValid;
        }

        private bool validateGenderField()
        {
            bool isValid = true;

            if (!(checkBox_TabFaceRide_Male.Checked || checkBox_TabFaceRide_Female.Checked))
            {
                MessageBox.Show("Please Select A Gender Of Your Ride");
                isValid = false;
            }

            return isValid;
        }

        #endregion

        public static bool populateDataGridViewWithCsvFile(DataGridView i_GridView, string i_CsvPath)
        {
            bool sucess = true;
            try
            {
                DataRow row;
                DataTable dataTable = new DataTable();
                string[] lines = File.ReadAllLines(i_CsvPath);
                string[] fields;
                int cols;
                fields = lines[0].Split(new char[] { ',' });
                cols = fields.GetLength(0);

                for (int i = 0; i < cols; i++)
                {
                    dataTable.Columns.Add(fields[i].ToLower(), typeof(string));
                }

                for (int i = 1; i < lines.GetLength(0); i++)
                {
                    fields = lines[i].Split(new char[] { ',' });
                    row = dataTable.NewRow();
                    for (int f = 0; f < cols; f++)
                    {
                        row[f] = fields[f];
                    }

                    dataTable.Rows.Add(row);
                }

                i_GridView.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                sucess = false;
            }

            return sucess;
        }

        #region General Methods

        private User getAFriendOfTheUserByName(string i_FriendName)
        {
            return m_AppController.User.Friends.Find(x => x.Name == i_FriendName);
        }

        private static void makeRoundPictureBox(PictureBox i_PictureBox, int i_WidthRound, int i_HeightRound)
        {
            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            gp.AddEllipse(0, 0, i_PictureBox.Width - i_WidthRound, i_PictureBox.Height - i_HeightRound);
            Region rg = new Region(gp);
            i_PictureBox.Region = rg;
        }

        private void postToWall(User i_User, string i_postText)
        {
            if (i_postText != string.Empty && i_postText != "Do you want to say anything?")
            {
                try
                {
                    m_WallManager.PostToWall(i_User, i_postText);
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
            initializeTabForm();
        }

        public void StartLoginSession()
        {
            CheckForIllegalCrossThreadCalls = false;
            initializeLoginForm();
            m_LoginForm.StartLoginSession();
        }

        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            initiaozeTabContacts();
            webBrowser_TabContacts.Url = new Uri(r_GoogleUploadContactsLink);
            GoogleContact.MakeCsvFromContactList(m_Contacts, r_DeafultCsvOutputName);
            populateDataGridViewWithCsvFile(dataGridView_TabContacts, r_DeafultCsvOutputName);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            dataGridViewToCSV(dataGridView_TabContacts);
        }

        private void dataGridViewToCSV(DataGridView i_dataGridView)
        {
            string filename = string.Empty;
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Filter = r_SaveDialog_CsvFilter;
            saveDialog.FileName = r_DeafultCsvOutputName;


            if(saveDialog.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show(r_NotifyWhenDoneMessage);
                if (File.Exists(filename))
                {
                    try
                    {
                        File.Delete(filename);
                    }
                    catch (IOException ex)
                    {
                        MessageBox.Show(r_CsvErrorMakingFile + ex.Message);
                    }
                }

                string csvOutput = string.Empty;

                foreach (DataGridViewColumn column in dataGridView_TabContacts.Columns)
                {
                    csvOutput += column.HeaderText + ',';
                }

                csvOutput += Environment.NewLine;


                foreach (DataGridViewRow row in dataGridView_TabContacts.Rows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        if (cell.Value != null)
                        {
                            csvOutput += cell.Value.ToString().TrimEnd(',').Replace(",", ";") + ',';
                        }
                    }

                    csvOutput += Environment.NewLine;
                }

                System.IO.File.WriteAllText(saveDialog.FileName, csvOutput, System.Text.Encoding.UTF8);
                MessageBox.Show(r_CsvMakeFileOk);
            }
        }
    }
}