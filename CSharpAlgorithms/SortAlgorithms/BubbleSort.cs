using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpAlgorithms.SortAlgorithms {
    public class BubbleSort {
        public static void bubbleSort(ref int[] array) {
            bool unsorted;
            do {
                unsorted = false;
                for (int i = 0; i < array.Length - 1; i++) {
                    int holder;

                    if (array[i] > array[i + 1]) {
                        unsorted = true;

                        holder = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = holder;
                    }
                }
            } while (unsorted);
        }
    }
}
