using PizzariaDoZe.Compartilhado;
using System.Globalization;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PizzariaDoZe_DAO;

namespace PizzariaDoZe.Telas.Telas_De_Cadastro
{
    public partial class CadastroPedidos : Form
    {
        public CadastroPedidos()
        {
            InitializeComponent();
            this.AtualizaCorLetras();
            this.ColocaImagemForm();
            Funcoes.EventoFocoCampos(this);

        }
    }
}
