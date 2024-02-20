using DotNetTrainingBatch2.MvcApp;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Refit;
using RestSharp;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
//builder.Services.AddControllersWithViews().AddJsonOptions(opt =>
//{
//    opt.JsonSerializerOptions.PropertyNamingPolicy = null;
//});
builder.Services.AddDbContext<AppDbContext>(opt =>
{
    string connectionString = builder.Configuration.GetConnectionString("DbConnection")!;
    opt.UseSqlServer(connectionString);
});
//builder.Services.AddScoped<HttpClient>();
builder.Services.AddScoped(n =>
{
    HttpClient httpClient = new HttpClient()
    {
        BaseAddress = new Uri(builder.Configuration.GetSection("ApiUrl").Value!)
    };
    return httpClient;
});
builder.Services.AddScoped(n =>
{
    RestClient restClient = new RestClient(builder.Configuration.GetSection("ApiUrl").Value!);
    return restClient;
});
builder.Services
    .AddRefitClient<IBlogApi>()
    .ConfigureHttpClient(c => c.BaseAddress = new Uri(builder.Configuration.GetSection("ApiUrl").Value!));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
