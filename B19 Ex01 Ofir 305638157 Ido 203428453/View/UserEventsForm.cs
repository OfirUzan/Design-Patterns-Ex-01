using FacebookWrapper.ObjectModel;
using System.Windows.Forms;
using View.AssistiveComponents;

namespace View
{
    public partial class UserEventsForm : Form
    {
        #region Class Members / Properties
        public Button ButtonGetEvents
        {
            get
            {
                return (m_userEventsComponent as UserEventsComponent).ButtonGetEvents;
            }

            set
            {
                (m_userEventsComponent as UserEventsComponent).ButtonGetEvents = value;
            }
        }

        public BindingSource BindingSource
        {
            get
            {
                return (m_userEventsComponent as UserEventsComponent).BindingSource;
            }

            set
            {
                (m_userEventsComponent as UserEventsComponent).BindingSource = value;
            }
        }

        public DataGridView DataGridView
        {
            get
            {
                return (m_userEventsComponent as UserEventsComponent).DataGridView;
            }

            set
            {
                (m_userEventsComponent as UserEventsComponent).DataGridView = value;
            }
        }

        public DataGridViewTextBoxColumn LocationColumn
        {
            get
            {
                return (m_userEventsComponent as UserEventsComponent).LocationColumn;
            }

            set
            {
                (m_userEventsComponent as UserEventsComponent).LocationColumn = value;
            }
        }
        #endregion

        #region Class Methods
        public UserEventsForm(User i_User)
        {
            InitializeComponent();
            IAppComponent userEventsComponent = AppComponentFactory.CreateAppComponent(Utils.eAppComponent.UserEvents, Controls, i_User);
            userEventsComponent.Initialize();
        }
        #endregion
    }
}
