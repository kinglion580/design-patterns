using System;

namespace decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            Person xc = new Person("小菜");

            Console.WriteLine("\n第一种装扮: ");

            xc.WearTShirts();
            xc.WearBigTrouser();
            xc.WearSneakers();
            xc.Show();

            Console.WriteLine("\n第二种装扮: ");
            
            xc.WearSuit();
            xc.WearTie();
            xc.WearLeatherShoes();
            xc.Show();

            Console.Read();
        }
    }
}
