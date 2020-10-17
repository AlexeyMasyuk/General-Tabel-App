using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generalSQL_Table
{
    class DBhandler : DBAccess
    {
        private static string conString;
        private static DBhandler instance;
        private DBhandler(string conString) : base(conString)
        {
        }

        /* initiate DB connection */
        public static DBhandler Instance
        {
            get
            {
                if (instance == null)
                {
                    return new DBhandler(conString);
                }
                return instance;
            }
        }

        public static string ConnectionString
        {
            get { return conString; }
            set
            {
                conString = "server=localhost;user=root;database=" + value + ";port=3306;password=";
            }
        }

        private string AddTabelsNamesToQuery(string[] tabelFields)
        {
            StringBuilder tabelNamesFormat = new StringBuilder();
            for (int j = 0; j < tabelFields.Length; j++)
            {
                tabelNamesFormat.Append('`');
                tabelNamesFormat.Append(tabelFields[j]);
                tabelNamesFormat.Append('`');
                tabelNamesFormat.Append("VARCHAR(20)");
                if (j + 1 < tabelFields.Length)
                    tabelNamesFormat.Append(",");
            }
            return tabelNamesFormat.ToString();
        }

        private string NewTableQueryBuilder(string baseQuery, string tabelName, string[] tabelFields) 
        {
            StringBuilder newQuery = new StringBuilder();
            for(int i=0; i < baseQuery.Length; i++)
            {
                if (char.Equals(baseQuery[i], '1'))
                {
                    newQuery.Append(tabelName);
                    i++;
                }
                else if (i != 0 && char.Equals(baseQuery[i - 1], '('))
                {
                    newQuery.Append(AddTabelsNamesToQuery(tabelFields));
                }
                newQuery.Append(baseQuery[i]);
            }
            return newQuery.ToString();
        }

        public void TableBuilder(string tabelName,string[] tabelFields)
        {
            string[] reader = GetMultipleQuery("SELECT * FROM `queryBank`");
            ExecuteSimpleQuery(NewTableQueryBuilder(reader[1], tabelName, tabelFields));
        }
    }
}
