using System.Collections.Generic;
using System;

namespace GradeBook {

    public class Book {

        public const double MAX_GRADE = 100;
        public const double MIN_GRADE = 0;

        public string Name { get; set; }
        private List<double> grades;

        public Book(string name) {
            Name = name;
            grades = new List<double>();
        }

        public void AddGrade(double grade)
        {
            if (grade < MIN_GRADE || grade > MAX_GRADE) {
                throw new ArgumentOutOfRangeException($"grade should be between {MIN_GRADE} and {MAX_GRADE}");
            }

            grades.Add(grade);
        }

        public Statistics GetStatistics() {
            if (grades.Count == 0) {
                // In real world better to use exception
                return null;
            }

            double sum = 0;
            double max = grades[0];
            double min = grades[0];

            foreach (double grade in grades)
            {
                sum += grade;

                if (max < grade) {
                    max = grade;
                }

                if (min > grade) {
                    min = grade;
                }
            }

            return new Statistics(
                sum / grades.Count,
                max,
                min
            );
        }

        override public string ToString()
        {
            string gradesList = string.Join(' ', grades);

            return $"'{Name}': {gradesList}";
        }
    }
}
