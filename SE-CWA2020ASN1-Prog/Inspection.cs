using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE_CWA2020ASN1_Prog
{
    public class Inspection
    {

        private string m_siteName;
        public string Site_Name { get { return m_siteName; } set { m_siteName = value; } }

        private string m_type;
        public string Type { get { return m_type; } set { m_type = value; } }

        private string m_jobDescription;
        public string Job_Description { get { return m_jobDescription; } set { m_jobDescription = value; } }

        private string m_inspectorName;
        public string Inspector_Name { get { return m_inspectorName; } set { m_inspectorName = value; } }

        private DateTime m_inspectionDate;
        public DateTime Inspection_Date { get { return m_inspectionDate; } set { m_inspectionDate = value; } }


        private string m_supervisorName;
        public string Supervisor_Name { get { return m_supervisorName; } set { m_supervisorName = value; } }
    }

    public class InspectionArea : Inspection
    {
        private string m_workareaName;
        public string Work_Area { get { return m_workareaName; } set { m_workareaName = value; } }

        private string m_inspectionSummary;
        public string Inspection_Summary { get { return m_inspectionSummary; } set { m_inspectionSummary = value; } }



        public class Intervention
        {
            private string m_subheadingName;
            public string Subheading_Name { get { return m_subheadingName; } set { m_subheadingName = value; } }

            private string m_interventionType;
            public string Intervention_Type { get { return m_interventionType; } set { m_interventionType = value; } }

            private string m_actionComments;
            public string Action_Comments { get { return m_actionComments; } set { m_actionComments = value; } }

            private string m_inspectionComments;
            public string Inspection_Comments { get { return m_inspectionComments; } set { m_inspectionComments = value; } }

            //private string m_inspectionPicture;
            //public string Inspection_Picture { get { return m_inspectionPicture; } set { m_inspectionPicture = value; } }

        }
    }

}