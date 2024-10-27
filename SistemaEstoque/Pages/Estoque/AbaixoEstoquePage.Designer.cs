namespace SistemaEstoque.Pages.Estoque
{
    partial class AbaixoEstoquePage
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
            List_Abaixo_Estoque = new ListView();
            label1 = new Label();
            Btn_Recarregar = new Button();
            SuspendLayout();
            // 
            // List_Abaixo_Estoque
            // 
            List_Abaixo_Estoque.Location = new Point(12, 42);
            List_Abaixo_Estoque.Name = "List_Abaixo_Estoque";
            List_Abaixo_Estoque.Size = new Size(776, 396);
            List_Abaixo_Estoque.TabIndex = 0;
            List_Abaixo_Estoque.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(285, 30);
            label1.TabIndex = 1;
            label1.Text = "Produtos abaixo do estoque";
            // 
            // Btn_Recarregar
            // 
            Btn_Recarregar.Location = new Point(713, 17);
            Btn_Recarregar.Name = "Btn_Recarregar";
            Btn_Recarregar.Size = new Size(75, 23);
            Btn_Recarregar.TabIndex = 2;
            Btn_Recarregar.Text = "Recarregar";
            Btn_Recarregar.UseVisualStyleBackColor = true;
            // 
            // AbaixoEstoquePage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Btn_Recarregar);
            Controls.Add(label1);
            Controls.Add(List_Abaixo_Estoque);
            Name = "AbaixoEstoquePage";
            Text = "AbaixoEstoquePage";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView List_Abaixo_Estoque;
        private Label label1;
        private Button Btn_Recarregar;
    }
}