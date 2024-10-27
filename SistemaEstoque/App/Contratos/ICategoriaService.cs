namespace SistemaEstoque.App.Contratos;

public interface ICategoriaService
{
    Task<CategoriaEntity> Registrar(CategoriaEntity categoria);
    Task<IEnumerable<CategoriaEntity>> Todos();
    Task<CategoriaEntity?> ObterPorId(long id);
}
