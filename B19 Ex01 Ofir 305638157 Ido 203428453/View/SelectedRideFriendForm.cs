﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace View
{
    public partial class SelectedRideFriendForm : Form
    {
        public SelectedRideFriendForm()
        {
            InitializeComponent();
        }

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
                return m_buttonPostOnMessanger;
            }

            set
            {
                m_buttonPostOnMessanger = value;
            }
        }

        public BindingSource BindingSource { get; set; }
    }
}
