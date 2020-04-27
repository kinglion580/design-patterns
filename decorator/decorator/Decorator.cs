using System;
using System.Collections.Generic;
using System.Text;

namespace decorator
{
    class Finery : Person
    {
        protected Person component;

        public void Decorate(Person component)
        {
            this.component = component;
        }

        public override void show()
        {
            if (component != null)
            {
                component.show();
            }
        }
    }

    class TShirts : Finery
    {
        public override void show()
        {
            Console.Write("大T恤");
            base.show();
        }
    }

    class BigTrouser : Finery
    {
        public override void show()
        {
            Console.Write("垮裤");
            base.show();
        }
    }
}
