using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpAlgorithms.SearchAlgorithms {
    class BinarySearch {
        public static int Search(int num, int[] array) {
            int index = array.Length / 2;

            int min = 0;
            int max = array.Length;

            while (max - min > 1) {
                if (array[index] == num) {
                    return index;
                } else if (array[index] < num) {
                    min = index;
                } else {
                    max = index;
                }

                index = ((max - min) / 2) + min;
            }

            return -1;
        }
    }
}
