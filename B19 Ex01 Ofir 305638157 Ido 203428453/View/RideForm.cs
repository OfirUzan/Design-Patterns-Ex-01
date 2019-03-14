using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace View
{
    public partial class RideForm : Form
    {
        public RideForm()
        {
            InitializeComponent();
        }

        public BindingSource BindingSource
        {
            get
            {
                return m_bindingSource_Friends;
            }
            set
            {
                m_bindingSource_Friends = value;
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
    }
}
