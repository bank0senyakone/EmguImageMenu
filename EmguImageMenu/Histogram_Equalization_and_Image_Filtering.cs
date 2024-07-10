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
        Image<Bgr, byte> oriImage;
        Image<Gray,byte>imgBeforeE,imgAfterE;
        Image<Gray, byte> imgFilter;
        Image<Bgr,byte> oriImageFilter;
        int Ksize,check;

        private void btnLoadImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            if (opf.ShowDialog() == DialogResult.OK)
            {
                
                imgBeforeE = new Image<Gray, byte>(opf.FileName);
                imageBoxinput.Image = imgBeforeE;

                oriImage = new Image<Bgr, byte>(opf.FileName);
                imgBoxolg.Image = oriImage;
             //   imgAfterE = new Image<Gray, byte>(imgBeforeE.Width, imgBeforeE.Height);
                htgori.GenerateHistograms(oriImage, 255);
                htgori.Refresh();
                htgBeforeE.GenerateHistograms(imgBeforeE, 255);
                htgBeforeE.Refresh();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
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
            Ksize = int.Parse(txtKsize.Text);
            if(check == 1)
            {
                oriImageFilter = new Image<Bgr, byte>(oriImage.Width, oriImage.Height);
                CvInvoke.MedianBlur(oriImage, oriImageFilter,Ksize);
                imageBoxoutput.Image = oriImageFilter;
                imageBoxoutput.Refresh();
                htgAfterE.ClearHistogram() ;
                htgAfterE.GenerateHistograms(oriImageFilter, 255);
            }
            else
            {
                imgFilter = new Image<Gray, byte>(imgAfterE.Width, imgAfterE.Height);
                CvInvoke.MedianBlur(imgAfterE, imgFilter,Ksize);

                imageBoxoutput.Image = imgFilter;
                imageBoxoutput.Refresh();
                htgAfterE.ClearHistogram();
                htgAfterE.GenerateHistograms(imgFilter, 255);
            }

            htgAfterE.Refresh();
        }

        private void htgBeforeE_Load(object sender, EventArgs e)
        {

        }

        private void btnGuassian_Click(object sender, EventArgs e)
        {
            Ksize = int.Parse(txtKsize.Text);
            if(check == 1)
            {
                oriImageFilter = new Image<Bgr, byte>(oriImage.Width, oriImage.Height);
                CvInvoke.GaussianBlur(oriImage, oriImageFilter, new Size(Ksize,Ksize),0,0,BorderType.Default);
                imageBoxoutput.Image = oriImageFilter;
                imageBoxoutput.Refresh();
                htgAfterE.ClearHistogram();
                htgAfterE.GenerateHistograms(oriImageFilter,255);
            }
            else
            {
                imgFilter = new Image<Gray, byte>(imgAfterE.Width, imgAfterE.Height);
                CvInvoke.GaussianBlur(imgAfterE, imgFilter, new Size(Ksize, Ksize), 0, 0, BorderType.Default);
                imageBoxoutput.Image = imgFilter;
                imageBoxoutput.Refresh();
                htgAfterE.ClearHistogram();
                htgAfterE.GenerateHistograms(imgFilter, 255);

            }
            htgAfterE.Refresh();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void htg3_Load(object sender, EventArgs e)
        {

        }

        private void imageBoxinput_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtKsize_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtKsize_KeyDown(object sender, KeyEventArgs e)
        {
   
        }

        private void txtKsize_TextChanged_1(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtKsize.Text == "")
            {
               txtKsize.Text = "3";
            }
            else
            {
                Ksize = int.Parse(txtKsize.Text);
                if (Ksize % 2 == 0)
                {
                    Ksize = Ksize + 1;
                    txtKsize.Text = Ksize.ToString();
                }
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            check = 2;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            check = 1;
        }

        private void Histogram_Equalization_and_Image_Filtering_Load(object sender, EventArgs e)
        {

        }
    }
}
