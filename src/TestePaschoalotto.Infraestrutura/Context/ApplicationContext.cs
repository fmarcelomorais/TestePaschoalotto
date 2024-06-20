using Microsoft.EntityFrameworkCore;
using System.Runtime.InteropServices.JavaScript;
using TestePaschoalotto.Domain.Model;

namespace TestePaschoalotto.Infraestrutura.Context
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Usuario> Users { get; set; }
        public DbSet<Name> Names { get; set; }
        public DbSet<Login> Logins { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Picture> Pictures { get; set; }
        public DbSet<Dob> Dobs { get; set; }
        //public DbSet<Identity> Ids { get; set; }
        public DbSet<Street> Streets { get; set; }
        public DbSet<Registered> Registereds { get; set; }
        public DbSet<Timezone> Timezones { get; set; }
        public DbSet<Coordinates> Cordinates { get; set; }   


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            const string PGHOST = "ep-raspy-sun-230216.us-east-2.aws.neon.tech";
            const string PGDATABASE = "dbPaschoalotto";
            const string PGUSER = "fmarcelomorais";
            const string PGPASSWORD = "X1DTC5jQUsuf";

            const string CSTRING = $"Server={PGHOST};Database={PGDATABASE};User Id={PGUSER}; Password={PGPASSWORD};";

            optionsBuilder.UseNpgsql(CSTRING) ;
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationContext).Assembly);
            base.OnModelCreating(modelBuilder);
        }
    }
}
