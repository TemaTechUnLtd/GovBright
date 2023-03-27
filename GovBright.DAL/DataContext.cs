namespace GovBright.DAL
{
    using GovBright.Models;
    using Microsoft.EntityFrameworkCore;

    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Feedback> FeedbackSet { get; set; }
    }
}
