using System;
using CSharpAlgorithms.SortAlgorithms;
using CSharpAlgorithms.TestingHelpers;

namespace CSharpAlgorithms {
    class Program {
        static void Main(string[] args) {
            StopWatch stopwatch = new StopWatch();
            int[] population;
            int[] result;

            Console.WriteLine("Poptulation Size: 10");
            stopwatch.ResetTime();
            population = IntPopulator.Random(10, unique: true);
            Console.WriteLine(stopwatch.GetTime() + " milliseconds to create population.");

            stopwatch.ResetTime();
            result = MergeSort.Sort(population);
            Console.WriteLine(stopwatch.GetTime() + " milliseconds to sort population.");

            Console.Write("\nRandom: ");
            foreach (var num in population) {
                Console.Write(num + " ");
            }
            Console.Write("\nSorted: ");
            foreach (var num in result) {
                Console.Write(num + " ");
            }



            Console.WriteLine("\n\n\nPoptulation Size: 100");
            stopwatch.ResetTime();
            population = IntPopulator.Random(100, unique: true);
            Console.WriteLine(stopwatch.GetTime() + " milliseconds to create population.");

            stopwatch.ResetTime();
            result = MergeSort.Sort(population);
            Console.WriteLine(stopwatch.GetTime() + " milliseconds to sort population.");

            Console.Write("\nRandom: ");
            foreach (var num in population) {
                Console.Write(num + " ");
            }
            Console.Write("\nSorted: ");
            foreach (var num in result) {
                Console.Write(num + " ");
            }



            Console.WriteLine("\n\n\nPoptulation Size: 1000");
            stopwatch.ResetTime();
            population = IntPopulator.Random(1000, unique: true, max: 10000);
            Console.WriteLine(stopwatch.GetTime() + " milliseconds to create population.");

            stopwatch.ResetTime();
            result = MergeSort.Sort(population);
            Console.WriteLine(stopwatch.GetTime() + " milliseconds to sort population.");

            Console.Write("\nRandom: ");
            foreach (var num in population) {
                Console.Write(num + " ");
            }
            Console.Write("\nSorted: ");
            foreach (var num in result) {
                Console.Write(num + " ");
            }
        }
    }
}
