using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using RequisiteService.Application.Interface;
using RequisiteService.persistance;

namespace RequisiteService.Persistance
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddPersistance(this IServiceCollection services, IConfiguration config)
        {
            var connectionString = config["DbConnection"];

            IRequisiteContext _context;
            switch (config["DbType"])
            {
                case "InMemory":
                    {
                        services.AddDbContext<RequisiteContext>(opt =>
                        {
                            opt.UseInMemoryDatabase("1");
                        });
                        break;
                    }
                case "Postgres":
                    {
                        services.AddDbContext<RequisiteContext>(options =>
                        {
                            options.UseNpgsql(connectionString);
                        });
                        break;
                    }
                case "SQLite":
                    {
                        services.AddDbContext<RequisiteContext>(options =>
                        {
                            options.UseSqlite(connectionString);
                        });
                        break;
                    }
                default:
                    {
                        throw new Exception();
                    }
            }

            services.AddScoped<IRequisiteContext>(provider => provider.GetService<RequisiteContext>());
            return services;
        }


    }
}
