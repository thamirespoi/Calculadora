using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraPeso
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
                Crie um programa que solicite o nome, idade, sexo, peso e altura. Ao final 
                utilize a fórmula "peso / altura * altura" para mostrar o IMC da pessoa

            */

            // Define as variáveis
            string nome;
            decimal idade;
            string sexo;
            decimal peso;
            decimal altura;

            Console.WriteLine("CALCULADORA DE PESO APP 3000");

            Console.Write("Informe seu nome: ");
            nome = Console.ReadLine();

            Console.Write("Informe sua idade: ");
            idade = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Informe seu sexo: ");
            sexo = Console.ReadLine();

            Console.Write("Informe sua peso: ");
            peso = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Informe sua altura: ");
            altura = Convert.ToDecimal(Console.ReadLine());
             
            decimal imc = peso / (altura * altura);

            Console.WriteLine(
                nome + ", sua idade é " + idade + ", seu genêro é " + sexo + ", seu peso é " 
                + peso + " e sua altura é " + altura + ", fazendo sua média de IMC ser "
                + imc + "."
            );
        }
    }
}
