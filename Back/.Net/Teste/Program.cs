using System;
using System.IO;

namespace Teste
{
    class Program
    {
        public static void Main(string[] args)
        {
            int idade = 25;
            int maiorIdade = 18;      
            int idadeLimit = 70;     
          
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
