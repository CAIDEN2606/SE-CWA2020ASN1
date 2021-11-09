﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SE_CWA2020ASN1_Prog
{
    public partial class SafetyInspection1 : Form
    {
        public SafetyInspection1()
        {
            InitializeComponent();

            addComboData();

        }
        private List<Inspection> inspection = new List<Inspection>();
        private void addComboData()
        {
            cmbEnterSite.Items.Add("Weetabix Burton AP1 / Main");
            cmbEnterSite.Items.Add("Project Safety Audits");
            cmbEnterSite.Items.Add("Tate and Lyle");
            cmbEnterSite.Items.Add("Musk Design");
            cmbEnterSite.Items.Add("AkzoNobel Stowmarket");


            cmbEnterType.Items.Add("Installation");
            cmbEnterType.Items.Add("General maintenance");
            cmbEnterType.Items.Add("Building works");
            cmbEnterType.Items.Add("Repairing");

        }

        //created by anzors
        /// <summary>
        /// 
        /// </summary>
        public void getInspection()
        {
            string inspector = txt_name.Text;
            string site = cmbEnterSite.Text;
            var date = dateTimePicker1.Text;
            string job = txt_jobDescription.Text;
            string type = cmbEnterType.Text;
            string supervisor = txt_supervisor.Text;

            //Creating a list 
            List<String> inspectionList = new List<String>();

            inspectionList.Add(inspector);
            inspectionList.Add(site);
            inspectionList.Add(date);
            inspectionList.Add(job);
            inspectionList.Add(type);
            inspectionList.Add(supervisor);


            //printing in console
            foreach (String String in inspectionList)
            {
                Console.WriteLine(String.ToString());
            }

            //printing in console REFACTORING
            inspectionList.ForEach(String => Console.WriteLine(String + ", "));
        }


        public void createInspectionDetails()
        { 
            inspection = new List<Inspection>();
            Inspection insp = new Inspection();
            insp.Inspector_Name = txt_name.Text;
           
            insp.Site_Name = cmbEnterSite.Text;
            insp.Inspection_Date = dateTimePicker1.Value;
            insp.Job_Description = txt_jobDescription.Text;
            insp.Type = cmbEnterType.Text;
            insp.Inspector_Name = txt_supervisor.Text;
            
            inspection.Add(insp);

            //printing in console
            foreach (Inspection i in inspection)
            {
                Console.WriteLine(i.ToString());
            }
            //printing in console REFACTORING
            inspection.ForEach(Inspection => Console.WriteLine(inspection.ToString() + ", "));
        }

        /// <summary>
        /// Display inspections and some details in rich text box as required by project reqs.
        /// </summary>
        public void displayInspections()
        {




        }


        //###########################################################
        //                              buttons
        //
        //###########################################################

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void btn_Enter_Click(object sender, EventArgs e )
        {
            //anzors method using string list
            getInspection();
            //same method using inspection class list
            createInspectionDetails();
            List<object> form3 = new List<object>();
            InspectionSubmission2 frmInspectsub = new InspectionSubmission2(form3);
                this.Hide();
            frmInspectsub.ShowDialog();
                this.Show();
        }

        private void btn_about_Click(object sender, EventArgs e)
        {
            AboutMusk amusk = new AboutMusk();
            //this.Hide();
            amusk.ShowDialog();
            this.Show();
        }

        //dont do anything /////////////////////////////////////
        private void txt_name_TextChanged(object sender, EventArgs e)
        {
            //if (!System.Text.RegularExpressions.Regex.IsMatch(txt_name.Text, "^[a-zA-Z ]"))
            //{
            //    MessageBox.Show("This textbox accepts only alphabetical characters");
            //    txt_name.Text.Remove(txt_name.Text.Length - 1);
            //}
            //else
            if (txt_name.Text == "")
            {
                MessageBox.Show("Please, Enter your full name");
            }
        }

        private void txt_workArea_TextChanged(object sender, EventArgs e)
        {
           
            if (txt_name.Text == "")
            {
                MessageBox.Show("Please, Enter Work Area");
            }
        }

        private void txt_jobDescription_TextChanged(object sender, EventArgs e)
        {
            if (txt_name.Text == "")
            {
                MessageBox.Show("Please, Enter Job Description");
            }
        }

        private void txt_supervisor_TextChanged(object sender, EventArgs e)
        {
            //if (!System.Text.RegularExpressions.Regex.IsMatch(txt_name.Text, "^[a-zA-Z ]"))
            //{
            //    MessageBox.Show("This textbox accepts only alphabetical characters");
            //    txt_name.Text.Remove(txt_name.Text.Length - 1);
            //}
            //else
            if (txt_name.Text == "")
            {
                MessageBox.Show("Please, Enter your supervisor's name");
            }
        }

        private void SafetyInspection_Load(object sender, EventArgs e)
        {

        }

        
    }
}

