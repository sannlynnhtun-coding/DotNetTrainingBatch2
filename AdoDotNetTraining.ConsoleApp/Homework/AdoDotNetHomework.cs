using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace AdoDotNetTraining.ConsoleApp.Homework
{
    public class AdoDotNetHomework
    {
        SqlConnectionStringBuilder connectionStringBuilder = new SqlConnectionStringBuilder()
        {
            DataSource = ".",
            InitialCatalog = "DotNetClass",
            UserID = "sa",
            Password = "sa@123"
       };

        public void Run()
        {
            Read();
            //Create("Linn Thit", 18, "128877", "Yangon", "09773871112");
            //Edit(2);
            //Update(1, "Linn Thit edited", 18, "128877", "Yangon", "09773871112");
            //Delete(2);
        }

        #region Read
        private void Read()
        {
            try
            {
                SqlConnection connection = new SqlConnection(connectionStringBuilder.ConnectionString);
                string query = @"SELECT [UserId]
      ,[UserName]
      ,[Age]
      ,[NRC]
      ,[Address]
      ,[MobileNo]
  FROM [dbo].[Tbl_User]";
                connection.Open();
                SqlCommand cmd = new SqlCommand(query,connection);
                DataTable dt = new DataTable();
                SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                dataAdapter.Fill(dt);
                connection.Close();
                foreach (DataRow dr in dt.Rows)
                {
                    Console.WriteLine($"UserId => {dr["UserId"]}");
                    Console.WriteLine($"UserName => {dr["UserName"]}");
                    Console.WriteLine($"Age => {dr["Age"]}");
                    Console.WriteLine($"NRC => {dr["NRC"]}");
                    Console.WriteLine($"Address => {dr["Address"]}");
                    Console.WriteLine($"MobileNo => {dr["MobileNo"]}");
                    Console.WriteLine("-------------------");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        #endregion

        #region Edit
        private void Edit(int id)
        {
            try
            {
                string query = @"SELECT [UserId]
      ,[UserName]
      ,[Age]
      ,[NRC]
      ,[Address]
      ,[MobileNo]
  FROM [dbo].[Tbl_User]
  WHERE UserId = @UserId";
                SqlConnection connection = new(connectionStringBuilder.ConnectionString);
                connection.Open();
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("UserId", id);
                DataTable dt = new DataTable();
                SqlDataAdapter sqlDataAdapter = new(cmd);
                sqlDataAdapter.Fill(dt);
                connection.Close();

                if(dt.Rows.Count == 0)
                {
                    Console.WriteLine("No data found!");
                    return;
                }

                DataRow dr = dt.Rows[0];
                Console.WriteLine($"UserId => {dr["UserId"]}");
                Console.WriteLine($"UserName => {dr["UserName"]}");
                Console.WriteLine($"Age => {dr["Age"]}");
                Console.WriteLine($"NRC => {dr["NRC"]}");
                Console.WriteLine($"Address => {dr["Address"]}");
                Console.WriteLine($"MobileNo => {dr["MobileNo"]}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        #endregion

        #region Create
        private void Create(string userName, int age, string NRC, string address, string mobile)
        {
            try
            {
                string query = @"INSERT INTO [dbo].[Tbl_User]
                      ([UserName]
                      ,[Age]
                      ,[NRC]
                      ,[Address]
                      ,[MobileNo])
                VALUES
                      (@UserName
                      ,@Age
                      ,@NRC
                      ,@Address
                      ,@MobileNo)";
                SqlConnection conn = new(connectionStringBuilder.ConnectionString);
                conn.Open();
                SqlCommand cmd = new(query,conn);
                cmd.Parameters.AddWithValue("@UserName",userName);
                cmd.Parameters.AddWithValue("@Age", age);
                cmd.Parameters.AddWithValue("@NRC", NRC);
                cmd.Parameters.AddWithValue("@Address", address);
                cmd.Parameters.AddWithValue("@MobileNo", mobile);
                int result = cmd.ExecuteNonQuery();
                conn.Close();
                string message = result > 0 ? "Inserted!" : "Insert Fail!";
                Console.WriteLine(message);
            }catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        #endregion

        #region Update
        private void Update(int id, string userName, int age, string NRC, string address, string mobile)
        {
            try
            {
                string query = @"UPDATE [dbo].[Tbl_User]
   SET [UserName] = @UserName
      ,[Age] = @Age
      ,[NRC] = @NRC
      ,[Address] = @Address
      ,[MobileNo] = @MobileNo
 WHERE UserId = @UserId";
                SqlConnection connection = new SqlConnection(connectionStringBuilder.ConnectionString);
                connection.Open();
                SqlCommand cmd = new(query,connection);
                cmd.Parameters.AddWithValue("@UserName", userName);
                cmd.Parameters.AddWithValue("@Age", age);
                cmd.Parameters.AddWithValue("@NRC", NRC);
                cmd.Parameters.AddWithValue("@Address", address);
                cmd.Parameters.AddWithValue("@MobileNo", mobile);
                cmd.Parameters.AddWithValue("@UserId", id);
                int result = cmd.ExecuteNonQuery();
                connection.Close();
                Console.WriteLine(result > 0 ? "Update Success!" : "Update Fail!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        #endregion

        #region Delete
        private void Delete(int id)
        {
            try
            {
                string query = @"DELETE FROM [dbo].[Tbl_User]
      WHERE UserId = @UserId";
                SqlConnection connection = new SqlConnection(connectionStringBuilder.ConnectionString);
                connection.Open();
                SqlCommand cmd = new(query,connection);
                cmd.Parameters.AddWithValue("@UserId", id);
                int result = cmd.ExecuteNonQuery();
                connection.Close();
                Console.WriteLine(result > 0 ? "Delete Success!" : "Delete Fail!");
            }
            catch (Exception ex) {
                Console.WriteLine(ex.Message);
            }
        }
        #endregion
    }
}
