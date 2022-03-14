using System;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            var Teste = "Testando Comparações de Strings";
            Console.WriteLine(Teste.CompareTo("testando comparações de strings"));
            var Teste2 = "Testando Comparações de Strings";
            Console.WriteLine(Teste2.Contains("testando"));
            Console.WriteLine(Teste2.Contains("testando",StringComparison.OrdinalIgnoreCase));
            var Teste3 = "Testando Início";
            Console.WriteLine(Teste3.StartsWith("Testando"));
            Console.WriteLine(Teste3.StartsWith("testando"));
            var Teste4 = "Testando Fim";
            Console.WriteLine(Teste4.EndsWith("Fim"));
            Console.WriteLine(Teste4.EndsWith("fim"));
            var Teste5 = "Comparando Texto Exato";
            Console.WriteLine(Teste5.Equals("Comparando Texto Exato"));
        }
    }
}
