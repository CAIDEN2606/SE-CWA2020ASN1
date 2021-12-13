//##############################################//
//                                              //
//      Module: 2021 MOD003263 TRI1 FO1CAM      //
//              Team name: CWA                  //
//          Control system: Github              //
//              Date:14/12/2021                 //
//##############################################//

// Class purpose:
// Layer class between SQLite and DBFactory
// Contains sql insert and fetch statements 
//

//using InspectionTesting;
using System;
using System.Collections.Generic;
using System.Data.Common;

namespace SE_CWA2020ASN1_Prog
{
    public class BusinessMetaLayer
    {
        static private BusinessMetaLayer m_instance = null;
        Inspection inspection;
        private BusinessMetaLayer() { }

        static public BusinessMetaLayer instance()
        {
            if (null == m_instance)
            {
                m_instance = new BusinessMetaLayer();
            }
            return m_instance;
        }

        
        public List<Inspection> getInspections()
        {
            List<Inspection> inspections = new List<Inspection>();

            DbConection con = DbFactory.instance();
            if (con.OpenConnection())
            {
                DbDataReader dr = con.Select("SELECT siteName, jobType, jobDescription, inspectorName, inspectionDate, supervisorName, workAreaName FROM Inspection;;");

                //Read the data and store them in the list
                while (dr.Read())
                {
                    inspection = new Inspection();
                    inspection.Site_Name = dr.GetString(0);
                    inspection.Type = dr.GetString(1);
                    inspection.Job_Description = dr.GetString(2);
                    inspection.Inspector_Name = dr.GetString(3);
                    long datel = dr.GetInt64(4);
                    DateTime date = new DateTime(datel);
                    inspection.Inspection_Date = date;
                    inspection.Supervisor_Name = dr.GetString(5);
                    inspection.Work_Area_Name = dr.GetString(6);
                    inspections.Add(inspection);
                }

                //close Data Reader
                dr.Close();
                con.CloseConnection();
            }

            return inspections;
        }

        public void Insert()
        {

            string query = "INSERT INTO Inspection (siteName, inspectionDate) VALUES('John Smith', '33')";
            DbConection con = DbFactory.instance();

            //open connection
            if (con.OpenConnection())
            {
               

            }
        }
    }
}
