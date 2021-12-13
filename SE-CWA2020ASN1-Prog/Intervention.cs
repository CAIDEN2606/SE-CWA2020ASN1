//##############################################//
//                                              //
//      Module: 2021 MOD003263 TRI1 FO1CAM      //
//              Team name: CWA                  //
//          Control system: Github              //
//              Date:14/12/2021                 //
//##############################################//

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE_CWA2020ASN1_Prog
{

    // Gives names for anything included in the database 
    public class Intervention
    {
        private List<Image> m_pics;

        // All database item declarations
       public Intervention(int intervID, string subName, string type, string aComments, string iComments,Image img1, Image img2,Image img3)
        {
            m_intervID = intervID;
            m_subheadingName = subName;
            m_interventionType = type;
            m_actionComments = aComments;
            m_inspectionComments = iComments;
            m_img1 = img1;
            m_img2 = img2;
            m_img3 = img3;
            m_pics = new List<Image>();
        }

        //adding individual pics to a list
        public void addImage(Image img1,Image img2,Image img3)
        {
            m_pics.Add(m_img1);
            m_pics.Add(m_img2);
            m_pics.Add(m_img3);
        }

        // Following lines for returning all of these values
        private int m_intervID;
        public int Interv_ID { get { return m_intervID; } set { m_intervID = value; } }

        private string m_subheadingName;
        public string Subheading_Name { get { return m_subheadingName; } set { m_subheadingName = value; } }

        private string m_interventionType;
        public string Intervention_Type { get { return m_interventionType; } set { m_interventionType = value; } }

        private string m_actionComments;
        public string Action_Comments { get { return m_actionComments; } set { m_actionComments = value; } }

        private string m_inspectionComments;
        public string Inspection_Comments { get { return m_inspectionComments; } set { m_inspectionComments = value; } }

        private Image m_img1;
        public Image Img_1 { get { return m_img1; } set { m_img1 = value; } }
        private Image m_img2;
        public Image Img_2 { get { return m_img2; } set { m_img2 = value; } }
        private Image m_img3;
        public Image Img_3 { get { return m_img3; } set { m_img3 = value; } }

        /// <summary>
        /// Used to test if data in the list is correct
        /// </summary>
        /// <returns></returns>
        public string testString()
        {
            return "Intervention --> ID: " + m_intervID + "subheading: " + m_subheadingName + "Images --> " + m_img1 + ", " + m_img2 + ", " + m_img3 + ",  Intervention_Type" + m_interventionType + ", Action_Comments " + m_actionComments + ", Inspection_Comments" + m_inspectionComments;
        }
                
    }
}
