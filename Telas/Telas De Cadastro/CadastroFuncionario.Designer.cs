namespace PizzariaDoZe.Telas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroFuncionario));
            PnlUserControlEnderecoFuncionario = new Panel();
            userControlEnderecoFuncionarios = new userControlEndereco();
            TextCadastroFuncionario = new Label();
            PnlCadastroFuncionario = new Panel();
            TextObservacao = new Label();
            PnlGrupo = new Panel();
            TextGrupo = new Label();
            RadioBtnEntregador = new RadioButton();
            RadioBtnAtendente = new RadioButton();
            RadioBtnAdministrador = new RadioButton();
            TextBoxObservacao = new TextBox();
            DateTimePickerValidade = new DateTimePicker();
            TextSenha = new Label();
            TextBoxSenha = new TextBox();
            TextValidade = new Label();
            TextCarteira = new Label();
            TextMatricula = new Label();
            TextBoxMatricula = new TextBox();
            TextIDCliente = new Label();
            TextboxIdCliente = new TextBox();
            TextEmail = new Label();
            TextboxNome = new TextBox();
            TextCpf = new Label();
            TextboxEmail = new TextBox();
            MaskedboxCpf = new MaskedTextBox();
            MaskedboxTelefone = new MaskedTextBox();
            TextNome = new Label();
            TextTelefone = new Label();
            FlowLayoutPanelFuncionario = new FlowLayoutPanel();
            PnlCrudFuncionario = new Panel();
            CrudFuncionario = new CRUD();
            ComboBoxCarteira = new ComboBox();
            PnlUserControlEnderecoFuncionario.SuspendLayout();
            PnlCadastroFuncionario.SuspendLayout();
            PnlGrupo.SuspendLayout();
            FlowLayoutPanelFuncionario.SuspendLayout();
            PnlCrudFuncionario.SuspendLayout();
            SuspendLayout();
            // 
            // PnlUserControlEnderecoFuncionario
            // 
            PnlUserControlEnderecoFuncionario.BackColor = SystemColors.ActiveCaptionText;
            PnlUserControlEnderecoFuncionario.Controls.Add(userControlEnderecoFuncionarios);
            PnlUserControlEnderecoFuncionario.Location = new Point(529, 3);
            PnlUserControlEnderecoFuncionario.Name = "PnlUserControlEnderecoFuncionario";
            PnlUserControlEnderecoFuncionario.Size = new Size(441, 285);
            PnlUserControlEnderecoFuncionario.TabIndex = 0;
            // 
            // userControlEnderecoFuncionarios
            // 
            userControlEnderecoFuncionarios.BackgroundImage = (Image)resources.GetObject("userControlEnderecoFuncionarios.BackgroundImage");
            userControlEnderecoFuncionarios.BackgroundImageLayout = ImageLayout.Stretch;
            userControlEnderecoFuncionarios.ForeColor = SystemColors.Info;
            userControlEnderecoFuncionarios.Location = new Point(3, 0);
            userControlEnderecoFuncionarios.Name = "userControlEnderecoFuncionarios";
            userControlEnderecoFuncionarios.Size = new Size(437, 285);
            userControlEnderecoFuncionarios.TabIndex = 9;
            // 
            // TextCadastroFuncionario
            // 
            TextCadastroFuncionario.Anchor = AnchorStyles.None;
            TextCadastroFuncionario.AutoSize = true;
            TextCadastroFuncionario.BackColor = SystemColors.ActiveCaptionText;
            TextCadastroFuncionario.BorderStyle = BorderStyle.Fixed3D;
            TextCadastroFuncionario.Font = new Font("Copperplate Gothic Bold", 36F, FontStyle.Regular, GraphicsUnit.Point);
            TextCadastroFuncionario.ForeColor = SystemColors.Info;
            TextCadastroFuncionario.Image = Properties.Resources.Screenshot_1;
            TextCadastroFuncionario.Location = new Point(132, -13);
            TextCadastroFuncionario.Name = "TextCadastroFuncionario";
            TextCadastroFuncionario.Size = new Size(855, 55);
            TextCadastroFuncionario.TabIndex = 15;
            TextCadastroFuncionario.Text = "CADASTRO DE FUNCIONÁRIOS";
            TextCadastroFuncionario.TextAlign = ContentAlignment.TopCenter;
            // 
            // PnlCadastroFuncionario
            // 
            PnlCadastroFuncionario.BackgroundImage = Properties.Resources.Screenshot_1;
            PnlCadastroFuncionario.BackgroundImageLayout = ImageLayout.Stretch;
            PnlCadastroFuncionario.Controls.Add(TextObservacao);
            PnlCadastroFuncionario.Controls.Add(PnlGrupo);
            PnlCadastroFuncionario.Controls.Add(TextBoxObservacao);
            PnlCadastroFuncionario.Controls.Add(DateTimePickerValidade);
            PnlCadastroFuncionario.Controls.Add(ComboBoxCarteira);
            PnlCadastroFuncionario.Controls.Add(TextSenha);
            PnlCadastroFuncionario.Controls.Add(TextBoxSenha);
            PnlCadastroFuncionario.Controls.Add(TextValidade);
            PnlCadastroFuncionario.Controls.Add(TextCarteira);
            PnlCadastroFuncionario.Controls.Add(TextMatricula);
            PnlCadastroFuncionario.Controls.Add(TextBoxMatricula);
            PnlCadastroFuncionario.Controls.Add(TextIDCliente);
            PnlCadastroFuncionario.Controls.Add(TextboxIdCliente);
            PnlCadastroFuncionario.Controls.Add(TextEmail);
            PnlCadastroFuncionario.Controls.Add(TextboxNome);
            PnlCadastroFuncionario.Controls.Add(TextCpf);
            PnlCadastroFuncionario.Controls.Add(TextboxEmail);
            PnlCadastroFuncionario.Controls.Add(MaskedboxCpf);
            PnlCadastroFuncionario.Controls.Add(MaskedboxTelefone);
            PnlCadastroFuncionario.Controls.Add(TextNome);
            PnlCadastroFuncionario.Controls.Add(TextTelefone);
            PnlCadastroFuncionario.Location = new Point(3, 3);
            PnlCadastroFuncionario.Name = "PnlCadastroFuncionario";
            PnlCadastroFuncionario.Size = new Size(520, 371);
            PnlCadastroFuncionario.TabIndex = 17;
            // 
            // TextObservacao
            // 
            TextObservacao.AutoSize = true;
            TextObservacao.BackColor = Color.Transparent;
            TextObservacao.Font = new Font("Copperplate Gothic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TextObservacao.ForeColor = SystemColors.Info;
            TextObservacao.Location = new Point(3, 257);
            TextObservacao.Name = "TextObservacao";
            TextObservacao.Size = new Size(198, 36);
            TextObservacao.TabIndex = 67;
            TextObservacao.Text = "OBSERVAÇÃO:\r\n(DADOS DO VEÍCULO)";
            // 
            // PnlGrupo
            // 
            PnlGrupo.BackColor = SystemColors.ActiveCaptionText;
            PnlGrupo.BackgroundImageLayout = ImageLayout.Stretch;
            PnlGrupo.Controls.Add(TextGrupo);
            PnlGrupo.Controls.Add(RadioBtnEntregador);
            PnlGrupo.Controls.Add(RadioBtnAtendente);
            PnlGrupo.Controls.Add(RadioBtnAdministrador);
            PnlGrupo.Font = new Font("Copperplate Gothic Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            PnlGrupo.ForeColor = SystemColors.Info;
            PnlGrupo.Location = new Point(358, 26);
            PnlGrupo.Name = "PnlGrupo";
            PnlGrupo.Size = new Size(150, 112);
            PnlGrupo.TabIndex = 65;
            PnlGrupo.Tag = "Grupo";
            // 
            // TextGrupo
            // 
            TextGrupo.Anchor = AnchorStyles.None;
            TextGrupo.AutoSize = true;
            TextGrupo.BackColor = Color.Transparent;
            TextGrupo.Font = new Font("Copperplate Gothic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TextGrupo.ForeColor = SystemColors.Info;
            TextGrupo.Location = new Point(41, 5);
            TextGrupo.Name = "TextGrupo";
            TextGrupo.Size = new Size(65, 18);
            TextGrupo.TabIndex = 12;
            TextGrupo.Text = "Grupo";
            TextGrupo.TextAlign = ContentAlignment.TopCenter;
            // 
            // RadioBtnEntregador
            // 
            RadioBtnEntregador.AutoSize = true;
            RadioBtnEntregador.BackColor = Color.Transparent;
            RadioBtnEntregador.Location = new Point(3, 93);
            RadioBtnEntregador.Name = "RadioBtnEntregador";
            RadioBtnEntregador.Size = new Size(121, 18);
            RadioBtnEntregador.TabIndex = 11;
            RadioBtnEntregador.Text = "ENTREGADOR";
            RadioBtnEntregador.UseVisualStyleBackColor = false;
            // 
            // RadioBtnAtendente
            // 
            RadioBtnAtendente.AutoSize = true;
            RadioBtnAtendente.BackColor = Color.Transparent;
            RadioBtnAtendente.Location = new Point(3, 60);
            RadioBtnAtendente.Name = "RadioBtnAtendente";
            RadioBtnAtendente.Size = new Size(108, 18);
            RadioBtnAtendente.TabIndex = 10;
            RadioBtnAtendente.Text = "ATENDENTE";
            RadioBtnAtendente.UseVisualStyleBackColor = false;
            // 
            // RadioBtnAdministrador
            // 
            RadioBtnAdministrador.AutoSize = true;
            RadioBtnAdministrador.BackColor = Color.Transparent;
            RadioBtnAdministrador.Checked = true;
            RadioBtnAdministrador.Location = new Point(3, 31);
            RadioBtnAdministrador.Name = "RadioBtnAdministrador";
            RadioBtnAdministrador.Size = new Size(142, 18);
            RadioBtnAdministrador.TabIndex = 9;
            RadioBtnAdministrador.TabStop = true;
            RadioBtnAdministrador.Text = "ADMINISTRADOR";
            RadioBtnAdministrador.UseVisualStyleBackColor = false;
            // 
            // TextBoxObservacao
            // 
            TextBoxObservacao.Location = new Point(3, 296);
            TextBoxObservacao.Multiline = true;
            TextBoxObservacao.Name = "TextBoxObservacao";
            TextBoxObservacao.Size = new Size(512, 69);
            TextBoxObservacao.TabIndex = 8;
            // 
            // DateTimePickerValidade
            // 
            DateTimePickerValidade.Format = DateTimePickerFormat.Short;
            DateTimePickerValidade.Location = new Point(252, 220);
            DateTimePickerValidade.Name = "DateTimePickerValidade";
            DateTimePickerValidade.Size = new Size(106, 23);
            DateTimePickerValidade.TabIndex = 6;
            DateTimePickerValidade.Value = new DateTime(2023, 6, 1, 0, 0, 0, 0);
            // 
            // TextSenha
            // 
            TextSenha.AutoSize = true;
            TextSenha.BackColor = Color.Transparent;
            TextSenha.Font = new Font("Copperplate Gothic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TextSenha.ForeColor = SystemColors.Info;
            TextSenha.Location = new Point(371, 199);
            TextSenha.Name = "TextSenha";
            TextSenha.Size = new Size(73, 18);
            TextSenha.TabIndex = 25;
            TextSenha.Text = "SENHA";
            TextSenha.TextAlign = ContentAlignment.TopCenter;
            // 
            // TextBoxSenha
            // 
            TextBoxSenha.Location = new Point(371, 220);
            TextBoxSenha.MaxLength = 100;
            TextBoxSenha.Name = "TextBoxSenha";
            TextBoxSenha.PasswordChar = '*';
            TextBoxSenha.Size = new Size(144, 23);
            TextBoxSenha.TabIndex = 7;
            // 
            // TextValidade
            // 
            TextValidade.AutoSize = true;
            TextValidade.BackColor = Color.Transparent;
            TextValidade.Font = new Font("Copperplate Gothic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TextValidade.ForeColor = SystemColors.Info;
            TextValidade.Location = new Point(251, 199);
            TextValidade.Name = "TextValidade";
            TextValidade.Size = new Size(100, 18);
            TextValidade.TabIndex = 23;
            TextValidade.Text = "VALIDADE";
            TextValidade.TextAlign = ContentAlignment.TopCenter;
            // 
            // TextCarteira
            // 
            TextCarteira.AutoSize = true;
            TextCarteira.BackColor = Color.Transparent;
            TextCarteira.Font = new Font("Copperplate Gothic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TextCarteira.ForeColor = SystemColors.Info;
            TextCarteira.Location = new Point(3, 199);
            TextCarteira.Name = "TextCarteira";
            TextCarteira.Size = new Size(242, 18);
            TextCarteira.TabIndex = 21;
            TextCarteira.Text = "CARTEIRA DE MOROTISTA";
            TextCarteira.TextAlign = ContentAlignment.TopCenter;
            // 
            // TextMatricula
            // 
            TextMatricula.AutoSize = true;
            TextMatricula.BackColor = Color.Transparent;
            TextMatricula.Font = new Font("Copperplate Gothic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TextMatricula.ForeColor = SystemColors.Info;
            TextMatricula.Location = new Point(185, 0);
            TextMatricula.Name = "TextMatricula";
            TextMatricula.Size = new Size(115, 18);
            TextMatricula.TabIndex = 19;
            TextMatricula.Text = "MATRICULA";
            TextMatricula.TextAlign = ContentAlignment.TopCenter;
            // 
            // TextBoxMatricula
            // 
            TextBoxMatricula.Location = new Point(185, 21);
            TextBoxMatricula.Name = "TextBoxMatricula";
            TextBoxMatricula.Size = new Size(158, 23);
            TextBoxMatricula.TabIndex = 2;
            // 
            // TextIDCliente
            // 
            TextIDCliente.AutoSize = true;
            TextIDCliente.BackColor = Color.Transparent;
            TextIDCliente.Font = new Font("Copperplate Gothic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TextIDCliente.ForeColor = SystemColors.Info;
            TextIDCliente.Location = new Point(3, 0);
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
            TextboxIdCliente.Location = new Point(3, 21);
            TextboxIdCliente.MaxLength = 80;
            TextboxIdCliente.Name = "TextboxIdCliente";
            TextboxIdCliente.Size = new Size(41, 21);
            TextboxIdCliente.TabIndex = 16;
            // 
            // TextEmail
            // 
            TextEmail.AutoSize = true;
            TextEmail.BackColor = Color.Transparent;
            TextEmail.Font = new Font("Copperplate Gothic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TextEmail.ForeColor = SystemColors.Info;
            TextEmail.Location = new Point(116, 126);
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
            TextboxNome.Location = new Point(3, 83);
            TextboxNome.MaxLength = 80;
            TextboxNome.Name = "TextboxNome";
            TextboxNome.Size = new Size(326, 21);
            TextboxNome.TabIndex = 3;
            // 
            // TextCpf
            // 
            TextCpf.AutoSize = true;
            TextCpf.BackColor = Color.Transparent;
            TextCpf.Font = new Font("Copperplate Gothic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TextCpf.ForeColor = SystemColors.Info;
            TextCpf.Location = new Point(65, 0);
            TextCpf.Name = "TextCpf";
            TextCpf.Size = new Size(45, 18);
            TextCpf.TabIndex = 11;
            TextCpf.Text = "CPF";
            TextCpf.TextAlign = ContentAlignment.TopCenter;
            // 
            // TextboxEmail
            // 
            TextboxEmail.Location = new Point(116, 147);
            TextboxEmail.Name = "TextboxEmail";
            TextboxEmail.Size = new Size(227, 23);
            TextboxEmail.TabIndex = 4;
            // 
            // MaskedboxCpf
            // 
            MaskedboxCpf.Location = new Point(62, 21);
            MaskedboxCpf.Mask = "000.000.000-00";
            MaskedboxCpf.Name = "MaskedboxCpf";
            MaskedboxCpf.RightToLeft = RightToLeft.No;
            MaskedboxCpf.Size = new Size(113, 23);
            MaskedboxCpf.TabIndex = 1;
            MaskedboxCpf.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            // 
            // MaskedboxTelefone
            // 
            MaskedboxTelefone.Location = new Point(3, 147);
            MaskedboxTelefone.Mask = "(00) 90000-0000";
            MaskedboxTelefone.Name = "MaskedboxTelefone";
            MaskedboxTelefone.Size = new Size(99, 23);
            MaskedboxTelefone.TabIndex = 3;
            MaskedboxTelefone.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            // 
            // TextNome
            // 
            TextNome.AutoSize = true;
            TextNome.BackColor = Color.Transparent;
            TextNome.Font = new Font("Copperplate Gothic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TextNome.ForeColor = SystemColors.Info;
            TextNome.Location = new Point(3, 62);
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
            TextTelefone.Location = new Point(3, 126);
            TextTelefone.Name = "TextTelefone";
            TextTelefone.Size = new Size(106, 18);
            TextTelefone.TabIndex = 14;
            TextTelefone.Text = "TELEFONE";
            TextTelefone.TextAlign = ContentAlignment.TopCenter;
            // 
            // FlowLayoutPanelFuncionario
            // 
            FlowLayoutPanelFuncionario.Anchor = AnchorStyles.None;
            FlowLayoutPanelFuncionario.BackColor = SystemColors.ActiveCaptionText;
            FlowLayoutPanelFuncionario.Controls.Add(PnlCadastroFuncionario);
            FlowLayoutPanelFuncionario.Controls.Add(PnlUserControlEnderecoFuncionario);
            FlowLayoutPanelFuncionario.Controls.Add(PnlCrudFuncionario);
            FlowLayoutPanelFuncionario.Location = new Point(61, 60);
            FlowLayoutPanelFuncionario.Name = "FlowLayoutPanelFuncionario";
            FlowLayoutPanelFuncionario.Size = new Size(973, 467);
            FlowLayoutPanelFuncionario.TabIndex = 18;
            // 
            // PnlCrudFuncionario
            // 
            PnlCrudFuncionario.BackColor = SystemColors.ActiveCaptionText;
            PnlCrudFuncionario.Controls.Add(CrudFuncionario);
            PnlCrudFuncionario.Location = new Point(3, 380);
            PnlCrudFuncionario.Name = "PnlCrudFuncionario";
            PnlCrudFuncionario.Size = new Size(973, 87);
            PnlCrudFuncionario.TabIndex = 19;
            // 
            // CrudFuncionario
            // 
            CrudFuncionario.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            CrudFuncionario.BackColor = SystemColors.Desktop;
            CrudFuncionario.ForeColor = SystemColors.Info;
            CrudFuncionario.Location = new Point(0, 0);
            CrudFuncionario.Name = "CrudFuncionario";
            CrudFuncionario.Size = new Size(973, 87);
            CrudFuncionario.TabIndex = 0;
            CrudFuncionario.Load += CrudFuncionario_Load;
            // 
            // ComboBoxCarteira
            // 
            ComboBoxCarteira.FormattingEnabled = true;
            ComboBoxCarteira.Items.AddRange(new object[] { "Não Possuo Carteira", "Habilitação - A", "Habilitação - B", "Habilitação - C", "Habilitação - D" });
            ComboBoxCarteira.Location = new Point(3, 219);
            ComboBoxCarteira.Name = "ComboBoxCarteira";
            ComboBoxCarteira.Size = new Size(241, 23);
            ComboBoxCarteira.TabIndex = 5;
            // 
            // CadastroFuncionario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1095, 550);
            Controls.Add(FlowLayoutPanelFuncionario);
            Controls.Add(TextCadastroFuncionario);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CadastroFuncionario";
            Text = "CadastroFuncionario";
            WindowState = FormWindowState.Maximized;
            PnlUserControlEnderecoFuncionario.ResumeLayout(false);
            PnlCadastroFuncionario.ResumeLayout(false);
            PnlCadastroFuncionario.PerformLayout();
            PnlGrupo.ResumeLayout(false);
            PnlGrupo.PerformLayout();
            FlowLayoutPanelFuncionario.ResumeLayout(false);
            PnlCrudFuncionario.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel PnlUserControlEnderecoFuncionario;
        private userControlEndereco userControlEnderecoFuncionarios;
        private Label TextCadastroFuncionario;
        private Panel PnlCadastroFuncionario;
        private Label TextIDCliente;
        private TextBox TextboxIdCliente;
        private Label TextEmail;
        private TextBox TextboxNome;
        private Label TextCpf;
        private TextBox TextboxEmail;
        private MaskedTextBox MaskedboxCpf;
        private MaskedTextBox MaskedboxTelefone;
        private Label TextNome;
        private Label TextTelefone;
        private Label TextMatricula;
        private TextBox TextBoxMatricula;
        private Label TextSenha;
        private TextBox TextBoxSenha;
        private Label TextValidade;
        private Label TextCarteira;
        private DateTimePicker DateTimePickerValidade;
        private Panel panel1;
        private Panel PnlGrupo;
        private RadioButton RadioBtnEntregador;
        private RadioButton RadioBtnAtendente;
        private RadioButton RadioBtnAdministrador;
        private Label TextGrupo;
        private Label TextObservacao;
        private TextBox TextBoxObservacao;
        private FlowLayoutPanel FlowLayoutPanelFuncionario;
        private Panel PnlCrudFuncionario;
        private CRUD CrudFuncionario;
        private ComboBox ComboBoxCarteira;
    }
}