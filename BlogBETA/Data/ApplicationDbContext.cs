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
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=BlogDataBase;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Blog>()
                .HasMany(b => b.Posts)
                .WithOne(p => p.Owner)
                .HasForeignKey(b => b.OwnerId);
            modelBuilder.Entity<Post>()
                .HasOne(p => p.User )
                .WithMany(u => u.Posts)
                .HasForeignKey(u => u.Id);  
            modelBuilder.Entity<User>()
                .HasOne(u => u.Blog)
                .WithMany(b => b.Users)
                .HasForeignKey(u => u.Id);
                
               
        }

    }
}