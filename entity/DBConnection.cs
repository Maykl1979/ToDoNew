using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoNew.entity
{
    internal class DBConnection
    {
        private static DBConnection instance;
        private SqlConnection sqlConnection;

        private DBConnection()
        {
            sqlConnection = new SqlConnection("Server=localhost\\SQLEXPRESS; Database = MyBD; Integrated Security=true; TrustServerCertificate=true");
        }
        public static DBConnection GetInstance()
        {
            if (instance == null)
            {
                instance = new DBConnection();
            }
            return instance;
        }
        public SqlConnection GetConnection()
        {
            return sqlConnection;
        }

    }
}
