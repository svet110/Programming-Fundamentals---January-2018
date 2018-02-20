namespace AverageGrades
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class AverageGrades
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            var studentList = new List<Student>();
            
            for (int i = 0; i < n; i++)
            {
                Student student = ReadStudents();
                studentList.Add(student);
            }

            studentList = studentList
                .Where(s => s.AverageGrade >= 5)
                .OrderBy(s => s.Name)
                .ThenByDescending(s => s.AverageGrade)
                .ToList();
            
            foreach (var student in studentList)
            {
                Console.WriteLine($"{student.Name} -> {student.AverageGrade:F2}");
            }   
        }

        public static Student ReadStudents()
        {
            var studentsData = Console.ReadLine().Split(' ');
            var marks = new List<double>();
            string studentName = studentsData[0];

            for (int i = 1; i < studentsData.Length; i++)
            {
                double currentMark = double.Parse(studentsData[i]);
                marks.Add(currentMark);
            }

            Student newStudent = new Student
            {
                Name = studentName,
                Grades = marks
            };

            return newStudent;
        }
    }
}
