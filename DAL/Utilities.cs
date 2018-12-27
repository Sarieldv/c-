using BE;
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
    }
}
