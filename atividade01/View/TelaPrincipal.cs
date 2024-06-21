using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace atividade01.View
{
    public partial class TelaPrincipal : Form
    {
        public TelaPrincipal()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Somar_Click(object sender, EventArgs e)
        {
            int Valor1  = Convert.ToInt16(tbx_Valor1.Text);
            int Valor2  = Convert.ToInt16(tbx_Valor2.Text);
            int soma = Valor1 + Valor2;

            lbl_Display.Text = soma.ToString();

        }
    }
}
