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
            ListBox_10_ML = new ListBox();
            Text_10_Tipo = new Label();
            ListBox_10_Tipo = new ListBox();
            Text_10_Nome = new Label();
            Text_10_Valor = new Label();
            TextBoxValorCadastros = new TextBox();
            TextBoxNomeCadastros = new TextBox();
            Tit_10_Cadastrar_Produtos = new Label();
            Pnl_10_Produtos = new Panel();
            crud1 = new CRUD();
            Btn_10_Sair = new Button();
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
            // ListBox_10_ML
            // 
            ListBox_10_ML.BackColor = SystemColors.Desktop;
            ListBox_10_ML.ForeColor = SystemColors.Info;
            ListBox_10_ML.FormattingEnabled = true;
            ListBox_10_ML.ItemHeight = 18;
            ListBox_10_ML.Items.AddRange(new object[] { "150", "300", "600", "1000", "1500", "2000" });
            ListBox_10_ML.Location = new Point(586, 125);
            ListBox_10_ML.Name = "ListBox_10_ML";
            ListBox_10_ML.Size = new Size(151, 94);
            ListBox_10_ML.TabIndex = 24;
            ListBox_10_ML.SelectedIndexChanged += ListBox_10_ML_SelectedIndexChanged;
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
            // ListBox_10_Tipo
            // 
            ListBox_10_Tipo.BackColor = SystemColors.Desktop;
            ListBox_10_Tipo.ForeColor = SystemColors.Info;
            ListBox_10_Tipo.FormattingEnabled = true;
            ListBox_10_Tipo.ItemHeight = 18;
            ListBox_10_Tipo.Items.AddRange(new object[] { "REFRIGERANTE", "CERVEJA", "SUCU", "ÁGUA", "OUTROS" });
            ListBox_10_Tipo.Location = new Point(407, 125);
            ListBox_10_Tipo.Name = "ListBox_10_Tipo";
            ListBox_10_Tipo.Size = new Size(151, 94);
            ListBox_10_Tipo.TabIndex = 22;
            ListBox_10_Tipo.SelectedIndexChanged += ListBox_10_Tipo_SelectedIndexChanged;
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
            // TextBoxValorCadastros
            // 
            TextBoxValorCadastros.Location = new Point(38, 188);
            TextBoxValorCadastros.Name = "TextBoxValorCadastros";
            TextBoxValorCadastros.Size = new Size(319, 25);
            TextBoxValorCadastros.TabIndex = 19;
            // 
            // TextBoxNomeCadastros
            // 
            TextBoxNomeCadastros.Location = new Point(38, 77);
            TextBoxNomeCadastros.Name = "TextBoxNomeCadastros";
            TextBoxNomeCadastros.Size = new Size(319, 25);
            TextBoxNomeCadastros.TabIndex = 18;
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
            Pnl_10_Produtos.Controls.Add(crud1);
            Pnl_10_Produtos.Controls.Add(Text_10_Nome);
            Pnl_10_Produtos.Controls.Add(TextBoxValorCadastros);
            Pnl_10_Produtos.Controls.Add(Text_10_ML);
            Pnl_10_Produtos.Controls.Add(TextBoxNomeCadastros);
            Pnl_10_Produtos.Controls.Add(ListBox_10_ML);
            Pnl_10_Produtos.Controls.Add(Text_10_Valor);
            Pnl_10_Produtos.Controls.Add(Text_10_Tipo);
            Pnl_10_Produtos.Controls.Add(ListBox_10_Tipo);
            Pnl_10_Produtos.Location = new Point(294, 105);
            Pnl_10_Produtos.Name = "Pnl_10_Produtos";
            Pnl_10_Produtos.Size = new Size(783, 351);
            Pnl_10_Produtos.TabIndex = 26;
            // 
            // crud1
            // 
            crud1.BackColor = SystemColors.Desktop;
            crud1.ForeColor = SystemColors.Info;
            crud1.Location = new Point(15, 263);
            crud1.Name = "crud1";
            crud1.Size = new Size(745, 70);
            crud1.TabIndex = 26;
            // 
            // Btn_10_Sair
            // 
            Btn_10_Sair.Anchor = AnchorStyles.None;
            Btn_10_Sair.BackColor = SystemColors.HotTrack;
            Btn_10_Sair.BackgroundImage = Properties.Resources.Screenshot_1;
            Btn_10_Sair.BackgroundImageLayout = ImageLayout.Stretch;
            Btn_10_Sair.Cursor = Cursors.Hand;
            Btn_10_Sair.FlatStyle = FlatStyle.Flat;
            Btn_10_Sair.Font = new Font("Copperplate Gothic Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            Btn_10_Sair.ForeColor = SystemColors.Info;
            Btn_10_Sair.Location = new Point(540, 482);
            Btn_10_Sair.Margin = new Padding(4, 3, 4, 3);
            Btn_10_Sair.Name = "Btn_10_Sair";
            Btn_10_Sair.Size = new Size(229, 32);
            Btn_10_Sair.TabIndex = 27;
            Btn_10_Sair.Text = "SAIR";
            Btn_10_Sair.UseVisualStyleBackColor = false;
            Btn_10_Sair.Click += Btn_10_Sair_Click;
            // 
            // CadastrarProdutos
            // 
            AutoScaleDimensions = new SizeF(12F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.istockphoto_1137028124_612x612;
            ClientSize = new Size(1370, 540);
            Controls.Add(Btn_10_Sair);
            Controls.Add(Pnl_10_Produtos);
            Controls.Add(Tit_10_Cadastrar_Produtos);
            Font = new Font("Copperplate Gothic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
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
        private ListBox ListBox_10_ML;
        private Label Text_10_Tipo;
        private ListBox ListBox_10_Tipo;
        private Label Text_10_Nome;
        private Label Text_10_Valor;
        private TextBox TextBoxValorCadastros;
        private TextBox TextBoxNomeCadastros;
        private Label Tit_10_Cadastrar_Produtos;
        private Panel Pnl_10_Produtos;
        private CRUD crud1;
        private Button Btn_10_Sair;
    }
}