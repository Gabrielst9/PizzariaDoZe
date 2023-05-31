namespace PizzariaDoZe
{
    partial class CadastroIngredientes
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
            BtnListaIngredientes = new Button();
            crud1 = new CRUD();
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
            Pnl_11_Ingredientes.Controls.Add(BtnListaIngredientes);
            Pnl_11_Ingredientes.Controls.Add(crud1);
            Pnl_11_Ingredientes.Controls.Add(ING_NOME_TEXT);
            Pnl_11_Ingredientes.Controls.Add(ING_NOME);
            Pnl_11_Ingredientes.Location = new Point(237, 88);
            Pnl_11_Ingredientes.Name = "Pnl_11_Ingredientes";
            Pnl_11_Ingredientes.Size = new Size(458, 301);
            Pnl_11_Ingredientes.TabIndex = 27;
            // 
            // BtnListaIngredientes
            // 
            BtnListaIngredientes.BackgroundImage = Properties.Resources.Screenshot_1;
            BtnListaIngredientes.BackgroundImageLayout = ImageLayout.Stretch;
            BtnListaIngredientes.Font = new Font("Copperplate Gothic Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            BtnListaIngredientes.ForeColor = SystemColors.Info;
            BtnListaIngredientes.Location = new Point(165, 148);
            BtnListaIngredientes.Name = "BtnListaIngredientes";
            BtnListaIngredientes.Size = new Size(117, 45);
            BtnListaIngredientes.TabIndex = 29;
            BtnListaIngredientes.Text = "Listar Ingredientes";
            BtnListaIngredientes.UseVisualStyleBackColor = true;
            BtnListaIngredientes.Click += BtnListaIngredientes_Click;
            // 
            // crud1
            // 
            crud1.BackColor = SystemColors.Desktop;
            crud1.ForeColor = SystemColors.Info;
            crud1.Location = new Point(3, 233);
            crud1.Name = "crud1";
            crud1.Size = new Size(452, 65);
            crud1.TabIndex = 2;
            // 
            // ING_NOME_TEXT
            // 
            ING_NOME_TEXT.Location = new Point(130, 66);
            ING_NOME_TEXT.MaxLength = 80;
            ING_NOME_TEXT.Name = "ING_NOME_TEXT";
            ING_NOME_TEXT.Size = new Size(188, 23);
            ING_NOME_TEXT.TabIndex = 0;
            // 
            // ING_NOME
            // 
            ING_NOME.Anchor = AnchorStyles.None;
            ING_NOME.AutoSize = true;
            ING_NOME.BackColor = Color.Transparent;
            ING_NOME.Font = new Font("Copperplate Gothic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ING_NOME.ForeColor = SystemColors.Info;
            ING_NOME.Location = new Point(195, 45);
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
            Btn_11_Sair.TabIndex = 3;
            Btn_11_Sair.Text = "SAIR";
            Btn_11_Sair.UseVisualStyleBackColor = false;
            Btn_11_Sair.Click += Btn_11_Sair_Click;
            // 
            // CadastroIngredientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.istockphoto_1137028124_612x612;
            ClientSize = new Size(932, 478);
            Controls.Add(Btn_11_Sair);
            Controls.Add(Tit_11_Ingredientes);
            Controls.Add(Pnl_11_Ingredientes);
            FormBorderStyle = FormBorderStyle.None;
            KeyPreview = true;
            Name = "CadastroIngredientes";
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
        private TextBox ING_NOME_TEXT;
        private Label ING_NOME;
        private CRUD crud1;
        private Label Tit_11_Ingredientes;
        private Button Btn_11_Sair;
        private DataGridView dataGridViewDados;
        private Button BtnListaIngredientes;
    }
}