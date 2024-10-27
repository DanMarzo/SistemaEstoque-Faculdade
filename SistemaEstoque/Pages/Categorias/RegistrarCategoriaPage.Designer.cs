namespace SistemaEstoque.Pages.Categorias
{
    partial class RegistrarCategoriaPage
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
            Lbl_RegistrarCategoria = new Label();
            label1 = new Label();
            Input_NomeCategoria = new TextBox();
            CheckBox_EmAtividade = new CheckBox();
            Btn_RegistrarCategoria = new Button();
            SuspendLayout();
            // 
            // Lbl_RegistrarCategoria
            // 
            Lbl_RegistrarCategoria.AutoSize = true;
            Lbl_RegistrarCategoria.Font = new Font("Segoe UI", 16F);
            Lbl_RegistrarCategoria.Location = new Point(12, 9);
            Lbl_RegistrarCategoria.Name = "Lbl_RegistrarCategoria";
            Lbl_RegistrarCategoria.Size = new Size(258, 30);
            Lbl_RegistrarCategoria.TabIndex = 0;
            Lbl_RegistrarCategoria.Text = "Cadastrar nova Categoria";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 53);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 1;
            label1.Text = "Nome";
            // 
            // Input_NomeCategoria
            // 
            Input_NomeCategoria.Location = new Point(12, 71);
            Input_NomeCategoria.Name = "Input_NomeCategoria";
            Input_NomeCategoria.Size = new Size(191, 23);
            Input_NomeCategoria.TabIndex = 2;
            // 
            // CheckBox_EmAtividade
            // 
            CheckBox_EmAtividade.AutoSize = true;
            CheckBox_EmAtividade.Location = new Point(209, 73);
            CheckBox_EmAtividade.Name = "CheckBox_EmAtividade";
            CheckBox_EmAtividade.Size = new Size(96, 19);
            CheckBox_EmAtividade.TabIndex = 3;
            CheckBox_EmAtividade.Text = "Em Atividade";
            CheckBox_EmAtividade.UseVisualStyleBackColor = true;
            // 
            // Btn_RegistrarCategoria
            // 
            Btn_RegistrarCategoria.Location = new Point(12, 116);
            Btn_RegistrarCategoria.Name = "Btn_RegistrarCategoria";
            Btn_RegistrarCategoria.Size = new Size(342, 23);
            Btn_RegistrarCategoria.TabIndex = 4;
            Btn_RegistrarCategoria.Text = "Cadastrar";
            Btn_RegistrarCategoria.UseVisualStyleBackColor = true;
            Btn_RegistrarCategoria.Click += Btn_RegistrarCategoria_Click;
            // 
            // RegistrarCategoriaPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(366, 151);
            Controls.Add(Btn_RegistrarCategoria);
            Controls.Add(CheckBox_EmAtividade);
            Controls.Add(Input_NomeCategoria);
            Controls.Add(label1);
            Controls.Add(Lbl_RegistrarCategoria);
            Name = "RegistrarCategoriaPage";
            Text = "Registrar categoria";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Lbl_RegistrarCategoria;
        private Label label1;
        private TextBox Input_NomeCategoria;
        private CheckBox CheckBox_EmAtividade;
        private Button Btn_RegistrarCategoria;
    }
}