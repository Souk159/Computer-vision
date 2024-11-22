using Emgu.CV.Structure;
using Emgu.CV;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Thresholding
{
    public partial class Form3 : Form
    {

        Image<Bgr, byte> inputImage;
        Image<Gray, byte> outputImage;
        Image<Gray, float> sobelImage, laplacianImage;

        public Form3()
        {
            InitializeComponent();
        }

        private void toolStripTextBox4_Click(object sender, EventArgs e)
        {
            if (inputImage != null)
            {
                outputImage = inputImage.Convert<Gray, byte>().Canny(150, 10);
                imgOutput.Image = outputImage.Bitmap;
            }
        }

        private void toolStripTextBox5_Click(object sender, EventArgs e)
        {
            if (inputImage != null)
            {
                sobelImage = inputImage.Convert<Gray, float>().Sobel(1, 1, 5);
                imgOutput.Image = sobelImage.Bitmap;
            }
        }

        private void toolStripTextBox6_Click(object sender, EventArgs e)
        {
            if (inputImage != null)
            {
                laplacianImage = inputImage.Convert<Gray, float>().Laplace(5);
                imgOutput.Image = laplacianImage.Bitmap;
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void toolStripTextBox2_Click(object sender, EventArgs e)
        {
            SaveFileDialog savef = new SaveFileDialog();
            savef.Title = "Save Edge Detection";
            savef.Filter = "Jpeg Files(*.jpg)|*.jpg|PNG Files(*.png) | *.png | Bitmap Files(*.bmp) | *.bmp";
            if (savef.ShowDialog() == DialogResult.OK)
            {
                imgOutput.Image.Save(savef.FileName);
            }
        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            if (opf.ShowDialog() == DialogResult.OK)
            {
                inputImage = new Image<Bgr, byte>(opf.FileName);
                imgInput.Image = inputImage.Bitmap;
            }

        }
    }
}
