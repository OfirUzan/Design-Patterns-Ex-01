using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace View.AssistiveComponents
{
    public partial class UserEventsComponent : UserControl
    {
        public UserEventsComponent()
        {
            InitializeComponent();
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

        public BindingSource BindingSource
        {
            get
            {
                return eventBindingSource;
            }

            set
            {
                eventBindingSource = value;
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
    }
}
