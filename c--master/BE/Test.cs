using System;
using System.Collections.Generic;
using System.Text;
using DS;

namespace BE
{
    public class Test
    {
        private int number;
        private string testerId;
        private string traineeId;
        private Address addressOfDeparture;
        private bool? distanceKeep;
        private bool? reverseParking;
        private bool? parking;
        private bool? lookingAtMirrors;
        private bool? junction;
        private bool? reversing;
        private bool? roundabout;
        private bool? overtaking;
        private bool? turning;
        private string testerNote;
        private DateTime dateAndTime;
        private bool? grade;
        public int Number { get => number; private set => number = value ; }
        public string TesterId { get => testerId; set => testerId = value; }
        public string TraineeId { get => traineeId; set => traineeId = value; }
        public Address AddressOfDeparture { get => addressOfDeparture; set => addressOfDeparture = value; }
        public bool? DistanceKeep { get => distanceKeep; set => distanceKeep = value; }
        public bool? ReverseParking { get => reverseParking; set => reverseParking = value; }
        public bool? Parking { get => parking; set => parking = value; }
        public bool? LookingAtMirrors { get => lookingAtMirrors; set => lookingAtMirrors = value; }
        public bool? Junction { get => junction; set => junction = value; }
        public bool? Reversing { get => reversing; set => reversing = value; }
        public bool? Roundabout { get => roundabout; set => roundabout = value; }
        public bool? Overtaking { get => overtaking; set => overtaking = value; }
        public bool? Turning { get => turning; set => turning = value; }
        public string TesterNote { get => testerNote; set => testerNote = value; }
        public DateTime DateAndTime { get => dateAndTime; set => dateAndTime = value; }
        public bool? Grade { get => grade; set => grade = value; }
        public Test(string _testerId, string _traineeId, Address _addressOfDeparture, DateTime _dateAndTime)
        {
            number = Configuration.TestId;
            TesterId = _testerId;
            TraineeId = _traineeId;
            AddressOfDeparture = _addressOfDeparture;
            DateAndTime = _dateAndTime;

        }
        public Test(Test t, bool? _distanceKeep, bool? _reverseParking,bool? _parking, bool? _lookingAtMirrors, bool? _junction,bool? _reversing,bool? _roundabout, bool? _overtaking,bool? _turning, string _testerNote, bool? _grade)
        {
            number = t.number;
            TesterId = t.TesterId;
            TraineeId = t.TraineeId;
            AddressOfDeparture = t.AddressOfDeparture;
            DateAndTime = t.DateAndTime;
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
        public Test()
        {

        }

        public override string ToString()
        {
            throw new NotImplementedException();
        }
    }
}
