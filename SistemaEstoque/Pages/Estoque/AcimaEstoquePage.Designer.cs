namespace SistemaEstoque.Pages.Estoque
{
    partial class AcimaEstoquePage
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
            List_Acima_Estoque = new ListView();
            label1 = new Label();
            BTN_Recarregar = new Button();
            SuspendLayout();
            // 
            // List_Acima_Estoque
            // 
            List_Acima_Estoque.Location = new Point(12, 42);
            List_Acima_Estoque.Name = "List_Acima_Estoque";
            List_Acima_Estoque.Size = new Size(776, 396);
            List_Acima_Estoque.TabIndex = 0;
            List_Acima_Estoque.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(278, 30);
            label1.TabIndex = 1;
            label1.Text = "Produtos acima do estoque";
            // 
            // BTN_Recarregar
            // 
            BTN_Recarregar.Location = new Point(713, 16);
            BTN_Recarregar.Name = "BTN_Recarregar";
            BTN_Recarregar.Size = new Size(75, 23);
            BTN_Recarregar.TabIndex = 2;
            BTN_Recarregar.Text = "Recarregar";
            BTN_Recarregar.UseVisualStyleBackColor = true;
            // 
            // AcimaEstoquePage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BTN_Recarregar);
            Controls.Add(label1);
            Controls.Add(List_Acima_Estoque);
            Name = "AcimaEstoquePage";
            Text = "AcimaEstoquePage";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView List_Acima_Estoque;
        private Label label1;
        private Button BTN_Recarregar;
    }
}