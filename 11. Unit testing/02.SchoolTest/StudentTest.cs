namespace SchoolTest
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using SchoolProject;

    [TestClass]
    public class StudentTest
    {
        [TestMethod]
        [ExpectedException(typeof (ArgumentException))]
        public void FirstNameNull()
        {
            Student student = new Student(null, "Smith", 99999);
            student.ToString();
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void LastNameNull()
        {
            Student student = new Student("John", null, 10000);
            student.ToString();
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void LastNameEmptyString()
        {
            Student student = new Student("John", string.Empty, 10000);
            student.ToString();
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void UniqueNumber25()
        {
            Student student = new Student("John", "Smith", 25);
            student.ToString();
        }

        [TestMethod]
        public void UniqueNumberMin()
        {
            uint number = 10000;
            Student student = new Student("John", "Smith", number);
            Assert.AreEqual(number, student.UniqueClassNumber);
        }

        [TestMethod]
        public void UniqueNumberMax()
        {
            uint number = 99999;
            Student student = new Student("John", "Smith", number);
            Assert.AreEqual(number, student.UniqueClassNumber);
        }

        [TestMethod]
        public void StudentToStringTest()
        {
            string firstName = "Bugs";
            string lastName = "Bunny";
            uint number = 12528;
            Student student = new Student(firstName, lastName, number);
            string actual = student.ToString();
            string expected = string.Format("({0} {1}, {2})", firstName, lastName, number);
            Assert.AreEqual(expected, actual);
        }
    }
}