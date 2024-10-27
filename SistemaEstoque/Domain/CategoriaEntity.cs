namespace SistemaEstoque.Domain;

public class CategoriaEntity
{
    public CategoriaEntity() { }
    public CategoriaEntity(string nome, bool emAtividade)
    {
        this.Nome = nome;
        this.EmAtividade = emAtividade;
        this.CriadoEm = DateTime.Now;
    }
    public long Id { get; set; }
    public DateTime CriadoEm { get; set; }
    public string? Nome { get; set; }
    public bool EmAtividade { get; set; }
    public List<ProdutoEntity> Produtos { get; set; } = [];
}
