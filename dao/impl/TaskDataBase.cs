using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoNew.dao.abstracts;
using ToDoNew.entity;

namespace ToDoNew.dao.impl
{
    internal class TaskDataBase : ITaskDao
    {
       SqlConnection sqlConnection = DBConnection.GetInstance().GetConnection();
        public void DeliteTask(TaskEntity task)
        {
            throw new NotImplementedException();
        }

        public List<TaskEntity> FindTask(TaskEntity task)
        {
            sqlConnection.Open();
            string sqlRequest = "SELECT * FROM Tasks WHERE user_id = @user_id";
            SqlCommand sqlCommand = new SqlCommand(sqlRequest, sqlConnection);
            sqlCommand.Parameters.Add("@user_id", System.Data.SqlDbType.VarChar).Value = task.user_id;
            try
            {
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                List<TaskEntity> tasks = new List<TaskEntity>();
                if (!sqlDataReader.HasRows)
                {
                    sqlConnection.Close();
                    return tasks;
                }
                while (sqlDataReader.Read())
                {
                    tasks.Add(new TaskEntity(
                        (long)sqlDataReader.GetValue(0),
                        (long)sqlDataReader.GetValue(1),
                        (string)sqlDataReader.GetValue(2),
                        (string)sqlDataReader.GetValue(3),
                        (DateTime)sqlDataReader.GetValue(4),
                        (DateTime)sqlDataReader.GetValue(5)));
                }
                return tasks;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally { sqlConnection.Close(); }
        }

        public void SeveTask(TaskEntity task)
        {
            sqlConnection.Open();
            string sqlRequest = "INSERT INTO Task (user_id, name, status, time_start, time_stop)"+
                "VALUES (@user_id, @name, @status, @time_start, @time_stop)";
            SqlCommand sqlCommand = new SqlCommand(sqlRequest, sqlConnection);
            sqlCommand.Parameters.Add("@user_id", System.Data.SqlDbType.BigInt).Value = task.user_id;
            sqlCommand.Parameters.Add("@name", System.Data.SqlDbType.BigInt).Value = task.name;
            sqlCommand.Parameters.Add("@status", System.Data.SqlDbType.BigInt).Value = task.status;
            sqlCommand.Parameters.Add("@time_start", System.Data.SqlDbType.DateTime).Value = task.TimeStart;
            sqlCommand.Parameters.Add("@time_stop", System.Data.SqlDbType.DateTime).Value = task.TimeStop;
            try
            {
                sqlCommand.ExecuteNonQuery();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { sqlConnection.Close(); }

        }

        public TaskEntity UpdateTaskr(TaskEntity task)
        {
            throw new NotImplementedException();
        }
    }
}
