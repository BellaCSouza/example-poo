using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamplePOO.Models
{
    public class Current : Account
    {
        public override void Credit(decimal amount)
        {
            balance += amount;
        }
    }
}