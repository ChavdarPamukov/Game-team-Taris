using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06NumberCalculation
{
    class NumberCalculation
    {
        static void Main(string[] args)
        {
            string numbers = Console.ReadLine();
            double[] arr = numbers.Split().Select(double.Parse).ToArray();
            Console.WriteLine(min(arr));
            Console.WriteLine(max(arr));
            Console.WriteLine(sum(arr));
            Console.WriteLine(average(arr));
            Console.WriteLine(product(arr));

           
        }
        private static double min(double[] arr)
        {
            double min = double.MaxValue;
            for (int i = 0; i < arr.Length; i++)
                if (arr[i] < min)
                    min = arr[i];
            return min;
        }

        private static double max(double[] arr)
        {
            double max = double.MinValue;
            for (int i = 0; i < arr.Length; i++)
                if (arr[i] > max)
                    max = arr[i];
            return max;

        } 
        private static double sum(double[] arr)
        {
            double result = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                result += arr[i];
            }
            return result;
        }

        private static double average(double[] arr)
        {
            if (arr.Length == 0) 
                return 0.00;
            return ((double)sum(arr)) / arr.Length;
        }

       

        private static double product(double[] arr)
        {
            double result = 1;
            for (int i = 0; i < arr.Length; i++)
            {
                result *= arr[i];
            }
            return result;
        }
           
        }
    }

