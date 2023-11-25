using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exerciciofor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1 - Escreva 10 nomes de cores 
            // 2 - Escreva quantos produtos vai para produzir cada tinta

            string[] tintas = new string[10];
            int[] qnt_produtos = new int[10];

            for (int indice = 1; indice < 10; indice++)
            {
                Console.Write($"Digite o peso da cor: ");
                tintas[indice] = Console.ReadLine();

                Console.Write($"Digite o peso da cor: ");
                qnt_produtos[indice] = Convert.ToInt64(Console.ReadLine());
            }

        }
    }
}
