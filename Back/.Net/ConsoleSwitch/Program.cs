using System;

namespace ConsoleSwitch
{
    class Program
    {
        private const bool V = false;

        private static void Main(string[] args)
        {
            Main(args, false);
        }

        static void Main(string[] args, bool v)
        {
           Console.WriteLine("Entre com o Nome");
           string Nome = Console.ReadLine();
           Console.WriteLine("Entre com a idade");
           int idade = int.Parse(Console.ReadLine());
           Boolean menorIdade = false;
           switch (idade)
           {
               case < 18:  menorIdade = true;break;
               case >= 18: menorIdade = false;break;
               default: menorIdade = false;break;
           }
           switch (menorIdade)
           {
                case true: Console.WriteLine($"{Nome} é menor de Idade");break;
                case false: Console.WriteLine($"{Nome} é maior de Idade");break;   
                default: Console.WriteLine($"{Nome}é menor de Idade");break;
           } 

        }
    }
}
