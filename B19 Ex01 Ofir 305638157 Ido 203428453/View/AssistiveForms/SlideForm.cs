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
        private int              m_CurrPic = 0;

        public SlideForm(AlbumFacade i_AlbumFacade)
        {
            InitializeComponent();
            m_Album = i_AlbumFacade;   
            init();
        }

        private void init()
        {
            timer1.Interval = 40;
            timer1.Tick += timerLoad_Tick;
            timer1.Enabled = true;
            foreach (string url in m_Album)
            {
                PictureBox picToAdd = new PictureBox();
                this.Controls.Add(picToAdd);
                picToAdd.Size = pictureBox.Size;
                picToAdd.Location = pictureBox.Location;
                picToAdd.Visible = false;
                picToAdd.ImageLocation = url;
                picToAdd.SizeMode = PictureBoxSizeMode.StretchImage;
                m_Pictures.Add(picToAdd);
            }

            label1.Visible = false;
            timer1.Tick -= timerLoad_Tick;
            timer1.Interval = 3000;
            timer1.Tick += timer1_Tick;
            m_Pictures[m_CurrPic].Visible = true;
        }

        private void timerLoad_Tick(object sender, System.EventArgs e)
        {
            if (label1.ForeColor == Color.White)
            {
                label1.ForeColor = Color.Pink;
            }
            else
            {
                label1.ForeColor = Color.White;
            }
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

         
            m_Pictures[m_CurrPic++].Visible = false;

            if (m_CurrPic >= m_Pictures.Count)
            {
                m_CurrPic = 0;
            }

            m_Pictures[m_CurrPic].Visible = true;
            m_Pictures[m_CurrPic].Visible = true;
        }

    }
}
