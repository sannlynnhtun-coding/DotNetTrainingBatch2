using DotNetTrainingBatch2.MinimalApi;
using DotNetTrainingBatch2.MinimalApi.Features.Blog;
using DotNetTrainingBatch2.MinimalApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<AppDbContext>(opt =>
{
    opt.UseSqlServer(builder.Configuration.GetConnectionString("DbConnection"));
}, ServiceLifetime.Transient, ServiceLifetime.Transient);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseBlogService();

//app.MapGet("/api/blog/{pageNo}/{pageSize}", async ([FromServicesAttribute] AppDbContext dbContext, int pageNo, int pageSize) =>
//    {
//        return await dbContext.Blogs
//            .AsNoTracking()
//            .OrderByDescending(x => x.Blog_Id)
//            .Skip((pageNo - 1) * pageSize)
//            .Take(pageSize)
//            .ToListAsync();
//    })
//    .WithName("GetBlogs")
//    .WithOpenApi();

//app.MapGet("/api/blog/{id}", async ([FromServicesAttribute] AppDbContext dbContext, int id) =>
//    {
//        var item = await dbContext.Blogs
//            .AsNoTracking()
//            .FirstOrDefaultAsync(x => x.Blog_Id == id);
//        if (item is null)
//        {
//            return Results.NotFound("No data found.");
//        }

//        return Results.Ok(item);
//    })
//    .WithName("GetBlog")
//    .WithOpenApi();

//app.MapGet("/api/blog", async ([FromServicesAttribute] AppDbContext dbContext, BlogDataModel blog) =>
//    {
//        await dbContext.Blogs.AddAsync(blog);
//        var result = await dbContext.SaveChangesAsync();
//        var message = result > 0 ? "Saving Successful." : "Saving Failed";
//        return Results.Ok(message);
//    })
//    .WithName("CreateBlog")
//    .WithOpenApi();

app.Run();