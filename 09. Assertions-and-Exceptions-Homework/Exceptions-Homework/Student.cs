﻿using System;
using System.Linq;
using System.Collections.Generic;

namespace ExceptionsHomework
{
    public class Student
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public IList<Exam> Exams { get; set; }

        public Student(string firstName, string lastName, IList<Exam> exams)
        {
            if (firstName == null)
            {
                throw new ArgumentNullException("The first name cannot be null!");
            }

            if (lastName == null)
            {
                throw new ArgumentNullException("The last name cannot be null!");
            }

            this.FirstName = firstName;
            this.LastName = lastName;
            this.Exams = exams;
        }

        public IList<ExamResult> CheckExams()
        {
            if (this.Exams == null)
            {
                throw new ArgumentNullException(string.Format("The List with exams of student {0} {1} cannot be null!", this.FirstName, this.LastName));
            }

            if (this.Exams.Count == 0)
            {
                throw new ArgumentOutOfRangeException(string.Format("The List with exams of student {0} {1} cannot be empty!", this.FirstName, this.LastName));
            }

            IList<ExamResult> results = new List<ExamResult>();
            for (int i = 0; i < this.Exams.Count; i++)
            {
                results.Add(this.Exams[i].Check());
            }

            return results;
        }

        public double CalcAverageExamResultInPercents()
        {
            if (this.Exams == null)
            {
                // Cannot calculate average on missing exams
                throw new ArgumentNullException(string.Format("The List with exams of student {0} {1} cannot be null! Calculating average on missing exams is not possible!", this.FirstName, this.LastName));
            }

            if (this.Exams.Count == 0)
            {
                // No exams --> return -1;
                throw new ArgumentOutOfRangeException(string.Format("The List with exams of student {0} {1} cannot be empty! Calculating average on missing exams is not possible!", this.FirstName, this.LastName));
            }

            double[] examScore = new double[this.Exams.Count];
            IList<ExamResult> examResults = CheckExams();
            for (int i = 0; i < examResults.Count; i++)
            {
                examScore[i] = ((double)examResults[i].Grade - examResults[i].MinGrade) /
                               (examResults[i].MaxGrade - examResults[i].MinGrade);
            }

            return examScore.Average();
        }
    }
}
