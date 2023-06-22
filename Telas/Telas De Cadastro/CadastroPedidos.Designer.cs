namespace PizzariaDoZe.Telas.Telas_De_Cadastro
{
    partial class CadastroPedidos
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
            TextCadastroPedido = new Label();
            tabControlPedidos = new TabControl();
            tabPageCliente = new TabPage();
            panel3 = new Panel();
            TextSelecioneCliente = new Label();
            panel2 = new Panel();
            MaskedTextboxTelefone = new MaskedTextBox();
            TextNome = new Label();
            TextTelefone = new Label();
            panel1 = new Panel();
            dataGridViewClientes = new DataGridView();
            MaskedTextboxCpf = new MaskedTextBox();
            textBoxNome = new TextBox();
            BtnBuscar = new Button();
            TextCpf = new Label();
            tabPagePizza = new TabPage();
            panel4 = new Panel();
            dataGridViewSabores = new DataGridView();
            TextSaboresLimite = new Label();
            TextSelecioneTamanho = new Label();
            comboBoxTamanho = new ComboBox();
            tabPageProduto = new TabPage();
            tabControlPedidos.SuspendLayout();
            tabPageCliente.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewClientes).BeginInit();
            tabPagePizza.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSabores).BeginInit();
            SuspendLayout();
            // 
            // TextCadastroPedido
            // 
            TextCadastroPedido.Anchor = AnchorStyles.None;
            TextCadastroPedido.AutoSize = true;
            TextCadastroPedido.BackColor = SystemColors.ActiveCaptionText;
            TextCadastroPedido.BorderStyle = BorderStyle.Fixed3D;
            TextCadastroPedido.Font = new Font("Copperplate Gothic Bold", 36F, FontStyle.Regular, GraphicsUnit.Point);
            TextCadastroPedido.ForeColor = SystemColors.Info;
            TextCadastroPedido.Image = Properties.Resources.Screenshot_1;
            TextCadastroPedido.Location = new Point(189, 82);
            TextCadastroPedido.Name = "TextCadastroPedido";
            TextCadastroPedido.Size = new Size(675, 55);
            TextCadastroPedido.TabIndex = 16;
            TextCadastroPedido.Text = "CADASTRO DE PEDIDOS";
            TextCadastroPedido.TextAlign = ContentAlignment.TopCenter;
            // 
            // tabControlPedidos
            // 
            tabControlPedidos.Alignment = TabAlignment.Left;
            tabControlPedidos.Controls.Add(tabPageCliente);
            tabControlPedidos.Controls.Add(tabPagePizza);
            tabControlPedidos.Controls.Add(tabPageProduto);
            tabControlPedidos.Cursor = Cursors.Hand;
            tabControlPedidos.Font = new Font("Copperplate Gothic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tabControlPedidos.Location = new Point(77, 135);
            tabControlPedidos.Multiline = true;
            tabControlPedidos.Name = "tabControlPedidos";
            tabControlPedidos.SelectedIndex = 0;
            tabControlPedidos.Size = new Size(978, 508);
            tabControlPedidos.TabIndex = 18;
            // 
            // tabPageCliente
            // 
            tabPageCliente.Controls.Add(panel3);
            tabPageCliente.Controls.Add(panel2);
            tabPageCliente.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tabPageCliente.ForeColor = SystemColors.Info;
            tabPageCliente.Location = new Point(28, 4);
            tabPageCliente.Name = "tabPageCliente";
            tabPageCliente.Padding = new Padding(3);
            tabPageCliente.Size = new Size(946, 500);
            tabPageCliente.TabIndex = 0;
            tabPageCliente.Text = "Cliente";
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ActiveCaptionText;
            panel3.Controls.Add(TextSelecioneCliente);
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(947, 42);
            panel3.TabIndex = 12;
            // 
            // TextSelecioneCliente
            // 
            TextSelecioneCliente.AutoSize = true;
            TextSelecioneCliente.Location = new Point(118, 13);
            TextSelecioneCliente.Name = "TextSelecioneCliente";
            TextSelecioneCliente.Size = new Size(125, 15);
            TextSelecioneCliente.TabIndex = 6;
            TextSelecioneCliente.Text = "SELECIONE O CLIENTE";
            // 
            // panel2
            // 
            panel2.BackgroundImage = Properties.Resources.Screenshot_1;
            panel2.BackgroundImageLayout = ImageLayout.Stretch;
            panel2.Controls.Add(MaskedTextboxTelefone);
            panel2.Controls.Add(TextNome);
            panel2.Controls.Add(TextTelefone);
            panel2.Controls.Add(panel1);
            panel2.Controls.Add(MaskedTextboxCpf);
            panel2.Controls.Add(textBoxNome);
            panel2.Controls.Add(BtnBuscar);
            panel2.Controls.Add(TextCpf);
            panel2.Location = new Point(0, 48);
            panel2.Name = "panel2";
            panel2.Size = new Size(396, 456);
            panel2.TabIndex = 11;
            // 
            // MaskedTextboxTelefone
            // 
            MaskedTextboxTelefone.Anchor = AnchorStyles.None;
            MaskedTextboxTelefone.Location = new Point(257, 28);
            MaskedTextboxTelefone.Mask = "(00) 90000-0000";
            MaskedTextboxTelefone.Name = "MaskedTextboxTelefone";
            MaskedTextboxTelefone.Size = new Size(92, 23);
            MaskedTextboxTelefone.TabIndex = 11;
            MaskedTextboxTelefone.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            // 
            // TextNome
            // 
            TextNome.AutoSize = true;
            TextNome.BackColor = Color.Transparent;
            TextNome.Location = new Point(3, 10);
            TextNome.Name = "TextNome";
            TextNome.Size = new Size(42, 15);
            TextNome.TabIndex = 0;
            TextNome.Text = "NOME";
            // 
            // TextTelefone
            // 
            TextTelefone.AutoSize = true;
            TextTelefone.BackColor = Color.Transparent;
            TextTelefone.Location = new Point(257, 10);
            TextTelefone.Name = "TextTelefone";
            TextTelefone.Size = new Size(61, 15);
            TextTelefone.TabIndex = 4;
            TextTelefone.Text = "TELEFONE";
            // 
            // panel1
            // 
            panel1.Controls.Add(dataGridViewClientes);
            panel1.Location = new Point(6, 98);
            panel1.Name = "panel1";
            panel1.Size = new Size(387, 254);
            panel1.TabIndex = 10;
            // 
            // dataGridViewClientes
            // 
            dataGridViewClientes.AllowUserToAddRows = false;
            dataGridViewClientes.AllowUserToDeleteRows = false;
            dataGridViewClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewClientes.Dock = DockStyle.Fill;
            dataGridViewClientes.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridViewClientes.Location = new Point(0, 0);
            dataGridViewClientes.MultiSelect = false;
            dataGridViewClientes.Name = "dataGridViewClientes";
            dataGridViewClientes.RowTemplate.Height = 25;
            dataGridViewClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewClientes.Size = new Size(387, 254);
            dataGridViewClientes.TabIndex = 0;
            dataGridViewClientes.CellContentClick += dataGridViewClientes_CellContentClick;
            // 
            // MaskedTextboxCpf
            // 
            MaskedTextboxCpf.Anchor = AnchorStyles.None;
            MaskedTextboxCpf.Location = new Point(118, 28);
            MaskedTextboxCpf.Mask = "000.000.000-00";
            MaskedTextboxCpf.Name = "MaskedTextboxCpf";
            MaskedTextboxCpf.RightToLeft = RightToLeft.No;
            MaskedTextboxCpf.Size = new Size(106, 23);
            MaskedTextboxCpf.TabIndex = 3;
            MaskedTextboxCpf.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            // 
            // textBoxNome
            // 
            textBoxNome.Location = new Point(3, 28);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(100, 23);
            textBoxNome.TabIndex = 1;
            // 
            // BtnBuscar
            // 
            BtnBuscar.ForeColor = SystemColors.InactiveCaptionText;
            BtnBuscar.Location = new Point(124, 69);
            BtnBuscar.Name = "BtnBuscar";
            BtnBuscar.Size = new Size(100, 23);
            BtnBuscar.TabIndex = 7;
            BtnBuscar.Text = "BUSCAR";
            BtnBuscar.UseVisualStyleBackColor = true;
            BtnBuscar.Click += BtnBuscar_Click;
            // 
            // TextCpf
            // 
            TextCpf.AutoSize = true;
            TextCpf.BackColor = Color.Transparent;
            TextCpf.Location = new Point(118, 10);
            TextCpf.Name = "TextCpf";
            TextCpf.Size = new Size(28, 15);
            TextCpf.TabIndex = 2;
            TextCpf.Text = "CPF";
            // 
            // tabPagePizza
            // 
            tabPagePizza.Controls.Add(panel4);
            tabPagePizza.Controls.Add(TextSaboresLimite);
            tabPagePizza.Controls.Add(TextSelecioneTamanho);
            tabPagePizza.Controls.Add(comboBoxTamanho);
            tabPagePizza.Location = new Point(28, 4);
            tabPagePizza.Name = "tabPagePizza";
            tabPagePizza.Padding = new Padding(3);
            tabPagePizza.Size = new Size(946, 500);
            tabPagePizza.TabIndex = 1;
            tabPagePizza.Text = "Pizza";
            tabPagePizza.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            panel4.Controls.Add(dataGridViewSabores);
            panel4.Location = new Point(6, 56);
            panel4.Name = "panel4";
            panel4.Size = new Size(200, 438);
            panel4.TabIndex = 3;
            // 
            // dataGridViewSabores
            // 
            dataGridViewSabores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewSabores.Dock = DockStyle.Fill;
            dataGridViewSabores.Location = new Point(0, 0);
            dataGridViewSabores.Name = "dataGridViewSabores";
            dataGridViewSabores.RowTemplate.Height = 25;
            dataGridViewSabores.Size = new Size(200, 438);
            dataGridViewSabores.TabIndex = 0;
            // 
            // TextSaboresLimite
            // 
            TextSaboresLimite.AutoSize = true;
            TextSaboresLimite.Location = new Point(223, 0);
            TextSaboresLimite.Name = "TextSaboresLimite";
            TextSaboresLimite.Size = new Size(457, 54);
            TextSaboresLimite.TabIndex = 2;
            TextSaboresLimite.Text = "Limites por sabores:\r\nPequena - 1 Sabor         |  Grande - 3 Sabores                \r\nMédia        - 2 Sabores   |  Familia - 5 Sabores";
            // 
            // TextSelecioneTamanho
            // 
            TextSelecioneTamanho.AutoSize = true;
            TextSelecioneTamanho.Location = new Point(6, 3);
            TextSelecioneTamanho.Name = "TextSelecioneTamanho";
            TextSelecioneTamanho.Size = new Size(198, 18);
            TextSelecioneTamanho.TabIndex = 1;
            TextSelecioneTamanho.Text = "Selecione o Tamanho";
            // 
            // comboBoxTamanho
            // 
            comboBoxTamanho.FormattingEnabled = true;
            comboBoxTamanho.Items.AddRange(new object[] { "Pequena", "Media", "Grande", "Familia" });
            comboBoxTamanho.Location = new Point(6, 24);
            comboBoxTamanho.Name = "comboBoxTamanho";
            comboBoxTamanho.Size = new Size(198, 26);
            comboBoxTamanho.TabIndex = 0;
            comboBoxTamanho.MouseCaptureChanged += comboBoxTamanho_MouseCaptureChanged;
            // 
            // tabPageProduto
            // 
            tabPageProduto.Location = new Point(28, 4);
            tabPageProduto.Name = "tabPageProduto";
            tabPageProduto.Size = new Size(946, 500);
            tabPageProduto.TabIndex = 2;
            tabPageProduto.Text = "Produto";
            tabPageProduto.UseVisualStyleBackColor = true;
            // 
            // CadastroPedidos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1054, 655);
            Controls.Add(tabControlPedidos);
            Controls.Add(TextCadastroPedido);
            Name = "CadastroPedidos";
            Text = "CadastroPedidos";
            tabControlPedidos.ResumeLayout(false);
            tabPageCliente.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewClientes).EndInit();
            tabPagePizza.ResumeLayout(false);
            tabPagePizza.PerformLayout();
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewSabores).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label TextCadastroPedido;
        private TabControl tabControlPedidos;
        private TabPage tabPageCliente;
        private TabPage tabPagePizza;
        private Label TextSelecioneCliente;
        private Label TextTelefone;
        private Label TextCpf;
        private TextBox textBoxNome;
        private Label TextNome;
        private Button BtnBuscar;
        private Panel panel1;
        private DataGridView dataGridViewClientes;
        private MaskedTextBox MaskedTextboxCpf;
        private Panel panel2;
        private Panel panel3;
        private MaskedTextBox MaskedTextboxTelefone;
        private TabPage tabPageProduto;
        private Label TextSelecioneTamanho;
        private ComboBox comboBoxTamanho;
        private Label TextSaboresLimite;
        private Panel panel4;
        private DataGridView dataGridViewSabores;
    }
}