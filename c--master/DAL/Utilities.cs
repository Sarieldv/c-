﻿using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public static class Utilities
    {
        public static Tester DeepClone(this Tester t)
        {
            return new Tester
            {
                IDNumber=t.IDNumber,
                MaxDistanceFromTest = t.MaxDistanceFromTest,
                MaximumWeeklyTests = t.MaximumWeeklyTests,
                MyVehicle = t.MyVehicle,
                MyWorkHours = t.MyWorkHours,
                TestsSignedUpFor = t.TestsSignedUpFor,
                YearsOfExperience = t.YearsOfExperience,
                BirthDate = t.BirthDate,
                MyAddress = new Address
                {
                    AddressNumber = t.MyAddress.AddressNumber,
                    CityName = t.MyAddress.CityName,
                    StreetName = t.MyAddress.StreetName
                },
                MyGender = t.MyGender,
                MyPhoneNumber = t.MyPhoneNumber,
                Name = t.Name
            };
        }
        public static Trainee DeepClone(this Trainee t)
        {
            return new Trainee
            {

                BirthDate = t.BirthDate,
                MyAddress=new Address
                {
                    AddressNumber = t.MyAddress.AddressNumber,
                    CityName = t.MyAddress.CityName,
                    StreetName = t.MyAddress.StreetName
                },
                MyGender = t.MyGender,
                MyPhoneNumber = t.MyPhoneNumber,
                Name = t.Name,
                TraineeVehicle=t.TraineeVehicle,
                AmountOfClasses =t.AmountOfClasses,
                HaveTest =t.HaveTest,
                IDNumber =t.IDNumber,
                SchoolName =t.SchoolName,
                Teacher =t.Teacher,
                AmountOfTests =t.AmountOfTests
            };
        }
        public static Test DeepClone(this Test t)
        {
            return new Test(t, t.DistanceKeep, t.ReverseParking, t.Parking, t.LookingAtMirrors, t.Junction, t.Reversing, t.Roundabout, t.Overtaking, t.Turning, t.TesterNote, t.Grade);            
        }
    }

}
