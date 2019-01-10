using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public class Cat : Animal, Mammal
    {
        public Cat(string name) : base (name)
        {

        }

        public bool isMammal()
        {
            return true;
        }

        public override void makeSoudnd()
        {
            Console.WriteLine("Meow!");
        }
    }
}
