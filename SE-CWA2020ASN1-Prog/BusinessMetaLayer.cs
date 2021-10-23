using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Common;
using System.Data.SQLite;

namespace SE_CWA2020ASN1_Prog
{
    public class BusinessMetaLayer
    {
        static private BusinessMetaLayer m_instance = null;
        private BusinessMetaLayer() { }
        static public BusinessMetaLayer instance()
        {
            if (null == m_instance)
            {
                m_instance = new BusinessMetaLayer();
            }
            return m_instance;
        }

        //method to get form data and save to sqlite
        public int saveInspection(Inspection i)
        {
            int num = 0;
            // create an insert statement for your class

            // send insert statement down to connection



            return num;
        }

        //method to list details of inspection before submit 
        //need datareader to read from sqlite
        //gestring and save to list
        //read to display in a messagebox
        public List<Inspection> getInspectionDetails()
        {
            List<Inspection> inspection = new List<Inspection>();
            DbConnection con = DbFactory.instance();
            if (con.OpenConnection())
            {
                DbDataReader dr = con.Select("SELECT Inspection.workAreaName, Intervention.subHeading FROM InspectionArea AND Intervention;");

                //Read the data and store them in the list
                while (dr.Read())
                {
                    //creating object
                    Inspection inspect = new Inspection();
                    inspect.Work_Area = dr.GetString(0);
                    inspect.Subheading_Name = dr.GetString(1);
                    //inspect.Address = dr.GetString(2);
                    //inspect.City = dr.GetString(3);
                    // etc.....
                    
                    //adding object
                    inspection.Add(inspect);
                }

                //close Data Reader
                dr.Close();
                con.CloseConnection();
            }

            //return object to display



            return inspection;
        }
    }
}
