using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CapaComun.Cache;

namespace DataAccess
{
    public class UserDao:ConnectionToSql
    {
        public bool Login(string user, string pass)
        {
            using(var connection = GetConnection())
            {
                connection.Open();
                using(var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "select * from Usuarios where nombre +' '+ apellido=@user and contraseña=@pass";
                    command.Parameters.AddWithValue("@user", user);
                    command.Parameters.AddWithValue("@pass", pass);
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            UserLoginCache.IdUser = reader.GetInt32(0);
                            UserLoginCache.LoginUser = $"{reader.GetString(1)} {reader.GetString(2)}";
                            UserLoginCache.NivelUser = reader.GetString(5);
                            UserLoginCache.NumeroUser = reader.GetString(3);
                        }
                    }
                    return reader.HasRows;
                }
            }
        }
    }
}
