using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQedList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //Restriction/Filtering Operations

            // Find the words in the collection that start with the letter "L"
            List<string> fruits = new List<string>() { "Lemon", "Apple", "Orange", "Lime", "Watermelon", "Loganberry" };

            var LFruits = from fruit in fruits where fruit.First() == 'L' select fruit;

            foreach (var fruit in LFruits)
            {
                Console.WriteLine(fruit); 
            }

            //Which of the following numbers are multiples of 4 or 6
            List<int> numbers = new List<int>()
            {
                15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
            };

            var fourSixMultiples = numbers.Where(num => numbers % 4 = 0 || numbers % 6 = 0);
        }
    }
}
