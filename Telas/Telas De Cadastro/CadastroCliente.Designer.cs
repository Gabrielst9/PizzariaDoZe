﻿namespace PizzariaDoZe
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
            TextCadastroCliente = new Label();
            CrudCliente = new CRUD();
            BtnSair = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel1 = new Panel();
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
            panel2 = new Panel();
            panel5 = new Panel();
            userControlEndereco1 = new Telas.userControlEndereco();
            flowLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // TextCadastroCliente
            // 
            TextCadastroCliente.Anchor = AnchorStyles.None;
            TextCadastroCliente.AutoSize = true;
            TextCadastroCliente.BackColor = SystemColors.ActiveCaptionText;
            TextCadastroCliente.BorderStyle = BorderStyle.Fixed3D;
            TextCadastroCliente.Font = new Font("Copperplate Gothic Bold", 36F, FontStyle.Regular, GraphicsUnit.Point);
            TextCadastroCliente.ForeColor = SystemColors.Info;
            TextCadastroCliente.Image = Properties.Resources.Screenshot_1;
            TextCadastroCliente.Location = new Point(237, 5);
            TextCadastroCliente.Name = "TextCadastroCliente";
            TextCadastroCliente.Size = new Size(701, 55);
            TextCadastroCliente.TabIndex = 1;
            TextCadastroCliente.Text = "CADASTRO DE CLIENTES";
            TextCadastroCliente.TextAlign = ContentAlignment.TopCenter;
            // 
            // CrudCliente
            // 
            CrudCliente.BackColor = SystemColors.Desktop;
            CrudCliente.ForeColor = SystemColors.Info;
            CrudCliente.Location = new Point(164, 10);
            CrudCliente.Margin = new Padding(4, 5, 4, 5);
            CrudCliente.Name = "CrudCliente";
            CrudCliente.Size = new Size(456, 66);
            CrudCliente.TabIndex = 5;
            // 
            // BtnSair
            // 
            BtnSair.Anchor = AnchorStyles.None;
            BtnSair.BackColor = SystemColors.HotTrack;
            BtnSair.BackgroundImage = Properties.Resources.Screenshot_1;
            BtnSair.BackgroundImageLayout = ImageLayout.Stretch;
            BtnSair.Cursor = Cursors.Hand;
            BtnSair.FlatStyle = FlatStyle.Flat;
            BtnSair.Font = new Font("Copperplate Gothic Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            BtnSair.ForeColor = SystemColors.Info;
            BtnSair.Location = new Point(473, 550);
            BtnSair.Margin = new Padding(4, 3, 4, 3);
            BtnSair.Name = "BtnSair";
            BtnSair.Size = new Size(229, 32);
            BtnSair.TabIndex = 13;
            BtnSair.Text = "SAIR";
            BtnSair.UseVisualStyleBackColor = false;
            BtnSair.Click += Btn_Sair_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(panel1);
            flowLayoutPanel1.Controls.Add(panel2);
            flowLayoutPanel1.Controls.Add(panel5);
            flowLayoutPanel1.Location = new Point(283, 160);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(784, 384);
            flowLayoutPanel1.TabIndex = 14;
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.Screenshot_1;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(TextIDCliente);
            panel1.Controls.Add(TextboxIdCliente);
            panel1.Controls.Add(TextEmail);
            panel1.Controls.Add(TextboxNome);
            panel1.Controls.Add(TextCpf);
            panel1.Controls.Add(TextboxEmail);
            panel1.Controls.Add(MaskedTextboxCpf);
            panel1.Controls.Add(MaskedTextboxTelefone);
            panel1.Controls.Add(TextNome);
            panel1.Controls.Add(TextTelefone);
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
            // TextboxIdCliente
            // 
            TextboxIdCliente.Anchor = AnchorStyles.None;
            TextboxIdCliente.BackColor = SystemColors.ControlDarkDark;
            TextboxIdCliente.Cursor = Cursors.IBeam;
            TextboxIdCliente.Enabled = false;
            TextboxIdCliente.Font = new Font("Copperplate Gothic Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            TextboxIdCliente.ForeColor = SystemColors.MenuText;
            TextboxIdCliente.Location = new Point(3, 30);
            TextboxIdCliente.MaxLength = 80;
            TextboxIdCliente.Name = "TextboxIdCliente";
            TextboxIdCliente.Size = new Size(34, 21);
            TextboxIdCliente.TabIndex = 16;
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
            // TextboxNome
            // 
            TextboxNome.Anchor = AnchorStyles.None;
            TextboxNome.BackColor = SystemColors.ButtonHighlight;
            TextboxNome.Cursor = Cursors.IBeam;
            TextboxNome.Font = new Font("Copperplate Gothic Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            TextboxNome.ForeColor = SystemColors.MenuText;
            TextboxNome.Location = new Point(3, 92);
            TextboxNome.MaxLength = 80;
            TextboxNome.Name = "TextboxNome";
            TextboxNome.Size = new Size(319, 21);
            TextboxNome.TabIndex = 1;
            // 
            // TextCpf
            // 
            TextCpf.Anchor = AnchorStyles.None;
            TextCpf.AutoSize = true;
            TextCpf.BackColor = Color.Transparent;
            TextCpf.Font = new Font("Copperplate Gothic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TextCpf.ForeColor = SystemColors.Info;
            TextCpf.Location = new Point(3, 125);
            TextCpf.Name = "TextCpf";
            TextCpf.Size = new Size(45, 18);
            TextCpf.TabIndex = 11;
            TextCpf.Text = "CPF";
            TextCpf.TextAlign = ContentAlignment.TopCenter;
            // 
            // TextboxEmail
            // 
            TextboxEmail.Anchor = AnchorStyles.None;
            TextboxEmail.Location = new Point(3, 262);
            TextboxEmail.Name = "TextboxEmail";
            TextboxEmail.Size = new Size(320, 23);
            TextboxEmail.TabIndex = 4;
            // 
            // MaskedTextboxCpf
            // 
            MaskedTextboxCpf.Anchor = AnchorStyles.None;
            MaskedTextboxCpf.Location = new Point(0, 146);
            MaskedTextboxCpf.Mask = "000.000.000-00";
            MaskedTextboxCpf.Name = "MaskedTextboxCpf";
            MaskedTextboxCpf.RightToLeft = RightToLeft.No;
            MaskedTextboxCpf.Size = new Size(106, 23);
            MaskedTextboxCpf.TabIndex = 2;
            MaskedTextboxCpf.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            // 
            // MaskedTextboxTelefone
            // 
            MaskedTextboxTelefone.Anchor = AnchorStyles.None;
            MaskedTextboxTelefone.Location = new Point(0, 206);
            MaskedTextboxTelefone.Mask = "(999) 000-0000";
            MaskedTextboxTelefone.Name = "MaskedTextboxTelefone";
            MaskedTextboxTelefone.Size = new Size(92, 23);
            MaskedTextboxTelefone.TabIndex = 3;
            MaskedTextboxTelefone.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
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
            // TextTelefone
            // 
            TextTelefone.Anchor = AnchorStyles.None;
            TextTelefone.AutoSize = true;
            TextTelefone.BackColor = Color.Transparent;
            TextTelefone.Font = new Font("Copperplate Gothic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TextTelefone.ForeColor = SystemColors.Info;
            TextTelefone.Location = new Point(3, 185);
            TextTelefone.Name = "TextTelefone";
            TextTelefone.Size = new Size(106, 18);
            TextTelefone.TabIndex = 14;
            TextTelefone.Text = "TELEFONE";
            TextTelefone.TextAlign = ContentAlignment.TopCenter;
            // 
            // panel2
            // 
            panel2.Controls.Add(userControlEndereco1);
            panel2.Location = new Point(336, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(445, 285);
            panel2.TabIndex = 0;
            // 
            // panel5
            // 
            panel5.Controls.Add(CrudCliente);
            panel5.Location = new Point(3, 303);
            panel5.Name = "panel5";
            panel5.Size = new Size(784, 86);
            panel5.TabIndex = 2;
            // 
            // userControlEndereco1
            // 
            userControlEndereco1.BackgroundImage = (Image)resources.GetObject("userControlEndereco1.BackgroundImage");
            userControlEndereco1.BackgroundImageLayout = ImageLayout.Stretch;
            userControlEndereco1.ForeColor = SystemColors.Info;
            userControlEndereco1.Location = new Point(2, 0);
            userControlEndereco1.Name = "userControlEndereco1";
            userControlEndereco1.Size = new Size(441, 285);
            userControlEndereco1.TabIndex = 2;
            // 
            // CadastroCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            BackgroundImage = Properties.Resources.istockphoto_1137028124_612x612;
            ClientSize = new Size(1174, 616);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(BtnSair);
            Controls.Add(TextCadastroCliente);
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
        private Label TextCadastroCliente;
        private CRUD CrudCliente;
        private Button BtnSair;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel1;
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
        private Panel panel2;
        private Panel panel5;
        private Telas.userControlEndereco userControlEndereco1;
    }
}