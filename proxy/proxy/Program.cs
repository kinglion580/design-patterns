using System;

namespace proxy
{
    class Program
    {
        static void Main(string[] args)
        {
            SchoolGirl mm = new SchoolGirl();
            mm.Name = "小红";

            Proxy p = new Proxy(mm);
            
            p.GiveFlowers();
            p.GiveDolls();
            p.GiveChocolate();

            Console.Read();
        }
    }
}
