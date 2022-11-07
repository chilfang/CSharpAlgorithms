using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CSharpAlgorithms.SortAlgorithms {
    class MergeSort {
        public static int[] Sort(int[] array) {
            if (array.Length <= 1) return array;

            int[] array1 = array[0..(array.Length/2)];
            int[] array2 = array[(array.Length / 2)..];

            array1 = Sort(array1);
            array2 = Sort(array2);

            return Merge(array1, array2);
        }

        
        private static int[] Merge(int[] array1, int[] array2) {
            List<int> output = new List<int>();

            while (array1.Length > 0 && array2.Length > 0) {
                if (array1[0] < array2[0]) {
                    output.Add(array1[0]);
                    array1 = array1[1..];
                } else {
                    output.Add(array2[0]);
                    array2 = array2[1..];
                }
            }

            while (array1.Length > 0) {
                output.Add(array1[0]);
                array1 = array1[1..];
            }

            while (array2.Length > 0) {
                output.Add(array2[0]);
                array2 = array2[1..];
            }

            return output.ToArray();
        } 
    }
}
