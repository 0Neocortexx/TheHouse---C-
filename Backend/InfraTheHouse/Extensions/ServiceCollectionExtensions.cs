using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using Model.Context;
using Model.Profiles.Compras;
using Model.Profiles.MetaProfile;
using Model.Profiles.UsuarioProfile;
using Model.Profiles.VisitaProfile;
using Model.Repositories.Compras;
using Model.Repositories.Entretenimento;
using Model.Repositories.Interfaces;
using Model.Repositories.MetaRepository;
using Model.Repositories.UsuarioRepository;
using Model.Services.CompraService;
using Model.Services.Interfaces;
using Model.Services.MetaService;
using Model.Services.UsuarioService;
using Model.Services.VisitaService;
using System.Text;

namespace InfraTheHouse.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static void AddDatabase(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<TheHouseContext>(options =>
                options.UseNpgsql(configuration.GetConnectionString("DefaultConnection")));
        }

        public static void AddRepositories(this IServiceCollection services)
        {
            services.AddTransient<ICompraRepository, CompraRepository>();
            services.AddTransient<IVisitaRepository, VisitasRepository>();
            services.AddTransient<IUsuarioRepository, UsuarioRepository>();
            services.AddTransient<IMetaRepository, MetaRepository>();
        }
        public static void AddServices(this IServiceCollection services)
        {
            services.AddScoped<IMetaService, MetaService>();
            services.AddScoped<ICompraService, CompraService>();
            services.AddScoped<IVisitaService, VisitaService>();
            services.AddScoped<IUsuarioService, UsuarioService>();
        }
        public static void AddMappers(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(UsuarioProfile).Assembly);
            services.AddAutoMapper(typeof(CompraProfile).Assembly);
            services.AddAutoMapper(typeof(VisitaProfile).Assembly);
            services.AddAutoMapper(typeof(MetaProfile).Assembly);
        }

        public static void AddCorsPolicy(this IServiceCollection services)
        {
            services.AddCors(options =>
            {
                options.AddDefaultPolicy(
                    policy =>
                    {
                        policy.WithOrigins("*");
                    });
            });
        }

        public static void AddJwtAuthentication(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            }).AddJwtBearer(options =>
            {
                options.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes("TheHouseTokenSuperSecretKeyMaster2024")),
                    ValidateIssuer = false,
                    ValidateAudience = false
                };
            });
        }
    }
}
