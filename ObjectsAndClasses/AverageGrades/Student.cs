namespace AverageGrades
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class Student
    {
        public string Name { get; set; }

        public List<double> Grades { get; set; }

        public double AverageGrade { get { return Grades.Average(); } }
    }
}
