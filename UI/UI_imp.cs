using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using BL;

namespace UI
{
    class UI_imp : IUI
    {
        public void AddAnotherWeek(Tester tester)
        {
            FactoryBL.Instance.AddAnotherWeek(tester);
        }

        public void AddTest(Test NewTest)
        {
            throw new NotImplementedException();
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
            throw new NotImplementedException();
        }

        public void CancelTest(Test _test)
        {
            throw new NotImplementedException();
        }

        public bool CanDrive(Trainee _trainee, VehicleParams vehicle)
        {
            throw new NotImplementedException();
        }

        public FullName CorrectWriting(FullName name)
        {
            FullName correction = name;
            correction.FirstName.ToLower();
            correction.FirstName[0] +=
        }

        public void EraseTester(Tester _tester)
        {
            throw new NotImplementedException();
        }

        public void EraseTrainee(Trainee _trainee)
        {
            throw new NotImplementedException();
        }

        public void GetTest(Trainee trainee, DateTime dateTime)
        {
            throw new NotImplementedException();
        }

        public void GiveOptions()
        {
            throw new NotImplementedException();
        }

        public bool IsLetter(char c)
        {
            if (((int)c > 64 && (int)c < 91) || ((int)c > 96 && (int)c < 123))
                return true;
            return false;
        }

        public bool IsNumber(char c)
        {
            if ((int)c > 47 && (int)c < 58)
                return true;
            return false;
        }

        public bool IsStringLetters(string str)
        {
            foreach (char letter in str)
            {
                if(!IsLetter(letter))
                {
                    return false;
                }
            }
            return true;
        }

        public bool IsStringNumbers(string str)
        {
            foreach (char letter in str)
            {
                if (!IsNumber(letter))
                {
                    return false;
                }
            }
            return true;
        }

        public void RemoveFirstWeek(Tester tester)
        {
            FactoryBL.Instance.RemoveFirstWeek(tester);
        }

        public List<Tester> ReturnTesters()
        {
            try
            {
                FactoryBL.Instance.ReturnTesters();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            return FactoryBL.Instance.ReturnTesters();
        }

        public List<Test> ReturnTests()
        {
            try
            {
                FactoryBL.Instance.ReturnTests();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            return FactoryBL.Instance.ReturnTests();
        }

        public List<Trainee> ReturnTrainees()
        {
            try
            {
               FactoryBL.Instance.ReturnTrainees();
            }
            catch ( Exception ex)
            {
                Console.WriteLine(ex);
            }
            return FactoryBL.Instance.ReturnTrainees();
        }

        public List<Tester> TestersBusyByTime(DateTime _dateTime)
        {
            throw new NotImplementedException();
        }

        public List<Tester> TestersByCity(Address address)
        {
            throw new NotImplementedException();
        }

        public List<Tester> TestersByDistance(int _distance, Address address)
        {
            throw new NotImplementedException();
        }

        public List<Tester> TestersBySpecialty(VehicleParams vehicle)
        {
            throw new NotImplementedException();
        }

        public List<Tester> TestersFreeByTime(DateTime dateTime)
        {
            throw new NotImplementedException();
        }

        public List<List<List<Tester>>> TestersGroupedBySpecialty(bool _extraSorted)
        {
            throw new NotImplementedException();
        }

        public List<Test> TestsByCondition(Func<Test, bool> _condition)
        {
            throw new NotImplementedException();
        }

        public List<Test> TestsByDay(DateTime _dateTime)
        {
            throw new NotImplementedException();
        }

        public List<Test> TestsByMonth(DateTime _dateTime)
        {
            throw new NotImplementedException();
        }

        public int TestsDone(Trainee _trainee)
        {
            throw new NotImplementedException();
        }

        public List<List<Trainee>> TraineesGroupedBySchool(bool _extraSorted)
        {
            throw new NotImplementedException();
        }

        public List<List<Trainee>> TraineesGroupedByTeacher(bool _extraSorted)
        {
            throw new NotImplementedException();
        }

        public List<List<Trainee>> TraineesGroupedByTestAmount(bool _extraSorted)
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
