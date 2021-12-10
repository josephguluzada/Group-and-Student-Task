using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group
{
    public class Student
    {
        private static int Counter = 0;
        public string FullName;
        public int No;

        public Student(string fullName)
        {
            Counter++;
            this.No = Counter;
            this.FullName = fullName;

        }
    }
}
