using Model;
using System.Windows.Forms;

namespace View.AssistiveComponents
{
    public partial class UserAlbumPicturesComponent: UserControl, IAppComponent
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

            foreach (PictureBox pictureBox in PictureBoxes)
            {
                pictureBox.Click += PictureBox_Click;
            }
        }

        private void PictureBox_Click(object sender, System.EventArgs e)
        {
            LargePhotoForm largePhotoForm = new LargePhotoForm();
            largePhotoForm.Picture.ImageLocation = (sender as PictureBox).ImageLocation;
            largePhotoForm.Show();
        }

        public UserAlbumPicturesComponent()
        {
            NumOfPictureBoxes = 8;
            InitializeComponent();
        }

        void IAppComponent.Initialize()
        {
            initializePictureBoxesArray();
        }

        #endregion
    }
}
