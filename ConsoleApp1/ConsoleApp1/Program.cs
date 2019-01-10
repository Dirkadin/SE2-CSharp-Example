using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Animals;


namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal foo = new Animal("Scooby Doo");

            Console.WriteLine(foo.Name);
            Console.ReadKey();
        }
    }
}
