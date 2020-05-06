﻿using System;
using System.Collections.Generic;
using System.Text;

namespace resume
{
    class Resume
    {
        private string name;
        private string sex;
        private string age;
        private string timeArea;
        private string company; 
        
        public Resume(string name)
        {
            this.name = name;
        }

        public void SetPersonalInfo(string sex, string age)
        {
            this.sex = sex;
            this.age = age;
        }

        public void SetWorkExperience(string timeArea, string company)
        {
            this.timeArea = timeArea;
            this.company = company;
        }

        public void Display()
        {
            Console.WriteLine("{0} {1} {2}", name, sex, age);
            Console.WriteLine("工作经历: {0} {1}", timeArea, company);
        }
    }
}
