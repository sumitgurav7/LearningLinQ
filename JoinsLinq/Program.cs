using System;
using System.Collections.Generic;
using System.Linq;

namespace joiningArray
{
    class Program
    {
        //int[] numbers = { 8, 6, 9, 5, 4, 3, 7, 2, 1, 8, 0 };
        //string[] numbersString = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
        static void Main(string[] args)
        {
            int[] numbers = { 8, 6, 9, 5, 4, 3, 7, 2, 1, 8, 0 };
            string[] numbersString = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            IEnumerable<string> numbersInSTring = from number in numbers
                                                  select numbersString[number];
                                                  
            foreach(string str in numbersInSTring)
            {
                Console.Write(str + " ");
            }
        }
    }
}
