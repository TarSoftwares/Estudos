using System;

namespace ForWhileDoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            //Contando com For
            Contar50();
            Contar(30);
            Contar(0,45);
            Console.WriteLine("Entre com o valor Inicial");
            int inicio = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o valor Final");
            int fim = int.Parse(Console.ReadLine());
            ContarDecrescente(inicio, fim);
        }
        static void Contar50()
        {
            for (int i = 0; i <=50; i++)
            {
                Console.WriteLine($"Número {i}");
            }           
        }
        static void Contar(int numero)
        {
            var i = 0;
            do{
                Console.WriteLine($"Número {i}");
                i++;
            } while(i <= numero);
        }
        static void Contar(int inicio,int fim)
        {
            int cont = 0;
            while (cont <= fim)
            {
                Console.WriteLine($"Atual {cont}");
                cont++;
            }
        }
        static void ContarDecrescente(int inicio,int fim)
        {
            int Inicio = inicio;
            int Fim = fim;
            for (int cont = Fim; cont >= Inicio; cont--)
            {
                Console.WriteLine($"Valor Atual {cont}");
            }
        }
    }
}
