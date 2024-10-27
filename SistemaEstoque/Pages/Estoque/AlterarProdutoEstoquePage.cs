namespace SistemaEstoque.Pages.Estoque;

public partial class AlterarProdutoEstoquePage : Form
{
    private ProdutoEntity Produto { get; set; }
    private ApplicationDbContext Context;
    private IProdutoService ProdutoService;
    private IMovimentacaoService movimentacaoService;
    public AlterarProdutoEstoquePage(ProdutoEntity produto)
    {
        this.InitializeComponent();
        this.Produto = produto;
        var contexto = new ApplicationDbContext();
        this.Context = contexto;
        this.ProdutoService = new ProdutoService(this.Context);
        this.movimentacaoService = new MovimentacaoService(this.Context);
        this.Combo_TipoMov.DataSource = Enum.GetValues(typeof(TipoMovimentacaoENUM));
    }

    private async void BTN_AtualizarEstoque_Click(object sender, EventArgs e)
    {
        if (this.Produto is null)
            this.Close();

        var tipoMov = (TipoMovimentacaoENUM)this.Combo_TipoMov.SelectedItem!;

        var newEstoque = this.Produto!.Quantidade;

        switch (tipoMov)
        {
            case TipoMovimentacaoENUM.Entrada:
                newEstoque += decimal.Parse(this.Input_Estoque.Text);
                break;
            case TipoMovimentacaoENUM.Saida:
                newEstoque -= decimal.Parse(this.Input_Estoque.Text);
                break;
            case TipoMovimentacaoENUM.Balanco:
                newEstoque = decimal.Parse(this.Input_Estoque.Text);
                break;
            default:
                MessageBox.Show("Nenhum tipo selecionado");
                return;
        }
        var movimentacao = new MovimentacaoEntity(Produto.Id, tipoMov, this.Produto!.Quantidade, newEstoque);

        await this.movimentacaoService.Registrar(movimentacao);
        this.Produto!.Quantidade = newEstoque;
        await this.ProdutoService.Atualizar(this.Produto);

        this.Close();
    }
}
