# AKLMPSTYZDotNetCore

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
- Console App

- Ado.Net (CRUD)
- Dapper  (CRUD)
- EF Entity Framework (Code First => Create Table, Database First => use in Code) (CRUD)
RepoDB

- Asp.Net Core Web Api (Rest Api)
    - EF
    - Dapper
    - Ado.Net
- Postman

- Api Call [Console]
    - HttpClient
    - RestClient
    - Refit

- html, css, javascript
- jquery
- jquery plugins
- sweetalert https://sweetalert2.github.io/
- notiflix https://notiflix.github.io/ Notify Report Confirm Loading Block
- datatable https://datatables.net/examples/index https://datatables.net/ https://datatables.net/download/
- datetime picker https://fengyuanchen.github.io/datepicker/ https://github.com/fengyuanchen/datepicker/blob/master/README.md https://github.com/fengyuanchen/datepicker/releases/tag/v1.0.10
- ladda button https://cdnjs.com/libraries/ladda-bootstrap https://msurguy.github.io/ladda-bootstrap/ https://github.com/msurguy/ladda-bootstrap
- radio checkbox https://bantikyan.github.io/icheck-bootstrap/ https://cdnjs.com/libraries/icheck-bootstrap https://github.com/bantikyan/icheck-bootstrap https://penguin-arts.com/how-to-check-if-a-checkbox-is-checked-using-icheck-library/
- toast https://apvarun.github.io/toastify-js/# https://github.com/apvarun/toastify-js/blob/master/README.md

- Asp.Net Core MVC (submit, ajax)
    - EF 
    Ado.Net
    Dapper

- Chart [ApexChart, ChartJs, HighCharts, CanvasJS]

Api Call [MVC]
    HttpClient
    RestClient
    Refit

Minimal Api
Text Logging
Db Logging

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