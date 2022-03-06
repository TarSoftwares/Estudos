using System;

namespace Calculator
{
    class Program
    {
        int Num1 = 0;
        static void Main(string[] args)
        {    
            Menu();           
        }
        static void Menu()
        {
            Console.Clear();         
            Console.WriteLine("================================================");
            Console.WriteLine("          C A L C U L A D O R A                 ");
            Console.WriteLine("================================================");
            Console.WriteLine("              1- SOMAR                          ");
            Console.WriteLine("              2- SUTRAIR                        ");
            Console.WriteLine("              3- MULTIPLICAR                    ");
            Console.WriteLine("              4- DIVIDIR                        ");
            Console.WriteLine("              5- SAIR                           ");              
           Console.WriteLine("Entre com a Operação");          
           var Operacao = int.Parse(Console.ReadLine());
           switch (Operacao)
           {
               case 1 :
               {
                    Console.WriteLine("         1- SOMAR            ");
                    break;                             
                   
               } 
               case 2 :
               {
                    Console.WriteLine("         1- SUBTRARIR         ");break;                             
                   
               } 
               case 3 :
               {
                    Console.WriteLine("         1- MULTIPLICAR        ");break;                                                
               } 
               case 4 :
               {
                    Console.WriteLine("         1- DIVIDIR            ");break;                                                
               } 
               case 5 :
               {
                    System.Environment.Exit(0);
                    break;                                                
               } 

               default:
               {
                    Menu();
                    break;
               } 
           }           
           Console.WriteLine("Entre com o 1º Número");
           var Num1 = float.Parse(Console.ReadLine());
           Console.WriteLine("Entre com o 2º Número");
           var Num2 = float.Parse(Console.ReadLine());
           switch (Operacao)
           {    
               case 1:
               {
                    Somar(Num1,Num2);
                    break;
               } 
               case 2:
               {
                    Subtrair(Num1,Num2);
                    break;
               } 
               case 3:
               {
                    Multiplicar(Num1,Num2);
                    break;
               } 
               case 4:
               {
                    Dividir(Num1,Num2);
                    break;
               }              

               default:
               {
                   Menu();
                   break;
               }   
           }         
        }
        static void Somar(float num1, float num2)
        {          
            Console.WriteLine("");
            Console.WriteLine("");       
            var Resultado = num1 + num2;   
            Console.WriteLine($"Resultado da Soma é {Resultado}");  
            Console.ReadKey();        
            Menu();    
        }
        static void Subtrair(float num1, float num2)
        {          
            Console.WriteLine("");
            Console.WriteLine("");       
            var Resultado = num1 - num2;   
            Console.WriteLine($"Resultado da Subração é {Resultado}");  
            Console.ReadKey();        
            Menu();    
        }
        static void Multiplicar(float num1, float num2)
        {          
            Console.WriteLine("");
            Console.WriteLine("");       
            var Resultado = num1 * num2;   
            Console.WriteLine($"Resultado da Multiplicação é {Resultado}");  
            Console.ReadKey();        
            Menu();    
        }
        static void Dividir(float num1, float num2)
        {          
            Console.WriteLine("");
            Console.WriteLine("");       
            var Resultado = num1 / num2;   
            Console.WriteLine($"Resultado da Divisão é {Resultado}");  
            Console.ReadKey();        
            Menu();    
        }
    }
}
