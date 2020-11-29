using System;
using System.Collections.Generic;
using System.Text;
namespace Delegate
{
    class Operation
    {
        public static void Add(int a, int b)
        {
            Console.WriteLine("A+B" + " " + (a + b));
        }
        public static void Mul(int a, int b)
        {
            Console.WriteLine("A*B" + " " +(a * b));
        }
    }
}
