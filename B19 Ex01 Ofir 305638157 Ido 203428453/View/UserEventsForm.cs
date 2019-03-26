using System.Windows.Forms;

namespace View
{
    public partial class UserEventsForm : Form
    {
        #region Class Members / Properties
        public Button ButtonGetEvents
        {
            get
            {
                return m_userEventsComponent.ButtonGetEvents;
            }

            set
            {
                m_userEventsComponent.ButtonGetEvents = value;
            }
        }

        public BindingSource BindingSource
        {
            get
            {
                return m_userEventsComponent.BindingSource;
            }

            set
            {
                m_userEventsComponent.BindingSource = value;
            }
        }

        public DataGridView DataGridView
        {
            get
            {
                return m_userEventsComponent.DataGridView;
            }

            set
            {
                m_userEventsComponent.DataGridView = value;
            }
        }

        public DataGridViewTextBoxColumn LocationColumn
        {
            get
            {
                return m_userEventsComponent.LocationColumn;
            }

            set
            {
                m_userEventsComponent.LocationColumn = value;
            }
        }
        #endregion

        #region Class Methods
        public UserEventsForm()
        {
            InitializeComponent();
        }
        #endregion
    }
}
