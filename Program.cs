using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Test4
{
    public delegate int Sum(int[] nums);
    class Program
    {

        static void Main(string[] args)
        {
            var input = new int[] { 1,2,3,4,6,7,8,9,10};
            //var input1 = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //var input2 = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //var input3 = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //int n = 10;
            //var result = FindMissingNumer(input, n);
            //Console.WriteLine(result);
            //Console.ReadKey();

            //Thread th = new Thread(new ThreadStart(SumOfNumber(input)));
            //th.Start();

            new Thread((o => {
                var sum = SumOfNumber(input);
            })).Start();

            new Thread((o => {
                var sum = AverageOfNumber(input);
            })).Start();
            new Thread((o => {
                var sum = ListOfOdds(input);
            })).Start();



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

        public static int SumOfNumber(int[] nums)
        {
            int sum = 0;
            for(int i =0; i < nums.Length; i++)
            {

                sum += nums[i];
            }
            return sum;
        }

        public static int AverageOfNumber(int[] nums)
        {
            var sum = SumOfNumber(nums);
            var average = sum / nums.Length;
            return average;
        }

        public static int[] ListOfOdds(int[] nums)
        {
            var list = new List<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if(nums[i] % 2 != 0)
                {
                    list.Add(nums[i]);
                }
            }
            return list.ToArray();
        }

        //Define array of n numbers
        //comute sum of n & avarage & list of odd number

        //lagacy
        //read logs file from differnt machine (altron etc.) --> medical equiments (10-15)
        //


        //1. Create base Interface name as IMachineType
        //2. Create classes Parsing for MachineTypeLogs
        //3. Inherit IMachineType Log and check what kind of Log and pass it that particular class object.
        //4. 


    }

    public enum Types
    {
        UltraSound,
        MR,
        SonoGraphy
    }

    public interface IMachineType
    {
        void FromMachine(Types typeOfMachine);
    }

    class Filter : IMachineType
    {
        public Types type { get; set; }
        public void FromMachine(Types typeOfMachine)
        {
            switch (type)
            {
                case Types.MR:
                    new ProcessMRLogs();
                    break;

                case Types.UltraSound:
                    new ProcessUltraSoundLogs();
                    break;
            }
        }

        public class ProcessMRLogs
        {
            public ProcessMRLogs()
            {
                //Process Logs
            }
        }

        public class ProcessUltraSoundLogs
        {
            public ProcessUltraSoundLogs()
            {
                //Process Logs
            }
        }
    }
}
