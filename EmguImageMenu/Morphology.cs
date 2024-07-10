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
using Emgu.CV.Structure;
using Emgu.CV.CvEnum;
using Emgu.Util;

namespace EmguImageMenu
{
    public partial class Morphology : Form
    {
        Image<Bgr,byte> inputImage;
        Image<Bgr, byte> colorImage;
        Image<Gray, byte> binaryImage, morphoImage;

        public Morphology()
        {
            InitializeComponent();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // open button code
            OpenFileDialog opf = new OpenFileDialog();
            if(opf.ShowDialog() == DialogResult.OK)
            {
                inputImage = new Image<Bgr, byte>(opf.FileName);
                imgBoxInput.Image = inputImage;
            }
        }

        private void dilationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(inputImage != null)
            {
                colorImage = new Image<Bgr, byte>(inputImage.Width, inputImage.Height);
                colorImage = inputImage.Dilate(3);
                imgBoxOutput.Image = colorImage;
            }
        }

        private void erosionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(inputImage != null)
            {
                colorImage = new Image<Bgr, byte>(inputImage.Width,inputImage.Height);
                colorImage = inputImage.Erode(5);
                imgBoxOutput.Image = colorImage;
            }
        }

        private void openingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(inputImage != null)
            {
                colorImage = new Image<Bgr, byte>(inputImage.Width, inputImage.Height);
                Mat kernel = CvInvoke.GetStructuringElement(ElementShape.Rectangle,new Size(3,3), new Point(-1,-1));
                colorImage = inputImage.MorphologyEx(MorphOp.Open, kernel, new Point(-1, -1), 1, BorderType.Default, new MCvScalar(1.0));
                imgBoxOutput.Image = colorImage;
            }
        }

        private void closingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(inputImage != null)
            {
                colorImage = new Image<Bgr, byte>(inputImage.Width,imgBoxOutput.Height);
                Mat kernel = CvInvoke.GetStructuringElement(ElementShape.Rectangle, new Size(3,3),new Point(-1,-1));
                colorImage = inputImage.MorphologyEx(MorphOp.Close,kernel, new Point(-1, -1),1, BorderType.Default,new MCvScalar(1.0));
                imgBoxOutput.Image = colorImage;
            }
        }

        private void gradientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(inputImage != null)
            {
                colorImage = new Image<Bgr, byte>(inputImage.Width, imgBoxOutput.Height);
                Mat kernel = CvInvoke.GetStructuringElement(ElementShape.Rectangle,new Size(3,3),new Point(-1,-1));
                colorImage = inputImage.MorphologyEx(MorphOp.Gradient, kernel, new Point(-1, -1), 1, BorderType.Default, new MCvScalar(1.0));
                imgBoxOutput.Image = colorImage;
            }
        }

        private void topHatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(inputImage != null)
            {
                colorImage = new Image<Bgr, byte>(inputImage.Width,imgBoxOutput.Height);
                Mat kernel = CvInvoke.GetStructuringElement(ElementShape.Rectangle,new Size(3,3),new Point(-1,-1));
                colorImage = inputImage.MorphologyEx(MorphOp.Tophat,kernel, new Point(-1, -1),1, BorderType.Default,new MCvScalar(1.0));
                imgBoxOutput.Image = colorImage;
            }
        }

        private void blackHatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(inputImage != null)
            {
                colorImage = new Image<Bgr, byte>(inputImage.Width, imgBoxOutput.Height);
                Mat kernel = CvInvoke.GetStructuringElement(ElementShape.Rectangle, new Size(3, 3), new Point(-1, -1));
                colorImage = inputImage.MorphologyEx(MorphOp.Blackhat,kernel, new Point(-1, -1),1,BorderType.Default,new MCvScalar(0.0));
                imgBoxOutput.Image = colorImage;
            }
        }

        private void dilationToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if(inputImage != null)
            {
                binaryImage = new Image<Gray,byte>(inputImage.Width, inputImage.Height);
                binaryImage = inputImage.Convert<Gray,byte>().ThresholdBinaryInv(new Gray(150),new Gray(255)).Dilate(1);
                imgBoxOutput.Image=binaryImage;
            }
        }

        private void erosionToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if(inputImage != null)
            {
                binaryImage = new Image<Gray, byte>(inputImage.Width, inputImage.Height);
                binaryImage = inputImage.Convert<Gray, byte>().ThresholdBinaryInv(new Gray(150), new
               Gray(255)).Erode(1);
                imgBoxOutput.Image = binaryImage;
            }
        }

        private void closingToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (inputImage != null)
            {
                binaryImage = inputImage.Convert<Gray, byte>().ThresholdBinaryInv(new Gray(150), new
               Gray(255));
                Mat kernel = CvInvoke.GetStructuringElement(ElementShape.Rectangle, new Size(3, 3), new
               Point(-1, -1));
                morphoImage = binaryImage.MorphologyEx(MorphOp.Close, kernel, new Point(-1, -1),
                1, BorderType.Default, new MCvScalar(1.0));
                imgBoxOutput.Image = morphoImage;
            }

        }

        private void openingToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (inputImage != null)
            {
                binaryImage = inputImage.Convert<Gray, byte>().ThresholdBinaryInv(new Gray(150), new
               Gray(255));
                Mat kernel = CvInvoke.GetStructuringElement(ElementShape.Rectangle, new Size(3, 3), new
               Point(-1, -1));
                morphoImage = binaryImage.MorphologyEx(MorphOp.Open, kernel, new Point(-1, -1),
                1, BorderType.Default, new MCvScalar(1.0));

                imgBoxOutput.Image = morphoImage;
            }
        }
        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
