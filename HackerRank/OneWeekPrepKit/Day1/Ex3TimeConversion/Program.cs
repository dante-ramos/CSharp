// https://www.hackerrank.com/challenges/one-week-preparation-kit-time-conversion/problem?isFullScreen=true&h_l=interview&playlist_slugs%5B%5D=preparation-kits&playlist_slugs%5B%5D=one-week-preparation-kit&playlist_slugs%5B%5D=one-week-day-one

using System;

namespace Ex3TimeConversion
{
    // Program shoud convert from AM/PM time to a 24 hour time, 12 AM will be 00 and 12 PM will be 12
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(timeConversion("12:01:00PM"));

            Console.WriteLine(timeConversion("12:01:00AM"));

            Console.WriteLine(timeConversion("11:55:00AM"));
            
            Console.WriteLine(timeConversion("05:08:00PM"));
        }

        /*
        * Complete the 'timeConversion' function below.
        *
        * The function is expected to return a STRING.
        * The function accepts STRING s as parameter.
        */

        public static string timeConversion(string s)
        {
            string ret;
            bool isPM;
            bool is12;

            int pmHours;

            // ;

            // if time is PM, we should increate the hours in 12 (unless is 12 PM)
            isPM = s.EndsWith("PM");

            // is 12 hours (should do different things if AM or PM)
            is12 = s.StartsWith("12");

            // remove time AM/PM
            ret = s.Substring(0, s.Length-2);

            // if is 12 AM, decrease by 12
            if(is12 && !isPM)
            {
                ret = "00" + ret.Substring(2);
            }

            // if is not 12 PM, increase by 12
            if( isPM )
            {
                if( !is12 )
                {
                    pmHours = int.Parse(ret.Substring(0, 2)) + 12;
                    ret = pmHours.ToString() + ret.Substring(2);
                }
            }

            return ret;
        }
    }
}
