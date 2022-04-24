using System;

namespace CSharpCalculator
{
    class Calculator
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Hello World");

            int num1;
            int num2;

            num1 = Console.Read();
            num2 = Console.Read();

            System.Console.WriteLine(num1 + num2);
        }
    }
}