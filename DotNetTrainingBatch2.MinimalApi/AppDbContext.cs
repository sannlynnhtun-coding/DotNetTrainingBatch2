using DotNetTrainingBatch2.MinimalApi.Models;
using Microsoft.EntityFrameworkCore;

namespace DotNetTrainingBatch2.MinimalApi
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<BlogDataModel> Blogs { get; set; }
    }
}
