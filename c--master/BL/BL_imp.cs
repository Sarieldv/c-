using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using DAL;
namespace BL
{
    internal class BL_imp : IBL
    {
        public void AddTest(Test NewTest)
        {
            Tester tester = (from t in ReturnTesters()
                             where t.IDNumber == NewTest.TesterId
                             select t).FirstOrDefault();
            if (tester == null)
            {
                throw new Exception("Tester does not exist.");
            }
            if (tester.MyWorkHours[NewTest.DateAndTime])
            {
                throw new Exception("That time is not available.");
            }
            Trainee trainee = (from t in ReturnTrainees()
                               where t.IDNumber == NewTest.TraineeId
                               select t).FirstOrDefault();
            if (trainee == null)
            {
                throw new Exception("Trainee does not exist.");
            }
            if (trainee.HaveTest)
            {
                throw new Exception("Trainee already has a test in the system.");
            }
            if (trainee.AmountOfClasses < Configuration.MinimumClasses)
            {
                throw new Exception("Not enough classes.");
            }
            var k = (from t in ReturnTests()
                     where t.TraineeId == trainee.IDNumber
                     select t);
            Test mostRecentTest = k.OrderByDescending(e => e.DateAndTime).FirstOrDefault();
            if (Configuration.TimeBetweenTests > (NewTest.DateAndTime - mostRecentTest.DateAndTime) && (mostRecentTest != null))
            {
                throw new Exception("Trainee had a test too recently.");
            }
            if ((from bool t in tester.MyWorkHours
                 where t
                 select t).Count() == tester.MaximumWeeklyTests)
            {
                throw new Exception("Tester can not test any more this week.");
            }
            if (!(tester.MyVehicle == trainee.TraineeVehicle))
            {
                throw new Exception("Mismatch between trainee and tester");
            }
            if (trainee.PassedByVehicleParams[(int)trainee.TraineeVehicle.VehicleType, (int)trainee.TraineeVehicle.GearBoxType])
            {
                throw new Exception("Trainee already passed this test.");
            }
            if(CalcDistance(tester.MyAddress, NewTest.AddressOfDeparture)>tester.MaxDistanceFromTest)
            {
                throw new Exception("Test is too far for tester.");
            }
            try
            {
                FactoryDAL.Instance.AddTest(NewTest);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            tester.MyWorkHours[NewTest.DateAndTime] = true;
            tester.TestsSignedUpFor = 1;
            trainee.HaveTest = true;
        }

        public void AddTester(Tester NewTester)
        {
            throw new NotImplementedException();
        }

        public void AddTrainee(Trainee NewTrainee)
        {
            throw new NotImplementedException();
        }

        public int CalcDistance(Address address1, Address address2)
        {
            Random r = new Random();
            return r.Next(0, 21);
        }

        public void CancelTest(Test _test)
        {
            throw new NotImplementedException();
        }

        public bool CanDrive(Trainee _trainee)
        {
            throw new NotImplementedException();
        }

        public void EraseTester(Tester _tester)
        {
            throw new NotImplementedException();
        }

        public void EraseTrainee(Trainee _trainee)
        {
            throw new NotImplementedException();
        }

        public void GetTest(Trainee trainee, Address address, DateTime dateTime)
        {
            if(trainee.HaveTest)
            {
                throw new Exception("Trainee already has a test.");
            }

        }

        public List<Tester> ReturnTesters()
        {
            return FactoryDAL.Instance.ReturnTesters();
        }

        public List<Test> ReturnTests()
        {
            return FactoryDAL.Instance.ReturnTests();
        }

        public List<Trainee> ReturnTrainees()
        {
            return FactoryDAL.Instance.ReturnTrainees();
        }

        public List<Tester> TestersByDistance(int _distance, Address address, List<Tester> _testersList)
        {
            throw new NotImplementedException();
        }

        public List<Tester> TestersByTime(DateTime _dateTime)
        {
            throw new NotImplementedException();
        }

        public List<Tester> TestersGroupedByCity(bool _extraSorted)
        {
            throw new NotImplementedException();
        }

        public List<Tester> TestersGroupedBySpecialty(bool _extraSorted)
        {
            throw new NotImplementedException();
        }

        public List<Tester> TestsByCondition(Delegate _condition)
        {
            throw new NotImplementedException();
        }

        public List<Test> TestsByTime(DateTime _dateTime, bool _dayOrMonth)
        {
            throw new NotImplementedException();
        }

        public int TestsDone(Trainee _trainee)
        {
            throw new NotImplementedException();
        }

        public List<Trainee> TraineesGroupedBySchool(bool _extraSorted)
        {
            throw new NotImplementedException();
        }

        public List<Trainee> TraineesGroupedByTeacher(bool _extraSorted)
        {
            throw new NotImplementedException();
        }

        public List<Trainee> TraineesGroupedByTestAmount(bool _extraSorted)
        {
            throw new NotImplementedException();
        }

        public void UpdateTest(Test updatedTest)
        {
            throw new NotImplementedException();
        }

        public void UpdateTester(Tester updatedTester)
        {
            throw new NotImplementedException();
        }

        public void UpdateTrainee(Trainee updatedTrainee)
        {
            throw new NotImplementedException();
        }
    }
}