using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExamplePOO.Interfaces;

namespace ExamplePOO.Models
{
    public class Calculator : ICalculator
    {
        public int Mul(int num1, int num2)
        {
            return num1 * num2;
        }

        public int Sub(int num1, int num2)
        {
            return num1 - num2;
        }

        public int Sum(int num1, int num2)
        {
            return num1 + num2;
        }
    }
}