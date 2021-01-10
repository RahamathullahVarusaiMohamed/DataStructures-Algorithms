using System;
using System.Collections.Generic;

namespace FindBalancedNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //<<<<  ---------------- Examples ------->>>>>>>>>>
            //7008007 ==> balanced
            //12340 ==> not balanced as 1 + 2 != 4 + 0
            //700 8  232 //7+0+0 == 2+3+2

            //<<<<  ---------------- Problem ------->>>>>>>>>>
            //Sum to Check the given number is balanced or not for both odd & even count
            //Rules : No In-Built function ex: Math log function or convert to string to find the middle value
            //Please note this works upto base 10

            //<<<<  ---------------- My Soultion ------->>>>>>>>>>
            int inputVal = 7008232;
            //Other Sample Values tested
            //int inputVal = 12340;
            //int inputVal = 11;
            //int inputVal = 212122110;
            //Temporary val to iterate & check count
            int tempVal = inputVal, count = 0;
            var inputArray = new List<int>();
            while (tempVal != 0)
            {
                //it adds the reverse numbers but still it should tally as per the requirement
                inputArray.Add(tempVal % 10);
                tempVal /= 10;
                ++count;
            }
            //Printing True If its balanced number with count
            Console.WriteLine($"Count : {count} number : {inputVal} and Is it balanced ? : {CheckIsBalanced(inputArray)}");
        }
        public static bool CheckIsBalanced(List<int> arr)
        {
            int centerVal = 0, plsOnefrOdd = 0;
            if (arr.Count % 2 > 0)
            {
                centerVal = (arr.Count / 2);
                plsOnefrOdd = 1;
            }
            if (arr.Count % 2 == 0)
                centerVal = (arr.Count / 2);

            int sum1 = 0, sum2 = 0;

            foreach (var item in arr.GetRange(0, (centerVal)))
            {
                sum1 += item;
            }
            foreach (var item in arr.GetRange(centerVal + plsOnefrOdd, (arr.Count - (centerVal + plsOnefrOdd))))
            {
                sum2 += item;
            }
            return sum1.Equals(sum2);
        }


    }
}
