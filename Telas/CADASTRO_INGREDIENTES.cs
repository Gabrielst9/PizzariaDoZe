using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PizzariaDoZe.Telas;

namespace PizzariaDoZe
{
    public partial class CADASTRO_INGREDIENTES : Form
    {
        public CADASTRO_INGREDIENTES()
        {
            InitializeComponent();
        }

        private void VOLTAR_CAD_INGREDIENTES_Click(object sender, EventArgs e)
        {
            this.Close();
            TELA_CADASTROS cad1 = new();
            cad1.Show();

        }

        private void Btn_Salvar_Ingredientes_Click(object sender, EventArgs e)
        {

        }

        private void Btn_11_Sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
