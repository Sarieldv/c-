using System;
using System.Collections.Generic;
using System.Text;

namespace BE
{
    public class Test
    {
        private static int Number;
        private string TesterId;
        private string TraineeId;
        private Address AddressOfDeparture;
        private bool? DistanceKeep;
        private bool? ReverseParking;
        private bool? Parking;
        private bool? LookingAtMirrors;
        private bool? Junction;
        private bool? Reversing;
        private bool? Roundabout;
        private bool? Overtaking;
        private bool? Turning;
        private string TesterNote;
        private DateTime DateAndTime;
        private bool? Grade;
        public Test(string _testerId, string _traineeId, Address _addressOfDeparture, DateTime _dateAndTime)
        {
            TesterId = _testerId;
            TraineeId = _traineeId;
            AddressOfDeparture = _addressOfDeparture;
            DateAndTime = _dateAndTime;

        }
        public Test(string _testerId, string _traineeId, Address _addressOfDeparture, DateTime _dateAndTime, bool? _distanceKeep, bool? _reverseParking,bool? _parking, bool? _lookingAtMirrors, bool? _junction,bool? _reversing,bool? _roundabout, bool? _overtaking,bool? _turning, string _testerNote, bool? _grade)
        {
            TesterId = _testerId;
            TraineeId = _traineeId;
            AddressOfDeparture = _addressOfDeparture;
            DateAndTime = _dateAndTime;
            DistanceKeep = _distanceKeep;
            ReverseParking = _reverseParking;
            Parking = _parking;
            LookingAtMirrors = _lookingAtMirrors;
            Junction = _junction;
            Reversing = _reversing;
            Roundabout = _roundabout;
            Overtaking = _overtaking;
            Turning = _turning;
            TesterNote = _testerNote;
            Grade = _grade;
        }
        public override string ToString()
        {
            throw new NotImplementedException();
        }
    }
}
