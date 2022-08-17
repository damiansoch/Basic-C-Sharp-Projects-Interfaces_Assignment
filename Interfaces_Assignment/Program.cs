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
            employe1.Quit();

            Console.ReadLine();
        }
    }
}
