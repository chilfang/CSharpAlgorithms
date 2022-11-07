using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpAlgorithms.TestingHelpers {
    class IntPopulator {
        public static int[] Random(int numberCount, int min = 0, int max = 100, bool unique = false) {
            if (unique && max - min < numberCount) throw new ArgumentOutOfRangeException("NumberCount", $"The number count ({numberCount}) requested cannot be achieved with the current min ({min}) and max ({max}).");
            Random random = new Random();

            int[] output = new int[numberCount];

            for (int i = 0; i < numberCount; i++) {
                output[i] = random.Next(min, max);

                if (unique && i > 0) {
                    while (output[i - 1] == output[i]) {
                        output[i] = random.Next(min, max);
                    }
                }
            }

            return output;
        }
    }
}
