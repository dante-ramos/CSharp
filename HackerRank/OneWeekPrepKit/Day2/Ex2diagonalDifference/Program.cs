using System;
using System.Collections.Generic;

namespace Ex2diagonalDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            List<List<int>> arr = new List<List<int>>();

            arr.Add(new List<int>(new int[]{11,2,4}));
            arr.Add(new List<int>(new int[]{4,5,6}));
            arr.Add(new List<int>(new int[]{10,8,-12}));

            Console.WriteLine(diagonalDifference(arr));
        }

        /*
        * Complete the 'diagonalDifference' function below.
        *
        * The function is expected to return an INTEGER.
        * The function accepts 2D_INTEGER_ARRAY arr as parameter.
        */

        public static int diagonalDifference(List<List<int>> arr)
        {
            int     ret;

            int     sumDiag1, sumDiag2;

            int     arrLenght;

            // ;

            ret = sumDiag1 = sumDiag2 = 0;

            arrLenght = arr[0].Count;

            for( int i = 0 ; i < arrLenght ; i ++ )
            {
                sumDiag1 += arr[i][i];
                sumDiag2 += arr[i][arrLenght-1-i];
            }

            ret = Math.Abs(sumDiag1 - sumDiag2);

            return ret;
        }
    }
}
