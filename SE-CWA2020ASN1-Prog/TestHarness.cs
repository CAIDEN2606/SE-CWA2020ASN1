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
    public partial class TestHarness : Form
    {
        public TestHarness()
        {
            InitializeComponent();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            //get each input and save to var
            var siteName = cmb_sitetName.Text;
            var date = dtp_dateTimePicker1;
            var comms = rtb_comments;
            var click = cbx_interventionType;
            var inspector = txt_inspectorName;
            //save to list
            List<Test> test = new List<Test>();
            //test.Add(siteName);
            //create tables using sqlite test
            //insert to tables
            //display in rich text box 

        }
    }

    internal class Test
    {
        private string m_siteName;
        public string Site_Name { get { return m_siteName; } set { m_siteName = value; } }
        private DateTime m_date;
        public DateTime Date { get { return m_date; } set { m_date = value; } }
        private string m_comments;
        public string Comments { get { return m_comments; } set { m_comments = value; } }
        private string m_interventionType;
        public string Intervention_Type { get { return m_interventionType; } set { m_interventionType = value; } }
        private string m_inspectorName;
        public string Inpector_Name { get { return m_inspectorName; } set { m_inspectorName = value; } }
    }
}
