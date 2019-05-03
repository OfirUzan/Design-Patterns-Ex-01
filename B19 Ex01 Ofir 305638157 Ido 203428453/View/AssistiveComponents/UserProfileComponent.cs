using System;
using System.Windows.Forms;
using Model;
using FacebookWrapper.ObjectModel;

namespace View.AssistiveComponents
{
    public partial class UserProfileComponent : UserControl, IAppComponent
    {
        #region Class Members / Properties
        private const string  k_PostToWallMsg     = "Do you want to say anything?";
        private const string  k_ErrorMsgEmptyText = "Please insert a text to post!";
        private IAppComponent m_userEventsComponent;

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

        private void setEventsComponentVisualSettings()
        {
            DataGridView dataGridView = (m_userEventsComponent as UserEventsComponent).DataGridView;
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.Anchor = (AnchorStyles)(AnchorStyles.Top | AnchorStyles.Bottom
            | AnchorStyles.Left
            | AnchorStyles.Right);
            dataGridView.AutoGenerateColumns = false;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.DataSource = m_ComponentBindingSourceUpcomingEvents;
            dataGridView.Location = new System.Drawing.Point(509, 53);
            dataGridView.Name = "m_dataGridViewUpcomingEvents";
            dataGridView.ReadOnly = true;
            dataGridView.RowTemplate.Height = 28;
            dataGridView.Size = new System.Drawing.Size(597, 350);
            dataGridView.TabIndex = 17;
        }

        void IAppComponent.Initialize()
        {
            InitializeComponent();
            ButtonAttachAFile.Click += ButtonAttachAFile_Click;
            ButtonPost.Click += ButtonPost_Click;
            m_userEventsComponent = AppComponentFactory.CreateAppComponent(Utils.eAppComponent.UserEvents, Controls, User);
            m_userEventsComponent.Initialize();
            setEventsComponentVisualSettings();
        }
        #endregion
    }
}
