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
using Emgu.Util;
using Emgu.CV.CvEnum;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace Thresholding
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Image<Bgr, byte> oriImage;
        Image<Gray, byte> grayImage, binaryImage;
        int a = 0, bs = 0, pa = 0;

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (oriImage == null)
            {
                MessageBox.Show("Please select an image");
                comboBox1.SelectedText = "";
                btnOpen.Focus();
                return;
            }

            if (txtThreS.Text == "" || a < 0)
            {
                txtThreS.Clear();
            }
            else
            {
                a = int.Parse(txtThreS.Text);
                if (comboBox1.SelectedIndex == 0)
                {
                    binaryImage = grayImage.ThresholdBinary(new
                    Gray(a), new Gray(255));
                    txtBSide.Text = "";
                    txtParam.Text = "";
                    comboBox2.SelectedText = "";

                }
                else if (comboBox1.SelectedIndex == 1)
                {
                    binaryImage =
                    grayImage.ThresholdBinaryInv(new Gray(a), new Gray(255));
                    txtBSide.Text = "";
                    txtParam.Text = "";
                    comboBox2.SelectedText = "";

                }
                else
                {
                    binaryImage = grayImage.ThresholdToZero(new
                    Gray(a));
                    comboBox2.SelectedText = "";
                }
                imgBinary.Image = binaryImage;
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //this.Close();
            main m=new main();
            m.Show();
            Visible = false;
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            if (opf.ShowDialog() == DialogResult.OK)
            {
                oriImage = new Image<Bgr, byte>(opf.FileName);
                imgInput.Image = oriImage;
                grayImage = oriImage.Convert<Gray, byte>();
                imgGray.Image = grayImage;
                imgBinary.Image = null;
                comboBox1.SelectedText = "";
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (oriImage == null)
            {
                MessageBox.Show("Please select an image");
                comboBox2.SelectedText = "";
                btnOpen.Focus();
                return;
            }

            if (txtBSide.Text == "" || txtParam.Text == "")
            {

            }
            else
            {
                bs = int.Parse(txtBSide.Text);
                pa = int.Parse(txtParam.Text);
                if (bs % 2 == 1 && bs > 2)
                {
                    if (comboBox2.SelectedIndex == 0)

                    {

                        binaryImage =
                        grayImage.ThresholdAdaptive(new Gray(256),
                        AdaptiveThresholdType.GaussianC,
                        ThresholdType.Binary, bs, new Gray(pa));
                        comboBox1.SelectedText = "";

                        txtThreS.Text = "";

                    }
                    else
                    {

                        binaryImage =
                        grayImage.ThresholdAdaptive(new Gray(256),
                        AdaptiveThresholdType.MeanC,
                        ThresholdType.Binary, bs, new Gray(pa));
                        txtThreS.Text = "";
                    }
                    imgBinary.Image = binaryImage;
                }
                else
                {
                    MessageBox.Show("The Number of Box Side Must Be higher than 2\nAnd Must Be Prime");
                    txtBSide.Clear();
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog savef = new SaveFileDialog();
            savef.Title = "Image Equalization and Filtering";
            savef.Filter = "Jpeg Files(*.jpg)|*.jpg|PNG Files(*.png) | *.png | Bitmap Files(*.bmp) | *.bmp";
            if (savef.ShowDialog() == DialogResult.OK)
            {
                imgBinary.Image.Save(savef.FileName);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            comboBox1_SelectedIndexChanged(txtThreS, e);
        }

        private void textParam_TextChanged(object sender, EventArgs e)
        {
            comboBox2_SelectedIndexChanged(txtParam, e);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
