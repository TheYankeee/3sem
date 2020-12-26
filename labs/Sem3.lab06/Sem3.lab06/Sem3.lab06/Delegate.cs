using System;
using System.Collections.Generic;
using System.Text;

namespace Sem3.lab06
{
    class Delegate
    {
        static public int Multiply(int a, int b)
        {
            return a * b;
        }
        static public double Division(double a, double b)
        {
            return a / b;
        }

        static public int Calculate(int a, int b, TwoVarsOperations<int> operation)
        {
            return operation(a, b);
        }

        static public int CalculateFunc(int a, int b, Func<int, int, int> operation)
        {
            return operation(a, b);
        }


    }
}
