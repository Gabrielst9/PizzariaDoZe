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
    public partial class TELA_FUNCIONARIOS : Form
    {
        public TELA_FUNCIONARIOS()
        {
            InitializeComponent();
        }

        private void Btn_Sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn3_Administrador_Click(object sender, EventArgs e)
        {
            TELA_ADM t4 = new();
            t4.Show();
        }

        private void Btn3_Atendente_Click(object sender, EventArgs e)
        {
            TELA_ATENDENTE t4 = new();
            t4.Show();
        }

        private void Btn3_Entregador_Click(object sender, EventArgs e)
        {
            TELA_ENTREGADOR t6 = new();
            t6.Show();
        }
    }
}
