using System;
using System.Collections.Generic;
using System.Linq;

namespace CHomework
{
    public class Program
    {
        static void Main(string[] args)
        {
            var arrList = new List<int> { 1, 23, 9, 7, 4 };

            Console.WriteLine(string.Join(" ", Program.StructuredArray(arrList)));
            Console.WriteLine(Program.Median(arrList));
            Console.ReadLine();
        }
        public static List<int> StructuredArray(List<int> arr)
        {
            if (!arr.Contains(0))
            {
                return arr;
            }

            var numbers = arr.Where(num => num > 0).ToList();
            var step = arr.Count - numbers.Count;
            for (int i = 0; i < step; i++)
            {
                numbers.Add(0);
            }
            return numbers;
        }

        public static double Median(List<int> arr)
        {
            arr.Sort();

            if (arr.Count % 2 == 0)
            {
                //return (arr[arr.Count / 2] + arr[(arr.Count / 2) - 1]) / 2;
                return Math.Round((double)(arr[arr.Count / 2] + arr[(arr.Count / 2) - 1]) / 2, 2);
            }
            else
            {
                return arr[arr.Count / 2];
            }
        }
    }
}
