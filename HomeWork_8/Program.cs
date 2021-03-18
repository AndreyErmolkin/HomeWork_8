using System;
using System.Collections.Generic;

namespace HomeWork_8
{
    public class Student
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Marks { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Random ranResult = new Random();

            Student student_1 = new Student
            {
                Name = "Sam",
                Surname = "Ogenji",
                Marks = ranResult.Next(0, 2)
            };
            Student student_2 = new Student
            {
                Name = "Kate",
                Surname = "Turkina",
                Marks = ranResult.Next(0, 2)
            };
            Student student_3 = new Student
            {
                Name = "Rex",
                Surname = "Trex",
                Marks = ranResult.Next(0, 2)
            };
            List<Student> students = new List<Student>() { student_1, student_2, student_3 };

            if (student_1.Marks > 0)
            {
                Console.WriteLine($" Студент { student_1.Name} {student_1.Surname } получил коффе");
            }

            if (student_2.Marks > 0)
            {
                Console.WriteLine($" Студент { student_2.Name} {student_2.Surname } получила коффе");
            }

            if (student_3.Marks > 0)
            {
                Console.WriteLine($" Студент { student_3.Name} {student_3.Surname } получил коффе");
            }
            Console.WriteLine();

        }
    }
}


