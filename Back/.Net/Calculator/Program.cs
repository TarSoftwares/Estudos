using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {     
           Console.Clear();         
           Menu();
           Console.WriteLine("Entre com a Operação");          
           var Operacao = int.Parse(Console.ReadLine());
           switch (Operacao)
           {
               case 1 :
               {
                    Console.WriteLine("         1- SOMAR            ");break;                             
                   
               } 
               default: Menu();break;
           }
           Console.WriteLine("Entre com o 1º Número");
           var Num1 = float.Parse(Console.ReadLine());
           Console.WriteLine("Entre com o 2º Número");
           var Num2 = float.Parse(Console.ReadLine());
           switch (Operacao)
           {    
               case 1: Somar(Num1,Num2);break;
               default:Menu();break;
           }
           

          
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
            // Console.WriteLine("================================================");
            // Console.WriteLine("              TARSOFTWARES                      ");
            // Console.WriteLine("================================================");            
        }
        static void Somar(float num1, float num2)
        {          
            Console.WriteLine("");
            Console.WriteLine("");       
            var Resultado = num1 + num2;   
            Console.WriteLine($"Resultado da Soma é {Resultado}");  
            Console.ReadKey();            
        }
        static void LerNumeros()
        {
        //    Console.WriteLine("Entre com o 1º Número");
        //    var num1 = float.Parse(Console.ReadLine());
        //    Console.WriteLine("Entre com o 2º Número");
        //    var num2 = float.Parse(Console.ReadLine());
        }
    }
}
