using System;

namespace BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
            Console.WriteLine("Enter number to search?");
            int number = Convert.ToInt32(Console.ReadLine());
            Search s = new Search();
            Console.WriteLine("index no. is {0}", s.LinearSearch(myArray, myArray.Length - 1,number ));
            Console.WriteLine("index no. is {0}", s.binarySearch(myArray, 0, myArray.Length - 1, number));
            Console.ReadLine();
        }
    }
}
