namespace SchoolTest
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using SchoolProject;
    
    [TestClass]
    public class SchoolTest
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void SchoolNameNull()
        {
            School school = new School(null);
            school.ToString();
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void SchoolNameEmptyString()
        {
            School school = new School(string.Empty);
            school.ToString();
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void SchoolListNull()
        {
            School school = new School("Telerik Academy", null);
            school.ToString();
        }

        [TestMethod]
        public void SchoolListLength()
        {
            Course firstCourse = new Course("JavasSript");
            Course secondCourse = new Course("OOP");
            Course thirdCourse = new Course("C# Part 1");
            List<Course> courses = new List<Course>() { firstCourse, secondCourse, thirdCourse };
            School school = new School("Telerik Academy", courses);

            Assert.AreEqual(3, school.Courses.Count);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void SchoolListAddExistingCourse()
        {
            Course firstCourse = new Course("JavaScript");
            Course secondCourse = new Course("OOP");

            School school = new School("Telerik Academy");
            school.AddCourse(firstCourse);
            school.AddCourse(secondCourse);
            school.AddCourse(firstCourse);
        }

        [TestMethod]
        public void SchoolListRemoveExistentCourse()
        {
            Course firstCourse = new Course("JavaScript");
            Course secondCourse = new Course("OOP");
            Course thirdCourse = new Course("C# Part 2");
            List<Course> courses = new List<Course>() { firstCourse, secondCourse, thirdCourse };
            School school = new School("Telerik Academy", courses);

            Assert.AreEqual(3, school.Courses.Count);

            school.RemoveCourse(firstCourse);
            school.RemoveCourse(secondCourse);

            Assert.AreEqual(1, school.Courses.Count);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void SchoolListRemoveNonExistentCourse()
        {
            Course firstCourse = new Course("JavaScript");
            Course secondCourse = new Course("OOP");
            Course thirdCourse = new Course("C# Part 3");
            List<Course> courses = new List<Course>() { firstCourse, secondCourse };
            School school = new School("Telerik Academy", courses);

            school.RemoveCourse(firstCourse);
            school.RemoveCourse(thirdCourse);
        }

        [TestMethod]
        public void SchoolListToStringTest()
        {
            Student firstStudent = new Student("John", "Smith", 56788);
            Student secondStudent = new Student("Arthur", "Pendragon", 21478);
            Student thirdStudent = new Student("Lancelot", "du Lac", 75489);
            Student fourthStudent = new Student("Christopher", "Robin", 22156);
            List<Student> students = new List<Student>() { firstStudent, secondStudent, thirdStudent, fourthStudent };
            Course course = new Course("C# Part 4", students);
            Course firstCourse = new Course("JavaScript");
            Course secondCourse = new Course("OOP");
            Course thirdCourse = new Course("C# Part 5");
            List<Course> courses = new List<Course>() { course, firstCourse, secondCourse, thirdCourse };
            School school = new School("Telerik Academy", courses);

            string actual = school.ToString();

            StringBuilder builder = new StringBuilder();
            builder.AppendLine("* * * School name: Telerik Academy * * *");
            builder.AppendLine("* * * Course name: C# Part 4 * * *");
            builder.AppendLine(firstStudent.ToString());
            builder.AppendLine(secondStudent.ToString());
            builder.AppendLine(thirdStudent.ToString());
            builder.AppendLine(fourthStudent.ToString());
            builder.AppendLine();
            builder.AppendLine("* * * Course name: JavaScript * * *");
            builder.AppendLine();
            builder.AppendLine("* * * Course name: OOP * * *");
            builder.AppendLine();
            builder.AppendLine("* * * Course name: C# Part 5 * * *");
            builder.AppendLine();
            string expected = builder.ToString();

            Assert.AreEqual(expected, actual);
        }
    }
}