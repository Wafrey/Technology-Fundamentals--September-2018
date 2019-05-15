﻿namespace P03_BigFactorial
{
    using System;
    using System.Numerics;

    public class Program
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            BigInteger factorial = 1;

            for (int i = 2; i <= number; i++)
            {
                factorial *= i;
            }

            Console.WriteLine(factorial);
        }
    }
}
