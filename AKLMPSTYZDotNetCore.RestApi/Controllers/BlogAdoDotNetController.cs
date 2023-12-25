using AKLMPSTYZDotNetCore.RestApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using System.Data.SqlClient;

namespace AKLMPSTYZDotNetCore.RestApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogAdoDotNetController : ControllerBase
    {
        private readonly SqlConnectionStringBuilder _sqlConnectionStringBuilder = new SqlConnectionStringBuilder()
        {
            DataSource = ".",
            InitialCatalog = "AKLMPSTYZDotNetCore",
            UserID = "sa",
            Password = "sa@123"
        };

        [HttpGet]
        public IActionResult GetBlogs()
        {
            SqlConnection connection = new SqlConnection(_sqlConnectionStringBuilder.ConnectionString);
            connection.Open();

            string query = @"SELECT [Blog_Id]
                            ,[Blog_Title]
                            ,[Blog_Author]
                            ,[Blog_Content]
                            FROM [dbo].[Tbl_Blog]";
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            sqlDataAdapter.Fill(dt);

            connection.Close();

            List<BlogDataModel> lst = dt.AsEnumerable().Select(dr => new BlogDataModel
            {
                Blog_Id = Convert.ToInt32(dr["Blog_Id"]),
                Blog_Title = Convert.ToString(dr["Blog_Title"]),
                Blog_Author = Convert.ToString(dr["Blog_Author"]),
                Blog_Content = Convert.ToString(dr["Blog_Content"]),
            }).ToList();
            return Ok(lst);
        }

        [HttpGet("{id}")]
        public IActionResult GetBlog(int id)
        {
            SqlConnection connection = new SqlConnection(_sqlConnectionStringBuilder.ConnectionString);
            connection.Open();
            string query = @"SELECT [Blog_Id]
                          ,[Blog_Title]
                          ,[Blog_Author]
                          ,[Blog_Content]
                      FROM [dbo].[Tbl_Blog] where Blog_Id = @Blog_Id";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@Blog_Id", id);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            connection.Close();

            if (dt.Rows.Count == 0)
            {
                return NotFound("Blog not found.");
            }

            var blog = new BlogDataModel
            {
                Blog_Id = Convert.ToInt32(dt.Rows[0]["Blog_Id"]),
                Blog_Title = Convert.ToString(dt.Rows[0]["Blog_Title"]),
                Blog_Author = Convert.ToString(dt.Rows[0]["Blog_Author"]),
                Blog_Content = Convert.ToString(dt.Rows[0]["Blog_Content"]),
            };
            return Ok(blog);
        }

        [HttpPost]
        public IActionResult CreateBlog(BlogDataModel blog)
        {
            using SqlConnection connection = new SqlConnection(_sqlConnectionStringBuilder.ConnectionString);
            connection.Open();
            string query = @"INSERT INTO [dbo].[Tbl_Blog]
           ([Blog_Title]
           ,[Blog_Author]
           ,[Blog_Content])
            VALUES
           (@Blog_Title
           ,@Blog_Author
           ,@Blog_Content)";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@Blog_Title", blog.Blog_Title);
            cmd.Parameters.AddWithValue("@Blog_Author", blog.Blog_Author);
            cmd.Parameters.AddWithValue("@Blog_Content", blog.Blog_Content);
            int result = cmd.ExecuteNonQuery();
            connection.Close();
            string resultMessage = result > 0 ? "Created Successfully" : "Create Failed";
            return Ok(resultMessage);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateBlog(int id, BlogDataModel blog)
        {
            using SqlConnection connection = new SqlConnection(_sqlConnectionStringBuilder.ConnectionString);
            connection.Open();
            string query = @"SELECT [Blog_Id]
                          ,[Blog_Title]
                          ,[Blog_Author]
                          ,[Blog_Content]
                      FROM [dbo].[Tbl_Blog] where Blog_Id = @Blog_Id";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@Blog_Id", id);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            connection.Close();

            if (dt.Rows.Count == 0)
            {
                return NotFound("Blog not found.");
            }

            if (string.IsNullOrEmpty(blog.Blog_Title))
            {
                return BadRequest("Blog title is required.");
            }
            if (string.IsNullOrEmpty(blog.Blog_Author))
            {
                return BadRequest("Blog author is required.");
            }
            if (string.IsNullOrEmpty(blog.Blog_Content))
            {
                return BadRequest("Blog content is required.");
            }

            connection.Open();
            string queryUpdate = @"UPDATE [dbo].[Tbl_Blog]
                           SET [Blog_Title] = @Blog_Title
                              ,[Blog_Author] = @Blog_Author
                              ,[Blog_Content] = @Blog_Content
                         WHERE Blog_Id = @Blog_Id";
            SqlCommand cmdUpdate = new SqlCommand(queryUpdate, connection);
            cmdUpdate.Parameters.AddWithValue("@Blog_Id", id);
            cmdUpdate.Parameters.AddWithValue("@Blog_Title", blog.Blog_Title);
            cmdUpdate.Parameters.AddWithValue("@Blog_Author", blog.Blog_Author);
            cmdUpdate.Parameters.AddWithValue("@Blog_Content", blog.Blog_Content);
            int result = cmdUpdate.ExecuteNonQuery();
            connection.Close();
            string resultMessage = result > 0 ? "Updated Successfully" : "Update Failed";

            return Ok(resultMessage);
        }

        [HttpPatch("{id}")]
        public IActionResult PatchBlog(int id, BlogDataModel blog)
        {
            using SqlConnection connection = new SqlConnection(_sqlConnectionStringBuilder.ConnectionString);
            connection.Open();
            string query = @"SELECT [Blog_Id]
                          ,[Blog_Title]
                          ,[Blog_Author]
                          ,[Blog_Content]
                      FROM [dbo].[Tbl_Blog] where Blog_Id = @Blog_Id";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@Blog_Id", id);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            connection.Close();

            if (dt.Rows.Count == 0)
            {
                return NotFound("Blog not found.");
            }

            string conditions = string.Empty;

            if (!string.IsNullOrEmpty(blog.Blog_Title))
            {
                conditions += $" [Blog_Title] = @Blog_Title, ";
            }
            if (!string.IsNullOrEmpty(blog.Blog_Author))
            {
                conditions += $" [Blog_Author] = @Blog_Author, ";
            }
            if (!string.IsNullOrEmpty(blog.Blog_Content))
            {
                conditions += $" [Blog_Content] = @Blog_Content, ";
            }
            if (conditions.Length == 0)
            {
                return BadRequest("Blog title, author or content is required.");
            }
            conditions = conditions.Substring(0, conditions.Length - 2);

            connection.Open();
            string queryUpdate = $@"UPDATE [dbo].[Tbl_Blog]
                           SET {conditions} 
                         WHERE Blog_Id = @Blog_Id";
            SqlCommand cmdUpdate = new SqlCommand(queryUpdate, connection);
            cmdUpdate.Parameters.AddWithValue("@Blog_Id", id);
            if (!string.IsNullOrEmpty(blog.Blog_Title))
            {
                cmdUpdate.Parameters.AddWithValue("@Blog_Title", blog.Blog_Title);
            }
            if (!string.IsNullOrEmpty(blog.Blog_Author))
            {
                cmdUpdate.Parameters.AddWithValue("@Blog_Author", blog.Blog_Author);
            }
            if (!string.IsNullOrEmpty(blog.Blog_Content))
            {
                cmdUpdate.Parameters.AddWithValue("@Blog_Content", blog.Blog_Content);
            }
            int result = cmdUpdate.ExecuteNonQuery();
            connection.Close();
            string resultMessage = result > 0 ? "Updated Successfully" : "Update Failed";
            return Ok(resultMessage);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteBlog(int id)
        {
            using SqlConnection connection = new SqlConnection(_sqlConnectionStringBuilder.ConnectionString);
            connection.Open();
            string query = @"DELETE FROM [dbo].[Tbl_Blog] WHERE Blog_Id = @Blog_Id";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@Blog_Id", id);
            int result = cmd.ExecuteNonQuery();
            connection.Close();
            string resultMessage = result > 0 ? "Deleted Successfully" : "Delete Failed";
            return Ok(resultMessage);
        }
    }
}
