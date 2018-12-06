using System;
using System.Collections.Generic;
using System.Linq;

namespace LearningLinQ
{
    class Program
    {
        static void Main(string[] args)
        {

            normalWhereWithIntArray();
            methodSyntaxWithString();


            Console.ReadKey();
        }

        private static void methodSyntaxWithString()
        {

            string[] stringArray = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten" };

            IEnumerable<string> stringLinq = stringArray.Where((str, index) => str.Length < index);

            Console.WriteLine("numbes which have shorter length than its value");
            foreach(string str in stringLinq)
            {
                Console.WriteLine("number {0} is shorter than its value",str);
            }
        }

        private static void normalWhereWithIntArray()
        {
            int[] intArray = new int[10];
            intArray = initializeArray(intArray);

            IEnumerable<int> test = from num in intArray
                                    where num == 1
                                    select num;
            foreach (int num in test)
            {
                Console.WriteLine(num);
            }

            IEnumerable<int> orderby = from num in intArray
                                       orderby num descending
                                       select num;
            foreach (int num in orderby)
            {
                Console.WriteLine(num);
            }
        }

        private static int[] initializeArray(int[] intArray)
        {
            for(int i = 0; i<intArray.Length; i++)
            {
                intArray[i] = i;
            }

            return intArray;
        }


    }
}
