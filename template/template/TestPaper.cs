using System;
using System.Collections.Generic;
using System.Text;

namespace template
{
    class TestPaper
    {
        public void TestQuestion1 ()
        {
            Console.WriteLine("Question 1");
        }

        public void TestQuestion2 ()
        {
            Console.WriteLine("Question 2");
        }

        public void TestQuestion3 ()
        {
            Console.WriteLine("Question 3");
        }
    }

    
    class TestPaperA : TestPaper
    {
        public new void TestQuestion1 ()
        {
            base.TestQuestion1();
            Console.WriteLine("answer: b");
        }

        public new void TestQuestion2()
        {
            base.TestQuestion2();
            Console.WriteLine("answer: c");
        }

        public new void TestQuestion3()
        {
            base.TestQuestion3();
            Console.WriteLine("answer: d");
        }
    }


    class TestPaperB : TestPaper
    {
        public new void TestQuestion1()
        {
            base.TestQuestion1();
            Console.WriteLine("answer: a");
        }

        public new void TestQuestion2()
        {
            base.TestQuestion2();
            Console.WriteLine("answer: b");
        }

        public new void TestQuestion3()
        {
            base.TestQuestion3();
            Console.WriteLine("answer: c");
        }
    }
}
