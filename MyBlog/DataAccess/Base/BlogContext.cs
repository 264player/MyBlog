using System.Reflection.Metadata;
using Microsoft.EntityFrameworkCore;
using MyBlog.Models;

namespace MyBlog.DataAccess.Base
{
    public class BlogContext:DbContext
    {
        public BlogContext(DbContextOptions<BlogContext> options) : base(options) { }
        public DbSet<ABlog> Blogs { get; set; }
        public DbSet<ABContent> Contents { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ABlog>()
                .HasKey(b => b.BId)
                .HasName("PrimaryKey_BId");
            modelBuilder.Entity<ABContent>()
                .HasKey(b => b.BId)
                .HasName("PrimatyKey_BId");
        }
    }
}
