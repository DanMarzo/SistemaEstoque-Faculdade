namespace SistemaEstoque.App.Services;

public class CategoriaService : ICategoriaService
{
    private readonly ApplicationDbContext context;
    public CategoriaService(ApplicationDbContext context)
    {
        this.context = context;
    }

    public async Task<CategoriaEntity?> ObterPorId(long id)
    {
        var categoria = await this.context.Categorias.FirstOrDefaultAsync(x => x.Id == id);
        return categoria;
    }

    public async Task<CategoriaEntity> Registrar(CategoriaEntity categoria)
    {
        await this.context.Categorias.AddAsync(categoria);
        await this.context.SaveChangesAsync();
        return categoria;
    }

    public async Task<IEnumerable<CategoriaEntity>> Todos()
    {
        var categorias = await this.context.Categorias.ToListAsync();
        return categorias;
    }
}
