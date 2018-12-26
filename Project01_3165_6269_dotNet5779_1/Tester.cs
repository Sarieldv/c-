using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    class Tester : Person
    {
        private int YearOfExperience;
        private int MaxTests;
        private VehicleParams MyVehicle;
        private WeeklyWorkHours MyWorkHours;
        private double MaximumDistance;
        public double _MaximumDistance
        {
            get => MaximumDistance;
            set
            {
                MaximumDistance = ((int)(value * 10)) / 10;
            }
        }

        public override string ToString()
        {
            throw new NotImplementedException();
        }
    }
}
