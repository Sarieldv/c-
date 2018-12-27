using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Tester : Person
    {
        public int YearsOfExperience       { get; set;}
        public int MaximumWeeklyTests      { get; set;}
        public VehicleParams MyVehicle     { get; set;}
        public WeeklyWorkHours MyWorkHours { get; set;}
        public int MaxDistanceFromTest     { get; set;}

        private int _testsSignedUpFor;
        public int TestsSignedUpFor
        {
            get => _testsSignedUpFor;
            set
            {
                if (value > 0)
                {
                    _testsSignedUpFor++;
                }
                if (value < 0)
                {
                    _testsSignedUpFor--;
                }
            }
        }
        public Tester()
        {
            
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
