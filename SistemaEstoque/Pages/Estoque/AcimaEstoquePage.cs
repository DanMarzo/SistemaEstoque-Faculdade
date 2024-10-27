namespace SistemaEstoque.Pages.Estoque;

public partial class AcimaEstoquePage : Form
{
    private IProdutoService produtoService;
    public AcimaEstoquePage()
    {
        this.InitializeComponent();
        var context = new ApplicationDbContext();
        this.produtoService = new ProdutoService(context);
        this.ConfiguraListView();
        this.ObterProdutosAcimaEstoque();
    }

    public async void ObterProdutosAcimaEstoque()
    {
        this.List_Acima_Estoque.Items.Clear();
        var listaProdutos = await this.produtoService.Todos();

        foreach (var produto in listaProdutos)
        {
            if (produto.Quantidade > produto.QtdeMax)
            {
                var items = new ListViewItem(produto.Id.ToString());
                items.SubItems.Add(produto.Nome);
                items.SubItems.Add(produto.GTIN);
                items.SubItems.Add(produto.Preco.ToString());
                items.SubItems.Add(produto.QtdeMax.ToString());
                items.SubItems.Add(produto.Quantidade.ToString());
                this.List_Acima_Estoque.Items.Add(items);
            }
        }
    }

    public void ConfiguraListView()
    {
        // Configuração de Produtos
        this.List_Acima_Estoque.View = View.Details;
        this.List_Acima_Estoque.FullRowSelect = true;
        this.List_Acima_Estoque.GridLines = true;

        // Adiciona as colunas
        this.List_Acima_Estoque.Columns.Add("Id", 150);
        this.List_Acima_Estoque.Columns.Add("Nome", 150);
        this.List_Acima_Estoque.Columns.Add("GTIN", 150);
        this.List_Acima_Estoque.Columns.Add("Preço", 150);
        this.List_Acima_Estoque.Columns.Add("Qtde max", 150);
        this.List_Acima_Estoque.Columns.Add("Qtde", 150);
    }
}
