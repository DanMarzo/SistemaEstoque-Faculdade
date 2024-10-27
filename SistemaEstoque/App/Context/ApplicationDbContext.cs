namespace SistemaEstoque.App.Context;

public class ApplicationDbContext : DbContext
{
    //public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
    public DbSet<CategoriaEntity> Categorias { get; set; }
    public DbSet<ProdutoEntity> Produtos { get; set; }
    public DbSet<MovimentacaoEntity> Movimentacoes { get; set; }


    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseInMemoryDatabase("DatabaseEstoque");
        base.OnConfiguring(optionsBuilder);
    }
}
