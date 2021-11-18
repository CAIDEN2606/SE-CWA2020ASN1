using OpenCvSharp;
using OpenCvSharp.Extensions;
using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
//many thanks to //stackoverflow.com/questions/50812961/simple-camera-capture-in-winforms and lavahasif (@github) for the code
namespace SE_CWA2020ASN1_Prog
{
    public partial class ImageCapture : Form
    {
        // Create class-level accesible variables
        VideoCapture capture;
        private Mat frame;
        private Bitmap image;
        private Thread camera;
        private bool isCameraRunning = false;
        public string filePath = Application.StartupPath + @"\inspectImages\";

        // Declare required methods
        private void CaptureCamera()
        {
            camera = new Thread(new ThreadStart(CaptureCameraCallback));
            camera.Start();
        }

        private void CaptureCameraCallback()
        {
            frame = new Mat();
            capture = new VideoCapture(0);
            capture.Open(0);

            if (capture.IsOpened())
            {
                while (isCameraRunning)
                {
                    try
                    {
                        capture.Read(frame);
                        image = BitmapConverter.ToBitmap(frame);
                        //System.ArgumentException' occurred in System.Drawing.dll

                        if (pic_captureImage.Image != null)
                        {
                            pic_captureImage.Image.Dispose();
                        }
                        
                        //System.ArgumentException: 'Parameter is not valid
                        pic_captureImage.Image = image;
                        
                    }catch (ArgumentException ex)
                    {
                        Debug.WriteLine("Error: " + ex.Message);
                    }
                }
            }
        }

        public ImageCapture()
        {
            InitializeComponent();
            CaptureCamera();
            btn_start.Text = "Stop";
            isCameraRunning = true;
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            if (btn_start.Text.Equals("Start"))
            {
                CaptureCamera();
                btn_start.Text = "Stop";
                isCameraRunning = true;
            }
            else
            {
                capture.Release();
                btn_start.Text = "Start";
                isCameraRunning = false;
            }
        }

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            try
            {
                capture.Release();
                camera.Abort();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (isCameraRunning)
            {
                saveImage();
                capture.Release();
                camera.Abort();
                this.Close();
            }
            else
            {
                Debug.WriteLine("Cannot take picture if the camera isn't capturing image!");
            }
        }
        public void saveImage()
        {
            
            //C:\Users\labuj\Documents\GitHub\SE-CWA2020ASN1\SE-CWA2020ASN1-Prog\bin\Debug
            try
            {
                Bitmap snapshot = new Bitmap(pic_captureImage.Image);
                string file1 = filePath + @"img1.jpg";
                string file2 = filePath + @"img2.jpg";
                string file3 = filePath + @"img3.jpg";
                //NEED TO CHECK IF EXISTS IMG1,2,3 
                if (!File.Exists(file1))
                {
                    snapshot.Save(string.Format(filePath + @"img1.jpg", Guid.NewGuid()), ImageFormat.Jpeg);
                    //System.Runtime.InteropServices.ExternalException: 'A generic error occurred in GDI+.'
                }
                else if (!File.Exists(file2))
                {
                    snapshot.Save(string.Format(filePath + @"img2.jpg", Guid.NewGuid()), ImageFormat.Jpeg);
                    //System.Runtime.InteropServices.ExternalException: 'A generic error occurred in GDI+.'
                }
                else if (!File.Exists(file3))
                {
                    snapshot.Save(string.Format(filePath + @"img3.jpg", Guid.NewGuid()), ImageFormat.Jpeg);
                    //System.Runtime.InteropServices.ExternalException: 'A generic error occurred in GDI+.'
                }
                else
                {
                    Debug.WriteLine("Max pics reached");
                    MessageBox.Show("Cannot take any more pictures, max has been reached.");
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine("An error occured when trying to save image: " + ex.Message);
            }
            //Max pics reached
            //Exception thrown: 'System.ArgumentException' in System.Drawing.dll
            //Error: Parameter is not valid.
            //not closing cleanly
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
