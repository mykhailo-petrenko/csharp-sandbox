using System.Collections.Generic;

namespace GradeBook {

    internal class Book {

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

        override public string ToString()
        {
            string gradesList = string.Join(' ', grades);

            return $"'{name}': {gradesList}";
        }
    }
}
