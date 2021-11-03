using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

       
        /// <summary>
        /// save all inspection details of classes to db incl sqlite
        /// </summary>
        /// <param name="insp"></param>
        /// <returns></returns>
        public int Insert()
        {
            int affected = 0;

            // create an insert statement for your class

            // send insert statement down to connection

            return affected;
        }
        public int InsertInspectionData(SQLiteConnection con)
        {
            int ans = 0;

            SQLiteCommand sqlite_cmd;
            sqlite_cmd = con.CreateCommand();
            
            sqlite_cmd.CommandText = "INSERT INTO Inspection (SiteName, JobDescription,InspectorName,InspectionDate," +
                "SupervisorName) VALUES(@inspectName,@site,@wkarea, @date,@job,@supervisor);";
            //sqlite_cmd.Parameters.AddWithValue("@inspectName",txt_name.Text);
            //sqlite_cmd.Parameters.AddWithValue("@site", cmbEnterSite.Text);
            //sqlite_cmd.Parameters.AddWithValue("@wkarea", txt_workArea.Text);
            //sqlite_cmd.Parameters.AddWithValue("@date", dateTimePicker1.Text);
            //sqlite_cmd.Parameters.AddWithValue("@job", txt_jobDescription.Text);
            //sqlite_cmd.Parameters.AddWithValue("@supervisor", txt_supervisor.Text);

            sqlite_cmd.ExecuteNonQuery();
            ans++;
            return ans;
        }

        
        



    }
}
