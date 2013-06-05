namespace InheritanceAndPolymorphism
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Abstract class for course.
    /// </summary>
    public abstract class Course
    {
        /// <summary>
        /// Name of course.
        /// </summary>
        private string name;

        /// <summary>
        /// Name of teacher.
        /// </summary>
        private string teacherName;

        /// <summary>
        /// List of students.
        /// </summary>
        private IList<string> students = new List<string>();

        /// <summary>
        /// Initializes a new instance of the Course class.
        /// </summary>
        protected Course()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Course class.
        /// </summary>
        /// <param name="name">Name of course.</param>
        /// <param name="teacherName">Name of teacher.</param>
        /// <param name="students">List of students.</param>
        protected Course(string name, string teacherName, IList<string> students)
        {
            this.Name = name;
            this.TeacherName = teacherName;
            this.Students = students;
        }

        /// <summary>
        /// Gets or sets name of course.
        /// </summary>
        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException();
                }

                this.name = value;
            }
        }

        /// <summary>
        /// Gets or sets the teacher name.
        /// </summary>
        public string TeacherName
        {
            get
            {
                return this.teacherName;
            }

            set
            {
                this.teacherName = value;
            }
        }

        /// <summary>
        /// Gets or sets the list of students
        /// </summary>
        public IList<string> Students
        {
            get
            {
                return this.students;
            }

            set
            {
            }
        }

        /// <summary>
        /// Returns the course as string.
        /// </summary>
        /// <returns>Course as string.</returns>
        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.AppendFormat("Name = {0}", this.Name);

            if (this.TeacherName != null)
            {
                result.AppendFormat("; Teacher = {0}", this.TeacherName);
            }

            result.AppendFormat("; Students = {0}", this.GetStudentsAsString());

            return result.ToString();
        }

        /// <summary>
        /// Gets students as string.
        /// </summary>
        /// <returns>String of the list of students.</returns>
        protected string GetStudentsAsString()
        {
            if (this.Students == null || this.Students.Count == 0)
            {
                return "{ }";
            }
            else
            {
                return "{ " + string.Join(", ", this.Students) + " }";
            }
        }
    }
}