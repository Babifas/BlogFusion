using BlogFusion.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BlogFusion.Data
{
    public class BlogFusionContext : IdentityDbContext<IdentityUser>
    {
        public BlogFusionContext(DbContextOptions<BlogFusionContext> options)
            : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
