using BlogPost.Web.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace BlogPost.Web.Data
{
    public class BlogPostDbContext : DbContext
    {
        public BlogPostDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Blogs> Bloggie { get; set; }

        public DbSet<Tags> Taggie { get; set; }
    }
}