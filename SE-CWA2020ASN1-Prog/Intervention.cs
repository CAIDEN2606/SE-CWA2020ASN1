using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE_CWA2020ASN1_Prog
{
    class Intervention
    {
        public Intervention(String headingName, String subheadingName, String interventionType, String actionComments,
            String inspectionComments, String inspectionPicture)
        {
            m_headingName = headingName;
            m_subheadingName = subheadingName;
            m_interventionType = interventionType;
            m_actionComments = actionComments;
            m_inspectionComments = inspectionComments;
            m_inspectionPicture = inspectionPicture;

        }
            private string m_headingName;
            public string Heading_Name { get { return m_headingName; } set { m_headingName = value; } }

            private string m_subheadingName;
            public string Subheading_Name { get { return m_subheadingName; } set { m_subheadingName = value; } }

            private string m_interventionType;
            public string Intervention_Type { get { return m_interventionType; } set { m_interventionType = value; } }

            private string m_actionComments;
            public string Action_Comments { get { return m_actionComments; } set { m_actionComments = value; } }

            private string m_inspectionComments;
            public string Inspection_Comments { get { return m_inspectionComments; } set { m_inspectionComments = value; } }

            private string m_inspectionPicture;
            public string Inspection_Picture { get { return m_inspectionPicture; } set { m_inspectionPicture = value; } }

        
    }
}
