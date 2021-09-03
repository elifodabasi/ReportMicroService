using DataAccess.Configurations;
using DataAccess.Seeds;
using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.EntityFramework
{
   public class EfDbContext : DbContext
    {
        public EfDbContext(DbContextOptions<EfDbContext> options) : base(options)
        {

        }

        public EfDbContext()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(@"User ID=postgres;Password=123;Host=localhost;Port=5432;Database=TelephoneBook;Pooling=true");
        }

        public DbSet<Report> Reports;
        public DbSet<ReportStatus> ReportStatuses;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            #region ApplyEntiyConfiguration
            modelBuilder.ApplyConfiguration(new ReportConfiguration());
            modelBuilder.ApplyConfiguration(new ReportStatusConfiguration());
            #endregion

            #region ApplyEntitySeed
            modelBuilder.ApplyConfiguration(new ReportSeed(new Guid[] { new Guid("e98a2570-92e7-435e-a289-e5702987fa8e") }));
            modelBuilder.ApplyConfiguration(new ReportStatusSeed());
            #endregion
        }
    }
}
