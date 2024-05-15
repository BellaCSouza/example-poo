using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamplePOO.Models
{
    public class Professor : Person
    {
         public decimal Salary { get; set; }
         public override void Introduce() {
            Console.WriteLine($"Hello! My name is {Name}, I'm {Age} and I earn R${Salary}");
         }
    }
}