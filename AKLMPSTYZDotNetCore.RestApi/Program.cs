using AKLMPSTYZDotNetCore.RestApi;
using Microsoft.EntityFrameworkCore;
using System.Data.SqlClient;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//builder.Services.AddDbContext<AppDbContext>(opt =>
//{
//    SqlConnectionStringBuilder _sqlConnectionStringBuilder = new SqlConnectionStringBuilder()
//    {
//        DataSource = ".",
//        InitialCatalog = "AKLMPSTYZDotNetCore",
//        UserID = "sa",
//        Password = "sa@123",
//        TrustServerCertificate = true
//    };
//    opt.UseSqlServer(_sqlConnectionStringBuilder.ConnectionString);
//}, ServiceLifetime.Transient, ServiceLifetime.Transient);

var app = builder.Build();

// Configure the HTTP request pipeline.
//if (app.Environment.IsDevelopment())
//{
//    app.UseSwagger();
//    app.UseSwaggerUI();
//}

app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
