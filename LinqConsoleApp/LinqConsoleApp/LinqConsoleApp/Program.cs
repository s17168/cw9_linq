using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace LinqConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var d = new LinqSamples();
            //d.Przyklad1();
            //d.Przyklad2();
            //d.Przyklad3();
            //d.Przyklad4();
            //d.Przyklad5();
            //d.Przyklad6();
            //d.Przyklad7();
            //d.Przyklad8();
            //d.Przyklad9();
            //d.Przyklad10Button_Click();
            //d.Przyklad11();
            d.Przyklad12();

/*
            // Przyklady z zajec:
            // 1. Anonymous types
            var anon = new
            {
                Imie = "Jan",
                Nazwisko = "Kow",
                Display = new Action(() => Console.WriteLine("aaa"))
            };
            anon.Display();

            // 2. Metody rozszerzen - extension methods
            // metody rozszerzen sa na koncu brane pod uwage gdy juz istnieje w tej klasie metoda o danej nazwie
            string str = "s123";
            if (str.IsCorrectIndex())
            {
                // ok
            }

            var list = new List<int> { 5, 3, 5, 2, 1, 1, 3 };
            var even = list.GetEvenNums();

            // 3. Wyrazenia Lambda
            list.GetSomeNums(n => n % 2 == 0);
            */

        }
    }


/*    public static class ExtensionMethods
    {
        public static bool IsCorrectIndex(this string input)
        {
            return input[0] == 's' && input.Length == 5;
        }

        public static IEnumerable<int> GetEvenNums(this IEnumerable<int> nums)
        {
            var list = new List<int>();
            foreach(var n in nums)
            {
                if (n % 2 == 0) list.Add(n);
            }
            return list;
        }

        // HOF - Higher Order Function
        public static IEnumerable<int> GetSomeNums(this IEnumerable<int> nums, Func<int, bool> predicate)
        {
            var list = new List<int>();
            foreach (var n in nums)
            {
               *//* if (...)
                {
                    list.Add(n);
                }*//*
            }
            return list;
        }
    }*/

}
