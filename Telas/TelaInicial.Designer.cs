namespace PizzariaDoZe
{
    partial class TelaInicial
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
            PNL_LATERAL_LOGIN = new FlowLayoutPanel();
            PNL1_MENU = new Panel();
            BTN_MENU = new Button();
            TEXT1_MENU = new Label();
            panel1 = new Panel();
            BtnConfiguracoes = new Button();
            BTN1_CLIENTES = new Button();
            BTN_LOGIN_ADM = new Button();
            BTN1_CADASTRO_CLIENT = new Button();
            TEXT_PRIMEI_VEZ = new Label();
            TEXT1_FACA_LOGIN = new Label();
            BTN1_LOGIN = new Button();
            PNL1_MENU_LOGIN = new Panel();
            BTN1_SAIR = new Button();
            BTN_TelaPrincipalShortCuts = new Button();
            PNL_LATERAL_LOGIN.SuspendLayout();
            PNL1_MENU.SuspendLayout();
            panel1.SuspendLayout();
            PNL1_MENU_LOGIN.SuspendLayout();
            SuspendLayout();
            // 
            // PNL_LATERAL_LOGIN
            // 
            PNL_LATERAL_LOGIN.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            PNL_LATERAL_LOGIN.AutoSize = true;
            PNL_LATERAL_LOGIN.BackgroundImageLayout = ImageLayout.Stretch;
            PNL_LATERAL_LOGIN.BorderStyle = BorderStyle.Fixed3D;
            PNL_LATERAL_LOGIN.Controls.Add(PNL1_MENU);
            PNL_LATERAL_LOGIN.Controls.Add(panel1);
            PNL_LATERAL_LOGIN.Location = new Point(0, 0);
            PNL_LATERAL_LOGIN.MaximumSize = new Size(206, 1200);
            PNL_LATERAL_LOGIN.MinimumSize = new Size(42, 540);
            PNL_LATERAL_LOGIN.Name = "PNL_LATERAL_LOGIN";
            PNL_LATERAL_LOGIN.Size = new Size(206, 540);
            PNL_LATERAL_LOGIN.TabIndex = 0;
            PNL_LATERAL_LOGIN.Paint += PNL_LATERAL_LOGIN_Paint;
            // 
            // PNL1_MENU
            // 
            PNL1_MENU.Controls.Add(BTN_MENU);
            PNL1_MENU.Controls.Add(TEXT1_MENU);
            PNL1_MENU.Location = new Point(3, 3);
            PNL1_MENU.Name = "PNL1_MENU";
            PNL1_MENU.Size = new Size(206, 87);
            PNL1_MENU.TabIndex = 1;
            PNL1_MENU.Paint += PNL1_MENU_Paint;
            // 
            // BTN_MENU
            // 
            BTN_MENU.BackColor = SystemColors.Info;
            BTN_MENU.Image = Properties.Resources.icons8_menu_48;
            BTN_MENU.Location = new Point(0, 26);
            BTN_MENU.Name = "BTN_MENU";
            BTN_MENU.Size = new Size(40, 37);
            BTN_MENU.TabIndex = 10;
            BTN_MENU.TabStop = false;
            BTN_MENU.UseVisualStyleBackColor = false;
            BTN_MENU.Click += Button2_Click;
            // 
            // TEXT1_MENU
            // 
            TEXT1_MENU.AutoSize = true;
            TEXT1_MENU.Location = new Point(65, 35);
            TEXT1_MENU.Name = "TEXT1_MENU";
            TEXT1_MENU.Size = new Size(62, 18);
            TEXT1_MENU.TabIndex = 1;
            TEXT1_MENU.Text = "MENU";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(BTN_TelaPrincipalShortCuts);
            panel1.Controls.Add(BtnConfiguracoes);
            panel1.Controls.Add(BTN1_CLIENTES);
            panel1.Controls.Add(BTN_LOGIN_ADM);
            panel1.Location = new Point(3, 96);
            panel1.Name = "panel1";
            panel1.Size = new Size(207, 245);
            panel1.TabIndex = 5;
            // 
            // BtnConfiguracoes
            // 
            BtnConfiguracoes.Anchor = AnchorStyles.None;
            BtnConfiguracoes.BackColor = SystemColors.Info;
            BtnConfiguracoes.BackgroundImageLayout = ImageLayout.None;
            BtnConfiguracoes.Font = new Font("Copperplate Gothic Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            BtnConfiguracoes.ForeColor = SystemColors.ControlText;
            BtnConfiguracoes.ImageAlign = ContentAlignment.BottomLeft;
            BtnConfiguracoes.Location = new Point(0, 105);
            BtnConfiguracoes.Margin = new Padding(0);
            BtnConfiguracoes.Name = "BtnConfiguracoes";
            BtnConfiguracoes.Size = new Size(208, 44);
            BtnConfiguracoes.TabIndex = 5;
            BtnConfiguracoes.Text = "     \r\nCONFIGURAÇÕES";
            BtnConfiguracoes.TextAlign = ContentAlignment.TopRight;
            BtnConfiguracoes.UseVisualStyleBackColor = false;
            BtnConfiguracoes.Click += BtnConfiguracoes_Click;
            // 
            // BTN1_CLIENTES
            // 
            BTN1_CLIENTES.BackColor = SystemColors.Info;
            BTN1_CLIENTES.ForeColor = SystemColors.ControlText;
            BTN1_CLIENTES.Image = Properties.Resources.icons8_user_male_48;
            BTN1_CLIENTES.ImageAlign = ContentAlignment.MiddleLeft;
            BTN1_CLIENTES.Location = new Point(0, 3);
            BTN1_CLIENTES.Name = "BTN1_CLIENTES";
            BTN1_CLIENTES.Size = new Size(207, 45);
            BTN1_CLIENTES.TabIndex = 3;
            BTN1_CLIENTES.Text = "CLIENTE";
            BTN1_CLIENTES.UseVisualStyleBackColor = false;
            BTN1_CLIENTES.Click += BTN1_CLIENTES_Click;
            // 
            // BTN_LOGIN_ADM
            // 
            BTN_LOGIN_ADM.BackColor = SystemColors.Info;
            BTN_LOGIN_ADM.ForeColor = SystemColors.ControlText;
            BTN_LOGIN_ADM.Image = Properties.Resources.icons8_lock_48;
            BTN_LOGIN_ADM.ImageAlign = ContentAlignment.MiddleLeft;
            BTN_LOGIN_ADM.Location = new Point(-1, 54);
            BTN_LOGIN_ADM.Name = "BTN_LOGIN_ADM";
            BTN_LOGIN_ADM.Size = new Size(208, 44);
            BTN_LOGIN_ADM.TabIndex = 4;
            BTN_LOGIN_ADM.Text = "         ADMINISTRADOR";
            BTN_LOGIN_ADM.UseVisualStyleBackColor = false;
            BTN_LOGIN_ADM.Click += BTN_LOGIN_ADM_Click;
            // 
            // BTN1_CADASTRO_CLIENT
            // 
            BTN1_CADASTRO_CLIENT.BackgroundImage = Properties.Resources.Screenshot_1;
            BTN1_CADASTRO_CLIENT.BackgroundImageLayout = ImageLayout.Stretch;
            BTN1_CADASTRO_CLIENT.Location = new Point(36, 83);
            BTN1_CADASTRO_CLIENT.Name = "BTN1_CADASTRO_CLIENT";
            BTN1_CADASTRO_CLIENT.Size = new Size(248, 45);
            BTN1_CADASTRO_CLIENT.TabIndex = 0;
            BTN1_CADASTRO_CLIENT.Text = "CADASTRAR";
            BTN1_CADASTRO_CLIENT.UseVisualStyleBackColor = true;
            BTN1_CADASTRO_CLIENT.Click += BTN1_CADASTRO_CLIENT_Click;
            // 
            // TEXT_PRIMEI_VEZ
            // 
            TEXT_PRIMEI_VEZ.AutoSize = true;
            TEXT_PRIMEI_VEZ.BackColor = Color.Transparent;
            TEXT_PRIMEI_VEZ.Font = new Font("Copperplate Gothic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TEXT_PRIMEI_VEZ.Location = new Point(3, 41);
            TEXT_PRIMEI_VEZ.Name = "TEXT_PRIMEI_VEZ";
            TEXT_PRIMEI_VEZ.Size = new Size(310, 18);
            TEXT_PRIMEI_VEZ.TabIndex = 2;
            TEXT_PRIMEI_VEZ.Text = "PRIMEIRA VEZ? CRIE UMA CONTA!";
            // 
            // TEXT1_FACA_LOGIN
            // 
            TEXT1_FACA_LOGIN.AutoSize = true;
            TEXT1_FACA_LOGIN.BackColor = Color.Transparent;
            TEXT1_FACA_LOGIN.Font = new Font("Copperplate Gothic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TEXT1_FACA_LOGIN.Location = new Point(15, 197);
            TEXT1_FACA_LOGIN.Name = "TEXT1_FACA_LOGIN";
            TEXT1_FACA_LOGIN.Size = new Size(285, 18);
            TEXT1_FACA_LOGIN.TabIndex = 3;
            TEXT1_FACA_LOGIN.Text = "JA TEM CONTA? FAÇA O LOGIN";
            // 
            // BTN1_LOGIN
            // 
            BTN1_LOGIN.BackgroundImage = Properties.Resources.Screenshot_1;
            BTN1_LOGIN.BackgroundImageLayout = ImageLayout.Stretch;
            BTN1_LOGIN.Location = new Point(36, 232);
            BTN1_LOGIN.Name = "BTN1_LOGIN";
            BTN1_LOGIN.Size = new Size(248, 44);
            BTN1_LOGIN.TabIndex = 1;
            BTN1_LOGIN.Text = "ENTRAR";
            BTN1_LOGIN.UseVisualStyleBackColor = true;
            BTN1_LOGIN.Click += BTN1_LOGIN_Click;
            // 
            // PNL1_MENU_LOGIN
            // 
            PNL1_MENU_LOGIN.BackgroundImage = Properties.Resources.Screenshot_1;
            PNL1_MENU_LOGIN.BorderStyle = BorderStyle.Fixed3D;
            PNL1_MENU_LOGIN.Controls.Add(TEXT_PRIMEI_VEZ);
            PNL1_MENU_LOGIN.Controls.Add(BTN1_LOGIN);
            PNL1_MENU_LOGIN.Controls.Add(BTN1_CADASTRO_CLIENT);
            PNL1_MENU_LOGIN.Controls.Add(TEXT1_FACA_LOGIN);
            PNL1_MENU_LOGIN.Location = new Point(525, 118);
            PNL1_MENU_LOGIN.Name = "PNL1_MENU_LOGIN";
            PNL1_MENU_LOGIN.Size = new Size(321, 304);
            PNL1_MENU_LOGIN.TabIndex = 0;
            // 
            // BTN1_SAIR
            // 
            BTN1_SAIR.Anchor = AnchorStyles.None;
            BTN1_SAIR.BackColor = SystemColors.HotTrack;
            BTN1_SAIR.BackgroundImage = Properties.Resources.Screenshot_1;
            BTN1_SAIR.BackgroundImageLayout = ImageLayout.Stretch;
            BTN1_SAIR.Cursor = Cursors.Hand;
            BTN1_SAIR.FlatStyle = FlatStyle.Flat;
            BTN1_SAIR.Font = new Font("Copperplate Gothic Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            BTN1_SAIR.ForeColor = SystemColors.Info;
            BTN1_SAIR.Location = new Point(571, 476);
            BTN1_SAIR.Margin = new Padding(4, 3, 4, 3);
            BTN1_SAIR.Name = "BTN1_SAIR";
            BTN1_SAIR.Size = new Size(229, 32);
            BTN1_SAIR.TabIndex = 6;
            BTN1_SAIR.Text = "SAIR";
            BTN1_SAIR.UseVisualStyleBackColor = false;
            BTN1_SAIR.Click += BTN1_SAIR_Click;
            // 
            // BTN_TelaPrincipalShortCuts
            // 
            BTN_TelaPrincipalShortCuts.Anchor = AnchorStyles.None;
            BTN_TelaPrincipalShortCuts.BackColor = SystemColors.Info;
            BTN_TelaPrincipalShortCuts.BackgroundImageLayout = ImageLayout.None;
            BTN_TelaPrincipalShortCuts.Font = new Font("Copperplate Gothic Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            BTN_TelaPrincipalShortCuts.ForeColor = SystemColors.ControlText;
            BTN_TelaPrincipalShortCuts.ImageAlign = ContentAlignment.BottomLeft;
            BTN_TelaPrincipalShortCuts.Location = new Point(4, 219);
            BTN_TelaPrincipalShortCuts.Margin = new Padding(0);
            BTN_TelaPrincipalShortCuts.Name = "BTN_TelaPrincipalShortCuts";
            BTN_TelaPrincipalShortCuts.Size = new Size(127, 24);
            BTN_TelaPrincipalShortCuts.TabIndex = 7;
            BTN_TelaPrincipalShortCuts.Text = "SHORTCUTS";
            BTN_TelaPrincipalShortCuts.TextAlign = ContentAlignment.TopRight;
            BTN_TelaPrincipalShortCuts.UseVisualStyleBackColor = false;
            BTN_TelaPrincipalShortCuts.Click += BTN_TelaPrincipalShortCuts_Click;
            // 
            // TelaInicial
            // 
            AutoScaleDimensions = new SizeF(12F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            BackgroundImage = Properties.Resources.istockphoto_1137028124_612x612;
            ClientSize = new Size(1284, 540);
            Controls.Add(BTN1_SAIR);
            Controls.Add(PNL1_MENU_LOGIN);
            Controls.Add(PNL_LATERAL_LOGIN);
            Font = new Font("Copperplate Gothic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = SystemColors.Info;
            FormBorderStyle = FormBorderStyle.None;
            KeyPreview = true;
            Margin = new Padding(5, 4, 5, 4);
            Name = "TelaInicial";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TELA_LOGIN_INICIAL";
            WindowState = FormWindowState.Maximized;
            Load += TelaInicial_Load;
            PNL_LATERAL_LOGIN.ResumeLayout(false);
            PNL1_MENU.ResumeLayout(false);
            PNL1_MENU.PerformLayout();
            panel1.ResumeLayout(false);
            PNL1_MENU_LOGIN.ResumeLayout(false);
            PNL1_MENU_LOGIN.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel PNL_LATERAL_LOGIN;
        private Panel PNL1_MENU;
        private Button BTN1_CADASTRO_CLIENT;
        private Label TEXT_PRIMEI_VEZ;
        private Label TEXT1_FACA_LOGIN;
        private Button BTN1_LOGIN;
        private Button BTN_LOGIN_ADM;
        private Label TEXT1_MENU;
        private Button BTN_MENU;
        private Button BTN1_CLIENTES;
        private Panel panel1;
        private Panel PNL1_MENU_LOGIN;
        private Button BTN1_SAIR;
        private Button BtnConfiguracoes;
        private Button BTN_TelaPrincipalShortCuts;
    }
}