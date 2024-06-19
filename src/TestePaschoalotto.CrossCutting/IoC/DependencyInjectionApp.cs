using Microsoft.Extensions.DependencyInjection;
using TestePaschoalotto.Application.Interface;
using TestePaschoalotto.Application.Servicos;
using TestePaschoalotto.Domain.Interface;
using TestePaschoalotto.Infraestrutura.Context;
using TestePaschoalotto.Infraestrutura.Repositories;
using TestePaschoalotto.Application.Mapper;



namespace TestePaschoalotto.CrossCutting.IoC
{
    public static class DependencyInjectionApp
    {
        public static IServiceCollection AddDependecyInjection(this IServiceCollection services) 
        {
            services.AddDbContext<ApplicationContext>();
            services.AddScoped<IUserRepository, UsuarioRepository>();
            //services.AddScoped<IUsuarioService, UsuarioService>();

            services.AddAutoMapper(typeof(MapperConfigureProfile));


           
            return services;
        }
    }
}
