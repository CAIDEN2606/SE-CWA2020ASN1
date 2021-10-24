using System;
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
    public partial class SafetyInspection : Form
    {
        public SafetyInspection()
        {
            InitializeComponent();

            cmb_siteName.Items.Add("Weetabix Burton AP1 / Main");
            cmb_siteName.Items.Add("Project Safety Audits");
            cmb_siteName.Items.Add("Tate and Lyle");
            cmb_siteName.Items.Add("Musk Design");
            cmb_siteName.Items.Add("AkzoNobel Stowmarket");


            cmb_EnterType.Items.Add("Instalation");
          
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Enter_Click(object sender, EventArgs e)
            {
                InspectionSubmission frmActComm = new InspectionSubmission();
                this.Hide();
                frmActComm.ShowDialog();
                this.Show();
            }

        private void txt_name_TextChanged(object sender, EventArgs e)
        {
           
           if (!System.Text.RegularExpressions.Regex.IsMatch(txt_inspectorName.Text, "^[a-zA-Z ]"))
            {
                MessageBox.Show("This textbox accepts only alphabetical characters");
                txt_inspectorName.Text.Remove(txt_inspectorName.Text.Length -1);
            }
                else
            if (txt_inspectorName.Text == "")
            {
                MessageBox.Show("Please, Enter your full name");
            }
        }

        private void txt_workArea_TextChanged(object sender, EventArgs e)
        {
           
            if (txt_inspectorName.Text == "")
            {
                MessageBox.Show("Please, Enter Work Area");
            }
        }

        private void txt_jobDescription_TextChanged(object sender, EventArgs e)
        {
            if (txt_inspectorName.Text == "")
            {
                MessageBox.Show("Please, Enter Job Description");
            }
        }

        private void txt_supervisor_TextChanged(object sender, EventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(txt_inspectorName.Text, "^[a-zA-Z ]"))
            {
                MessageBox.Show("This textbox accepts only alphabetical characters");
                txt_inspectorName.Text.Remove(txt_inspectorName.Text.Length - 1);
            }
            else
            if (txt_inspectorName.Text == "")
            {
                MessageBox.Show("Please, Enter your supervisor's name");
            }
        }

        private void SafetyInspection_Load(object sender, EventArgs e)
        {

        }

        private void btn_aboutMusk_Click(object sender, EventArgs e)
        {
            AboutMusk frmActComm = new AboutMusk();
            //this.Hide();
            frmActComm.ShowDialog();
            this.Show();
        }
    }
}

