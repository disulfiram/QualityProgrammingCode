namespace SchoolProject
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class School
    {
        private List<Course> courses;
        private string name;

        public School(string name)
        {
            this.Courses = new List<Course>();
            this.Name = name;
        }

        public School(string name, List<Course> courses)
        {
            this.Courses = courses;
            this.Name = name;
        }

        public List<Course> Courses
        {
            get
            {
                return this.courses;
            }

            private set
            {
                this.courses = value;
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
                    throw new ArgumentException("Name of the school cannot be empty!");
                }

                this.name = value;
            }
        }

        public void AddCourse(Course newCourse)
        {
            bool isCourseFound = this.IsCourseInTheCourseList(newCourse);

            if (isCourseFound)
            {
                throw new ArgumentException("The course " + newCourse.Name + " already exist in this course list!");
            }

            this.Courses.Add(newCourse);
        }

        public void RemoveCourse(Course newCourse)
        {
            bool isCourseFound = this.IsCourseInTheCourseList(newCourse);

            if (!isCourseFound)
            {
                throw new ArgumentException("The course " + newCourse.Name + " does not exist in this course list!");
            }

            this.Courses.Remove(newCourse);
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine(string.Format("* * * School name: {0} * * *", this.Name));

            for (int i = 0; i < this.Courses.Count; i++)
            {
                builder.AppendLine(this.Courses[i].ToString());
            }

            return builder.ToString();
        }

        private bool IsCourseInTheCourseList(Course newCourse)
        {
            bool isCourseFound = false;
            for (int i = 0; i < this.Courses.Count; i++)
            {
                if (this.Courses[i].Name == newCourse.Name)
                {
                    isCourseFound = true;
                }
            }

            return isCourseFound;
        }
    }
}