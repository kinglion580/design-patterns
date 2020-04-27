using System;                       
using System.Collections.Generic;
using System.Text;

namespace proxy
{
    interface IGiveGift
    {
        void GiveDolls();
        void GiveFlowers();
        void GiveChocolate();
    }

    class Proxy : IGiveGift
    {
        Pursuit gg;
        public Proxy(SchoolGirl mm)
        {
            gg = new Pursuit(mm);
        }
        public void GiveChocolate()
        {
            gg.GiveChocolate();
        }

        public void GiveDolls()
        {
            gg.GiveDolls();
        }

        public void GiveFlowers()
        {
            gg.GiveFlowers();
        }
    }

    class Pursuit : IGiveGift
    {
        SchoolGirl mm;
        public Pursuit(SchoolGirl mm)
        {
            this.mm = mm;
        }
        public void GiveChocolate()
        {
            Console.WriteLine(mm.Name + " 送你巧克力");
        }

        public void GiveDolls()
        {
            Console.WriteLine(mm.Name + " 送你洋娃娃");
        }

        public void GiveFlowers()
        {
            Console.WriteLine(mm.Name + " 送你鲜花");
        }
    }

    class SchoolGirl
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
    }
}
