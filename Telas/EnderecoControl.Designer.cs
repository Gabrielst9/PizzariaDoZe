namespace PizzariaDoZe.Telas
{
    partial class EnderecoControl
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            textBox1 = new TextBox();
            TextCep = new Label();
            TextBoxCep = new TextBox();
            TextLogradouro = new Label();
            TextBoxLogradouro = new TextBox();
            TextBairro = new Label();
            TextBoxBairro = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Copperplate Gothic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(26, 18);
            label1.TabIndex = 11;
            label1.Text = "ID";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.None;
            textBox1.BackColor = SystemColors.ButtonHighlight;
            textBox1.Cursor = Cursors.IBeam;
            textBox1.Enabled = false;
            textBox1.Font = new Font("Copperplate Gothic Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.ForeColor = SystemColors.MenuText;
            textBox1.Location = new Point(3, 21);
            textBox1.MaxLength = 80;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(45, 21);
            textBox1.TabIndex = 10;
            // 
            // TextCep
            // 
            TextCep.Anchor = AnchorStyles.None;
            TextCep.AutoSize = true;
            TextCep.BackColor = Color.Transparent;
            TextCep.Font = new Font("Copperplate Gothic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TextCep.Location = new Point(82, 0);
            TextCep.Name = "TextCep";
            TextCep.Size = new Size(45, 18);
            TextCep.TabIndex = 13;
            TextCep.Text = "CEP";
            TextCep.TextAlign = ContentAlignment.TopCenter;
            // 
            // TextBoxCep
            // 
            TextBoxCep.Anchor = AnchorStyles.None;
            TextBoxCep.BackColor = SystemColors.ButtonHighlight;
            TextBoxCep.Cursor = Cursors.IBeam;
            TextBoxCep.Enabled = false;
            TextBoxCep.Font = new Font("Copperplate Gothic Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            TextBoxCep.ForeColor = SystemColors.MenuText;
            TextBoxCep.Location = new Point(82, 21);
            TextBoxCep.MaxLength = 80;
            TextBoxCep.Name = "TextBoxCep";
            TextBoxCep.Size = new Size(104, 21);
            TextBoxCep.TabIndex = 12;
            // 
            // TextLogradouro
            // 
            TextLogradouro.Anchor = AnchorStyles.None;
            TextLogradouro.AutoSize = true;
            TextLogradouro.BackColor = Color.Transparent;
            TextLogradouro.Font = new Font("Copperplate Gothic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TextLogradouro.Location = new Point(3, 63);
            TextLogradouro.Name = "TextLogradouro";
            TextLogradouro.Size = new Size(119, 18);
            TextLogradouro.TabIndex = 15;
            TextLogradouro.Text = "Logradouro";
            TextLogradouro.TextAlign = ContentAlignment.TopCenter;
            // 
            // TextBoxLogradouro
            // 
            TextBoxLogradouro.Anchor = AnchorStyles.None;
            TextBoxLogradouro.BackColor = SystemColors.ButtonHighlight;
            TextBoxLogradouro.Cursor = Cursors.IBeam;
            TextBoxLogradouro.Enabled = false;
            TextBoxLogradouro.Font = new Font("Copperplate Gothic Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            TextBoxLogradouro.ForeColor = SystemColors.MenuText;
            TextBoxLogradouro.Location = new Point(3, 84);
            TextBoxLogradouro.MaxLength = 80;
            TextBoxLogradouro.Name = "TextBoxLogradouro";
            TextBoxLogradouro.Size = new Size(299, 21);
            TextBoxLogradouro.TabIndex = 14;
            // 
            // TextBairro
            // 
            TextBairro.Anchor = AnchorStyles.None;
            TextBairro.AutoSize = true;
            TextBairro.BackColor = Color.Transparent;
            TextBairro.Font = new Font("Copperplate Gothic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TextBairro.Location = new Point(3, 108);
            TextBairro.Name = "TextBairro";
            TextBairro.Size = new Size(70, 18);
            TextBairro.TabIndex = 17;
            TextBairro.Text = "Bairro";
            TextBairro.TextAlign = ContentAlignment.TopCenter;
            // 
            // TextBoxBairro
            // 
            TextBoxBairro.Anchor = AnchorStyles.None;
            TextBoxBairro.BackColor = SystemColors.ButtonHighlight;
            TextBoxBairro.Cursor = Cursors.IBeam;
            TextBoxBairro.Enabled = false;
            TextBoxBairro.Font = new Font("Copperplate Gothic Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            TextBoxBairro.ForeColor = SystemColors.MenuText;
            TextBoxBairro.Location = new Point(3, 129);
            TextBoxBairro.MaxLength = 80;
            TextBoxBairro.Name = "TextBoxBairro";
            TextBoxBairro.Size = new Size(299, 21);
            TextBoxBairro.TabIndex = 16;
            // 
            // EnderecoControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(TextBairro);
            Controls.Add(TextBoxBairro);
            Controls.Add(TextLogradouro);
            Controls.Add(TextBoxLogradouro);
            Controls.Add(TextCep);
            Controls.Add(TextBoxCep);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Name = "EnderecoControl";
            Size = new Size(441, 283);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Label TextCep;
        private TextBox TextBoxCep;
        private Label TextLogradouro;
        private TextBox TextBoxLogradouro;
        private Label TextBairro;
        private TextBox TextBoxBairro;
    }
}
