using System;

namespace saladpuk
{
    internal class Grades
    {
        private string _grade;

        public string GradeSubject
        {
            get => _grade;
            set
            {
                _grade = value;
                _grade = Calculate(Convert.ToDouble(_grade));
            }
        }

        private string Calculate(double score)
        {
            return score > 90 ? "A" :
                score > 80 ? "B" :
                score > 70 ? "C" :
                score > 60 ? "D" : "F";
        }
    }
}