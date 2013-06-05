namespace SchoolProject
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Course
    {
        public const byte MaxStudentsCountInCourse = 30;

        private List<Student> students;
        private string name;

        public Course(string name)
        {
            this.Students = new List<Student>();
            this.Name = name;
        }

        public Course(string name, List<Student> students)
        {
            this.Students = students;
            this.Name = name;
        }

        public List<Student> Students
        {
            get
            {
                return this.students;
            }

            private set
            {
                this.students = value;
            }
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Name of the course cannot be empty!");
                }

                this.name = value;
            }
        }

        public void AddStudent(Student newStudent)
        {
            bool isStudentFound = this.IsStudentInTheCourseList(newStudent);

            if (isStudentFound)
            {
                throw new ArgumentException("The student " + newStudent.FirstName + " " + newStudent.LastName + " already exist in this student list!");
            }

            if (this.Students.Count + 1 <= MaxStudentsCountInCourse)
            {
                this.Students.Add(newStudent);
            }
            else
            {
                throw new ArgumentOutOfRangeException("The course is full. No more students can be added!");
            }
        }

        public void RemoveStudent(Student newStudent)
        {
            bool isStudentFound = this.IsStudentInTheCourseList(newStudent);

            if (!isStudentFound)
            {
                throw new ArgumentException("The student " + newStudent.FirstName + " " + newStudent.LastName + " does not exist in this student list!");
            }

            this.Students.Remove(newStudent);
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine(string.Format("* * * Course name: {0} * * *", this.Name));

            for (int i = 0; i < this.Students.Count; i++)
            {
                builder.AppendLine(this.Students[i].ToString());
            }

            return builder.ToString();
        }

        private bool IsStudentInTheCourseList(Student newStudent)
        {
            bool isStudentFound = false;
            for (int i = 0; i < this.Students.Count; i++)
            {
                if (this.Students[i].UniqueClassNumber == newStudent.UniqueClassNumber)
                {
                    isStudentFound = true;
                }
            }

            return isStudentFound;
        }
    }
}