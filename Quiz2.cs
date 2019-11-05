using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
        class SumOfDigits
        {
            public static void Main(String[] args)
            {
                Console.Write("Enter a number : ");
                int number = Convert.ToInt16(Console.ReadLine());
                int sum = 0;
                while (number != 0)
                {
                    sum += number % 10;
                    number /= 10; 
                }
                Console.Write("The result would be : {0} ", sum);

                Console.ReadKey();

            }
        }
    }
