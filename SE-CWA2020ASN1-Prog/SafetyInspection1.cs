using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
//using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SE_CWA2020ASN1_Prog
{
    public partial class SafetyInspection1 : Form
    {


        private IMethods im = new Methods();
        public SafetyInspection1()
        {
            InitializeComponent();
            
            addComboData();

        }
        
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

        
        public string m_site
        {
            get { return cmbEnterSite.Text; }
            set { cmbEnterSite.Text = value; }
        }
        public DateTime m_date
        {
            get { return dateTimePicker1.Value; }
            set { dateTimePicker1.Value = value; }
        }
        public string m_inspector
        {
            get { return txt_name.Text; }
            set { txt_name.Text = value; }
        }
        public string m_jobDesc
        {
            get { return txt_jobDescription.Text; }
            set { txt_jobDescription.Text = value; }
        } 
        public string m_jobType
        {
            get { return cmbEnterType.Text; }
            set { cmbEnterType.Text = value; }
        } 
        public string m_supervisor
        {
            get { return txt_supervisor.Text; }
            set { txt_supervisor.Text = value; }
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
            //create object of type inspection_area
            //pass to safetyInspection2
            Inspection insp = new Inspection(iName...);


            //im.createInspectionList();
            InspectionSubmission2 frmIS2 = new InspectionSubmission2(insp);
            frmIS2.ShowDialog();
                this.Show();
        }

        private void btn_about_Click(object sender, EventArgs e)
        {
            AboutMusk amusk = new AboutMusk();
            //this.Hide();
            amusk.ShowDialog();
            //this.Show();
        }

        //  doesn't do anything yet  /////////////////////////////////////
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

