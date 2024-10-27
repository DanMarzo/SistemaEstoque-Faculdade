namespace SistemaEstoque.App.Services;

public class MovimentacaoService : IMovimentacaoService
{
    private readonly ApplicationDbContext context;
    public MovimentacaoService(ApplicationDbContext context)
    {
        this.context = context;
    }

    public async Task<MovimentacaoEntity?> ObterPorId(long id)
    {
        var movimentacao = await this.context.Movimentacoes.FirstOrDefaultAsync(x => x.Id == id);
        return movimentacao;
    }
    public async Task<MovimentacaoEntity> Registrar(MovimentacaoEntity movimentacao)
    {
        await this.context.Movimentacoes.AddAsync(movimentacao);
        await this.context.SaveChangesAsync();
        return movimentacao;
    }

    public async Task<IEnumerable<MovimentacaoEntity>> Todos()
    {
        var movimentacao = await this.context.Movimentacoes.ToListAsync();
        return movimentacao;
    }
}
