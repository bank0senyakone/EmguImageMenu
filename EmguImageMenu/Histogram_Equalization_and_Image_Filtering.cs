using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using Emgu.Util;



//hi hihihihihihihihihihihi

namespace EmguImageMenu
{
    public partial class Histogram_Equalization_and_Image_Filtering : Form
    {
        public Histogram_Equalization_and_Image_Filtering()
        {
            InitializeComponent();
        }
        Image<Gray,byte>imgBeforeE,imgAfterE;
        Image<Gray, byte> imgFilter;


        int hi = 101;

        private void btnLoadImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            if (opf.ShowDialog() == DialogResult.OK)
            {
                imgBeforeE = new Image<Gray, byte>(opf.FileName);
                imageBoxinput.Image = imgBeforeE;
                htgBeforeE.GenerateHistograms(imgBeforeE, 255);
                htgBeforeE.Refresh();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            imgAfterE = new Image<Gray, byte>(imgBeforeE.Width, imgBeforeE.Height);
            CvInvoke.EqualizeHist(imgBeforeE,imgAfterE);
            imageBoxoutput.Image = imgAfterE;

            SaveFileDialog save = new SaveFileDialog();
            save.Title = "Image Equalizarion and Filtering";
            save.Filter = "Jpeg Files(*.jpg)|*.jpg|Bitmap Files(*.bmp)|*.bmp";

            if(save.ShowDialog() == DialogResult.OK)
            {
                imageBoxoutput.Image.Save(save.FileName);
            }

            htgAfterE.ClearHistogram();
            htgAfterE.GenerateHistograms(imgAfterE, 255);
            htgAfterE.Refresh();

        }

        private void btnEquali_Click(object sender, EventArgs e)
        {
            imgAfterE = new Image<Gray, byte>(imgBeforeE.Width, imgBeforeE.Height);
            CvInvoke.EqualizeHist(imgBeforeE, imgAfterE);
            imageBoxoutput.Image = imgAfterE;
            htgAfterE.ClearHistogram();
            htgAfterE.GenerateHistograms(imgAfterE, 255);
            htgAfterE.Refresh();
        }

        private void btnMedian_Click(object sender, EventArgs e)
        {
            imgFilter = new Image<Gray, byte>(im)
        }

        private void htgBeforeE_Load(object sender, EventArgs e)
        {

        }

        private void btnGuassian_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Histogram_Equalization_and_Image_Filtering_Load(object sender, EventArgs e)
        {

        }
    }
}
