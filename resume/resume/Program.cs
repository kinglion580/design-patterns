using System;

namespace resume
{
    class Program
    {
        static void Main(string[] args)
        {
            Resume a = new Resume("大鸟");
            a.SetPersonalInfo("男", "29");
            a.SetWorkExperience("1998-2000", "xx公司");

            Resume b = (Resume)a.Clone();
            b.SetWorkExperience("1998-2000", "yy公司");

            Resume c = (Resume)a.Clone();
            c.SetPersonalInfo("女", "24");

            a.Display();
            b.Display();
            c.Display();

            Console.Read();
        }
    }
}
