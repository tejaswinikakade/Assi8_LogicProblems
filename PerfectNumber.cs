using System;
using System.Collections.Generic;
using System.Text;

namespace AssigmentDay6
{
    class PerfectNumber
    {
        public static void GetPerfectNum()
        {
            int number;
            int sum = 0;
            int n;

            Console.WriteLine("Enter the numberTO Check Perfect or not :");
            number = Convert.ToInt32(Console.ReadLine());
            n = number;

            for (int i = 1; i < number; i++)
            {
                if (number % i == 0)
                {
                    sum = sum + i;
                }
            }

            if (sum == n)
            {
                Console.WriteLine("The entered number is a perfect number");
            }
            else
            {
                Console.WriteLine("The entered number is not a perfect number");
            }
        }
    }
}
