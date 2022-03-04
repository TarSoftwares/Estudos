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
    }
}
