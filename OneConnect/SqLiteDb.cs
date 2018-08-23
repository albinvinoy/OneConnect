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

        public DataTable executeCommand(string commandString)
        {
            IDbCommand cmd = new SQLiteCommand(commandString, connection);
            IDataAdapter da = new SQLiteDataAdapter((SQLiteCommand)cmd);
            if (commandString.Contains("select"))
            {
                
                IDataReader reader = cmd.ExecuteReader();
                DataTable dreader = new DataTable();
                dreader.Load(reader);
                return dreader;
            }
            else
            {
                cmd.ExecuteNonQuery();
                return null;
            }
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
            string[] restrictions = new string[4];
            if (connectionOpen)
            {
                tables = connection.GetSchema("Tables");
                
                foreach (DataRow name in tables.Rows)
                {
                    restrictions[2] = name.ItemArray[2].ToString();
                    DataTable table = connection.GetSchema("Columns", restrictions);
                    ParseSchema ps = new ParseSchema();
                    ps.parseSchema((string)name[6]);
                    databaseSchema.Add(name.ItemArray[2].ToString(), ps.getSchema);
                }
            }
            return databaseSchema;
        }

        public List<string> getTableNames()
        {
            List<string> _tableName = new List<string>();
            DataTable table = connection.GetSchema("Tables");
            foreach(DataRow row in table.Rows)
            {
                _tableName.Add((string)row[2]);
            }

            return _tableName;
        }

        public bool createDb(string path)
        {
            createDbHelper(path);
            return false;
        }

        private void createDbHelper(string v)
        {
            SQLiteConnection.CreateFile(v);
        }
    }
}