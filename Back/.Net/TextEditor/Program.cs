using System;
using System.IO;
using System.Threading;
using System.Globalization;

namespace TextEditor
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();        
        }
        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("          M E N U             ");
            Console.WriteLine("Digite - 1 Para Criar Arquivo ");
            Console.WriteLine("Digite - 2 Para Editar Arquivo");
            Console.WriteLine("Digite - 0 Sair");
            var Opcao = Int32.Parse(Console.ReadLine());
            switch (Opcao)
            {
                case 1: CriarArquivo();break;
                case 2: LerArquivo();break;
                case 0: System.Environment.Exit(0);break;
                default: Menu();break;
            }
        }
        static void CriarArquivo()
        {
            DateTime dataHoje = DateTime.Now;    
            StreamWriter sw = new StreamWriter("C:\\Tarso\\Projetos\\Estudos\\Back\\.Net\\TextEditor\\Arq.txt");
            sw.WriteLine("Arquivo criado");
            sw.WriteLine(dataHoje.ToString());
            sw.Close();
            Console.WriteLine("Arquivo criado com êxito!");
            Thread.Sleep(2500);
            Menu();
        }
        static void LerArquivo()
        {
            String Linha;
            StreamReader sr = new StreamReader("C:\\Tarso\\Projetos\\Estudos\\Back\\.Net\\TextEditor\\Arq.txt");
            do
            {
               Linha = sr.ReadLine();                
               Console.WriteLine(Linha);
            }while (Linha != null);
            sr.Close();
            Thread.Sleep(2500);
            Menu();
            
        }
    }    
}
