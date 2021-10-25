using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        // Could just have a set of static helper methods rather than a singleton!
        //getting data from database file adding to list to display in win form display window
        //public List<Inspection> getInspection()
        //{
        //    List<Inspection> inspection = new List<Inspection>();

        //    DbConnection con = DbFactory.instance();
        //    if (con.OpenConnection())
        //    {
        //        DbDataReader dr = con.Select("SELECT CUST_ID, cust_name, cust_address, cust_city FROM customers;");

        //        //Read the data and store them in the list
        //        while (dr.Read())
        //        {
        //            //creating object
        //            Inspection inspect = new Inspection();
        //            inspect.Site_Name = dr.GetString(0);
        //            inspect.Inspection_Date = dr.GetDateTime(1);
        //            inspect.Inspector_Name = dr.GetString(2);
        //            inspect.Job_Description = dr.GetString(3);
        //            inspect.Supervisor_Name = dr.GetString(4);
        //            inspect.Type = dr.GetString(5);
        //            // etc.....

        //            //adding object
        //            inspection.Add(inspect);
        //        }

        //        //close Data Reader
        //        dr.Close();
        //        con.CloseConnection();
        //    }

        //    //return object to display
        //    return inspection;
        //}

        
        //read data from win forms fields and store in sqlite tables
        //seperate methods for each class
        //should save each form into dictionary for each form and extract data via tag @
        
        
        static int saveInspection(Inspection insp)
        {
            int affected = 0;

            // create an insert statement for your class

            // send insert statement down to connection

            return affected;
        }
        
        static int saveInspectionArea(InspectionArea inspa)
        {
            int affected = 0;

            // create an insert statement for your class

            // send insert statement down to connection

            return affected;
        }

        static int insertIntervention(Intervention intv)
        {
            int affected = 0;

            // create an insert statement for your class

            // send insert statement down to connection

            return affected;
        }

    }
}
