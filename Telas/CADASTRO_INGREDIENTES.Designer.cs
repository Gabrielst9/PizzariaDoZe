namespace PizzariaDoZe
{
    partial class CADASTRO_INGREDIENTES
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
            Pnl_11_Ingredientes = new Panel();
            crud1 = new CRUD();
            ING_ID_TEXT = new TextBox();
            ING_ID = new Label();
            ING_NOME_TEXT = new TextBox();
            ING_NOME = new Label();
            Tit_11_Ingredientes = new Label();
            Btn_11_Sair = new Button();
            Pnl_11_Ingredientes.SuspendLayout();
            SuspendLayout();
            // 
            // Pnl_11_Ingredientes
            // 
            Pnl_11_Ingredientes.Anchor = AnchorStyles.None;
            Pnl_11_Ingredientes.BackgroundImage = Properties.Resources.Screenshot_1;
            Pnl_11_Ingredientes.BackgroundImageLayout = ImageLayout.Stretch;
            Pnl_11_Ingredientes.Controls.Add(crud1);
            Pnl_11_Ingredientes.Controls.Add(ING_ID_TEXT);
            Pnl_11_Ingredientes.Controls.Add(ING_ID);
            Pnl_11_Ingredientes.Controls.Add(ING_NOME_TEXT);
            Pnl_11_Ingredientes.Controls.Add(ING_NOME);
            Pnl_11_Ingredientes.Location = new Point(209, 91);
            Pnl_11_Ingredientes.Name = "Pnl_11_Ingredientes";
            Pnl_11_Ingredientes.Size = new Size(514, 301);
            Pnl_11_Ingredientes.TabIndex = 27;
            // 
            // crud1
            // 
            crud1.BackColor = SystemColors.Desktop;
            crud1.ForeColor = SystemColors.Info;
            crud1.Location = new Point(31, 224);
            crud1.Name = "crud1";
            crud1.Size = new Size(452, 65);
            crud1.TabIndex = 30;
            // 
            // ING_ID_TEXT
            // 
            ING_ID_TEXT.Location = new Point(163, 150);
            ING_ID_TEXT.Name = "ING_ID_TEXT";
            ING_ID_TEXT.Size = new Size(188, 23);
            ING_ID_TEXT.TabIndex = 29;
            // 
            // ING_ID
            // 
            ING_ID.Anchor = AnchorStyles.None;
            ING_ID.AutoSize = true;
            ING_ID.BackColor = Color.Transparent;
            ING_ID.Font = new Font("Copperplate Gothic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ING_ID.ForeColor = SystemColors.Info;
            ING_ID.Location = new Point(245, 129);
            ING_ID.Name = "ING_ID";
            ING_ID.Size = new Size(26, 18);
            ING_ID.TabIndex = 28;
            ING_ID.Text = "ID";
            ING_ID.TextAlign = ContentAlignment.TopCenter;
            // 
            // ING_NOME_TEXT
            // 
            ING_NOME_TEXT.Location = new Point(163, 66);
            ING_NOME_TEXT.Name = "ING_NOME_TEXT";
            ING_NOME_TEXT.Size = new Size(188, 23);
            ING_NOME_TEXT.TabIndex = 27;
            // 
            // ING_NOME
            // 
            ING_NOME.Anchor = AnchorStyles.None;
            ING_NOME.AutoSize = true;
            ING_NOME.BackColor = Color.Transparent;
            ING_NOME.Font = new Font("Copperplate Gothic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ING_NOME.ForeColor = SystemColors.Info;
            ING_NOME.Location = new Point(223, 45);
            ING_NOME.Name = "ING_NOME";
            ING_NOME.Size = new Size(63, 18);
            ING_NOME.TabIndex = 26;
            ING_NOME.Text = "NOME";
            ING_NOME.TextAlign = ContentAlignment.TopCenter;
            // 
            // Tit_11_Ingredientes
            // 
            Tit_11_Ingredientes.Anchor = AnchorStyles.None;
            Tit_11_Ingredientes.AutoSize = true;
            Tit_11_Ingredientes.BackColor = SystemColors.ActiveCaptionText;
            Tit_11_Ingredientes.BorderStyle = BorderStyle.Fixed3D;
            Tit_11_Ingredientes.Font = new Font("Copperplate Gothic Bold", 36F, FontStyle.Regular, GraphicsUnit.Point);
            Tit_11_Ingredientes.ForeColor = SystemColors.Info;
            Tit_11_Ingredientes.Image = Properties.Resources.Screenshot_1;
            Tit_11_Ingredientes.Location = new Point(48, 7);
            Tit_11_Ingredientes.Name = "Tit_11_Ingredientes";
            Tit_11_Ingredientes.Size = new Size(841, 55);
            Tit_11_Ingredientes.TabIndex = 28;
            Tit_11_Ingredientes.Text = "CADASTRO DE INGREDIENTES";
            Tit_11_Ingredientes.TextAlign = ContentAlignment.TopCenter;
            // 
            // Btn_11_Sair
            // 
            Btn_11_Sair.Anchor = AnchorStyles.None;
            Btn_11_Sair.BackColor = SystemColors.HotTrack;
            Btn_11_Sair.BackgroundImage = Properties.Resources.Screenshot_1;
            Btn_11_Sair.BackgroundImageLayout = ImageLayout.Stretch;
            Btn_11_Sair.Cursor = Cursors.Hand;
            Btn_11_Sair.FlatStyle = FlatStyle.Flat;
            Btn_11_Sair.Font = new Font("Copperplate Gothic Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            Btn_11_Sair.ForeColor = SystemColors.Info;
            Btn_11_Sair.Location = new Point(352, 421);
            Btn_11_Sair.Margin = new Padding(4, 3, 4, 3);
            Btn_11_Sair.Name = "Btn_11_Sair";
            Btn_11_Sair.Size = new Size(229, 32);
            Btn_11_Sair.TabIndex = 29;
            Btn_11_Sair.Text = "SAIR";
            Btn_11_Sair.UseVisualStyleBackColor = false;
            Btn_11_Sair.Click += Btn_11_Sair_Click;
            // 
            // CADASTRO_INGREDIENTES
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.istockphoto_1137028124_612x612;
            ClientSize = new Size(932, 478);
            Controls.Add(Btn_11_Sair);
            Controls.Add(Tit_11_Ingredientes);
            Controls.Add(Pnl_11_Ingredientes);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CADASTRO_INGREDIENTES";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CADASTRO_INGREDIENTES";
            WindowState = FormWindowState.Maximized;
            Pnl_11_Ingredientes.ResumeLayout(false);
            Pnl_11_Ingredientes.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel Pnl_11_Ingredientes;
        private TextBox ING_ID_TEXT;
        private Label ING_ID;
        private TextBox ING_NOME_TEXT;
        private Label ING_NOME;
        private CRUD crud1;
        private Label Tit_11_Ingredientes;
        private Button Btn_11_Sair;
    }
}