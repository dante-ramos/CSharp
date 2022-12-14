//https://www.hackerrank.com/challenges/one-week-preparation-kit-lonely-integer/problem?isFullScreen=true&h_l=interview&playlist_slugs%5B%5D=preparation-kits&playlist_slugs%5B%5D=one-week-preparation-kit&playlist_slugs%5B%5D=one-week-day-two
using System;
using System.Collections.Generic;

namespace Ex1lonelyinteger
{
    // find the unique element in a list of integer where all the numbers are twice but one
    class Program
    {
        static void Main(string[] args)
        {
            List<int> a = new List<int>(new int[]{1,2,3,4,3,2,1});

            Console.WriteLine(lonelyinteger(a));

            a = new List<int>(new int[]{34,95,34,64,45,95,16,80,80,75,3,25,75,25,31,3,64,16,31});

            Console.WriteLine(lonelyinteger(a));
        }

        /*
        * Complete the 'lonelyinteger' function below.
        *
        * The function is expected to return an INTEGER.
        * The function accepts INTEGER_ARRAY a as parameter.
        */

        public static int lonelyinteger(List<int> a)
        {
            int     ret; // hold the returning value

            int     listSize; // hold the list size in order to not to size it each time this informatio is needed

            // ;

            ret = -1; // returns -1 in case of no repeated number is found
            listSize = a.Count; // get the count of elements

            a.Sort(); // arranges the list so same numbers are grouped
            
            // for each element validate if it's the same than the following, if no then return if yes jump one position to check the next couple
            for(int i = 0 ; i < listSize ; i++)
            {
                if( i == listSize -1 )
                {
                    ret = a[i];
                    break;
                }
                else if( a[i] != a[i+1] )
                {
                    ret = a[i];
                }
                else 
                {
                    i++;
                }
            }

            return ret;
        }
    }
}
