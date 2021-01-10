using System;

namespace FindLongestArray
{
    class Program
    {
        static void Main(string[] args)
        {
            //<<<<  ---------------- Examples ------->>>>>>>>>>
            //Input : [1,2,3,4,7,8,9,10,11]
            //Ans   : [7,8,9,10,11]

            //<<<<  ---------------- Problem ------->>>>>>>>>>
            //Given an array, find the longest sequence.

            //<<<<  ---------------- My Soultion ------->>>>>>>>>>
            //int[] arrayInput = new int[] { 1, 2, 3, 4, 7, 8, 9, 10, 11 };
            //int[] arrayInput = new int[] { 1, 2, 3, 4, 5, 8, 9, 10, 11 };
            int[] arrayInput = new int[] { 1, 2, 3, 4, 5, 8, 9, 12, 13, 14, 15, 16, 17 };

            var str = "";
            for (int i = 0; i < arrayInput.Length; i++)
            {
                if ((i + 1) == arrayInput.Length)
                {
                    if (arrayInput[i] > arrayInput[i - 1] && arrayInput[i] - arrayInput[i - 1] == 1)
                    {
                        str += arrayInput[i];
                    }
                }
                else if (arrayInput[i] < arrayInput[i + 1] && arrayInput[i + 1] - arrayInput[i] == 1)
                {
                    str += arrayInput[i] + ",";
                }
                else if (arrayInput[i] > arrayInput[i - 1] && arrayInput[i] - arrayInput[i - 1] == 1)
                {
                    str += arrayInput[i] + ",";
                    str += "-";
                }
            }

            var computedArray=str.Split("-");
            int previosCounter = 0; string setValue = "";
            foreach (var item in computedArray)
            {
                int length=item.Split(",", StringSplitOptions.RemoveEmptyEntries).Length;
                if (length > previosCounter)
                {
                    previosCounter = length;
                    setValue = item;
                }
            }
            Console.WriteLine($"Highest Sequence is {setValue} and its length is {previosCounter}");
        }


        
    }
}
