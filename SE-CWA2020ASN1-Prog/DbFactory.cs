//##############################################//
//                                              //
//      Module: 2021 MOD003263 TRI1 FO1CAM      //
//              Team name: CWA                  //
//          Control system: Github              //
//              Date:14/12/2021                 //
//##############################################//

// Class purpose:
//
//
//


using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Diagnostics;
using System.IO;

namespace SE_CWA2020ASN1_Prog
{
    // This class will create instances for the database 
    public class DbFactory
    {
        private static DbConection m_instance = null;

        Dictionary<string, string> m_properties;
        private static string propfile = "properties.dat";

        private DbFactory()
        {
            m_properties = new Dictionary<string, string>();
        }
        public static DbConection instance()
        {
            if (null == m_instance)
            {
                DbFactory factory = new DbFactory();
                m_instance = factory.getConection();
            }
            return m_instance;
        }

        // Gets the connection
        private DbConection getConection()
        {
            DbConection connection = null;

            try
            {
                m_properties = getProperties();
                string provider = m_properties["Provider"];
                if (provider.Equals("SQLite"))
                    connection = new SqlLiteCon(m_properties);
                else
                {
                    // should throw unsupport exception here
                    throw new DBException("Not supported provider '" + provider + "'");
                }
            }
            catch (FileNotFoundException e)
            {
                Debug.WriteLine("Error file not found" + e.Message);
                connection = null;
                throw e;
            }
            catch (Exception e)
            {
                Debug.WriteLine("Property file parsing exception thrown : " + e.Message);
                connection = null;
                throw e;
            }
            return connection;
        }

        // Gets the properties file
        private Dictionary<string, string> getProperties()
        {
            string fileData = "";
            using (StreamReader sr = new StreamReader(propfile))
            {
                fileData = sr.ReadToEnd().Replace("\r", "");
            }
            Dictionary<string, string> properties = new Dictionary<string, string>();
            string[] kvp;
            string[] records = fileData.Split("\n".ToCharArray());
            foreach (string record in records)
            {
                kvp = record.Split("=".ToCharArray());
                properties.Add(kvp[0], kvp[1]);
            }
            return properties;
        }
    }
    class DBException : System.Exception
    {
        public DBException(string message) : base(message) { }
    }

    // Interface for connection & database items
    public interface DbConection
    {
        bool OpenConnection();

        bool CloseConnection();

        //Select statement
        DbDataReader Select(String query);

        DataSet getDataSet(string sqlStatement);

    }
}
