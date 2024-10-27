using Microsoft.EntityFrameworkCore.Query;
using System.Linq.Expressions;

namespace SistemaEstoque.App.Contratos;

public interface IProdutoService
{
    Task<ProdutoEntity> Registrar(ProdutoEntity produto);
    Task<IEnumerable<ProdutoEntity>> Todos();
    Task<ProdutoEntity?> ObterPorId(long id);
    Task<ProdutoEntity> Atualizar(ProdutoEntity produto);
    Task<int> ExecuteUpdateAsync(Expression<Func<ProdutoEntity, bool>> where, Expression<Func<SetPropertyCalls<ProdutoEntity>, SetPropertyCalls<ProdutoEntity>>> setPropertyCalls);
}

