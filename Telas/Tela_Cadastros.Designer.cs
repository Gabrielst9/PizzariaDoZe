namespace PizzariaDoZe.Telas
{
    partial class Tela_Cadastros
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
            BTN_Cadastrar_Ingredientes = new Button();
            BTN_Cadastro_Sabores = new Button();
            PainelTelaCadastrosAdm = new Panel();
            BTN_CadastrarProdutos = new Button();
            BTN_CadastrarFuncionarios = new Button();
            BTN_CadastroValores = new Button();
            BTN_CadastrarClientes = new Button();
            BTN_Sair_TelaCadastro = new Button();
            Titulo_Principal = new Label();
            PainelTelaCadastrosAdm.SuspendLayout();
            SuspendLayout();
            // 
            // BTN_Cadastrar_Ingredientes
            // 
            BTN_Cadastrar_Ingredientes.BackgroundImage = Properties.Resources.Screenshot_1;
            BTN_Cadastrar_Ingredientes.BackgroundImageLayout = ImageLayout.Stretch;
            BTN_Cadastrar_Ingredientes.ForeColor = SystemColors.Info;
            BTN_Cadastrar_Ingredientes.Location = new Point(23, 33);
            BTN_Cadastrar_Ingredientes.Name = "BTN_Cadastrar_Ingredientes";
            BTN_Cadastrar_Ingredientes.Size = new Size(135, 58);
            BTN_Cadastrar_Ingredientes.TabIndex = 1;
            BTN_Cadastrar_Ingredientes.Text = "CADASTRAR INGREDIENTES";
            BTN_Cadastrar_Ingredientes.UseVisualStyleBackColor = true;
            BTN_Cadastrar_Ingredientes.Click += BTN_Cadastrar_Ingredientes_Click;
            // 
            // BTN_Cadastro_Sabores
            // 
            BTN_Cadastro_Sabores.BackgroundImage = Properties.Resources.Screenshot_1;
            BTN_Cadastro_Sabores.BackgroundImageLayout = ImageLayout.Stretch;
            BTN_Cadastro_Sabores.ForeColor = SystemColors.Info;
            BTN_Cadastro_Sabores.Location = new Point(23, 131);
            BTN_Cadastro_Sabores.Name = "BTN_Cadastro_Sabores";
            BTN_Cadastro_Sabores.Size = new Size(135, 58);
            BTN_Cadastro_Sabores.TabIndex = 4;
            BTN_Cadastro_Sabores.Text = "CADASTRAR SABORES";
            BTN_Cadastro_Sabores.UseVisualStyleBackColor = true;
            BTN_Cadastro_Sabores.Click += BTN_Cadastro_Sabores_Click;
            // 
            // PainelTelaCadastrosAdm
            // 
            PainelTelaCadastrosAdm.Anchor = AnchorStyles.None;
            PainelTelaCadastrosAdm.BackColor = Color.Transparent;
            PainelTelaCadastrosAdm.Controls.Add(BTN_CadastrarProdutos);
            PainelTelaCadastrosAdm.Controls.Add(BTN_CadastrarFuncionarios);
            PainelTelaCadastrosAdm.Controls.Add(BTN_CadastroValores);
            PainelTelaCadastrosAdm.Controls.Add(BTN_CadastrarClientes);
            PainelTelaCadastrosAdm.Controls.Add(BTN_Cadastrar_Ingredientes);
            PainelTelaCadastrosAdm.Controls.Add(BTN_Cadastro_Sabores);
            PainelTelaCadastrosAdm.Location = new Point(255, 94);
            PainelTelaCadastrosAdm.Name = "PainelTelaCadastrosAdm";
            PainelTelaCadastrosAdm.Size = new Size(518, 227);
            PainelTelaCadastrosAdm.TabIndex = 3;
            // 
            // BTN_CadastrarProdutos
            // 
            BTN_CadastrarProdutos.BackgroundImage = Properties.Resources.Screenshot_1;
            BTN_CadastrarProdutos.BackgroundImageLayout = ImageLayout.Stretch;
            BTN_CadastrarProdutos.ForeColor = SystemColors.Info;
            BTN_CadastrarProdutos.Location = new Point(350, 131);
            BTN_CadastrarProdutos.Name = "BTN_CadastrarProdutos";
            BTN_CadastrarProdutos.Size = new Size(135, 58);
            BTN_CadastrarProdutos.TabIndex = 6;
            BTN_CadastrarProdutos.Text = "CADASTRAR PRODUTOS";
            BTN_CadastrarProdutos.UseVisualStyleBackColor = true;
            BTN_CadastrarProdutos.Click += BTN_CadastrarProdutos_Click;
            // 
            // BTN_CadastrarFuncionarios
            // 
            BTN_CadastrarFuncionarios.BackgroundImage = Properties.Resources.Screenshot_1;
            BTN_CadastrarFuncionarios.BackgroundImageLayout = ImageLayout.Stretch;
            BTN_CadastrarFuncionarios.ForeColor = SystemColors.Info;
            BTN_CadastrarFuncionarios.Location = new Point(350, 33);
            BTN_CadastrarFuncionarios.Name = "BTN_CadastrarFuncionarios";
            BTN_CadastrarFuncionarios.Size = new Size(135, 58);
            BTN_CadastrarFuncionarios.TabIndex = 3;
            BTN_CadastrarFuncionarios.Text = "CADASTRAR FUNCIONARIOS";
            BTN_CadastrarFuncionarios.UseVisualStyleBackColor = true;
            BTN_CadastrarFuncionarios.Click += BTN_CadastrarFuncionarios_Click;
            // 
            // BTN_CadastroValores
            // 
            BTN_CadastroValores.BackgroundImage = Properties.Resources.Screenshot_1;
            BTN_CadastroValores.BackgroundImageLayout = ImageLayout.Stretch;
            BTN_CadastroValores.ForeColor = SystemColors.Info;
            BTN_CadastroValores.Location = new Point(184, 131);
            BTN_CadastroValores.Name = "BTN_CadastroValores";
            BTN_CadastroValores.Size = new Size(135, 58);
            BTN_CadastroValores.TabIndex = 5;
            BTN_CadastroValores.Text = "CADASTRAR VALORES";
            BTN_CadastroValores.UseVisualStyleBackColor = true;
            BTN_CadastroValores.Click += BTN_CadastroValores_Click;
            // 
            // BTN_CadastrarClientes
            // 
            BTN_CadastrarClientes.BackgroundImage = Properties.Resources.Screenshot_1;
            BTN_CadastrarClientes.BackgroundImageLayout = ImageLayout.Stretch;
            BTN_CadastrarClientes.ForeColor = SystemColors.Info;
            BTN_CadastrarClientes.Location = new Point(184, 33);
            BTN_CadastrarClientes.Name = "BTN_CadastrarClientes";
            BTN_CadastrarClientes.Size = new Size(135, 58);
            BTN_CadastrarClientes.TabIndex = 2;
            BTN_CadastrarClientes.Text = "CADASTRAR CLIENTES";
            BTN_CadastrarClientes.UseVisualStyleBackColor = true;
            BTN_CadastrarClientes.Click += BTN_CadastrarClientes_Click;
            // 
            // BTN_Sair_TelaCadastro
            // 
            BTN_Sair_TelaCadastro.Anchor = AnchorStyles.None;
            BTN_Sair_TelaCadastro.BackgroundImage = Properties.Resources.Screenshot_1;
            BTN_Sair_TelaCadastro.BackgroundImageLayout = ImageLayout.Stretch;
            BTN_Sair_TelaCadastro.Font = new Font("Copperplate Gothic Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            BTN_Sair_TelaCadastro.ForeColor = SystemColors.Info;
            BTN_Sair_TelaCadastro.Location = new Point(439, 380);
            BTN_Sair_TelaCadastro.Name = "BTN_Sair_TelaCadastro";
            BTN_Sair_TelaCadastro.Size = new Size(150, 58);
            BTN_Sair_TelaCadastro.TabIndex = 7;
            BTN_Sair_TelaCadastro.Text = "SAIR";
            BTN_Sair_TelaCadastro.UseVisualStyleBackColor = true;
            BTN_Sair_TelaCadastro.Click += BTN_Sair_TelaCadastro_Click;
            // 
            // Titulo_Principal
            // 
            Titulo_Principal.Anchor = AnchorStyles.None;
            Titulo_Principal.AutoSize = true;
            Titulo_Principal.BackColor = SystemColors.ActiveCaptionText;
            Titulo_Principal.BorderStyle = BorderStyle.Fixed3D;
            Titulo_Principal.Font = new Font("Copperplate Gothic Bold", 36F, FontStyle.Regular, GraphicsUnit.Point);
            Titulo_Principal.ForeColor = SystemColors.Info;
            Titulo_Principal.Image = Properties.Resources.Screenshot_1;
            Titulo_Principal.Location = new Point(287, 12);
            Titulo_Principal.Margin = new Padding(4, 50, 4, 0);
            Titulo_Principal.Name = "Titulo_Principal";
            Titulo_Principal.Size = new Size(454, 55);
            Titulo_Principal.TabIndex = 5;
            Titulo_Principal.Text = "PIZZARIA DO ZÉ";
            Titulo_Principal.TextAlign = ContentAlignment.MiddleCenter;
            Titulo_Principal.Click += Titulo_Principal_Click;
            // 
            // Tela_Cadastros
            // 
            AutoScaleDimensions = new SizeF(9F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.istockphoto_1137028124_612x612;
            ClientSize = new Size(1029, 420);
            Controls.Add(Titulo_Principal);
            Controls.Add(BTN_Sair_TelaCadastro);
            Controls.Add(PainelTelaCadastrosAdm);
            Font = new Font("Copperplate Gothic Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "Tela_Cadastros";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tela_Cadastros";
            WindowState = FormWindowState.Maximized;
            PainelTelaCadastrosAdm.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BTN_Cadastrar_Ingredientes;
        private Button BTN_Cadastro_Sabores;
        private Panel PainelTelaCadastrosAdm;
        private Button BTN_Sair_TelaCadastro;
        private Label Titulo_Principal;
        private Button BTN_CadastrarClientes;
        private Button BTN_CadastroValores;
        private Button BTN_CadastrarFuncionarios;
        private Button BTN_CadastrarProdutos;
    }
}