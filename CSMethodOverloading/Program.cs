using System;
using System.Collections.Generic;
using System.Text;

namespace CSMethodOverloading
{
    internal class Program
    {
        /*
        Exercise 1:
        Create a new Console app in Visual Studio Community.
        Create a method named Add, that accepts two integers and returns the sum of those two integers
        Now create an overload of the Add method to account for being able to add two decimals together
        Now create another overload of the Add method that returns a string and accepts 3 parameters: 2 integers and 1 boolean
        If the boolean parameter is equal to true, the Add method will return the sum of the 2 numbers plus the word “dollars” at the end of the string.
        You must also account for the appropriate grammar of the string - so it can’t be “1 dollars”
        For example:
        “5 dollars”
        "1 dollar”
        “16 dollars”
        */

        public static int Add(int num1, int num2)
        {
            Console.WriteLine($"Add(int num1({num1}), int num2({num2}))");
            return num1 + num2;
        }
        public static decimal Add(decimal num1, decimal num2)
        {
            Console.WriteLine($"Add(decimal num1({num1}), decimal num2({num2}))");
            return num1 + num2;
        }
        public static string Add(int num1, int num2, bool sayDollars)
        {
            Console.WriteLine($"Add(int num1({num1}), int num2({num2}), bool sayDollars({sayDollars}))");
            string dollarNoDollar = (sayDollars) ? (Math.Abs(num1 + num2) > 1) ? " dollars" : " dollar" : "";
            return $"{num1 + num2}{dollarNoDollar}";
        }

        static void Main(string[] args)
        {
            Console.WriteLine("\nAdd with integers");
            Console.WriteLine("result = " + Add(-2, 1));
            Console.WriteLine("result = " + Add(2, 2));
            Console.WriteLine("result = " + Add(0, 0));

            Console.WriteLine("\nAdd with decimals");
            Console.WriteLine("result = " + Add(-2.5m, 5.4m));
            Console.WriteLine("result = " + Add(7.6m, 9m));
            Console.WriteLine("result = " + Add(512.468m, -674.456m));

            Console.WriteLine("\nAdd with integers and a string");
            Console.WriteLine("result = " + Add(-3, 7, true));
            Console.WriteLine("result = " + Add(-3, 7, false));
            Console.WriteLine("result = " + Add(-4, 5, true));
            Console.WriteLine("result = " + Add(-4, 5, false));

        }
    }
}
