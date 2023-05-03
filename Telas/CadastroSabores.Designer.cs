namespace PizzariaDoZe
{
    partial class CadastroSabores
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
            Pnl_8_Sabores = new Panel();
            crud1 = new CRUD();
            SABOR_INGREDIENTES = new Label();
            listView1 = new ListView();
            TIPO_SABOR = new Label();
            SABOR_TIPO = new CheckedListBox();
            CATEGORIA_SABOR = new Label();
            SABOR_CATEGORIA = new CheckedListBox();
            SABOR_FOTO = new Label();
            FOTO_SABOR = new PictureBox();
            SABOR_COD_TEXT = new TextBox();
            SABOR_COD = new Label();
            SABOR_NOME_TEXT = new TextBox();
            SABOR_NOME = new Label();
            Btn_Salvar_Ingredientes = new Button();
            VOLTAR_CAD_INGREDIENTES = new Button();
            Tit_8_Cadastro_Sabores = new Label();
            Btn_8_Sair = new Button();
            Pnl_8_Sabores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)FOTO_SABOR).BeginInit();
            SuspendLayout();
            // 
            // Pnl_8_Sabores
            // 
            Pnl_8_Sabores.Anchor = AnchorStyles.None;
            Pnl_8_Sabores.BackgroundImage = Properties.Resources.Screenshot_1;
            Pnl_8_Sabores.BackgroundImageLayout = ImageLayout.Stretch;
            Pnl_8_Sabores.Controls.Add(crud1);
            Pnl_8_Sabores.Controls.Add(SABOR_INGREDIENTES);
            Pnl_8_Sabores.Controls.Add(listView1);
            Pnl_8_Sabores.Controls.Add(TIPO_SABOR);
            Pnl_8_Sabores.Controls.Add(SABOR_TIPO);
            Pnl_8_Sabores.Controls.Add(CATEGORIA_SABOR);
            Pnl_8_Sabores.Controls.Add(SABOR_CATEGORIA);
            Pnl_8_Sabores.Controls.Add(SABOR_FOTO);
            Pnl_8_Sabores.Controls.Add(FOTO_SABOR);
            Pnl_8_Sabores.Controls.Add(SABOR_COD_TEXT);
            Pnl_8_Sabores.Controls.Add(SABOR_COD);
            Pnl_8_Sabores.Controls.Add(SABOR_NOME_TEXT);
            Pnl_8_Sabores.Controls.Add(SABOR_NOME);
            Pnl_8_Sabores.Controls.Add(Btn_Salvar_Ingredientes);
            Pnl_8_Sabores.Controls.Add(VOLTAR_CAD_INGREDIENTES);
            Pnl_8_Sabores.Location = new Point(182, 94);
            Pnl_8_Sabores.Name = "Pnl_8_Sabores";
            Pnl_8_Sabores.Size = new Size(665, 371);
            Pnl_8_Sabores.TabIndex = 28;
            // 
            // crud1
            // 
            crud1.BackColor = SystemColors.Desktop;
            crud1.ForeColor = SystemColors.Info;
            crud1.Location = new Point(38, 303);
            crud1.Name = "crud1";
            crud1.Size = new Size(583, 65);
            crud1.TabIndex = 5;
            // 
            // SABOR_INGREDIENTES
            // 
            SABOR_INGREDIENTES.Anchor = AnchorStyles.None;
            SABOR_INGREDIENTES.AutoSize = true;
            SABOR_INGREDIENTES.BackColor = Color.Transparent;
            SABOR_INGREDIENTES.Font = new Font("Copperplate Gothic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            SABOR_INGREDIENTES.ForeColor = SystemColors.Info;
            SABOR_INGREDIENTES.Location = new Point(423, 139);
            SABOR_INGREDIENTES.Name = "SABOR_INGREDIENTES";
            SABOR_INGREDIENTES.Size = new Size(145, 18);
            SABOR_INGREDIENTES.TabIndex = 37;
            SABOR_INGREDIENTES.Text = "INGREDIENTES";
            SABOR_INGREDIENTES.TextAlign = ContentAlignment.TopCenter;
            // 
            // listView1
            // 
            listView1.Location = new Point(359, 160);
            listView1.Name = "listView1";
            listView1.Size = new Size(262, 105);
            listView1.TabIndex = 4;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // TIPO_SABOR
            // 
            TIPO_SABOR.Anchor = AnchorStyles.None;
            TIPO_SABOR.AutoSize = true;
            TIPO_SABOR.BackColor = Color.Transparent;
            TIPO_SABOR.Font = new Font("Copperplate Gothic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TIPO_SABOR.ForeColor = SystemColors.Info;
            TIPO_SABOR.Location = new Point(99, 196);
            TIPO_SABOR.Name = "TIPO_SABOR";
            TIPO_SABOR.Size = new Size(50, 18);
            TIPO_SABOR.TabIndex = 35;
            TIPO_SABOR.Text = "TIPO";
            TIPO_SABOR.TextAlign = ContentAlignment.TopCenter;
            // 
            // SABOR_TIPO
            // 
            SABOR_TIPO.BackColor = SystemColors.InfoText;
            SABOR_TIPO.ForeColor = SystemColors.Info;
            SABOR_TIPO.FormattingEnabled = true;
            SABOR_TIPO.Items.AddRange(new object[] { "DOCE", "SALGADA" });
            SABOR_TIPO.Location = new Point(35, 217);
            SABOR_TIPO.Name = "SABOR_TIPO";
            SABOR_TIPO.Size = new Size(188, 36);
            SABOR_TIPO.TabIndex = 3;
            // 
            // CATEGORIA_SABOR
            // 
            CATEGORIA_SABOR.Anchor = AnchorStyles.None;
            CATEGORIA_SABOR.AutoSize = true;
            CATEGORIA_SABOR.BackColor = Color.Transparent;
            CATEGORIA_SABOR.Font = new Font("Copperplate Gothic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            CATEGORIA_SABOR.ForeColor = SystemColors.Info;
            CATEGORIA_SABOR.Location = new Point(64, 136);
            CATEGORIA_SABOR.Name = "CATEGORIA_SABOR";
            CATEGORIA_SABOR.Size = new Size(116, 18);
            CATEGORIA_SABOR.TabIndex = 33;
            CATEGORIA_SABOR.Text = "CATEGORIA";
            CATEGORIA_SABOR.TextAlign = ContentAlignment.TopCenter;
            // 
            // SABOR_CATEGORIA
            // 
            SABOR_CATEGORIA.BackColor = SystemColors.InfoText;
            SABOR_CATEGORIA.ForeColor = SystemColors.Info;
            SABOR_CATEGORIA.FormattingEnabled = true;
            SABOR_CATEGORIA.Items.AddRange(new object[] { "TRADICIONAL", "ESPECIAL" });
            SABOR_CATEGORIA.Location = new Point(35, 157);
            SABOR_CATEGORIA.Name = "SABOR_CATEGORIA";
            SABOR_CATEGORIA.Size = new Size(188, 36);
            SABOR_CATEGORIA.TabIndex = 2;
            // 
            // SABOR_FOTO
            // 
            SABOR_FOTO.AutoSize = true;
            SABOR_FOTO.BackColor = SystemColors.InactiveCaptionText;
            SABOR_FOTO.Font = new Font("Copperplate Gothic Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            SABOR_FOTO.ForeColor = SystemColors.Info;
            SABOR_FOTO.Location = new Point(359, 36);
            SABOR_FOTO.Name = "SABOR_FOTO";
            SABOR_FOTO.Size = new Size(69, 21);
            SABOR_FOTO.TabIndex = 31;
            SABOR_FOTO.Text = "FOTO";
            // 
            // FOTO_SABOR
            // 
            FOTO_SABOR.BackColor = SystemColors.Info;
            FOTO_SABOR.BorderStyle = BorderStyle.Fixed3D;
            FOTO_SABOR.Location = new Point(434, 15);
            FOTO_SABOR.Name = "FOTO_SABOR";
            FOTO_SABOR.Size = new Size(117, 105);
            FOTO_SABOR.TabIndex = 30;
            FOTO_SABOR.TabStop = false;
            // 
            // SABOR_COD_TEXT
            // 
            SABOR_COD_TEXT.Location = new Point(35, 99);
            SABOR_COD_TEXT.Name = "SABOR_COD_TEXT";
            SABOR_COD_TEXT.Size = new Size(188, 21);
            SABOR_COD_TEXT.TabIndex = 1;
            // 
            // SABOR_COD
            // 
            SABOR_COD.Anchor = AnchorStyles.None;
            SABOR_COD.AutoSize = true;
            SABOR_COD.BackColor = Color.Transparent;
            SABOR_COD.Font = new Font("Copperplate Gothic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            SABOR_COD.ForeColor = SystemColors.Info;
            SABOR_COD.Location = new Point(85, 75);
            SABOR_COD.Name = "SABOR_COD";
            SABOR_COD.Size = new Size(81, 18);
            SABOR_COD.TabIndex = 28;
            SABOR_COD.Text = "CÓDIGO";
            SABOR_COD.TextAlign = ContentAlignment.TopCenter;
            // 
            // SABOR_NOME_TEXT
            // 
            SABOR_NOME_TEXT.Location = new Point(35, 36);
            SABOR_NOME_TEXT.Name = "SABOR_NOME_TEXT";
            SABOR_NOME_TEXT.Size = new Size(188, 21);
            SABOR_NOME_TEXT.TabIndex = 0;
            // 
            // SABOR_NOME
            // 
            SABOR_NOME.Anchor = AnchorStyles.None;
            SABOR_NOME.AutoSize = true;
            SABOR_NOME.BackColor = Color.Transparent;
            SABOR_NOME.Font = new Font("Copperplate Gothic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            SABOR_NOME.ForeColor = SystemColors.Info;
            SABOR_NOME.Location = new Point(86, 15);
            SABOR_NOME.Name = "SABOR_NOME";
            SABOR_NOME.Size = new Size(63, 18);
            SABOR_NOME.TabIndex = 26;
            SABOR_NOME.Text = "NOME";
            SABOR_NOME.TextAlign = ContentAlignment.TopCenter;
            // 
            // Btn_Salvar_Ingredientes
            // 
            Btn_Salvar_Ingredientes.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            Btn_Salvar_Ingredientes.BackColor = SystemColors.ControlDarkDark;
            Btn_Salvar_Ingredientes.BackgroundImage = Properties.Resources.Screenshot_1;
            Btn_Salvar_Ingredientes.BackgroundImageLayout = ImageLayout.Center;
            Btn_Salvar_Ingredientes.Cursor = Cursors.Hand;
            Btn_Salvar_Ingredientes.FlatStyle = FlatStyle.Flat;
            Btn_Salvar_Ingredientes.Font = new Font("Copperplate Gothic Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Btn_Salvar_Ingredientes.ForeColor = SystemColors.Info;
            Btn_Salvar_Ingredientes.Location = new Point(664, 502);
            Btn_Salvar_Ingredientes.Margin = new Padding(4, 3, 4, 3);
            Btn_Salvar_Ingredientes.Name = "Btn_Salvar_Ingredientes";
            Btn_Salvar_Ingredientes.Size = new Size(111, 53);
            Btn_Salvar_Ingredientes.TabIndex = 25;
            Btn_Salvar_Ingredientes.Text = "SALVAR";
            Btn_Salvar_Ingredientes.UseVisualStyleBackColor = false;
            // 
            // VOLTAR_CAD_INGREDIENTES
            // 
            VOLTAR_CAD_INGREDIENTES.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            VOLTAR_CAD_INGREDIENTES.BackColor = Color.Transparent;
            VOLTAR_CAD_INGREDIENTES.BackgroundImage = Properties.Resources.Screenshot_1;
            VOLTAR_CAD_INGREDIENTES.FlatStyle = FlatStyle.Flat;
            VOLTAR_CAD_INGREDIENTES.Font = new Font("Copperplate Gothic Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            VOLTAR_CAD_INGREDIENTES.ForeColor = SystemColors.Info;
            VOLTAR_CAD_INGREDIENTES.Location = new Point(27, 502);
            VOLTAR_CAD_INGREDIENTES.Name = "VOLTAR_CAD_INGREDIENTES";
            VOLTAR_CAD_INGREDIENTES.Size = new Size(111, 53);
            VOLTAR_CAD_INGREDIENTES.TabIndex = 0;
            VOLTAR_CAD_INGREDIENTES.Text = "VOLTAR";
            VOLTAR_CAD_INGREDIENTES.UseVisualStyleBackColor = false;
            // 
            // Tit_8_Cadastro_Sabores
            // 
            Tit_8_Cadastro_Sabores.Anchor = AnchorStyles.None;
            Tit_8_Cadastro_Sabores.AutoSize = true;
            Tit_8_Cadastro_Sabores.BackColor = SystemColors.ActiveCaptionText;
            Tit_8_Cadastro_Sabores.BorderStyle = BorderStyle.Fixed3D;
            Tit_8_Cadastro_Sabores.Font = new Font("Copperplate Gothic Bold", 36F, FontStyle.Regular, GraphicsUnit.Point);
            Tit_8_Cadastro_Sabores.ForeColor = SystemColors.Info;
            Tit_8_Cadastro_Sabores.Image = Properties.Resources.Screenshot_1;
            Tit_8_Cadastro_Sabores.Location = new Point(172, -9);
            Tit_8_Cadastro_Sabores.Name = "Tit_8_Cadastro_Sabores";
            Tit_8_Cadastro_Sabores.Size = new Size(694, 55);
            Tit_8_Cadastro_Sabores.TabIndex = 29;
            Tit_8_Cadastro_Sabores.Text = "CADASTRO DE SABORES";
            Tit_8_Cadastro_Sabores.TextAlign = ContentAlignment.TopCenter;
            // 
            // Btn_8_Sair
            // 
            Btn_8_Sair.Anchor = AnchorStyles.None;
            Btn_8_Sair.BackColor = SystemColors.HotTrack;
            Btn_8_Sair.BackgroundImage = Properties.Resources.Screenshot_1;
            Btn_8_Sair.BackgroundImageLayout = ImageLayout.Stretch;
            Btn_8_Sair.Cursor = Cursors.Hand;
            Btn_8_Sair.FlatStyle = FlatStyle.Flat;
            Btn_8_Sair.Font = new Font("Copperplate Gothic Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            Btn_8_Sair.ForeColor = SystemColors.Info;
            Btn_8_Sair.Location = new Point(400, 516);
            Btn_8_Sair.Margin = new Padding(4, 3, 4, 3);
            Btn_8_Sair.Name = "Btn_8_Sair";
            Btn_8_Sair.Size = new Size(229, 32);
            Btn_8_Sair.TabIndex = 6;
            Btn_8_Sair.Text = "SAIR";
            Btn_8_Sair.UseVisualStyleBackColor = false;
            Btn_8_Sair.Click += Btn_8_Sair_Click;
            // 
            // CadastroSabores
            // 
            AutoScaleDimensions = new SizeF(9F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.istockphoto_1137028124_612x612;
            ClientSize = new Size(1029, 571);
            Controls.Add(Btn_8_Sair);
            Controls.Add(Tit_8_Cadastro_Sabores);
            Controls.Add(Pnl_8_Sabores);
            Font = new Font("Copperplate Gothic Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "CadastroSabores";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CADASTRO_SABORES";
            WindowState = FormWindowState.Maximized;
            Pnl_8_Sabores.ResumeLayout(false);
            Pnl_8_Sabores.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)FOTO_SABOR).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel Pnl_8_Sabores;
        private TextBox SABOR_COD_TEXT;
        private Label SABOR_COD;
        private TextBox SABOR_NOME_TEXT;
        private Label SABOR_NOME;
        private Button Btn_Salvar_Ingredientes;
        private Button VOLTAR_CAD_INGREDIENTES;
        private Label TIPO_SABOR;
        private CheckedListBox SABOR_TIPO;
        private Label CATEGORIA_SABOR;
        private CheckedListBox SABOR_CATEGORIA;
        private Label SABOR_FOTO;
        private PictureBox FOTO_SABOR;
        private ListView listView1;
        private Label SABOR_INGREDIENTES;
        private Label Tit_8_Cadastro_Sabores;
        private Button Btn_8_Sair;
        private CRUD crud1;
    }
}