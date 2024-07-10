namespace EmguImageMenu
{
    partial class Histogram_Equalization_and_Image_Filtering
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.htgAfterE = new Emgu.CV.UI.HistogramBox();
            this.htgBeforeE = new Emgu.CV.UI.HistogramBox();
            this.htgori = new Emgu.CV.UI.HistogramBox();
            this.btnLoadImage = new System.Windows.Forms.Button();
            this.btnEquali = new System.Windows.Forms.Button();
            this.btnGuassian = new System.Windows.Forms.Button();
            this.btnMedian = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtKsize = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.imgBoxolg = new Emgu.CV.UI.ImageBox();
            this.imageBoxinput = new Emgu.CV.UI.ImageBox();
            this.imageBoxoutput = new Emgu.CV.UI.ImageBox();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgBoxolg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBoxinput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBoxoutput)).BeginInit();
            this.SuspendLayout();
            // 
            // htgAfterE
            // 
            this.htgAfterE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.htgAfterE.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.htgAfterE.Location = new System.Drawing.Point(263, 370);
            this.htgAfterE.Margin = new System.Windows.Forms.Padding(8);
            this.htgAfterE.Name = "htgAfterE";
            this.htgAfterE.Size = new System.Drawing.Size(465, 188);
            this.htgAfterE.TabIndex = 5;
            // 
            // htgBeforeE
            // 
            this.htgBeforeE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.htgBeforeE.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.htgBeforeE.Location = new System.Drawing.Point(263, 199);
            this.htgBeforeE.Margin = new System.Windows.Forms.Padding(8);
            this.htgBeforeE.Name = "htgBeforeE";
            this.htgBeforeE.Size = new System.Drawing.Size(465, 156);
            this.htgBeforeE.TabIndex = 4;
            this.htgBeforeE.Load += new System.EventHandler(this.htgBeforeE_Load);
            // 
            // htgori
            // 
            this.htgori.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.htgori.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.htgori.Location = new System.Drawing.Point(263, 0);
            this.htgori.Margin = new System.Windows.Forms.Padding(8);
            this.htgori.Name = "htgori";
            this.htgori.Size = new System.Drawing.Size(465, 180);
            this.htgori.TabIndex = 8;
            this.htgori.Load += new System.EventHandler(this.htg3_Load);
            // 
            // btnLoadImage
            // 
            this.btnLoadImage.Location = new System.Drawing.Point(3, 15);
            this.btnLoadImage.Name = "btnLoadImage";
            this.btnLoadImage.Size = new System.Drawing.Size(245, 39);
            this.btnLoadImage.TabIndex = 0;
            this.btnLoadImage.Text = "Load image";
            this.btnLoadImage.UseVisualStyleBackColor = true;
            this.btnLoadImage.Click += new System.EventHandler(this.btnLoadImage_Click);
            // 
            // btnEquali
            // 
            this.btnEquali.Location = new System.Drawing.Point(3, 60);
            this.btnEquali.Name = "btnEquali";
            this.btnEquali.Size = new System.Drawing.Size(245, 55);
            this.btnEquali.TabIndex = 1;
            this.btnEquali.Text = "Histogram Equalization";
            this.btnEquali.UseVisualStyleBackColor = true;
            this.btnEquali.Click += new System.EventHandler(this.btnEquali_Click);
            // 
            // btnGuassian
            // 
            this.btnGuassian.Location = new System.Drawing.Point(16, 106);
            this.btnGuassian.Name = "btnGuassian";
            this.btnGuassian.Size = new System.Drawing.Size(212, 39);
            this.btnGuassian.TabIndex = 2;
            this.btnGuassian.Text = "Guassian Filter";
            this.btnGuassian.UseVisualStyleBackColor = true;
            this.btnGuassian.Click += new System.EventHandler(this.btnGuassian_Click);
            // 
            // btnMedian
            // 
            this.btnMedian.Location = new System.Drawing.Point(16, 160);
            this.btnMedian.Name = "btnMedian";
            this.btnMedian.Size = new System.Drawing.Size(212, 39);
            this.btnMedian.TabIndex = 3;
            this.btnMedian.Text = "Median Filter";
            this.btnMedian.UseVisualStyleBackColor = true;
            this.btnMedian.Click += new System.EventHandler(this.btnMedian_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(3, 121);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(245, 39);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save image";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(3, 166);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(245, 39);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.btnEquali);
            this.panel1.Controls.Add(this.btnLoadImage);
            this.panel1.Location = new System.Drawing.Point(739, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(257, 676);
            this.panel1.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.txtKsize);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.btnGuassian);
            this.groupBox1.Controls.Add(this.btnMedian);
            this.groupBox1.Location = new System.Drawing.Point(14, 220);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(234, 314);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // button1
            // 
            this.button1.Image = global::EmguImageMenu.Properties.Resources.check1;
            this.button1.Location = new System.Drawing.Point(138, 232);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(79, 56);
            this.button1.TabIndex = 6;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtKsize
            // 
            this.txtKsize.Location = new System.Drawing.Point(16, 248);
            this.txtKsize.Name = "txtKsize";
            this.txtKsize.Size = new System.Drawing.Size(97, 30);
            this.txtKsize.TabIndex = 5;
            this.txtKsize.Text = "3";
            this.txtKsize.TextChanged += new System.EventHandler(this.txtKsize_TextChanged_1);
            this.txtKsize.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtKsize_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 214);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 22);
            this.label1.TabIndex = 4;
            this.label1.Text = "ksize";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Saysettha OT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.Location = new System.Drawing.Point(16, 61);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(144, 36);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "ຮຼບພາບສີເທົາ";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Saysettha OT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(16, 29);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(113, 36);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "ຮູບພາບສີ";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.imgBoxolg);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.htgori);
            this.panel2.Controls.Add(this.imageBoxinput);
            this.panel2.Controls.Add(this.htgBeforeE);
            this.panel2.Controls.Add(this.imageBoxoutput);
            this.panel2.Controls.Add(this.htgAfterE);
            this.panel2.Location = new System.Drawing.Point(6, 8);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1017, 565);
            this.panel2.TabIndex = 9;
            // 
            // imgBoxolg
            // 
            this.imgBoxolg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imgBoxolg.Location = new System.Drawing.Point(6, 3);
            this.imgBoxolg.Name = "imgBoxolg";
            this.imgBoxolg.Size = new System.Drawing.Size(246, 180);
            this.imgBoxolg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgBoxolg.TabIndex = 7;
            this.imgBoxolg.TabStop = false;
            // 
            // imageBoxinput
            // 
            this.imageBoxinput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imageBoxinput.Location = new System.Drawing.Point(6, 199);
            this.imageBoxinput.Name = "imageBoxinput";
            this.imageBoxinput.Size = new System.Drawing.Size(246, 156);
            this.imageBoxinput.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageBoxinput.TabIndex = 2;
            this.imageBoxinput.TabStop = false;
            this.imageBoxinput.Click += new System.EventHandler(this.imageBoxinput_Click);
            // 
            // imageBoxoutput
            // 
            this.imageBoxoutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imageBoxoutput.Location = new System.Drawing.Point(6, 370);
            this.imageBoxoutput.Name = "imageBoxoutput";
            this.imageBoxoutput.Size = new System.Drawing.Size(246, 188);
            this.imageBoxoutput.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageBoxoutput.TabIndex = 3;
            this.imageBoxoutput.TabStop = false;
            // 
            // Histogram_Equalization_and_Image_Filtering
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 583);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Histogram_Equalization_and_Image_Filtering";
            this.Text = "Histogram_Equalization_and_Image_Filtering";
            this.Load += new System.EventHandler(this.Histogram_Equalization_and_Image_Filtering_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgBoxolg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBoxinput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBoxoutput)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Emgu.CV.UI.ImageBox imageBoxinput;
        private Emgu.CV.UI.ImageBox imageBoxoutput;
        private Emgu.CV.UI.HistogramBox htgAfterE;
        private Emgu.CV.UI.HistogramBox htgBeforeE;
        private Emgu.CV.UI.ImageBox imgBoxolg;
        private Emgu.CV.UI.HistogramBox htgori;
        private System.Windows.Forms.Button btnLoadImage;
        private System.Windows.Forms.Button btnEquali;
        private System.Windows.Forms.Button btnGuassian;
        private System.Windows.Forms.Button btnMedian;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.TextBox txtKsize;
        private System.Windows.Forms.Button button1;
    }
}