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

        public UserProfileComponent()
        {
            InitializeComponent();
        }

        private void m_textBoxPostText_Click(object sender, EventArgs e)
        {
            m_textBoxPostText.Text = string.Empty;
            (sender as TextBox).Click -= m_textBoxPostText_Click;
        }
    }
}
