namespace SchoolTest
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using SchoolProject;

    [TestClass]
    public class CourseTest
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void CourseNameNull()
        {
            Course course = new Course(null);
            course.ToString();
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void CourseNameEmptyString()
        {
            Course course = new Course(string.Empty);
            course.ToString();
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void CourseListNull()
        {
            Course course = new Course("JavaScript", null);
            course.ToString();
        }

        [TestMethod]
        public void CourseListLength()
        {
            Student firstStudent = new Student("John", "Smith", 56788);
            Student secondStudent = new Student("Christopher", "Robin", 22156);
            Student thirdStudent = new Student("Lancelot", "du Lac", 75489);
            List<Student> students = new List<Student>() { firstStudent, secondStudent, thirdStudent };
            Course course = new Course("JavaScript", students);

            Assert.AreEqual(3, course.Students.Count);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void CourseListAdd31()
        {
            Course course = new Course("JavaScript");

            for (uint i = 10000; i <= 10031; i++)
            {
                course.AddStudent(new Student("Christopher", "Robin", i));
            }
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void CourseListAddExistingStudent()
        {
            Student firstStudent = new Student("John", "Smith", 56788);
            Student secondStudent = new Student("John", "Smith", 56788);
            Course course = new Course("C# Part 1");
            course.AddStudent(firstStudent);
            course.AddStudent(secondStudent);
        }

        [TestMethod]
        public void CourseListRemoveExistentStudent()
        {
            Student firstStudent = new Student("John", "Smith", 56788);
            Student secondStudent = new Student("John", "Smith", 21478);
            Student thirdStudent = new Student("Lancelot", "du Lac", 75489);
            Student fourthStudent = new Student("Christopher", "Robin", 22156);
            List<Student> students = new List<Student>() { firstStudent, secondStudent, thirdStudent, fourthStudent };
            Course course = new Course("C# Part 2", students);

            Assert.AreEqual(4, course.Students.Count);

            course.RemoveStudent(firstStudent);
            course.RemoveStudent(secondStudent);

            Assert.AreEqual(2, course.Students.Count);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void CourseListRemoveNonExistentStudent()
        {
            Student firstStudent = new Student("John", "Smith", 56788);
            Student secondStudent = new Student("John", "Smith", 21478);
            Student thirdStudent = new Student("Lancelot", "du Lac", 75489);
            Student fourthStudent = new Student("Christopher", "Robin", 22156);
            List<Student> students = new List<Student>() { firstStudent, secondStudent, thirdStudent };
            Course course = new Course("C# Part 3", students);

            course.RemoveStudent(firstStudent);
            course.RemoveStudent(fourthStudent);
        }

        [TestMethod]
        public void CourseListToStringTest()
        {
            Student firstStudent = new Student("John", "Smith", 56788);
            Student secondStudent = new Student("John", "Smith", 21478);
            Student thirdStudent = new Student("Lancelot", "du Lac", 75489);
            Student fourthStudent = new Student("Christopher", "Robin", 22156);
            List<Student> students = new List<Student>() { firstStudent, secondStudent, thirdStudent, fourthStudent };
            Course course = new Course("C# Part 4", students);

            string actual = course.ToString();

            StringBuilder builder = new StringBuilder();
            builder.AppendLine("* * * Course name: C# Part 4 * * *");
            builder.AppendLine(firstStudent.ToString());
            builder.AppendLine(secondStudent.ToString());
            builder.AppendLine(thirdStudent.ToString());
            builder.AppendLine(fourthStudent.ToString());
            string expected = builder.ToString();

            Assert.AreEqual(expected, actual);
        }
    }
}