using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ROJINE.Application.UseCases.Produtos;
using ROJINE.Domain.Interfaces;
using ROJINE.Infrastructure.Context;
using ROJINE.Infrastructure.Repositories;

namespace ROJINE.IoC;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<ApplicationDbContext>(options =>
            options.UseInMemoryDatabase("RojineInMemoryDb")
        );

        services.AddScoped<IProdutoRepository, ProdutoRepository>();
        services.AddScoped<CriarProdutoUseCase>();

        return services;
    }
} 