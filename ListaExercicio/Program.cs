using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExercicio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                Crie um programa que solicite o ano de nascimento de uma pessoa, 
                calcule e mostre sua idade atual. Em seguida mostre se a pessoa é 
                maior ou menos de idade.

            */

            // Define as variáveis
            decimal ano;
            decimal ano_atual;

            Console.WriteLine("CONVERSOR DE TEMPERATURA APP 3000");

            Console.Write("Informe o seu ano de nascimento: ");
            ano = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Informe o ano atual: ");
            ano_atual = Convert.ToDecimal(Console.ReadLine());

            decimal idade = ano_atual - ano;

            if (idade >= 18)
                Console.WriteLine("Sua idade é " + idade + ", você é maior de idade.");
            else
                Console.WriteLine("Sua idade é " + idade + ", você é menor de idade");


            Console.ReadKey();
        }
    
    }
}
