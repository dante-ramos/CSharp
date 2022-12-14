using System;
using System.Collections;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace turing
{
    class Program
    {
        static void Main(string[] args)
        {
            Program thisClassObj;
            string[] ops;

            // ;

            thisClassObj = new Program();

            // ops = new string[]{"5","2","C","D","+"};

            // Console.WriteLine(thisClassObj.CalPoints(ops));

            foreach(string value in thisClassObj.moves("...."))
            {
                Console.Write(value + " ; ");
            }

            Console.WriteLine();

            foreach(string value in thisClassObj.moves("..-.."))
            {
                Console.Write(value + " ; ");
            }

            Console.WriteLine();

            foreach(string value in thisClassObj.moves("----"))
            {
                Console.Write(value + " ; ");
            }

            Console.WriteLine("*--..--");

            foreach(string value in thisClassObj.moves("--..--"))
            {
                Console.Write(value + " ; ");
            }

            Console.WriteLine("*...--..-...");

            foreach(string value in thisClassObj.moves("...--..-..."))
            {
                Console.Write(value + " ; ");
            }
        }

        private int CalPoints(string[] ops)
        {
            int ret; // holds the final result, sum of the points list
            List<int>  points; // holds all the calculated points

            // ;

            ret = 0;
            points = new List<int>();

            // walk ops
            foreach(string value in ops)
            {
                if( Regex.IsMatch(value, @"^\d+$") ) // is number
                {
                    points.Add(int.Parse(value));
                }
                else if( value == "+" )
                {
                    points.Add(points[points.Count -1] + points[points.Count -2]);
                }
                else if( value == "D" )
                {
                    points.Add(points[points.Count - 1] * 2);
                }
                else if( value == "C" )
                {
                    points.RemoveAt(points.Count - 1);
                }
            }
            
            // sum all points in list
            foreach(int value in points)
            {
                ret += value;
            }

            return ret;
        }

        private IList<string> moves(string input)
        {
            IList<string> ret = new List<string>();

            string frontPart;
            string trailingPart;

            int i = 0;
            int posOfOccur;

            // for( int i = 0; i < input.Length ; i++ )
            // {
            //     frontPart = input.Substring(0, i);

            //     trailingPart = input.Substring(i);

            //     if (trailingPart.Contains(".."))
            //     {
            //         trailingPart = trailingPart.Remove(trailingPart.IndexOf("..")) + "--" + trailingPart.Substring(trailingPart.IndexOf("..") + 2);
            //         ret.Add(frontPart + trailingPart);
            //     }
            // }

            do
            {
                frontPart = input.Substring(0, i);

                trailingPart = input.Substring(i);

                posOfOccur = trailingPart.IndexOf("..");
                if( posOfOccur >= 0 )
                {
                    ret.Add(frontPart + trailingPart.Substring(0, posOfOccur) + "--" + trailingPart.Substring(posOfOccur + 2));
                    i = posOfOccur + 1 + frontPart.Length;
                }
                
            } while (i < input.Length && trailingPart.Contains(".."));

            return ret;
        }
    }
}
