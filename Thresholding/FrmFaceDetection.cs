using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

using Emgu.CV;
using Emgu.CV.Structure;


namespace Thresholding
{
    public partial class FrmFaceDetection : Form
    {

        Image<Bgr, byte> imgInput;

        Mat frame; bool turn_on;
        VideoCapture capture;

        public FrmFaceDetection()
        {
            InitializeComponent();
        }

        private void FrmFaceDetection_Load(object sender, EventArgs e)
        {
            turn_on = false;
            capture = new VideoCapture(0);
            frame = new Mat();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {

            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                if (dialog.ShowDialog() == DialogResult.OK)
                {

                    imgInput = new Image<Bgr, byte>(dialog.FileName);
                    pictureBox1.Image = imgInput.Bitmap;
                }
                else
                {
                    throw new Exception("No file selected");
                }

            }
            catch (Exception ex) 
            {
            
                MessageBox.Show(ex.Message);
            }
        }

        private void detectFaceHaarToolStripMenuItem_Click(object sender, EventArgs e)
        {

            try
            {
                if (imgInput == null)
                {
                    throw new Exception("Please select and image");

                }
                DetectFaceHaar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void DetectFaceHaar()
        {

            /*try
            {

                string facePath = Path.GetFullPath(@"../../data/haarcascade_frontalface_default.xml");
                CascadeClassifier classifier = new CascadeClassifier(facePath);
                var imgGray = imgInput.Convert<Gray, byte>().Clone();
                Rectangle [] faces = classifier.DetectMultiScale(imgGray,1.1,4);
                foreach (var face in faces)
                {
                    imgInput.Draw(face, new Bgr(0, 0, 255), 15);
                }
                pictureBox1.Image = imgInput.Bitmap;
                //MessageBox.Show("ນີ້ແມ່ນຄົນຫລາຍໃຈ");

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }*/
            //string facepath = "haarcascade_frontalcatface.xml"; 
            //string facepath = "haarcascade_frontalface_default.xml"; 
            //string facepath = "haarcascade_fullbody.xml"; 
            string facepath = Path.GetFullPath(@"../../data/haarcascade_frontalface_alt2.xml");
            string eyepath = Path.GetFullPath(@"../../data/haarcascade_eye.xml");

            int count;

            CascadeClassifier classifierFace = new CascadeClassifier(facepath);
            CascadeClassifier classifierEye = new CascadeClassifier(eyepath);

            var grayImage = imgInput.Convert<Gray, byte>().Clone();
            Rectangle[] faces = classifierFace.DetectMultiScale(grayImage, 1.1, 11);
            count = faces.Length;
            foreach (var face in faces)
            {
                imgInput.Draw(face, new Bgr(0, 0, 255), 3);
                grayImage.ROI = face;
                Rectangle[] eyes = classifierEye.DetectMultiScale(grayImage, 1.1, 7);
                foreach (var eye in eyes)
                {
                    var e = eye;
                    e.X += face.X;
                    e.Y += face.Y;
                    imgInput.Draw(e, new Bgr(0, 255, 0), 3);
                }
            }
            pictureBox1.Image = imgInput.Bitmap;

            if (faces.Length == 0)
                MessageBox.Show("There are no People");
            else if (faces.Length == 1)
                MessageBox.Show("There is only" + count + " Person");
            else
                MessageBox.Show("There are " + count + " People");

        }

        public void detectfaceLBP()
        {
            string facepath = Path.GetFullPath(@"../../data/lbpcascade_frontalface.xml");
            CascadeClassifier classifierFace = new CascadeClassifier(facepath);
            var grayImage = imgInput.Convert<Gray, byte>().Clone();
            Rectangle[] faces = classifierFace.DetectMultiScale(grayImage, 1.1, 7);
            foreach (var face in faces)
            {
                imgInput.Draw(face, new Bgr(255, 0, 0), 3);
            }
            pictureBox1.Image = imgInput.Bitmap;
        }

        private void detectFaceLBPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (imgInput == null) return;
            detectfaceLBP();

        }

        private void startToolStripMenuItem_Click(object sender, EventArgs e)
        {
            turn_on = true;
            //ImgCapture.Image = null;
            Application.Idle += Application_Idle;
        }

        private void Application_Idle(object sender, EventArgs e)
        {
            if (capture != null)
            {
                capture.Retrieve(frame);
                pictureBox1.Image = frame.ToImage<Bgr, byte>().Bitmap;
            }
        }
    }
}
