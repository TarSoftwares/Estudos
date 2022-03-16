using System;
using System.Linq;
using System.Text;

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
            var Frase = "Corinthians";            
            Console.WriteLine(Frase.Insert(Frase.Length," é o melhor time do mundo!"));
            Console.WriteLine(Frase.Insert(Frase.Length," é o melhor time do mundo!").ToLower());
            Console.WriteLine(Frase.Insert(Frase.Length," é o melhor time do mundo!").ToUpper());
            var Frase1 = "Hoje está chovendo";
            int qtdeCaracteresEspaco = Frase1.Count(f => f == ' ');
            Console.WriteLine($"Total de caracteres ' ' {qtdeCaracteresEspaco}");
            var Texto = new StringBuilder();
            Texto.Append("1ª Linha \n");
            Texto.Append("2ª Linha \n");
            Texto.Append("3ª Linha \n");
            Texto.Append("4ª Linha \n");
            Texto.Append("5ª Linha \n");
            Console.WriteLine(Texto.ToString());
           
        }
    }
}
