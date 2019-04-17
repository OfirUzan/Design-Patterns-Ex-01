using System.Windows.Forms;

namespace View
{
    public partial class RideForm : Form
    {
        #region Class Members / Properties
        public BindingSource FriendsBindingSource
        {
            get
            {
                return friendsBindingSource;
            }

            set
            {
                friendsBindingSource = value;
            }
        }

        public DataGridView FriendsDataGridView
        {
            get
            {
                return m_dataGridView_Friends;
            }

            set
            {
                m_dataGridView_Friends = value;
            }
        }

        public DataGridViewTextBoxColumn LocationColumn
        {
            get
            {
                return m_locationColumn;
            }

            set
            {
                m_locationColumn = value;
            }
        }

        public DataGridViewTextBoxColumn FirstNameColumn
        {
            get
            {
                return m_firstNameColumn;
            }

            set
            {
                m_firstNameColumn = value;
            }
        }

        public DataGridViewTextBoxColumn LastNameColumn
        {
            get
            {
                return m_lastNameColumn;
            }

            set
            {
                m_lastNameColumn = value;
            }
        }

        public DataGridViewImageColumn ProfilePictureColumn
        {
            get
            {
                return m_profilePicColumn;
            }

            set
            {
                m_profilePicColumn = value;
            }
        }
        #endregion

        #region Class Methods
        public RideForm()
        {
            InitializeComponent();
        }
        #endregion
    }
}