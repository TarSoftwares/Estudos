using System;
using System.IO;

namespace Teste
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade = 0;
            int maiorIdade = 18;
            int idadeLimit = 65;
            Console.WriteLine("Entre com a Idade");
            idade = int.Parse(Console.ReadLine());
            
            if (idade >= maiorIdade && idade <= idadeLimit)
            {
                Console.WriteLine($"Você tem {idade} anos de idade. Pode ser convocado para a Guerra! ");
            }
            else
            {
                Console.WriteLine($"Você tem {idade} de idade. Não Pode ser convocado para a Guerra! ");

            }
        }
    }
}
