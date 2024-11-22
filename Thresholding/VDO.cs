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

using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.CvEnum;

namespace Thresholding
{
    public partial class VDO : Form
    {

        Image<Gray, byte> grayVDO, binaryVDO, CannyVDO,DilationVDO, ErosionVDO;
        VideoCapture capture;
        Image<Gray, float> SobelVDO;
        Mat frame; bool turn_on;

        public VDO()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            turn_on = true;
            ImgCapture.Image = null;
            Application.Idle += Application_Idle; 
        }

        private void Application_Idle6(object sender, EventArgs e)
        {
            ErosionVDO = frame.ToImage<Gray,byte>().ThresholdBinaryInv(new Gray(150), new Gray(255)).Erode(1);
            imgBoxVDO.Image = ErosionVDO;
        }

        private void Application_Idle5(object sender, EventArgs e)
        {
            DilationVDO = frame.ToImage<Gray,byte>().ThresholdBinaryInv(new Gray(150), new Gray(255)).Dilate(1);
            imgBoxVDO.Image = DilationVDO;
        }

        private void Application_Idle4(object sender, EventArgs e)
        {
            SobelVDO = frame.ToImage<Gray, float>().Sobel(1, 1, 5);
            imgBoxVDO.Image = SobelVDO;
        }
    

        private void Application_Idle3(object sender, EventArgs e)
        {
            CannyVDO = frame.ToImage<Gray, byte>().Canny(150,10);
            imgBoxVDO.Image = CannyVDO;
        }
    

        private void Application_Idle2(object sender, EventArgs e)
        {
            grayVDO = frame.ToImage<Gray, byte>();
            binaryVDO = grayVDO.ThresholdBinary(new Gray(150), new Gray(255));
            imgBoxVDO.Image = binaryVDO;
        }

        private void Application_Idle1(object sender, EventArgs e)
        {
            grayVDO = frame.ToImage<Gray, byte>();
            imgBoxVDO.Image = grayVDO;
        }

        private void Application_Idle(object sender, EventArgs e)
        {
            if (capture != null)
            {
                capture.Retrieve(frame);
                imgBoxVDO.Image = frame.ToImage<Bgr, byte>();
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            turn_on = false;
            Application.Idle -= Application_Idle;
            imgBoxVDO.Image = null;
        }

        private void btnGray_Click(object sender, EventArgs e)
        {
            if (turn_on == true)
                Application.Idle += Application_Idle1;
            else
                MessageBox.Show("Please Start the WebCam");
        }

        private void btnBinary_Click(object sender, EventArgs e)
        {
            if (turn_on == true)
                Application.Idle += Application_Idle2;
            else
                MessageBox.Show("Please Start the WebCam");
        }

        private void btnCapture_Click(object sender, EventArgs e)
        {
            ImgCapture.Image = imgBoxVDO.Image;
        }

        private void Sobel_Click(object sender, EventArgs e)
        {
            if (turn_on == true)
                Application.Idle += Application_Idle4;
            else
                MessageBox.Show("Please Start the WebCam");
        }

        private void Erotion_Click(object sender, EventArgs e)
        {
            if (turn_on == true)
                Application.Idle += Application_Idle6;
            else
                MessageBox.Show("Please Start the WebCam");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog svf = new SaveFileDialog();
            svf.Title = "Save Capture Image";
            svf.DefaultExt = "*.Jpg";
            svf.Filter = "Jpeg Files (*.jpg)|*.jpg";
            if (svf.ShowDialog() == DialogResult.OK)
            {
                ImgCapture.Image.Save(svf.FileName);
            }
        }

        private void Dilation_Click(object sender, EventArgs e)
        {
            if (turn_on == true)
                Application.Idle += Application_Idle5;
            else
                MessageBox.Show("Please Start the WebCam");
        }

        private void Canny_Click(object sender, EventArgs e)
        {
            if (turn_on == true)
                Application.Idle += Application_Idle3;
            else
                MessageBox.Show("Please Start the WebCam");
        }

        private void VDO_Load(object sender, EventArgs e)
        {

            turn_on = false;
            capture = new VideoCapture(0);
            frame = new Mat();

        }
    }
}
