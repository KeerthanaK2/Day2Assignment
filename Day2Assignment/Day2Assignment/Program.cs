using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            int j;
            bool notPrime = false;
            Console.WriteLine("Enter the min number:");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the max number:");
            int y = Convert.ToInt32(Console.ReadLine());
            for (int i = x; i <= y; i++)
            {
                for ( j = x; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        notPrime = true;
                        break;
                    }
                }

                if (!notPrime)
                    Console.Write("{0} ", j);
                else
                    notPrime = false;
            }

            Console.ReadLine();
            Console.WriteLine("Kayshini AJ");
        }
    }
}
