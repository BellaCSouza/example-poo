using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamplePOO.Models
{
    public class Student : Person
    { // extends Person
       public double Grade { get; set; }
        public override void Introduce()
        {
            Console.WriteLine($"Hello! My name is {Name}, I'm {Age} and I'm a grade {Grade} student.");
        }
    }
}