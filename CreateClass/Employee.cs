using System;

namespace CreateClass
{
    class Employee : Person, ICloneable
    {
        public int Salary { get; set; }
        public string Profession { get; set; }
        public Room Room;

        public Employee(string name, DateTime birthDate, Genders gender, int salary, string profession) : base(name, birthDate, gender)
        {
            Salary = salary;
            Profession = profession;
        }

        public override string ToString()
        {
            return ("Name: " + Name + 
                    " " + "Date of birth: " + BirthDate + 
                    " " + "Gender: " + Gender +
                    " " + "Salary: " + Salary +
                    " " + "Profession: " + Profession +
                    " " + "Room number: " + Room.RoomNumber);
        }

        public object Clone()
        {
            Employee newEmployee = (Employee)this.MemberwiseClone();
            newEmployee.Room = new Room(Room.RoomNumber);
            return newEmployee;
        }
    }
}
