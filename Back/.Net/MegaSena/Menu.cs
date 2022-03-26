using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
namespace MegaSena
{
        class Menu{        
        public static List<Int32> dezenas = new List<Int32>();
        public static Int32 opcao = new Int32();        
        public static Int32 Opcao
        { 
            get{return opcao;} 
            set{opcao = value;} 
        }
        public static List<Int32> Dezenas
        { 
            get{return dezenas;} 
            set{dezenas = value;} 
        }
        public Menu()
        {           
            
        }
        ///<summary>Método responsável por Exibir o Jogo(Dezenas)      
        ///</summary>
        ///<param></param>
        ///<returns>Método não tem retorno(void)</returns>
        ///<remarks>
        /// <para>************M E N U*********"</para>          
        /// <para>                             </para>
        /// <para>       1 - Gerar  Dezenas"   </para>
        /// <para>       2 - Exibir Dezenas    </para>
        /// <para>       3 - Salvar Dezenas    </para>
        /// <para>       4 - Sair              </para>
        ///</remarks>
        public static void Exibir ()
        {                     
            Console.WriteLine("************M E N U*********");          
            Console.WriteLine("");
            Console.WriteLine("1 - Gerar  Dezenas");
            Console.WriteLine("2 - Exibir Dezenas");
            Console.WriteLine("3 - Salvar Dezenas");
            Console.WriteLine("4 - Sair");
            Int32 v = Int32.Parse(Console.ReadLine());  
            switch (v)
            {
                case 1:
                {
                   Menu.GerarDezenas();   
                   Menu.Exibir();               
                   break;   
                }  
                case 2:
                {                    
                    Menu.ExibirDezenas();       
                    Menu.Exibir();                                                
                    break;
                }     
                case 3:
                {
                    Menu.GravarDezenas();
                    Menu.Exibir();
                    break;
                }
                case 4:
                {
                    System.Environment.Exit(0);
                    break;
                }             
                default:
                {
                   Menu.Exibir();               
                   break;
                }
            }                              
        }
        public static void GerarDezenas()
        {            
            List<Int32> lista = new List<Int32>();
            while (lista.Count < 6)
            {
                var dezena = 0;
                Random random = new Random();
                dezena = random.Next(1,60);
                lista.Add(dezena);               
            }                     
            Menu.Dezenas = lista;                         
        }  
        public static void ExibirDezenas()
        {            
            var cont = 0;
            foreach (Int32 dez in Menu.Dezenas)
            {
                cont++;
                Console.WriteLine($"Dezena {cont} - {dez.ToString()}");
            }    

        }
        public static void GravarDezenas()
        {
            StreamWriter sw = new StreamWriter("C:\\Tarso\\Jogos\\CSharp.txt");
            var cont = 0;
            foreach (var dezenas in Menu.Dezenas)
            {
                cont++;
                sw.WriteLine($"Dezena {cont} -  {dezenas.ToString()}");
            }
            sw.Close();
        }   


    }
}