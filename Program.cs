﻿using System;

namespace HackerRankPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("<--------------FizzBuzz--------------->");
            Console.WriteLine("Created by Morasiu (morasiu2@gmail.com)");

            for (int i = 1; i <= 100; i++)
            {
                if (i % 15 == 0) Console.Write("FizzBuzz");
                else if (i % 5 == 0) Console.Write("Buzz");
                else if (i % 3 == 0) Console.Write("Fizz");
                else Console.Write(i);
                Console.Write(",");
            }

            Console.ReadKey();

            var sum = 0;
            for (var idx = 1; idx <= 50; idx++)
            {
                if (idx % 7 == 0 || idx % 5 == 0)
                {
                    sum += idx;
                }
                return sum;
            }




        }
    }
}
