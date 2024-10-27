namespace SistemaEstoque.Pages.Produtos
{
    partial class RegistrarProdutoPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Button BTN_CadastrarProduto;
            Lbl_CadastrarProduto = new Label();
            ComboCategorias = new ComboBox();
            label1 = new Label();
            Input_Nome = new TextBox();
            label2 = new Label();
            Input_Qtde = new TextBox();
            label3 = new Label();
            label4 = new Label();
            Input_GTIN = new TextBox();
            label5 = new Label();
            Input_Preco = new TextBox();
            Input_QtdeMin = new TextBox();
            label6 = new Label();
            label7 = new Label();
            Input_QtdeMax = new TextBox();
            BTN_CadastrarProduto = new Button();
            SuspendLayout();
            // 
            // BTN_CadastrarProduto
            // 
            BTN_CadastrarProduto.Location = new Point(12, 278);
            BTN_CadastrarProduto.Name = "BTN_CadastrarProduto";
            BTN_CadastrarProduto.Size = new Size(690, 23);
            BTN_CadastrarProduto.TabIndex = 11;
            BTN_CadastrarProduto.Text = "Cadastrar";
            BTN_CadastrarProduto.UseVisualStyleBackColor = true;
            BTN_CadastrarProduto.Click += BTN_CadastrarProduto_Click;
            // 
            // Lbl_CadastrarProduto
            // 
            Lbl_CadastrarProduto.AutoSize = true;
            Lbl_CadastrarProduto.Font = new Font("Segoe UI", 16F);
            Lbl_CadastrarProduto.Location = new Point(12, 9);
            Lbl_CadastrarProduto.Name = "Lbl_CadastrarProduto";
            Lbl_CadastrarProduto.Size = new Size(244, 30);
            Lbl_CadastrarProduto.TabIndex = 0;
            Lbl_CadastrarProduto.Text = "Cadastrar novo Produto";
            // 
            // ComboCategorias
            // 
            ComboCategorias.FormattingEnabled = true;
            ComboCategorias.Location = new Point(12, 155);
            ComboCategorias.Name = "ComboCategorias";
            ComboCategorias.Size = new Size(690, 23);
            ComboCategorias.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 49);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 2;
            label1.Text = "Nome";
            // 
            // Input_Nome
            // 
            Input_Nome.Location = new Point(12, 67);
            Input_Nome.Name = "Input_Nome";
            Input_Nome.Size = new Size(342, 23);
            Input_Nome.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 137);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 4;
            label2.Text = "Categoria";
            // 
            // Input_Qtde
            // 
            Input_Qtde.Location = new Point(360, 67);
            Input_Qtde.Name = "Input_Qtde";
            Input_Qtde.Size = new Size(342, 23);
            Input_Qtde.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(360, 49);
            label3.Name = "label3";
            label3.Size = new Size(103, 15);
            label3.TabIndex = 6;
            label3.Text = "Quantidade inicial";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 93);
            label4.Name = "label4";
            label4.Size = new Size(97, 15);
            label4.TabIndex = 7;
            label4.Text = "Código de barras";
            // 
            // Input_GTIN
            // 
            Input_GTIN.Location = new Point(12, 111);
            Input_GTIN.Name = "Input_GTIN";
            Input_GTIN.Size = new Size(342, 23);
            Input_GTIN.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(360, 93);
            label5.Name = "label5";
            label5.Size = new Size(37, 15);
            label5.TabIndex = 9;
            label5.Text = "Preço";
            // 
            // Input_Preco
            // 
            Input_Preco.Location = new Point(360, 111);
            Input_Preco.Name = "Input_Preco";
            Input_Preco.Size = new Size(341, 23);
            Input_Preco.TabIndex = 10;
            // 
            // Input_QtdeMin
            // 
            Input_QtdeMin.Location = new Point(12, 199);
            Input_QtdeMin.Name = "Input_QtdeMin";
            Input_QtdeMin.Size = new Size(342, 23);
            Input_QtdeMin.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(14, 181);
            label6.Name = "label6";
            label6.Size = new Size(113, 15);
            label6.TabIndex = 13;
            label6.Text = "Quantidade minima";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(360, 181);
            label7.Name = "label7";
            label7.Size = new Size(115, 15);
            label7.TabIndex = 14;
            label7.Text = "Quantidade maxima";
            // 
            // Input_QtdeMax
            // 
            Input_QtdeMax.Location = new Point(360, 199);
            Input_QtdeMax.Name = "Input_QtdeMax";
            Input_QtdeMax.Size = new Size(341, 23);
            Input_QtdeMax.TabIndex = 15;
            // 
            // RegistrarProdutoPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(711, 313);
            Controls.Add(Input_QtdeMax);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(Input_QtdeMin);
            Controls.Add(BTN_CadastrarProduto);
            Controls.Add(Input_Preco);
            Controls.Add(label5);
            Controls.Add(Input_GTIN);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(Input_Qtde);
            Controls.Add(label2);
            Controls.Add(Input_Nome);
            Controls.Add(label1);
            Controls.Add(ComboCategorias);
            Controls.Add(Lbl_CadastrarProduto);
            Name = "RegistrarProdutoPage";
            Text = "Cadastrar produtos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Lbl_CadastrarProduto;
        private ComboBox ComboCategorias;
        private Label label1;
        private TextBox Input_Nome;
        private Label label2;
        private TextBox Input_Qtde;
        private Label label3;
        private Label label4;
        private TextBox Input_GTIN;
        private Label label5;
        private TextBox Input_Preco;
        private Button BTN_CadastrarProduto;
        private TextBox Input_QtdeMin;
        private Label label6;
        private Label label7;
        private TextBox Input_QtdeMax;
    }
}