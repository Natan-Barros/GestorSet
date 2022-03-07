using GS.Receitas.API.Data;
using Microsoft.EntityFrameworkCore;

namespace GS.Receitas.API.Configuration
{
    public static class ApiConfig
    {
        public static void AddConfiguration(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ReceitaContext>(opts =>
                opts.UseNpgsql(configuration.GetConnectionString("DefaultConnection")));

            //services.AddControllers();

            //services.AddCors(options =>
            //{
            //    options.AddPolicy("Total",
            //    builder =>
            //    builder
            //    .AllowAnyOrigin()
            //    .AllowAnyMethod()
            //    .AllowAnyHeader());
            //});

        }
    }
}
