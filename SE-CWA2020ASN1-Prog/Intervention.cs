using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE_CWA2020ASN1_Prog
{
    class Intervention
    {
        private List<Intervention> interv;

        public Intervention(String hName, String subName, String type, String aComments,
            String iComments, Image iPicture)

        {
            m_headingName = hName;
            m_subheadingName = subName;
            m_interventionType = type;
            m_actionComments = aComments;
            m_inspectionComments = iComments;
            m_inspectionPicture = iPicture;

        }


        //public void makeIntervention(String hName, String subName, String type, String aComments,
        //    String iComments, Image iPicture, Intervention intervention)
        //{
        //    intervention.Add(hName,subName,type,aComments,iComments,iPicture);
        //}

        //private void Add(string hName, string subName, string type, string aComments, string iComments, Image iPicture)
        //{

        //    throw new NotImplementedException();
        //}

        private String m_headingName;
        public String Heading_Name { get { return m_headingName; } set { m_headingName = value; } }

        private String m_subheadingName;
        public String Subheading_Name { get { return m_subheadingName; } set { m_subheadingName = value; } }

        private String m_interventionType;
        public String Intervention_Type { get { return m_interventionType; } set { m_interventionType = value; } }

        private String m_actionComments;
        public String Action_Comments { get { return m_actionComments; } set { m_actionComments = value; } }

        private String m_inspectionComments;
        public String Inspection_Comments { get { return m_inspectionComments; } set { m_inspectionComments = value; } }

        private Image m_inspectionPicture;
        public Image Inspection_Picture { get { return m_inspectionPicture; } set { m_inspectionPicture = value; } }

        
    }
}
