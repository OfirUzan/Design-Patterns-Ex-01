using FacebookWrapper.ObjectModel;
using System;
using System.Windows.Forms;

namespace View.AssistiveComponents
{
    public partial class UserEventsComponent : UserControl, IAppComponent
    {
        #region Class Members / Properties

        public User User { get; set; }
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

        public BindingSource EventsBindingSource
        {
            get
            {
                return eventsBindingSource;
            }

            set
            {
                eventsBindingSource = value;
            }
        }

        public DataGridView DataGridView
        {
            get
            {
                return m_dataGridViewUpcomingEvents;
            }

            set
            {
                m_dataGridViewUpcomingEvents = value;
            }
        }

        public DataGridViewTextBoxColumn LocationColumn
        {
            get
            {
                return locationDataGridViewTextBoxColumn;
            }

            set
            {
                locationDataGridViewTextBoxColumn = value;
            }
        }
        #endregion

        #region Class Methods

        void IAppComponent.Initialize()
        {
            InitializeComponent();
            ButtonGetEvents.Click += ButtonGetEvents_Click;
        }

        private void ButtonGetEvents_Click(object sender, System.EventArgs e)
        {
            try
            {
                EventsBindingSource.DataSource = User.Events;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion
    }
}
