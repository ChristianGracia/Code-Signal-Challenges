﻿using System;
using System.Collections.Generic;

namespace DuplicateChecker
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a series of numbers seperated by a hyphen to check duplicates");
            string series = Console.ReadLine();

            string duplicateResult = DuplicateResult(series);
            Console.WriteLine(duplicateResult);
        }

        public static string DuplicateResult(string series)
        {
            string result = "no duplicates found";

            if (series == "")
            {
                result = "exit";
                return result;
            }

            int[] numberArray = series.Split("-");
            List<int> numberList = new List<int>();

            for (var i = 0; i < numberArray.Length - 1; i++)
            {
                if (numberList.Contains(Convert.ToInt32(numberArray[i])))
                    result = "duplicates found";

                numberList.Add(Convert.ToInt32(numberArray[i]));
            }


            return result;
        }
    }
}