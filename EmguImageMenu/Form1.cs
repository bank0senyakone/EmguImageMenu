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
using Emgu.Util;
using Emgu.CV.CvEnum;


namespace EmguImageMenu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent(); 
        }
        Image<Bgr, byte> oriImage;
        Image<Gray, byte> grayImage,binaryImage;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            if(opf.ShowDialog() == DialogResult.OK)
            {
                oriImage = new Image<Bgr, byte>(opf.FileName);
                imgInput.Image = oriImage;
                grayImage = oriImage.Convert<Gray, byte>();
                imgGray.Image = grayImage;
                ImageBinary.Image = null;
                comboBox1.SelectedText = "ເລືອກຮູບແບບພາບຂາວດໍາ";
                comboBox2.SelectedText = "ເລືອກຮູບແບບພາບຂາວດໍາ";
                txtBoxsize.Clear();
                txtParam.Clear();
                txtThreshold.Clear();
            }
        }

        private void imgGray_Click(object sender, EventArgs e)
        {

        }
        
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int gray = 0;
            if(txtThreshold.Text == "")
            {
                gray = 100;
                txtThreshold.Text = "100";
            }
            else
            {
                gray = int.Parse(txtThreshold.Text);
            }
            if (comboBox1.SelectedIndex == 0)
            {
                binaryImage = grayImage.ThresholdBinary(new Gray(gray), new Gray(255));
                ImageBinary.Image = binaryImage;
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                binaryImage = grayImage.ThresholdBinaryInv(new Gray(gray), new Gray(255));
                ImageBinary.Image = binaryImage;
            }else 
            {
                binaryImage = grayImage.ThresholdToZero(new Gray(gray));
                ImageBinary.Image = binaryImage;
            }
        }

        private void ImageBinary_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            int boxsize = 0, Param = 0;
            if (txtBoxsize.Text == "" || txtParam.Text == "")
            {
                MessageBox.Show("ກະລຸນາປ້ອນຄ່າ Boxsize ແລະ param");
            }
            else if ((int.Parse(txtBoxsize.Text)) % 2 == 0)
            {
                boxsize =int.Parse(txtBoxsize.Text);
                boxsize = boxsize+1;
                txtBoxsize.Text= boxsize.ToString();

            }
            else
            {
                boxsize = int.Parse(txtBoxsize.Text);
                Param = int.Parse(txtParam.Text);
                if (comboBox2.SelectedIndex == 0)
                {
                    binaryImage = grayImage.ThresholdAdaptive(new Gray(255), AdaptiveThresholdType.GaussianC, ThresholdType.Binary, boxsize, new Gray(Param));
                    ImageBinary.Image = binaryImage;
                }
                else 
                {
                    binaryImage = grayImage.ThresholdAdaptive(new Gray(256), AdaptiveThresholdType.MeanC, ThresholdType.Binary, boxsize, new Gray(Param));
                    ImageBinary.Image = binaryImage;
                }
            
        }


        }
        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void txtBoxsize_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(ImageBinary.Image == null)
            {
                MessageBox.Show("ຮູບພາບຍັງບໍໄດ້ threshold");
            }
            else
            {
                SaveFileDialog save = new SaveFileDialog();
                save.Title = "Threshold ";
                save.DefaultExt = "*.Jpeg";
                save.Filter = "Jpeg Files (*.jpg)|*.jpg|PNG Files(*.png) | *.jpn | Bmp Files(*.bmp) | *.bmp";
                if(save.ShowDialog() == DialogResult.OK)
                {
                    ImageBinary.Image.Save(save.FileName);
                    MessageBox.Show("ບັນທຶກ ສໍາເລັດ");
                }
            }
        }
    }
}
