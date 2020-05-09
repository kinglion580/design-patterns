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
            Console.WriteLine("answer: " + Answer1());
        }

        protected virtual string Answer1()
        {
            return "";
        }

        public void TestQuestion2 ()
        {
            Console.WriteLine("Question 2");
            Console.WriteLine("answer: " + Answer2());
        }

        protected virtual string Answer2()
        {
            return "";
        }

        public void TestQuestion3 ()
        {
            Console.WriteLine("Question 3");
            Console.WriteLine("answer: " + Answer3());
        }

        protected virtual string Answer3()
        {
            return "";
        }
    }

    
    class TestPaperA : TestPaper
    {
        protected override string Answer1()
        {
            return "b";
        }

        protected override string Answer2()
        {
            return "c";
        }

        protected override string Answer3()
        {
            return "d";
        }
    }


    class TestPaperB : TestPaper
    {
        protected override string Answer1()
        {
            return "a";
        }

        protected override string Answer2()
        {
            return "b";
        }

        protected override string Answer3()
        {
            return "c";
        }
    }
}
