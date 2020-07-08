using DevIO.Data.Context;
using Microsoft.Extensions.DependencyInjection;
using DevIO.Business.Intefaces;
using DevIO.Data.Repository;
using Microsoft.AspNetCore.Mvc.DataAnnotations;


namespace DevIO.App.Configurations
{
    public static class DependencyInjectionConfig
    {
        public static IServiceCollection ResolveDependencies(this IServiceCollection services)
        {
            services.AddScoped<MeuDbContext>();
            services.AddScoped<IProdutoRepository, ProdutoRepository>();
            services.AddScoped<IFornecedorRepository, FornecedorRepository>();
            services.AddScoped<IEnderecoRepository, EnderecoRepository>();

            
            return services;
        }
    }
}
