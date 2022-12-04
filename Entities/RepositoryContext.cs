using Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace Entities
{
    public class RepositoryContext : DbContext
    {
        public RepositoryContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<SomeFeatureEntity>? SomeFeatureEntity { get; set; }
        public DbSet<SomeFeatureDetailEntity> SomeFeatureDetailEntities { get; set; }
        public DbSet<SystemMessage> SystemMessages { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<SystemMessage>().HasKey(e => new { e.Code, e.LanguageCode });

        }
    }
}