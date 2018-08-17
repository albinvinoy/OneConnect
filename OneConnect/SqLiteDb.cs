using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;

namespace OneConnect
{
    class SqLiteDb
    {
        
        private string path = "";
        private static SQLiteConnection connection;
        private static bool connectionOpen = false;

        public SqLiteDb(string sqliteLocation)
        {
            connectionString = sqliteLocation;
            connection = new SQLiteConnection();
            
        }
    
        public string connectionString
        {
            set { path = string.Format("Data Source={0}", value); }
            get { return path; }
        }

        public void getSchema()
        {
            if (connectionOpen)
            {
                var metaData = connection.GetSchema();
                foreach (var item in metaData.Rows)
                {
                    
                }
                
            }
        }
        public bool openDb()
        {
            try
            {
                connection.Open();

            } catch(SQLiteException ex)
            {
                Console.WriteLine(ex.Message);
                return connectionOpen = false;
            }
            connectionOpen = true;
            return connectionOpen;
        }

        public bool isConnectionOpen
        {
            get { return connectionOpen; }
        }

        public void closeDB()
        {
            if (connectionOpen)
            {
                connection.Close();
            }
        }

        public DataTable getTableData()
        {
            DataTable tables = null;
            if (connectionOpen)
            {
                tables = connection.GetSchema("Tables");
            }
            else
            {
                
            }

            return tables;
        }
        
    }
}

/*
 https://archive.codeplex.com/?p=dbschemareader

     https://docs.microsoft.com/en-us/dotnet/api/system.data.sqlclient.sqlconnection.getschema?view=netframework-4.7.2
     
     */
