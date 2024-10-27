namespace SistemaEstoque.Domain;

public class ProdutoEntity
{
    public ProdutoEntity() { }
    public ProdutoEntity(string nome, decimal preco, string gtin, decimal qtde, long categoriaId, decimal qtdeMin, decimal qtdeMax)
    {
        this.CriadoEm = DateTime.Now;
        this.Nome = nome;
        this.GTIN = gtin;
        this.Preco = preco;
        this.Quantidade = qtde;
        this.CategoriaId = categoriaId;
        this.QtdeMin = qtdeMin;
        this.QtdeMax = qtdeMax;
    }
    public long Id { get; set; }
    public DateTime CriadoEm { get; set; }
    public string? Nome { get; set; }
    public decimal Preco { get; set; }
    public decimal Quantidade { get; set; }
    public string? GTIN { get; set; }
    public decimal QtdeMin { get; set; }
    public decimal QtdeMax { get; set; }

    public long CategoriaId { get; set; }
    public CategoriaEntity? Categoria { get; set; }
    public List<MovimentacaoEntity> Movimentacoes { get; set; } = [];
}
