﻿using System;

namespace SecondProgram
{
    class SecondProgram
    {
        static void Main(string[] args)
        {
            // int a = 5;
            // int b = 6;

            // if (a + b > 10)
            // {
            //     Console.WriteLine("The answer is greater than 10.");
            // }

            // bool something = a + b > 10;
            // if (something)
            //     Console.WriteLine("The answer is greater than 10.");
            // else
            //     Console.WriteLine("The answer is not greater than 10");

            // int a = 5;
            // int b = 6;
            // int c = 4;

            // if ((a + b + c > 10) && (a == b))
            // {
            //     Console.WriteLine("The answer is greater than 10");
            //     Console.WriteLine("And the first number is equal to the second number");
            // }
            // else
            // {
            //     Console.WriteLine("The answer is not greater than 10");
            //     Console.WriteLine("Or the first number is not equal to the second number");
            // }

            // int counter = 0;

            // while (counter < 10)
            // {
            //     Console.WriteLine($"Hello World! The counter is {counter}");
            //     counter++;
            // }

            // int counter = 10;

            // do
            // {
            //     Console.WriteLine($"Hello World! The counter is {counter}");
            //     counter++;
            // } while (counter < 10);

            // for (int i = 0; i < 10; i++)
            // {
            //     Console.WriteLine($"Hello World! The index is {i}");
            // }

            int sum = 0;

            for (int i = 1; i <= 20; i++)
            {
                if (i % 3 == 0)
                {
                    sum += i;
                }
            }

            System.Console.WriteLine(sum);
        }
    }
}