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

    }
}   
       

        
