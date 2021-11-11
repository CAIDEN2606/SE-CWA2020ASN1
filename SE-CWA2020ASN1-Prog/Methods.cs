using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE_CWA2020ASN1_Prog
{

    interface IMethods
    {
        int createInspectionList();
        int createInspectionArea();
        int createInterventionList();
        void displayInspections();

    }


    class Methods : IMethods
    {

        //private SafetyInspection1 si1 = new SafetyInspection1();
        private InspectionSubmission2 is2;
        private List<Intervention> interv;
        private List<WorkArea> inspectArea;
        private List<Inspection> inspect = new List<Inspection>();
        
        

        /// <summary>
        /// Saving user input on form1 as an inspection obj and adding to inspection list 
        /// </summary>
        public int createInspectionList()
        {
            
            Inspection insp = new Inspection();
           // int num = 0;
           //     insp.Inspector_Name = si1.m_inspector; //always null
           //     insp.Site_Name = si1.m_site;
           //     insp.Inspection_Date = si1.m_date;
           //     insp.Job_Description = si1.m_jobDesc;
           //     insp.Type = si1.m_jobType;
           //     insp.Supervisor_Name = si1.m_supervisor;
           //     inspect.Add(insp);
           //if (inspect.Count()==0)
           // {
           //     Console.WriteLine("Inspection list is empty");
           // }
           // else
           // {
           //     foreach (Inspection i in inspect)
           //         Console.WriteLine(i);
           //     num++;
           // }
           return num;    //return inspect      
        }

        public int createInspectionArea()
        {
            int num = 0;


            return num;

        }


        public int createInterventionList()
        {
            int num = 0;


            return num;
            
        }

        ///// <summary>
        ///// Display list of inspections and some details in rich text box as required by project reqs.
        ///// </summary>
        public void displayInspections()
        {
        

        }
        

        
    }

    
}
