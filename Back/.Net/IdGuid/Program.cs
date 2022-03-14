using System;

namespace IdGuid
{
    class Program
    {
        static void Main(string[] args)
        {
            var Id = Guid.NewGuid();
            Console.WriteLine(Id.ToString().Substring(0,8));

        }
    }
}
