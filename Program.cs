using System;

namespace ExampleUsingDelegates
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine(">Starting.");
            Calculate();
            System.Console.WriteLine(">Ended...");
        }

        private static void Calculate()
        {
            System.Console.WriteLine("Please enter a number:");
            var left = int.Parse(Console.ReadLine());
            System.Console.WriteLine("Please enter another number:");
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