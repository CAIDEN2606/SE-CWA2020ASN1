using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Common;
using System.Data.SQLite;
using System.Windows.Forms;
using System.Diagnostics;
//taken from https://www.codeguru.com/dotnet/using-sqlite-in-a-c-application/

namespace SE_CWA2020ASN1_Prog
{
    class SQLiteCon : DbConnection
    {
        Dictionary<string, string> m_properties;
        private SQLiteConnection connection;
        private string database;

        //Constructor
        public SQLiteCon(Dictionary<string, string> properties)
        {
            m_properties = properties;
            initialize();
        }

        //Initialize values
        private void initialize()
        {
            database = m_properties["Database"];
            createConnection();
        }

        //private void setConnection()
        static SQLiteConnection createConnection()
        {
            SQLiteConnection sqlite_conn;
            // Create a new database connection:
            sqlite_conn = new SQLiteConnection("Data Source=database.db; Version = 3; New = True; Compress = True; ");
            // Open the connection:
            try
            {
                sqlite_conn.Open();
            }
            catch (Exception ex)
            {
                Debug.WriteLine("No connection exception thrown : " + ex.Message);
                sqlite_conn = null;
                throw ex;
            }
            return sqlite_conn;
        }

        public bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cannot close the database. Contact administer\n" + ex.Message);
            }
            return false;

        }

        public bool OpenConnection()
        {
            bool connected = false;

            try
            {
                connection.Open();
                connected = true;
                //sqlite_conn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cannot connect to database. Contact administer\n" + ex.Message);
            }
            return connected;
            throw new NotImplementedException();
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

        public DbDataReader Select(string query)
        {
            DbDataReader dr = null;
            if (null != connection)
            {
                SQLiteCommand sqlite_cmd;
                sqlite_cmd = connection.CreateCommand();
                sqlite_cmd.CommandText = query;

                dr = sqlite_cmd.ExecuteReader();
            }
            return dr;
        }

        public int Insert()
        {
            throw new NotImplementedException();
        }


    }


    /////////////////////////////////////////////
    ///
    ///
    //creating a tester prior to implementing above  
    public class Tester
    {

        public static void SQLiteTest()
        {
            SQLiteConnection sqlite_conn;
            sqlite_conn = CreateConnection();
            CreateTables(sqlite_conn);
            InsertData(sqlite_conn);
            ReadData(sqlite_conn);
        }

        static SQLiteConnection CreateConnection()
        {

            SQLiteConnection sqlite_conn;
            // Create a new database connection:
            sqlite_conn = new SQLiteConnection("Data Source=database.db; Version = 3; New = True; Compress = True; ");
            // Open the connection:
            try
            {
                sqlite_conn.Open();
            }
            catch (Exception ex)
            {
                Debug.WriteLine("No connection exception thrown : " + ex.Message);
                sqlite_conn = null;
                throw ex;
            }
            return sqlite_conn;
        }

        static void CreateTables(SQLiteConnection conn)
        {
            //if not exist create table

            SQLiteCommand sqlite_cmd;
            string Createsql = "CREATE TABLE Inspection (SiteName VARCHAR(20), InspectionDate DATE, SuperVisorName VARCHAR(20), Type VARCHAR(30), JobDescription VARCHAR(30), InspectorName VARCHAR(20))";
            string Createsql1 = "CREATE TABLE InspectionArea (WorkAreaName VARCHAR(20), InspectionSummary VARCHAR(200), InterventionsTotal INT)";
            string Createsql2 = "CREATE TABLE Intervention (Heading VARCHAR(50), SubHeading VARCHAR(50), InterventionType VARCHAR(50), InterventionSum INT, InspectorActions VARCHAR(200), InspectorComments VARCHAR(200)";

            sqlite_cmd = conn.CreateCommand();
            sqlite_cmd.CommandText = Createsql;
            sqlite_cmd.ExecuteNonQuery();
            sqlite_cmd.CommandText = Createsql1;
            sqlite_cmd.ExecuteNonQuery();
            sqlite_cmd.CommandText = Createsql2;
            sqlite_cmd.ExecuteNonQuery();
        }

        static void InsertData(SQLiteConnection conn)
        {
           
            
            SQLiteCommand sqlite_cmd;
            string ins1 = "INSERT INTO Inspection (SiteName, InspectionDate, SuperVisorName, Type, JobDescription, InspectorName)" +
                "VALUES('" + cmb_siteName + "','" + DateTimePicker1 + "','" + txt_supervisor + "','" + cmb_EnterType + "','" + txt_jobDescription + "','" + txt_inspectorName + "')";
            string ins2 = "INSERT INTO InspectionArea (WorkAreaName, InspectionSummary, InterventionsTotal)" +
                "VALUES('" + rtb_WorkArea + "','" + rtb_InspectionComments + "','" + rtb_Total + "')";
            string ins3 = "INSERT INTO Intervention (Heading, SubHeading, InterventionType, InterventionSum, InspectorActions, InspectorComments)" +
                " VALUES('" + +"','" + +"','" + +"','" + +"','" + rtx_ActionTaken + "','" + rtx_comments + "')";

            sqlite_cmd = conn.CreateCommand();
            sqlite_cmd.CommandText = ins1;
            sqlite_cmd.ExecuteNonQuery();
            sqlite_cmd.CommandText = ins2;
            sqlite_cmd.ExecuteNonQuery();
            sqlite_cmd.CommandText = ins3;
            sqlite_cmd.ExecuteNonQuery();
            //add picture to create table and insert
            
        }

        static void ReadData(SQLiteConnection conn)
        {
            //test data 
            SQLiteDataReader sqlite_datareader;
            SQLiteCommand sqlite_cmd;
            sqlite_cmd = conn.CreateCommand();
            //sqlite_cmd.CommandText = "SELECT * FROM Inspection,InspectionArea,Intervention";
            //sqlite_cmd.CommandText = "SELECT * FROM Inspection";
            //sqlite_cmd.CommandText = "SELECT * FROM InspectionArea";
            sqlite_cmd.CommandText = "SELECT * FROM Intervention";

            sqlite_datareader = sqlite_cmd.ExecuteReader();
            while (sqlite_datareader.Read())
            {
                string myreader = sqlite_datareader.GetString(0);
                Console.WriteLine(myreader);
            }
            conn.Close();
        }
    }
}
