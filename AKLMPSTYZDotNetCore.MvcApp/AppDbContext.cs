using AKLMPSTYZDotNetCore.MvcApp.Models;
using Microsoft.EntityFrameworkCore;

namespace AKLMPSTYZDotNetCore.MvcApp
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { } 

        public DbSet<BlogDataModel> Blogs { get; set; }
    }
}
