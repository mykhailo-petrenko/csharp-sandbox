using System;
using System.Collections.Generic;
using System.Text;

namespace GradeBook
{
    public class Grade
    {
        public string Letter
        {
            get
            {
                return this.letter;
            }
        }

        private string letter;

        Grade()
        {

        }

        Grade(double grade)
        {
            this.letter = GradeToLetter(grade);
        }

        public static string GradeToLetter(double grade)
        {
            switch(grade)
            {
                case var d when d >= 90:
                    return "A";
                case var d when d >= 80:
                    return "B";
                case var d when d >= 70:
                    return "C";
                case var d when d >= 60:
                    return "D";
                default:
                    return "F";
            }
        }
    }
}
