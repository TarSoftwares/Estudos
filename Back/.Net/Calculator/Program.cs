using System;

namespace Calculator
{
    class Program
    {
        public float numero1;
        public float numero2;
        public float Numero1
        { 
            get{return numero1;} 
            set{numero1 = value;}
        }
        public float Numero2
        { 
            get{return numero2;} 
            set{numero2 = value;} 
        }

        static void Main(string[] args)
        {
            Menu();
            LerNumeros();
        }
        static void Menu()
        {
            Console.WriteLine("================================================");
            Console.WriteLine("          C A L C U L A D O R A                 ");
            Console.WriteLine("================================================");
            Console.WriteLine("              1- SOMAR                          ");
            Console.WriteLine("              2- SUTRAIR                        ");
            Console.WriteLine("              3- MULTIPLICAR                    ");
            Console.WriteLine("              4- DIVIDIR                        ");
            Console.WriteLine("              5- SAIR                           ");
            Console.WriteLine("================================================");
            Console.WriteLine("              TARSOFTWARES                      ");
            Console.WriteLine("================================================");
            Console.ReadKey();
        }
        static void Somar()
        {
            Console.WriteLine("              1- SOMAR                          ");            
            Console.WriteLine("");
            Console.WriteLine("");            
        }
        static void LerNumeros()
        {
            Console.WriteLine("Entre com o 1º Número");
            // Numero1 = float.Parse(Console.ReadLine());

        }
    }
}
