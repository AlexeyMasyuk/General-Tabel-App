using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace generalSQL_Table
{
    public class DBAccess
    {
        protected MySqlConnection connection = null;
        public DBAccess(string connectionString)
        {
            connection = new MySqlConnection(connectionString);
        }

        protected void Connect()
        {
            if (connection.State != System.Data.ConnectionState.Open)
            {
                connection.Open();
            }
        }

        protected void Disconnect()
        {
            connection.Close();
        }

        private string[] ReaderToString(MySqlDataReader reader)
        {
            string[] readedData = new string[reader.FieldCount];
            for (int i = 0; reader.Read() || i < readedData.Length; i++) 
                readedData[i] = reader[i].ToString();
            return readedData;
        }

        protected string[] GetMultipleQuery(string query)
        {
            MySqlDataReader reader = null;
            string[] readedData = null;
            lock (connection)
            {
                Connect();
                try
                {
                    MySqlCommand command = new MySqlCommand(query, connection);
                    reader = command.ExecuteReader();
                    readedData = ReaderToString(reader);
                }
                finally
                {
                    Disconnect();                    
                }
            }
            return readedData;
        }

        protected void ExecuteSimpleQuery(string query)
        {
            lock (connection)
            {
                Connect();
                try
                {
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.ExecuteNonQuery();
                }
                catch(Exception e)
                {
                    MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK);
                }
                finally
                {
                    Disconnect();
                }
            }
        }
    }
}
