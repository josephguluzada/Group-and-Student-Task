using System;

namespace Group
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student("Umid Shemdinli");
            Student student2 = new Student("Shemil");
            Student student3 = new Student("Vasif ");
            Student student4 = new Student("Agasif ");

            Console.WriteLine(student1.No + " - " + student1.FullName);
            Console.WriteLine(student2.No + " - " + student2.FullName);

            Group programming = new Group("Programing");
            Group design = new Group("Design");

            Console.WriteLine(programming.GroupNo);
            Console.WriteLine(design.GroupNo);

            programming.Students = new Student[] { student1, student2 };
            Console.WriteLine("\nProgramming:");
            foreach (var student in programming.Students)
            {
                Console.WriteLine(student.FullName);
            }

            design.Students = new Student[] { student3, student4 };
            Console.WriteLine("\nDesign:");
            foreach (var student in design.Students)
            {
                Console.WriteLine(student.FullName);
            }
            Console.WriteLine("\nWanted Student:");
            Student wantedStudent1 = programming.FindStudentByNo(1);
            Console.WriteLine(wantedStudent1.No + " - " + wantedStudent1.FullName);


        }
    }
}
