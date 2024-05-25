using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Straighten.Models;

namespace Straighten.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<News> News { get; set; }
        public DbSet<ImagesUrl> ImagesUrls { get; set; }
        public DbSet<Paragraph> Paragraphs { get; set; }
        public DbSet<SubHeading> SubHeadings { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
