using System;
using System.Collections.Generic;
using System.Linq;

namespace ListAndLambda
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            list.AddRange(new int[] { 2, 55, 99, 66, 88, 75, 89 });
            List<int> evenNumbers = list.FindAll((i) => (i % 2) == 0);
            foreach(int i in evenNumbers)
            {
                Console.WriteLine(i);
            }

            

            Console.WriteLine("test with linq");

            IEnumerable<int> evenNumbersWithLinq = from num in list
                          where num % 2 == 0
                          select num;
            var a = list.Where((num) => num % 2 == 0);
            foreach(int num in a)
            {
                Console.WriteLine(num);
            }
            Console.ReadKey();
        }
    }
}
