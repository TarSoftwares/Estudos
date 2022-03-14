using System;

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
    }
    }    
}
