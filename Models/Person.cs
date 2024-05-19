using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamplePOO.Models
{
    public class Person
    {
        public Person(string name)
        {
            Name = name;
        }

        public Person()
        {
            
        }
        
        public string Name { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }

        public virtual void Introduce() { //virtual pode ser sobreescrito
            Console.WriteLine($"Hello! My name is {Name} and I have {Age} years old!");
        }
    }
}