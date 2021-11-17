using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE_CWA2020ASN1_Prog
{
    public class Intervention
    {
       public Intervention(string subName, string type, string aComments, string iComments,string iPicture)
        {
            m_subheadingName = subName;
            m_interventionType = type;
            m_actionComments = aComments;
            m_inspectionComments = iComments;
            m_inspectionPicture = iPicture;
        }
        public void makeInterv(string subName, string type, string aComments, string iComments)
        {
             

        }
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
        public string testString()
        {
            return "Intervention --> subheading: " + m_subheadingName;
        }
        
    }
}
