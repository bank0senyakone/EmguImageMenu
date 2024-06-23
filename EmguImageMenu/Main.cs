using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmguImageMenu
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            btn1.BackColor = Color.FromArgb(75, 112, 245);

            this.pnlLoad.Controls.Clear();
            Histogram_Equalization_and_Image_Filtering frmHistogram_vrb = new Histogram_Equalization_and_Image_Filtering() { Dock = DockStyle.Fill,TopLevel=false,TopMost=true };
            frmHistogram_vrb.FormBorderStyle = FormBorderStyle.None;
            this.pnlLoad .Controls.Add(frmHistogram_vrb);
            frmHistogram_vrb.Show();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            btn2.BackColor = Color.FromArgb(75, 112, 245);
        }

        private void btn1_Leave(object sender, EventArgs e)
        {
            btn1.BackColor = Color.White;
        }
    }
}
