using System;
using CSharpAlgorithms.SortAlgorithms;
using CSharpAlgorithms.TestingHelpers;

namespace CSharpAlgorithms {
    class Program {
        static void Main(string[] args) {
            int[] result = MergeSort.Sort(IntPopulator.Random(10, unique: true));

            foreach (var num in result) {
                Console.Write(num + " ");
            }
        }
    }
}
