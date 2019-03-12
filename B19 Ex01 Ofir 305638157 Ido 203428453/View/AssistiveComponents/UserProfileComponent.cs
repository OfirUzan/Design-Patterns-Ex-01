using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace View
{
    public partial class UserProfileComponent : UserControl
    {
        public PictureBox ComponentPictureBoxProfilePic
        {
            get
            {
                return m_ComponentPictureBoxProfilePic;
            }

            set
            {
                m_ComponentPictureBoxProfilePic = value;
            }
        }

        public TextBox ComponentTextBoxUserInfo
        {
            get
            {
                return m_ComponentTextBoxUserInfo;
            }

            set
            {
                m_ComponentTextBoxUserInfo = value;
            }
        }

        public BindingSource ComponentBindingSourceUpcomingEvents
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

        public Button Post
        {
            get
            {
                return m_ComponentButtonPostOnWall;
            }

            set
            {
                m_ComponentButtonPostOnWall = value;
            }
        }

        public Button AttachAFile
        {
            get
            {
                return m_buttonUploadPic;
            }

            set
            {
                m_buttonUploadPic = value;
            }
        }

        public Button GetEvents
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

        public UserProfileComponent()
        {
            InitializeComponent();
        }

        private void m_ComponentTextBoxPostOnWall_Click(object sender, EventArgs e)
        {
            m_ComponentTextBoxPostOnWall.Text = string.Empty;
            (sender as TextBox).Click -= m_ComponentTextBoxPostOnWall_Click;
        }

        private void m_ComponentButtonPostOnWall_Click(object sender, EventArgs e)
        {
            if (m_ComponentTextBoxPostOnWall.Text != string.Empty &&
               m_ComponentTextBoxPostOnWall.Text != "Do you want to say anything?")
            {
                MessageBox.Show("Posted successfully to the wall!");
            }

            else
            {
                MessageBox.Show("Please insert a text to post!");
            }
        }
    }
}
