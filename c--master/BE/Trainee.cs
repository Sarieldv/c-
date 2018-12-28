using System;
using System.Collections.Generic;
using System.Text;

namespace BE
{
    public class Trainee : Person
    {
        public VehicleParams TraineeVehicle { get; set; }
        public string SchoolName { get; set; }
        public FullName Teacher { get; set; }
        private int _amountOfTests;
        public int AmountOfTests
        {
            get => _amountOfTests;
            set => _amountOfTests++;
        }
        public bool HaveTest { get; set; }
        public bool[,] PassedByVehicleParams = new bool[4, 2];
        public int AmountOfClasses { get; set; }
        public Trainee()
        {

        }
        public Trainee(string _ID, FullName _name, DateTime _birthDate, Gender _gender, PhoneNumber _phoneNumber, Address _address, VehicleParams _traineeVehicle, string _schoolName, FullName _teacher, int _amountOfClasses)
        {
            IDNumber = _ID;
            Name = _name;
            BirthDate = _birthDate;
            MyGender = _gender;
            MyPhoneNumber = _phoneNumber;
            MyAddress = _address;
            TraineeVehicle = _traineeVehicle;
            SchoolName = _schoolName;
            Teacher = _teacher;
            AmountOfClasses = _amountOfClasses;
        }
        public override string ToString()
        {
            throw new NotImplementedException();
        }

    }
}
