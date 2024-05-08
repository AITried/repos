using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computer_Shop
{
    internal class DataBase
    {
        private static DataBase instance;
        SqlConnection sqlConnection = new SqlConnection(@"Data Source=LAPTOP-02IGU07E;Initial Catalog=Shop_DB;Integrated Security=true;");

        public static DataBase getInstance()
        {
            if (instance == null)
                instance = new DataBase();
            return instance;
        }

        private DataBase() { }

        public void openConnection()
        {
            if(sqlConnection.State == System.Data.ConnectionState.Closed) 
            { 
                sqlConnection.Open();
            }
        }

        public void closeConnection()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Open)
            {
                sqlConnection.Close();
            }
        }

        public SqlConnection getConnection()
        {
            return sqlConnection;
        }
    }
}
