using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE_CWA2020ASN1_Prog
{

    interface IMethods
    {
        void GetInspections();
        void GetInspectionArea();
        void GetIntervention();


    }


    class Methods
    {
        //adding user input to lists
        public List<Inspection> GetInspection()
        {
            List<Inspection> inspection = new List<Inspection>();
            //inspection.Add(0, Site_Name);
            //inspection.Add(1, Type);
            //inspection.Add(2, Job_Description);
            //inspection.Add(3, Inspector_Name);
            //inspection.Add(4, Inspection_Date);
            //inspection.Add(5, Supervisor_Name);


            return inspection;

        }

        public List<InspectionArea> GetInspectionArea()
        {
            List<InspectionArea> inspectionArea = new List<InspectionArea>();
            //inspectionArea.Add(0, Work_Area);
            //inspectionArea.Add(1, Inspection_Summary);
            

            return inspectionArea;

        }

        public List<Intervention> GetIntervention()
        {
            List<Intervention> intervention = new List<Intervention>();
            //intervention.Add(0, Heading_Name);
            //intervention.Add(1, Subheading_Name);
            //intervention.Add(2, Intervention_Type);
            //intervention.Add(3, Action_Comments);
            //intervention.Add(4, Inspection_Comments);
            //intervention.Add(5, Inspection_Picture);


            return intervention;

        }





    }

    
}
