namespace PizzariaDoZe
{
    partial class CRUD
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            Btn12_Salvar = new Button();
            Btn12_Editar = new Button();
            Btn12_Excluir = new Button();
            Btn12_Fechar = new Button();
            SuspendLayout();
            // 
            // Btn12_Salvar
            // 
            Btn12_Salvar.BackgroundImage = Properties.Resources.Screenshot_1;
            Btn12_Salvar.BackgroundImageLayout = ImageLayout.Stretch;
            Btn12_Salvar.Location = new Point(22, 9);
            Btn12_Salvar.Name = "Btn12_Salvar";
            Btn12_Salvar.Size = new Size(99, 41);
            Btn12_Salvar.TabIndex = 0;
            Btn12_Salvar.Text = "SALVAR";
            Btn12_Salvar.UseVisualStyleBackColor = true;
            // 
            // Btn12_Editar
            // 
            Btn12_Editar.BackgroundImage = Properties.Resources.Screenshot_1;
            Btn12_Editar.BackgroundImageLayout = ImageLayout.Stretch;
            Btn12_Editar.Location = new Point(126, 10);
            Btn12_Editar.Name = "Btn12_Editar";
            Btn12_Editar.Size = new Size(99, 41);
            Btn12_Editar.TabIndex = 1;
            Btn12_Editar.Text = "EDITAR";
            Btn12_Editar.UseVisualStyleBackColor = true;
            // 
            // Btn12_Excluir
            // 
            Btn12_Excluir.BackgroundImage = Properties.Resources.Screenshot_1;
            Btn12_Excluir.BackgroundImageLayout = ImageLayout.Stretch;
            Btn12_Excluir.Location = new Point(230, 11);
            Btn12_Excluir.Name = "Btn12_Excluir";
            Btn12_Excluir.Size = new Size(99, 41);
            Btn12_Excluir.TabIndex = 2;
            Btn12_Excluir.Text = "EXCLUIR";
            Btn12_Excluir.UseVisualStyleBackColor = true;
            // 
            // Btn12_Fechar
            // 
            Btn12_Fechar.BackgroundImage = Properties.Resources.Screenshot_1;
            Btn12_Fechar.BackgroundImageLayout = ImageLayout.Stretch;
            Btn12_Fechar.ForeColor = SystemColors.Info;
            Btn12_Fechar.Location = new Point(335, 11);
            Btn12_Fechar.Name = "Btn12_Fechar";
            Btn12_Fechar.Size = new Size(99, 41);
            Btn12_Fechar.TabIndex = 3;
            Btn12_Fechar.Text = "FECHAR";
            Btn12_Fechar.UseVisualStyleBackColor = true;
            // 
            // CRUD
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Desktop;
            Controls.Add(Btn12_Fechar);
            Controls.Add(Btn12_Excluir);
            Controls.Add(Btn12_Editar);
            Controls.Add(Btn12_Salvar);
            ForeColor = SystemColors.Info;
            Name = "CRUD";
            Size = new Size(452, 65);
            ResumeLayout(false);
        }

        #endregion

        private Button Btn12_Salvar;
        private Button Btn12_Editar;
        private Button Btn12_Excluir;
        private Button Btn12_Fechar;
    }
}
