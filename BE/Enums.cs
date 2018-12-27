using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public enum Gender { Male, Female };
    public enum Vehicle { PrivateVehicle, TwoWheelVehicle, MediumTruck, HeavyTruck };
    public enum GearBox { Automatic, Manual };
    public class VehicleParams
    {
        private Vehicle VehicleType;
        private GearBox GearBoxType;
    }
    public enum Days { Sunday, Monday, Tuesday, Wednesday, Thursday };
    public enum KindOfPhoneNumber { Mobile, Home};
    public class PhoneNumber
    {
        public readonly string number;
        public readonly KindOfPhoneNumber kind;
        PhoneNumber(string _number, KindOfPhoneNumber _kind)
        {
            number = _number;
            kind = _kind;
        }
        PhoneNumber(PhoneNumber phone)
        {
            this.kind = phone.kind;
            this.number = phone.number;
        }
    }
    public class HoursInDay : IEnumerable
    {
        public bool[] Hours = new bool[6];
        public IEnumerator GetEnumerator()
        {
            return Hours.GetEnumerator();
        }
    }
    public class WeeklyWorkHours : IEnumerable
    {
        HoursInDay[] MyWeek = new HoursInDay[5];

        public IEnumerator GetEnumerator()
        {
            return MyWeek.GetEnumerator();
        }
    }
    
    public class FullName
    {
        public readonly string FirstName;
        public readonly string LastName;
        FullName(string _firstName, string _lastName)
        {
            FirstName = _firstName;
            LastName = _lastName;
        }
        public override string ToString()
        {
            return FirstName + " " + LastName;
        }
    }
}
