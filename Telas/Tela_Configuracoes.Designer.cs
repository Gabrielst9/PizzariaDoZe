namespace PizzariaDoZe
{
    partial class Tela_Configuracoes
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
            tabControl1 = new TabControl();
            Tab20_Idioma = new TabPage();
            textBoxStringDeConexao = new TextBox();
            comboBoxProvider = new ComboBox();
            TextoStringConection = new Label();
            TextoProvider = new Label();
            TextoBD = new Label();
            Checkbox20Reiniciar = new CheckBox();
            Combo20Idiomas = new ComboBox();
            Text_20_Idioma = new Label();
            Tab20_Armazen = new TabPage();
            Tab20_FechareSair = new TabPage();
            Tab20_Parametros = new TabPage();
            Tab20_Banco = new TabPage();
            Btn20Salvar = new Button();
            tabControl1.SuspendLayout();
            Tab20_Idioma.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(Tab20_Idioma);
            tabControl1.Controls.Add(Tab20_Armazen);
            tabControl1.Controls.Add(Tab20_FechareSair);
            tabControl1.Controls.Add(Tab20_Parametros);
            tabControl1.Controls.Add(Tab20_Banco);
            tabControl1.Location = new Point(12, 26);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(760, 349);
            tabControl1.TabIndex = 0;
            // 
            // Tab20_Idioma
            // 
            Tab20_Idioma.Controls.Add(textBoxStringDeConexao);
            Tab20_Idioma.Controls.Add(comboBoxProvider);
            Tab20_Idioma.Controls.Add(TextoStringConection);
            Tab20_Idioma.Controls.Add(TextoProvider);
            Tab20_Idioma.Controls.Add(TextoBD);
            Tab20_Idioma.Controls.Add(Checkbox20Reiniciar);
            Tab20_Idioma.Controls.Add(Combo20Idiomas);
            Tab20_Idioma.Controls.Add(Text_20_Idioma);
            Tab20_Idioma.Location = new Point(4, 27);
            Tab20_Idioma.Name = "Tab20_Idioma";
            Tab20_Idioma.Padding = new Padding(3);
            Tab20_Idioma.Size = new Size(752, 318);
            Tab20_Idioma.TabIndex = 0;
            Tab20_Idioma.Text = "Idioma/Região";
            Tab20_Idioma.UseVisualStyleBackColor = true;
            // 
            // textBoxStringDeConexao
            // 
            textBoxStringDeConexao.Location = new Point(29, 251);
            textBoxStringDeConexao.Name = "textBoxStringDeConexao";
            textBoxStringDeConexao.Size = new Size(536, 25);
            textBoxStringDeConexao.TabIndex = 7;
            // 
            // comboBoxProvider
            // 
            comboBoxProvider.FormattingEnabled = true;
            comboBoxProvider.Items.AddRange(new object[] { "pt-BR", "en-US", "es" });
            comboBoxProvider.Location = new Point(29, 181);
            comboBoxProvider.Name = "comboBoxProvider";
            comboBoxProvider.Size = new Size(176, 26);
            comboBoxProvider.TabIndex = 6;
            // 
            // TextoStringConection
            // 
            TextoStringConection.AutoSize = true;
            TextoStringConection.Location = new Point(29, 230);
            TextoStringConection.Name = "TextoStringConection";
            TextoStringConection.Size = new Size(176, 18);
            TextoStringConection.TabIndex = 5;
            TextoStringConection.Text = "String de Conexão";
            // 
            // TextoProvider
            // 
            TextoProvider.AutoSize = true;
            TextoProvider.Location = new Point(69, 160);
            TextoProvider.Name = "TextoProvider";
            TextoProvider.Size = new Size(89, 18);
            TextoProvider.TabIndex = 4;
            TextoProvider.Text = "Provider";
            // 
            // TextoBD
            // 
            TextoBD.AutoSize = true;
            TextoBD.Location = new Point(19, 125);
            TextoBD.Name = "TextoBD";
            TextoBD.Size = new Size(151, 18);
            TextoBD.TabIndex = 3;
            TextoBD.Text = "Bando de Dados";
            // 
            // Checkbox20Reiniciar
            // 
            Checkbox20Reiniciar.AutoSize = true;
            Checkbox20Reiniciar.Location = new Point(228, 68);
            Checkbox20Reiniciar.Name = "Checkbox20Reiniciar";
            Checkbox20Reiniciar.Size = new Size(485, 22);
            Checkbox20Reiniciar.TabIndex = 2;
            Checkbox20Reiniciar.Text = "Reiniciar para aplicar o novo idioma imediatamente";
            Checkbox20Reiniciar.UseVisualStyleBackColor = true;
            // 
            // Combo20Idiomas
            // 
            Combo20Idiomas.FormattingEnabled = true;
            Combo20Idiomas.Items.AddRange(new object[] { "pt-BR", "en-US", "es" });
            Combo20Idiomas.Location = new Point(19, 68);
            Combo20Idiomas.Name = "Combo20Idiomas";
            Combo20Idiomas.Size = new Size(156, 26);
            Combo20Idiomas.TabIndex = 1;
            // 
            // Text_20_Idioma
            // 
            Text_20_Idioma.AutoSize = true;
            Text_20_Idioma.Location = new Point(19, 34);
            Text_20_Idioma.Name = "Text_20_Idioma";
            Text_20_Idioma.Size = new Size(156, 18);
            Text_20_Idioma.TabIndex = 0;
            Text_20_Idioma.Text = "IDIOMA/REGIÃO";
            // 
            // Tab20_Armazen
            // 
            Tab20_Armazen.Location = new Point(4, 24);
            Tab20_Armazen.Name = "Tab20_Armazen";
            Tab20_Armazen.Padding = new Padding(3);
            Tab20_Armazen.Size = new Size(752, 321);
            Tab20_Armazen.TabIndex = 1;
            Tab20_Armazen.Text = "Armazenamento LOG";
            Tab20_Armazen.UseVisualStyleBackColor = true;
            // 
            // Tab20_FechareSair
            // 
            Tab20_FechareSair.Location = new Point(4, 24);
            Tab20_FechareSair.Name = "Tab20_FechareSair";
            Tab20_FechareSair.Size = new Size(752, 321);
            Tab20_FechareSair.TabIndex = 2;
            Tab20_FechareSair.Text = "Fechar ao Sair";
            Tab20_FechareSair.UseVisualStyleBackColor = true;
            // 
            // Tab20_Parametros
            // 
            Tab20_Parametros.Location = new Point(4, 24);
            Tab20_Parametros.Name = "Tab20_Parametros";
            Tab20_Parametros.Size = new Size(752, 321);
            Tab20_Parametros.TabIndex = 3;
            Tab20_Parametros.Text = "Parametros para Cobrança";
            Tab20_Parametros.UseVisualStyleBackColor = true;
            // 
            // Tab20_Banco
            // 
            Tab20_Banco.Location = new Point(4, 24);
            Tab20_Banco.Name = "Tab20_Banco";
            Tab20_Banco.Size = new Size(752, 321);
            Tab20_Banco.TabIndex = 4;
            Tab20_Banco.Text = "Banco de Dados";
            Tab20_Banco.UseVisualStyleBackColor = true;
            // 
            // Btn20Salvar
            // 
            Btn20Salvar.Anchor = AnchorStyles.None;
            Btn20Salvar.Location = new Point(12, 382);
            Btn20Salvar.Margin = new Padding(5, 4, 5, 4);
            Btn20Salvar.Name = "Btn20Salvar";
            Btn20Salvar.Size = new Size(759, 28);
            Btn20Salvar.TabIndex = 3;
            Btn20Salvar.Text = "SALVAR";
            Btn20Salvar.UseVisualStyleBackColor = true;
            Btn20Salvar.Click += Btn20Salvar_Click;
            // 
            // Tela_Configuracoes
            // 
            AutoScaleDimensions = new SizeF(12F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(785, 423);
            Controls.Add(Btn20Salvar);
            Controls.Add(tabControl1);
            Font = new Font("Copperplate Gothic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            KeyPreview = true;
            Margin = new Padding(5, 4, 5, 4);
            Name = "Tela_Configuracoes";
            Text = "Tela_Configuracoes";
            tabControl1.ResumeLayout(false);
            Tab20_Idioma.ResumeLayout(false);
            Tab20_Idioma.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage Tab20_Idioma;
        internal TabPage Tab20_Armazen;
        private TabPage Tab20_FechareSair;
        private TabPage Tab20_Parametros;
        private TabPage Tab20_Banco;
        private CheckBox Checkbox20Reiniciar;
        private ComboBox Combo20Idiomas;
        private Label Text_20_Idioma;
        private Button Btn20Salvar;
        private Label TextoStringConection;
        private Label TextoProvider;
        private Label TextoBD;
        private TextBox textBoxStringDeConexao;
        private ComboBox comboBoxProvider;
    }
}