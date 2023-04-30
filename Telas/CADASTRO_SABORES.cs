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
    public partial class CADASTRO_SABORES : Form
    {
        public CADASTRO_SABORES()
        {
            InitializeComponent();
        }

        private void SAIR_SABORES_Btn_Click(object sender, EventArgs e)
        {
            this.Close();
            TELA_CADASTROS cad1 = new();
            cad1.Show();

        }

        private void ING_NOME_TEXT_TextChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Btn_8_Sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
