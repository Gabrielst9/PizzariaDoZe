namespace PizzariaDoZe
{
    partial class TelaInicialClientes
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
            BTN8_FAZER_PEDIDO = new Button();
            Titulo8_Principal = new Label();
            BTN8_SAIR = new Button();
            BTN8_PENDENTES = new Button();
            BTN8_SABORES = new Button();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // BTN8_FAZER_PEDIDO
            // 
            BTN8_FAZER_PEDIDO.BackgroundImage = Properties.Resources.Screenshot_1;
            BTN8_FAZER_PEDIDO.BackgroundImageLayout = ImageLayout.Stretch;
            BTN8_FAZER_PEDIDO.ForeColor = SystemColors.Info;
            BTN8_FAZER_PEDIDO.Location = new Point(4, 30);
            BTN8_FAZER_PEDIDO.Name = "BTN8_FAZER_PEDIDO";
            BTN8_FAZER_PEDIDO.Size = new Size(279, 58);
            BTN8_FAZER_PEDIDO.TabIndex = 0;
            BTN8_FAZER_PEDIDO.Text = "FAZER PEDIDO";
            BTN8_FAZER_PEDIDO.UseVisualStyleBackColor = true;
            // 
            // Titulo8_Principal
            // 
            Titulo8_Principal.Anchor = AnchorStyles.None;
            Titulo8_Principal.AutoSize = true;
            Titulo8_Principal.BackColor = SystemColors.ActiveCaptionText;
            Titulo8_Principal.BorderStyle = BorderStyle.Fixed3D;
            Titulo8_Principal.Font = new Font("Copperplate Gothic Bold", 36F, FontStyle.Regular, GraphicsUnit.Point);
            Titulo8_Principal.ForeColor = SystemColors.Info;
            Titulo8_Principal.Image = Properties.Resources.Screenshot_1;
            Titulo8_Principal.Location = new Point(451, -2);
            Titulo8_Principal.Margin = new Padding(4, 50, 4, 0);
            Titulo8_Principal.Name = "Titulo8_Principal";
            Titulo8_Principal.Size = new Size(454, 55);
            Titulo8_Principal.TabIndex = 2;
            Titulo8_Principal.Text = "PIZZARIA DO ZÉ";
            Titulo8_Principal.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // BTN8_SAIR
            // 
            BTN8_SAIR.Anchor = AnchorStyles.None;
            BTN8_SAIR.BackColor = SystemColors.HotTrack;
            BTN8_SAIR.BackgroundImage = Properties.Resources.Screenshot_1;
            BTN8_SAIR.BackgroundImageLayout = ImageLayout.Stretch;
            BTN8_SAIR.Cursor = Cursors.Hand;
            BTN8_SAIR.FlatStyle = FlatStyle.Flat;
            BTN8_SAIR.Font = new Font("Copperplate Gothic Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            BTN8_SAIR.ForeColor = SystemColors.Info;
            BTN8_SAIR.Location = new Point(571, 439);
            BTN8_SAIR.Margin = new Padding(4, 3, 4, 3);
            BTN8_SAIR.Name = "BTN8_SAIR";
            BTN8_SAIR.Size = new Size(229, 32);
            BTN8_SAIR.TabIndex = 5;
            BTN8_SAIR.Text = "SAIR";
            BTN8_SAIR.UseVisualStyleBackColor = false;
            BTN8_SAIR.Click += BTN8_SAIR_Click;
            // 
            // BTN8_PENDENTES
            // 
            BTN8_PENDENTES.BackgroundImage = Properties.Resources.Screenshot_1;
            BTN8_PENDENTES.BackgroundImageLayout = ImageLayout.Stretch;
            BTN8_PENDENTES.ForeColor = SystemColors.Info;
            BTN8_PENDENTES.Location = new Point(4, 113);
            BTN8_PENDENTES.Name = "BTN8_PENDENTES";
            BTN8_PENDENTES.Size = new Size(279, 58);
            BTN8_PENDENTES.TabIndex = 6;
            BTN8_PENDENTES.Text = "VER PEDIDOS PENDENTES";
            BTN8_PENDENTES.UseVisualStyleBackColor = true;
            // 
            // BTN8_SABORES
            // 
            BTN8_SABORES.BackgroundImage = Properties.Resources.Screenshot_1;
            BTN8_SABORES.BackgroundImageLayout = ImageLayout.Stretch;
            BTN8_SABORES.ForeColor = SystemColors.Info;
            BTN8_SABORES.Location = new Point(4, 189);
            BTN8_SABORES.Name = "BTN8_SABORES";
            BTN8_SABORES.Size = new Size(279, 58);
            BTN8_SABORES.TabIndex = 7;
            BTN8_SABORES.Text = "CATALOGO DE SABORES";
            BTN8_SABORES.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(BTN8_FAZER_PEDIDO);
            panel1.Controls.Add(BTN8_SABORES);
            panel1.Controls.Add(BTN8_PENDENTES);
            panel1.Location = new Point(540, 97);
            panel1.Name = "panel1";
            panel1.Size = new Size(290, 275);
            panel1.TabIndex = 8;
            // 
            // TELA_INICIAL_CLIENTE
            // 
            AutoScaleDimensions = new SizeF(12F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.istockphoto_1137028124_612x612;
            ClientSize = new Size(1370, 540);
            Controls.Add(panel1);
            Controls.Add(Titulo8_Principal);
            Controls.Add(BTN8_SAIR);
            Font = new Font("Copperplate Gothic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = SystemColors.Info;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(5, 4, 5, 4);
            Name = "TELA_INICIAL_CLIENTE";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TELA_INICIAL_CLIENTE";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BTN8_FAZER_PEDIDO;
        private Label Titulo8_Principal;
        private Button BTN8_SAIR;
        private Button BTN8_PENDENTES;
        private Button BTN8_SABORES;
        private Panel panel1;
    }
}