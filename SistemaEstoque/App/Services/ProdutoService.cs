using Microsoft.EntityFrameworkCore.Query;
using System.Linq.Expressions;

namespace SistemaEstoque.App.Services;

public class ProdutoService : IProdutoService
{
    private readonly ApplicationDbContext context;
    public ProdutoService(ApplicationDbContext context)
    {
        this.context = context;
    }

    public async Task<ProdutoEntity> Atualizar(ProdutoEntity produto)
    {
        var attach = this.context.Produtos.Attach(produto);
        attach.State = EntityState.Modified;
        await this.context.SaveChangesAsync();
        return produto;
    }

    public async Task<int> ExecuteUpdateAsync(Expression<Func<ProdutoEntity, bool>> where, Expression<Func<SetPropertyCalls<ProdutoEntity>, SetPropertyCalls<ProdutoEntity>>> setPropertyCalls)
    {
        return await this.context.Produtos
            .Where(where)
            .ExecuteUpdateAsync(setPropertyCalls);
    }

    public async Task<ProdutoEntity?> ObterPorId(long id)
    {
        var produto = await this.context.Produtos.FirstOrDefaultAsync(x => x.Id == id);
        return produto;
    }

    public async Task<ProdutoEntity> Registrar(ProdutoEntity produto)
    {
        await this.context.Produtos.AddAsync(produto);
        await this.context.SaveChangesAsync();
        return produto;
    }

    public async Task<IEnumerable<ProdutoEntity>> Todos()
    {
        var produtos = await this.context.Produtos.ToListAsync();
        return produtos;
    }
}
