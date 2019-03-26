using System.Windows.Forms;

namespace View
{
    public partial class UserAlbumPicturesComponent : UserControl
    {
        #region Class Members / Properties
        public byte NumOfPictureBoxes { get; }

        public PictureBox[] PictureBoxes { get; set; }
        #endregion

        #region Class Methods
        private void initializePictureBoxesArray()
        {
            PictureBoxes = new PictureBox[NumOfPictureBoxes];
            PictureBoxes[0] = m_pictureBox0;
            PictureBoxes[1] = m_pictureBox1;
            PictureBoxes[2] = m_pictureBox2;
            PictureBoxes[3] = m_pictureBox3;
            PictureBoxes[4] = m_pictureBox4;
            PictureBoxes[5] = m_pictureBox5;
            PictureBoxes[6] = m_pictureBox6;
            PictureBoxes[7] = m_pictureBox7;
        }

        public UserAlbumPicturesComponent()
        {
            NumOfPictureBoxes = 8;
            InitializeComponent();
            initializePictureBoxesArray();
        }
        #endregion
    }
}
