using System;
using System.Collections.Generic;
using System.Linq;

namespace RepresentationsOfLinq
{
    class Program
    {
        string[] stringArray = { "One Plus", "Nokia", "Oppo", "Apple Iphone", "Samsung", "Xiomi Mi", "Xiomi Redmi" };
        public bool containsRequired(string inObj) { return inObj.Contains(" ");}//targets
        public string selectFromThis(string inObj) { return inObj; }//targets
        static void Main(string[] args)
        {
            Program program = new Program();
            program.QueryOperators();
            program.ExtensionMethods();
            program.ExtensionMethodsWithSteps();
            program.ExtensionMethodsWithDelegatesAnoynomous();
            program.ExtensionMethodsWithDelegateCreated();


            Console.ReadLine();
        }

        private void ExtensionMethodsWithDelegateCreated()
        {
            Console.WriteLine("Extension methods with self created methods feeding to raw delegate");
            Func<string, bool> containsSpace = new Func<string, bool>(containsRequired); //feeding target here
            Func<string, string> selectingRes = new Func<string, string>(selectFromThis); //feeding target here

            IEnumerable<string> res = stringArray.Where(containsSpace).Select(selectingRes);

            foreach (string phoneWithSpace in res)
            {
                Console.WriteLine(phoneWithSpace);
            }


        }

        private void ExtensionMethodsWithDelegatesAnoynomous()
        {
            Console.WriteLine("With Extension Methods with delegates and anoynoumus methods");

            Func<string, bool> containsSpace = delegate (string phone) { return phone.Contains(" "); };
            Func<string, string> selectingRes = delegate (string containSp) { return containSp; };

            IEnumerable<string> res = stringArray.Where(containsSpace).Select(selectingRes);

            foreach (string phoneWithSpace in res)
            {
                Console.WriteLine(phoneWithSpace);
            }
        }

        private void ExtensionMethodsWithSteps()
        {
            Console.WriteLine("With Extension Methods in chunks");

            IEnumerable<String> whereRes = stringArray.Where(inObj => inObj.Contains(" "));
            IEnumerable<string> orderRes = whereRes.OrderByDescending(g=>g);
            IEnumerable<string> res = orderRes.Select(inObj => inObj);

            foreach (string phoneWithSpace in res)
            {
                Console.WriteLine(phoneWithSpace);
            }

        }

        private void ExtensionMethods()
        {
            Console.WriteLine("With Extension Methods");
            IEnumerable<String> res = stringArray.Where((inObj) => { return inObj.Contains(" "); }).Select(inObj => inObj);
            /*
             * Where((inObj) => { return inObj.Contains(" "); }) 
             * here we are using lambda expression to satisfy delegate 
             * actually it takes delegate which has string asinput an string as return type
             * by default it takes Func<Targ,Tresult>
             * we can create our own delegate to satisfy it
             * lets first try each method calling separately like first where then select
             */

            foreach (string phoneWithSpace in res)
            {
                Console.WriteLine(phoneWithSpace);
            }

        }

        private void QueryOperators()
        {
            Console.WriteLine("With Query Operators");

            IEnumerable<String> res = from phone in stringArray
                                      where phone.Contains(" ")
                                      select phone;
            foreach(string phoneWithSpace in res)
            {
                Console.WriteLine(phoneWithSpace);
            }
        }
    }
}
///<summary>
///•	 Query expressions are created using various C# query operators.
///•	 Query operators are simply shorthand notations for invoking extension methods
///      defined by the System.Linq.Enumerable type.
///•	 Many methods of Enumerable require delegates (Func<> in particular) as parameters.
///•	 Any method requiring a delegate parameter can instead be passed a lambda
///      expression.
///•	 Lambda expressions are simply anonymous methods in disguise (which greatly
///      improve readability).
///•	 Anonymous methods are shorthand notations for allocating a raw delegate and
///      manually building a delegate target method.
/// 
/// </summary>