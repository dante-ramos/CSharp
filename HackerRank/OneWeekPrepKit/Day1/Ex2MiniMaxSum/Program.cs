// https://www.hackerrank.com/challenges/one-week-preparation-kit-mini-max-sum/problem?isFullScreen=true&h_l=interview&playlist_slugs%5B%5D=preparation-kits&playlist_slugs%5B%5D=one-week-preparation-kit&playlist_slugs%5B%5D=one-week-day-one&h_r=next-challenge&h_v=zen

using System;
using System.Collections.Generic;

namespace Ex2MiniMaxSum
{
    // Calculate the minimum sum of 4 elements of the inputed list and the maximum sum of 4 elements of the inputed list, print them in a single line
    class Program
    {
        static void Main(string[] args)
        {
            List<int> arr = new List<int>(new int[]{1,3,5,7,9});
            Console.WriteLine(String.Join(',',arr));
            miniMaxSum(arr);

            arr = new List<int>(new int[]{256741038,623958417,467905213,714532089,938071625});
            Console.WriteLine(String.Join(',',arr));
            miniMaxSum(arr);
        }

        /*
        * Complete the 'miniMaxSum' function below.
        *
        * The function accepts INTEGER_ARRAY arr as parameter.
        */

        public static void miniMaxSum(List<int> arr)
        {
            // sort list to have lower number at the beggining and larger ar the end
            arr.Sort();

            // call sum method indicating the first 4 elements and then the last 4 elements
            Console.WriteLine(getSum(arr,0,4) + " " + getSum(arr,arr.Count -4, 4));
        }

        private static long getSum(List<int> arr, int startIndex, int numberOfElements)
        {
            long sum = 0;

            for(int i = startIndex ; i < startIndex + numberOfElements ; i++ )
            {
                sum += arr[i];
            }

            return sum;
        }
    }
}
