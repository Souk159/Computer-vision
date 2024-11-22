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

namespace Thresholding
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        Image<Bgr, byte> inputImage;
        Image<Bgr, byte> colorImage;
        Image<Gray, byte> binaryImage, morphoImage;

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void opentoolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            if (opf.ShowDialog() == DialogResult.OK)
            {
                inputImage = new Image<Bgr, byte>(opf.FileName);
                pictureBoxInput.Image = inputImage.Bitmap;
            }
        }

        private void savetoolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void exittoolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dilationtoolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (inputImage != null)
            {
                colorImage = new Image<Bgr, byte>(inputImage.Width, inputImage.Height);
                colorImage = inputImage.Dilate(3);
                pictureBoxOutput.Image = colorImage.Bitmap;
            }
        }

        private void erosiontoolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (inputImage != null)
            {
                colorImage = new Image<Bgr, byte>(inputImage.Width, inputImage.Height);
                colorImage = inputImage.Erode(5);
                pictureBoxOutput.Image = colorImage.Bitmap;
            }

        }

        private void closingtoolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (inputImage != null)
            {
                colorImage = new Image<Bgr, byte>(inputImage.Width, inputImage.Height);
                Mat kernel = CvInvoke.GetStructuringElement(ElementShape.Rectangle, new Size(3, 3), new Point(-1, -1));
                colorImage = inputImage.MorphologyEx(MorphOp.Close, kernel, new Point(-1, -1), 1, BorderType.Default, new MCvScalar(1.0));
                pictureBoxOutput.Image = colorImage.Bitmap;
            }
        }

        private void gradienttoolStripMeniItem_Click(object sender, EventArgs e)
        {
            if (inputImage != null)
            {
                colorImage = new Image<Bgr, byte>(inputImage.Width, inputImage.Height);
                Mat kernel = CvInvoke.GetStructuringElement(ElementShape.Rectangle, new Size(3, 3), new Point(-1, -1));
                colorImage = inputImage.MorphologyEx(MorphOp.Gradient, kernel, new Point(-1, -1), 1, BorderType.Default, new MCvScalar(1.0));
                pictureBoxOutput.Image = colorImage.Bitmap;
            }
        }

        private void topHattoolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (inputImage != null)
            {
                colorImage = new Image<Bgr, byte>(inputImage.Width, inputImage.Height);
                Mat kernel = CvInvoke.GetStructuringElement(ElementShape.Rectangle, new Size(3, 3), new Point(-1, -1));
                colorImage = inputImage.MorphologyEx(MorphOp.Tophat, kernel, new Point(-1, -1), 1, BorderType.Default, new MCvScalar(1.0));
                pictureBoxOutput.Image = colorImage.Bitmap;
            }
        }

        private void blackHattoolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (inputImage != null)
            {
                colorImage = new Image<Bgr, byte>(inputImage.Width, inputImage.Height);
                Mat kernel = CvInvoke.GetStructuringElement(ElementShape.Rectangle, new Size(3, 3), new Point(-1, -1));
                colorImage = inputImage.MorphologyEx(MorphOp.Blackhat, kernel, new Point(-1, -1), 1, BorderType.Default, new MCvScalar(1.0));
                pictureBoxOutput.Image = colorImage.Bitmap;
            }
        }

        private void dilationtoolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (inputImage != null)
            {
                binaryImage = new Image<Gray, byte>(inputImage.Width, inputImage.Height);
                binaryImage = inputImage.Convert<Gray, byte>().ThresholdBinaryInv(new Gray(150), new Gray(255)).Dilate(1);
                pictureBoxOutput.Image = binaryImage.Bitmap;
            }
        }

        private void erosiontoolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (inputImage != null)
            {
                binaryImage = new Image<Gray, byte>(inputImage.Width, inputImage.Height);
                binaryImage = inputImage.Convert<Gray, byte>().ThresholdBinaryInv(new Gray(150), new Gray(255)).Erode(1);
                pictureBoxOutput.Image = binaryImage.Bitmap;
            }
        }

        private void openingtoolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (inputImage != null)
            {
                colorImage = new Image<Bgr, byte>(inputImage.Width, inputImage.Height);
                Mat kernel = CvInvoke.GetStructuringElement(ElementShape.Rectangle, new Size(3, 3), new Point(-1, -1));
                colorImage = inputImage.MorphologyEx(MorphOp.Open, kernel, new Point(-1, -1),
                                                    1, BorderType.Default, new MCvScalar(1.0));
                pictureBoxOutput.Image = colorImage.Bitmap;
            }
        }
    }
}
