using Microsoft.VisualStudio.TestTools.UnitTesting;
using CSharpAlgorithms.SortAlgorithms;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpAlgorithms.SortAlgorithms.Tests {
    [TestClass()]
    public class BubbleSortTests {
        [TestMethod()]
        public void bubbleSortTest() {
            int[] sample = new int[] { 3, 0, 2, 5, -1, 4, 1 };
            BubbleSort.bubbleSort(ref sample);
            Assert.IsTrue(sample[0] == -1);
        }
    }
}