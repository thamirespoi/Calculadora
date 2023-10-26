using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                \Crie um programa que solicite 4 numeros e ao final mostre a média dos números.
            */

            // Define as variáveis
            decimal numero_um;
            decimal numero_dois;
            decimal numero_tres;
            decimal numero_quatro;

            Console.WriteLine("MEDIA APP 3000");

            Console.Write("Informe o primeiro numero: ");
            numero_um = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Informe o segundo numero: ");
            numero_dois = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Informe o terceiro numero: ");
            numero_tres = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Informe o quarto numero: ");
            numero_quatro = Convert.ToDecimal(Console.ReadLine());

            decimal resultado_media = (numero_um + numero_dois + numero_tres 
                + numero_quatro) / 4;

            Console.WriteLine(
                "A media dos numeros" + numero_um + "+" + numero_dois + "+" + numero_tres + 
                "+" + numero_quatro + "é igual a: " + resultado_media + "."
            );

        }
    }
}
