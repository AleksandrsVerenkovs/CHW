using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CHW
{
    public class CsharpTasks
    {
        public static List<int> StructuredArray(List<int> arr)
        {
            if (!arr.Contains(0))
            {
                return arr;
            }

            var numbers = arr.Where(num => num > 0).ToList();
            for (int i = 0; i < arr.Count - numbers.Count; i++)
            {
                numbers.Add(0);
            }
            return numbers;
        }

        public static double Median(List<int> arr)
        {
            if (arr.Count == 1)
            {
                return arr[0];
            }
            if (arr.Count == 0)
            {
                return 0;
            }

            arr.Sort();

            if (arr.Count % 2 == 0)
            {
                return Math.Round((double)(arr[arr.Count / 2] + arr[(arr.Count / 2) - 1]) / 2, 2);
            }
            else
            {
                return arr[arr.Count / 2];
            }
        }
    }
}
