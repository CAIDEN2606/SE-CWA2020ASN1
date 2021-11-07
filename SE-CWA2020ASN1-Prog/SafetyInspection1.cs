using System;
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

            cmbEnterSite.Items.Add("Weetabix Burton AP1 / Main");
            cmbEnterSite.Items.Add("Project Safety Audits");
            cmbEnterSite.Items.Add("Tate and Lyle");
            cmbEnterSite.Items.Add("Musk Design");
            cmbEnterSite.Items.Add("AkzoNobel Stowmarket");


            cmbEnterType.Items.Add("Instalation");
          
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void btn_Enter_Click(object sender, EventArgs e )
        {

            
            InspectionSubmission2 frmInspectsub = new InspectionSubmission2();
                this.Hide();
            frmInspectsub.ShowDialog();
                this.Show();
        }

        private void txt_name_TextChanged(object sender, EventArgs e)
        {
           
           if (!System.Text.RegularExpressions.Regex.IsMatch(txt_name.Text, "^[a-zA-Z ]"))
            {
                MessageBox.Show("This textbox accepts only alphabetical characters");
                txt_name.Text.Remove(txt_name.Text.Length -1);
            }
                else
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
            if (!System.Text.RegularExpressions.Regex.IsMatch(txt_name.Text, "^[a-zA-Z ]"))
            {
                MessageBox.Show("This textbox accepts only alphabetical characters");
                txt_name.Text.Remove(txt_name.Text.Length - 1);
            }
            else
            if (txt_name.Text == "")
            {
                MessageBox.Show("Please, Enter your supervisor's name");
            }
        }

        private void SafetyInspection_Load(object sender, EventArgs e)
        {

        }

        private void btn_about_Click(object sender, EventArgs e)
        {
            AboutMusk amusk = new AboutMusk();
            //this.Hide();
            amusk.ShowDialog();
            this.Show();
        }
    }
}

