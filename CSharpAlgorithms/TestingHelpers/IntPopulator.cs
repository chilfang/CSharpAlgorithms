using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CSharpAlgorithms.TestingHelpers {
    class IntPopulator {
        public static int[] Random(int numberCount, int min = 0, int max = 100, bool unique = false) {
            if (unique && max - min < numberCount) throw new ArgumentOutOfRangeException("NumberCount", $"The number count ({numberCount}) requested cannot be achieved with the current min ({min}) and max ({max}).");
            Random random = new Random();

            int[] output = new int[numberCount];

            for (int i = 0; i < numberCount; i++) {
                output[i] = random.Next(min, max);

                if (unique && i > 0) {
                    while (output[..i].Any(x => x == output[i])) {
                        output[i] = random.Next(min, max);
                    }
                }
            }

            return output;
        }

        public static int[] Sorted(int start, int end, int spacing = 1) {
            int[] output = new int[(end - start) / spacing + 1];

            for (int i = 0; i < output.Length; i += spacing) {
                output[i] = start + i;
            }

            return output;
        }
    }
}
