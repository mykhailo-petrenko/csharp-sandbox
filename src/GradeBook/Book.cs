using System.Collections.Generic;

namespace GradeBook {

    public class Book {

        private string name;
        private List<double> grades;

        public Book(string name) {
            this.name = name;
            grades = new List<double>();
        }

        public void AddGrade(double grade)
        {
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

            return $"'{name}': {gradesList}";
        }
    }
}
