using AdoDotNetTraining.ConsoleApp.Models;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoDotNetTraining.ConsoleApp.Homework
{
    public class DapperHomework
    {
        SqlConnectionStringBuilder sqlConnectionStringBuilder = new SqlConnectionStringBuilder()
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
            //Update(3, "Linn Thit edited", 18, "128877", "Yangon", "09773871112");
            //Delete(3);
        }
        #region Read
        private void Read()
        {
            try
            {
                string query = @"SELECT [UserId]
      ,[UserName]
      ,[Age]
      ,[NRC]
      ,[Address]
      ,[MobileNo]
  FROM [dbo].[Tbl_User]";
                using IDbConnection db = new SqlConnection(sqlConnectionStringBuilder.ConnectionString);
                List<UserDataModel> lst = db.Query<UserDataModel>(query).ToList();
                foreach (UserDataModel item in lst)
                {
                    Console.WriteLine($"UserId => {item.UserId}");
                    Console.WriteLine($"UserName => {item.UserName}");
                    Console.WriteLine($"Age => {item.Age}");
                    Console.WriteLine($"NRC => {item.NRC}");
                    Console.WriteLine($"Address => {item.Address}");
                    Console.WriteLine($"MobileNo => {item.MobileNo}");
                    Console.WriteLine("-------------------");
                }
            }catch (Exception ex)
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

                using IDbConnection db = new SqlConnection(sqlConnectionStringBuilder.ConnectionString);
                UserDataModel? item = db.Query<UserDataModel>(query, new {UserId = id}).FirstOrDefault();

                if(item is null)
                {
                    Console.WriteLine("Data Not Found!");
                    return;
                }
                Console.WriteLine($"UserId => {item.UserId}");
                Console.WriteLine($"UserName => {item.UserName}");
                Console.WriteLine($"Age => {item.Age}");
                Console.WriteLine($"NRC => {item.NRC}");
                Console.WriteLine($"Address => {item.Address}");
                Console.WriteLine($"MobileNo => {item.MobileNo}");
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
                using IDbConnection db = new SqlConnection(sqlConnectionStringBuilder.ConnectionString);
                UserDataModel userDataModel = new UserDataModel()
                {
                    UserName = userName,
                    Age = age,
                    NRC = NRC,
                    Address = address,
                    MobileNo = mobile
                };
                int result = db.Execute(query,userDataModel);
                string message = result > 0 ? "Inserted!" : "Insert Fail!";
                Console.WriteLine(message);
            }
            catch (Exception ex)
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
                using IDbConnection db = new SqlConnection(sqlConnectionStringBuilder.ConnectionString);
                UserDataModel userDataModel = new UserDataModel()
                {
                    UserId = id,
                    UserName = userName,
                    Age = age,
                    NRC = NRC,
                    Address = address,
                    MobileNo = mobile
                };
                int result = db.Execute(query,userDataModel);
                Console.WriteLine(result > 0 ? "Update Success!" : "Update Fail!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        #endregion

        #region Delete
        private void  Delete(int id)
        {
            try
            {
                string query = @"DELETE FROM [dbo].[Tbl_User]
      WHERE UserId = @UserId";
                IDbConnection db = new SqlConnection(sqlConnectionStringBuilder.ConnectionString);
                UserDataModel userDataModel = new UserDataModel()
                {
                    UserId= id,
                };
                int result = db.Execute(query,userDataModel);
                Console.WriteLine(result > 0 ? "Delete Success!" : "Delete Fail!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        #endregion
    }
}
