using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lápbai4
{
    public class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Student(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Age: {Age}");
        }
    }
    class program
    {
        static void Main()
        {
            List<Student> studentList = new List<Student>();
            studentList.Add(new Student("John", 20));
            studentList.Add(new Student("Jane", 22));
            studentList.Add(new Student("Alice", 21));

            foreach (var student in studentList)
            {
                student.DisplayInfo();
                Console.WriteLine();
                
            }
            Console.ReadLine();
        }

    }
}
