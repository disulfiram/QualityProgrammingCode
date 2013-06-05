using System;

class Person
{
    public Gender Gender { get; set; }

    public string PersonName { get; set; }

    public int Age { get; set; }

    public void MakePerson(int personalMagicNumber)
    {
        Person newPerson = new Person();
        newPerson.Age = personalMagicNumber;
        if (personalMagicNumber % 2 == 0)
        {
            newPerson.PersonName = "Батката";
            newPerson.Gender = Gender.Male;
        }
        else
        {
            newPerson.PersonName = "Мацето";
            newPerson.Gender = Gender.Female;
        }
    }
}