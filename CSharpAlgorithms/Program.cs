using System;
using CSharpAlgorithms.SortAlgorithms;
using CSharpAlgorithms.SearchAlgorithms;
using CSharpAlgorithms.TestingHelpers;

namespace CSharpAlgorithms {
    class Program {
        static void Main(string[] args) {
            StopWatch stopwatch = new StopWatch();
            int[] population;
            int[] result;
            //-----------------------------------//
            // Console.WriteLine(stopwatch.GetTime() + " milliseconds");
            Console.Write(""); //for some reason needs this for accurate time

            population = IntPopulator.Sorted(-50, 50);

            stopwatch.ResetTime();
            Console.WriteLine(BinarySearch.Search(-28, population));
            Console.WriteLine(stopwatch.GetTime() + " milliseconds");



            population = IntPopulator.Sorted(-500, 500);

            stopwatch.ResetTime();
            Console.WriteLine(BinarySearch.Search(-493, population));
            Console.WriteLine(stopwatch.GetTime() + " milliseconds");


            population = IntPopulator.Sorted(-50, 50);

            stopwatch.ResetTime();
            Console.WriteLine(BinarySearch.Search(-28, population));
            Console.WriteLine(stopwatch.GetTime() + " milliseconds");


        }
    }
}
