using System;

namespace template
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("student a: ");
            TestPaperA a = new TestPaperA();
            a.TestQuestion1();
            a.TestQuestion2();
            a.TestQuestion3();

            Console.WriteLine("student b: ");
            TestPaperB b = new TestPaperB();
            b.TestQuestion1();
            b.TestQuestion2();
            b.TestQuestion3();

            Console.Read();
        }
    }
}
