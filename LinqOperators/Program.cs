using System;
using System.Linq;
using System.Collections.Generic;


namespace LinqOperators
{
    class Program
    {
        ProductInfo[] productInfos = {
            new ProductInfo("OnePlus6T","In Screen FingerPrint",45,2018),
            new ProductInfo("MIA2","Android One",55,2018),
            new ProductInfo("PoCoF1","CopyCat Of Oneplus",23,2018),
            new ProductInfo("Redmi note 5","Affordable Beast",18,2017),
            new ProductInfo("Apple 7","Was Overpriced ***",5,2016),
            new ProductInfo("Apple X", "Is overpriced ***",38,2018)
        };
        static void Main(string[] args)
        {
            Program program = new Program();
            program.PrintAllProducts();
            program.LowStock();
            program.withHighStockAndLatest();
            program.ApplePhones();
            program.AnoynomousType();
            program.countingLatest();

            Console.ReadKey();
        }

        private void countingLatest()
        {
            Console.WriteLine(" latest Products count");
            int products = productInfos.Where((prod) => prod.Make == 2018).Count();

            //foreach (ProductInfo product in products)
            //{
                Console.WriteLine(products);
            //}
        }

        private void AnoynomousType()
        {
            Console.WriteLine("AnoynomousType");
            IEnumerable<object> products = from prod in productInfos
                                                where prod.Name.Contains("Apple")
                                                select new {prod.Name, prod.Stock };

            foreach (object product in products)
            {
                Console.WriteLine(product.ToString());
            }
        }

        private void ApplePhones()
        {
            Console.WriteLine("Iphones");
            IEnumerable<ProductInfo> products = from prod in productInfos
                                                where prod.Name.Contains("Apple")
                                                select prod;

            foreach (ProductInfo product in products)
            {
                Console.WriteLine(product);
            }
        }

        private void withHighStockAndLatest()
        {
            Console.WriteLine("High Stock and latest Products");
            IEnumerable<ProductInfo> products = from prod in productInfos
                                                where prod.Stock > 25 && prod.Make ==2018
                                                select prod;

            foreach (ProductInfo product in products)
            {
                Console.WriteLine(product);
            }
        }

        private void LowStock()
        {
            Console.WriteLine("Low Stock Products");
            IEnumerable<ProductInfo> products = from prod in productInfos
                                                where prod.Stock<25
                                                select prod;

            foreach (ProductInfo product in products)
            {
                Console.WriteLine(product);
            }
        }

        private void PrintAllProducts()
        {
            Console.WriteLine("All Products");
            IEnumerable<ProductInfo> products = from prod in productInfos
                                                select prod;

            foreach(ProductInfo product in products)
            {
                Console.WriteLine(product);
            }
        }
    }
}
