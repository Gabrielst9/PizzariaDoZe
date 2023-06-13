namespace PizzariaDoZe
{
    partial class CadastrarProdutos
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
            Text_10_ML = new Label();
            listBoxMl = new ListBox();
            Text_10_Tipo = new Label();
            listBoxTipo = new ListBox();
            Text_10_Nome = new Label();
            Text_10_Valor = new Label();
            TextBoxValor = new TextBox();
            TextBoxNome = new TextBox();
            Tit_10_Cadastrar_Produtos = new Label();
            Pnl_10_Produtos = new Panel();
            BtnSair = new Button();
            CrudProdutos = new CRUD();
            Pnl_10_Produtos.SuspendLayout();
            SuspendLayout();
            // 
            // Text_10_ML
            // 
            Text_10_ML.AutoSize = true;
            Text_10_ML.BackColor = Color.Transparent;
            Text_10_ML.ForeColor = SystemColors.Info;
            Text_10_ML.Location = new Point(642, 64);
            Text_10_ML.Name = "Text_10_ML";
            Text_10_ML.Size = new Size(39, 18);
            Text_10_ML.TabIndex = 25;
            Text_10_ML.Text = "ML:";
            // 
            // listBoxMl
            // 
            listBoxMl.BackColor = SystemColors.Desktop;
            listBoxMl.ForeColor = SystemColors.Info;
            listBoxMl.FormattingEnabled = true;
            listBoxMl.ItemHeight = 18;
            listBoxMl.Items.AddRange(new object[] { "150", "300", "600", "1000", "1500", "2000" });
            listBoxMl.Location = new Point(586, 125);
            listBoxMl.Name = "listBoxMl";
            listBoxMl.Size = new Size(151, 94);
            listBoxMl.TabIndex = 4;
            // 
            // Text_10_Tipo
            // 
            Text_10_Tipo.AutoSize = true;
            Text_10_Tipo.BackColor = Color.Transparent;
            Text_10_Tipo.ForeColor = SystemColors.Info;
            Text_10_Tipo.Location = new Point(444, 64);
            Text_10_Tipo.Name = "Text_10_Tipo";
            Text_10_Tipo.Size = new Size(55, 18);
            Text_10_Tipo.TabIndex = 23;
            Text_10_Tipo.Text = "TIPO:";
            // 
            // listBoxTipo
            // 
            listBoxTipo.BackColor = SystemColors.Desktop;
            listBoxTipo.ForeColor = SystemColors.Info;
            listBoxTipo.FormattingEnabled = true;
            listBoxTipo.ItemHeight = 18;
            listBoxTipo.Items.AddRange(new object[] { "REFRIGERANTE", "CERVEJA", "SUCU", "ÁGUA", "OUTROS" });
            listBoxTipo.Location = new Point(407, 125);
            listBoxTipo.Name = "listBoxTipo";
            listBoxTipo.Size = new Size(151, 94);
            listBoxTipo.TabIndex = 3;
            // 
            // Text_10_Nome
            // 
            Text_10_Nome.AutoSize = true;
            Text_10_Nome.BackColor = Color.Transparent;
            Text_10_Nome.ForeColor = SystemColors.Info;
            Text_10_Nome.Location = new Point(153, 39);
            Text_10_Nome.Name = "Text_10_Nome";
            Text_10_Nome.Size = new Size(68, 18);
            Text_10_Nome.TabIndex = 21;
            Text_10_Nome.Text = "NOME:";
            // 
            // Text_10_Valor
            // 
            Text_10_Valor.AutoSize = true;
            Text_10_Valor.BackColor = Color.Transparent;
            Text_10_Valor.ForeColor = SystemColors.Info;
            Text_10_Valor.Location = new Point(145, 146);
            Text_10_Valor.Name = "Text_10_Valor";
            Text_10_Valor.Size = new Size(76, 18);
            Text_10_Valor.TabIndex = 20;
            Text_10_Valor.Text = "VALOR:";
            // 
            // TextBoxValor
            // 
            TextBoxValor.Location = new Point(38, 188);
            TextBoxValor.Name = "TextBoxValor";
            TextBoxValor.Size = new Size(319, 25);
            TextBoxValor.TabIndex = 1;
            // 
            // TextBoxNome
            // 
            TextBoxNome.Location = new Point(38, 77);
            TextBoxNome.Name = "TextBoxNome";
            TextBoxNome.Size = new Size(319, 25);
            TextBoxNome.TabIndex = 0;
            // 
            // Tit_10_Cadastrar_Produtos
            // 
            Tit_10_Cadastrar_Produtos.AutoSize = true;
            Tit_10_Cadastrar_Produtos.BackColor = SystemColors.ActiveCaptionText;
            Tit_10_Cadastrar_Produtos.Font = new Font("Copperplate Gothic Bold", 36F, FontStyle.Regular, GraphicsUnit.Point);
            Tit_10_Cadastrar_Produtos.ForeColor = SystemColors.Info;
            Tit_10_Cadastrar_Produtos.Image = Properties.Resources.Screenshot_1;
            Tit_10_Cadastrar_Produtos.Location = new Point(339, 26);
            Tit_10_Cadastrar_Produtos.Name = "Tit_10_Cadastrar_Produtos";
            Tit_10_Cadastrar_Produtos.Size = new Size(681, 53);
            Tit_10_Cadastrar_Produtos.TabIndex = 17;
            Tit_10_Cadastrar_Produtos.Text = "CADASTRAR PRODUTOS";
            // 
            // Pnl_10_Produtos
            // 
            Pnl_10_Produtos.BackgroundImage = Properties.Resources.Screenshot_1;
            Pnl_10_Produtos.BackgroundImageLayout = ImageLayout.Stretch;
            Pnl_10_Produtos.Controls.Add(CrudProdutos);
            Pnl_10_Produtos.Controls.Add(Text_10_Nome);
            Pnl_10_Produtos.Controls.Add(TextBoxValor);
            Pnl_10_Produtos.Controls.Add(Text_10_ML);
            Pnl_10_Produtos.Controls.Add(TextBoxNome);
            Pnl_10_Produtos.Controls.Add(listBoxMl);
            Pnl_10_Produtos.Controls.Add(Text_10_Valor);
            Pnl_10_Produtos.Controls.Add(Text_10_Tipo);
            Pnl_10_Produtos.Controls.Add(listBoxTipo);
            Pnl_10_Produtos.Location = new Point(294, 105);
            Pnl_10_Produtos.Name = "Pnl_10_Produtos";
            Pnl_10_Produtos.Size = new Size(783, 351);
            Pnl_10_Produtos.TabIndex = 0;
            // 
            // BtnSair
            // 
            BtnSair.Anchor = AnchorStyles.None;
            BtnSair.BackColor = SystemColors.HotTrack;
            BtnSair.BackgroundImage = Properties.Resources.Screenshot_1;
            BtnSair.BackgroundImageLayout = ImageLayout.Stretch;
            BtnSair.Cursor = Cursors.Hand;
            BtnSair.FlatStyle = FlatStyle.Flat;
            BtnSair.Font = new Font("Copperplate Gothic Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            BtnSair.ForeColor = SystemColors.Info;
            BtnSair.Location = new Point(540, 482);
            BtnSair.Margin = new Padding(4, 3, 4, 3);
            BtnSair.Name = "BtnSair";
            BtnSair.Size = new Size(229, 32);
            BtnSair.TabIndex = 7;
            BtnSair.Text = "SAIR";
            BtnSair.UseVisualStyleBackColor = false;
            BtnSair.Click += BtnSair_Click;
            // 
            // CrudProdutos
            // 
            CrudProdutos.BackColor = SystemColors.Desktop;
            CrudProdutos.ForeColor = SystemColors.Info;
            CrudProdutos.Location = new Point(0, 286);
            CrudProdutos.Name = "CrudProdutos";
            CrudProdutos.Size = new Size(783, 65);
            CrudProdutos.TabIndex = 26;
            // 
            // CadastrarProdutos
            // 
            AutoScaleDimensions = new SizeF(12F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.istockphoto_1137028124_612x612;
            ClientSize = new Size(1370, 540);
            Controls.Add(BtnSair);
            Controls.Add(Pnl_10_Produtos);
            Controls.Add(Tit_10_Cadastrar_Produtos);
            Font = new Font("Copperplate Gothic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            KeyPreview = true;
            Margin = new Padding(5, 4, 5, 4);
            Name = "CadastrarProdutos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tela_Produtos";
            WindowState = FormWindowState.Maximized;
            Pnl_10_Produtos.ResumeLayout(false);
            Pnl_10_Produtos.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Text_10_ML;
        private ListBox listBoxMl;
        private Label Text_10_Tipo;
        private ListBox listBoxTipo;
        private Label Text_10_Nome;
        private Label Text_10_Valor;
        private TextBox TextBoxValor;
        private TextBox TextBoxNome;
        private Label Tit_10_Cadastrar_Produtos;
        private Panel Pnl_10_Produtos;
        private CRUD crud1;
        private Button BtnSair;
        private CRUD CrudProdutos;
    }
}