using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzariaDoZe.Telas
{
    public partial class TelaShortCuts : Form
    {
        public TelaShortCuts()
        {
            InitializeComponent();
            //shift para abrir tela
            this.KeyDown += new KeyEventHandler(Funcoes.ShiftF1AbrirTelaInicial!);
            this.KeyDown += new KeyEventHandler(Funcoes.ShiftF2AbrirTelaFuncionarios!);
            this.KeyDown += new KeyEventHandler(Funcoes.ShiftF3AbrirTelaClientes!);
            this.KeyDown += new KeyEventHandler(Funcoes.ShiftF4AbrirTelaIngredientes!);
            this.KeyDown += new KeyEventHandler(Funcoes.ShiftF5AbrirTelaSabor!);
            this.KeyDown += new KeyEventHandler(Funcoes.ShiftF6abrirTelaValor!);
            this.KeyDown += new KeyEventHandler(Funcoes.ShiftF7AbrirTelaProduto!);
            this.KeyDown += new KeyEventHandler(Funcoes.ShiftF8AbrirConfiguracoes!);
            //Shift delete pra Sair
            this.KeyDown += new KeyEventHandler(Funcoes.ShiftDeleteSair!);
        }
    }
}
