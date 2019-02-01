using CodeFirstData.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace CodeFirstData.DAL
{
    public class DataContext : DbContext 
    {
        public DataContext() : base("DataContext")
        {
        }

        public DbSet<Datamodel> Datamodels { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}