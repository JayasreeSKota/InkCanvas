namespace DrawingApp
{
    partial class Form1
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
            this.canvas = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.redBox = new System.Windows.Forms.PictureBox();
            this.orangeBox = new System.Windows.Forms.PictureBox();
            this.YellowBox = new System.Windows.Forms.PictureBox();
            this.TealBox = new System.Windows.Forms.PictureBox();
            this.Bluebox = new System.Windows.Forms.PictureBox();
            this.GreenBox = new System.Windows.Forms.PictureBox();
            this.BlackBox = new System.Windows.Forms.PictureBox();
            this.PinkBox = new System.Windows.Forms.PictureBox();
            this.canvas.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.redBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orangeBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.YellowBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TealBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bluebox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GreenBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BlackBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PinkBox)).BeginInit();
            this.SuspendLayout();
            // 
            // canvas
            // 
            this.canvas.Controls.Add(this.panel1);
            this.canvas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.canvas.Location = new System.Drawing.Point(0, 0);
            this.canvas.Name = "canvas";
            this.canvas.Size = new System.Drawing.Size(1197, 497);
            this.canvas.TabIndex = 0;
            this.canvas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.canvas_MouseDown);
            this.canvas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.canvas_MouseMove);
            this.canvas.MouseUp += new System.Windows.Forms.MouseEventHandler(this.canvas_MouseUp);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.BlackBox);
            this.panel1.Controls.Add(this.PinkBox);
            this.panel1.Controls.Add(this.YellowBox);
            this.panel1.Controls.Add(this.orangeBox);
            this.panel1.Controls.Add(this.Bluebox);
            this.panel1.Controls.Add(this.TealBox);
            this.panel1.Controls.Add(this.GreenBox);
            this.panel1.Controls.Add(this.redBox);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(186, 88);
            this.panel1.TabIndex = 0;
            // 
            // redBox
            // 
            this.redBox.BackColor = System.Drawing.Color.Red;
            this.redBox.Location = new System.Drawing.Point(3, 0);
            this.redBox.Name = "redBox";
            this.redBox.Size = new System.Drawing.Size(38, 47);
            this.redBox.TabIndex = 1;
            this.redBox.TabStop = false;
            this.redBox.Click += new System.EventHandler(this.BlackBox_Click);
            // 
            // orangeBox
            // 
            this.orangeBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.orangeBox.Location = new System.Drawing.Point(47, 0);
            this.orangeBox.Name = "orangeBox";
            this.orangeBox.Size = new System.Drawing.Size(38, 47);
            this.orangeBox.TabIndex = 2;
            this.orangeBox.TabStop = false;
            this.orangeBox.Click += new System.EventHandler(this.BlackBox_Click);
            // 
            // YellowBox
            // 
            this.YellowBox.BackColor = System.Drawing.Color.Yellow;
            this.YellowBox.Location = new System.Drawing.Point(91, 0);
            this.YellowBox.Name = "YellowBox";
            this.YellowBox.Size = new System.Drawing.Size(38, 47);
            this.YellowBox.TabIndex = 3;
            this.YellowBox.TabStop = false;
            this.YellowBox.Click += new System.EventHandler(this.BlackBox_Click);
            // 
            // TealBox
            // 
            this.TealBox.BackColor = System.Drawing.Color.Cyan;
            this.TealBox.Location = new System.Drawing.Point(0, 53);
            this.TealBox.Name = "TealBox";
            this.TealBox.Size = new System.Drawing.Size(41, 35);
            this.TealBox.TabIndex = 4;
            this.TealBox.TabStop = false;
            this.TealBox.Click += new System.EventHandler(this.BlackBox_Click);
            // 
            // Bluebox
            // 
            this.Bluebox.BackColor = System.Drawing.Color.Blue;
            this.Bluebox.Location = new System.Drawing.Point(47, 53);
            this.Bluebox.Name = "Bluebox";
            this.Bluebox.Size = new System.Drawing.Size(38, 35);
            this.Bluebox.TabIndex = 5;
            this.Bluebox.TabStop = false;
            this.Bluebox.Click += new System.EventHandler(this.BlackBox_Click);
            // 
            // GreenBox
            // 
            this.GreenBox.BackColor = System.Drawing.Color.Lime;
            this.GreenBox.Location = new System.Drawing.Point(142, 0);
            this.GreenBox.Name = "GreenBox";
            this.GreenBox.Size = new System.Drawing.Size(41, 47);
            this.GreenBox.TabIndex = 6;
            this.GreenBox.TabStop = false;
            this.GreenBox.Click += new System.EventHandler(this.BlackBox_Click);
            // 
            // BlackBox
            // 
            this.BlackBox.BackColor = System.Drawing.Color.Black;
            this.BlackBox.Location = new System.Drawing.Point(142, 53);
            this.BlackBox.Name = "BlackBox";
            this.BlackBox.Size = new System.Drawing.Size(38, 35);
            this.BlackBox.TabIndex = 6;
            this.BlackBox.TabStop = false;
            this.BlackBox.Click += new System.EventHandler(this.BlackBox_Click);
            // 
            // PinkBox
            // 
            this.PinkBox.BackColor = System.Drawing.Color.Fuchsia;
            this.PinkBox.Location = new System.Drawing.Point(91, 53);
            this.PinkBox.Name = "PinkBox";
            this.PinkBox.Size = new System.Drawing.Size(38, 35);
            this.PinkBox.TabIndex = 7;
            this.PinkBox.TabStop = false;
            this.PinkBox.Click += new System.EventHandler(this.BlackBox_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1197, 497);
            this.Controls.Add(this.canvas);
            this.Name = "Form1";
            this.Text = "Form1";
            this.canvas.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.redBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orangeBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.YellowBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TealBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bluebox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GreenBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BlackBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PinkBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel canvas;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox BlackBox;
        private System.Windows.Forms.PictureBox PinkBox;
        private System.Windows.Forms.PictureBox YellowBox;
        private System.Windows.Forms.PictureBox orangeBox;
        private System.Windows.Forms.PictureBox Bluebox;
        private System.Windows.Forms.PictureBox TealBox;
        private System.Windows.Forms.PictureBox GreenBox;
        private System.Windows.Forms.PictureBox redBox;
    }
}

