namespace SistemaEstoque.Pages.Produtos;

public partial class RegistrarProdutoPage : Form
{
    private readonly IProdutoService produtoService;
    private readonly ICategoriaService categoriaService;
    public RegistrarProdutoPage()
    {
        this.InitializeComponent();
        var context = new ApplicationDbContext();
        this.produtoService = new ProdutoService(context);
        this.categoriaService = new CategoriaService(context);
        this.ObterCategoria();
    }

    public async void ObterCategoria()
    {
        var categorias = await this.categoriaService.Todos();
        if (!categorias.Any())
        {
            MessageBox.Show("Nenhuma categoria localizada.", Name = "Alerta");
            this.Close();
            return;
        }
        this.ComboCategorias.DataSource = categorias;
        this.ComboCategorias.DisplayMember = "Nome";
        this.ComboCategorias.ValueMember = "Id";
    }

    private async void BTN_CadastrarProduto_Click(object sender, EventArgs e)
    {
        var categoria = (CategoriaEntity?)this.ComboCategorias.SelectedItem;
        if (!this.ValidateCampos() || categoria is null)
        {
            MessageBox.Show("Campos invalidos");
            return;
        }
        var produto = new ProdutoEntity(
            this.Input_Nome.Text, 
            decimal.Parse(this.Input_Preco.Text), 
            this.Input_GTIN.Text, 
            decimal.Parse(this.Input_Qtde.Text), 
            categoria.Id,
            decimal.Parse(this.Input_QtdeMin.Text),
            decimal.Parse(this.Input_QtdeMax.Text)
            );
        await this.produtoService.Registrar(produto);
        this.Close();
    }

    private bool ValidateCampos()
    {
        var valido = !string.IsNullOrEmpty(this.Input_GTIN.Text);
        valido = !string.IsNullOrEmpty(this.Input_Nome.Text);
        valido = decimal.TryParse(this.Input_Qtde.Text, out decimal valueQtde);
        valido = decimal.TryParse(this.Input_Preco.Text, out decimal valuePreco);
        valido = decimal.TryParse(this.Input_QtdeMax.Text, out decimal valueQtdeMin);
        valido = decimal.TryParse(this.Input_QtdeMin.Text, out decimal valueQtdeMax);
        return valido;
    }

}
