namespace GovBright.DAL
{
    using GovBright.Models;
    using Microsoft.EntityFrameworkCore;
    using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

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
            optionsBuilder.UseSqlServer("server=DARKNESS;Database=GovBright;Trusted_Connection=True;MultipleActiveResultSets=true;TrustServerCertificate=true;");
        }

        public DbSet<Feedback> FeedbackSet { get; set; }
    }
}
