namespace PizzariaDoZe
{
    partial class CadastroAdm
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
            TIT_ADM = new Label();
            Btn4_Voltar = new Button();
            TEXT4_EMAIL = new Label();
            Textbox4_NOME = new TextBox();
            Textbox4_ENDERECO = new TextBox();
            TEXT4_CPF = new Label();
            TEXT4_ENDERECO = new Label();
            Textbox4_EMAIL = new TextBox();
            Maskedbox4_CPF = new MaskedTextBox();
            Maskedbox4_TELEFONE = new MaskedTextBox();
            TEXT4_NOME = new Label();
            TEXT4_TELEFONE = new Label();
            panel1 = new Panel();
            crud1 = new CRUD();
            TextBox4_CNF_SENHA = new TextBox();
            Text4_CNF_SENHA = new Label();
            Text4_SENHA = new Label();
            Textbox4_SENHA = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // TIT_ADM
            // 
            TIT_ADM.AutoSize = true;
            TIT_ADM.BackColor = SystemColors.ActiveCaptionText;
            TIT_ADM.BorderStyle = BorderStyle.Fixed3D;
            TIT_ADM.Font = new Font("Copperplate Gothic Bold", 36F, FontStyle.Regular, GraphicsUnit.Point);
            TIT_ADM.Image = Properties.Resources.Screenshot_1;
            TIT_ADM.ImageAlign = ContentAlignment.TopCenter;
            TIT_ADM.Location = new Point(189, 22);
            TIT_ADM.Margin = new Padding(4, 0, 4, 0);
            TIT_ADM.Name = "TIT_ADM";
            TIT_ADM.Size = new Size(894, 55);
            TIT_ADM.TabIndex = 0;
            TIT_ADM.Text = "CADASTRO DE ADMINISTRADOR";
            TIT_ADM.TextAlign = ContentAlignment.TopCenter;
            // 
            // Btn4_Voltar
            // 
            Btn4_Voltar.Anchor = AnchorStyles.None;
            Btn4_Voltar.BackColor = SystemColors.ActiveCaptionText;
            Btn4_Voltar.BackgroundImage = Properties.Resources.Screenshot_1;
            Btn4_Voltar.BackgroundImageLayout = ImageLayout.Stretch;
            Btn4_Voltar.Cursor = Cursors.Hand;
            Btn4_Voltar.FlatStyle = FlatStyle.Flat;
            Btn4_Voltar.Font = new Font("Copperplate Gothic Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            Btn4_Voltar.Location = new Point(500, 496);
            Btn4_Voltar.Margin = new Padding(3, 2, 3, 2);
            Btn4_Voltar.Name = "Btn4_Voltar";
            Btn4_Voltar.Size = new Size(139, 33);
            Btn4_Voltar.TabIndex = 25;
            Btn4_Voltar.Text = "SAIR";
            Btn4_Voltar.UseVisualStyleBackColor = false;
            Btn4_Voltar.Click += Btn4_Voltar_Click;
            // 
            // TEXT4_EMAIL
            // 
            TEXT4_EMAIL.Anchor = AnchorStyles.None;
            TEXT4_EMAIL.AutoSize = true;
            TEXT4_EMAIL.BackColor = Color.Transparent;
            TEXT4_EMAIL.Font = new Font("Copperplate Gothic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TEXT4_EMAIL.Location = new Point(351, 135);
            TEXT4_EMAIL.Margin = new Padding(2, 0, 2, 0);
            TEXT4_EMAIL.Name = "TEXT4_EMAIL";
            TEXT4_EMAIL.Size = new Size(64, 18);
            TEXT4_EMAIL.TabIndex = 15;
            TEXT4_EMAIL.Text = "EMAIL";
            TEXT4_EMAIL.TextAlign = ContentAlignment.TopCenter;
            // 
            // Textbox4_NOME
            // 
            Textbox4_NOME.Anchor = AnchorStyles.None;
            Textbox4_NOME.BackColor = SystemColors.ButtonHighlight;
            Textbox4_NOME.Cursor = Cursors.IBeam;
            Textbox4_NOME.Font = new Font("Copperplate Gothic Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Textbox4_NOME.ForeColor = SystemColors.MenuText;
            Textbox4_NOME.Location = new Point(285, 27);
            Textbox4_NOME.Margin = new Padding(2, 2, 2, 2);
            Textbox4_NOME.Name = "Textbox4_NOME";
            Textbox4_NOME.Size = new Size(183, 21);
            Textbox4_NOME.TabIndex = 14;
            // 
            // Textbox4_ENDERECO
            // 
            Textbox4_ENDERECO.Anchor = AnchorStyles.None;
            Textbox4_ENDERECO.Cursor = Cursors.IBeam;
            Textbox4_ENDERECO.Font = new Font("Copperplate Gothic Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Textbox4_ENDERECO.Location = new Point(287, 112);
            Textbox4_ENDERECO.Margin = new Padding(2, 2, 2, 2);
            Textbox4_ENDERECO.Name = "Textbox4_ENDERECO";
            Textbox4_ENDERECO.PasswordChar = '*';
            Textbox4_ENDERECO.RightToLeft = RightToLeft.No;
            Textbox4_ENDERECO.Size = new Size(184, 21);
            Textbox4_ENDERECO.TabIndex = 23;
            // 
            // TEXT4_CPF
            // 
            TEXT4_CPF.Anchor = AnchorStyles.None;
            TEXT4_CPF.AutoSize = true;
            TEXT4_CPF.BackColor = Color.Transparent;
            TEXT4_CPF.Font = new Font("Copperplate Gothic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TEXT4_CPF.Location = new Point(352, 50);
            TEXT4_CPF.Margin = new Padding(2, 0, 2, 0);
            TEXT4_CPF.Name = "TEXT4_CPF";
            TEXT4_CPF.Size = new Size(45, 18);
            TEXT4_CPF.TabIndex = 16;
            TEXT4_CPF.Text = "CPF";
            TEXT4_CPF.TextAlign = ContentAlignment.TopCenter;
            // 
            // TEXT4_ENDERECO
            // 
            TEXT4_ENDERECO.Anchor = AnchorStyles.None;
            TEXT4_ENDERECO.AutoSize = true;
            TEXT4_ENDERECO.BackColor = Color.Transparent;
            TEXT4_ENDERECO.Font = new Font("Copperplate Gothic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TEXT4_ENDERECO.Location = new Point(327, 92);
            TEXT4_ENDERECO.Margin = new Padding(2, 0, 2, 0);
            TEXT4_ENDERECO.Name = "TEXT4_ENDERECO";
            TEXT4_ENDERECO.Size = new Size(111, 18);
            TEXT4_ENDERECO.TabIndex = 19;
            TEXT4_ENDERECO.Text = "ENDEREÇO";
            TEXT4_ENDERECO.TextAlign = ContentAlignment.TopCenter;
            // 
            // Textbox4_EMAIL
            // 
            Textbox4_EMAIL.Anchor = AnchorStyles.None;
            Textbox4_EMAIL.Font = new Font("Copperplate Gothic Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Textbox4_EMAIL.Location = new Point(288, 155);
            Textbox4_EMAIL.Margin = new Padding(2, 2, 2, 2);
            Textbox4_EMAIL.Name = "Textbox4_EMAIL";
            Textbox4_EMAIL.PasswordChar = '*';
            Textbox4_EMAIL.Size = new Size(183, 21);
            Textbox4_EMAIL.TabIndex = 22;
            // 
            // Maskedbox4_CPF
            // 
            Maskedbox4_CPF.Anchor = AnchorStyles.None;
            Maskedbox4_CPF.Font = new Font("Copperplate Gothic Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Maskedbox4_CPF.Location = new Point(288, 70);
            Maskedbox4_CPF.Margin = new Padding(2, 2, 2, 2);
            Maskedbox4_CPF.Mask = "000.000.000-00";
            Maskedbox4_CPF.Name = "Maskedbox4_CPF";
            Maskedbox4_CPF.RightToLeft = RightToLeft.No;
            Maskedbox4_CPF.Size = new Size(183, 21);
            Maskedbox4_CPF.TabIndex = 21;
            // 
            // Maskedbox4_TELEFONE
            // 
            Maskedbox4_TELEFONE.Anchor = AnchorStyles.None;
            Maskedbox4_TELEFONE.Font = new Font("Copperplate Gothic Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Maskedbox4_TELEFONE.Location = new Point(288, 198);
            Maskedbox4_TELEFONE.Margin = new Padding(2, 2, 2, 2);
            Maskedbox4_TELEFONE.Mask = "(999) 00 0000-0000";
            Maskedbox4_TELEFONE.Name = "Maskedbox4_TELEFONE";
            Maskedbox4_TELEFONE.Size = new Size(183, 21);
            Maskedbox4_TELEFONE.TabIndex = 20;
            Maskedbox4_TELEFONE.MaskInputRejected += Maskedbox4_TELEFONE_MaskInputRejected;
            // 
            // TEXT4_NOME
            // 
            TEXT4_NOME.Anchor = AnchorStyles.None;
            TEXT4_NOME.AutoSize = true;
            TEXT4_NOME.BackColor = Color.Transparent;
            TEXT4_NOME.Font = new Font("Copperplate Gothic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TEXT4_NOME.ForeColor = SystemColors.Info;
            TEXT4_NOME.Location = new Point(352, 7);
            TEXT4_NOME.Margin = new Padding(2, 0, 2, 0);
            TEXT4_NOME.Name = "TEXT4_NOME";
            TEXT4_NOME.Size = new Size(63, 18);
            TEXT4_NOME.TabIndex = 18;
            TEXT4_NOME.Text = "NOME";
            TEXT4_NOME.TextAlign = ContentAlignment.TopCenter;
            // 
            // TEXT4_TELEFONE
            // 
            TEXT4_TELEFONE.Anchor = AnchorStyles.None;
            TEXT4_TELEFONE.AutoSize = true;
            TEXT4_TELEFONE.BackColor = Color.Transparent;
            TEXT4_TELEFONE.Font = new Font("Copperplate Gothic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TEXT4_TELEFONE.Location = new Point(332, 178);
            TEXT4_TELEFONE.Margin = new Padding(2, 0, 2, 0);
            TEXT4_TELEFONE.Name = "TEXT4_TELEFONE";
            TEXT4_TELEFONE.Size = new Size(106, 18);
            TEXT4_TELEFONE.TabIndex = 17;
            TEXT4_TELEFONE.Text = "TELEFONE";
            TEXT4_TELEFONE.TextAlign = ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.Screenshot_1;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(crud1);
            panel1.Controls.Add(TextBox4_CNF_SENHA);
            panel1.Controls.Add(Text4_CNF_SENHA);
            panel1.Controls.Add(Text4_SENHA);
            panel1.Controls.Add(Textbox4_SENHA);
            panel1.Controls.Add(TEXT4_NOME);
            panel1.Controls.Add(TEXT4_TELEFONE);
            panel1.Controls.Add(TEXT4_EMAIL);
            panel1.Controls.Add(Maskedbox4_TELEFONE);
            panel1.Controls.Add(Maskedbox4_CPF);
            panel1.Controls.Add(Textbox4_NOME);
            panel1.Controls.Add(Textbox4_EMAIL);
            panel1.Controls.Add(Textbox4_ENDERECO);
            panel1.Controls.Add(TEXT4_ENDERECO);
            panel1.Controls.Add(TEXT4_CPF);
            panel1.Location = new Point(189, 85);
            panel1.Margin = new Padding(2, 2, 2, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(741, 398);
            panel1.TabIndex = 26;
            // 
            // crud1
            // 
            crud1.BackColor = SystemColors.Desktop;
            crud1.ForeColor = SystemColors.Info;
            crud1.Location = new Point(0, 325);
            crud1.Margin = new Padding(5, 4, 5, 4);
            crud1.Name = "crud1";
            crud1.Size = new Size(736, 69);
            crud1.TabIndex = 30;
            crud1.Load += crud1_Load;
            // 
            // TextBox4_CNF_SENHA
            // 
            TextBox4_CNF_SENHA.Font = new Font("Copperplate Gothic Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            TextBox4_CNF_SENHA.Location = new Point(286, 284);
            TextBox4_CNF_SENHA.Margin = new Padding(2, 2, 2, 2);
            TextBox4_CNF_SENHA.Name = "TextBox4_CNF_SENHA";
            TextBox4_CNF_SENHA.Size = new Size(183, 21);
            TextBox4_CNF_SENHA.TabIndex = 29;
            // 
            // Text4_CNF_SENHA
            // 
            Text4_CNF_SENHA.AutoSize = true;
            Text4_CNF_SENHA.BackColor = Color.Transparent;
            Text4_CNF_SENHA.Font = new Font("Copperplate Gothic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Text4_CNF_SENHA.Location = new Point(279, 264);
            Text4_CNF_SENHA.Margin = new Padding(2, 0, 2, 0);
            Text4_CNF_SENHA.Name = "Text4_CNF_SENHA";
            Text4_CNF_SENHA.Size = new Size(189, 18);
            Text4_CNF_SENHA.TabIndex = 28;
            Text4_CNF_SENHA.Text = "CONFIRMAR SENHA";
            Text4_CNF_SENHA.Click += Text4_CNF_SENHA_Click;
            // 
            // Text4_SENHA
            // 
            Text4_SENHA.AutoSize = true;
            Text4_SENHA.BackColor = Color.Transparent;
            Text4_SENHA.Font = new Font("Copperplate Gothic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Text4_SENHA.Location = new Point(342, 221);
            Text4_SENHA.Margin = new Padding(2, 0, 2, 0);
            Text4_SENHA.Name = "Text4_SENHA";
            Text4_SENHA.Size = new Size(73, 18);
            Text4_SENHA.TabIndex = 27;
            Text4_SENHA.Text = "SENHA";
            Text4_SENHA.Click += Text4_SENHA_Click;
            // 
            // Textbox4_SENHA
            // 
            Textbox4_SENHA.Font = new Font("Copperplate Gothic Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Textbox4_SENHA.Location = new Point(288, 241);
            Textbox4_SENHA.Margin = new Padding(2, 2, 2, 2);
            Textbox4_SENHA.Name = "Textbox4_SENHA";
            Textbox4_SENHA.Size = new Size(183, 21);
            Textbox4_SENHA.TabIndex = 26;
            // 
            // TELA_ADM
            // 
            AutoScaleDimensions = new SizeF(12F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.istockphoto_1137028124_612x612;
            ClientSize = new Size(1096, 540);
            Controls.Add(panel1);
            Controls.Add(TIT_ADM);
            Controls.Add(Btn4_Voltar);
            Font = new Font("Copperplate Gothic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = SystemColors.Info;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(6, 4, 6, 4);
            Name = "TELA_ADM";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TELA_ADM";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label TIT_ADM;
        private Button Btn4_Voltar;
        private Label TEXT4_EMAIL;
        private TextBox Textbox4_NOME;
        private TextBox Textbox4_ENDERECO;
        private Label TEXT4_CPF;
        private Label TEXT4_ENDERECO;
        private TextBox Textbox4_EMAIL;
        private MaskedTextBox Maskedbox4_CPF;
        private MaskedTextBox Maskedbox4_TELEFONE;
        private Label TEXT4_NOME;
        private Label TEXT4_TELEFONE;
        private Panel panel1;
        private TextBox Textbox4_SENHA;
        private TextBox TextBox4_CNF_SENHA;
        private Label Text4_CNF_SENHA;
        private Label Text4_SENHA;
        private CRUD crud1;
    }
}