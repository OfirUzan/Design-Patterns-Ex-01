using System.Windows.Forms;

namespace View
{
    public partial class SelectedRideFriendForm : Form
    {
        #region Class Members / Properties
        public PictureBox FriendProfilePicture
        {
            get
            {
                return m_pictureBoxFriendProfilePic;
            }

            set
            {
                m_pictureBoxFriendProfilePic = value;
            }
        }

        public TextBox FriendFirstName
        {
            get
            {
                return m_textBoxFriendFirstName;
            }

            set
            {
                m_textBoxFriendFirstName = value;
            }
        }

        public TextBox FriendLastName
        {
            get
            {
                return m_textBoxFriendLastName;
            }

            set
            {
                m_textBoxFriendLastName = value;
            }
        }

        public TextBox RequestMessage
        {
            get
            {
                return m_textBoxRequestText;
            }

            set
            {
                m_textBoxRequestText = value;
            }
        }

        public Button ButtonPostOnWall
        {
            get
            {
                return m_buttonPostOnWall;
            }

            set
            {
                m_buttonPostOnWall = value;
            }
        }

        public Button ButtonPostOnMessanger
        {
            get
            {
                return m_buttonSendViaMessanger;
            }

            set
            {
                m_buttonSendViaMessanger = value;
            }
        }
        #endregion

        #region Class Methods
        public SelectedRideFriendForm()
        {
            InitializeComponent();
        }
        #endregion
    }
}
