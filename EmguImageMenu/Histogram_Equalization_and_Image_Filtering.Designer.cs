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
            this.imageBoxinput = new Emgu.CV.UI.ImageBox();
            this.imageBoxoutput = new Emgu.CV.UI.ImageBox();
            this.htgAfterE = new Emgu.CV.UI.HistogramBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnMedian = new System.Windows.Forms.Button();
            this.btnGuassian = new System.Windows.Forms.Button();
            this.btnEquali = new System.Windows.Forms.Button();
            this.btnLoadImage = new System.Windows.Forms.Button();
            this.htgBeforeE = new Emgu.CV.UI.HistogramBox();
            this.imagebox3 = new Emgu.CV.UI.ImageBox();
            this.htg3 = new Emgu.CV.UI.HistogramBox();
            ((System.ComponentModel.ISupportInitialize)(this.imageBoxinput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBoxoutput)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagebox3)).BeginInit();
            this.SuspendLayout();
            // 
            // imageBoxinput
            // 
            this.imageBoxinput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imageBoxinput.Location = new System.Drawing.Point(12, 12);
            this.imageBoxinput.Name = "imageBoxinput";
            this.imageBoxinput.Size = new System.Drawing.Size(310, 214);
            this.imageBoxinput.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageBoxinput.TabIndex = 2;
            this.imageBoxinput.TabStop = false;
            // 
            // imageBoxoutput
            // 
            this.imageBoxoutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imageBoxoutput.Location = new System.Drawing.Point(12, 232);
            this.imageBoxoutput.Name = "imageBoxoutput";
            this.imageBoxoutput.Size = new System.Drawing.Size(310, 228);
            this.imageBoxoutput.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageBoxoutput.TabIndex = 3;
            this.imageBoxoutput.TabStop = false;
            // 
            // htgAfterE
            // 
            this.htgAfterE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.htgAfterE.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.htgAfterE.Location = new System.Drawing.Point(333, 232);
            this.htgAfterE.Margin = new System.Windows.Forms.Padding(8);
            this.htgAfterE.Name = "htgAfterE";
            this.htgAfterE.Size = new System.Drawing.Size(437, 228);
            this.htgAfterE.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.btnMedian);
            this.panel1.Controls.Add(this.btnGuassian);
            this.panel1.Controls.Add(this.btnEquali);
            this.panel1.Controls.Add(this.btnLoadImage);
            this.panel1.Location = new System.Drawing.Point(793, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(232, 692);
            this.panel1.TabIndex = 6;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(14, 416);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(189, 39);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(14, 346);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(189, 39);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save image";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnMedian
            // 
            this.btnMedian.Location = new System.Drawing.Point(14, 278);
            this.btnMedian.Name = "btnMedian";
            this.btnMedian.Size = new System.Drawing.Size(189, 39);
            this.btnMedian.TabIndex = 3;
            this.btnMedian.Text = "Median Filter";
            this.btnMedian.UseVisualStyleBackColor = true;
            this.btnMedian.Click += new System.EventHandler(this.btnMedian_Click);
            // 
            // btnGuassian
            // 
            this.btnGuassian.Location = new System.Drawing.Point(14, 191);
            this.btnGuassian.Name = "btnGuassian";
            this.btnGuassian.Size = new System.Drawing.Size(189, 39);
            this.btnGuassian.TabIndex = 2;
            this.btnGuassian.Text = "Guassian Filter";
            this.btnGuassian.UseVisualStyleBackColor = true;
            this.btnGuassian.Click += new System.EventHandler(this.btnGuassian_Click);
            // 
            // btnEquali
            // 
            this.btnEquali.Location = new System.Drawing.Point(14, 109);
            this.btnEquali.Name = "btnEquali";
            this.btnEquali.Size = new System.Drawing.Size(189, 55);
            this.btnEquali.TabIndex = 1;
            this.btnEquali.Text = "Histogram Equalization";
            this.btnEquali.UseVisualStyleBackColor = true;
            this.btnEquali.Click += new System.EventHandler(this.btnEquali_Click);
            // 
            // btnLoadImage
            // 
            this.btnLoadImage.Location = new System.Drawing.Point(14, 30);
            this.btnLoadImage.Name = "btnLoadImage";
            this.btnLoadImage.Size = new System.Drawing.Size(189, 39);
            this.btnLoadImage.TabIndex = 0;
            this.btnLoadImage.Text = "Load image";
            this.btnLoadImage.UseVisualStyleBackColor = true;
            this.btnLoadImage.Click += new System.EventHandler(this.btnLoadImage_Click);
            // 
            // htgBeforeE
            // 
            this.htgBeforeE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.htgBeforeE.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.htgBeforeE.Location = new System.Drawing.Point(333, 12);
            this.htgBeforeE.Margin = new System.Windows.Forms.Padding(8);
            this.htgBeforeE.Name = "htgBeforeE";
            this.htgBeforeE.Size = new System.Drawing.Size(437, 214);
            this.htgBeforeE.TabIndex = 4;
            this.htgBeforeE.Load += new System.EventHandler(this.htgBeforeE_Load);
            // 
            // imagebox3
            // 
            this.imagebox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imagebox3.Location = new System.Drawing.Point(12, 466);
            this.imagebox3.Name = "imagebox3";
            this.imagebox3.Size = new System.Drawing.Size(310, 228);
            this.imagebox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imagebox3.TabIndex = 7;
            this.imagebox3.TabStop = false;
            // 
            // htg3
            // 
            this.htg3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.htg3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.htg3.Location = new System.Drawing.Point(333, 470);
            this.htg3.Margin = new System.Windows.Forms.Padding(8);
            this.htg3.Name = "htg3";
            this.htg3.Size = new System.Drawing.Size(437, 228);
            this.htg3.TabIndex = 8;
            // 
            // Histogram_Equalization_and_Image_Filtering
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 715);
            this.Controls.Add(this.htg3);
            this.Controls.Add(this.imagebox3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.htgAfterE);
            this.Controls.Add(this.htgBeforeE);
            this.Controls.Add(this.imageBoxoutput);
            this.Controls.Add(this.imageBoxinput);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Histogram_Equalization_and_Image_Filtering";
            this.Text = "Histogram_Equalization_and_Image_Filtering";
            this.Load += new System.EventHandler(this.Histogram_Equalization_and_Image_Filtering_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imageBoxinput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBoxoutput)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imagebox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Emgu.CV.UI.ImageBox imageBoxinput;
        private Emgu.CV.UI.ImageBox imageBoxoutput;
        private Emgu.CV.UI.HistogramBox htgAfterE;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnLoadImage;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnMedian;
        private System.Windows.Forms.Button btnGuassian;
        private System.Windows.Forms.Button btnEquali;
        private System.Windows.Forms.Button btnExit;
        private Emgu.CV.UI.HistogramBox htgBeforeE;
        private Emgu.CV.UI.ImageBox imagebox3;
        private Emgu.CV.UI.HistogramBox htg3;
    }
}