using System;

namespace decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            Person xc = new Person("小菜");

            Console.WriteLine("\n第一种装扮: ");

            BigTrouser bt = new BigTrouser();
            TShirts dtx = new TShirts();
            bt.Decorate(xc);
            dtx.Decorate(bt);
            dtx.show();

            Console.WriteLine("\n第二种装扮: ");

            TShirts dtx2 = new TShirts();
            BigTrouser bt2 = new BigTrouser();
            dtx2.Decorate(xc);
            bt2.Decorate(dtx2);
            bt2.show();

            Console.Read();
        }
    }
}
