using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DataAccess
{
    public abstract class ConnectionToSql
    {
        private readonly string connectionString;

        public ConnectionToSql()
        {
            connectionString = "Server=LAPTOP-2RS2E00C\\GOMEZ;DataBase=Proyecto;integrated security=true";
        }
        protected SqlConnection GetConnection() => new SqlConnection(connectionString);
    }
}
