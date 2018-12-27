using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using DAL;

namespace BL
{
    class BL_imp : IBL
    {
        public void AddTest(ref Tester _tester, ref Trainee _trainee, Address _AddressOfDeparture, DateTime _DateAndTime)
        {
            try
            {
                new Dal_imp().AddTest(ref _tester, ref _trainee, _AddressOfDeparture, _DateAndTime);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void AddTester(Tester NewTester)
        {
            throw new NotImplementedException();
        }

        public void AddTrainee(Trainee NewTrainee)
        {
            throw new NotImplementedException();
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

        public List<Tester> ReturnTesters()
        {
            throw new NotImplementedException();
        }

        public List<Test> ReturnTests()
        {
            throw new NotImplementedException();
        }

        public List<Trainee> ReturnTrainees()
        {
            throw new NotImplementedException();
        }

        public List<Tester> TestersByDistance(int _distance, Address address, List<Tester> _testersList)
        {
            throw new NotImplementedException();
        }

        public List<Tester> TestersByTime(DateTime _dateTime)
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

        public void UpdateTest(ref Test MyTest, Test _updatedTest)
        {
            throw new NotImplementedException();
        }

        public void UpdateTester(ref Tester MyTester, Tester _updatedTester)
        {
            throw new NotImplementedException();
        }

        public void UpdateTrainee(ref Trainee MyTrainee, Trainee _updatedTrainee)
        {
            throw new NotImplementedException();
        }
    }
}
