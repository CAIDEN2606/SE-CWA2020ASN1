using OpenCvSharp;
using OpenCvSharp.Extensions;
using System;
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
//many thanks to //stackoverflow.com/questions/50812961/simple-camera-capture-in-winforms and lavahasif (@github) for the code
namespace SE_CWA2020ASN1_Prog
{
    public partial class ImageCapture : Form
    {
        // Create class-level accesible variables
        VideoCapture capture;
        Mat frame;
        Bitmap image;
        private Thread camera;
        bool isCameraRunning = false;

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
                    }
                    catch (ArgumentException ex)
                    {
                        Console.WriteLine("Error: " + ex.Message);
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
                Console.WriteLine("Cannot take picture if the camera isn't capturing image!");
            }
        }
        public void saveImage()
        {
            Bitmap snapshot = new Bitmap(pic_captureImage.Image);
            //C:\Users\labuj\Documents\GitHub\SE-CWA2020ASN1\SE-CWA2020ASN1-Prog\bin\Debug
            try
            {
                //NEED TO CHECK IF EXISTS IMG1,2,3 
                snapshot.Save(string.Format(Application.StartupPath + @"\\img1.jpg", Guid.NewGuid()), ImageFormat.Jpeg);
                //System.Runtime.InteropServices.ExternalException: 'A generic error occurred in GDI+.'
                
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occured when trying to save image: " + ex.Message);
            }
            
        }
        
    }
}
