using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneConnect
{
    class ParseSchema
    {

        private List<string> schema = new List<string>();
        
        public void parseSchema(string s)
        {
            var list = s.Split('\r');
            foreach (var item in list)
            {
                var line = item.Trim(new Char[] { '\n', '[', ']' }).ToString();
                if (line.IndexOfAny(new Char[] { '[' }, 0, line.Length) != -1)
                {
                    schema.Add(line);
                }
            }
        }

       public List<string> getSchema
        {
            get
            {
                return schema;
            }
        }

    }
}
