namespace InheritanceAndPolymorphism
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    
    /// <summary>
    /// CLass for offsite courses.
    /// </summary>
    public class OffsiteCourse : Course
    {
        /// <summary>
        /// Town in which the course is held.
        /// </summary>
        private string town;

        /// <summary>
        /// Initializes a new instance of the OffsiteCourse class.
        /// </summary>
        /// <param name="courseName">Name of the course.</param>
        /// <param name="teacherName">Name of teacher.</param>
        /// <param name="students">List of students.</param>
        /// <param name="town">Town in which the course is held.</param>
        public OffsiteCourse(string courseName, string teacherName, IList<string> students, string town) : base(courseName, teacherName, students)
        {
            this.Town = town;
        }
     
        /// <summary>
        /// Initializes a new instance of the OffsiteCourse class.
        /// </summary>
        /// <param name="courseName">Name of the course.</param>
        /// <param name="teacherName">Name of teacher.</param>
        public OffsiteCourse(string courseName, string teacherName) : this(courseName, teacherName, null, null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the OffsiteCourse class.
        /// </summary>
        /// <param name="courseName">Name of the course.</param>
        /// <param name="teacherName">Name of teacher.</param>
        /// <param name="students">List of students.</param>
        public OffsiteCourse(string courseName, string teacherName, IList<string> students) : this(courseName, teacherName, students, null)
        {
        }

        /// <summary>
        /// Gets or sets town in which the course is being held.
        /// </summary>
        public string Town
        {
            get
            {
                return this.town;
            }

            set
            {
                this.town = value;
            }
        }

        /// <summary>
        /// String representation of the course.
        /// </summary>
        /// <returns>Offsite course as string.</returns>
        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append("OffsiteCourse { ");
            result.Append(base.ToString());

            if (this.Town != null)
            {
                result.AppendFormat("; Town = {0}", this.Town);
            }

            result.Append(" }");
            return result.ToString();
        }
    }
}