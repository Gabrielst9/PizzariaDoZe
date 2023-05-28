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
            TextEmail = new Label();
            TIT_CPF = new Label();
            TIT_TELEFONE = new Label();
            TextNome = new Label();
            Maskedbox_TELEFONE = new MaskedTextBox();
            Maskedbox_CPF = new MaskedTextBox();
            Textbox_EMAIL = new TextBox();
            PNL2_CADRASTRO_CLI = new Panel();
            crud1 = new CRUD();
            Btn_Sair = new Button();
            splitContainer1 = new SplitContainer();
            TextBoxIDCliente = new TextBox();
            TextIDCliente = new Label();
            label1 = new Label();
            textBox1 = new TextBox();
            PNL2_CADRASTRO_CLI.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // Textbox_NOME
            // 
            Textbox_NOME.Anchor = AnchorStyles.None;
            Textbox_NOME.BackColor = SystemColors.ButtonHighlight;
            Textbox_NOME.Cursor = Cursors.IBeam;
            Textbox_NOME.Font = new Font("Copperplate Gothic Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Textbox_NOME.ForeColor = SystemColors.MenuText;
            Textbox_NOME.Location = new Point(10, 96);
            Textbox_NOME.MaxLength = 80;
            Textbox_NOME.Name = "Textbox_NOME";
            Textbox_NOME.Size = new Size(319, 21);
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
            TITULO_CADASTRO_CLI.Location = new Point(237, 48);
            TITULO_CADASTRO_CLI.Name = "TITULO_CADASTRO_CLI";
            TITULO_CADASTRO_CLI.Size = new Size(701, 55);
            TITULO_CADASTRO_CLI.TabIndex = 1;
            TITULO_CADASTRO_CLI.Text = "CADASTRO DE CLIENTES";
            TITULO_CADASTRO_CLI.TextAlign = ContentAlignment.TopCenter;
            // 
            // TextEmail
            // 
            TextEmail.Anchor = AnchorStyles.None;
            TextEmail.AutoSize = true;
            TextEmail.BackColor = Color.Transparent;
            TextEmail.Font = new Font("Copperplate Gothic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TextEmail.Location = new Point(9, 197);
            TextEmail.Name = "TextEmail";
            TextEmail.Size = new Size(64, 18);
            TextEmail.TabIndex = 2;
            TextEmail.Text = "EMAIL";
            TextEmail.TextAlign = ContentAlignment.TopCenter;
            // 
            // TIT_CPF
            // 
            TIT_CPF.Anchor = AnchorStyles.None;
            TIT_CPF.AutoSize = true;
            TIT_CPF.BackColor = Color.Transparent;
            TIT_CPF.Font = new Font("Copperplate Gothic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TIT_CPF.Location = new Point(10, 133);
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
            TIT_TELEFONE.Location = new Point(131, 133);
            TIT_TELEFONE.Name = "TIT_TELEFONE";
            TIT_TELEFONE.Size = new Size(106, 18);
            TIT_TELEFONE.TabIndex = 4;
            TIT_TELEFONE.Text = "TELEFONE";
            TIT_TELEFONE.TextAlign = ContentAlignment.TopCenter;
            // 
            // TextNome
            // 
            TextNome.Anchor = AnchorStyles.None;
            TextNome.AutoSize = true;
            TextNome.BackColor = Color.Transparent;
            TextNome.Font = new Font("Copperplate Gothic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TextNome.ForeColor = SystemColors.Info;
            TextNome.Location = new Point(10, 75);
            TextNome.Name = "TextNome";
            TextNome.Size = new Size(63, 18);
            TextNome.TabIndex = 5;
            TextNome.Text = "NOME";
            TextNome.TextAlign = ContentAlignment.TopCenter;
            // 
            // Maskedbox_TELEFONE
            // 
            Maskedbox_TELEFONE.Anchor = AnchorStyles.None;
            Maskedbox_TELEFONE.Location = new Point(11, 157);
            Maskedbox_TELEFONE.Mask = "(999) 000-0000";
            Maskedbox_TELEFONE.Name = "Maskedbox_TELEFONE";
            Maskedbox_TELEFONE.Size = new Size(92, 23);
            Maskedbox_TELEFONE.TabIndex = 4;
            // 
            // Maskedbox_CPF
            // 
            Maskedbox_CPF.Anchor = AnchorStyles.None;
            Maskedbox_CPF.Location = new Point(131, 157);
            Maskedbox_CPF.Mask = "000.000.000-00";
            Maskedbox_CPF.Name = "Maskedbox_CPF";
            Maskedbox_CPF.RightToLeft = RightToLeft.No;
            Maskedbox_CPF.Size = new Size(106, 23);
            Maskedbox_CPF.TabIndex = 1;
            Maskedbox_CPF.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            // 
            // Textbox_EMAIL
            // 
            Textbox_EMAIL.Anchor = AnchorStyles.None;
            Textbox_EMAIL.Location = new Point(9, 218);
            Textbox_EMAIL.Name = "Textbox_EMAIL";
            Textbox_EMAIL.PasswordChar = '*';
            Textbox_EMAIL.Size = new Size(320, 23);
            Textbox_EMAIL.TabIndex = 3;
            // 
            // PNL2_CADRASTRO_CLI
            // 
            PNL2_CADRASTRO_CLI.Anchor = AnchorStyles.None;
            PNL2_CADRASTRO_CLI.BackColor = Color.Transparent;
            PNL2_CADRASTRO_CLI.BackgroundImage = Properties.Resources.Screenshot_1;
            PNL2_CADRASTRO_CLI.BackgroundImageLayout = ImageLayout.Stretch;
            PNL2_CADRASTRO_CLI.BorderStyle = BorderStyle.FixedSingle;
            PNL2_CADRASTRO_CLI.Controls.Add(TextIDCliente);
            PNL2_CADRASTRO_CLI.Controls.Add(TextBoxIDCliente);
            PNL2_CADRASTRO_CLI.Controls.Add(TextEmail);
            PNL2_CADRASTRO_CLI.Controls.Add(Textbox_NOME);
            PNL2_CADRASTRO_CLI.Controls.Add(TIT_CPF);
            PNL2_CADRASTRO_CLI.Controls.Add(Textbox_EMAIL);
            PNL2_CADRASTRO_CLI.Controls.Add(Maskedbox_CPF);
            PNL2_CADRASTRO_CLI.Controls.Add(Maskedbox_TELEFONE);
            PNL2_CADRASTRO_CLI.Controls.Add(TextNome);
            PNL2_CADRASTRO_CLI.Controls.Add(TIT_TELEFONE);
            PNL2_CADRASTRO_CLI.ForeColor = SystemColors.Info;
            PNL2_CADRASTRO_CLI.Location = new Point(0, 3);
            PNL2_CADRASTRO_CLI.Name = "PNL2_CADRASTRO_CLI";
            PNL2_CADRASTRO_CLI.Size = new Size(419, 417);
            PNL2_CADRASTRO_CLI.TabIndex = 12;
            PNL2_CADRASTRO_CLI.Paint += PNL2_CADRASTRO_CLI_Paint;
            // 
            // crud1
            // 
            crud1.BackColor = SystemColors.Desktop;
            crud1.ForeColor = SystemColors.Info;
            crud1.Location = new Point(195, 448);
            crud1.Margin = new Padding(4, 5, 4, 5);
            crud1.Name = "crud1";
            crud1.Size = new Size(452, 65);
            crud1.TabIndex = 5;
            crud1.Load += crud1_Load;
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
            Btn_Sair.Location = new Point(473, 505);
            Btn_Sair.Margin = new Padding(4, 3, 4, 3);
            Btn_Sair.Name = "Btn_Sair";
            Btn_Sair.Size = new Size(229, 32);
            Btn_Sair.TabIndex = 13;
            Btn_Sair.Text = "SAIR";
            Btn_Sair.UseVisualStyleBackColor = false;
            Btn_Sair.Click += Btn_Sair_Click;
            // 
            // splitContainer1
            // 
            splitContainer1.Location = new Point(5, 23);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(PNL2_CADRASTRO_CLI);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.BackgroundImage = Properties.Resources.Screenshot_1;
            splitContainer1.Panel2.BackgroundImageLayout = ImageLayout.Stretch;
            splitContainer1.Panel2.Controls.Add(label1);
            splitContainer1.Panel2.Controls.Add(textBox1);
            splitContainer1.Panel2.ForeColor = SystemColors.Info;
            splitContainer1.Size = new Size(879, 420);
            splitContainer1.SplitterDistance = 425;
            splitContainer1.TabIndex = 14;
            // 
            // TextBoxIDCliente
            // 
            TextBoxIDCliente.Anchor = AnchorStyles.None;
            TextBoxIDCliente.BackColor = SystemColors.ButtonHighlight;
            TextBoxIDCliente.Cursor = Cursors.IBeam;
            TextBoxIDCliente.Enabled = false;
            TextBoxIDCliente.Font = new Font("Copperplate Gothic Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            TextBoxIDCliente.ForeColor = SystemColors.MenuText;
            TextBoxIDCliente.Location = new Point(10, 36);
            TextBoxIDCliente.MaxLength = 80;
            TextBoxIDCliente.Name = "TextBoxIDCliente";
            TextBoxIDCliente.Size = new Size(45, 21);
            TextBoxIDCliente.TabIndex = 6;
            // 
            // TextIDCliente
            // 
            TextIDCliente.Anchor = AnchorStyles.None;
            TextIDCliente.AutoSize = true;
            TextIDCliente.BackColor = Color.Transparent;
            TextIDCliente.Font = new Font("Copperplate Gothic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TextIDCliente.Location = new Point(10, 15);
            TextIDCliente.Name = "TextIDCliente";
            TextIDCliente.Size = new Size(26, 18);
            TextIDCliente.TabIndex = 7;
            TextIDCliente.Text = "ID";
            TextIDCliente.TextAlign = ContentAlignment.TopCenter;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Copperplate Gothic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(29, 25);
            label1.Name = "label1";
            label1.Size = new Size(26, 18);
            label1.TabIndex = 9;
            label1.Text = "ID";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.None;
            textBox1.BackColor = SystemColors.ButtonHighlight;
            textBox1.Cursor = Cursors.IBeam;
            textBox1.Enabled = false;
            textBox1.Font = new Font("Copperplate Gothic Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.ForeColor = SystemColors.MenuText;
            textBox1.Location = new Point(29, 46);
            textBox1.MaxLength = 80;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(45, 21);
            textBox1.TabIndex = 8;
            // 
            // CadastroCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            BackgroundImage = Properties.Resources.istockphoto_1137028124_612x612;
            ClientSize = new Size(1174, 550);
            Controls.Add(crud1);
            Controls.Add(splitContainer1);
            Controls.Add(Btn_Sair);
            Controls.Add(TITULO_CADASTRO_CLI);
            FormBorderStyle = FormBorderStyle.None;
            KeyPreview = true;
            Name = "CadastroCliente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TELA_CLIENTES";
            WindowState = FormWindowState.Maximized;
            PNL2_CADRASTRO_CLI.ResumeLayout(false);
            PNL2_CADRASTRO_CLI.PerformLayout();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Textbox_NOME;
        private Label TITULO_CADASTRO_CLI;
        private Label TextEmail;
        private Label TIT_CPF;
        private Label TIT_TELEFONE;
        private Label TextNome;
        private MaskedTextBox Maskedbox_TELEFONE;
        private MaskedTextBox Maskedbox_CPF;
        private TextBox Textbox_EMAIL;
        private Panel PNL2_CADRASTRO_CLI;
        private CRUD crud1;
        private Button Btn_Sair;
        private SplitContainer splitContainer1;
        private Label TextIDCliente;
        private TextBox TextBoxIDCliente;
        private Label label1;
        private TextBox textBox1;
    }
}