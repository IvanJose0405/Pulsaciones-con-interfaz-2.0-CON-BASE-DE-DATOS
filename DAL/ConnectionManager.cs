using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DAL
{
    public class ConnectionManager
    {
        SqlConnection Connection;

        public ConnectionManager(string connection)
        {
            Connection = new SqlConnection(connection);
        }

        public void Open()
        {
            Connection.Open();
        }

        public void Close()
        {
            Connection.Close();
        }
        public String Estado()
        {
            return Connection.State.ToString();
        }
    }
}
