using System;
using System.Collections.Generic;
using System.Text;
using BE;
using DS;

namespace DAL
{
    internal class Dal_imp : IDAL
    {
        public void AddTest(ref Tester tester, ref Trainee trainee, Address _AddressOfDeparture, DateTime _DateAndTime)
        {
            if (IsTestLegal(new Test(tester._IDNumber, trainee._IDNumber, _AddressOfDeparture, _DateAndTime)))
            {
                DataSource.TestsList.Add(new Test(tester._IDNumber, trainee._IDNumber, _AddressOfDeparture, _DateAndTime));
                tester._testsSignedUpFor=1;
                trainee.HaveTest = true;
            }
        }
        private bool IsTestLegal(Test _test)
        {
            return true;
        }


        public void AddTester(Tester NewTester)
        {
            if (IsTesterLegal(NewTester))
                DataSource.TestersList.Add(NewTester);
            
        }
        private bool IsTesterLegal(Tester _tester)
        {
            if (!IsIdLegal(_tester._IDNumber))
                throw new Exception("The ID number is invalid.");
            if (!DoesIDExist(_tester._IDNumber))
                throw new Exception("The ID number alredy exists.");
            if (!IsPhoneNumberLegal(_tester._myPhoneNumber))
                throw new Exception("The phone number is invalid");
            if (!IsTesterAgeLegal(_tester.Age()))
                throw new Exception(_tester._name.ToString() + "is too old to be a tester");
            return true;
        }
        #region personCheck
        private bool IsStringLetters(string str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                if (!(IsCharLetter(str[i])))
                    return false;
            }
            return true;
        }
        private bool IsStringNumbers(string str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                if (!(IsCharNumber(str[i])))
                    return false;
            }
            return true;
        }
        private bool IsCharLetter(char c)
        {
            if (((int)c > 64 && (int)c < 91) || ((int)c > 96 && (int)c < 123))
                return true;
            return false;
        }
        private bool IsCharNumber(char c)
        {
            if ((int)c > 47 && (int)c < 58 )
                return true;
            return false;
        }
        private bool IsIdLegal(string _ID)
        {
            if (_ID.Length != 8)
            {
                return false;
            }
            if (!IsStringNumbers(_ID))
            {
                return false;
            }
                int input = int.Parse(_ID);
                int Sum = 0;
                int Temp = input / 10;
                for (int i = 0; i < 8; i++)
                {
                    Sum += ((Temp % 10) * (2 ^ (i % 2))) / 10 + ((Temp % 10) * (2 ^ (i % 2))) % 10;
                    Temp /= 10;
                }
                Temp = (((Sum / 10) * 10 + 10) - Sum) % 10;
                if (Temp != input % 10)
                    return false;
                return true;
        }
        private bool IsPhoneNumberLegal(PhoneNumber _pn)
        {
            if (!IsStringNumbers(_pn.number))
                return false;
            if (_pn.kind == 0)
            {
                if (_pn.number.Length != 10)
                    return false;
            }
            if((int)_pn.kind==1)
            {
                if (_pn.number.Length != 9)
                    return false;
            }
            return true;

        }
        #endregion
        private bool DoesIDExist(string _ID)
        {
            foreach (Tester item in DataSource.TestersList)
            {
                if (_ID==item._IDNumber)
                {
                    return false;
                }
            }
            foreach  (Trainee item in DataSource.TraineesList)
            {
                if (_ID == item._IDNumber)
                {
                    return false;
                }
            }
            return true;
        }
        private bool IsTesterAgeLegal(int _age)
        {
            if (_age > new Configuration()._maximumTesterAge)
                return false;
            return true;
        }
        private bool IsTraineeAgeLegal(int _age)
        {
            if (_age < new Configuration()._minimumTraineeAge)
                return false;
            return true;
        }
        private bool CanAddTest(Tester _tester)
        {
            if (_tester._testsSignedUpFor == _tester._maximumWeeklyTests)
                return false;
            return true;
        }
        public void AddTrainee(Trainee NewTrainee)
        {
            if (IsTraineeLegal(NewTrainee))
                DataSource.TraineesList.Add(NewTrainee);
        }
        private bool IsTraineeLegal(Trainee _trainee)
        {
            return true;
        }

        public void CancelTest(Test _test, ref Tester _tester, ref Trainee _trainee)
        {
            _tester._testsSignedUpFor = -1;
            _trainee.HaveTest = false;
            DataSource.TestsList.Remove(_test);
        }

        public void EraseTester(Tester _tester)
        {
            DataSource.TestersList.Remove(_tester);
        }
        public void EraseTrainee(Trainee trainee)
        {
            DataSource.TraineesList.Remove(trainee);
        }

        public List<Tester> ReturnTesters()
        {
            return DataSource.TestersList;
        }

        public List<Test> ReturnTests()
        {
            return DataSource.TestsList;
        }

        public List<Trainee> ReturnTrainees()
        {
            return DataSource.TraineesList;
        }

        public void UpdateTest(ref Test MyTest, Test _updatedTest)
        {
            if(IsTestLegal(_updatedTest))
                MyTest = _updatedTest;
        }

        public void UpdateTester(ref Tester MyTester, Tester _updatedTester)
        {
            if (IsTesterLegal(_updatedTester))
                MyTester = _updatedTester;
        }

        public void UpdateTrainee(ref Trainee MyTrainee, Trainee _updatedTrainee)
        {
            if (IsTraineeLegal(_updatedTrainee))
                MyTrainee = _updatedTrainee;
        }
    }
}
