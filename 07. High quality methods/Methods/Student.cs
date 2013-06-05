using System;

namespace Methods
{
    class Student
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string PlaceOfBirth { get; set; }

        public DateTime BirthDate { get; set; }
        
        public string OtherInfo { get; set; }

        public Student(string firstName, string lastName, string placeOfBirth, DateTime birthDate)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.PlaceOfBirth = placeOfBirth;
            this.BirthDate = birthDate;
        }

        public Student(string firstName, string lastName, string placeOfBirth, DateTime birthDate, string otherInfo) : this(firstName, lastName, placeOfBirth, birthDate)
        {
            this.OtherInfo = otherInfo;
        }

        public bool IsOlderThan(Student other)
        {
            bool result = this.BirthDate > other.BirthDate;

            return result;
        }
    }
}