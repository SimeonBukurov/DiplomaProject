using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using BlogBETA.Models;

namespace BlogBETA.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Post>? Posts { get; set; }
        public DbSet<Blog>? Blogs { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseLazyLoadingProxies();
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Blog>()
                .HasMany(b => b.Posts)
                .WithOne(p => p.Blog)
                .HasForeignKey(b => b.BlogId);
            modelBuilder.Entity<Post>()
                .HasOne(p => p.User )
                .WithMany(b => b.Posts)
                .HasForeignKey(b => b.UserId);  
                
               
        }

    }
}