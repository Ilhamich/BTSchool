using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;

using BTSchool.Data;

namespace BTSchool.WebApp
{
    public class DependenciesRoot
    {
        public static void InjectDependencies(IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<AppContext>(option =>
            {
                option.UseSqlServer(configuration.GetConnectionString("DefaultConnection")
                    , optionBuilder => optionBuilder.MigrationsAssembly("BTSchool.WebApp"));
            });
        }
    }
}
