using System;
using System.Collections.Generic;
using System.Text;

namespace JoinsInLinq
{
    class Student
    {
        public Student(int rollNo, string name, int department)
        {
            this.rollNo = rollNo;
            Name = name;
            Department = department;
        }

        public int rollNo { get; set; }
        public string Name { get; set; }
        public int Department { get; set; }
    }
}
