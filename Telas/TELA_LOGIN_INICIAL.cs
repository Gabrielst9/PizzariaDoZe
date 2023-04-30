﻿using PizzariaDoZe.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzariaDoZe
{
    public partial class TELA_LOGIN_INICIAL : Form
    {
        bool PNL_LATERAL_EXPANDE;
        public TELA_LOGIN_INICIAL()
        {
            InitializeComponent();
            //adiciona eventos em geral, exemplo: ganhar e perder o foco
            Funcoes.EventoFocoCampos(this);

        }
        /// <summary>
        /// este botão serve para realizar o cadastro de um cliente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BTN1_CADASTRO_CLIENT_Click(object sender, EventArgs e)
        {
            TELA_CLIENTES t1 = new();
            t1.Show();
        }

        private void MENU1_BTN_Click(object sender, EventArgs e)
        {
        }

        private void Button2_Click(object sender, EventArgs e)
        {
        }
        /// <summary>
        /// este botão redireciona para a página de cadastrar administrador
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BTN_LOGIN_ADM_Click(object sender, EventArgs e)
        {
            Form1 t1 = new();
            t1.Show();
        }

        private void PNL1_MENU_Paint(object sender, PaintEventArgs e)
        {
        }
        /// <summary>
        /// botão de voltar padrão
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BTN1_SAIR_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TIMER_PNL_LATERAL_Tick(object sender, EventArgs e)
        {
            //Definindo o Minimo e o Máximo size do Painel Lateral


            if (PNL_LATERAL_EXPANDE)
            {
                //if painel lateral expande, minimiza
                PNL_LATERAL_LOGIN.Width -= 10;
                if (PNL_LATERAL_LOGIN.Width == PNL_LATERAL_LOGIN.MinimumSize.Width)
                {
                    PNL_LATERAL_EXPANDE = false;
                }
                else
                {
                    PNL_LATERAL_LOGIN.Width += 10;
                    if (PNL_LATERAL_LOGIN.Width == PNL_LATERAL_LOGIN.MaximumSize.Width)
                    {
                        PNL_LATERAL_EXPANDE = true;
                    }
                }
            }
        }
        /// <summary>
        /// este botão abre as telas de clientes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BTN1_CLIENTES_Click(object sender, EventArgs e)
        {
            TELA_LOGIN_INICIAL t1 = new();
            t1.Show();
        }
        /// <summary>
        /// este botão serve para o usuário que já tem conta entrar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BTN1_LOGIN_Click(object sender, EventArgs e)
        {
            TELA_INICIAL_CLIENTE t8 = new();
            t8.Show();
        }
        /// <summary>
        /// este botão redireciona para a página de configurações
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnConfiguracoes_Click(object sender, EventArgs e)
        {
            Tela_Configuracoes t20 = new Tela_Configuracoes();
            t20.Show();
        }

        private void PNL_LATERAL_LOGIN_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
