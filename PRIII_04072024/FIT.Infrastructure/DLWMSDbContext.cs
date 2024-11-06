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
        public DbSet<NastavaIB220043> NastavaIB220043 { get; set; }
        public DbSet<PrisustvoIB220043> PrisustvoIB220043 { get; set; }
        public DbSet<ProstorijeIB220043> ProstorijeIB220043 { get; set; }
    }
}