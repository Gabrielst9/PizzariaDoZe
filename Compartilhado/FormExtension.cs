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
        }
        public static void AtualizaCorLetras(this Form form ) 
        {
            form.ForeColor = SystemColors.Info;
        }
    }
}
