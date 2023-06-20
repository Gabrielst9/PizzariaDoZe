using PizzariaDoZe.Telas.Telas_De_Cadastro;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzariaDoZe
{
    public partial class TelaInicialClientes : Form
    {
        public TelaInicialClientes()
        {
            InitializeComponent();

            this.ConfigurarShortCut();
        }

        private void BTN8_SAIR_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BTN8_FAZER_PEDIDO_Click(object sender, EventArgs e)
        {
            CadastroPedidos cp = new CadastroPedidos();
            cp.Show();
        }
    }
}
