namespace GovBright.DAL
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;

    public static class ServiceCollectionExtensions 
    {
        public static IServiceCollection RegisterFeedbackDataServices(this IServiceCollection services, ConfigurationManager configuration)
        {
            services.AddDbContext<DataContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("FeedbackConnection"),
                    x => x.MigrationsAssembly("GovBright.Dal"));               
            });

            services.AddScoped<IFeedbackRepository, FeedbackRepository>();
            return services;
        }
    }
}
