using System;

namespace Teste
{
    class Program
    {
        static void Main(string[] args)
        {            
            int idadeMaxima = 65;
            int maiorIdade  = 18;            
            Console.WriteLine("Entre com o Nome");
            string Nome = Console.ReadLine();
            Console.WriteLine("Entre com a idade Limite");
            int idade = int.Parse(Console.ReadLine());
            if (idade >= maiorIdade)
            {
                Console.WriteLine($"{Nome} é maior de Idade");
            }
            if (idade >= maiorIdade && idade <= idadeMaxima)
            {
                Console.WriteLine($"{Nome} Pode ser convocado para a guerra!");
            }
            else
            {
                Console.WriteLine($"{Nome} Não Pode ser convocado para a guerra!");
            }

            
        }
    }
}
