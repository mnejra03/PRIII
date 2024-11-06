using FIT.Data;
using FIT.Data.IB220043;
using Microsoft.EntityFrameworkCore;

using System.Configuration;

namespace FIT.Infrastructure
{
    public class DLWMSDbContext : DbContext
    {
        private readonly string dbPutanja;

        public DLWMSDbContext()
        {
            dbPutanja = ConfigurationManager.
                ConnectionStrings["DLWMSBaza"].ConnectionString;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(dbPutanja);
        }
        public DbSet<SemestriIB220043> Semestri { get; set; }
        public DbSet<Student> Studenti { get; set; }
        public DbSet<PredmetiIB220043> Predmeti { get; set; }
        public DbSet<PolozeniPredemtiIB220043> PolozeniPredmeti { get; set; }
        public DbSet<StudentiUvjerenjaIB220043> StudentiUvjerenjaIB220043 { get; set; }
    }
}