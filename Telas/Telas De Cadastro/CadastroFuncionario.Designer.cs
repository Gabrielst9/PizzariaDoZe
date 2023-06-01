namespace PizzariaDoZe
{
    partial class CadastroFuncionario
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
            TextCadastroDeFuncionario = new Label();
            CadastroFunc = new Panel();
            PnlFuncionario = new Panel();
            RadioBtnEntregador = new RadioButton();
            RadioBtnAtendente = new RadioButton();
            RadioBtnAdm = new RadioButton();
            ComboBoxCarteira = new ComboBox();
            TextObservacao = new Label();
            TextBoxObservacao = new TextBox();
            TextSenha = new Label();
            TextBoxSenha = new TextBox();
            DateTimePickerValidade = new DateTimePicker();
            TextValidade = new Label();
            TextCarteiraMotorista = new Label();
            TextMatricula = new Label();
            TextBoxMatricula = new TextBox();
            TextIDCliente = new Label();
            TextboxIdCliente = new TextBox();
            TextEmail = new Label();
            TextboxNome = new TextBox();
            TextCpf = new Label();
            TextboxEmail = new TextBox();
            MaskedTextboxCpf = new MaskedTextBox();
            MaskedTextboxTelefone = new MaskedTextBox();
            TextNome = new Label();
            TextTelefone = new Label();
            TextBoxIdFuncionario = new TextBox();
            this.FlowLayoutPanelFuncionarios = new FlowLayoutPanel();
            PnlUserControlEndereco = new Panel();
            PnlCadastroFuncionario = new Panel();
            CadastroFunc.SuspendLayout();
            PnlFuncionario.SuspendLayout();
            this.FlowLayoutPanelFuncionarios.SuspendLayout();
            PnlCadastroFuncionario.SuspendLayout();
            SuspendLayout();
            // 
            // TextCadastroDeFuncionario
            // 
            TextCadastroDeFuncionario.Anchor = AnchorStyles.None;
            TextCadastroDeFuncionario.AutoSize = true;
            TextCadastroDeFuncionario.Font = new Font("Copperplate Gothic Bold", 36F, FontStyle.Regular, GraphicsUnit.Point);
            TextCadastroDeFuncionario.Image = Properties.Resources.Screenshot_1;
            TextCadastroDeFuncionario.Location = new Point(219, 27);
            TextCadastroDeFuncionario.Name = "TextCadastroDeFuncionario";
            TextCadastroDeFuncionario.Size = new Size(818, 53);
            TextCadastroDeFuncionario.TabIndex = 0;
            TextCadastroDeFuncionario.Text = "CADASTRO DE FUNCIONÁRIO";
            // 
            // CadastroFunc
            // 
            CadastroFunc.BackgroundImage = Properties.Resources.Screenshot_1;
            CadastroFunc.BackgroundImageLayout = ImageLayout.Stretch;
            CadastroFunc.Controls.Add(PnlFuncionario);
            CadastroFunc.Controls.Add(TextIDCliente);
            CadastroFunc.Controls.Add(ComboBoxCarteira);
            CadastroFunc.Controls.Add(TextObservacao);
            CadastroFunc.Controls.Add(TextBoxObservacao);
            CadastroFunc.Controls.Add(TextSenha);
            CadastroFunc.Controls.Add(TextBoxSenha);
            CadastroFunc.Controls.Add(DateTimePickerValidade);
            CadastroFunc.Controls.Add(TextValidade);
            CadastroFunc.Controls.Add(TextCarteiraMotorista);
            CadastroFunc.Controls.Add(TextMatricula);
            CadastroFunc.Controls.Add(TextBoxMatricula);
            CadastroFunc.Controls.Add(TextBoxIdFuncionario);
            CadastroFunc.Controls.Add(TextboxIdCliente);
            CadastroFunc.Controls.Add(TextEmail);
            CadastroFunc.Controls.Add(TextboxNome);
            CadastroFunc.Controls.Add(TextCpf);
            CadastroFunc.Controls.Add(TextboxEmail);
            CadastroFunc.Controls.Add(MaskedTextboxCpf);
            CadastroFunc.Controls.Add(MaskedTextboxTelefone);
            CadastroFunc.Controls.Add(TextNome);
            CadastroFunc.Controls.Add(TextTelefone);
            CadastroFunc.Dock = DockStyle.Fill;
            CadastroFunc.Location = new Point(0, 0);
            CadastroFunc.Name = "CadastroFunc";
            CadastroFunc.Size = new Size(533, 373);
            CadastroFunc.TabIndex = 0;
            // 
            // PnlFuncionario
            // 
            PnlFuncionario.BackColor = Color.Transparent;
            PnlFuncionario.Controls.Add(RadioBtnEntregador);
            PnlFuncionario.Controls.Add(RadioBtnAtendente);
            PnlFuncionario.Controls.Add(RadioBtnAdm);
            PnlFuncionario.Location = new Point(396, 3);
            PnlFuncionario.Name = "PnlFuncionario";
            PnlFuncionario.Size = new Size(131, 128);
            PnlFuncionario.TabIndex = 68;
            // 
            // RadioBtnEntregador
            // 
            RadioBtnEntregador.AutoSize = true;
            RadioBtnEntregador.Location = new Point(3, 107);
            RadioBtnEntregador.Name = "RadioBtnEntregador";
            RadioBtnEntregador.Size = new Size(108, 18);
            RadioBtnEntregador.TabIndex = 70;
            RadioBtnEntregador.TabStop = true;
            RadioBtnEntregador.Text = "Entregador";
            RadioBtnEntregador.UseVisualStyleBackColor = true;
            // 
            // RadioBtnAtendente
            // 
            RadioBtnAtendente.AutoSize = true;
            RadioBtnAtendente.Location = new Point(3, 55);
            RadioBtnAtendente.Name = "RadioBtnAtendente";
            RadioBtnAtendente.Size = new Size(99, 18);
            RadioBtnAtendente.TabIndex = 69;
            RadioBtnAtendente.TabStop = true;
            RadioBtnAtendente.Text = "Atendente";
            RadioBtnAtendente.UseVisualStyleBackColor = true;
            // 
            // RadioBtnAdm
            // 
            RadioBtnAdm.AutoSize = true;
            RadioBtnAdm.Location = new Point(3, 5);
            RadioBtnAdm.Name = "RadioBtnAdm";
            RadioBtnAdm.Size = new Size(123, 18);
            RadioBtnAdm.TabIndex = 0;
            RadioBtnAdm.TabStop = true;
            RadioBtnAdm.Text = "Administrador";
            RadioBtnAdm.UseVisualStyleBackColor = true;
            // 
            // ComboBoxCarteira
            // 
            ComboBoxCarteira.FormattingEnabled = true;
            ComboBoxCarteira.Items.AddRange(new object[] { "Habilitação - A", "Habilitação - B", "Habilitação - C", "Habilitação - D", "Não Possuo Carteira" });
            ComboBoxCarteira.Location = new Point(3, 210);
            ComboBoxCarteira.Name = "ComboBoxCarteira";
            ComboBoxCarteira.Size = new Size(242, 22);
            ComboBoxCarteira.TabIndex = 67;
            // 
            // TextObservacao
            // 
            TextObservacao.AutoSize = true;
            TextObservacao.BackColor = Color.Transparent;
            TextObservacao.Font = new Font("Copperplate Gothic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TextObservacao.Location = new Point(3, 235);
            TextObservacao.Name = "TextObservacao";
            TextObservacao.Size = new Size(198, 36);
            TextObservacao.TabIndex = 65;
            TextObservacao.Text = "OBSERVAÇÃO:\r\n(DADOS DO VEÍCULO)";
            // 
            // TextBoxObservacao
            // 
            TextBoxObservacao.Location = new Point(3, 274);
            TextBoxObservacao.Multiline = true;
            TextBoxObservacao.Name = "TextBoxObservacao";
            TextBoxObservacao.Size = new Size(517, 95);
            TextBoxObservacao.TabIndex = 64;
            // 
            // TextSenha
            // 
            TextSenha.AutoSize = true;
            TextSenha.BackColor = Color.Transparent;
            TextSenha.Font = new Font("Copperplate Gothic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TextSenha.ForeColor = SystemColors.Info;
            TextSenha.Location = new Point(393, 189);
            TextSenha.Name = "TextSenha";
            TextSenha.Size = new Size(73, 18);
            TextSenha.TabIndex = 26;
            TextSenha.Text = "SENHA";
            TextSenha.TextAlign = ContentAlignment.TopCenter;
            // 
            // TextBoxSenha
            // 
            TextBoxSenha.Location = new Point(395, 211);
            TextBoxSenha.Name = "TextBoxSenha";
            TextBoxSenha.PasswordChar = '*';
            TextBoxSenha.Size = new Size(123, 21);
            TextBoxSenha.TabIndex = 25;
            // 
            // DateTimePickerValidade
            // 
            DateTimePickerValidade.Format = DateTimePickerFormat.Short;
            DateTimePickerValidade.Location = new Point(251, 211);
            DateTimePickerValidade.Name = "DateTimePickerValidade";
            DateTimePickerValidade.Size = new Size(138, 21);
            DateTimePickerValidade.TabIndex = 24;
            // 
            // TextValidade
            // 
            TextValidade.AutoSize = true;
            TextValidade.BackColor = Color.Transparent;
            TextValidade.Font = new Font("Copperplate Gothic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TextValidade.ForeColor = SystemColors.Info;
            TextValidade.Location = new Point(247, 189);
            TextValidade.Name = "TextValidade";
            TextValidade.Size = new Size(100, 18);
            TextValidade.TabIndex = 23;
            TextValidade.Text = "VALIDADE";
            TextValidade.TextAlign = ContentAlignment.TopCenter;
            // 
            // TextCarteiraMotorista
            // 
            TextCarteiraMotorista.AutoSize = true;
            TextCarteiraMotorista.BackColor = Color.Transparent;
            TextCarteiraMotorista.Font = new Font("Copperplate Gothic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TextCarteiraMotorista.ForeColor = SystemColors.Info;
            TextCarteiraMotorista.Location = new Point(1, 189);
            TextCarteiraMotorista.Name = "TextCarteiraMotorista";
            TextCarteiraMotorista.Size = new Size(242, 18);
            TextCarteiraMotorista.TabIndex = 21;
            TextCarteiraMotorista.Text = "CARTEIRA DE MOROTISTA";
            TextCarteiraMotorista.TextAlign = ContentAlignment.TopCenter;
            // 
            // TextMatricula
            // 
            TextMatricula.AutoSize = true;
            TextMatricula.BackColor = Color.Transparent;
            TextMatricula.Font = new Font("Copperplate Gothic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TextMatricula.ForeColor = SystemColors.Info;
            TextMatricula.Location = new Point(192, 2);
            TextMatricula.Name = "TextMatricula";
            TextMatricula.Size = new Size(115, 18);
            TextMatricula.TabIndex = 19;
            TextMatricula.Text = "MATRICULA";
            TextMatricula.TextAlign = ContentAlignment.TopCenter;
            // 
            // TextBoxMatricula
            // 
            TextBoxMatricula.BackColor = SystemColors.ButtonHighlight;
            TextBoxMatricula.Cursor = Cursors.IBeam;
            TextBoxMatricula.Font = new Font("Copperplate Gothic Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            TextBoxMatricula.ForeColor = SystemColors.MenuText;
            TextBoxMatricula.Location = new Point(192, 23);
            TextBoxMatricula.MaxLength = 80;
            TextBoxMatricula.Name = "TextBoxMatricula";
            TextBoxMatricula.Size = new Size(128, 21);
            TextBoxMatricula.TabIndex = 18;
            // 
            // TextIDCliente
            // 
            TextIDCliente.AutoSize = true;
            TextIDCliente.BackColor = Color.Transparent;
            TextIDCliente.Font = new Font("Copperplate Gothic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TextIDCliente.ForeColor = SystemColors.Info;
            TextIDCliente.Location = new Point(0, 2);
            TextIDCliente.Name = "TextIDCliente";
            TextIDCliente.Size = new Size(26, 18);
            TextIDCliente.TabIndex = 17;
            TextIDCliente.Text = "ID";
            TextIDCliente.TextAlign = ContentAlignment.TopCenter;
            // 
            // TextboxIdCliente
            // 
            TextboxIdCliente.BackColor = SystemColors.ControlDarkDark;
            TextboxIdCliente.Cursor = Cursors.IBeam;
            TextboxIdCliente.Enabled = false;
            TextboxIdCliente.Font = new Font("Copperplate Gothic Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            TextboxIdCliente.ForeColor = SystemColors.MenuText;
            TextboxIdCliente.Location = new Point(1, 23);
            TextboxIdCliente.MaxLength = 80;
            TextboxIdCliente.Name = "TextboxIdCliente";
            TextboxIdCliente.Size = new Size(34, 21);
            TextboxIdCliente.TabIndex = 16;
            // 
            // TextEmail
            // 
            TextEmail.AutoSize = true;
            TextEmail.BackColor = Color.Transparent;
            TextEmail.Font = new Font("Copperplate Gothic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TextEmail.ForeColor = SystemColors.Info;
            TextEmail.Location = new Point(130, 126);
            TextEmail.Name = "TextEmail";
            TextEmail.Size = new Size(64, 18);
            TextEmail.TabIndex = 10;
            TextEmail.Text = "EMAIL";
            TextEmail.TextAlign = ContentAlignment.TopCenter;
            // 
            // TextboxNome
            // 
            TextboxNome.BackColor = SystemColors.ButtonHighlight;
            TextboxNome.Cursor = Cursors.IBeam;
            TextboxNome.Font = new Font("Copperplate Gothic Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            TextboxNome.ForeColor = SystemColors.MenuText;
            TextboxNome.Location = new Point(1, 85);
            TextboxNome.MaxLength = 80;
            TextboxNome.Name = "TextboxNome";
            TextboxNome.Size = new Size(319, 21);
            TextboxNome.TabIndex = 1;
            // 
            // TextCpf
            // 
            TextCpf.AutoSize = true;
            TextCpf.BackColor = Color.Transparent;
            TextCpf.Font = new Font("Copperplate Gothic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TextCpf.ForeColor = SystemColors.Info;
            TextCpf.Location = new Point(62, 2);
            TextCpf.Name = "TextCpf";
            TextCpf.Size = new Size(45, 18);
            TextCpf.TabIndex = 11;
            TextCpf.Text = "CPF";
            TextCpf.TextAlign = ContentAlignment.TopCenter;
            // 
            // TextboxEmail
            // 
            TextboxEmail.Location = new Point(130, 147);
            TextboxEmail.Name = "TextboxEmail";
            TextboxEmail.Size = new Size(190, 21);
            TextboxEmail.TabIndex = 4;
            // 
            // MaskedTextboxCpf
            // 
            MaskedTextboxCpf.Location = new Point(62, 23);
            MaskedTextboxCpf.Mask = "000.000.000-00";
            MaskedTextboxCpf.Name = "MaskedTextboxCpf";
            MaskedTextboxCpf.RightToLeft = RightToLeft.No;
            MaskedTextboxCpf.Size = new Size(106, 21);
            MaskedTextboxCpf.TabIndex = 2;
            MaskedTextboxCpf.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            // 
            // MaskedTextboxTelefone
            // 
            MaskedTextboxTelefone.Location = new Point(3, 147);
            MaskedTextboxTelefone.Mask = "(999) 000-0000";
            MaskedTextboxTelefone.Name = "MaskedTextboxTelefone";
            MaskedTextboxTelefone.Size = new Size(106, 21);
            MaskedTextboxTelefone.TabIndex = 3;
            MaskedTextboxTelefone.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            // 
            // TextNome
            // 
            TextNome.AutoSize = true;
            TextNome.BackColor = Color.Transparent;
            TextNome.Font = new Font("Copperplate Gothic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TextNome.ForeColor = SystemColors.Info;
            TextNome.Location = new Point(1, 64);
            TextNome.Name = "TextNome";
            TextNome.Size = new Size(63, 18);
            TextNome.TabIndex = 15;
            TextNome.Text = "NOME";
            TextNome.TextAlign = ContentAlignment.TopCenter;
            // 
            // TextTelefone
            // 
            TextTelefone.AutoSize = true;
            TextTelefone.BackColor = Color.Transparent;
            TextTelefone.Font = new Font("Copperplate Gothic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TextTelefone.ForeColor = SystemColors.Info;
            TextTelefone.Location = new Point(1, 126);
            TextTelefone.Name = "TextTelefone";
            TextTelefone.Size = new Size(106, 18);
            TextTelefone.TabIndex = 14;
            TextTelefone.Text = "TELEFONE";
            TextTelefone.TextAlign = ContentAlignment.TopCenter;
            // 
            // TextBoxIdFuncionario
            // 
            TextBoxIdFuncionario.BackColor = SystemColors.ControlDarkDark;
            TextBoxIdFuncionario.Cursor = Cursors.IBeam;
            TextBoxIdFuncionario.Enabled = false;
            TextBoxIdFuncionario.Font = new Font("Copperplate Gothic Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            TextBoxIdFuncionario.ForeColor = SystemColors.MenuText;
            TextBoxIdFuncionario.Location = new Point(2, 23);
            TextBoxIdFuncionario.MaxLength = 80;
            TextBoxIdFuncionario.Name = "TextBoxIdFuncionario";
            TextBoxIdFuncionario.Size = new Size(34, 21);
            TextBoxIdFuncionario.TabIndex = 16;
            // 
            // FlowLayoutPanelFuncionarios
            // 
            this.FlowLayoutPanelFuncionarios.Controls.Add(PnlCadastroFuncionario);
            this.FlowLayoutPanelFuncionarios.Controls.Add(PnlUserControlEndereco);
            this.FlowLayoutPanelFuncionarios.Location = new Point(104, 63);
            this.FlowLayoutPanelFuncionarios.Name = "FlowLayoutPanelFuncionarios";
            this.FlowLayoutPanelFuncionarios.Size = new Size(1210, 420);
            this.FlowLayoutPanelFuncionarios.TabIndex = 1;
            // 
            // PnlUserControlEndereco
            // 
            PnlUserControlEndereco.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            PnlUserControlEndereco.Location = new Point(542, 3);
            PnlUserControlEndereco.Name = "PnlUserControlEndereco";
            PnlUserControlEndereco.Size = new Size(488, 369);
            PnlUserControlEndereco.TabIndex = 0;
            // 
            // PnlCadastroFuncionario
            // 
            PnlCadastroFuncionario.Controls.Add(CadastroFunc);
            PnlCadastroFuncionario.Location = new Point(3, 3);
            PnlCadastroFuncionario.Name = "PnlCadastroFuncionario";
            PnlCadastroFuncionario.Size = new Size(533, 373);
            PnlCadastroFuncionario.TabIndex = 1;
            // 
            // CadastroFuncionario
            // 
            AutoScaleDimensions = new SizeF(9F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            BackgroundImage = Properties.Resources.istockphoto_1137028124_612x612;
            ClientSize = new Size(1146, 546);
            Controls.Add(this.FlowLayoutPanelFuncionarios);
            Controls.Add(TextCadastroDeFuncionario);
            Font = new Font("Copperplate Gothic Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = SystemColors.Info;
            FormBorderStyle = FormBorderStyle.None;
            KeyPreview = true;
            Margin = new Padding(4, 3, 4, 3);
            Name = "CadastroFuncionario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TELA_ATENDENTE";
            WindowState = FormWindowState.Maximized;
            CadastroFunc.ResumeLayout(false);
            CadastroFunc.PerformLayout();
            PnlFuncionario.ResumeLayout(false);
            PnlFuncionario.PerformLayout();
            this.FlowLayoutPanelFuncionarios.ResumeLayout(false);
            PnlCadastroFuncionario.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label TextCadastroDeFuncionario;
        private Panel CadastroFunc;
        private Label TextIDCliente;
        private TextBox TextboxIdCliente;
        private Label TextEmail;
        private TextBox TextboxNome;
        private Label TextCpf;
        private TextBox TextboxEmail;
        private MaskedTextBox MaskedTextboxCpf;
        private MaskedTextBox MaskedTextboxTelefone;
        private Label TextNome;
        private Label TextTelefone;
        private Label TextMatricula;
        private TextBox TextBoxMatricula;
        private Label TextValidade;
        private Label TextCarteiraMotorista;
        private Label TextSenha;
        private TextBox TextBoxSenha;
        private DateTimePicker DateTimePickerValidade;
        private Label TextObservacao;
        private TextBox TextBoxObservacao;
        private ComboBox ComboBoxCarteira;
        private Panel PnlFuncionario;
        private RadioButton RadioBtnEntregador;
        private RadioButton RadioBtnAtendente;
        private RadioButton RadioBtnAdm;
        private Label label8;
        private Label label7;
        private TextBox textBox5;
        private Label label6;
        private Label label5;
        private TextBox TextBoxIdFuncionario;
        private Label label3;
        private MaskedTextBox maskedTextBox1;
        private Label label2;
        private Label label1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel PnlUserControlEndereco;
        private Panel PnlCadastroFuncionario;
    }
}