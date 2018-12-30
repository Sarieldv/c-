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

        public void AddTest()
        {
            string testerId;
            string traineeId;
            VehicleParams vehicle;
            char a;
            Console.WriteLine("Please enter tester ID:");
            do
            {
                testerId = Console.ReadLine();
                if (testerId.Length != 9)
                {
                    Console.WriteLine("The tester ID number is the wrong length. Please reenter the ID:");
                }
                if (!IsStringNumbers(testerId))
                {
                    Console.WriteLine("The tester ID number entered contains characters that are not numbers. Please reenter the ID:");
                }
            } while (testerId.Length != 9 || !IsStringNumbers(testerId));
            Console.WriteLine("Please enter trainee ID:");
            do
            {
                traineeId = Console.ReadLine();
                if (traineeId.Length != 9)
                {
                    Console.WriteLine("The trainee ID number is the wrong length. Please reenter the ID:");
                }
                if (!IsStringNumbers(traineeId))
                {
                    Console.WriteLine("The trainee ID number entered contains characters that are not numbers. Please reenter the ID:");
                }
            } while (traineeId.Length != 9 || !IsStringNumbers(traineeId));
            do
            {
                Console.WriteLine("For a test on an automatic gearbox, press 0. For a test on a manual gearbox, press 1.");
                a = Console.ReadLine()[0];
                switch (a)
                {
                    case '0':
                        {
                            vehicle.GearBoxType = GearBox.Automatic;
                            break;
                        }
                    case '1':
                        {
                            vehicle.GearBoxType = GearBox.Manual;
                            break;
                        }
                    default:
                        {


                            break;
                        }
                }
            } while ((int)a != 48 && (int));
            

        }

        public void AddTester()
        {
            throw new NotImplementedException();
        }

        public void AddTrainee()
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
            correction.FirstName[0].ToString().ToUpper();
            correction.LastName.ToLower();
            correction.LastName[0].ToString().ToUpper();
            return correction;
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
