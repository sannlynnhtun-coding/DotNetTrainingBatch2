
# AKLMPSTYZDotNetCore

https://stackoverflow.com/questions/17615260/the-certificate-chain-was-issued-by-an-authority-that-is-not-trusted-when-conn
https://www.learnentityframeworkcore.com/walkthroughs/existing-database
https://www.entityframeworktutorial.net/efcore/create-model-for-existing-database-in-ef-core.aspx#google_vignette

dotnet tool install --global dotnet-ef

Scaffold-DbContext "Server=.\SQLExpress;Database=SchoolDB;Trusted_Connection=True;" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models
dotnet ef dbcontext scaffold "Server=.;Database=TestDb;User ID=sa;Password=sa@123;Trusted_Connection=True;TrustServerCertificate=True;" Microsoft.EntityFrameworkCore.SqlServer -c AppDbContext -o EFDbContextModel

EFCore
Code First (C# Class => Database Table)
Database First (Database Table => C# Class)




```
- Console App

- Ado.Net (CRUD)
Dapper  (CRUD)
EF Entity Framework (Code First => Create Table, Database First => use in Code) (CRUD)
RepoDB

Asp.Net Core Web Api (Rest Api)
    Ado.Net
    - EF
    Dapper
Postman
Api Call [Console]
    HttpClient
    RestClient
    Refit
Asp.Net Core MVC
    Ado.Net
    EF
    Dapper
Api Call [MVC]
    HttpClient
    RestClient
    Refit
Minimal Api
Text Logging
Db Logging

Chart [ApexChart, ChartJs, HighCharts, CanvasJS]

SignalR - (Insert Data => UpdateChart, Chat Message)
UI Design
Blazor CRUD [Server, WASM]
------------------------------------------------------
Deploy WASM
Deploy on IIS

Middleware For MVC

GraphQL
gRPC
```

Nuget Package = npm