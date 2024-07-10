﻿namespace EmguImageMenu
{
    partial class Morphology
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.morphologyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dilationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.erosionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.openingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gradientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.topHatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blackHatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.morphologicalBinaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dilationToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.erosionToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.imgBoxOutput = new Emgu.CV.UI.ImageBox();
            this.imgBoxInput = new Emgu.CV.UI.ImageBox();
            this.closingToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.openingToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgBoxOutput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBoxInput)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Location = new System.Drawing.Point(0, 28);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(919, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // menuStrip2
            // 
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.morphologyToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(919, 28);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(128, 26);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(128, 26);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(128, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // morphologyToolStripMenuItem
            // 
            this.morphologyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dilationToolStripMenuItem,
            this.erosionToolStripMenuItem,
            this.toolStripSeparator1,
            this.openingToolStripMenuItem,
            this.closingToolStripMenuItem,
            this.gradientToolStripMenuItem,
            this.topHatToolStripMenuItem,
            this.blackHatToolStripMenuItem,
            this.morphologicalBinaryToolStripMenuItem});
            this.morphologyToolStripMenuItem.Name = "morphologyToolStripMenuItem";
            this.morphologyToolStripMenuItem.Size = new System.Drawing.Size(105, 24);
            this.morphologyToolStripMenuItem.Text = "Morphology";
            // 
            // dilationToolStripMenuItem
            // 
            this.dilationToolStripMenuItem.Name = "dilationToolStripMenuItem";
            this.dilationToolStripMenuItem.Size = new System.Drawing.Size(235, 26);
            this.dilationToolStripMenuItem.Text = "Dilation";
            this.dilationToolStripMenuItem.Click += new System.EventHandler(this.dilationToolStripMenuItem_Click);
            // 
            // erosionToolStripMenuItem
            // 
            this.erosionToolStripMenuItem.Name = "erosionToolStripMenuItem";
            this.erosionToolStripMenuItem.Size = new System.Drawing.Size(235, 26);
            this.erosionToolStripMenuItem.Text = "Erosion";
            this.erosionToolStripMenuItem.Click += new System.EventHandler(this.erosionToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(232, 6);
            // 
            // openingToolStripMenuItem
            // 
            this.openingToolStripMenuItem.Name = "openingToolStripMenuItem";
            this.openingToolStripMenuItem.Size = new System.Drawing.Size(235, 26);
            this.openingToolStripMenuItem.Text = "Opening";
            this.openingToolStripMenuItem.Click += new System.EventHandler(this.openingToolStripMenuItem_Click);
            // 
            // closingToolStripMenuItem
            // 
            this.closingToolStripMenuItem.Name = "closingToolStripMenuItem";
            this.closingToolStripMenuItem.Size = new System.Drawing.Size(235, 26);
            this.closingToolStripMenuItem.Text = "Closing";
            this.closingToolStripMenuItem.Click += new System.EventHandler(this.closingToolStripMenuItem_Click);
            // 
            // gradientToolStripMenuItem
            // 
            this.gradientToolStripMenuItem.Name = "gradientToolStripMenuItem";
            this.gradientToolStripMenuItem.Size = new System.Drawing.Size(235, 26);
            this.gradientToolStripMenuItem.Text = "Gradient";
            this.gradientToolStripMenuItem.Click += new System.EventHandler(this.gradientToolStripMenuItem_Click);
            // 
            // topHatToolStripMenuItem
            // 
            this.topHatToolStripMenuItem.Name = "topHatToolStripMenuItem";
            this.topHatToolStripMenuItem.Size = new System.Drawing.Size(235, 26);
            this.topHatToolStripMenuItem.Text = "Top Hat";
            this.topHatToolStripMenuItem.Click += new System.EventHandler(this.topHatToolStripMenuItem_Click);
            // 
            // blackHatToolStripMenuItem
            // 
            this.blackHatToolStripMenuItem.Name = "blackHatToolStripMenuItem";
            this.blackHatToolStripMenuItem.Size = new System.Drawing.Size(235, 26);
            this.blackHatToolStripMenuItem.Text = "Black Hat";
            this.blackHatToolStripMenuItem.Click += new System.EventHandler(this.blackHatToolStripMenuItem_Click);
            // 
            // morphologicalBinaryToolStripMenuItem
            // 
            this.morphologicalBinaryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dilationToolStripMenuItem1,
            this.erosionToolStripMenuItem1,
            this.closingToolStripMenuItem1,
            this.openingToolStripMenuItem1});
            this.morphologicalBinaryToolStripMenuItem.Name = "morphologicalBinaryToolStripMenuItem";
            this.morphologicalBinaryToolStripMenuItem.Size = new System.Drawing.Size(235, 26);
            this.morphologicalBinaryToolStripMenuItem.Text = "Morphological Binary";
            // 
            // dilationToolStripMenuItem1
            // 
            this.dilationToolStripMenuItem1.Name = "dilationToolStripMenuItem1";
            this.dilationToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.dilationToolStripMenuItem1.Text = "Dilation";
            this.dilationToolStripMenuItem1.Click += new System.EventHandler(this.dilationToolStripMenuItem1_Click);
            // 
            // erosionToolStripMenuItem1
            // 
            this.erosionToolStripMenuItem1.Name = "erosionToolStripMenuItem1";
            this.erosionToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.erosionToolStripMenuItem1.Text = "Erosion";
            this.erosionToolStripMenuItem1.Click += new System.EventHandler(this.erosionToolStripMenuItem1_Click);
            // 
            // imgBoxOutput
            // 
            this.imgBoxOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imgBoxOutput.Location = new System.Drawing.Point(473, 55);
            this.imgBoxOutput.Name = "imgBoxOutput";
            this.imgBoxOutput.Size = new System.Drawing.Size(423, 411);
            this.imgBoxOutput.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgBoxOutput.TabIndex = 3;
            this.imgBoxOutput.TabStop = false;
            // 
            // imgBoxInput
            // 
            this.imgBoxInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imgBoxInput.Location = new System.Drawing.Point(12, 55);
            this.imgBoxInput.Name = "imgBoxInput";
            this.imgBoxInput.Size = new System.Drawing.Size(423, 411);
            this.imgBoxInput.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgBoxInput.TabIndex = 4;
            this.imgBoxInput.TabStop = false;
            // 
            // closingToolStripMenuItem1
            // 
            this.closingToolStripMenuItem1.Name = "closingToolStripMenuItem1";
            this.closingToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.closingToolStripMenuItem1.Text = "Closing";
            this.closingToolStripMenuItem1.Click += new System.EventHandler(this.closingToolStripMenuItem1_Click);
            // 
            // openingToolStripMenuItem1
            // 
            this.openingToolStripMenuItem1.Name = "openingToolStripMenuItem1";
            this.openingToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.openingToolStripMenuItem1.Text = "Opening";
            this.openingToolStripMenuItem1.Click += new System.EventHandler(this.openingToolStripMenuItem1_Click);
            // 
            // Morphology
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 493);
            this.Controls.Add(this.imgBoxInput);
            this.Controls.Add(this.imgBoxOutput);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Morphology";
            this.Text = "Morphology";
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgBoxOutput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBoxInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem morphologyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dilationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem erosionToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem openingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gradientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem topHatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blackHatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem morphologicalBinaryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dilationToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem erosionToolStripMenuItem1;
        private Emgu.CV.UI.ImageBox imgBoxOutput;
        private Emgu.CV.UI.ImageBox imgBoxInput;
        private System.Windows.Forms.ToolStripMenuItem closingToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem openingToolStripMenuItem1;
    }
}