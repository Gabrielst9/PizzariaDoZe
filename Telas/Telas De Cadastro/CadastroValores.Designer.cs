namespace PizzariaDoZe
{
    partial class CadastroValores
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
            TIT12_CADASTRAR = new Label();
            TextBoxValorBorda = new TextBox();
            TextBoxValor = new TextBox();
            Text_9_Valor = new Label();
            Text_9_Valores_Adicionais = new Label();
            listBoxTamanhos = new ListBox();
            Text_9_Tamanhos = new Label();
            listBoxCategorias = new ListBox();
            Text_9_Categorias = new Label();
            Btn_9_Sair = new Button();
            Pnl_9_Valores = new Panel();
            TextBoxId = new TextBox();
            TextID = new Label();
            CrudValores = new CRUD();
            Pnl_9_Valores.SuspendLayout();
            SuspendLayout();
            // 
            // TIT12_CADASTRAR
            // 
            TIT12_CADASTRAR.AutoSize = true;
            TIT12_CADASTRAR.BackColor = SystemColors.ActiveCaptionText;
            TIT12_CADASTRAR.Font = new Font("Copperplate Gothic Bold", 36F, FontStyle.Regular, GraphicsUnit.Point);
            TIT12_CADASTRAR.ForeColor = SystemColors.Info;
            TIT12_CADASTRAR.Image = Properties.Resources.Screenshot_1;
            TIT12_CADASTRAR.Location = new Point(367, 29);
            TIT12_CADASTRAR.Name = "TIT12_CADASTRAR";
            TIT12_CADASTRAR.Size = new Size(638, 53);
            TIT12_CADASTRAR.TabIndex = 6;
            TIT12_CADASTRAR.Text = "CADASTRAR VALORES";
            // 
            // TextBoxValorBorda
            // 
            TextBoxValorBorda.Location = new Point(46, 196);
            TextBoxValorBorda.Name = "TextBoxValorBorda";
            TextBoxValorBorda.Size = new Size(319, 25);
            TextBoxValorBorda.TabIndex = 1;
            // 
            // TextBoxValor
            // 
            TextBoxValor.Location = new Point(46, 121);
            TextBoxValor.Name = "TextBoxValor";
            TextBoxValor.Size = new Size(319, 25);
            TextBoxValor.TabIndex = 0;
            // 
            // Text_9_Valor
            // 
            Text_9_Valor.AutoSize = true;
            Text_9_Valor.BackColor = Color.Transparent;
            Text_9_Valor.ForeColor = SystemColors.Info;
            Text_9_Valor.Location = new Point(46, 100);
            Text_9_Valor.Name = "Text_9_Valor";
            Text_9_Valor.Size = new Size(71, 18);
            Text_9_Valor.TabIndex = 9;
            Text_9_Valor.Text = "VALOR";
            // 
            // Text_9_Valores_Adicionais
            // 
            Text_9_Valores_Adicionais.AutoSize = true;
            Text_9_Valores_Adicionais.BackColor = Color.Transparent;
            Text_9_Valores_Adicionais.ForeColor = SystemColors.Info;
            Text_9_Valores_Adicionais.Location = new Point(46, 175);
            Text_9_Valores_Adicionais.Name = "Text_9_Valores_Adicionais";
            Text_9_Valores_Adicionais.Size = new Size(246, 18);
            Text_9_Valores_Adicionais.TabIndex = 10;
            Text_9_Valores_Adicionais.Text = "VALOR ADICIONAL BORDA";
            // 
            // listBoxTamanhos
            // 
            listBoxTamanhos.BackColor = SystemColors.Desktop;
            listBoxTamanhos.ForeColor = SystemColors.Info;
            listBoxTamanhos.FormattingEnabled = true;
            listBoxTamanhos.ItemHeight = 18;
            listBoxTamanhos.Items.AddRange(new object[] { "PEQUENA", "MÉDIA", "GRANDE", "FAMÍLIA" });
            listBoxTamanhos.Location = new Point(458, 108);
            listBoxTamanhos.Name = "listBoxTamanhos";
            listBoxTamanhos.Size = new Size(120, 94);
            listBoxTamanhos.TabIndex = 2;
            // 
            // Text_9_Tamanhos
            // 
            Text_9_Tamanhos.AutoSize = true;
            Text_9_Tamanhos.BackColor = Color.Transparent;
            Text_9_Tamanhos.ForeColor = SystemColors.Info;
            Text_9_Tamanhos.Location = new Point(455, 77);
            Text_9_Tamanhos.Name = "Text_9_Tamanhos";
            Text_9_Tamanhos.Size = new Size(123, 18);
            Text_9_Tamanhos.TabIndex = 14;
            Text_9_Tamanhos.Text = "TAMANHOS: ";
            // 
            // listBoxCategorias
            // 
            listBoxCategorias.BackColor = SystemColors.Desktop;
            listBoxCategorias.ForeColor = SystemColors.Info;
            listBoxCategorias.FormattingEnabled = true;
            listBoxCategorias.ItemHeight = 18;
            listBoxCategorias.Items.AddRange(new object[] { "TRADICIONAL", "ESPECIAL" });
            listBoxCategorias.Location = new Point(640, 108);
            listBoxCategorias.Name = "listBoxCategorias";
            listBoxCategorias.Size = new Size(120, 94);
            listBoxCategorias.TabIndex = 3;
            // 
            // Text_9_Categorias
            // 
            Text_9_Categorias.AutoSize = true;
            Text_9_Categorias.BackColor = Color.Transparent;
            Text_9_Categorias.ForeColor = SystemColors.Info;
            Text_9_Categorias.Location = new Point(640, 77);
            Text_9_Categorias.Name = "Text_9_Categorias";
            Text_9_Categorias.Size = new Size(121, 18);
            Text_9_Categorias.TabIndex = 16;
            Text_9_Categorias.Text = "CATEGORIA:";
            // 
            // Btn_9_Sair
            // 
            Btn_9_Sair.Anchor = AnchorStyles.None;
            Btn_9_Sair.BackColor = SystemColors.HotTrack;
            Btn_9_Sair.BackgroundImage = Properties.Resources.Screenshot_1;
            Btn_9_Sair.BackgroundImageLayout = ImageLayout.Stretch;
            Btn_9_Sair.Cursor = Cursors.Hand;
            Btn_9_Sair.FlatStyle = FlatStyle.Flat;
            Btn_9_Sair.Font = new Font("Copperplate Gothic Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            Btn_9_Sair.ForeColor = SystemColors.Info;
            Btn_9_Sair.Location = new Point(571, 479);
            Btn_9_Sair.Margin = new Padding(4, 3, 4, 3);
            Btn_9_Sair.Name = "Btn_9_Sair";
            Btn_9_Sair.Size = new Size(229, 32);
            Btn_9_Sair.TabIndex = 5;
            Btn_9_Sair.Text = "SAIR";
            Btn_9_Sair.UseVisualStyleBackColor = false;
            Btn_9_Sair.Click += Btn_9_Sair_Click;
            // 
            // Pnl_9_Valores
            // 
            Pnl_9_Valores.BackgroundImage = Properties.Resources.Screenshot_1;
            Pnl_9_Valores.BackgroundImageLayout = ImageLayout.Stretch;
            Pnl_9_Valores.Controls.Add(TextBoxId);
            Pnl_9_Valores.Controls.Add(TextID);
            Pnl_9_Valores.Controls.Add(CrudValores);
            Pnl_9_Valores.Controls.Add(Text_9_Valor);
            Pnl_9_Valores.Controls.Add(TextBoxValorBorda);
            Pnl_9_Valores.Controls.Add(Text_9_Categorias);
            Pnl_9_Valores.Controls.Add(TextBoxValor);
            Pnl_9_Valores.Controls.Add(listBoxCategorias);
            Pnl_9_Valores.Controls.Add(Text_9_Valores_Adicionais);
            Pnl_9_Valores.Controls.Add(Text_9_Tamanhos);
            Pnl_9_Valores.Controls.Add(listBoxTamanhos);
            Pnl_9_Valores.Location = new Point(270, 105);
            Pnl_9_Valores.Name = "Pnl_9_Valores";
            Pnl_9_Valores.Size = new Size(831, 351);
            Pnl_9_Valores.TabIndex = 18;
            // 
            // TextBoxId
            // 
            TextBoxId.BackColor = SystemColors.ControlDark;
            TextBoxId.Location = new Point(46, 47);
            TextBoxId.Name = "TextBoxId";
            TextBoxId.ReadOnly = true;
            TextBoxId.Size = new Size(47, 25);
            TextBoxId.TabIndex = 29;
            // 
            // TextID
            // 
            TextID.Anchor = AnchorStyles.None;
            TextID.AutoSize = true;
            TextID.BackColor = Color.Transparent;
            TextID.Font = new Font("Copperplate Gothic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TextID.ForeColor = SystemColors.Info;
            TextID.Location = new Point(46, 26);
            TextID.Name = "TextID";
            TextID.Size = new Size(26, 18);
            TextID.TabIndex = 30;
            TextID.Text = "ID";
            TextID.TextAlign = ContentAlignment.TopCenter;
            // 
            // CrudValores
            // 
            CrudValores.BackColor = SystemColors.Desktop;
            CrudValores.ForeColor = SystemColors.Info;
            CrudValores.Location = new Point(0, 286);
            CrudValores.Name = "CrudValores";
            CrudValores.Size = new Size(831, 65);
            CrudValores.TabIndex = 17;
            // 
            // CadastroValores
            // 
            AutoScaleDimensions = new SizeF(12F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.istockphoto_1137028124_612x612;
            ClientSize = new Size(1370, 540);
            Controls.Add(Pnl_9_Valores);
            Controls.Add(Btn_9_Sair);
            Controls.Add(TIT12_CADASTRAR);
            Font = new Font("Copperplate Gothic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            KeyPreview = true;
            Margin = new Padding(5, 4, 5, 4);
            Name = "CadastroValores";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tela_Valores";
            WindowState = FormWindowState.Maximized;
            Pnl_9_Valores.ResumeLayout(false);
            Pnl_9_Valores.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label TIT12_CADASTRAR;
        private TextBox TextBoxValorBorda;
        private TextBox TextBoxValor;
        private Label Text_9_Valor;
        private Label Text_9_Valores_Adicionais;
        private ListBox listBoxTamanhos;
        private Label Text_9_Tamanhos;
        private ListBox listBoxCategorias;
        private Label Text_9_Categorias;
        private Button Btn_9_Sair;
        private Panel Pnl_9_Valores;
        private CRUD CrudValores;
        private TextBox TextBoxId;
        private Label TextID;
    }
}