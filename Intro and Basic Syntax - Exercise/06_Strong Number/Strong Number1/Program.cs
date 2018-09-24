using System;

namespace Strong_Number1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, n1, s1 = 0, j, k, sn;
            int fact;


            sn = Convert.ToInt32(Console.ReadLine());



            for (k = sn; k <= sn; k++)
            {
                n1 = k;
                s1 = 0;

                for (j = k; j > 0; j = j / 10)
                {

                    fact = 1;
                    for (i = 1; i <= j % 10; i++)
                    {
                        fact = fact * i;
                    }
                    s1 = s1 + fact;
                }

                if (s1 == n1)
                {

                    Console.Write("yes");
                }
                else
                {
                    Console.WriteLine("no");
                }

            }
        }
    }
}

