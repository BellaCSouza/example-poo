using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamplePOO.Interfaces
{
    public interface ICalculator
    {
        int Sum(int num1, int num2);
        int Sub(int num1, int num2);
        int Mul(int num1, int num2);

        int Split(int num1, int num2) {
            return num1 / num2;
        }
    }
}