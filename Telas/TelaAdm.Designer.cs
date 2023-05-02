namespace PizzariaDoZe
{
    partial class TelaAdm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Titulo_Principal = new Label();
            BTN_PEDIDOS = new Button();
            Btn20_Sair = new Button();
            BTN_CADASTRAR = new Button();
            SuspendLayout();
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
            Titulo_Principal.Location = new Point(252, 25);
            Titulo_Principal.Margin = new Padding(4, 50, 4, 0);
            Titulo_Principal.Name = "Titulo_Principal";
            Titulo_Principal.Size = new Size(454, 55);
            Titulo_Principal.TabIndex = 1;
            Titulo_Principal.Text = "PIZZARIA DO ZÉ";
            Titulo_Principal.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // BTN_PEDIDOS
            // 
            BTN_PEDIDOS.Anchor = AnchorStyles.None;
            BTN_PEDIDOS.AutoSize = true;
            BTN_PEDIDOS.BackColor = SystemColors.ControlDarkDark;
            BTN_PEDIDOS.BackgroundImage = Properties.Resources.Screenshot_1;
            BTN_PEDIDOS.BackgroundImageLayout = ImageLayout.Stretch;
            BTN_PEDIDOS.Cursor = Cursors.Hand;
            BTN_PEDIDOS.FlatStyle = FlatStyle.Flat;
            BTN_PEDIDOS.Font = new Font("Copperplate Gothic Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            BTN_PEDIDOS.ForeColor = SystemColors.Info;
            BTN_PEDIDOS.Location = new Point(297, 165);
            BTN_PEDIDOS.Margin = new Padding(4, 3, 4, 3);
            BTN_PEDIDOS.Name = "BTN_PEDIDOS";
            BTN_PEDIDOS.Size = new Size(365, 54);
            BTN_PEDIDOS.TabIndex = 3;
            BTN_PEDIDOS.Text = "PEDIDOS";
            BTN_PEDIDOS.UseVisualStyleBackColor = false;
            BTN_PEDIDOS.Click += BTN_PEDIDOS_Click;
            // 
            // Btn20_Sair
            // 
            Btn20_Sair.Anchor = AnchorStyles.None;
            Btn20_Sair.BackColor = SystemColors.HotTrack;
            Btn20_Sair.BackgroundImage = Properties.Resources.Screenshot_1;
            Btn20_Sair.BackgroundImageLayout = ImageLayout.Stretch;
            Btn20_Sair.Cursor = Cursors.Hand;
            Btn20_Sair.FlatStyle = FlatStyle.Flat;
            Btn20_Sair.Font = new Font("Copperplate Gothic Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            Btn20_Sair.ForeColor = SystemColors.Info;
            Btn20_Sair.Location = new Point(367, 455);
            Btn20_Sair.Margin = new Padding(4, 3, 4, 3);
            Btn20_Sair.Name = "Btn20_Sair";
            Btn20_Sair.Size = new Size(229, 32);
            Btn20_Sair.TabIndex = 4;
            Btn20_Sair.Text = "SAIR";
            Btn20_Sair.UseVisualStyleBackColor = false;
            Btn20_Sair.Click += Btn20_Sair_Click;
            // 
            // BTN_CADASTRAR
            // 
            BTN_CADASTRAR.Anchor = AnchorStyles.None;
            BTN_CADASTRAR.AutoSize = true;
            BTN_CADASTRAR.BackColor = SystemColors.ControlDarkDark;
            BTN_CADASTRAR.BackgroundImage = Properties.Resources.Screenshot_1;
            BTN_CADASTRAR.BackgroundImageLayout = ImageLayout.Stretch;
            BTN_CADASTRAR.Cursor = Cursors.Hand;
            BTN_CADASTRAR.FlatStyle = FlatStyle.Flat;
            BTN_CADASTRAR.Font = new Font("Copperplate Gothic Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            BTN_CADASTRAR.ForeColor = SystemColors.Info;
            BTN_CADASTRAR.Location = new Point(297, 260);
            BTN_CADASTRAR.Margin = new Padding(4, 3, 4, 3);
            BTN_CADASTRAR.Name = "BTN_CADASTRAR";
            BTN_CADASTRAR.Size = new Size(365, 54);
            BTN_CADASTRAR.TabIndex = 5;
            BTN_CADASTRAR.Text = "CADASTRAR";
            BTN_CADASTRAR.UseVisualStyleBackColor = false;
            BTN_CADASTRAR.Click += BTN_CADASTRAR_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackgroundImage = Properties.Resources.istockphoto_1137028124_612x612;
            ClientSize = new Size(959, 521);
            Controls.Add(BTN_CADASTRAR);
            Controls.Add(Btn20_Sair);
            Controls.Add(BTN_PEDIDOS);
            Controls.Add(Titulo_Principal);
            Font = new Font("Copperplate Gothic Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Principal";
            WindowState = FormWindowState.Maximized;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label Titulo_Principal;
        private Button BTN_PEDIDOS;
        private Button Btn20_Sair;
        private Button BTN_CADASTRAR;
    }
}