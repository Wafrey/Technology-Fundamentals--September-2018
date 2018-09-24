using System;

namespace Print_and_sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = first; i <= second; i++)
            {
                Console.Write($"{i} ");
                sum += i;

            }
            Console.WriteLine();
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
