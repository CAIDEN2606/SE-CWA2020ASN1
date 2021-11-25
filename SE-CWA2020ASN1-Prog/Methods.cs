using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SE_CWA2020ASN1_Prog
{

    interface IMethods
    {
        
        string displayInterventions(Intervention interv);
        Boolean isEmptyTextFieldForm1(string siteName, string inspectorName, string jobType, string jobDesc, string supervisor);
        Boolean isEmptyTextFieldForm2(string workArea,string intDesc, string intervType);
    }


    class Methods : IMethods
    {

        
        ///// <summary>
        ///// Display list of inspections and some details in rich text box as required by project reqs.
        ///// </summary>
        public string displayInterventions(Intervention interv)
        {
            string shead = interv.Subheading_Name;
            return shead;

        }
        
        public Boolean isEmptyTextFieldForm1(string siteName, string inspectorName, string jobType, string jobDesc, string supervisor)
        {
        Boolean ans = true;
            if (siteName == "")
            {
                MessageBox.Show("Please, enter the site name");
                    
            }
            if (inspectorName == "")
            {
                MessageBox.Show("Please, enter your name");
                    
            }
            if (jobType == "")
            {
                MessageBox.Show("Please, enter the job type");

            }
            if (jobDesc == "")
            {
                MessageBox.Show("Please, enter a job description");

            }
                
                
            if (supervisor == "")
            {
                MessageBox.Show("Please, enter the supervisor's name");
                    
            }
            else
            {
                ans = false;
            }
            
            return ans;
        }
        public Boolean isEmptyTextFieldForm2(string workArea,string intDesc,string intervType)
        {
            Boolean ans = true;

                if (workArea == "")
                {
                    MessageBox.Show("Please, enter the work area");

                }
                if (intDesc == "")
                {
                    MessageBox.Show("Please, select an intervention");
                    
                }
                if (intervType == "")
                {
                    MessageBox.Show("Please, select an intervention type");
                    
                }
                else
                {
                    ans = false;
                }
            
            return ans;
        }




    }

    
}
