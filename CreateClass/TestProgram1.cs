using System;

namespace CreateClass
{
    public class TestProgram1
    {
        
        static void Main(string[] args)
        {
            Employee Kovacs = new Employee("Géza", DateTime.Now, Person.Genders.Male, 1000, "léhűtő");
            Kovacs.Room = new Room(111);
            Employee Kovacs2 = (Employee)Kovacs.Clone();
            Kovacs2.Room.RoomNumber = 112;
            Console.WriteLine(Kovacs.ToString());
            Console.WriteLine(Kovacs2.ToString());
            Console.ReadKey();
        }
    }
}
