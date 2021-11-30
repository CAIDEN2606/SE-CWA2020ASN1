//##############################################//
//                                              //
//      Module: 2021 MOD003263 TRI1 FO1CAM      //
//              Team name: CWA                  //
//          Control system: Github              //
//              Date:14/12/2021                 //
//##############################################//
using SE_CWA2020ASN1_Prog.Properties;
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace SE_CWA2020ASN1_Prog
{
    public partial class Form1 : Form
    {
        
        private IMethods im = new Methods();
        string filePath = Application.StartupPath + @"\inspectImages\";
        
        

        public Form1()
        {
            InitializeComponent();
        }

        

        private void btn_exitSystem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
        //1st form
        private void btn_goSafetyInspection_Click(object sender, EventArgs e)
        {
            SafetyInspection1 frmSafetyInspection = new SafetyInspection1();
            this.Hide();
            frmSafetyInspection.ShowDialog();
            this.Show();
        }

        private void btn_takePic_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("start take picture process");
            string filePath = Path.Combine(Application.StartupPath + @"\inspectImages\");
            try
            {
                if (!Directory.Exists(filePath))
                {
                    Directory.CreateDirectory(filePath);
                    Debug.WriteLine("Image folder created: " + filePath);
                }
                else
                {
                    Debug.WriteLine("Folder already exists");
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine("An error occured: " + ex.Message);
            }

            ImageCapture imc = new ImageCapture();
            imc.ShowDialog();
            this.Show();
            Debug.WriteLine("end pic take process");
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("start delete process");
            try
            {
                //string filelst = "";
                string filelst = lst_pics.Items[lst_pics.SelectedIndex].ToString() + ".jpg";
                string file = filePath + filelst;
                //pic_intervPics.Image = Resources.musk_logo;
                FileInfo img1 = new FileInfo(file);
                img1.Delete();
                //extra dispose
                //pic_intervPics.Dispose();
                //im.deleteImg(file);

                Console.WriteLine(file);
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Error trying to delete file: " + ex.Message);
            }
            Console.WriteLine("delete finished");
        }

       

        private void lst_pics_SelectedIndexChanged(object sender, EventArgs e)
        {
            Debug.WriteLine("start select list process");
            Image image = null;
            string imageName = "";
            //name each selection in lst_pics with .jpg image 
            if (lst_pics.Items[lst_pics.SelectedIndex].ToString() == "img1")
            {
                imageName = "img1.jpg";
                
            }
            else if (lst_pics.Items[lst_pics.SelectedIndex].ToString() == "img2")
            {
                imageName = "img2.jpg";
                
            }
            else if (lst_pics.Items[lst_pics.SelectedIndex].ToString() == "img3")
            {
                imageName = "img3.jpg";
               
            }
            //set image to file path of selected item above
            //stackoverflow.com/questions/6576341/open-image-from-file-then-release-lock
            try
            {
                using (var bmpTemp = new Bitmap(filePath + @imageName))
                {
                    image = new Bitmap(bmpTemp);
                }
                //image = Image.FromFile(filePath + @imageName);
                //image = new Bitmap(filePath + @imageName);
            }catch(Exception ex)
            {
                Debug.WriteLine("File not found: " + ex.Message);
            }

            //display image selected in pic viewer if exists, if not display default logo
            if (image == null)
            {
                pic_intervPics.Image = Resources.musk_logo;
            }
            else
            {
                pic_intervPics.Image = image;

            }


            //if selected from list display to fill pic viewer
            pic_intervPics.SizeMode = PictureBoxSizeMode.StretchImage;
            //image.Dispose(); //crashes the program to form1
            Debug.WriteLine("end select list process");
        }
    }
}
