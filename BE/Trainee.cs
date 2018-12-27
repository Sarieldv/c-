using System;
using System.Collections.Generic;
using System.Text;

namespace BE
{
    public class Trainee : Person
    {
        private VehicleParams TraineeVehicle;
        public VehicleParams _traineeVehicle => TraineeVehicle;
        private string SchoolName;
        public string _schoolName => SchoolName;
        private FullName Teacher;
        public FullName _teacher => Teacher;
        private int AmountOfTests;
        public int _amountOfTests
        {
            get => AmountOfTests;
            set => AmountOfTests++;
        }
        public bool HaveTest;
        private int AmountOfClasses;
        public int _amountOfClasses => AmountOfClasses;
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
