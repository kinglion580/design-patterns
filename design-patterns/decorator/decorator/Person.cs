using System;
using System.Collections.Generic;
using System.Text;

namespace decorator
{
    class Person
    {
        public Person() { }
        private string name;
        public Person(string name)
        {
            this.name = name;
        }

        public virtual void show()
        {
            Console.WriteLine("装扮的{0}", name);
        }
    }
}
