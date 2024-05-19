using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamplePOO.Models
{
    public class Principal : Professor
    {
        public override void Introduce() {
            Console.WriteLine("Principal");
         }
    }
}