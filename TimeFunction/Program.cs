﻿using System;

namespace TimeFunction
{
    public class Program
    {
        // returns number of minutes between 2 times given hour and minutes
        public static int TimeBetween( int hr1, int min1, int hr2, int min2)
        {
            int totalMinutes = 0;

            int ttl1 = (hr1 % 12) * 60 + min1;
            int ttl2 = (hr2 % 12) * 60 + min2;

            totalMinutes = Math.Abs(ttl2 - ttl1);
            return totalMinutes;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("TimeFunction.Program.Main()");
        }
    }
}
