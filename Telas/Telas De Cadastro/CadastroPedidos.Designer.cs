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
            TextCadastroPedido.Location = new Point(189, 9);
            TextCadastroPedido.Name = "TextCadastroPedido";
            TextCadastroPedido.Size = new Size(675, 55);
            TextCadastroPedido.TabIndex = 16;
            TextCadastroPedido.Text = "CADASTRO DE PEDIDOS";
            TextCadastroPedido.TextAlign = ContentAlignment.TopCenter;
            // 
            // CadastroPedidos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1054, 508);
            Controls.Add(TextCadastroPedido);
            Name = "CadastroPedidos";
            Text = "CadastroPedidos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label TextCadastroPedido;
    }
}