namespace SchoolProject
{
    using System;

    public class Student
    {
        private string firstName;
        private string lastName;
        private uint uniqueClassNumber;

        public Student(string firstName, string lastName, uint uniqueClassNumber)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.UniqueClassNumber = uniqueClassNumber;
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("First name cannot be empty!");
                }

                this.firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Last name cannot be empty!");
                }

                this.lastName = value;
            }
        }

        public uint UniqueClassNumber
        {
            get
            {
                return this.uniqueClassNumber;
            }

            set
            {
                if (value < 10000 || value > 99999)
                {
                    throw new ArgumentException("Invalid unique class number! Unique class number of " + this.FirstName + " " + this.LastName + " should be > 10000 and < 99999.");
                }

                this.uniqueClassNumber = value;
            }
        }

        public override string ToString()
        {
            string result = string.Format("({0} {1}, {2})", this.FirstName, this.LastName, this.UniqueClassNumber);
            return result;
        }
    }
}