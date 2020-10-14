using System;

namespace ExampleUsingDelegates
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculate();
        }

        private static void Calculate()
        {
            var left = int.Parse(Console.ReadLine());
            var right = int.Parse(Console.ReadLine());

            var sum = Sum(left, right);

            Print(sum);
        }

        private static int Sum(int a, int b)
        {
            return a + b;
        }

        private static int Product(int a, int b)
        {
            return a * b;
        }

        private static void Print(int result)
        {
            System.Console.WriteLine($"Result is {result}.");
        }
    }
}