using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public class Animal
    {
        private string name;

        public Animal(string name)
        {
            this.name = name;
        }

        public String Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }

        public virtual void makeSoudnd()
        {
            Console.WriteLine("Default sound");
        }

    }
}
