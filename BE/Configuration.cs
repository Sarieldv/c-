using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public  static class Configuration
    {
        private static int maxTesterAge;
        private static int testId;
        private static int minTesterAge;
        private static int minimumTraineeAge;

        public static int MaximumTesterAge
        {
            get { return maxTesterAge; }
            private set { maxTesterAge = value; }
        }
        public static int MinimumTesterAge
        {
            get { return minTesterAge; }
            private set { minTesterAge = value; }
        }


        public static int TestId
        {
            get { return testId++; }
            private set { testId = value; }
        }
        public static int MinimumTraineeAge
        {
            get { return MinimumTraineeAge; }
            private set { MinimumTraineeAge = value; }
        }
        private static int minimumClasses;

        public static int MinimumClasses
        {
            get { return minimumClasses; }
            set { minimumClasses = value; }
        }

        private static int timeBetweenTests;

        public static int TimeBetweenTests
        {
            get { return timeBetweenTests; }
            set { timeBetweenTests = value; }
        }


        static Configuration()
        {
            MaximumTesterAge = 80;
            MinimumTesterAge = 40;
            TestId = 10000000;
            MinimumTraineeAge = 18;
            MinimumClasses = 20;
            TimeBetweenTests = 7;
            // here we are going to change all this by loading a "configuration.xml" file
            // in those variables
        }

      }
}
