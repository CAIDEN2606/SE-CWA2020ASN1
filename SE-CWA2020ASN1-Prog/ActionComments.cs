﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;

namespace SE_CWA2020ASN1_Prog
{
    public partial class ActionComments : Form
    {
        public ActionComments()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Save comments, action comments and pics to sqlite intervention table
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_confirmInspection_Click(object sender, EventArgs e)
        {
            
            //1st text box
            var comments = rtx_comments.Text;
            //2nd text box
            var actionTaken = rtx_actionTaken.Text;
            //pics
            //pic_viewer.Image
            


            //Console.WriteLine(rtx_comments.Text); works
            SafetyInspection frmActComm = new SafetyInspection();
            this.Hide();
            frmActComm.ShowDialog();
            this.Show();


        }

        private void btn_takePic_Click(object sender, EventArgs e)
        {

        }

        private void btn_deletePic_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Exit page without saving data
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_backSubHead_Click(object sender, EventArgs e)
        {

            var answer = MessageBox.Show("This will exit without saving. Are you sure?",
                "Exit no save", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (answer == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                //nothing
            }
        }
    }
}
