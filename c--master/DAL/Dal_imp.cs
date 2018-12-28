using System;
using System.Collections.Generic;
using System.Text;
using BE;
using DS;
using System.Linq;

namespace DAL
{
    internal class Dal_imp : IDAL
    {
        #region add
        public void AddTest(Test NewTest)
        {

            if (DataSource.TestsList.Any(t=>t.Number==NewTest.Number))
            {
                throw new Exception("New Test already exists.");
            }
            if(!DataSource.TraineesList.Any(t=>t.IDNumber==NewTest.TraineeId))
            {
                throw new Exception("Trainee does not exist.");
            }
            if(!DataSource.TestersList.Any(t=>t.IDNumber==NewTest.TesterId))
            {
                throw new Exception("Tester does not exist.");
            }
            DataSource.TestsList.Add(NewTest);


        }

        public void AddTester(Tester NewTester)
        {
            if (DataSource.TestersList.Any(t => t.IDNumber == NewTester.IDNumber) || DataSource.TraineesList.Any(t => t.IDNumber == NewTester.IDNumber))
            {
                throw new Exception("New Tester already exists.");
            }
            DataSource.TestersList.Add(NewTester);

        }


        // to be MOVED to UI 
        //if (!IsPhoneNumberLegal(_tester._myPhoneNumber))
        //    throw new Exception("The phone number is invalid");

        //to be MOVED to BL 
        //if (!IsTesterAgeLegal(_tester.Age()))
        //    throw new Exception(_tester._name.ToString() + "is too old to be a tester");

        //to be MOVED to UI
        //private bool IsStringLetters(string str)
        //{
        //    for (int i = 0; i < str.Length; i++)
        //    {
        //        if (!(IsCharLetter(str[i])))
        //            return false;
        //    }
        //    return true;
        //}
        //private bool IsStringNumbers(string str)
        //{
        //    for (int i = 0; i < str.Length; i++)
        //    {
        //        if (!(IsCharNumber(str[i])))
        //            return false;
        //    }
        //    return true;
        //}
        //private bool IsCharLetter(char c)
        //{
        //    if (((int)c > 64 && (int)c < 91) || ((int)c > 96 && (int)c < 123))
        //        return true;
        //    return false;
        //}
        //private bool IsCharNumber(char c)
        //{
        //    if ((int)c > 47 && (int)c < 58 )
        //        return true;
        //    return false;
        //}

        //to be MOVED to UI
        //    if (_ID.Length != 8)
        //    {
        //        return false;
        //    }
        //    if (!IsStringNumbers(_ID))
        //    {
        //        return false;
        //    }

        //to be MOVED to BL
        //        int input = int.Parse(_ID);
        //        int Sum = 0;
        //        int Temp = input / 10;
        //        for (int i = 0; i < 8; i++)
        //        {
        //            Sum += ((Temp % 10) * (2 ^ (i % 2))) / 10 + ((Temp % 10) * (2 ^ (i % 2))) % 10;
        //            Temp /= 10;
        //        }
        //        Temp = (((Sum / 10) * 10 + 10) - Sum) % 10;
        //        if (Temp != input % 10)
        //            return false;
        //        return true;

        //private bool IsPhoneNumberLegal(PhoneNumber _pn)
        //{
        //    if (!IsStringNumbers(_pn.number))
        //        return false;
        //    if (_pn.kind == 0)
        //    {
        //        if (_pn.number.Length != 10)
        //            return false;
        //    }
        //    if((int)_pn.kind==1)
        //    {
        //        if (_pn.number.Length != 9)
        //            return false;
        //    }
        //    return true;

        //}

        //private bool IsTesterAgeLegal(int _age)
        //{
        //    if (_age > Configuration.MaximumTesterAge)
        //        return false;
        //    return true;
        //}
        //private bool IsTraineeAgeLegal(int _age)
        //{
        //    if (_age < Configuration.MinimumTraineeAge)
        //        return false;
        //    return true;
        //}
        //private bool CanAddTest(Tester _tester)
        //{
        //    if (_tester._testsSignedUpFor == _tester._maximumWeeklyTests)
        //        return false;
        //    return true;
        //}
        public void AddTrainee(Trainee NewTrainee)
        {
            if (DataSource.TraineesList.Any(t => t.IDNumber == NewTrainee.IDNumber) || DataSource.TraineesList.Any(t => t.IDNumber == NewTrainee.IDNumber))
            {
                throw new Exception("New Tester already exists.");
            }
            DataSource.TraineesList.Add(NewTrainee);
        }
        #endregion
        #region erase
        public void CancelTest(Test _test)
        {
            //Tester tester = (from t in DataSource.TestersList
            //                 where _test.TesterId == t.IDNumber
            //                 select t).FirstOrDefault();
            //Trainee trainee = (from t in DataSource.TraineesList
            //                   where _test.TraineeId == t.IDNumber
            //                   select t).FirstOrDefault();
            if (!DataSource.TestsList.Any(t => _test.Number == t.Number))
            {
                throw new Exception("Test does not exist");
            }
            //tester.TestsSignedUpFor = -1;
            //trainee.HaveTest = false;
            DataSource.TestsList.Remove(_test);
        }

        public void EraseTester(Tester tester)
        {
            if (!DataSource.TestersList.Any(t => tester.IDNumber == t.IDNumber))
            {
                throw new Exception("Tester does not exist.");
            }
            DataSource.TestersList.Remove(tester);
        }
        public void EraseTrainee(Trainee trainee)
        {
            if (!DataSource.TraineesList.Any(t => trainee.IDNumber == t.IDNumber))
            {
                throw new Exception("Trainee does not exist.");
            }
            DataSource.TraineesList.Remove(trainee);
        }
        #endregion
        #region returnFromDataSource
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
        #endregion
        #region update
        public void UpdateTest(Test updatedTest)

        {
            if (!DataSource.TraineesList.Any(t => t.IDNumber == updatedTest.TraineeId))
            {
                throw new Exception("Trainee does not exist.");
            }
            if (!DataSource.TestersList.Any(t => t.IDNumber == updatedTest.TesterId))
            {
                throw new Exception("Tester does not exist.");
            }
            var k = (from t in DataSource.TestsList
                     where updatedTest.Number == t.Number
                     select t).FirstOrDefault();
            if(k==null)
            {
                throw new Exception("Test does not exist.");
            }
            CancelTest(k);
            k = updatedTest.DeepClone();
            AddTest(k);
        }

        public void UpdateTester(Tester updatedTester)
        {
            var k = (from t in DataSource.TestersList
                     where t.IDNumber == updatedTester.IDNumber
                     select t).FirstOrDefault();
            if (k == null)
            {
                throw new Exception("Tester does not exist.");
            }
            EraseTester(k);
            k = updatedTester.DeepClone();
            AddTester(k);
        }

        public void UpdateTrainee(Trainee updatedTrainee)
        {
            var k = (from t in DataSource.TraineesList
                     where t.IDNumber == updatedTrainee.IDNumber
                     select t).FirstOrDefault();
            if (k == null)
            {
                throw new Exception("Trainee does not exist.");
            }
            EraseTrainee(k);
            k = updatedTrainee.DeepClone();
            AddTrainee(k);
        }
        #endregion
    }
}