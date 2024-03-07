
# DotNetCoreTrainingBatch2

Blazor Server (Server Side)
- Db 
Blazor Web Assembly (Client Side) download files into browser
- Frontend => API Call (HttpClient)
- Offline

Blazor Server Blog
Blazor Web Assembly Blog

- [Serilog](https://github.com/serilog/serilog/wiki/Getting-Started#example-application)
- [ Serilog.AspNetCore](https://github.com/serilog/serilog-aspnetcore#serilogaspnetcore---
)
- [Provided Sinks](https://github.com/serilog/serilog/wiki/Provided-Sinks
)
- [Serilog.Sinks.MSSqlServer](https://github.com/serilog-mssql/serilog-sinks-mssqlserver
)
- [ Log4Net And .NET Core](https://www.c-sharpcorner.com/article/log4net-and-net-core/)
- [Structured Logging in ASP.NET Core With log4net](https://code-maze.com/aspnetcore-structured-logging-log4net/)
-  [Introduction To NLog With ASP.NET Coret](https://www.c-sharpcorner.com/article/introduction-to-nlog-with-asp-net-core2/)
- [CORS Enable in Asp-net-core](https://stackoverflow.com/questions/31942037/how-to-enable-cors-in-asp-net-core )

----------

[Clear git local cache](https://stackoverflow.com/questions/41863484/clear-git-local-cache)

```bash

git rm -r --cached .
git add .
git commit -am 'git cache cleared'
git push

```

```sql
create proc Sp_GetBlogs
@pageNo int,
@pageSize int
as
begin

select * from Tbl_Blog
order by Blog_Id
OFFSET ((@pageNo - 1) * @pageSize) ROWS
FETCH NEXT @pageSize ROWS ONLY

end
```

https://www.jqueryscript.net/popular/2023.html

- [Pagination Design ](https://camo.githubusercontent.com/da474a243ed23a783bc24aae5d7c771c30288cf952e74b693df934dd0d59345c/68747470733a2f2f757864776f726c642e636f6d2f77702d636f6e74656e742f75706c6f6164732f323031382f31322f706167696e6174696f6e2d312e676966)
- [Sweetalert ](https://sweetalert2.github.io/)
- [Notiflix ](https://notiflix.github.io) 
- [Datatable](https://datatables.net/)
- [Datetime Picker ](https://fengyuanchen.github.io/datepicker/ )
- [Ladda Button](https://cdnjs.com/libraries/ladda-bootstrap  )
 - [Radio Checkbox](https://bantikyan.github.io/icheck-bootstrap/ )
 - [Toast](https://apvarun.github.io/toastify-js/#  )

- Switch / Toggle dark mode how to use theme

Business1 => repo, data access 1 => data access 2
Business1 => repo, data access 2 => data access 2

Repo
- CRUD

Data Access 1
 - CRUD

Data Access 2
- CRUD

Business1
Transfer
- Balance Check
- From Account = - Amount
- To Account = + Amount

Repo = Data Access 1

Data Access 1
 - Check
 - Debit
 - Credit

Data Access 2
 - Check
 - Debit
 - Credit

Dependency injection is a powerful technique that promotes loosely coupled, maintainable, and testable code. By applying dependency injection principles in your C# projects, you can achieve better modularity, reusability, and flexibility.

[Refit](https://github.com/reactiveui/refit
)
[RestSharp](https://restsharp.dev/authenticators.html
)

XML
JSON
Javascript Object
JSON Object
Format / Compress

API
HTTP Method
-----------------
Get=> Read
Post=> Ceate
Put     => Update
Patch   => Update
Delete  => Delete

HTTP Status Code
-----------------
200 - OK
404 - Not Found
500 - Internal Server Error
402, 403, 409

100 - 199
200 - 299
300 - 399

[ HTTP response status codes](https://developer.mozilla.org/en-US/docs/Web/HTTP/Status
)
[TrustServerCertificate](https://stackoverflow.com/questions/17615260/the-certificate-chain-was-issued-by-an-authority-that-is-not-trusted-when-conn
)
[EF Core Database First](https://www.learnentityframeworkcore.com/walkthroughs/existing-database)
[dotNet tool install --global dotnet-ef](https://www.entityframeworktutorial.net/efcore/create-model-for-existing-database-in-ef-core.aspx#google_vignette)

Install DotNet EF
```
dotnet tool install --global dotnet-ef --version 7
```

Package Manager Console
```bash
Scaffold-DbContext "Server=.\SQLExpress;Database=SchoolDB;Trusted_Connection=True;" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models
```

Terminal
```
dotnet ef dbcontext scaffold "Server=.;Database=TestDb;User ID=sa;Password=sa@123;Trusted_Connection=True;TrustServerCertificate=True;" Microsoft.EntityFrameworkCore.SqlServer -c AppDbContext -o EFDbContextModel
```

EFCore
Code First (C# Class => Database Table)
Database First (Database Table => C# Class)




```
[x] Console App

[x] Ado.Net (CRUD)
[x] Dapper  (CRUD)
[x] EF Entity Framework (Code First => Create Table, Database First => use in Code) (CRUD)
RepoDB

[x] Asp.Net Core Web Api (Rest Api)
    [x] EF
    [x] Dapper
    [x] Ado.Net
[x] Postman

[x] Api Call [Console]
    [x] HttpClient
    [x] RestClient
    [x] Refit

[x] html, css, javascript
[x] jquery
[x] jquery plugins
[x] sweetalert https://sweetalert2.github.io/
[x] notiflix https://notiflix.github.io/ Notify Report Confirm Loading Block
[x] datatable https://datatables.net/examples/index https://datatables.net/ https://datatables.net/download/
[x] datetime picker https://fengyuanchen.github.io/datepicker/ https://github.com/fengyuanchen/datepicker/blob/master/README.md https://github.com/fengyuanchen/datepicker/releases/tag/v1.0.10
[x] ladda button https://cdnjs.com/libraries/ladda-bootstrap https://msurguy.github.io/ladda-bootstrap/ https://github.com/msurguy/ladda-bootstrap
[x] radio checkbox https://bantikyan.github.io/icheck-bootstrap/ https://cdnjs.com/libraries/icheck-bootstrap https://github.com/bantikyan/icheck-bootstrap https://penguin-arts.com/how-to-check-if-a-checkbox-is-checked-using-icheck-library/
[x] toast https://apvarun.github.io/toastify-js/# https://github.com/apvarun/toastify-js/blob/master/README.md

[x] Asp.Net Core MVC (submit, ajax)
    [x] EF 
    - Ado.Net
    - Dapper

[x] Chart [ApexChart, ChartJs, HighCharts, CanvasJS]

[x] Api Call [MVC]
    [x] HttpClient
    [x] RestClient
    [x] Refit

[x] Minimal Api

[x] Serilog
    [x] Text Logging
    [x] Db Logging
[x] NLog
[x] Log4net

[x] Realtime Chat App using SignalR 
[x] Realtime Chart using SignalR 

[x] Register ADO.Net Service to ASP.NET Core Web MVC / API / Minimal API
[x] Register Dapper Service to ASP.NET Core Web MVC / API / Minimal API

[x] UI Design

[x] Blazor CRUD [Server, WASM]
    [x] Blazor Web Assembly (Offline, download file into client) [Frontend] [HttpClient]
    [x] Blazor Web Server (MVC, no javascript, client to server C#) [Frontend + Backend]


Middleware For MVC

[x] [Deploy WASM on Netlify](https://swimburger.net/blog/dotnet/how-to-deploy-blazor-webassembly-to-netlify)
[x] [Deploy Blazor Web Assembly on IIS](https://youtu.be/15-TzypV2HU?si=OFWz3yvVE5SflxCJ)
[x] Deploy on IIS

------------------------------------------------------

GraphQL
gRPC

```

NuGet Package = npm