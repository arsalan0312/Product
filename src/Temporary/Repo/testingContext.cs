using Microsoft.EntityFrameworkCore;
using TechnoLab.QMS.Core.EFCore.Persistence;
using Temporary.Models;

namespace Temporary.Repo
{
    public partial class testingContext : DbContext, ItestingContext
    {
        public testingContext(DbContextOptions options) : base(options)
        {
        }

        public virtual DbSet<Product> Product { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }
    }
}