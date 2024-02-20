using DotNetTrainingBatch2.MvcApp.Models;
using Microsoft.EntityFrameworkCore;

namespace DotNetTrainingBatch2.MvcApp
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { } 

        public DbSet<BlogDataModel> Blogs { get; set; }
    }
}
