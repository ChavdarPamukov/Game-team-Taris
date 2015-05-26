using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05ReverseNumbers
{
    class reverseNumbers
    {
        static void Main(string[] args)
        {
            double num = double.Parse(Console.ReadLine());
            Console.WriteLine(GetReversedNumber(num));
        }
        private static double GetReversedNumber(double number)
        {
           char[] arr = number.ToString().ToCharArray();
            Array.Reverse(arr);
            return Convert.ToDouble(new string(arr));


        }
    }
}
