using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_4_AverageGrades
{
    class Student
    {
        public string Name { get; set; }
        public double[] GradesList { get; set; }
        public double AvgGrade {
            get {
                return GradesList.Average();
            }
        }
        
    }

    class Program
    {
        static void Main(string[] args)
        {
            int studentsCount = int.Parse(Console.ReadLine());
            var students = new List<Student>();

            for (int i = 0; i < studentsCount; i++)
            {
                var input = Console.ReadLine().Split().ToList();
                double[] currentGrades = input.Skip(1).Select(double.Parse).ToArray();
                Student student = new Student() {
                    Name = input[0],
                    GradesList = currentGrades
                };
                students.Add(student);
            }

            students = students.Where(x => x.AvgGrade >= 5.00)
                .OrderBy(s => s.Name)
                .ThenByDescending(s => s.AvgGrade)
                .ToList();

            foreach (var student in students)
            {
                Console.WriteLine($"{student.Name} -> {student.AvgGrade:F2}");
            }

        }
    }
}
