using BlogFusion.Models;
using Microsoft.EntityFrameworkCore;

namespace BlogFusion.Data
{
    public class BlogFusionContext : DbContext
    {
        public BlogFusionContext(DbContextOptions<BlogFusionContext> options)
            : base(options) { }

        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
