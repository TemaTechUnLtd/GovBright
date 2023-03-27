namespace GovBright.DAL
{
    using GovBright.Models;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Identity.Client;

    public class DataContext : DbContext
    {
        public DataContext()
        {
        }

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(@"server=DARKNESS;Database=GovBright;Trusted_Connection=True;TrustServerCertificate=true;");
        }

        public DbSet<Feedback> FeedbackSet { get; set; }

        public DbSet<Address> Addresses { get; set; }
    }
}
