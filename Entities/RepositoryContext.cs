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
    }
}