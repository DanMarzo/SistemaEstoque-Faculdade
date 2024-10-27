namespace SistemaEstoque
{
    partial class HomePage
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ListViewItem listViewItem1 = new ListViewItem("");
            TabsControl = new TabControl();
            TabProd = new TabPage();
            Btn_AcimaEstoque = new Button();
            Btn_AbaixoEstoque = new Button();
            BTN_RecarregarProd = new Button();
            BTN_CadastrarProduto = new Button();
            List_Produtos = new ListView();
            TabCateg = new TabPage();
            BTN_RecarregarCategorias = new Button();
            Btn_NovaCategoria = new Button();
            List_Categoria = new ListView();
            TabMov = new TabPage();
            BTN_RecarregarMov = new Button();
            List_MovEstoque = new ListView();
            TabsControl.SuspendLayout();
            TabProd.SuspendLayout();
            TabCateg.SuspendLayout();
            TabMov.SuspendLayout();
            SuspendLayout();
            // 
            // TabsControl
            // 
            TabsControl.Controls.Add(TabProd);
            TabsControl.Controls.Add(TabCateg);
            TabsControl.Controls.Add(TabMov);
            TabsControl.Location = new Point(2, 3);
            TabsControl.Name = "TabsControl";
            TabsControl.SelectedIndex = 0;
            TabsControl.Size = new Size(1056, 449);
            TabsControl.TabIndex = 0;
            // 
            // TabProd
            // 
            TabProd.Controls.Add(Btn_AcimaEstoque);
            TabProd.Controls.Add(Btn_AbaixoEstoque);
            TabProd.Controls.Add(BTN_RecarregarProd);
            TabProd.Controls.Add(BTN_CadastrarProduto);
            TabProd.Controls.Add(List_Produtos);
            TabProd.Location = new Point(4, 24);
            TabProd.Name = "TabProd";
            TabProd.Size = new Size(1048, 421);
            TabProd.TabIndex = 2;
            TabProd.Text = "Produtos";
            TabProd.UseVisualStyleBackColor = true;
            // 
            // Btn_AcimaEstoque
            // 
            Btn_AcimaEstoque.Location = new Point(417, 388);
            Btn_AcimaEstoque.Name = "Btn_AcimaEstoque";
            Btn_AcimaEstoque.Size = new Size(150, 23);
            Btn_AcimaEstoque.TabIndex = 4;
            Btn_AcimaEstoque.Text = "Acima do estoque";
            Btn_AcimaEstoque.UseVisualStyleBackColor = true;
            Btn_AcimaEstoque.Click += Btn_AcimaEstoque_Click;
            // 
            // Btn_AbaixoEstoque
            // 
            Btn_AbaixoEstoque.Location = new Point(283, 388);
            Btn_AbaixoEstoque.Name = "Btn_AbaixoEstoque";
            Btn_AbaixoEstoque.Size = new Size(128, 23);
            Btn_AbaixoEstoque.TabIndex = 3;
            Btn_AbaixoEstoque.Text = "Abaixo de estoque";
            Btn_AbaixoEstoque.UseVisualStyleBackColor = true;
            Btn_AbaixoEstoque.Click += Btn_AbaixoEstoque_Click;
            // 
            // BTN_RecarregarProd
            // 
            BTN_RecarregarProd.Location = new Point(6, 388);
            BTN_RecarregarProd.Name = "BTN_RecarregarProd";
            BTN_RecarregarProd.Size = new Size(133, 23);
            BTN_RecarregarProd.TabIndex = 2;
            BTN_RecarregarProd.Text = "Recarregar";
            BTN_RecarregarProd.UseVisualStyleBackColor = true;
            BTN_RecarregarProd.Click += BTN_RecarregarProd_Click;
            // 
            // BTN_CadastrarProduto
            // 
            BTN_CadastrarProduto.Location = new Point(145, 388);
            BTN_CadastrarProduto.Name = "BTN_CadastrarProduto";
            BTN_CadastrarProduto.Size = new Size(132, 23);
            BTN_CadastrarProduto.TabIndex = 1;
            BTN_CadastrarProduto.Text = "Novo Produto";
            BTN_CadastrarProduto.UseVisualStyleBackColor = true;
            BTN_CadastrarProduto.Click += BTN_CadastrarProduto_Click;
            // 
            // List_Produtos
            // 
            List_Produtos.Items.AddRange(new ListViewItem[] { listViewItem1 });
            List_Produtos.Location = new Point(3, 3);
            List_Produtos.MultiSelect = false;
            List_Produtos.Name = "List_Produtos";
            List_Produtos.Size = new Size(1042, 379);
            List_Produtos.TabIndex = 0;
            List_Produtos.UseCompatibleStateImageBehavior = false;
            List_Produtos.SelectedIndexChanged += List_Produtos_SelectedIndexChanged;
            // 
            // TabCateg
            // 
            TabCateg.Controls.Add(BTN_RecarregarCategorias);
            TabCateg.Controls.Add(Btn_NovaCategoria);
            TabCateg.Controls.Add(List_Categoria);
            TabCateg.Location = new Point(4, 24);
            TabCateg.Name = "TabCateg";
            TabCateg.Padding = new Padding(3);
            TabCateg.Size = new Size(1048, 421);
            TabCateg.TabIndex = 1;
            TabCateg.Text = "Categorias";
            TabCateg.UseVisualStyleBackColor = true;
            // 
            // BTN_RecarregarCategorias
            // 
            BTN_RecarregarCategorias.Location = new Point(6, 395);
            BTN_RecarregarCategorias.Name = "BTN_RecarregarCategorias";
            BTN_RecarregarCategorias.Size = new Size(75, 23);
            BTN_RecarregarCategorias.TabIndex = 2;
            BTN_RecarregarCategorias.Text = "Recarregar";
            BTN_RecarregarCategorias.UseVisualStyleBackColor = true;
            BTN_RecarregarCategorias.Click += BTN_RecarregarCategorias_Click;
            // 
            // Btn_NovaCategoria
            // 
            Btn_NovaCategoria.Location = new Point(87, 395);
            Btn_NovaCategoria.Name = "Btn_NovaCategoria";
            Btn_NovaCategoria.Size = new Size(107, 23);
            Btn_NovaCategoria.TabIndex = 1;
            Btn_NovaCategoria.Text = "Nova categoria";
            Btn_NovaCategoria.UseVisualStyleBackColor = true;
            Btn_NovaCategoria.Click += Btn_NovaCategoria_Click;
            // 
            // List_Categoria
            // 
            List_Categoria.Location = new Point(3, 6);
            List_Categoria.Name = "List_Categoria";
            List_Categoria.Size = new Size(1042, 377);
            List_Categoria.TabIndex = 0;
            List_Categoria.UseCompatibleStateImageBehavior = false;
            // 
            // TabMov
            // 
            TabMov.Controls.Add(BTN_RecarregarMov);
            TabMov.Controls.Add(List_MovEstoque);
            TabMov.Location = new Point(4, 24);
            TabMov.Name = "TabMov";
            TabMov.Size = new Size(1048, 421);
            TabMov.TabIndex = 3;
            TabMov.Text = "Movimentação";
            TabMov.UseVisualStyleBackColor = true;
            // 
            // BTN_RecarregarMov
            // 
            BTN_RecarregarMov.Location = new Point(3, 395);
            BTN_RecarregarMov.Name = "BTN_RecarregarMov";
            BTN_RecarregarMov.Size = new Size(75, 23);
            BTN_RecarregarMov.TabIndex = 1;
            BTN_RecarregarMov.Text = "Recarregar";
            BTN_RecarregarMov.UseVisualStyleBackColor = true;
            BTN_RecarregarMov.Click += BTN_RecarregarMov_Click;
            // 
            // List_MovEstoque
            // 
            List_MovEstoque.Location = new Point(3, 3);
            List_MovEstoque.Name = "List_MovEstoque";
            List_MovEstoque.Size = new Size(1042, 381);
            List_MovEstoque.TabIndex = 0;
            List_MovEstoque.UseCompatibleStateImageBehavior = false;
            // 
            // HomePage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1056, 450);
            Controls.Add(TabsControl);
            Name = "HomePage";
            Text = "Estoque";
            TabsControl.ResumeLayout(false);
            TabProd.ResumeLayout(false);
            TabCateg.ResumeLayout(false);
            TabMov.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl TabsControl;
        private TabPage TabCateg;
        private TabPage TabProd;
        private Button BTN_CadastrarProduto;
        private Button Btn_NovaCategoria;
        private Button BTN_RecarregarProd;
        private Button BTN_RecarregarCategorias;
        private TabPage TabMov;
        private Button BTN_RecarregarMov;


        private ListView List_Categoria;
        private ListView List_Produtos;
        private ListView List_MovEstoque;
        private Button Btn_AbaixoEstoque;
        private Button Btn_AcimaEstoque;
    }
}
