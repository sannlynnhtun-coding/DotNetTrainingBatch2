# AKLMPSTYZDotNetCore

Blazor Server (Server Side)
- Db 
Blazor Web Assembly (Client Side) download files into browser
- Frontend => API Call (HttpClient)
- Offline

Blazor Server Blog
Blazor Web Assembly Blog

https://github.com/serilog/serilog/wiki/Getting-Started#example-application
https://github.com/serilog/serilog-aspnetcore#serilogaspnetcore---
https://github.com/serilog/serilog/wiki/Provided-Sinks
https://github.com/serilog-mssql/serilog-sinks-mssqlserver

https://www.c-sharpcorner.com/article/log4net-and-net-core/
https://code-maze.com/aspnetcore-structured-logging-log4net/
https://www.c-sharpcorner.com/article/introduction-to-nlog-with-asp-net-core2/

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

- pagination design https://camo.githubusercontent.com/da474a243ed23a783bc24aae5d7c771c30288cf952e74b693df934dd0d59345c/68747470733a2f2f757864776f726c642e636f6d2f77702d636f6e74656e742f75706c6f6164732f323031382f31322f706167696e6174696f6e2d312e676966

- sweetalert https://sweetalert2.github.io/

- notiflix https://notiflix.github.io/ Notify Report Confirm Loading Block

- datatable https://datatables.net/examples/index https://datatables.net/ https://datatables.net/download/

- datetime picker https://fengyuanchen.github.io/datepicker/ https://github.com/fengyuanchen/datepicker/blob/master/README.md https://github.com/fengyuanchen/datepicker/releases/tag/v1.0.10

- ladda button https://cdnjs.com/libraries/ladda-bootstrap https://msurguy.github.io/ladda-bootstrap/ https://github.com/msurguy/ladda-bootstrap

- radio checkbox https://bantikyan.github.io/icheck-bootstrap/ https://cdnjs.com/libraries/icheck-bootstrap https://github.com/bantikyan/icheck-bootstrap https://penguin-arts.com/how-to-check-if-a-checkbox-is-checked-using-icheck-library/

- toast https://apvarun.github.io/toastify-js/# https://github.com/apvarun/toastify-js/blob/master/README.md

- switch / toggle dark mode how to use theme

business1 => repo, data access 1 => data access 2
business1 => repo, data access 2 => data access 2

Repo
- CRUD

data access 1
CRUD

data access 2
CRUD

business1
Transfer
- Balance Check
- From Account = - Amount
- To Account = + Amount

repo = data access 1

data access 1
check
debit
credit

data access 2
check
debit
credit


Dependency injection is a powerful technique that promotes loosely coupled, maintainable, and testable code. By applying dependency injection principles in your C# projects, you can achieve better modularity, reusability, and flexibility.

https://github.com/reactiveui/refit
https://restsharp.dev/authenticators.html

xml
json 
javascript object
json object
format / compress

api

http method
-----------------
get     => read
post    => create
put     => update
patch   => update
delete  => delete

http status code
-----------------
200 - ok
404 - not found
500 - internal server error
402, 403, 409

100 - 199
200 - 299
300 - 399

https://developer.mozilla.org/en-US/docs/Web/HTTP/Status

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
