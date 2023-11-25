using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lacosrepeticao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*int numero = 0;
            int tabuada = 2;

            while (numero <= 10)
            {
                int resultado = numero * tabuada;
                numero++;
                Console.WriteLine(resultado);            

            }*/

            // Solicita a tabuada para o usuário
            string opcao = "";

            // Repete a tabuada enquanto o usuário não escolher sair
            while(opcao != "0")
            {
                Console.WriteLine("Qual tabuada você deseja?");
                int tabuada = Convert.ToInt32(Console.ReadLine());


                // Repete 10 vezes o bloco de código dentro das chaves
                for (int numero = 0; numero <= 10; numero++)
                {
                    Console.WriteLine("2 x " + numero + " = " + numero * 2);
                }
            }
 
        }
    }
}
