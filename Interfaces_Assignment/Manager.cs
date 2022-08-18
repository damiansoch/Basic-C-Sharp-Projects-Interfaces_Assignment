using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces_Assignment
{
    class Manager : Employee, IQuittable
    {

        public string Section { get; set; }
    }
}
