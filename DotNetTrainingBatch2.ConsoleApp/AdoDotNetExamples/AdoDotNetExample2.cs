using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DotNetTrainingBatch2.ConsoleApp.Models;
using DotNetTrainingBatch2.Services;

namespace DotNetTrainingBatch2.ConsoleApp.AdoDotNetExamples
{
    public class AdoDotNetExample2
    {
        private readonly AdoDotNetService _adoDotNetService = new AdoDotNetService(new SqlConnectionStringBuilder()
        {
            DataSource = ".",
            InitialCatalog = "AKLMPSTYZDotNetCore",
            UserID = "sa",
            Password = "sa@123"
        });

        public void Run()
        {
            //Read();
            //Edit(1);
            //Edit(12);
            //Create("Test Title", "Test Author", "Test Content");
            //Update(1, "Test Title", "Test Author", "Test Content");
            Delete(13);
        }
        #region Read
        private void Read()
        {
            string query = @"SELECT [Blog_Id]
                          ,[Blog_Title]
                          ,[Blog_Author]
                          ,[Blog_Content]
                      FROM [dbo].[Tbl_Blog]";
            var lst = _adoDotNetService.Query<BlogDataModel>(query);
            foreach (BlogDataModel item in lst)
            {
                Console.WriteLine(item.Blog_Id);
                Console.WriteLine(item.Blog_Title);
                Console.WriteLine(item.Blog_Author);
                Console.WriteLine(item.Blog_Content);
            }

            // var dt = _adoDotNetService.Query(query);

            // foreach (DataRow dr in dt.Rows)
            // {
            //     Console.WriteLine("Id => " + dr["Blog_Id"]);
            //     Console.WriteLine("Title => " + dr["Blog_Title"]);
            //     Console.WriteLine("Author => " + dr["Blog_Author"]);
            //     Console.WriteLine("Content => " + dr["Blog_Content"]);
            //     Console.WriteLine("-----------------");
            // }
        }
        #endregion

        #region ReadWithPagination
        public void Read(int pageNo, int pageSize)
        {
            string query = "Sp_GetBlogs";
            List<SqlParameter> lstParameters = new List<SqlParameter>()
            {
                new("@pageNo", pageNo),
                new("@pageSize", pageSize)
            };

            //var dt = _adoDotNetService.Query(query, CommandType.StoredProcedure, 
            //    new SqlParameter("@pageNo", pageNo),
            //    new SqlParameter("@pageSize", pageSize));

            var dt = _adoDotNetService.Query(query, CommandType.StoredProcedure, lstParameters.ToArray());

            foreach (DataRow dr in dt.Rows)
            {
                Console.WriteLine("Id => " + dr["Blog_Id"]);
                Console.WriteLine("Title => " + dr["Blog_Title"]);
                Console.WriteLine("Author => " + dr["Blog_Author"]);
                Console.WriteLine("Content => " + dr["Blog_Content"]);
                Console.WriteLine("-----------------");
            }
        }
        #endregion

        #region Edit
        private void Edit(int id)
        {
            string query = @"SELECT [Blog_Id]
                          ,[Blog_Title]
                          ,[Blog_Author]
                          ,[Blog_Content]
                      FROM [dbo].[Tbl_Blog] where Blog_Id = @Blog_Id";
            List<SqlParameter> lstParameters = new List<SqlParameter>()
            {
                new("@Blog_Id", id)
            };

            var dt = _adoDotNetService.Query(query, sqlParameters: lstParameters.ToArray());

            if (dt.Rows.Count == 0)
            {
                Console.WriteLine("No data found.");
                return;
            }

            DataRow dr = dt.Rows[0];
            Console.WriteLine("Id => " + dr["Blog_Id"]);
            Console.WriteLine("Title => " + dr["Blog_Title"]);
            Console.WriteLine("Author => " + dr["Blog_Author"]);
            Console.WriteLine("Content => " + dr["Blog_Content"]);
            Console.WriteLine("-----------------");
        }
        #endregion

        #region Create
        private void Create(string title, string author, string content)
        {
            string query = @"INSERT INTO [dbo].[Tbl_Blog]
                           ([Blog_Title]
                           ,[Blog_Author]
                           ,[Blog_Content])
                     VALUES
                           (@Blog_Title
                           ,@Blog_Author
                           ,@Blog_Content)";
            List<SqlParameter> lstParameters = new List<SqlParameter>()
            {
                new("@Blog_Title", title),
                new("@Blog_Author", author),
                new("@Blog_Content", content)
            };

            var result = _adoDotNetService.Execute(query, sqlParameters: lstParameters.ToArray());
            string message = result > 0 ? "Saving Successful." : "Saving Failed.";
            Console.WriteLine(message);
        }
        #endregion

        #region Update
        private void Update(int id, string title, string author, string content)
        {
            string query = @"UPDATE [dbo].[Tbl_Blog]
                           SET [Blog_Title] = @Blog_Title
                              ,[Blog_Author] = @Blog_Author
                              ,[Blog_Content] = @Blog_Content
                         WHERE Blog_Id = @Blog_Id";

            List<SqlParameter> lstParameters = new List<SqlParameter>()
            {
                new("@Blog_Id", id),
                new("@Blog_Title", title),
                new("@Blog_Author", author),
                new("@Blog_Content", content),
            };

            int result = _adoDotNetService.Execute(query, sqlParameters: lstParameters.ToArray());
            string message = result > 0 ? "Updating Successful." : "Updating Failed.";
            Console.WriteLine(message);
        }
        #endregion

        #region Delete
        private void Delete(int id)
        {
            string query = @"DELETE FROM [dbo].[Tbl_Blog]
                              WHERE Blog_Id = @Blog_Id";

            List<SqlParameter> lstParameters = new List<SqlParameter>()
            {
                new("@Blog_Id", id)
            };

            int result = _adoDotNetService.Execute(query, sqlParameters: lstParameters.ToArray());
            string message = result > 0 ? "Deleting Successful." : "Deleting Failed.";
            Console.WriteLine(message);
        }
        #endregion
    }
}
