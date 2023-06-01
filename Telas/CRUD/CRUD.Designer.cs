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
            BtnSalvar = new Button();
            BtnEditar = new Button();
            BtnExcluir = new Button();
            BtnFechar = new Button();
            SuspendLayout();
            // 
            // BtnSalvar
            // 
            BtnSalvar.Anchor = AnchorStyles.None;
            BtnSalvar.BackgroundImage = Properties.Resources.Screenshot_1;
            BtnSalvar.BackgroundImageLayout = ImageLayout.Stretch;
            BtnSalvar.Location = new Point(20, 12);
            BtnSalvar.Name = "BtnSalvar";
            BtnSalvar.Size = new Size(98, 40);
            BtnSalvar.TabIndex = 0;
            BtnSalvar.Text = "SALVAR";
            BtnSalvar.UseVisualStyleBackColor = true;
            BtnSalvar.Click += Btn12_Salvar_Click;
            // 
            // BtnEditar
            // 
            BtnEditar.Anchor = AnchorStyles.None;
            BtnEditar.BackgroundImage = Properties.Resources.Screenshot_1;
            BtnEditar.BackgroundImageLayout = ImageLayout.Stretch;
            BtnEditar.Location = new Point(124, 11);
            BtnEditar.Name = "BtnEditar";
            BtnEditar.Size = new Size(98, 41);
            BtnEditar.TabIndex = 1;
            BtnEditar.Text = "EDITAR";
            BtnEditar.UseVisualStyleBackColor = true;
            // 
            // BtnExcluir
            // 
            BtnExcluir.Anchor = AnchorStyles.None;
            BtnExcluir.BackgroundImage = Properties.Resources.Screenshot_1;
            BtnExcluir.BackgroundImageLayout = ImageLayout.Stretch;
            BtnExcluir.Location = new Point(228, 12);
            BtnExcluir.Name = "BtnExcluir";
            BtnExcluir.Size = new Size(98, 40);
            BtnExcluir.TabIndex = 2;
            BtnExcluir.Text = "EXCLUIR";
            BtnExcluir.UseVisualStyleBackColor = true;
            // 
            // BtnFechar
            // 
            BtnFechar.Anchor = AnchorStyles.None;
            BtnFechar.BackgroundImage = Properties.Resources.Screenshot_1;
            BtnFechar.BackgroundImageLayout = ImageLayout.Stretch;
            BtnFechar.ForeColor = SystemColors.Info;
            BtnFechar.Location = new Point(332, 12);
            BtnFechar.Name = "BtnFechar";
            BtnFechar.Size = new Size(98, 40);
            BtnFechar.TabIndex = 3;
            BtnFechar.Text = "FECHAR";
            BtnFechar.UseVisualStyleBackColor = true;
            // 
            // CRUD
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Desktop;
            Controls.Add(BtnFechar);
            Controls.Add(BtnExcluir);
            Controls.Add(BtnEditar);
            Controls.Add(BtnSalvar);
            ForeColor = SystemColors.Info;
            Name = "CRUD";
            Size = new Size(451, 65);
            ResumeLayout(false);
        }

        #endregion

        public Button BtnSalvar;
        public Button BtnEditar;
        public Button BtnExcluir;
        public Button BtnFechar;
    }
}
