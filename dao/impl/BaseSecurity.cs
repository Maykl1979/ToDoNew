using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using ToDoNew.dao.abstracts;
using ToDoNew.entity;

namespace ToDoNew.dao.impl
{
    internal class BaseSecurity : ISecurity
    {
        SqlConnection sqlConnection = DBConnection.GetInstance().GetConnection();
        private static User AuthUser;
        
        public User Auth(User user)
        {
            
                sqlConnection.Open();
                string saqlAuth = "SELECT * FROM users WHERE login = @login AND password = @password";
                SqlCommand authCommand = new SqlCommand(saqlAuth, sqlConnection);
                authCommand.Parameters.Add("@login", System.Data.SqlDbType.VarChar).Value = user.Login;
                authCommand.Parameters.Add("@password", System.Data.SqlDbType.VarChar).Value = user.Password;

                SqlDataReader authReader = authCommand.ExecuteReader();


                

                if (!authReader.HasRows)
                {
                    sqlConnection.Close();
                    throw new Exception();
                }
                while (authReader.Read())
                {
                    user.Id = (long)authReader.GetValue(0);
                    user.Name = (string)authReader.GetValue(1);
                }
                sqlConnection.Close();
                SetUser(user);
                return user;
        }
        private void SetUser(User user)
        {
            AuthUser = user;
        }

        public static User GetAuthUser()
        {
            
            return AuthUser;
        }

        public User LogOut(User user)
        {
            throw new NotImplementedException();
        }

    }
}
