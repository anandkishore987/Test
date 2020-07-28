using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test4
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = new int[] { 1,2,3,4,6,7,8,9,10};
            var input1 = new int[] { 1, 2, 3, 4, 5,6, 7, 8, 9, 10 };
            var input2 = new int[] { 1, 2, 3, 4, 5,6, 7, 8, 9, 10 };
            var input3 = new int[] { 1, 2, 3, 4, 5,6, 7, 8, 9, 10 };

            int n = 10;
            var result = FindMissingNumer(input, n);
            Console.WriteLine(result);
            Console.ReadKey();
        }

        public static  int FindMissingNumer(int[] nums, int n)
        {
            int result = 0;
            if (nums != null && n > 0)
            {
                var length = nums.Length;
                var TotalSum = n * (n + 1) / 2;
                int sumOfArray = 0;

                for (var i = 0; i < length; i++)
                {
                    sumOfArray = sumOfArray + nums[i];
                }
                result = TotalSum - sumOfArray;
            }

            return result;
        }
    }
}
