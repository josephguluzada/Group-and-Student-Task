using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group
{
    public class Group
    {
        public string Type;
        public string GroupNo;
        public static int Counter = 100;

        public Student[] Students = { };

        public Group(string type)
        {
            Counter++;
            this.Type = type;
            GroupNo = this.Type[0] + Counter.ToString();
        }

        public Student FindStudentByNo(int no)
        {
            foreach (Student student in this.Students)
            {
                if(student.No == no)
                {
                    return student;
                }
            }

            return null;
        }
    }
}
