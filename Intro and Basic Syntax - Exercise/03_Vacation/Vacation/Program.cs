using System;

namespace Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            string groupType = Console.ReadLine();
            string day = Console.ReadLine();

            double sum = 0;

            if (day == "Friday")
            {
                if (groupType == "Students")
                {
                    sum += 8.45;
                    if (number >= 30)
                    {
                        sum = sum - (sum * 0.15);
                    }
                }
                else if (groupType == "Business")
                {
                    sum += 10.90;
                    if (number >= 100)
                    {
                        sum = sum - (sum * 10);
                    }
                }
                else if (groupType == "Regular")
                {
                    sum += 15.00;
                    if (number >= 10 && number <= 20)
                    {
                        sum = sum - (sum * 0.05);
                    }
                }
            }
            else if (day == "Saturday")
            {
                if (groupType == "Students")
                {
                    sum += 9.80;
                    if (number >= 30)
                    {
                        sum = sum - (sum * 0.15);
                    }
                }
                else if (groupType == "Business")
                {
                    sum += 15.60;
                    if (number >= 100)
                    {
                        sum = sum - (sum * 10);
                    }
                }
                else if (groupType == "Regular")
                {
                    sum += 20;
                    if (number >= 10 && number <= 20)
                    {
                        sum = sum - (sum * 0.05);
                    }
                }
            }
            else if (day == "Sunday")
            {
                if (groupType == "Students")
                {
                    sum += 10.46;
                    if (number >= 30)
                    {
                        sum = sum - (sum * 0.15);
                    }
                }
                else if (groupType == "Business")
                {
                    sum += 16;
                    if (number >= 100)
                    {
                        sum = sum - (sum * 10);
                    }
                }
                else if (groupType == "Regular")
                {
                    sum += 22.50;
                    if (number >= 10 && number <= 20)
                    {
                        sum = sum - (sum * 0.05);
                    }
                }
            }

            Console.WriteLine($"Total price: {number * sum:F2}");
        }
    }
}
