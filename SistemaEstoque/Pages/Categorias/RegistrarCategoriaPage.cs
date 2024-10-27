namespace SistemaEstoque.Pages.Categorias;

public partial class RegistrarCategoriaPage : Form
{
    private readonly ICategoriaService categoriaService;

    public RegistrarCategoriaPage()
    {
        this.InitializeComponent();
        var context = new ApplicationDbContext();
        this.categoriaService = new CategoriaService(context);
    }

    private async void Btn_RegistrarCategoria_Click(object sender, EventArgs e)
    {
        if (!FormularioValido())
        {
            MessageBox.Show("Nome obrigatório.");
            return;
        }
        var novaCategoria = new CategoriaEntity(this.Input_NomeCategoria.Text, this.CheckBox_EmAtividade.Checked);
        await this.categoriaService.Registrar(novaCategoria);
        this.Close();
    }

    private bool FormularioValido()
    {
        var valido = !string.IsNullOrEmpty(this.Input_NomeCategoria.Text);
        return valido;
    }
}
