using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Animal
    {
        private string name;

        public Animal (String name)
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
    }
}
