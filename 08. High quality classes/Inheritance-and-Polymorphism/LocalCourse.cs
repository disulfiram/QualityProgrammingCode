namespace InheritanceAndPolymorphism
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Local course class.
    /// </summary>
    public class LocalCourse : Course
    {
        /// <summary>
        /// Initializes a new instance of the LocalCourse class.
        /// </summary>
        /// <param name="courseName">Name of course.</param>
        /// <param name="teacherName">Teacher name.</param>
        /// <param name="students">List of students.</param>
        /// <param name="lab">Lab name.</param>
        public LocalCourse(string courseName, string teacherName, IList<string> students, string lab) : base(courseName, teacherName, students)
        {
            this.Lab = lab;
        }

        /// <summary>
        /// Initializes a new instance of the LocalCourse class.
        /// </summary>
        /// <param name="courseName">Name of course.</param>
        public LocalCourse(string courseName) : this(courseName, null, null, null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the LocalCourse class.
        /// </summary>
        /// <param name="courseName">Name of course.</param>
        /// <param name="teacherName">Teacher name.</param>
        public LocalCourse(string courseName, string teacherName) : this(courseName, teacherName, null, null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the LocalCourse class.
        /// </summary>
        /// <param name="courseName">Name of course.</param>
        /// <param name="teacherName">Teacher name.</param>
        /// <param name="students">List of students.</param>
        public LocalCourse(string courseName, string teacherName, IList<string> students) : this(courseName, teacherName, students, null)
        {
        }

        /// <summary>
        /// Gets or sets lab the course is being held in.
        /// </summary>
        public string Lab { get; set; }
        
        /// <summary>
        /// Represents the course as a string.
        /// </summary>
        /// <returns>Course as string.</returns>
        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append("LocalCourse { ");
            result.Append(base.ToString());

            if (this.Lab != null)
            {
                result.AppendFormat("; Lab = {0}", this.Lab);
            }

            result.Append(" }");
            return result.ToString();
        }
    }
}