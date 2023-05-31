using Org.BouncyCastle.Asn1.Cmp;
using PizzariaDoZe_DAO.Endereco;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzariaDoZe.Telas
{
    public partial class userControlEndereco : UserControl
    {
        public userControlEndereco()
        {
            InitializeComponent();
        }
        public string IdEndereco
        {
            get
            {
                return TextBoxIdEndereco.Text;
            }
        }

        public string Numero
        {
            get 
            {
                return TextBoxNumero.Text;
            }
        }

        public string Complemento
        {
            get
            {
                return TextBoxComplemento.Text;
            }
        }

        public string Bairro
        {
            get
            {
                return TextBoxBairro.Text;
            }
        }

        public string Cidade
        {
            get 
            { 
                return TextBoxCidade.Text;
            }
        }

        public string Pais
        {
            get 
            { 
                return TextBoxPais.Text; 
            }
        }

        public void maskedTextBoxCep_Leave(object sender, EventArgs e)
        {
            string cep = maskedTextBoxCep.Text.Trim();
        }
    }
}
