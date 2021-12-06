//##############################################//
//                                              //
//      Module: 2021 MOD003263 TRI1 FO1CAM      //
//              Team name: CWA                  //
//          Control system: Github              //
//              Date:14/12/2021                 //
//##############################################//

using OpenCvSharp;
using OpenCvSharp.Extensions;
using System;
using System.IO;
using System.Drawing;
using System.Drawing.Imaging;
using System.Threading;
using System.Windows.Forms;
using System.Diagnostics;

//many thanks to //stackoverflow.com/questions/50812961/simple-camera-capture-in-winforms and lavahasif (@github) for the initial code
//added exception handling and adjusted image capture to handle 3 images and save to path
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
       
        /// <summary>
        /// Start camera for image capture
        /// </summary>

        private void CaptureCamera()
        {
            camera = new Thread(new ThreadStart(CaptureCameraCallback));
            camera.Start();
        }
        /// <summary>
        /// Capture an image when snapshot button actioned
        /// </summary>
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
                        if (pic_captureImage.Image != null)
                        {
                            pic_captureImage.Image.Dispose();
                        }
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

        /// <summary>
        /// Stop and start the camera if required via a button operation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Close the camera when exit form
        /// </summary>
        /// <param name="e"></param>
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
        /// <summary>
        /// Call save image method and close the camera
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
                Debug.WriteLine("Cannot take picture as the camera is not running");
            }
        }
        /// <summary>
        /// Save max of 3 images to designated file path to add to intervention list in form2
        /// </summary>
        public void saveImage()
        {
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
                }
                else if (!File.Exists(file2))
                {
                    snapshot.Save(string.Format(filePath + @"img2.jpg", Guid.NewGuid()), ImageFormat.Jpeg);
                }
                else if (!File.Exists(file3))
                {
                    snapshot.Save(string.Format(filePath + @"img3.jpg", Guid.NewGuid()), ImageFormat.Jpeg);
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
        }

        /// <summary>
        /// Close the camera capture form if no images are required
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
