using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace OneConnect
{
    class Sql
    {
        private Dictionary<string, List<string>> databaseSchema = new Dictionary<string, List<string>>();
        private string path = "";
        private static SqlConnection connection;
        private static bool connectionOpen = false;

        public Sql(string s, string i, string u, string p)
        {
            connectionString(s, i, u, p);

            connection = new SqlConnection(connectionString());
        }

        public void connectionString(string s, string i, string u, string p)
        {
            //path = String.Format("Data Source={0};Initial Catalog={1};Persist Security Info=True;User ID={2};Password={3};",s,i,u,p );
            path = "Server = localhost; Database = tempdb; Trusted_Connection = True;";
            //Server = localhost; Database = master; Trusted_Connection = True;
        }
        public string connectionString()
        {
            if(path != "")
            {
                return path;
            }
            return "";
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
            IDbCommand cmd = new SqlCommand(commandString, connection);
            IDataAdapter da = new SqlDataAdapter((SqlCommand)cmd);
            IDataReader reader = cmd.ExecuteReader();
            return reader;
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

        public bool createDb(string connectionString)
        {
            createDbHelper(connectionString);

            return false;
        }

        private void createDbHelper(string connectionString)
        {
            
        }

        public List<string> getTableName()
        {
            List<string> TableName = new List<string>();

            DataTable table = connection.GetSchema("Tables");
            foreach (DataRow row in table.Rows)
            {
                TableName.Add((string)row[2]);
            }

            return TableName;            
        }
    }
}
