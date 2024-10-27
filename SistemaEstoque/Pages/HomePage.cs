using SistemaEstoque.Pages.Estoque;

namespace SistemaEstoque;

public partial class HomePage : Form
{
    private readonly IProdutoService produtoService;
    private readonly ICategoriaService categoriaService;
    private readonly IMovimentacaoService movimentacaoService;
    public HomePage()
    {
        this.InitializeComponent();
        var context = new ApplicationDbContext();
        this.produtoService = new ProdutoService(context);
        this.categoriaService = new CategoriaService(context);
        this.movimentacaoService = new MovimentacaoService(context);
        this.ConfiguraListView();
        this.ObterProdutos();
    }

    private void BTN_CadastrarProduto_Click(object sender, EventArgs e)
    {
        using var registrarProdutoPage = new RegistrarProdutoPage();
        registrarProdutoPage.ShowDialog();
    }
    private void Btn_NovaCategoria_Click(object sender, EventArgs e)
    {
        using var registrarCategoria = new RegistrarCategoriaPage();
        registrarCategoria.ShowDialog();
    }

    private async void ObterProdutos()
    {
        this.List_Produtos.Items.Clear();
        var listaProdutos = await this.produtoService.Todos();
        foreach (var produto in listaProdutos)
        {
            var items = new ListViewItem(produto.Id.ToString());
            items.SubItems.Add(produto.Nome);
            items.SubItems.Add(produto.GTIN);
            items.SubItems.Add(produto.Preco.ToString());
            items.SubItems.Add(produto.Quantidade.ToString());
            items.SubItems.Add(produto.QtdeMin.ToString());
            items.SubItems.Add(produto.QtdeMax.ToString());
            this.List_Produtos.Items.Add(items);
        }
    }

    public void ConfiguraListView()
    {
        // Configuração de Produtos
        this.List_Produtos.View = View.Details;
        this.List_Produtos.FullRowSelect = true;
        this.List_Produtos.GridLines = true;

        // Adiciona as colunas
        this.List_Produtos.Columns.Add("Id", 150);
        this.List_Produtos.Columns.Add("Nome", 150);
        this.List_Produtos.Columns.Add("GTIN", 150);
        this.List_Produtos.Columns.Add("Preço", 150);
        this.List_Produtos.Columns.Add("Qtde", 150);
        this.List_Produtos.Columns.Add("Qtde min", 150);
        this.List_Produtos.Columns.Add("Qtde max", 150);

        // Configuração de Categoria
        this.List_Categoria.View = View.Details;
        this.List_Categoria.FullRowSelect = true;
        this.List_Categoria.GridLines = true;

        this.List_Categoria.Columns.Add("Id", 150);
        this.List_Categoria.Columns.Add("Nome", 150);
        this.List_Categoria.Columns.Add("Em Atividade", 150);

        // Configuração de Movimentacao
        this.List_MovEstoque.View = View.Details;
        this.List_MovEstoque.FullRowSelect = true;
        this.List_MovEstoque.GridLines = true;

        this.List_MovEstoque.Columns.Add("Id", 150);
        this.List_MovEstoque.Columns.Add("Produto id", 150);
        this.List_MovEstoque.Columns.Add("Tipo", 150);
        this.List_MovEstoque.Columns.Add("Saldo Antigo", 150);
        this.List_MovEstoque.Columns.Add("Saldo Novo", 150);
        this.List_MovEstoque.Columns.Add("Criado em", 150);

    }

    private void BTN_RecarregarProd_Click(object sender, EventArgs e)
    {
        this.List_Produtos.Items.Clear();
        this.ObterProdutos();
    }
    private async void List_Produtos_SelectedIndexChanged(object sender, EventArgs e)
    {
        // Verifica se algum item foi selecionado
        if (List_Produtos.SelectedItems.Count > 0)
        {
            ListViewItem itemSelecionado = List_Produtos.SelectedItems[0];
            string idProduto = itemSelecionado.Text;

            var produto = await this.produtoService.ObterPorId(long.Parse(idProduto));
            if (produto is null)
            {
                MessageBox.Show("Não foi possível encontrar o produto.");
                return;
            }
            var estoqueForm = new AlterarProdutoEstoquePage(produto);
            estoqueForm.ShowDialog();
        }
    }

    private async void BTN_RecarregarCategorias_Click(object sender, EventArgs e)
    {
        this.List_Categoria.Items.Clear();
        var listaCategorias = await this.categoriaService.Todos();
        foreach (var categoria in listaCategorias)
        {
            var items = new ListViewItem(categoria.Id.ToString());
            items.SubItems.Add(categoria.Nome);
            items.SubItems.Add(categoria.EmAtividade.ToString());
            this.List_Categoria.Items.Add(items);
        }
    }

    private async void BTN_RecarregarMov_Click(object sender, EventArgs e)
    {
        this.List_MovEstoque.Items.Clear();
        var listaMovimentacao = await this.movimentacaoService.Todos();
        foreach (var movimentacao in listaMovimentacao)
        {
            var items = new ListViewItem(movimentacao.Id.ToString());
            items.SubItems.Add(movimentacao.ProdutoId.ToString());
            items.SubItems.Add(movimentacao.Tipo.ToString());
            items.SubItems.Add(movimentacao.SaldoAntigo.ToString());
            items.SubItems.Add(movimentacao.SaldoNovo.ToString());
            items.SubItems.Add(movimentacao.CriadoEm.ToString());
            this.List_MovEstoque.Items.Add(items);
        }
    }

    private void Btn_AbaixoEstoque_Click(object sender, EventArgs e)
    {
        var abaixoEstoqueProdutoPage = new AbaixoEstoquePage();
        abaixoEstoqueProdutoPage.ShowDialog();
    }

    private void Btn_AcimaEstoque_Click(object sender, EventArgs e)
    {
        var acimaEstoqueProdutoPage = new AcimaEstoquePage();
        acimaEstoqueProdutoPage.ShowDialog();
    }
}
