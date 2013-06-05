using System;

namespace ExceptionsHomework
{
    public class ExamResult
    {
        public int Grade { get; private set; }

        public int MinGrade { get; private set; }

        public int MaxGrade { get; private set; }

        public string Comments { get; private set; }

        public ExamResult(int grade, int minGrade, int maxGrade, string comments)
        {
            if (grade < 0)
            {
                throw new ArgumentOutOfRangeException("The grade should be positive!");
            }
            if (minGrade < 0)
            {
                throw new ArgumentOutOfRangeException("The minimum grade should be positive!");
            }
            if (maxGrade <= minGrade)
            {
                throw new ArgumentException("Maximum grade should be bigger than Minimum grade");
            }
            if (comments == null || comments == string.Empty)
            {
                throw new ArgumentNullException("The comments cannot be empty!");
            }

            this.Grade = grade;
            this.MinGrade = minGrade;
            this.MaxGrade = maxGrade;
            this.Comments = comments;
        }
    }
}