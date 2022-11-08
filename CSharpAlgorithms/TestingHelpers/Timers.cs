using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpAlgorithms.TestingHelpers {
    class StopWatch {
        private DateTime startTime;

        public StopWatch() {
            ResetTime();
        }

        public double GetTime() {
            return (DateTime.Now - startTime).TotalMilliseconds;
        }

        public void ResetTime() {
            startTime = DateTime.Now;
        }
    }
}
