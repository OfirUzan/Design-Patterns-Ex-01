using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;

namespace View.AssistiveForms
{
    public partial class SlideForm : Form
    {
        private AlbumFacade      m_Album;
        private List<PictureBox> m_Pictures = new List<PictureBox>();
        private int              m_CurrPicIndex = 0;

        public SlideForm(AlbumFacade i_AlbumFacade)
        {
            InitializeComponent();
            m_Album = i_AlbumFacade;   
            init();
        }

        private void init()
        {
            foreach (string url in m_Album)
            {
                PictureBox picToAdd = new PictureBox();
                picToAdd.Size = pictureBox.Size;
                picToAdd.Location = pictureBox.Location;
                picToAdd.Visible = false;
                picToAdd.ImageLocation = url;
                picToAdd.SizeMode = PictureBoxSizeMode.StretchImage;
                m_Pictures.Add(picToAdd);
                this.Controls.Add(picToAdd);
            }

            label1.Visible = false;
            pictureBox.Visible = false;
            timer1.Interval = 3000;
            timer1.Tick += timer1_Tick;
            timer1.Enabled = true;
            m_Pictures[m_CurrPicIndex].Visible = true;
        }

        private void timer1_Tick(object sender, System.EventArgs e)
        {
            if (this.BackColor == Color.DarkSlateBlue)
            {
                this.BackColor = Color.DarkBlue;
            }
            else
            {
                this.BackColor = Color.DarkSlateBlue;
            }

            m_Pictures[m_CurrPicIndex++].Visible = false;
            if (m_CurrPicIndex >= m_Pictures.Count)
            {
                m_CurrPicIndex = 0;
            }

            m_Pictures[m_CurrPicIndex].Visible = true;
        }
    }
}
