using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Common;
using System.Diagnostics;
using System.IO;

namespace SE_CWA2020ASN1_Prog
{
    public class DbFactory
    {
        private static DbConnection m_instance = null;

        Dictionary<string, string> m_properties;
        private static string propfile = "properties.dat";

        private DbFactory()
        {
            m_properties = new Dictionary<string, string>();
        }
        public static DbConnection instance()
        {
            if (null == m_instance)
            {
                DbFactory factory = new DbFactory();
                m_instance = factory.getConnection();
            }
            return m_instance;
        }
        private DbConnection getConnection()
        {
            DbConnection connection = null;

            try
            {
                m_properties = getProperties();
                string provider = m_properties["Provider"];
                if (provider.Equals("SQLite"))
                    connection = new SQLiteCon(m_properties);
                //else if (provider.Equals("MySQL"))
                //    connection = new MySQLCon(m_properties);
                //else if (provider.Equals("Microsoft.ACE.OLEDB.16.0"))
                //    connection = new OleDatabaseConnection(m_properties);
                //else if (provider.Equals("Microsoft.ACE.OLEDB.12.0"))
                //    connection = new OleDatabaseConnection(m_properties);
                
                else
                {
                    // should throw unsupport exception here
                    throw new DbException("Not supported provider '" + provider + "'");
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
    class DbException : System.Exception
    {
        public DbException(string message) : base(message) { }
    }

    public interface DbConnection
    {
        bool OpenConnection();

        bool CloseConnection();


        //Insert statement
        int Insert();
        /*
        //Update statement
        public void Update();
        //Delete statement
        public void Delete();
        */


        //Select statement
        DbDataReader Select(String query);
        /*
        //Count statement
        public int Count();
        public void Backup();
        public void Restore();
       
        */

        DataSet getDataSet(string sqlStatement);

    }


}

