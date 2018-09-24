using System;

namespace Vending_Machine
{
    class Program
    {
        static void Main(string[] args)
        {
            

            decimal nutsPrice = 2.0m;
            decimal waterPrice = 0.7m;
            decimal crispsPrice = 1.5m;
            decimal sodaPrice = 0.8m;
            decimal cokePrice = 1.0m;

            decimal totalCoins = 0;

            while (true)
            {
                string read = Console.ReadLine();
                if (read == "Start")
                {
                    while (true)
                    {
                        string snacks = Console.ReadLine();

                        if (snacks == "End")
                        {
                            Console.WriteLine($"Change: {totalCoins:F2}");
                            return;
                        }
                        if (snacks == "Coke" || snacks == "Soda" || snacks == "Crisps" || snacks == "Water" || snacks == "Nuts")
                        {
                            if (snacks == "Coke" && totalCoins >= cokePrice)
                            {
                                totalCoins -= cokePrice;
                                Console.WriteLine("Purchased coke");
                                continue;
                            }
                            else if (snacks == "Soda" && totalCoins >= sodaPrice)
                            {
                                totalCoins -= sodaPrice;
                                Console.WriteLine("Purchased soda");
                                continue;
                            }
                            else if (snacks == "Crisps" && totalCoins >= crispsPrice)
                            {
                                totalCoins -= crispsPrice;
                                Console.WriteLine("Purchased crisps");
                                continue;
                            }
                            else if (snacks == "Water" && totalCoins >= waterPrice)
                            {
                                totalCoins -= waterPrice;
                                Console.WriteLine("Purchased water");
                                continue;
                            }
                            else if (snacks == "Nuts" && totalCoins >= nutsPrice)
                            {
                                totalCoins -= nutsPrice;
                                Console.WriteLine("Purchased nuts");
                                continue;
                            }
                            else
                            {
                                Console.WriteLine("Sorry, not enough money");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid product");
                        }
                    }
                }
                else if (decimal.Parse(read) == 0.1m || decimal.Parse(read) == 0.2m || decimal.Parse(read) == 0.5m || decimal.Parse(read) == 1m || decimal.Parse(read) == 2m)
                {
                    totalCoins += decimal.Parse(read);
                }
                else
                {
                    Console.WriteLine($"Cannot accept {read}");
                }
            }
        }
    }
}
