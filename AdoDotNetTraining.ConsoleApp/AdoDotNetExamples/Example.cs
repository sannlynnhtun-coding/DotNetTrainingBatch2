using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace AdoDotNetTraining.ConsoleApp.AdoDotNetExamples
{
    public class Example
    {
        public void Run()
        {
            //Read();
            //Edit(1);
            //Create("Title","Author","Content");
            //Update(1);
            Delete(2);
        }

        #region Read
        private void Read()
        {
            SqlConnectionStringBuilder sqlConnectionStringBuilder = new SqlConnectionStringBuilder()
            {
                DataSource = "LAPTOP-DR9SFJ1C",
                InitialCatalog = "DotNetClass",
                UserID = "sa",
                Password = "sa@123",
            };
            SqlConnection connection = new SqlConnection(sqlConnectionStringBuilder.ConnectionString);
            connection.Open();
            string query = @"SELECT [Blog_Id]
      ,[Blog_Title]
      ,[Blog_Author]
      ,[Blog_Content]
  FROM [dbo].[Tbl_blog]";
            SqlCommand command = new SqlCommand(query, connection);
            DataTable dt = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(command);
            sqlDataAdapter.Fill(dt);
            connection.Close();
            foreach (DataRow dr in dt.Rows)
            {
                Console.WriteLine($"Id => {dr["Blog_Id"]}");
                Console.WriteLine($"Blog Title {dr["Blog_Title"]}");
                Console.WriteLine($"Blog Author {dr["Blog_Author"]}");
                Console.WriteLine($"Blog Content {dr["Blog_Content"]}");
                Console.WriteLine("\n");
            }
        }
        #endregion

        #region Edit
        private void Edit(int id)
        {
            SqlConnectionStringBuilder sqlConnectionStringBuilder = new SqlConnectionStringBuilder()
            {
                DataSource = "LAPTOP-DR9SFJ1C",
                InitialCatalog = "DotNetClass",
                UserID = "sa",
                Password = "sa@123"
            };
            SqlConnection connection = new SqlConnection( sqlConnectionStringBuilder.ConnectionString);
            connection.Open();
            string query = @"SELECT [Blog_Id]
      ,[Blog_Title]
      ,[Blog_Author]
      ,[Blog_Content]
  FROM [dbo].[Tbl_blog]
  WHERE Blog_Id = @Blog_Id;";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@Blog_Id", id);
            DataTable dt = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
            sqlDataAdapter.Fill(dt);
            connection.Close();
            DataRow row = dt.Rows[0];
            Console.WriteLine($"Id => {row["Blog_Id"]}");
            Console.WriteLine($"Blog Title => {row["Blog_Title"]}");
            Console.WriteLine($"Blog Author => {row["Blog_Author"]}");
            Console.WriteLine($"Blog Content => {row["Blog_Content"]}");
        }
        #endregion

        #region Create
        private void Create(string title, string author, string content)
        {
            SqlConnectionStringBuilder sqlConnectionStringBuilder = new SqlConnectionStringBuilder()
            {
                DataSource = "LAPTOP-DR9SFJ1C",
                InitialCatalog = "DotNetClass",
                UserID = "sa",
                Password = "sa@123"
            };
            SqlConnection connection = new SqlConnection(sqlConnectionStringBuilder.ConnectionString);
            connection.Open();
            string query = @"INSERT INTO [dbo].[Tbl_blog]
    ([Blog_Title]
    ,[Blog_Author]
    ,[Blog_Content])
VALUES (@Blog_Title
           ,@Blog_Author
           ,@Blog_Content);
";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Blog_Title", title);
            command.Parameters.AddWithValue("@Blog_Author", author);
            command.Parameters.AddWithValue("@Blog_Content", content);
            int result = command.ExecuteNonQuery();
            connection.Close();
            string message = result > 0 ? "Inserted Successfully!" : "Insert data fail!";
            Console.WriteLine(message);
        }
        #endregion

        #region Update
        private void Update(int id, string title, string author, string content)
        {
            try
            {
                SqlConnectionStringBuilder sqlConnectionStringBuilder = new SqlConnectionStringBuilder()
                {
                   DataSource = "LAPTOP-DR9SFJ1C",
                   InitialCatalog = "DotNetClass",
                   UserID = "sa",
                   Password = "sa@123"
                };
                SqlConnection connection = new SqlConnection( sqlConnectionStringBuilder.ConnectionString);
                connection.Open();
                string query = @"UPDATE [dbo].[Tbl_blog]
   SET [Blog_Title] = @Blog_Title
      ,[Blog_Author] = @Blog_Author
      ,[Blog_Content] = @Blog_Content
 WHERE Blog_Id = @Blog_Id;";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@BLog_Title", title);
                cmd.Parameters.AddWithValue("@Blog_Author", author);
                cmd.Parameters.AddWithValue("@Blog-Content", content);
                cmd.Parameters.AddWithValue("@Blog_Id", id);
                int result = cmd.ExecuteNonQuery();
                connection.Close();
                string message = result > 0 ? "Updated Successfully!" : "Update Fail!";
                Console.WriteLine(message);
            }catch (Exception ex)
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
                SqlConnectionStringBuilder sqlConnectionStringBuilder = new SqlConnectionStringBuilder()
                {
                    DataSource = "LAPTOP-DR9SFJ1C",
                    InitialCatalog = "DotNetClass",
                    UserID = "sa",
                    Password = "sa@123"
                };
                SqlConnection connection = new SqlConnection(sqlConnectionStringBuilder.ConnectionString);
                connection.Open();
                string query = @"DELETE FROM [dbo].[Tbl_blog]
      WHERE Blog_Id = @Blog_Id;";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Blog_Id", id);
                int result = command.ExecuteNonQuery();
                connection.Close();
                string message = result > 0 ? "Deleted Successfully!" : "Delete data fail!";
                Console.WriteLine(message);
            }catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        #endregion
    }

}
