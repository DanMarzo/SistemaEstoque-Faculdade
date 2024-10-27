namespace SistemaEstoque.Pages.Estoque
{
    partial class AlterarProdutoEstoquePage
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
            label1 = new Label();
            Input_Estoque = new TextBox();
            LBL_NovoEstoque = new Label();
            BTN_AtualizarEstoque = new Button();
            Combo_TipoMov = new ComboBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(162, 30);
            label1.TabIndex = 0;
            label1.Text = "Alterar estoque";
            // 
            // Input_Estoque
            // 
            Input_Estoque.Location = new Point(12, 69);
            Input_Estoque.Name = "Input_Estoque";
            Input_Estoque.Size = new Size(241, 23);
            Input_Estoque.TabIndex = 1;
            // 
            // LBL_NovoEstoque
            // 
            LBL_NovoEstoque.AutoSize = true;
            LBL_NovoEstoque.Location = new Point(12, 51);
            LBL_NovoEstoque.Name = "LBL_NovoEstoque";
            LBL_NovoEstoque.Size = new Size(81, 15);
            LBL_NovoEstoque.TabIndex = 2;
            LBL_NovoEstoque.Text = "Novo Estoque";
            // 
            // BTN_AtualizarEstoque
            // 
            BTN_AtualizarEstoque.Location = new Point(443, 69);
            BTN_AtualizarEstoque.Name = "BTN_AtualizarEstoque";
            BTN_AtualizarEstoque.Size = new Size(75, 23);
            BTN_AtualizarEstoque.TabIndex = 3;
            BTN_AtualizarEstoque.Text = "Atualizar Estoque";
            BTN_AtualizarEstoque.UseVisualStyleBackColor = true;
            BTN_AtualizarEstoque.Click += BTN_AtualizarEstoque_Click;
            // 
            // Combo_TipoMov
            // 
            Combo_TipoMov.FormattingEnabled = true;
            Combo_TipoMov.Location = new Point(259, 69);
            Combo_TipoMov.Name = "Combo_TipoMov";
            Combo_TipoMov.Size = new Size(178, 23);
            Combo_TipoMov.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(259, 51);
            label2.Name = "label2";
            label2.Size = new Size(30, 15);
            label2.TabIndex = 5;
            label2.Text = "Tipo";
            // 
            // AlterarProdutoEstoquePage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(530, 95);
            Controls.Add(label2);
            Controls.Add(Combo_TipoMov);
            Controls.Add(BTN_AtualizarEstoque);
            Controls.Add(LBL_NovoEstoque);
            Controls.Add(Input_Estoque);
            Controls.Add(label1);
            Name = "AlterarProdutoEstoquePage";
            Text = "AlterarProdutoEstoquePage";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox Input_Estoque;
        private Label LBL_NovoEstoque;
        private Button BTN_AtualizarEstoque;
        private ComboBox Combo_TipoMov;
        private Label label2;
    }
}