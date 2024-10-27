namespace SistemaEstoque.App.Contratos;

public interface IMovimentacaoService
{
    Task<MovimentacaoEntity> Registrar(MovimentacaoEntity movimentacao);
    Task<IEnumerable<MovimentacaoEntity>> Todos();
    Task<MovimentacaoEntity?> ObterPorId(long id);
}
