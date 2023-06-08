namespace PizzariaDoZe.Telas.DataGridView_s
{
    partial class ListarFuncionarios
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
            dataGridViewFuncionarios = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFuncionarios).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewFuncionarios
            // 
            dataGridViewFuncionarios.AllowUserToAddRows = false;
            dataGridViewFuncionarios.AllowUserToDeleteRows = false;
            dataGridViewFuncionarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewFuncionarios.Dock = DockStyle.Fill;
            dataGridViewFuncionarios.EnableHeadersVisualStyles = false;
            dataGridViewFuncionarios.Location = new Point(0, 0);
            dataGridViewFuncionarios.Name = "dataGridViewFuncionarios";
            dataGridViewFuncionarios.RowTemplate.Height = 25;
            dataGridViewFuncionarios.Size = new Size(800, 450);
            dataGridViewFuncionarios.TabIndex = 0;
            dataGridViewFuncionarios.CellFormatting += dataGridViewFuncionarios_CellFormatting;
            // 
            // ListarFuncionarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridViewFuncionarios);
            Name = "ListarFuncionarios";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ListarFuncionarios";
            ((System.ComponentModel.ISupportInitialize)dataGridViewFuncionarios).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewFuncionarios;
    }
}