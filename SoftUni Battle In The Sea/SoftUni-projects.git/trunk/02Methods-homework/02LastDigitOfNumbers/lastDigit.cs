using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02LastDigitOfNumbers
{
    class lastDigit
    {
         static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            lastDigitOfNumber(n);
        }
        static string[] number = { "zero", "one", "two", "three", "four", "five",
                              "six", "seven", "eight", "nine"};

        static void lastDigitOfNumber(int n)
        {
            int lastDigit = n % 10;
            Console.WriteLine(number[lastDigit]);
        }
      
    }
}

