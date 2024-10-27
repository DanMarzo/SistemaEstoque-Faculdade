using SistemaEstoque.App.Services;

namespace SistemaEstoque.App;

public static class RegisterApp
{
    public static IServiceCollection AddAppServices(this IServiceCollection services)
    {
        services.AddTransient<IProdutoService, ProdutoService>();
        services.AddTransient<ICategoriaService, CategoriaService>();
        services.AddTransient<IMovimentacaoService, MovimentacaoService>();
        return services;
    }
}