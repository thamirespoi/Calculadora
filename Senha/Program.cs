using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Senha
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
               Crie um programa que peça para que o usuário informe uma senha. 
               Depois de informar a senha o sistema deve validar se a senha tem mais 
               de 8 caracteres, uma letra maiúscula, uma letra minúscula e um número. 
               Informe se é valida ou não.

           */

            // Define as variáveis
            string senha;

            Console.WriteLine("SENHA APP 3000");

            Console.Write("Digite uma senha de 8 digitos, com 1 letra maiúscula, 1 letra" +
                "minúscula e pelo menos 1 número: ");
            senha = Console.ReadLine();

            if (senha.Length != 8)
            {
                Console.WriteLine("Sua senha é inválida, não tem caractere suficiente ou " +
                    "excede o número de caractere");
            }

            if (!senha.Any(c => char.IsDigit(c)))
            {
                Console.WriteLine("Sua senha é inválida, não tem caractere de número");
            }

            if (!senha.Any(c => char.IsUpper(c)))
            {
                Console.WriteLine("Sua senha é inválida, não tem letra maiúscula");
            }

            if (!senha.Any(c => char.IsLower(c)))
            {
                Console.WriteLine("Sua senha é inválida, não tem letra minúscula");
            }

            else
            {
                Console.WriteLine("Sua senha é válida");
            }
        }
    }
}
