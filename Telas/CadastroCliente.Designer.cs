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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroCliente));
            TITULO_CADASTRO_CLI = new Label();
            crud1 = new CRUD();
            Btn_Sair = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel1 = new Panel();
            TextIDCliente = new Label();
            TextBoxIDCliente = new TextBox();
            TextEmail = new Label();
            Textbox_NOME = new TextBox();
            TIT_CPF = new Label();
            Textbox_EMAIL = new TextBox();
            Maskedbox_CPF = new MaskedTextBox();
            Maskedbox_TELEFONE = new MaskedTextBox();
            TextNome = new Label();
            TIT_TELEFONE = new Label();
            panel2 = new Panel();
            enderecoControl1 = new Telas.EnderecoControl();
            panel3 = new Panel();
            panel4 = new Panel();
            panel5 = new Panel();
            flowLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
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
            // crud1
            // 
            crud1.BackColor = SystemColors.Desktop;
            crud1.ForeColor = SystemColors.Info;
            crud1.Location = new Point(164, 10);
            crud1.Margin = new Padding(4, 5, 4, 5);
            crud1.Name = "crud1";
            crud1.Size = new Size(456, 66);
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
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(panel1);
            flowLayoutPanel1.Controls.Add(panel2);
            flowLayoutPanel1.Controls.Add(panel5);
            flowLayoutPanel1.Controls.Add(panel4);
            flowLayoutPanel1.Location = new Point(195, 119);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(784, 380);
            flowLayoutPanel1.TabIndex = 14;
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.Screenshot_1;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(TextIDCliente);
            panel1.Controls.Add(TextBoxIDCliente);
            panel1.Controls.Add(TextEmail);
            panel1.Controls.Add(Textbox_NOME);
            panel1.Controls.Add(TIT_CPF);
            panel1.Controls.Add(Textbox_EMAIL);
            panel1.Controls.Add(Maskedbox_CPF);
            panel1.Controls.Add(Maskedbox_TELEFONE);
            panel1.Controls.Add(TextNome);
            panel1.Controls.Add(TIT_TELEFONE);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(327, 294);
            panel1.TabIndex = 0;
            // 
            // TextIDCliente
            // 
            TextIDCliente.Anchor = AnchorStyles.None;
            TextIDCliente.AutoSize = true;
            TextIDCliente.BackColor = Color.Transparent;
            TextIDCliente.Font = new Font("Copperplate Gothic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TextIDCliente.ForeColor = SystemColors.Info;
            TextIDCliente.Location = new Point(3, 9);
            TextIDCliente.Name = "TextIDCliente";
            TextIDCliente.Size = new Size(26, 18);
            TextIDCliente.TabIndex = 17;
            TextIDCliente.Text = "ID";
            TextIDCliente.TextAlign = ContentAlignment.TopCenter;
            // 
            // TextBoxIDCliente
            // 
            TextBoxIDCliente.Anchor = AnchorStyles.None;
            TextBoxIDCliente.BackColor = SystemColors.ButtonHighlight;
            TextBoxIDCliente.Cursor = Cursors.IBeam;
            TextBoxIDCliente.Enabled = false;
            TextBoxIDCliente.Font = new Font("Copperplate Gothic Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            TextBoxIDCliente.ForeColor = SystemColors.MenuText;
            TextBoxIDCliente.Location = new Point(3, 30);
            TextBoxIDCliente.MaxLength = 80;
            TextBoxIDCliente.Name = "TextBoxIDCliente";
            TextBoxIDCliente.Size = new Size(45, 21);
            TextBoxIDCliente.TabIndex = 16;
            // 
            // TextEmail
            // 
            TextEmail.Anchor = AnchorStyles.None;
            TextEmail.AutoSize = true;
            TextEmail.BackColor = Color.Transparent;
            TextEmail.Font = new Font("Copperplate Gothic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TextEmail.ForeColor = SystemColors.Info;
            TextEmail.Location = new Point(3, 241);
            TextEmail.Name = "TextEmail";
            TextEmail.Size = new Size(64, 18);
            TextEmail.TabIndex = 10;
            TextEmail.Text = "EMAIL";
            TextEmail.TextAlign = ContentAlignment.TopCenter;
            // 
            // Textbox_NOME
            // 
            Textbox_NOME.Anchor = AnchorStyles.None;
            Textbox_NOME.BackColor = SystemColors.ButtonHighlight;
            Textbox_NOME.Cursor = Cursors.IBeam;
            Textbox_NOME.Font = new Font("Copperplate Gothic Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Textbox_NOME.ForeColor = SystemColors.MenuText;
            Textbox_NOME.Location = new Point(3, 92);
            Textbox_NOME.MaxLength = 80;
            Textbox_NOME.Name = "Textbox_NOME";
            Textbox_NOME.Size = new Size(319, 21);
            Textbox_NOME.TabIndex = 8;
            // 
            // TIT_CPF
            // 
            TIT_CPF.Anchor = AnchorStyles.None;
            TIT_CPF.AutoSize = true;
            TIT_CPF.BackColor = Color.Transparent;
            TIT_CPF.Font = new Font("Copperplate Gothic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TIT_CPF.ForeColor = SystemColors.Info;
            TIT_CPF.Location = new Point(3, 125);
            TIT_CPF.Name = "TIT_CPF";
            TIT_CPF.Size = new Size(45, 18);
            TIT_CPF.TabIndex = 11;
            TIT_CPF.Text = "CPF";
            TIT_CPF.TextAlign = ContentAlignment.TopCenter;
            // 
            // Textbox_EMAIL
            // 
            Textbox_EMAIL.Anchor = AnchorStyles.None;
            Textbox_EMAIL.Location = new Point(3, 262);
            Textbox_EMAIL.Name = "Textbox_EMAIL";
            Textbox_EMAIL.PasswordChar = '*';
            Textbox_EMAIL.Size = new Size(320, 23);
            Textbox_EMAIL.TabIndex = 12;
            // 
            // Maskedbox_CPF
            // 
            Maskedbox_CPF.Anchor = AnchorStyles.None;
            Maskedbox_CPF.Location = new Point(3, 209);
            Maskedbox_CPF.Mask = "000.000.000-00";
            Maskedbox_CPF.Name = "Maskedbox_CPF";
            Maskedbox_CPF.RightToLeft = RightToLeft.No;
            Maskedbox_CPF.Size = new Size(106, 23);
            Maskedbox_CPF.TabIndex = 9;
            Maskedbox_CPF.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            // 
            // Maskedbox_TELEFONE
            // 
            Maskedbox_TELEFONE.Anchor = AnchorStyles.None;
            Maskedbox_TELEFONE.Location = new Point(3, 149);
            Maskedbox_TELEFONE.Mask = "(999) 000-0000";
            Maskedbox_TELEFONE.Name = "Maskedbox_TELEFONE";
            Maskedbox_TELEFONE.Size = new Size(92, 23);
            Maskedbox_TELEFONE.TabIndex = 13;
            // 
            // TextNome
            // 
            TextNome.Anchor = AnchorStyles.None;
            TextNome.AutoSize = true;
            TextNome.BackColor = Color.Transparent;
            TextNome.Font = new Font("Copperplate Gothic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TextNome.ForeColor = SystemColors.Info;
            TextNome.Location = new Point(3, 71);
            TextNome.Name = "TextNome";
            TextNome.Size = new Size(63, 18);
            TextNome.TabIndex = 15;
            TextNome.Text = "NOME";
            TextNome.TextAlign = ContentAlignment.TopCenter;
            // 
            // TIT_TELEFONE
            // 
            TIT_TELEFONE.Anchor = AnchorStyles.None;
            TIT_TELEFONE.AutoSize = true;
            TIT_TELEFONE.BackColor = Color.Transparent;
            TIT_TELEFONE.Font = new Font("Copperplate Gothic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TIT_TELEFONE.ForeColor = SystemColors.Info;
            TIT_TELEFONE.Location = new Point(3, 185);
            TIT_TELEFONE.Name = "TIT_TELEFONE";
            TIT_TELEFONE.Size = new Size(106, 18);
            TIT_TELEFONE.TabIndex = 14;
            TIT_TELEFONE.Text = "TELEFONE";
            TIT_TELEFONE.TextAlign = ContentAlignment.TopCenter;
            // 
            // panel2
            // 
            panel2.Controls.Add(enderecoControl1);
            panel2.Controls.Add(panel3);
            panel2.Location = new Point(336, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(443, 294);
            panel2.TabIndex = 0;
            // 
            // enderecoControl1
            // 
            enderecoControl1.BackgroundImage = (Image)resources.GetObject("enderecoControl1.BackgroundImage");
            enderecoControl1.BackgroundImageLayout = ImageLayout.Stretch;
            enderecoControl1.ForeColor = SystemColors.Info;
            enderecoControl1.Location = new Point(0, 0);
            enderecoControl1.Name = "enderecoControl1";
            enderecoControl1.Size = new Size(440, 294);
            enderecoControl1.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.Location = new Point(471, 26);
            panel3.Name = "panel3";
            panel3.Size = new Size(295, 205);
            panel3.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.Location = new Point(3, 303);
            panel4.Name = "panel4";
            panel4.Size = new Size(631, 77);
            panel4.TabIndex = 1;
            // 
            // panel5
            // 
            panel5.Controls.Add(crud1);
            panel5.Location = new Point(0, 294);
            panel5.Name = "panel5";
            panel5.Size = new Size(784, 86);
            panel5.TabIndex = 2;
            // 
            // CadastroCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            BackgroundImage = Properties.Resources.istockphoto_1137028124_612x612;
            ClientSize = new Size(1174, 550);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(Btn_Sair);
            Controls.Add(TITULO_CADASTRO_CLI);
            FormBorderStyle = FormBorderStyle.None;
            KeyPreview = true;
            Name = "CadastroCliente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TELA_CLIENTES";
            WindowState = FormWindowState.Maximized;
            flowLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel5.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label TITULO_CADASTRO_CLI;
        private CRUD crud1;
        private Button Btn_Sair;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel1;
        private Label TextIDCliente;
        private TextBox TextBoxIDCliente;
        private Label TextEmail;
        private TextBox Textbox_NOME;
        private Label TIT_CPF;
        private TextBox Textbox_EMAIL;
        private MaskedTextBox Maskedbox_CPF;
        private MaskedTextBox Maskedbox_TELEFONE;
        private Label TextNome;
        private Label TIT_TELEFONE;
        private Panel panel2;
        private Telas.EnderecoControl enderecoControl1;
        private Panel panel3;
        private Panel panel5;
        private Panel panel4;
    }
}