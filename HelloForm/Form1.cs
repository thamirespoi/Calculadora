using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBoxButtons caixa = new MessageBoxButtons();

            // Cria uma váriavel do tipo Form2 e instancia um objeto Form2
            Form3 formulario3 = new Form3();

            // Esconde a tela principal
            this.Hide();

            // Chama a função que mostra o formulário
            formulario3.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MessageBoxButtons caixa = new MessageBoxButtons();

            // Cria uma váriavel do tipo Form2 e instancia um objeto Form2
            Form2 formulario2 = new Form2();

            // Esconde a tela principal
            this.Hide();

            // Chama a função que mostra o formulário
            formulario2.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBoxButtons caixa = new MessageBoxButtons();

            // Cria uma váriavel do tipo Form2 e instancia um objeto Form2
            Form7 formulario7 = new Form7();

            // Esconde a tela principal
            this.Hide();

            // Chama a função que mostra o formulário
            formulario7.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBoxButtons caixa = new MessageBoxButtons();

            // Cria uma váriavel do tipo Form2 e instancia um objeto Form2
            Form4 formulario4 = new Form4();

            // Esconde a tela principal
            this.Hide();

            // Chama a função que mostra o formulário
            formulario4.ShowDialog();
        }
    }
}
