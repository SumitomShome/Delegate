using System;
namespace Delegate
{
    public delegate void MyDelegate(string msg); 
    class Program
    {
        public delegate void MyDelegate(int a, int b);
        static void Main(string[] args)
        {
            MyDelegate[] delegates =
            {
                new MyDelegate(Operation.Add),
                new MyDelegate(Operation.Mul)
            };
            for(int i = 0; i< delegates.Length; i++)
            {
                delegates[i](2,2);
                delegates[i](4,4);
            }
            Console.ReadKey();
        }
    }
}
