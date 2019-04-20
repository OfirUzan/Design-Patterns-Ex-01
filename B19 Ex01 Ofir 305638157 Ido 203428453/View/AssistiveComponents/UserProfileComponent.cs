using System;
using System.Windows.Forms;
using Model;
using FacebookWrapper.ObjectModel;

namespace View.AssistiveComponents
{
    public partial class UserProfileComponent : UserControl, IAppComponent
    {
        #region Class Members / Properties
        private const string k_PostToWallMsg     = "Do you want to say anything?";
        private const string k_ErrorMsgEmptyText = "Please insert a text to post!";
        //private IAppComponent m_userEventsComponent;

        public User User { get; set; }
        public PictureBox PictureBoxProfilePic
        {
            get
            {
                return m_pictureBoxProfilePic;
            }

            set
            {
                m_pictureBoxProfilePic = value;
            }
        }

        public TextBox TextBoxUserInfo
        {
            get
            {
                return m_textBoxUserInfo;
            }

            set
            {
                m_textBoxUserInfo = value;
            }
        }

        public TextBox TextBoxPostText
        {
            get
            {
                return m_textBoxPostText;
            }

            set
            {
                m_textBoxPostText = value;
            }
        }

        public BindingSource BindingSourceUpcomingEvents
        {
            get
            {
                return m_ComponentBindingSourceUpcomingEvents;
            }

            set
            {
                m_ComponentBindingSourceUpcomingEvents = value;
            }
        }

        public Button ButtonAttachAFile
        {
            get
            {
                return m_buttonAttachAPicture;
            }

            set
            {
                m_buttonAttachAPicture = value;
            }
        }

        public Button ButtonGetEvents
        {
            get
            {
                return m_buttonGetEvents;
            }

            set
            {
                m_buttonGetEvents = value;
            }
        }

        public Button ButtonPost
        {
            get
            {
                return m_buttonPost;
            }

            set
            {
                m_buttonPost = value;
            }
        }
        #endregion

        #region Class Methods
        private void m_textBoxPostText_Click(object sender, EventArgs e)
        {
            m_textBoxPostText.Text = string.Empty;
            (sender as TextBox).Click -= m_textBoxPostText_Click;
        }

        private void ButtonPost_Click(object sender, EventArgs e)
        {
            string postText = TextBoxPostText.Text;

            if (postText != string.Empty && postText != k_PostToWallMsg)
            {
                try
                {
                    WallManager.PostToWall(User, postText);
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
            }
            else
            {
                MessageBox.Show(k_ErrorMsgEmptyText);
            }
        }

        private void ButtonGetEvents_Click(object sender, EventArgs e)
        {
            try
            {
                BindingSourceUpcomingEvents.DataSource = User.Events;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void ButtonAttachAFile_Click(object sender, EventArgs e)
        {
            FilesUploader.UploadAPhotoToTimeline(User);
        }

        void IAppComponent.Initialize()
        {
            InitializeComponent();
            ButtonAttachAFile.Click += ButtonAttachAFile_Click;
            ButtonGetEvents.Click += ButtonGetEvents_Click;
            ButtonPost.Click += ButtonPost_Click;
        }
        #endregion
    }
}
