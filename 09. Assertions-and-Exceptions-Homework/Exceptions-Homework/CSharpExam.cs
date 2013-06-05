using System;

namespace ExceptionsHomework
{
    public class CSharpExam : Exam
    {
        public int Score { get; private set; }

        public CSharpExam(int score)
        {
            if (score < 0)
            {
                throw new ArgumentOutOfRangeException("The score should be positive!");
            }

            this.Score = score;
        }

        public override ExamResult Check()
        {
            if (this.Score < 0 || this.Score > 100)
            {
                throw new ArgumentOutOfRangeException("The score should in the range from 0 to 100!");
            }
            else
            {
                return new ExamResult(this.Score, 0, 100, "Exam results calculated by score.");
            }
        }
    }
}
