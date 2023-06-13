namespace PizzariaDoZe.Telas.DataGridView_s
{
    partial class ListarSabores
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
            dataGridViewSabores = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSabores).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewSabores
            // 
            dataGridViewSabores.AllowUserToAddRows = false;
            dataGridViewSabores.AllowUserToDeleteRows = false;
            dataGridViewSabores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewSabores.Dock = DockStyle.Fill;
            dataGridViewSabores.Location = new Point(0, 0);
            dataGridViewSabores.Name = "dataGridViewSabores";
            dataGridViewSabores.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewSabores.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewSabores.RowTemplate.Height = 25;
            dataGridViewSabores.Size = new Size(731, 281);
            dataGridViewSabores.TabIndex = 0;
            dataGridViewSabores.CellFormatting += DataGridViewSabores_CellFormatting;
            // 
            // ListarSabores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(731, 281);
            Controls.Add(dataGridViewSabores);
            Name = "ListarSabores";
            Text = "ListarSabores";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)dataGridViewSabores).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewSabores;
    }
}