using PizzariaDoZe.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzariaDoZe.Compartilhado
{
    public static class FormExtension
    {
        public static void ColocaImagemForm(this Form form )
        {
            form.BackgroundImage = Resources.istockphoto_1137028124_612x612;
            form.WindowState = FormWindowState.Maximized;
            form.FormBorderStyle = FormBorderStyle.None;
        }
        public static void AtualizaCorLetras(this Form form ) 
        {
            form.ForeColor = SystemColors.Info;
        }

        public static void ConfigurarShortCut(this Form form)
        {

            //shift para abrir tela
            form.KeyDown += new KeyEventHandler(Funcoes.ShiftF1AbrirTelaInicial!);
            form.KeyDown += new KeyEventHandler(Funcoes.ShiftF2AbrirTelaFuncionarios!);
            form.KeyDown += new KeyEventHandler(Funcoes.ShiftF3AbrirTelaClientes!);
            form.KeyDown += new KeyEventHandler(Funcoes.ShiftF4AbrirTelaIngredientes!);
            form.KeyDown += new KeyEventHandler(Funcoes.ShiftF5AbrirTelaSabor!);
            form.KeyDown += new KeyEventHandler(Funcoes.ShiftF6abrirTelaValor!);
            form.KeyDown += new KeyEventHandler(Funcoes.ShiftF7AbrirTelaProduto!);
            form.KeyDown += new KeyEventHandler(Funcoes.ShiftF8AbrirConfiguracoes!);
            //Shift delete pra Sair
            form.KeyDown += new KeyEventHandler(Funcoes.ShiftDeleteSair!);
            form.KeyDown += new KeyEventHandler(Funcoes.FormEventoKeyDownEsc!);
        }
    }
}
