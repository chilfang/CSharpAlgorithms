using System;
using CSharpAlgorithms.SortAlgorithms;
using CSharpAlgorithms.TestingHelpers;

namespace CSharpAlgorithms {
    class Program {
        static void Main(string[] args) {
            StopWatch stopwatch = new StopWatch();
            int[] population = IntPopulator.Random(10, unique: true);
            Console.WriteLine(stopwatch.GetTime() + " milliseconds to create population.");

            stopwatch.ResetTime();
            int[] result = MergeSort.Sort(population);
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
