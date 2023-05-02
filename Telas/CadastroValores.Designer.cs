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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            Text_9_Valor = new Label();
            Text_9_Valores_Adicionais = new Label();
            ListBox_9_Tamanhos = new ListBox();
            Text_9_Tamanhos = new Label();
            ListBox_9_Categorias = new ListBox();
            Text_9_Categorias = new Label();
            Btn_9_Sair = new Button();
            Pnl_9_Valores = new Panel();
            crud1 = new CRUD();
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
            // textBox1
            // 
            textBox1.Location = new Point(46, 196);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(319, 25);
            textBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(46, 70);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(319, 25);
            textBox2.TabIndex = 8;
            // 
            // Text_9_Valor
            // 
            Text_9_Valor.AutoSize = true;
            Text_9_Valor.BackColor = Color.Transparent;
            Text_9_Valor.ForeColor = SystemColors.Info;
            Text_9_Valor.Location = new Point(153, 49);
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
            Text_9_Valores_Adicionais.Location = new Point(73, 175);
            Text_9_Valores_Adicionais.Name = "Text_9_Valores_Adicionais";
            Text_9_Valores_Adicionais.Size = new Size(246, 18);
            Text_9_Valores_Adicionais.TabIndex = 10;
            Text_9_Valores_Adicionais.Text = "VALOR ADICIONAL BORDA";
            // 
            // ListBox_9_Tamanhos
            // 
            ListBox_9_Tamanhos.BackColor = SystemColors.Desktop;
            ListBox_9_Tamanhos.ForeColor = SystemColors.Info;
            ListBox_9_Tamanhos.FormattingEnabled = true;
            ListBox_9_Tamanhos.ItemHeight = 18;
            ListBox_9_Tamanhos.Items.AddRange(new object[] { "PEQUENA", "MÉDIA", "GRANDE", "FAMÍLIA" });
            ListBox_9_Tamanhos.Location = new Point(458, 108);
            ListBox_9_Tamanhos.Name = "ListBox_9_Tamanhos";
            ListBox_9_Tamanhos.Size = new Size(120, 94);
            ListBox_9_Tamanhos.TabIndex = 13;
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
            // ListBox_9_Categorias
            // 
            ListBox_9_Categorias.BackColor = SystemColors.Desktop;
            ListBox_9_Categorias.ForeColor = SystemColors.Info;
            ListBox_9_Categorias.FormattingEnabled = true;
            ListBox_9_Categorias.ItemHeight = 18;
            ListBox_9_Categorias.Items.AddRange(new object[] { "TRADICIONAL", "ESPECIAL" });
            ListBox_9_Categorias.Location = new Point(640, 108);
            ListBox_9_Categorias.Name = "ListBox_9_Categorias";
            ListBox_9_Categorias.Size = new Size(120, 94);
            ListBox_9_Categorias.TabIndex = 15;
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
            Btn_9_Sair.TabIndex = 17;
            Btn_9_Sair.Text = "SAIR";
            Btn_9_Sair.UseVisualStyleBackColor = false;
            Btn_9_Sair.Click += Btn_9_Sair_Click;
            // 
            // Pnl_9_Valores
            // 
            Pnl_9_Valores.BackgroundImage = Properties.Resources.Screenshot_1;
            Pnl_9_Valores.BackgroundImageLayout = ImageLayout.Stretch;
            Pnl_9_Valores.Controls.Add(crud1);
            Pnl_9_Valores.Controls.Add(Text_9_Valor);
            Pnl_9_Valores.Controls.Add(textBox1);
            Pnl_9_Valores.Controls.Add(Text_9_Categorias);
            Pnl_9_Valores.Controls.Add(textBox2);
            Pnl_9_Valores.Controls.Add(ListBox_9_Categorias);
            Pnl_9_Valores.Controls.Add(Text_9_Valores_Adicionais);
            Pnl_9_Valores.Controls.Add(Text_9_Tamanhos);
            Pnl_9_Valores.Controls.Add(ListBox_9_Tamanhos);
            Pnl_9_Valores.Location = new Point(270, 105);
            Pnl_9_Valores.Name = "Pnl_9_Valores";
            Pnl_9_Valores.Size = new Size(831, 351);
            Pnl_9_Valores.TabIndex = 18;
            // 
            // crud1
            // 
            crud1.BackColor = SystemColors.Desktop;
            crud1.ForeColor = SystemColors.Info;
            crud1.Location = new Point(41, 283);
            crud1.Name = "crud1";
            crud1.Size = new Size(765, 65);
            crud1.TabIndex = 17;
            // 
            // Tela_Valores
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
            Margin = new Padding(5, 4, 5, 4);
            Name = "Tela_Valores";
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
        private TextBox textBox1;
        private TextBox textBox2;
        private Label Text_9_Valor;
        private Label Text_9_Valores_Adicionais;
        private ListBox ListBox_9_Tamanhos;
        private Label Text_9_Tamanhos;
        private ListBox ListBox_9_Categorias;
        private Label Text_9_Categorias;
        private Button Btn_9_Sair;
        private Panel Pnl_9_Valores;
        private CRUD crud1;
    }
}