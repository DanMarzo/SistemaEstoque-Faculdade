using System.ComponentModel;

namespace SistemaEstoque.Domain;

public class MovimentacaoEntity
{
    public MovimentacaoEntity() { }
    public MovimentacaoEntity(long produtoId, TipoMovimentacaoENUM tipo, decimal saldoAntigo, decimal saldoNovo)
    {
        this.CriadoEm = DateTime.Now;
        this.ProdutoId = produtoId;
        this.Tipo = tipo;
        this.SaldoNovo = saldoNovo;
        this.SaldoAntigo = saldoAntigo;
    }
    public long Id { get; set; }
    public DateTime CriadoEm { get; set; }
    public TipoMovimentacaoENUM Tipo { get; set; }
    public long ProdutoId { get; set; }
    public decimal SaldoAntigo { get; set; }
    public decimal SaldoNovo { get; set; }
    public ProdutoEntity Produto { get; set; }
}

public enum TipoMovimentacaoENUM
{
    [Description("Entrada")]
    Entrada = 0,
    [Description("Saída")]
    Saida = 1,
    [Description("Balanço")]
    Balanco = 2
}