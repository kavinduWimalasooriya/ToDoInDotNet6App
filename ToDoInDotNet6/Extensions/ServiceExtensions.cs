using Microsoft.EntityFrameworkCore;
using ToDoInDotNet6.BLL;
using ToDoInDotNet6.BLL.Abstract;
using ToDoInDotNet6.DAL;
using ToDoInDotNet6.DAL.Abstract;
using ToDoInDotNet6.Models.Data;

namespace ToDoInDotNet6.Extensions
{
    public static class ServiceExtensions
    {
        public static void ConfigureSqlConnection(this IServiceCollection services, IConfiguration config) =>
            services.AddDbContext<DataContext>(options =>
            {
                options.UseSqlServer(config.GetConnectionString("sqlConnection"));
            });

        public static void ConfigureRepositoryManager(this IServiceCollection services) =>
            services.AddScoped<IRepositoryManager, RepositoryManager>();
        public static void ConfigureServiceManager(this IServiceCollection services) =>
            services.AddScoped<IServiceManager, ServiceManager>();

    }
}
