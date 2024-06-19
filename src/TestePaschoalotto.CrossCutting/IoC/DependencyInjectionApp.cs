using Microsoft.Extensions.DependencyInjection;
using TestePaschoalotto.Application.Interface;
using TestePaschoalotto.Application.Servicos;
using TestePaschoalotto.Domain.Interface;
using TestePaschoalotto.Infraestrutura.Context;
using TestePaschoalotto.Infraestrutura.Repositories;



namespace TestePaschoalotto.CrossCutting.IoC
{
    public static class DependencyInjectionApp
    {
        public static IServiceCollection AddDependecyInjection(this IServiceCollection services) 
        {
            services.AddDbContext<ApplicationContext>();
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<ILocationRepository, LocationRepository>();
            services.AddScoped<ILoginRepository, LoginRepository>();
            services.AddScoped<INaturalizationRepository, NaturalizationRepository>();
            services.AddScoped<IContactRepository, ContactRepository>();
            services.AddScoped<IPictureRepository, PictureRepository>();
            services.AddScoped<IUsuarioService, UsuarioService>();
           // services.AddScoped<IRandomUserService, RandomUserService>();
           
            return services;
        }
    }
}
