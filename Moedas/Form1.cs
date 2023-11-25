using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Moedas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Pega o valor do campo de texto
            //decimal valorEntrada = Convert.ToDecimal(txtValorEntrada.Text);

            // Pega o valor do item selecionado
            //string moeda = cmbMoeda.SelectedItem.TosString();

            //decimal resultado = 0;

            //if (moeda == "Real")
            //{
            //    resultado = valorEntrada / 0.20m;
            //}

            //else if (moeda == "Euro")
            //{
            //    resultado = valorEntrada / 1.06m;
            //}

            //lblValorConvertido.Text = resultado.ToString();

        }
    }
}
