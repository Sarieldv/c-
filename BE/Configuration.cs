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
            get { return testId; }
            private set { testId = value; }
        }

        static Configuration()
        {
            MaximumTesterAge = 80;
            MinimumTesterAge = 40;
            TestId = 10000000;
            // here we are going to change all this by loading a "configuration.xml" file
            // in those variables
        }

        private static int MinimumClasses;
        public static int _minimumClasses => MinimumClasses;


        private static int MinimumTraineeAge;
        public static int _minimumTraineeAge => MinimumTraineeAge;
        private static double TimeBetweenTests;
        public static double _timeBetweenTests => TimeBetweenTests;
      }
}
