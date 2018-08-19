using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;
using System.Data.Common;

namespace OneConnect
{
    class SqLiteDb
    {
        private Dictionary<string, List<string>> databaseSchema = new Dictionary<string, List<string>>();
        private string path = "";
        private static SQLiteConnection connection;
        private static bool connectionOpen = false;
        public SqLiteDb(string sqliteLocation)
        {
            connectionString = sqliteLocation;
            connection = new SQLiteConnection(connectionString);
        }

        public string connectionString
        {
            set
            {
                path = string.Format("Data Source={0}", value);
            }

            get
            {
                return path;
            }
        }

        public bool isConnectionOpen
        {
            get
            {
                return connectionOpen;
            }
        }

        public string dbName
        {
            get
            {
                return connection.Database;
            }
        }

        public bool openDb()
        {
            try
            {
                connection.Open();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return connectionOpen = false;
            }

            connectionOpen = true;
            return connectionOpen;
        }

        public IDataReader executeCommand(string commandString)
        {

            IDbCommand cmd = new SQLiteCommand(commandString, connection);
            IDataAdapter da = new SQLiteDataAdapter((SQLiteCommand)cmd);
            IDataReader reader = cmd.ExecuteReader();
            return reader;
        }

        public SQLiteDataReader getReader
        {

            get
            {
                return getReader;
            }
        }

        public void closeDB()
        {
            if (connectionOpen)
            {
                connection.Close();
            }
        }

        public Dictionary<string, List<string>> getTableData()
        {
            DataTable tables = null;
            if (connectionOpen)
            {
                tables = connection.GetSchema("Tables");
                foreach (DataRow name in tables.Rows)
                {
                    ParseSchema ps = new ParseSchema();
                    ps.parseSchema((string)name[6]);
                    databaseSchema.Add((string)name[2], ps.getSchema);
                }
            }
            return databaseSchema;
        }
    }
}