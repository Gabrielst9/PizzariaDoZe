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
            pictureBoxImagem = new PictureBox();
            listBoxTipo = new ListBox();
            listBoxCategoria = new ListBox();
            checkedListBoxIngredientes = new CheckedListBox();
            SABOR_INGREDIENTES = new Label();
            TextTipo = new Label();
            TextCategoria = new Label();
            TextFoto = new Label();
            TextBoxId = new TextBox();
            TextID = new Label();
            TextBoxNome = new TextBox();
            TextNome = new Label();
            Btn_Salvar_Ingredientes = new Button();
            VOLTAR_CAD_INGREDIENTES = new Button();
            Tit_8_Cadastro_Sabores = new Label();
            Btn_8_Sair = new Button();
            CrudSabores = new CRUD();
            Pnl_8_Sabores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxImagem).BeginInit();
            SuspendLayout();
            // 
            // Pnl_8_Sabores
            // 
            Pnl_8_Sabores.Anchor = AnchorStyles.None;
            Pnl_8_Sabores.BackgroundImage = Properties.Resources.Screenshot_1;
            Pnl_8_Sabores.BackgroundImageLayout = ImageLayout.Stretch;
            Pnl_8_Sabores.Controls.Add(CrudSabores);
            Pnl_8_Sabores.Controls.Add(pictureBoxImagem);
            Pnl_8_Sabores.Controls.Add(listBoxTipo);
            Pnl_8_Sabores.Controls.Add(listBoxCategoria);
            Pnl_8_Sabores.Controls.Add(checkedListBoxIngredientes);
            Pnl_8_Sabores.Controls.Add(SABOR_INGREDIENTES);
            Pnl_8_Sabores.Controls.Add(TextTipo);
            Pnl_8_Sabores.Controls.Add(TextCategoria);
            Pnl_8_Sabores.Controls.Add(TextFoto);
            Pnl_8_Sabores.Controls.Add(TextBoxId);
            Pnl_8_Sabores.Controls.Add(TextID);
            Pnl_8_Sabores.Controls.Add(TextBoxNome);
            Pnl_8_Sabores.Controls.Add(TextNome);
            Pnl_8_Sabores.Controls.Add(Btn_Salvar_Ingredientes);
            Pnl_8_Sabores.Controls.Add(VOLTAR_CAD_INGREDIENTES);
            Pnl_8_Sabores.Location = new Point(182, 94);
            Pnl_8_Sabores.Name = "Pnl_8_Sabores";
            Pnl_8_Sabores.Size = new Size(665, 371);
            Pnl_8_Sabores.TabIndex = 28;
            // 
            // pictureBoxImagem
            // 
            pictureBoxImagem.Image = Properties.Resources.icons8_imagem_100;
            pictureBoxImagem.Location = new Point(233, 36);
            pictureBoxImagem.Name = "pictureBoxImagem";
            pictureBoxImagem.Size = new Size(171, 144);
            pictureBoxImagem.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxImagem.TabIndex = 42;
            pictureBoxImagem.TabStop = false;
            pictureBoxImagem.Click += pictureBoxImagem_Click;
            // 
            // listBoxTipo
            // 
            listBoxTipo.FormattingEnabled = true;
            listBoxTipo.ItemHeight = 14;
            listBoxTipo.Items.AddRange(new object[] { "TRADICIONAL", "ESPECIAL" });
            listBoxTipo.Location = new Point(22, 204);
            listBoxTipo.Name = "listBoxTipo";
            listBoxTipo.Size = new Size(160, 32);
            listBoxTipo.TabIndex = 41;
            // 
            // listBoxCategoria
            // 
            listBoxCategoria.FormattingEnabled = true;
            listBoxCategoria.ItemHeight = 14;
            listBoxCategoria.Items.AddRange(new object[] { "TRADICIONAL", "ESPECIAL" });
            listBoxCategoria.Location = new Point(22, 148);
            listBoxCategoria.Name = "listBoxCategoria";
            listBoxCategoria.Size = new Size(160, 32);
            listBoxCategoria.TabIndex = 40;
            // 
            // checkedListBoxIngredientes
            // 
            checkedListBoxIngredientes.FormattingEnabled = true;
            checkedListBoxIngredientes.Location = new Point(490, 36);
            checkedListBoxIngredientes.Name = "checkedListBoxIngredientes";
            checkedListBoxIngredientes.Size = new Size(160, 324);
            checkedListBoxIngredientes.TabIndex = 38;
            // 
            // SABOR_INGREDIENTES
            // 
            SABOR_INGREDIENTES.Anchor = AnchorStyles.None;
            SABOR_INGREDIENTES.AutoSize = true;
            SABOR_INGREDIENTES.BackColor = Color.Transparent;
            SABOR_INGREDIENTES.Font = new Font("Copperplate Gothic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            SABOR_INGREDIENTES.ForeColor = SystemColors.Info;
            SABOR_INGREDIENTES.Location = new Point(490, 15);
            SABOR_INGREDIENTES.Name = "SABOR_INGREDIENTES";
            SABOR_INGREDIENTES.Size = new Size(145, 18);
            SABOR_INGREDIENTES.TabIndex = 37;
            SABOR_INGREDIENTES.Text = "INGREDIENTES";
            SABOR_INGREDIENTES.TextAlign = ContentAlignment.TopCenter;
            // 
            // TextTipo
            // 
            TextTipo.Anchor = AnchorStyles.None;
            TextTipo.AutoSize = true;
            TextTipo.BackColor = Color.Transparent;
            TextTipo.Font = new Font("Copperplate Gothic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TextTipo.ForeColor = SystemColors.Info;
            TextTipo.Location = new Point(22, 183);
            TextTipo.Name = "TextTipo";
            TextTipo.Size = new Size(50, 18);
            TextTipo.TabIndex = 35;
            TextTipo.Text = "TIPO";
            TextTipo.TextAlign = ContentAlignment.TopCenter;
            // 
            // TextCategoria
            // 
            TextCategoria.Anchor = AnchorStyles.None;
            TextCategoria.AutoSize = true;
            TextCategoria.BackColor = Color.Transparent;
            TextCategoria.Font = new Font("Copperplate Gothic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TextCategoria.ForeColor = SystemColors.Info;
            TextCategoria.Location = new Point(22, 127);
            TextCategoria.Name = "TextCategoria";
            TextCategoria.Size = new Size(116, 18);
            TextCategoria.TabIndex = 33;
            TextCategoria.Text = "CATEGORIA";
            TextCategoria.TextAlign = ContentAlignment.TopCenter;
            // 
            // TextFoto
            // 
            TextFoto.AutoSize = true;
            TextFoto.BackColor = Color.Transparent;
            TextFoto.Font = new Font("Copperplate Gothic Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            TextFoto.ForeColor = SystemColors.Info;
            TextFoto.Location = new Point(233, 9);
            TextFoto.Name = "TextFoto";
            TextFoto.Size = new Size(69, 21);
            TextFoto.TabIndex = 31;
            TextFoto.Text = "FOTO";
            // 
            // TextBoxId
            // 
            TextBoxId.BackColor = SystemColors.ControlDark;
            TextBoxId.Location = new Point(24, 33);
            TextBoxId.Name = "TextBoxId";
            TextBoxId.ReadOnly = true;
            TextBoxId.Size = new Size(47, 21);
            TextBoxId.TabIndex = 1;
            // 
            // TextID
            // 
            TextID.Anchor = AnchorStyles.None;
            TextID.AutoSize = true;
            TextID.BackColor = Color.Transparent;
            TextID.Font = new Font("Copperplate Gothic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TextID.ForeColor = SystemColors.Info;
            TextID.Location = new Point(24, 12);
            TextID.Name = "TextID";
            TextID.Size = new Size(26, 18);
            TextID.TabIndex = 28;
            TextID.Text = "ID";
            TextID.TextAlign = ContentAlignment.TopCenter;
            // 
            // TextBoxNome
            // 
            TextBoxNome.Location = new Point(22, 92);
            TextBoxNome.Name = "TextBoxNome";
            TextBoxNome.Size = new Size(188, 21);
            TextBoxNome.TabIndex = 0;
            // 
            // TextNome
            // 
            TextNome.Anchor = AnchorStyles.None;
            TextNome.AutoSize = true;
            TextNome.BackColor = Color.Transparent;
            TextNome.Font = new Font("Copperplate Gothic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TextNome.ForeColor = SystemColors.Info;
            TextNome.Location = new Point(22, 71);
            TextNome.Name = "TextNome";
            TextNome.Size = new Size(63, 18);
            TextNome.TabIndex = 26;
            TextNome.Text = "NOME";
            TextNome.TextAlign = ContentAlignment.TopCenter;
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
            // CrudSabores
            // 
            CrudSabores.BackColor = SystemColors.Desktop;
            CrudSabores.ForeColor = SystemColors.Info;
            CrudSabores.Location = new Point(-4, 306);
            CrudSabores.Name = "CrudSabores";
            CrudSabores.Size = new Size(488, 65);
            CrudSabores.TabIndex = 43;
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
            KeyPreview = true;
            Margin = new Padding(4, 3, 4, 3);
            Name = "CadastroSabores";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CADASTRO_SABORES";
            WindowState = FormWindowState.Maximized;
            Pnl_8_Sabores.ResumeLayout(false);
            Pnl_8_Sabores.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxImagem).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel Pnl_8_Sabores;
        private TextBox TextBoxId;
        private Label TextID;
        private TextBox TextBoxNome;
        private Label TextNome;
        private Button Btn_Salvar_Ingredientes;
        private Button VOLTAR_CAD_INGREDIENTES;
        private Label TextTipo;
        private Label TextCategoria;
        private Label TextFoto;
        private Label SABOR_INGREDIENTES;
        private Label Tit_8_Cadastro_Sabores;
        private Button Btn_8_Sair;
        private CheckedListBox checkedListBoxIngredientes;
        private ListBox listBoxCategoria;
        private ListBox listBoxTipo;
        private PictureBox pictureBoxImagem;
        private CRUD CrudSabores;
    }
}