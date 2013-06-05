namespace SchoolProject
{
    using System;

    public class TestProgram
    {
        static void Main(string[] args)
        {
            Course oop = new Course("OOP");
            Student studentToBeRemoved = new Student("Big Bad", "Wolf", 11111); 
            oop.AddStudent(new Student("Mickey", "Maus", 56788));
            oop.AddStudent(new Student("Bugs", "Bunny", 71245));
            oop.AddStudent(studentToBeRemoved);
            oop.AddStudent(new Student("Bruno", "The Dog", 33434));
            oop.RemoveStudent(studentToBeRemoved);

            School telerikAcademy = new School("Telerik Academy");
            telerikAcademy.AddCourse(oop);
            Console.WriteLine(telerikAcademy.ToString());
        }
    }
}