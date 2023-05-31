namespace PizzariaDoZe.Telas
{
    partial class userControlEndereco
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            TextBoxIdEndereco = new TextBox();
            TextCep = new Label();
            TextLogradouro = new Label();
            TextBoxLogradouro = new TextBox();
            TextBairro = new Label();
            TextBoxBairro = new TextBox();
            TextCidade = new Label();
            TextBoxCidade = new TextBox();
            TextUF = new Label();
            TextPais = new Label();
            TextBoxPais = new TextBox();
            TextNumero = new Label();
            TextBoxNumero = new TextBox();
            TextComplemento = new Label();
            TextBoxComplemento = new TextBox();
            maskedTextBoxCep = new MaskedTextBox();
            comboBoxUF = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Copperplate Gothic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Info;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(26, 18);
            label1.TabIndex = 11;
            label1.Text = "ID";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // TextBoxIdEndereco
            // 
            TextBoxIdEndereco.Anchor = AnchorStyles.None;
            TextBoxIdEndereco.BackColor = SystemColors.ControlDarkDark;
            TextBoxIdEndereco.Cursor = Cursors.IBeam;
            TextBoxIdEndereco.Font = new Font("Copperplate Gothic Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            TextBoxIdEndereco.ForeColor = SystemColors.MenuText;
            TextBoxIdEndereco.Location = new Point(3, 21);
            TextBoxIdEndereco.MaxLength = 80;
            TextBoxIdEndereco.Name = "TextBoxIdEndereco";
            TextBoxIdEndereco.ReadOnly = true;
            TextBoxIdEndereco.Size = new Size(33, 21);
            TextBoxIdEndereco.TabIndex = 10;
            TextBoxIdEndereco.TabStop = false;
            // 
            // TextCep
            // 
            TextCep.Anchor = AnchorStyles.None;
            TextCep.AutoSize = true;
            TextCep.BackColor = Color.Transparent;
            TextCep.Font = new Font("Copperplate Gothic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TextCep.ForeColor = SystemColors.Info;
            TextCep.Location = new Point(82, 0);
            TextCep.Name = "TextCep";
            TextCep.Size = new Size(45, 18);
            TextCep.TabIndex = 13;
            TextCep.Text = "CEP";
            TextCep.TextAlign = ContentAlignment.TopCenter;
            // 
            // TextLogradouro
            // 
            TextLogradouro.Anchor = AnchorStyles.None;
            TextLogradouro.AutoSize = true;
            TextLogradouro.BackColor = Color.Transparent;
            TextLogradouro.Font = new Font("Copperplate Gothic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TextLogradouro.ForeColor = SystemColors.Info;
            TextLogradouro.Location = new Point(3, 63);
            TextLogradouro.Name = "TextLogradouro";
            TextLogradouro.Size = new Size(119, 18);
            TextLogradouro.TabIndex = 15;
            TextLogradouro.Text = "Logradouro";
            TextLogradouro.TextAlign = ContentAlignment.TopCenter;
            // 
            // TextBoxLogradouro
            // 
            TextBoxLogradouro.Anchor = AnchorStyles.None;
            TextBoxLogradouro.BackColor = SystemColors.ButtonHighlight;
            TextBoxLogradouro.Cursor = Cursors.IBeam;
            TextBoxLogradouro.Font = new Font("Copperplate Gothic Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            TextBoxLogradouro.ForeColor = SystemColors.MenuText;
            TextBoxLogradouro.Location = new Point(3, 84);
            TextBoxLogradouro.MaxLength = 80;
            TextBoxLogradouro.Name = "TextBoxLogradouro";
            TextBoxLogradouro.Size = new Size(299, 21);
            TextBoxLogradouro.TabIndex = 52;
            // 
            // TextBairro
            // 
            TextBairro.Anchor = AnchorStyles.None;
            TextBairro.AutoSize = true;
            TextBairro.BackColor = Color.Transparent;
            TextBairro.Font = new Font("Copperplate Gothic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TextBairro.ForeColor = SystemColors.Info;
            TextBairro.Location = new Point(213, 0);
            TextBairro.Name = "TextBairro";
            TextBairro.Size = new Size(70, 18);
            TextBairro.TabIndex = 17;
            TextBairro.Text = "Bairro";
            TextBairro.TextAlign = ContentAlignment.TopCenter;
            // 
            // TextBoxBairro
            // 
            TextBoxBairro.Anchor = AnchorStyles.None;
            TextBoxBairro.BackColor = SystemColors.ButtonHighlight;
            TextBoxBairro.Cursor = Cursors.IBeam;
            TextBoxBairro.Font = new Font("Copperplate Gothic Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            TextBoxBairro.ForeColor = SystemColors.MenuText;
            TextBoxBairro.Location = new Point(213, 21);
            TextBoxBairro.MaxLength = 80;
            TextBoxBairro.Name = "TextBoxBairro";
            TextBoxBairro.Size = new Size(225, 21);
            TextBoxBairro.TabIndex = 51;
            // 
            // TextCidade
            // 
            TextCidade.Anchor = AnchorStyles.None;
            TextCidade.AutoSize = true;
            TextCidade.BackColor = Color.Transparent;
            TextCidade.Font = new Font("Copperplate Gothic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TextCidade.ForeColor = SystemColors.Info;
            TextCidade.Location = new Point(3, 119);
            TextCidade.Name = "TextCidade";
            TextCidade.Size = new Size(69, 18);
            TextCidade.TabIndex = 19;
            TextCidade.Text = "Cidade";
            TextCidade.TextAlign = ContentAlignment.TopCenter;
            // 
            // TextBoxCidade
            // 
            TextBoxCidade.Anchor = AnchorStyles.None;
            TextBoxCidade.BackColor = SystemColors.ButtonHighlight;
            TextBoxCidade.Cursor = Cursors.IBeam;
            TextBoxCidade.Font = new Font("Copperplate Gothic Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            TextBoxCidade.ForeColor = SystemColors.MenuText;
            TextBoxCidade.Location = new Point(3, 140);
            TextBoxCidade.MaxLength = 80;
            TextBoxCidade.Name = "TextBoxCidade";
            TextBoxCidade.Size = new Size(299, 21);
            TextBoxCidade.TabIndex = 53;
            // 
            // TextUF
            // 
            TextUF.Anchor = AnchorStyles.None;
            TextUF.AutoSize = true;
            TextUF.BackColor = Color.Transparent;
            TextUF.Font = new Font("Copperplate Gothic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TextUF.ForeColor = SystemColors.Info;
            TextUF.Location = new Point(3, 175);
            TextUF.Name = "TextUF";
            TextUF.Size = new Size(33, 18);
            TextUF.TabIndex = 21;
            TextUF.Text = "UF";
            TextUF.TextAlign = ContentAlignment.TopCenter;
            // 
            // TextPais
            // 
            TextPais.Anchor = AnchorStyles.None;
            TextPais.AutoSize = true;
            TextPais.BackColor = Color.Transparent;
            TextPais.Font = new Font("Copperplate Gothic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TextPais.ForeColor = SystemColors.Info;
            TextPais.Location = new Point(67, 175);
            TextPais.Name = "TextPais";
            TextPais.Size = new Size(46, 18);
            TextPais.TabIndex = 23;
            TextPais.Text = "País";
            TextPais.TextAlign = ContentAlignment.TopCenter;
            // 
            // TextBoxPais
            // 
            TextBoxPais.Anchor = AnchorStyles.None;
            TextBoxPais.BackColor = SystemColors.ButtonHighlight;
            TextBoxPais.Cursor = Cursors.IBeam;
            TextBoxPais.Font = new Font("Copperplate Gothic Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            TextBoxPais.ForeColor = SystemColors.MenuText;
            TextBoxPais.Location = new Point(67, 196);
            TextBoxPais.MaxLength = 80;
            TextBoxPais.Name = "TextBoxPais";
            TextBoxPais.Size = new Size(299, 21);
            TextBoxPais.TabIndex = 55;
            // 
            // TextNumero
            // 
            TextNumero.Anchor = AnchorStyles.None;
            TextNumero.AutoSize = true;
            TextNumero.BackColor = Color.Transparent;
            TextNumero.Font = new Font("Copperplate Gothic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TextNumero.ForeColor = SystemColors.Info;
            TextNumero.Location = new Point(3, 234);
            TextNumero.Name = "TextNumero";
            TextNumero.Size = new Size(78, 18);
            TextNumero.TabIndex = 25;
            TextNumero.Text = "Número";
            TextNumero.TextAlign = ContentAlignment.TopCenter;
            // 
            // TextBoxNumero
            // 
            TextBoxNumero.Anchor = AnchorStyles.None;
            TextBoxNumero.BackColor = SystemColors.ButtonHighlight;
            TextBoxNumero.Cursor = Cursors.IBeam;
            TextBoxNumero.Font = new Font("Copperplate Gothic Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            TextBoxNumero.ForeColor = SystemColors.MenuText;
            TextBoxNumero.Location = new Point(3, 255);
            TextBoxNumero.MaxLength = 80;
            TextBoxNumero.Name = "TextBoxNumero";
            TextBoxNumero.Size = new Size(124, 21);
            TextBoxNumero.TabIndex = 56;
            // 
            // TextComplemento
            // 
            TextComplemento.Anchor = AnchorStyles.None;
            TextComplemento.AutoSize = true;
            TextComplemento.BackColor = Color.Transparent;
            TextComplemento.Font = new Font("Copperplate Gothic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TextComplemento.ForeColor = SystemColors.Info;
            TextComplemento.Location = new Point(134, 234);
            TextComplemento.Name = "TextComplemento";
            TextComplemento.Size = new Size(129, 18);
            TextComplemento.TabIndex = 27;
            TextComplemento.Text = "Complemento";
            TextComplemento.TextAlign = ContentAlignment.TopCenter;
            // 
            // TextBoxComplemento
            // 
            TextBoxComplemento.Anchor = AnchorStyles.None;
            TextBoxComplemento.BackColor = SystemColors.ButtonHighlight;
            TextBoxComplemento.Cursor = Cursors.IBeam;
            TextBoxComplemento.Font = new Font("Copperplate Gothic Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            TextBoxComplemento.ForeColor = SystemColors.MenuText;
            TextBoxComplemento.Location = new Point(134, 255);
            TextBoxComplemento.MaxLength = 80;
            TextBoxComplemento.Name = "TextBoxComplemento";
            TextBoxComplemento.Size = new Size(299, 21);
            TextBoxComplemento.TabIndex = 57;
            // 
            // maskedTextBoxCep
            // 
            maskedTextBoxCep.Location = new Point(82, 21);
            maskedTextBoxCep.Mask = "00.000-000";
            maskedTextBoxCep.Name = "maskedTextBoxCep";
            maskedTextBoxCep.Size = new Size(108, 23);
            maskedTextBoxCep.TabIndex = 58;
            maskedTextBoxCep.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            // 
            // comboBoxUF
            // 
            comboBoxUF.FormattingEnabled = true;
            comboBoxUF.Location = new Point(3, 194);
            comboBoxUF.Name = "comboBoxUF";
            comboBoxUF.Size = new Size(46, 23);
            comboBoxUF.TabIndex = 59;
            // 
            // userControlEndereco
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Screenshot_1;
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(comboBoxUF);
            Controls.Add(maskedTextBoxCep);
            Controls.Add(TextComplemento);
            Controls.Add(TextBoxComplemento);
            Controls.Add(TextNumero);
            Controls.Add(TextBoxNumero);
            Controls.Add(TextPais);
            Controls.Add(TextBoxPais);
            Controls.Add(TextUF);
            Controls.Add(TextCidade);
            Controls.Add(TextBoxCidade);
            Controls.Add(TextBairro);
            Controls.Add(TextBoxBairro);
            Controls.Add(TextLogradouro);
            Controls.Add(TextBoxLogradouro);
            Controls.Add(TextCep);
            Controls.Add(label1);
            Controls.Add(TextBoxIdEndereco);
            DoubleBuffered = true;
            ForeColor = SystemColors.Info;
            Name = "userControlEndereco";
            Size = new Size(441, 283);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label TextCep;
        private Label TextLogradouro;
        private Label TextBairro;
        private Label TextCidade;
        private Label TextUF;
        private Label TextPais;
        private Label TextNumero;
        private Label TextComplemento;
        public TextBox TextBoxLogradouro;
        public TextBox TextBoxBairro;
        public TextBox TextBoxCidade;
        public TextBox TextBoxPais;
        public TextBox TextBoxNumero;
        public TextBox TextBoxComplemento;
        public MaskedTextBox maskedTextBoxCep;
        public ComboBox comboBoxUF;
        public TextBox TextBoxIdEndereco;
    }
}
