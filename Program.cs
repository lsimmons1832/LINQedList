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

            // foreach (var fruit in LFruits)
            // {
            //     Console.WriteLine(fruit);
            // }

            //Which of the following numbers are multiples of 4 or 6
            // List<int> numbers = new List<int>()
            // {
            //     15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
            // };

            // var fourSixMultiples = numbers.Where(num => num % 4 == 0 || num % 6 == 0).ToList();

            // foreach (var num in numbers)
            // {
            //     Console.WriteLine(num);
            // }

            // Order these student names alphabetically, in descending order (Z to A)
            List<string> names = new List<string>()
                {
                    "Heather", "James", "Xavier", "Michelle", "Brian", "Nina",
                    "Kathleen", "Sophia", "Amir", "Douglas", "Zarley", "Beatrice",
                    "Theodora", "William", "Svetlana", "Charisse", "Yolanda",
                    "Gregorio", "Jean-Paul", "Evangelina", "Viktor", "Jacqueline",
                    "Francisco", "Tre"
                };

                var descend = names.OrderByDescending(name => name);

                // foreach (var name in descend)
                // {
                //     Console.WriteLine(name);
                // }

                // Build a collection of these numbers sorted in ascending order
                // List<int> numbers = new List<int>()
                // {
                //     15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
                // };

                // var ascend = numbers.OrderBy(num => num);
                // foreach (var num in ascend)
                // {
                //     Console.WriteLine(num);
                // }

                // Output how many numbers are in this list
                // List<int> numbers = new List<int>()
                // {
                //     15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
                // };

                // var count = numbers.Aggregate(0, (total, next) => next % 1 == 0 ? total + 1 : total);

                // Console.WriteLine("The number of intergers is : {0}", count);

                // How much money have we made?
                List<double> purchases = new List<double>()
                {
                    2340.29, 745.31, 21.76, 34.03, 4786.45, 879.45, 9442.85, 2454.63, 45.65
                };

                var total = purchases.Sum();

                Console.WriteLine(total);
        }
    }
}
