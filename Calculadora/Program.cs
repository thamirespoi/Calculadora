using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                Criar um script que solicite 2 numeros ao usuário e ao final mostre
                a soma dos valores.
            */

            // Define as variáveis
            decimal numero_um;
            decimal numero_dois;
            

            Console.WriteLine("SOMA APP 3000");

            Console.Write("Informe o primeiro numero: ");
            numero_um = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Informe o segundo numero: ");
            numero_dois = Convert.ToDecimal(Console.ReadLine());

            decimal soma = numero_um + numero_dois;
            decimal subtracao = numero_um - numero_dois;
            decimal multiplicao = numero_um * numero_dois;
            decimal divisao = numero_um / numero_dois;

            Console.WriteLine(
                "Apatir do " + numero_um + " e " + numero_dois + ", o resultado da soma é: " 
                + soma + ", o resultado da divisão é: " + subtracao + ", o resultado da " +
                "multiplicação é: " + multiplicao + " e o resultado da divisão é: " + divisao +
                "."

            );

            Console.ReadKey();
        }
    }
}
