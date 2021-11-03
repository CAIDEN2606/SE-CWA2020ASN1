using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SQLite;
using System.IO;
using System.Windows.Forms;

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
            setConnection();
        }

        private void setConnection()
        {
            string connectionString;
            connectionString = "Data source=" + database + "; Version = 3; New = True; Compress = True; ";
            connection = new SQLiteConnection(connectionString);
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
        //moved to businessmetalayer.cs
        public int InsertInspectionData(SQLiteConnection con)
        {
            int ans = 0;

            SQLiteCommand sqlite_cmd;
            sqlite_cmd = con.CreateCommand();
            sqlite_cmd.CommandText = "INSERT INTO Inspection (SiteName, JobDescription,InspectorName,InspectionDate," +
                "SupervisorName) VALUES(inspectName,site,wkarea, date,job,supervisor);";
            sqlite_cmd.ExecuteNonQuery();
            ans++;
            MessageBox.Show("InsertInspectionData return value = " + ans);
            return ans;
        }

        static void ReadData(SQLiteConnection conn)
        {
            SQLiteDataReader sqlite_datareader;
            SQLiteCommand sqlite_cmd;
            sqlite_cmd = conn.CreateCommand();
            sqlite_cmd.CommandText = "SELECT * FROM SampleTable, SampleTable1";

            sqlite_datareader = sqlite_cmd.ExecuteReader();
            while (sqlite_datareader.Read())
            {
                string myreader = sqlite_datareader.GetString(0);
                Console.WriteLine(myreader);

            }
            conn.Close();
        }
        public void CreateTable(SQLiteConnection conn)
        {
            if (!File.Exists("MuskSQLiteDb.sqbpro"))
            {
                SQLiteConnection.CreateFile("MuskSQLiteDb.sqbpro");

                SQLiteCommand sqlite_cmd;
                string Interv = @"CREATE TABLE Inspection (
                        SiteName  TEXT NOT NULL,
	                    Type  TEXT NOT NULL,
	                    JobDescription    TEXT NOT NULL,
	                    InspectorName TEXT NOT NULL,
	                    InspectionDate    INTEGER NOT NULL,
	                    SupervisorName    TEXT NOT NULL,
	                    Inspection_ID INTEGER NOT NULL,
	                    WorkArea_ID   INTEGER NOT NULL,
	                    PRIMARY KEY Inspection_ID AUTOINCREMENT
                );";
                string InspectArea = @"CREATE TABLE InspectionWorkArea (
                        InspectionWorkArea_ID INTEGER NOT NULL,
	                    WorkAreaName  TEXT NOT NULL,
	                    InspectionSummary TEXT,
	                    Intervention_ID   INTEGER NOT NULL UNIQUE,
                        InterventionTotal INTEGER,
	                    PRIMARY KEY InspectionWorkArea_ID AUTOINCREMENT,
	                    FOREIGN KEY Intervention_ID REFERENCES Intervention Intervention_ID
                );";
                string Inspect = @"CREATE TABLE Inspection(
                        Inspection_ID PRIMARY KEY AUTOINCREMENT                    
                        SiteName TEXT NOT NULL,
                        Type TEXT NOT NULL,
                        JobDescription TEXT NOT NULL,
                        InspectorName TEXT NOT NULL,
                        InspectionDate INTEGER NOT NULL,
                        SupervisorName TEXT NOT NULL,
                        Inspection_ID INTEGER NOT NULL,
                        WorkArea_ID INTEGER NOT NULL
                 );";

                sqlite_cmd = conn.CreateCommand();
                sqlite_cmd.CommandText = Interv;
                sqlite_cmd.ExecuteNonQuery();
                sqlite_cmd.CommandText = InspectArea;
                sqlite_cmd.ExecuteNonQuery();
                sqlite_cmd.CommandText = Inspect;
                sqlite_cmd.ExecuteNonQuery();

                MessageBox.Show("Database file and tables created");
            }
            else
            {
                //show while testing then change to console or log file

                MessageBox.Show("Database file exists");
            }


        }
        ///////////////////////////////////////////////////
        ///
        /// 



        //creating a tester prior to implementing above  
        public class Tester
        {

            public static void SQLiteTest()
            {
                SQLiteConnection sqlite_conn;
                sqlite_conn = CreateConnection();
                CreateTable(sqlite_conn);
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

                }
                return sqlite_conn;
            }

            static void CreateTable(SQLiteConnection conn)
            {
                /*var site = cmb_sitetName.Text;
                var date = dtp_dateTimePicker1;
                var comms = rtb_comments;
                var clickbox = cbx_interventionType;
                var inspector = txt_inspectorName;*/
                SQLiteCommand sqlite_cmd;
                string Createsql = "CREATE TABLE SampleTable (Site VARCHAR(20), Date DATETIME)";
                string Createsql1 = "CREATE TABLE SampleTable1 (Comments VARCHAR(20), Clickbox VARCHAR(20), Inspector VARCHAR(20))";
                sqlite_cmd = conn.CreateCommand();
                sqlite_cmd.CommandText = Createsql;
                sqlite_cmd.ExecuteNonQuery();
                sqlite_cmd.CommandText = Createsql1;
                sqlite_cmd.ExecuteNonQuery();

            }

            static void InsertData(SQLiteConnection conn)
            {
                SQLiteCommand sqlite_cmd;
                sqlite_cmd = conn.CreateCommand();
                sqlite_cmd.CommandText = "INSERT INTO SampleTable (Site, Date) VALUES(site, date); ";
                sqlite_cmd.ExecuteNonQuery();
                sqlite_cmd.CommandText = "INSERT INTO SampleTable1 (Comms, Clickbox, Inspector) VALUES(comms, click, inspector); ";
                sqlite_cmd.ExecuteNonQuery();

            }

            static void ReadData(SQLiteConnection conn)
            {
                SQLiteDataReader sqlite_datareader;
                SQLiteCommand sqlite_cmd;
                sqlite_cmd = conn.CreateCommand();
                sqlite_cmd.CommandText = "SELECT * FROM SampleTable, SampleTable1";

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
}

