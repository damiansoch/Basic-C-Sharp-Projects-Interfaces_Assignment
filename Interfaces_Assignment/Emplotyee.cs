using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces_Assignment
{
    class Employee : Person, IQuittable
    {
        public override void SayName()
        {
            Console.WriteLine("Name: {0} {1} {2}", firstName, lastName, Quitting ? "is quitting" : "");
        }

        public void Quit()
        {
            // When Quit() function runs it assings bool "true" to Quitting variable (default "false") 
            Quitting = true;

            Console.WriteLine("Name: {0} {1} {2}", firstName, lastName, Quitting ? "is quitting" : "");

        }
    }
}
