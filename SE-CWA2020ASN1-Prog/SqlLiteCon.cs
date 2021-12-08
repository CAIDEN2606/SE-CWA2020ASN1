using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SE_CWA2020ASN1_Prog
{
    class SqlLiteCon : DbConection
    {
        Dictionary<string, string> m_properties;
        private SQLiteConnection connection;
        private string database;

        //Constructor
        public SqlLiteCon(Dictionary<string, string> properties)
        {
            m_properties = properties;
            initialize();
        }

        //Initialize values
        private void initialize()
        {
            database = m_properties["Database"];
            setConection();
        }

        private void setConection()
        {
            string connectionString;
            connectionString = "Data Source=" + database + "; Version = 3; New = True; Compress = True; ";
            connection = new SQLiteConnection(connectionString);

        }
        public bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public DataSet getDataSet(string sqlStatement)
        {
            DataSet dataSet;

            // create the object dataAdapter to manipulate a table from the database StudentDissertations specified by connectionToDB
            SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(sqlStatement, connection);
            // create the dataset
            dataSet = new System.Data.DataSet();
            dataAdapter.Fill(dataSet);
            //return the dataSet
            return dataSet;
        }

        public bool OpenConnection()
        {
            bool connected = false;
            try
            {
                connection.Open();
                connected = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cannot connect to database.  Contact administrator\n" + ex.Message);
            }
            return connected;
        }

        public DbDataReader Select(string query)
        {
            DbDataReader dr = null;

            if (null != connection)
            {
                //Create Command
                SQLiteCommand cmd = connection.CreateCommand();
                cmd.CommandText = query;
                //Create a data reader and Execute the command
                dr = cmd.ExecuteReader();
            }
            return dr;
        }
    }
}
