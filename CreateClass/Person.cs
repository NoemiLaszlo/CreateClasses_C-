using System;

namespace CreateClass
{
    public class Person
    {
        public enum Genders
        {
            Male,
            Female
        }

        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public Genders Gender { get; set; }

        public Person(string name, DateTime birthDate, Genders gender)
        {
            Name = name;
            BirthDate = birthDate;
            Gender = gender;

        }

        public override string ToString()
        {
            return ("Name: " + Name + 
                    " " + "Date of birth: " + BirthDate + 
                    " " + "Gender: " + Gender);
        }

    }
}
