﻿using DotNetTrainingBatch2.ConsoleApp.AdoDotNetExamples;
using DotNetTrainingBatch2.ConsoleApp.DapperExamples;
using DotNetTrainingBatch2.ConsoleApp.EFCoreExamples;
using DotNetTrainingBatch2.ConsoleApp.HttpClientExamples;
using DotNetTrainingBatch2.ConsoleApp.RefitExamples;
using System.Data;
using System.Data.SqlClient;
using Serilog;
using Serilog.Sinks.MSSqlServer;

Log.Logger = new LoggerConfiguration()
    .MinimumLevel.Debug()
    .WriteTo.Console()
    .WriteTo.File("logs/myapp.log", rollingInterval: RollingInterval.Hour)
    .WriteTo
    .MSSqlServer(
        connectionString: "Server=.;Database=TestDb;User ID=sa;Password=sasa@123;TrustServerCertificate=True;",
        sinkOptions: new MSSqlServerSinkOptions { TableName = "Tbl_Log", AutoCreateSqlTable = true })
    .CreateLogger();

Console.WriteLine("Hello, World!");
Log.Information("Hello, world!");

// Ctrl + .
// Ctrl + D
// Alt + Up Key, Down Key
// F10 - summary
// F11 - detail
// Ctrl + K, D // Reformat Code

// Ctrl + M, H // create region

//SqlConnectionStringBuilder sqlConnectionStringBuilder = new SqlConnectionStringBuilder();
//sqlConnectionStringBuilder.DataSource = "."; // server name
//sqlConnectionStringBuilder.InitialCatalog = "AKLMPSTYZDotNetCore"; // db name
//sqlConnectionStringBuilder.UserID = "sa";
//sqlConnectionStringBuilder.Password = "sa@123";

//SqlConnectionStringBuilder sqlConnectionStringBuilder = new SqlConnectionStringBuilder()
//{
//    DataSource = ".",
//    InitialCatalog = "AKLMPSTYZDotNetCore",
//    UserID = "sa",
//    Password = "sa@123"
//};
//SqlConnection connection = new SqlConnection(sqlConnectionStringBuilder.ConnectionString);
//Console.WriteLine("Connection opening...");
//connection.Open();
//Console.WriteLine("Connection opened.");

//string query = @"SELECT [Blog_Id]
//      ,[Blog_Title]
//      ,[Blog_Author]
//      ,[Blog_Content]
//  FROM [dbo].[Tbl_Blog]";
//SqlCommand command = new SqlCommand(query, connection);
//SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(command);
//DataTable dt = new DataTable();
//sqlDataAdapter.Fill(dt);

//Console.WriteLine("Connection closing...");
//connection.Close();
//Console.WriteLine("Connection closed.");

//// DataSet
//// DataTable
//// DataRow
//// DataColumn

//foreach (DataRow dr in dt.Rows)
//{
//    //Console.WriteLine($"Id => {dr["Blog_Id"]}");
//    Console.WriteLine("Id => " + dr["Blog_Id"]);
//    Console.WriteLine("Title => " + dr["Blog_Title"]);
//    Console.WriteLine("Author => " + dr["Blog_Author"]);
//    Console.WriteLine("Content => " + dr["Blog_Content"]);
//    Console.WriteLine("-----------------");
//}

//AdoDotNetExample adoDotNetExample = new AdoDotNetExample();
//adoDotNetExample.Run();

//DapperExample dapperExample = new DapperExample();
//dapperExample.Run();

//EFCoreExample eFCoreExample = new EFCoreExample();
//eFCoreExample.Run();

//HttpClientExample httpClientExample = new HttpClientExample();
//await httpClientExample.Run();

//Console.WriteLine("Please wait for api...");
//Console.ReadKey();

//RefitExample refitExample = new RefitExample(); 
//await refitExample.Run();

//AdoDotNetExample adoDotNetExample = new AdoDotNetExample();
//adoDotNetExample.Read(1, 10);
//adoDotNetExample.Read(5, 10);

int a = 10, b = 0;
try
{
    Log.Debug("Dividing {A} by {B}", a, b);
    Console.WriteLine(a / b);
}
catch (Exception ex)
{
    Log.Error(ex, "Something went wrong");
}
finally
{
    await Log.CloseAndFlushAsync();
}

Console.ReadKey();
//Console.ReadLine();