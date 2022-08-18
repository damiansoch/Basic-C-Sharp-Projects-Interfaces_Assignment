using System;

namespace Interfaces_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employe1 = new Employee();
            employe1.firstName = "Sample";
            employe1.lastName = "Student";

            employe1.SayName();
            employe1.Quit(employe1);

            Manager manager1 = new Manager();
            manager1.firstName = "Sample";
            manager1.lastName = "Manager";

            manager1.SayName();
            manager1.Quit(manager1);



            Console.ReadLine();
        }
    }
}
