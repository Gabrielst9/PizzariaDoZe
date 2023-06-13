namespace PizzariaDoZe.Telas.Telas_De_Cadastro
{
    partial class ListarValores
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
            dataGridViewValor = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewValor).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewValor
            // 
            dataGridViewValor.AllowUserToAddRows = false;
            dataGridViewValor.AllowUserToDeleteRows = false;
            dataGridViewValor.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewValor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewValor.Dock = DockStyle.Fill;
            dataGridViewValor.Location = new Point(0, 0);
            dataGridViewValor.Name = "dataGridViewValor";
            dataGridViewValor.RowTemplate.Height = 25;
            dataGridViewValor.Size = new Size(657, 259);
            dataGridViewValor.TabIndex = 0;
            // 
            // ListarValores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(657, 259);
            Controls.Add(dataGridViewValor);
            Name = "ListarValores";
            Text = "ListarValores";
            ((System.ComponentModel.ISupportInitialize)dataGridViewValor).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewValor;
    }
}