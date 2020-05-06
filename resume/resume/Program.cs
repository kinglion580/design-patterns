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

            Resume b = new Resume("大鸟");
            b.SetPersonalInfo("男", "29");
            b.SetWorkExperience("1998-2000", "xx公司");

            Resume c = new Resume("大鸟");
            c.SetPersonalInfo("男", "29");
            c.SetWorkExperience("1998-2000", "xx公司");

            a.Display();
            b.Display();
            c.Display();

            Console.Read();
        }
    }
}
