﻿using System;
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
            Cat foo = new Cat("Scooby Doo");

            Console.WriteLine(foo.Name);

            foo.makeSoudnd();

            if (foo.isMammal()) {
                Console.WriteLine("I am a mammal");
            }

            Double myDouble1 = 54.898989;
            Console.WriteLine("The double " + myDouble1 + " is " + MoreExamples.castDouleToInt(myDouble1) + " when casted to an int");

            Console.ReadKey();
        }
    }
}
