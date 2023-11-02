using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioDois
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                Crie um programa para converter a temperatura de Celsius para Fahrenheit 
                ou vice versa. O programa deve mostrar a temperatura convertida.

            */

            // Define as variáveis
            decimal celsius;
            decimal fahrenheit;
            decimal resposta;
            decimal resultado;

            Console.WriteLine("CONVERSOR DE TEMPERATURA APP 3000");

            Console.Write("Sua conversão é de 1 - Celsius para Fahrenheit " +
                "ou 2 - Fahrenheit para Celsius: ");
            resposta = Convert.ToDecimal(Console.ReadLine());

            if (resposta == 1)
            {
                Console.Write("Informe a temperatura em celsius: ");
                celsius = Convert.ToDecimal(Console.ReadLine());
                resultado = (celsius * 1.8m + 32);
                Console.WriteLine(celsius + "º celsius em fahrenheit é: " + resultado + ".");
            }
            if (resposta == 2)
            {
                Console.Write("Informe a temperatura em fahrenheit: ");
                fahrenheit = Convert.ToDecimal(Console.ReadLine());
                resultado = (fahrenheit - 32) / 1.8m;
                Console.WriteLine(fahrenheit + "º fahrenheit em celsius é: " + resultado + ".");
            }
            else
            {
                Console.WriteLine("Resposta não é válida.");
            }


            Console.ReadKey();
        }
    
    }
}
