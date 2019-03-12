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
    public partial class LargePhotoForm : Form
    {
        public PictureBox Picture
        {
            get
            {
                return m_pictureBox;
            }

            set
            {
                m_pictureBox = value;
            }
        }

        public LargePhotoForm()
        {
            InitializeComponent();
        }
    }
}
