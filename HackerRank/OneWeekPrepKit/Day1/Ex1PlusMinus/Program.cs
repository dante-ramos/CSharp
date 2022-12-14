// https://www.hackerrank.com/challenges/one-week-preparation-kit-plus-minus/problem?isFullScreen=true&h_l=interview&playlist_slugs%5B%5D=preparation-kits&playlist_slugs%5B%5D=one-week-preparation-kit&playlist_slugs%5B%5D=one-week-day-one

using System;
using System.Collections.Generic;

namespace Ex1PlusMinus
{
    // Requirement is, print the rate of the following three groups: positive numbers, negative numbers and zeros, present in the inputed list
    class Program
    {
        static void Main(string[] args)
        {
            Program thisClassObj = new Program();

            List<int> list = new List<int>(new int[]{1,1,0,-1,-1});
            Console.WriteLine(String.Join(',', list));
            plusMinus(list);

            list = new List<int>(new int[]{0,-1,-1});
            Console.WriteLine(String.Join(',', list));
            plusMinus(list);
            
            list = new List<int>(new int[]{1,1,0});
            Console.WriteLine(String.Join(',', list));
            plusMinus(list);

            list = new List<int>(new int[]{1,1,-1,-1});
            Console.WriteLine(String.Join(',', list));
            plusMinus(list);
        }

        /*
        * Complete the 'plusMinus' function below.
        *
        * The function accepts INTEGER_ARRAY arr as parameter.
        */
        public static void plusMinus(List<int> arr)
        {
            // will hold the countings of each category
            int count0 = 0;
            int countPos = 0;
            int countNeg = 0;

            // hold the total elements in inputed list
            int countTotal = arr.Count;

            // for each element in inputed list, increase the counting of each category as needed
            foreach(int value in arr)
            {
                if( value < 0 )
                    countNeg++;
                else if( value == 0 )
                    count0++;
                else
                    countPos++;
            }

            // print each category rate;
            // print positives
            printRateFormated(countTotal, countPos);

            // print negatives
            printRateFormated(countTotal, countNeg);

            // print zeros
            printRateFormated(countTotal, count0);
        }

        private static void printRateFormated(int totalCount, int groupCount)
        {
            // will hold each rate calculation
            float rate;

            rate = (float)groupCount / totalCount;
            Console.WriteLine(rate.ToString("0.000000"));
        }
    }
}
