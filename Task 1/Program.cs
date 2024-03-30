using System;
using System.Linq;
using System.Collections.Generic;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            // String section
            Console.WriteLine("Do you want to use the default string? (yes/no)");
            string response = Console.ReadLine() ?? "".ToLower();
            string inputString;
            if (response == "yes")
            {
                inputString = "Hello world";
                Console.WriteLine("Using default string: 'Hello world'");
            }
            else if (response == "no")
            {
                Console.WriteLine("Enter a string:");
                inputString = Console.ReadLine() ?? "";
            }
            else
            {
                Console.WriteLine("Invalid input. Using default string: 'Hello world'");
                inputString = "Hello world";
            }

            Console.WriteLine("Reverse the string");
            response = Console.ReadLine() ?? "".ToLower();
            {
                Console.WriteLine($"Reverse of inputString: {inputString.ReverseString()}");
            }

            Console.WriteLine("Enter the character you want to count:");
            char charToCount = char.Parse(Console.ReadLine() ?? "");
            Console.WriteLine($"Count of '{charToCount}' in inputString: {inputString.CountOccurrences(charToCount)}");

            // Integer array section
            Console.WriteLine("Do you want to use the default integer array? (yes/no)");
            response = Console.ReadLine() ?? "".ToLower();
            int[] intArray;
            if (response == "yes")
            {
                intArray = new int[] { 1, 2, 3, 4, 5, 9, 8, 7, 2 };
                Console.WriteLine("Using default integer array.");
            }
            else if (response == "no")
            {
                Console.WriteLine("Enter elements for the integer array (comma-separated):");
                string input = Console.ReadLine() ?? "";
                intArray = input.Split(',').Select(int.Parse).ToArray();
            }
            else
            {
                Console.WriteLine("Invalid input. Using default integer array.");
                intArray = new int[] { 1, 2, 3, 4, 5, 9, 8, 7, 2 };
            }

            Console.WriteLine($"Array: [{string.Join(", ", intArray)}]");
            Console.WriteLine("Enter the element you want to count:");
            int elementToCount = int.Parse(Console.ReadLine() ?? "");
            Console.WriteLine($"Count of '{elementToCount}' in intArray: {intArray.CountOccurrences(elementToCount)}");

            // Double array section
            Console.WriteLine("Do you want to use the default double array? (yes/no)");
            response = Console.ReadLine() ?? "".ToLower();
            double[] doubleArray;
            if (response == "yes")
            {
                doubleArray = new double[] { 1, 2, 3, 4, 5, 9, 8, 7, 2 };
                Console.WriteLine("Using default double array.");
            }
            else if (response == "no")
            {
                Console.WriteLine("Enter elements for the double array (comma-separated):");
                string input = Console.ReadLine() ?? "";
                doubleArray = input.Split(',').Select(double.Parse).ToArray();
            }
            else
            {
                Console.WriteLine("Invalid input. Using default double array.");
                doubleArray = new double[] { 1, 2, 3, 4, 5, 9, 8, 7, 2 };
            }

            Console.WriteLine($"Array: [{string.Join(", ", doubleArray)}]");
            Console.WriteLine("Unique elements in doubleArray:");
            double[] uniqueDoubles = doubleArray.GetUniqueElements();
            foreach (double uniqueDouble in uniqueDoubles)
            {
                Console.Write($"{uniqueDouble} ");
            }
            Console.WriteLine();

            // String array section
            Console.WriteLine("Do you want to use the default string array? (yes/no)");
            response = Console.ReadLine() ?? "".ToLower();
            string[] stringArray;
            if (response == "yes")
            {
                stringArray = new string[] { "Dog", "Zebra","Boar", "Bacteria", "Stas", "Boar", "Banana", "Stas" };
                Console.WriteLine("Using default string array.");
            }
            else if (response == "no")
            {
                Console.WriteLine("Enter elements for the string array (comma-separated):");
                string input = Console.ReadLine() ?? "";
                stringArray = input.Split(',');
            }
            else
            {
                Console.WriteLine("Invalid input. Using default string array.");
                stringArray = new string[] { "Dog", "Zebra", "Boar", "Bacteria", "Stas", "Boar", "Banana", "Stas" };
            }

            Console.WriteLine($"Array: [{string.Join(", ", stringArray)}]");
            Console.WriteLine("Unique elements in stringArray:");
            string[] uniqueStrings = stringArray.GetUniqueElements();
            foreach (string uniqueString in uniqueStrings)
            {
                Console.Write($"{uniqueString} ");
            }
            Console.WriteLine();
        }
    }

    public static class ArrayExtensions
    {
        public static int CountOccurrences<T>(this T[] arr, T item)
        {
            return arr.Count(x => Equals(x, item));
        }

        public static T[] GetUniqueElements<T>(this T[] arr)
        {
            if (arr == null)
                throw new ArgumentNullException(nameof(arr));

            return arr.Distinct().ToArray();
        }
    }

    public static class StringExtensions
    {
        public static int CountOccurrences(this string str, char c)
        {
            int counter = 0;
            foreach (char chr in str)
            {
                if (chr == c)
                    counter++;
            }
            return counter;
        }

        public static string ReverseString(this string str)
        {
            char[] charArray = str.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
