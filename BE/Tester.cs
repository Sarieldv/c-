using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Tester : Person
    {
        private int YearsOfExperience;
        public int _yearsOfExperience => YearsOfExperience;
        private int MaximumWeeklyTests;
        public int _maximumWeeklyTests => MaximumWeeklyTests;
        private VehicleParams MyVehicle;
        public VehicleParams _myVehicle => MyVehicle;
        private WeeklyWorkHours MyWorkHours;
        public WeeklyWorkHours _myWorkHours => MyWorkHours;
        private int MaxDistanceFromTest;
        public int _MaxDistanceFromTest => MaxDistanceFromTest;  
        private int TestsSignedUpFor;
        public int _testsSignedUpFor
        {
            get => TestsSignedUpFor;
            set
            {
                if (value > 0)
                {
                    TestsSignedUpFor++;
                }
                if (value < 0)
                {
                    TestsSignedUpFor--;
                }
            }
        }
        public Tester(string _ID, FullName _name, DateTime _birthDate, Gender _gender,PhoneNumber _phoneNumber, Address _address, int _yearsOfExperience, int _maximumWeeklyTests, VehicleParams _myVehicle, WeeklyWorkHours _myWorkHours, int _maximumDistance)
        {
            IDNumber = _ID;
            Name = _name;
            BirthDate = _birthDate;
            MyGender = _gender;
            MyPhoneNumber = _phoneNumber;
            MyAddress = _address;
            YearsOfExperience = _yearsOfExperience;
            MaximumWeeklyTests = _maximumWeeklyTests;
            MyVehicle = _myVehicle;
            MyWorkHours = _myWorkHours;
            MaxDistanceFromTest = _maximumDistance;
        }

        public override string ToString()
        {
            throw new NotImplementedException();
        }
    }
}
