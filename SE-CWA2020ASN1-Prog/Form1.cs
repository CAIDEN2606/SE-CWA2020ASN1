//##############################################//
//                                              //
//      Module: 2021 MOD003263 TRI1 FO1CAM      //
//              Team name: CWA                  //
//          Control system: Github              //
//              Date:14/12/2021                 //
//##############################################//

// Class purpose:
// Login page
// Exit the program
// Methods are displayed in the order as they appear on the form to help with class navigation
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
        /// <summary>
        /// Exit the programm
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_exitSystem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        /// <summary>
        /// This button allows us to continiue
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_goSafetyInspection_Click(object sender, EventArgs e)
        {
            SafetyInspection1 frmSafetyInspection = new SafetyInspection1();
            this.Hide();
            frmSafetyInspection.ShowDialog();
            this.Show();
        }
    }
}   
       

        
