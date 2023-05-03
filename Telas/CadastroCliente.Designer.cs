namespace PizzariaDoZe
{
    partial class CadastroCliente
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
            Textbox_NOME = new TextBox();
            TITULO_CADASTRO_CLI = new Label();
            TIT_EMAIL = new Label();
            TIT_CPF = new Label();
            TIT_TELEFONE = new Label();
            TEXT_NOME = new Label();
            TEXT_ENDERECO = new Label();
            Maskedbox_TELEFONE = new MaskedTextBox();
            Maskedbox_CPF = new MaskedTextBox();
            Textbox_EMAIL = new TextBox();
            Textbox_ENDERECO = new TextBox();
            PNL2_CADRASTRO_CLI = new Panel();
            crud1 = new CRUD();
            Btn_Sair = new Button();
            PNL2_CADRASTRO_CLI.SuspendLayout();
            SuspendLayout();
            // 
            // Textbox_NOME
            // 
            Textbox_NOME.Anchor = AnchorStyles.None;
            Textbox_NOME.BackColor = SystemColors.ButtonHighlight;
            Textbox_NOME.Cursor = Cursors.IBeam;
            Textbox_NOME.Font = new Font("Copperplate Gothic Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Textbox_NOME.ForeColor = SystemColors.MenuText;
            Textbox_NOME.Location = new Point(117, 31);
            Textbox_NOME.Name = "Textbox_NOME";
            Textbox_NOME.Size = new Size(228, 21);
            Textbox_NOME.TabIndex = 0;
            // 
            // TITULO_CADASTRO_CLI
            // 
            TITULO_CADASTRO_CLI.Anchor = AnchorStyles.None;
            TITULO_CADASTRO_CLI.AutoSize = true;
            TITULO_CADASTRO_CLI.BackColor = SystemColors.ActiveCaptionText;
            TITULO_CADASTRO_CLI.BorderStyle = BorderStyle.Fixed3D;
            TITULO_CADASTRO_CLI.Font = new Font("Copperplate Gothic Bold", 36F, FontStyle.Regular, GraphicsUnit.Point);
            TITULO_CADASTRO_CLI.ForeColor = SystemColors.Info;
            TITULO_CADASTRO_CLI.Image = Properties.Resources.Screenshot_1;
            TITULO_CADASTRO_CLI.Location = new Point(121, 9);
            TITULO_CADASTRO_CLI.Name = "TITULO_CADASTRO_CLI";
            TITULO_CADASTRO_CLI.Size = new Size(701, 55);
            TITULO_CADASTRO_CLI.TabIndex = 1;
            TITULO_CADASTRO_CLI.Text = "CADASTRO DE CLIENTES";
            TITULO_CADASTRO_CLI.TextAlign = ContentAlignment.TopCenter;
            // 
            // TIT_EMAIL
            // 
            TIT_EMAIL.Anchor = AnchorStyles.None;
            TIT_EMAIL.AutoSize = true;
            TIT_EMAIL.BackColor = Color.Transparent;
            TIT_EMAIL.Font = new Font("Copperplate Gothic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TIT_EMAIL.Location = new Point(197, 147);
            TIT_EMAIL.Name = "TIT_EMAIL";
            TIT_EMAIL.Size = new Size(64, 18);
            TIT_EMAIL.TabIndex = 2;
            TIT_EMAIL.Text = "EMAIL";
            TIT_EMAIL.TextAlign = ContentAlignment.TopCenter;
            // 
            // TIT_CPF
            // 
            TIT_CPF.Anchor = AnchorStyles.None;
            TIT_CPF.AutoSize = true;
            TIT_CPF.BackColor = Color.Transparent;
            TIT_CPF.Font = new Font("Copperplate Gothic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TIT_CPF.Location = new Point(207, 53);
            TIT_CPF.Name = "TIT_CPF";
            TIT_CPF.Size = new Size(45, 18);
            TIT_CPF.TabIndex = 3;
            TIT_CPF.Text = "CPF";
            TIT_CPF.TextAlign = ContentAlignment.TopCenter;
            // 
            // TIT_TELEFONE
            // 
            TIT_TELEFONE.Anchor = AnchorStyles.None;
            TIT_TELEFONE.AutoSize = true;
            TIT_TELEFONE.BackColor = Color.Transparent;
            TIT_TELEFONE.Font = new Font("Copperplate Gothic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TIT_TELEFONE.Location = new Point(176, 194);
            TIT_TELEFONE.Name = "TIT_TELEFONE";
            TIT_TELEFONE.Size = new Size(106, 18);
            TIT_TELEFONE.TabIndex = 4;
            TIT_TELEFONE.Text = "TELEFONE";
            TIT_TELEFONE.TextAlign = ContentAlignment.TopCenter;
            // 
            // TEXT_NOME
            // 
            TEXT_NOME.Anchor = AnchorStyles.None;
            TEXT_NOME.AutoSize = true;
            TEXT_NOME.BackColor = Color.Transparent;
            TEXT_NOME.Font = new Font("Copperplate Gothic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TEXT_NOME.ForeColor = SystemColors.Info;
            TEXT_NOME.Location = new Point(198, 10);
            TEXT_NOME.Name = "TEXT_NOME";
            TEXT_NOME.Size = new Size(63, 18);
            TEXT_NOME.TabIndex = 5;
            TEXT_NOME.Text = "NOME";
            TEXT_NOME.TextAlign = ContentAlignment.TopCenter;
            // 
            // TEXT_ENDERECO
            // 
            TEXT_ENDERECO.Anchor = AnchorStyles.None;
            TEXT_ENDERECO.AutoSize = true;
            TEXT_ENDERECO.BackColor = Color.Transparent;
            TEXT_ENDERECO.Font = new Font("Copperplate Gothic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TEXT_ENDERECO.Location = new Point(174, 100);
            TEXT_ENDERECO.Name = "TEXT_ENDERECO";
            TEXT_ENDERECO.Size = new Size(111, 18);
            TEXT_ENDERECO.TabIndex = 6;
            TEXT_ENDERECO.Text = "ENDEREÇO";
            TEXT_ENDERECO.TextAlign = ContentAlignment.TopCenter;
            // 
            // Maskedbox_TELEFONE
            // 
            Maskedbox_TELEFONE.Anchor = AnchorStyles.None;
            Maskedbox_TELEFONE.Location = new Point(118, 215);
            Maskedbox_TELEFONE.Mask = "(999) 00 0000-0000";
            Maskedbox_TELEFONE.Name = "Maskedbox_TELEFONE";
            Maskedbox_TELEFONE.Size = new Size(228, 23);
            Maskedbox_TELEFONE.TabIndex = 4;
            // 
            // Maskedbox_CPF
            // 
            Maskedbox_CPF.Anchor = AnchorStyles.None;
            Maskedbox_CPF.Location = new Point(118, 74);
            Maskedbox_CPF.Mask = "000.000.000-00";
            Maskedbox_CPF.Name = "Maskedbox_CPF";
            Maskedbox_CPF.RightToLeft = RightToLeft.No;
            Maskedbox_CPF.Size = new Size(228, 23);
            Maskedbox_CPF.TabIndex = 1;
            // 
            // Textbox_EMAIL
            // 
            Textbox_EMAIL.Anchor = AnchorStyles.None;
            Textbox_EMAIL.Location = new Point(117, 168);
            Textbox_EMAIL.Name = "Textbox_EMAIL";
            Textbox_EMAIL.PasswordChar = '*';
            Textbox_EMAIL.Size = new Size(228, 23);
            Textbox_EMAIL.TabIndex = 3;
            // 
            // Textbox_ENDERECO
            // 
            Textbox_ENDERECO.Anchor = AnchorStyles.None;
            Textbox_ENDERECO.Cursor = Cursors.IBeam;
            Textbox_ENDERECO.Location = new Point(117, 121);
            Textbox_ENDERECO.Name = "Textbox_ENDERECO";
            Textbox_ENDERECO.PasswordChar = '*';
            Textbox_ENDERECO.RightToLeft = RightToLeft.No;
            Textbox_ENDERECO.Size = new Size(229, 23);
            Textbox_ENDERECO.TabIndex = 2;
            // 
            // PNL2_CADRASTRO_CLI
            // 
            PNL2_CADRASTRO_CLI.Anchor = AnchorStyles.None;
            PNL2_CADRASTRO_CLI.BackColor = Color.Transparent;
            PNL2_CADRASTRO_CLI.BackgroundImage = Properties.Resources.Screenshot_1;
            PNL2_CADRASTRO_CLI.BackgroundImageLayout = ImageLayout.Stretch;
            PNL2_CADRASTRO_CLI.BorderStyle = BorderStyle.FixedSingle;
            PNL2_CADRASTRO_CLI.Controls.Add(crud1);
            PNL2_CADRASTRO_CLI.Controls.Add(TIT_EMAIL);
            PNL2_CADRASTRO_CLI.Controls.Add(Textbox_NOME);
            PNL2_CADRASTRO_CLI.Controls.Add(Textbox_ENDERECO);
            PNL2_CADRASTRO_CLI.Controls.Add(TIT_CPF);
            PNL2_CADRASTRO_CLI.Controls.Add(TEXT_ENDERECO);
            PNL2_CADRASTRO_CLI.Controls.Add(Textbox_EMAIL);
            PNL2_CADRASTRO_CLI.Controls.Add(Maskedbox_CPF);
            PNL2_CADRASTRO_CLI.Controls.Add(Maskedbox_TELEFONE);
            PNL2_CADRASTRO_CLI.Controls.Add(TEXT_NOME);
            PNL2_CADRASTRO_CLI.Controls.Add(TIT_TELEFONE);
            PNL2_CADRASTRO_CLI.ForeColor = SystemColors.Info;
            PNL2_CADRASTRO_CLI.Location = new Point(241, 95);
            PNL2_CADRASTRO_CLI.Name = "PNL2_CADRASTRO_CLI";
            PNL2_CADRASTRO_CLI.Size = new Size(461, 340);
            PNL2_CADRASTRO_CLI.TabIndex = 12;
            // 
            // crud1
            // 
            crud1.BackColor = SystemColors.Desktop;
            crud1.ForeColor = SystemColors.Info;
            crud1.Location = new Point(3, 270);
            crud1.Name = "crud1";
            crud1.Size = new Size(452, 65);
            crud1.TabIndex = 5;
            // 
            // Btn_Sair
            // 
            Btn_Sair.Anchor = AnchorStyles.None;
            Btn_Sair.BackColor = SystemColors.HotTrack;
            Btn_Sair.BackgroundImage = Properties.Resources.Screenshot_1;
            Btn_Sair.BackgroundImageLayout = ImageLayout.Stretch;
            Btn_Sair.Cursor = Cursors.Hand;
            Btn_Sair.FlatStyle = FlatStyle.Flat;
            Btn_Sair.Font = new Font("Copperplate Gothic Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            Btn_Sair.ForeColor = SystemColors.Info;
            Btn_Sair.Location = new Point(357, 466);
            Btn_Sair.Margin = new Padding(4, 3, 4, 3);
            Btn_Sair.Name = "Btn_Sair";
            Btn_Sair.Size = new Size(229, 32);
            Btn_Sair.TabIndex = 13;
            Btn_Sair.Text = "SAIR";
            Btn_Sair.UseVisualStyleBackColor = false;
            Btn_Sair.Click += Btn_Sair_Click;
            // 
            // CadastroCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            BackgroundImage = Properties.Resources.istockphoto_1137028124_612x612;
            ClientSize = new Size(942, 497);
            Controls.Add(Btn_Sair);
            Controls.Add(PNL2_CADRASTRO_CLI);
            Controls.Add(TITULO_CADASTRO_CLI);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CadastroCliente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TELA_CLIENTES";
            WindowState = FormWindowState.Maximized;
            PNL2_CADRASTRO_CLI.ResumeLayout(false);
            PNL2_CADRASTRO_CLI.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Textbox_NOME;
        private Label TITULO_CADASTRO_CLI;
        private Label TIT_EMAIL;
        private Label TIT_CPF;
        private Label TIT_TELEFONE;
        private Label TEXT_NOME;
        private Label TEXT_ENDERECO;
        private MaskedTextBox Maskedbox_TELEFONE;
        private MaskedTextBox Maskedbox_CPF;
        private TextBox Textbox_EMAIL;
        private TextBox Textbox_ENDERECO;
        private Panel PNL2_CADRASTRO_CLI;
        private CRUD crud1;
        private Button Btn_Sair;
    }
}