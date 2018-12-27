using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Configuration
    {
        private static int MinimumClasses;
        public int _minimumClasses => MinimumClasses;
        private static int MaximumTesterAge;
        public int _maximumTesterAge => MaximumTesterAge;
        private static int MinimumTraineeAge;
        public int _minimumTraineeAge => MinimumTraineeAge;
        private static double TimeBetweenTests;
        public double _timeBetweenTests => TimeBetweenTests;
        private static int TestId = 10000000;
        public int _TestID => TestId++;
    }
}
