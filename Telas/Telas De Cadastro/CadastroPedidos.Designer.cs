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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroPedidos));
            TextCadastroPedido = new Label();
            tabControlPedidos = new TabControl();
            tabPageCliente = new TabPage();
            crud1 = new CRUD();
            userControlEndereco1 = new userControlEndereco();
            button1 = new Button();
            label4 = new Label();
            textBox3 = new TextBox();
            label3 = new Label();
            textBox2 = new TextBox();
            label2 = new Label();
            textBox1 = new TextBox();
            TextNome = new Label();
            tabPagePedido = new TabPage();
            tabControlPedidos.SuspendLayout();
            tabPageCliente.SuspendLayout();
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
            TextCadastroPedido.Location = new Point(189, 52);
            TextCadastroPedido.Name = "TextCadastroPedido";
            TextCadastroPedido.Size = new Size(675, 55);
            TextCadastroPedido.TabIndex = 16;
            TextCadastroPedido.Text = "CADASTRO DE PEDIDOS";
            TextCadastroPedido.TextAlign = ContentAlignment.TopCenter;
            // 
            // tabControlPedidos
            // 
            tabControlPedidos.Controls.Add(tabPageCliente);
            tabControlPedidos.Controls.Add(tabPagePedido);
            tabControlPedidos.Location = new Point(189, 87);
            tabControlPedidos.Name = "tabControlPedidos";
            tabControlPedidos.SelectedIndex = 0;
            tabControlPedidos.Size = new Size(675, 508);
            tabControlPedidos.TabIndex = 18;
            // 
            // tabPageCliente
            // 
            tabPageCliente.Controls.Add(crud1);
            tabPageCliente.Controls.Add(userControlEndereco1);
            tabPageCliente.Controls.Add(button1);
            tabPageCliente.Controls.Add(label4);
            tabPageCliente.Controls.Add(textBox3);
            tabPageCliente.Controls.Add(label3);
            tabPageCliente.Controls.Add(textBox2);
            tabPageCliente.Controls.Add(label2);
            tabPageCliente.Controls.Add(textBox1);
            tabPageCliente.Controls.Add(TextNome);
            tabPageCliente.Location = new Point(4, 24);
            tabPageCliente.Name = "tabPageCliente";
            tabPageCliente.Padding = new Padding(3);
            tabPageCliente.Size = new Size(667, 480);
            tabPageCliente.TabIndex = 0;
            tabPageCliente.Text = "Cliente";
            tabPageCliente.UseVisualStyleBackColor = true;
            // 
            // crud1
            // 
            crud1.BackColor = SystemColors.Desktop;
            crud1.ForeColor = SystemColors.Info;
            crud1.Location = new Point(-4, 428);
            crud1.Name = "crud1";
            crud1.Size = new Size(671, 52);
            crud1.TabIndex = 9;
            // 
            // userControlEndereco1
            // 
            userControlEndereco1.BackgroundImage = (Image)resources.GetObject("userControlEndereco1.BackgroundImage");
            userControlEndereco1.BackgroundImageLayout = ImageLayout.Stretch;
            userControlEndereco1.ForeColor = SystemColors.Info;
            userControlEndereco1.Location = new Point(0, 143);
            userControlEndereco1.Name = "userControlEndereco1";
            userControlEndereco1.Size = new Size(667, 283);
            userControlEndereco1.TabIndex = 8;
            // 
            // button1
            // 
            button1.Location = new Point(266, 114);
            button1.Name = "button1";
            button1.Size = new Size(100, 23);
            button1.TabIndex = 7;
            button1.Text = "BUSCAR";
            button1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(252, 3);
            label4.Name = "label4";
            label4.Size = new Size(125, 15);
            label4.TabIndex = 6;
            label4.Text = "SELECIONE O CLIENTE";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(504, 68);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(504, 50);
            label3.Name = "label3";
            label3.Size = new Size(61, 15);
            label3.TabIndex = 4;
            label3.Text = "TELEFONE";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(266, 68);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(266, 50);
            label2.Name = "label2";
            label2.Size = new Size(28, 15);
            label2.TabIndex = 2;
            label2.Text = "CPF";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(25, 68);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 1;
            // 
            // TextNome
            // 
            TextNome.AutoSize = true;
            TextNome.Location = new Point(25, 50);
            TextNome.Name = "TextNome";
            TextNome.Size = new Size(42, 15);
            TextNome.TabIndex = 0;
            TextNome.Text = "NOME";
            // 
            // tabPagePedido
            // 
            tabPagePedido.Location = new Point(4, 24);
            tabPagePedido.Name = "tabPagePedido";
            tabPagePedido.Padding = new Padding(3);
            tabPagePedido.Size = new Size(667, 480);
            tabPagePedido.TabIndex = 1;
            tabPagePedido.Text = "Pedido";
            tabPagePedido.UseVisualStyleBackColor = true;
            // 
            // CadastroPedidos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1054, 595);
            Controls.Add(tabControlPedidos);
            Controls.Add(TextCadastroPedido);
            Name = "CadastroPedidos";
            Text = "CadastroPedidos";
            tabControlPedidos.ResumeLayout(false);
            tabPageCliente.ResumeLayout(false);
            tabPageCliente.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label TextCadastroPedido;
        private TabControl tabControlPedidos;
        private TabPage tabPageCliente;
        private TabPage tabPagePedido;
        private Label label4;
        private TextBox textBox3;
        private Label label3;
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox1;
        private Label TextNome;
        private CRUD crud1;
        private userControlEndereco userControlEndereco1;
        private Button button1;
    }
}