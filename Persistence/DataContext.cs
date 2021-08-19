using System.Linq;
using Domain;
using Microsoft.EntityFrameworkCore;

namespace Persistence
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Dietitian> Dietitians { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Visit> Visits { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Comment>()
                .HasKey(fs => new { fs.CommentForeignKey });

            modelBuilder.Entity<Comment>()
            .HasOne(p => p.Rated).WithMany(d => d.Comments)
            .HasForeignKey(p => p.Id);
        }

    }
}