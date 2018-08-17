using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneConnect
{
    class SqlKeyWords
    {
        private List<string> _reservedWords = new List<string>
        {
            "AND",
"OR",
"ALTER",
"AS",
"BETWEEN",
"CREATE",
"DATABASE",
"TABLE",
"INDEX",
"VIEW",
"DELETE",
"DATABASE",
"DROP",
"EXISTS",
"GROUP BY",
"INSERT INTO",
"INNER",
"LEFT",
"JOIN",
"RIGHT",
"FULL",
"LIKE",
"ORDER BY",
"SELECT",
"*",
"SELECT DISTINCT",
"SELECT INTO",
"SELECT TOP",
"TRUNCATE TABLE",
"UNION",
"UPDATE",
"WHERE"

        };
        public List<string> reservedWords
        {
            get { return _reservedWords; }
        }
    }
}
