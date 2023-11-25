using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace petshop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
               O Petshop LalaDog precisa de um sistema para ajudar nos cuidados dos pets.

               O sistema deve ter 3 opções em um menu.

               - Calculo medicação: O usuário informa o peso do pet e a dose por quilo do 
               medicamento, ao final o sistema mostra a dose correta.

               - Agendamento de Banho: O usuário informa o porte do pet. O sistema também 
               pergunta se deve ser adicionado cuidados extras (tirar parasitas, aparar pelos, 
               shampoo premium) em que cada um tem um valor adicional de R$ 20. Ao final o 
               sistema mostra o valor total do banho.   
               Pequeno - R$ 80; Médio - R$ 100; Grande - R$ 120

               - Cálculo de Alimentação: O usuário informa a quantidade de pets que possui 
               e a quantidade de ração disponível. O sistema calcula a quantidade de ração 
               diária necessária para todos os pets com base em 100g por pet e verifica se a 
               quantidade disponível é suficiente para alimentá-los por um determinado período 
               (por exemplo, 30 dias). O sistema exibe uma mensagem indicando se a ração é 
               suficiente ou se é necessário comprar mais.
           */

            // Nome do petshop
            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine("+++++++++++     PETSHOP LalaDOG     +++++++++++");
            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++");

            // Variavel para opção do menu
            int opcao = 0;

            // Define as variáveis
            string menu;
            string nome_pet;
            decimal peso;
            decimal medicamento;
            decimal valor;

            Console.WriteLine("+++++++++++++++++    MENU    +++++++++++++++++");
            Console.Write("1 - Cálculo de medicação");
            Console.Write("2 - Cálculo de custo do banho");
            Console.Write("3 - Cálculo de alimentação");
            menu = Console.ReadLine();

            // Agendamento banho de tosa
            if (menu == "1")
            {
                // Cálculo de medicação
                Console.Write("Digite aqui o nome do pet: ");
                nome_pet = Console.ReadLine();

                Console.Write($"Digite o peso do {nome_pet}: ");
                peso = Convert.ToDecimal(Console.ReadLine());

                Console.Write($"Digite a dose do medicamento do {nome_pet}: ");
                medicamento = Convert.ToDecimal(Console.ReadLine());

                Console.Write($"O medicamento é {medicamento}ml/kg");
                Console.Write($"A dose correta do medicamento do {nome_pet} é {peso * medicamento}.");

                // Mostra o menu de opções
            if (menu == "2")
                {
                while (opcao != 0)
                    Console.Write($"");
                    if (peso < 6)
                        valor = 80;
                        

                }
            }
        }
    }
}
