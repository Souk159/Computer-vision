namespace Thresholding
{
    partial class VDO
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Canny = new System.Windows.Forms.Button();
            this.Dilation = new System.Windows.Forms.Button();
            this.Sobel = new System.Windows.Forms.Button();
            this.Erotion = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCapture = new System.Windows.Forms.Button();
            this.btnBinary = new System.Windows.Forms.Button();
            this.btnGray = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ImgCapture = new Emgu.CV.UI.ImageBox();
            this.imgBoxVDO = new Emgu.CV.UI.ImageBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImgCapture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBoxVDO)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Canny);
            this.groupBox1.Controls.Add(this.Dilation);
            this.groupBox1.Controls.Add(this.Sobel);
            this.groupBox1.Controls.Add(this.Erotion);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.btnCapture);
            this.groupBox1.Controls.Add(this.btnBinary);
            this.groupBox1.Controls.Add(this.btnGray);
            this.groupBox1.Controls.Add(this.btnStop);
            this.groupBox1.Controls.Add(this.btnStart);
            this.groupBox1.Location = new System.Drawing.Point(116, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(875, 183);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "VDO From WebCam";
            // 
            // Canny
            // 
            this.Canny.Location = new System.Drawing.Point(101, 103);
            this.Canny.Name = "Canny";
            this.Canny.Size = new System.Drawing.Size(110, 49);
            this.Canny.TabIndex = 8;
            this.Canny.Text = "Canny";
            this.Canny.UseVisualStyleBackColor = true;
            this.Canny.Click += new System.EventHandler(this.Canny_Click);
            // 
            // Dilation
            // 
            this.Dilation.Location = new System.Drawing.Point(442, 103);
            this.Dilation.Name = "Dilation";
            this.Dilation.Size = new System.Drawing.Size(110, 49);
            this.Dilation.TabIndex = 7;
            this.Dilation.Text = "Dilation";
            this.Dilation.UseVisualStyleBackColor = true;
            this.Dilation.Click += new System.EventHandler(this.Dilation_Click);
            // 
            // Sobel
            // 
            this.Sobel.Location = new System.Drawing.Point(274, 103);
            this.Sobel.Name = "Sobel";
            this.Sobel.Size = new System.Drawing.Size(110, 49);
            this.Sobel.TabIndex = 6;
            this.Sobel.Text = "Sobel";
            this.Sobel.UseVisualStyleBackColor = true;
            this.Sobel.Click += new System.EventHandler(this.Sobel_Click);
            // 
            // Erotion
            // 
            this.Erotion.Location = new System.Drawing.Point(609, 103);
            this.Erotion.Name = "Erotion";
            this.Erotion.Size = new System.Drawing.Size(110, 49);
            this.Erotion.TabIndex = 5;
            this.Erotion.Text = "Erotion";
            this.Erotion.UseVisualStyleBackColor = true;
            this.Erotion.Click += new System.EventHandler(this.Erotion_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(747, 34);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(107, 44);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCapture
            // 
            this.btnCapture.Location = new System.Drawing.Point(612, 34);
            this.btnCapture.Name = "btnCapture";
            this.btnCapture.Size = new System.Drawing.Size(107, 44);
            this.btnCapture.TabIndex = 4;
            this.btnCapture.Text = "Capture";
            this.btnCapture.UseVisualStyleBackColor = true;
            this.btnCapture.Click += new System.EventHandler(this.btnCapture_Click);
            // 
            // btnBinary
            // 
            this.btnBinary.Location = new System.Drawing.Point(469, 34);
            this.btnBinary.Name = "btnBinary";
            this.btnBinary.Size = new System.Drawing.Size(107, 44);
            this.btnBinary.TabIndex = 3;
            this.btnBinary.Text = "Binary";
            this.btnBinary.UseVisualStyleBackColor = true;
            this.btnBinary.Click += new System.EventHandler(this.btnBinary_Click);
            // 
            // btnGray
            // 
            this.btnGray.Location = new System.Drawing.Point(322, 34);
            this.btnGray.Name = "btnGray";
            this.btnGray.Size = new System.Drawing.Size(107, 44);
            this.btnGray.TabIndex = 2;
            this.btnGray.Text = "Gray";
            this.btnGray.UseVisualStyleBackColor = true;
            this.btnGray.Click += new System.EventHandler(this.btnGray_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(174, 34);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(107, 44);
            this.btnStop.TabIndex = 1;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(25, 34);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(107, 44);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ImgCapture);
            this.groupBox2.Controls.Add(this.imgBoxVDO);
            this.groupBox2.Location = new System.Drawing.Point(12, 294);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(979, 499);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "VDO Preview";
            // 
            // ImgCapture
            // 
            this.ImgCapture.Location = new System.Drawing.Point(525, 21);
            this.ImgCapture.Name = "ImgCapture";
            this.ImgCapture.Size = new System.Drawing.Size(433, 468);
            this.ImgCapture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImgCapture.TabIndex = 3;
            this.ImgCapture.TabStop = false;
            // 
            // imgBoxVDO
            // 
            this.imgBoxVDO.Location = new System.Drawing.Point(24, 21);
            this.imgBoxVDO.Name = "imgBoxVDO";
            this.imgBoxVDO.Size = new System.Drawing.Size(433, 468);
            this.imgBoxVDO.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgBoxVDO.TabIndex = 2;
            this.imgBoxVDO.TabStop = false;
            // 
            // VDO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 805);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "VDO";
            this.Text = "VDO";
            this.Load += new System.EventHandler(this.VDO_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ImgCapture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBoxVDO)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCapture;
        private System.Windows.Forms.Button btnBinary;
        private System.Windows.Forms.Button btnGray;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnStart;
        private Emgu.CV.UI.ImageBox imgBoxVDO;
        private Emgu.CV.UI.ImageBox ImgCapture;
        private System.Windows.Forms.Button Canny;
        private System.Windows.Forms.Button Dilation;
        private System.Windows.Forms.Button Sobel;
        private System.Windows.Forms.Button Erotion;
    }
}