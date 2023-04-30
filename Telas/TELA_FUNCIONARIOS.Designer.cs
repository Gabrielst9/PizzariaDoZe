namespace PizzariaDoZe
{
    partial class TELA_FUNCIONARIOS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TELA_FUNCIONARIOS));
            Btn3_Voltar = new Button();
            Btn3_Administrador = new Button();
            Btn3_Atendente = new Button();
            Btn3_Entregador = new Button();
            TIT_GRUPOS = new Label();
            SuspendLayout();
            // 
            // Btn3_Voltar
            // 
            resources.ApplyResources(Btn3_Voltar, "Btn3_Voltar");
            Btn3_Voltar.BackColor = SystemColors.ControlDarkDark;
            Btn3_Voltar.BackgroundImage = Properties.Resources.Screenshot_1;
            Btn3_Voltar.Cursor = Cursors.Hand;
            Btn3_Voltar.ForeColor = SystemColors.Info;
            Btn3_Voltar.Name = "Btn3_Voltar";
            Btn3_Voltar.UseVisualStyleBackColor = false;
            Btn3_Voltar.Click += Btn_Sair_Click;
            // 
            // Btn3_Administrador
            // 
            resources.ApplyResources(Btn3_Administrador, "Btn3_Administrador");
            Btn3_Administrador.BackColor = SystemColors.ControlDarkDark;
            Btn3_Administrador.BackgroundImage = Properties.Resources.Screenshot_1;
            Btn3_Administrador.Cursor = Cursors.Hand;
            Btn3_Administrador.ForeColor = SystemColors.Info;
            Btn3_Administrador.Name = "Btn3_Administrador";
            Btn3_Administrador.UseVisualStyleBackColor = false;
            Btn3_Administrador.Click += Btn3_Administrador_Click;
            // 
            // Btn3_Atendente
            // 
            resources.ApplyResources(Btn3_Atendente, "Btn3_Atendente");
            Btn3_Atendente.BackColor = SystemColors.ControlDarkDark;
            Btn3_Atendente.BackgroundImage = Properties.Resources.Screenshot_1;
            Btn3_Atendente.Cursor = Cursors.Hand;
            Btn3_Atendente.ForeColor = SystemColors.Info;
            Btn3_Atendente.Name = "Btn3_Atendente";
            Btn3_Atendente.UseVisualStyleBackColor = false;
            Btn3_Atendente.Click += Btn3_Atendente_Click;
            // 
            // Btn3_Entregador
            // 
            resources.ApplyResources(Btn3_Entregador, "Btn3_Entregador");
            Btn3_Entregador.BackColor = SystemColors.ControlDarkDark;
            Btn3_Entregador.BackgroundImage = Properties.Resources.Screenshot_1;
            Btn3_Entregador.Cursor = Cursors.Hand;
            Btn3_Entregador.ForeColor = SystemColors.Info;
            Btn3_Entregador.Name = "Btn3_Entregador";
            Btn3_Entregador.UseVisualStyleBackColor = false;
            Btn3_Entregador.Click += Btn3_Entregador_Click;
            // 
            // TIT_GRUPOS
            // 
            resources.ApplyResources(TIT_GRUPOS, "TIT_GRUPOS");
            TIT_GRUPOS.BackColor = Color.Black;
            TIT_GRUPOS.BorderStyle = BorderStyle.Fixed3D;
            TIT_GRUPOS.ForeColor = SystemColors.Info;
            TIT_GRUPOS.Image = Properties.Resources.Screenshot_1;
            TIT_GRUPOS.Name = "TIT_GRUPOS";
            // 
            // TELA_FUNCIONARIOS
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.istockphoto_1137028124_612x612;
            Controls.Add(TIT_GRUPOS);
            Controls.Add(Btn3_Entregador);
            Controls.Add(Btn3_Atendente);
            Controls.Add(Btn3_Administrador);
            Controls.Add(Btn3_Voltar);
            ForeColor = SystemColors.Info;
            FormBorderStyle = FormBorderStyle.None;
            Name = "TELA_FUNCIONARIOS";
            WindowState = FormWindowState.Maximized;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Btn3_Voltar;
        private Button Btn3_Administrador;
        private Button Btn3_Atendente;
        private Button Btn3_Entregador;
        private Label TIT_GRUPOS;
    }
}