namespace SistemaEstoque.Pages.Estoque;

public partial class AbaixoEstoquePage : Form
{
    private IProdutoService produtoService;
    public AbaixoEstoquePage()
    {
        this.InitializeComponent();
        var context = new ApplicationDbContext();
        this.produtoService = new ProdutoService(context);
        this.ConfiguraListView();
        this.ObterProdutosAbaixoEstoque();
    }

    public async void ObterProdutosAbaixoEstoque()
    {
        this.List_Abaixo_Estoque.Items.Clear();
        var listaProdutos = await this.produtoService.Todos();

        foreach (var produto in listaProdutos)
        {
            if (produto.Quantidade < produto.QtdeMin)
            {
                var items = new ListViewItem(produto.Id.ToString());
                items.SubItems.Add(produto.Nome);
                items.SubItems.Add(produto.GTIN);
                items.SubItems.Add(produto.Preco.ToString());
                items.SubItems.Add(produto.QtdeMin.ToString());
                items.SubItems.Add(produto.Quantidade.ToString());
                this.List_Abaixo_Estoque.Items.Add(items);
            }
        }
    }
    public void ConfiguraListView()
    {
        // Configuração de Produtos
        this.List_Abaixo_Estoque.View = View.Details;
        this.List_Abaixo_Estoque.FullRowSelect = true;
        this.List_Abaixo_Estoque.GridLines = true;

        // Adiciona as colunas
        this.List_Abaixo_Estoque.Columns.Add("Id", 150);
        this.List_Abaixo_Estoque.Columns.Add("Nome", 150);
        this.List_Abaixo_Estoque.Columns.Add("GTIN", 150);
        this.List_Abaixo_Estoque.Columns.Add("Preço", 150);
        this.List_Abaixo_Estoque.Columns.Add("Qtde min", 150);
        this.List_Abaixo_Estoque.Columns.Add("Qtde", 150);
    }
}
