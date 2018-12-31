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
            string traineeId;
            Trainee trainee;
            DateTime myDate = new DateTime();
            //VehicleParams vehicle = new VehicleParams();
            char a;
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
                if ((from t in ReturnTrainees() where t.IDNumber == traineeId select t).FirstOrDefault() == null && IsStringLetters(traineeId) && traineeId.Length == 9)
                {
                    Console.WriteLine("A trainee with this ID does not exist");
                }
            } while (traineeId.Length != 9 || !IsStringNumbers(traineeId) || (from t in ReturnTrainees() where t.IDNumber == traineeId select t).FirstOrDefault() == null);
            trainee = (from t in ReturnTrainees() where t.IDNumber == traineeId select t).FirstOrDefault();
            //do
            //{
            //    Console.WriteLine("For a test on an automatic gearbox, press 0. For a test on a manual gearbox, press 1.");
            //    a = Console.ReadLine()[0];
            //    switch (a)
            //    {
            //        case '0':
            //            {
            //                vehicle.GearBoxType = GearBox.Automatic;
            //                break;
            //            }
            //        case '1':
            //            {
            //                vehicle.GearBoxType = GearBox.Manual;
            //                break;
            //            }
            //        default:
            //            {
            //                Console.WriteLine("The input is not valid. Please try again.");
            //                break;
            //            }
            //    }
            //} while ((int)a != 48 && (int)a != 49);
            //do
            //{
            //    Console.WriteLine("For a test on a two wheel vehicle press 0. For a test on a private vehicle press 1. For a test on a medium truck press 2. For a test on a heavy truck press 3.");
            //    a = Console.ReadLine()[0];
            //    switch (a)
            //    {
            //        case '0':
            //            {
            //                vehicle.VehicleType = Vehicle.TwoWheelVehicle;
            //                break;
            //            }
            //        case '1':
            //            {
            //                vehicle.VehicleType = Vehicle.PrivateVehicle;
            //                break;
            //            }
            //        case '2':
            //            {
            //                vehicle.VehicleType = Vehicle.MediumTruck;
            //                break;
            //            }
            //        case '3':
            //            {
            //                vehicle.VehicleType = Vehicle.HeavyTruck;
            //                break;
            //            }
            //        default:
            //            {
            //                Console.WriteLine("The input is not valid. Please try again.");
            //                break;
            //            }
            //    }
            //} while ((int)a < 48 || (int)a > 51);
            if (FactoryBL.Instance.GetAvailableDatesForTest((from t in ReturnTrainees() where t.IDNumber == traineeId select t).FirstOrDefault()) == null)
            {
                var c = (from t in ReturnTesters()
                         where t.MaxDistanceFromTest >= CalcDistance(trainee.MyAddress, t.MyAddress)
                         select t);
                var k = FactoryBL.Instance.TestersBySpecialty(trainee.TraineeVehicle).Intersect(c);
                foreach (var item in k)
                {
                    AddAnotherWeek(item);
                }
            }
            int i = 0;
            do
            {
                i = 0;
                foreach (DateTime date in FactoryBL.Instance.GetAvailableDatesForTest((from t in ReturnTrainees() where t.IDNumber == traineeId select t).FirstOrDefault()))
                {

                    Console.WriteLine("To choose date: " + date.ToString() + "press " + i.ToString());
                    i++;
                }
                a = Console.ReadLine()[0];
                if ((int)a < '0' || (int)a >= i)
                {
                    Console.WriteLine("Invalid Input. Please try again.");
                }
            }
            while ((int)a < '0' || (int)a >= i);
            i = 0;
            foreach (var item in FactoryBL.Instance.GetAvailableDatesForTest((from t in ReturnTrainees() where t.IDNumber == traineeId select t).FirstOrDefault()))
            {
                if (int.Parse(a.ToString()) == i)
                {
                    myDate = item;
                    break;
                }
                i++;
            }
            FactoryBL.Instance.GetTest(trainee, myDate);
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
            return FactoryBL.Instance.CalcDistance(address1, address2);
        }

        public void CancelTest()
        {
            try
            {
                FactoryBL.Instance.CancelTest(ChooseTest());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        public bool CanDrive(Trainee _trainee, VehicleParams vehicle)
        {
            throw new NotImplementedException();
        }

        public Test ChooseTest()
        {
            char c;
            int i;
            do
            {
                i = 0;
                foreach (var item in ReturnTests())
                {
                    Console.WriteLine("To choose test: " + item.ToString() + "press " + i.ToString());
                    i++;
                }
                c = Console.ReadLine()[0];
                if ((int)c < '0' || (int)c >= i)
                {
                    Console.WriteLine("Invalid Input. Please try again.");
                }
            }
            while ((int)c < '0' || (int)c >= i);
            i = 0;
            foreach (var item in ReturnTests())
            {
                if (int.Parse(c.ToString()) == i)
                {
                    return item;
                }
                i++;
            }
            return null;
        }

        public Tester ChooseTester()
        {
            char c;
            int i;
            do
            {
                i = 0;
                foreach (var item in ReturnTesters())
                {
                    Console.WriteLine("To choose tester: " + item.ToString() + "press " + i.ToString());
                    i++;
                }
                c = Console.ReadLine()[0];
                if ((int)c < '0' || (int)c >= i)
                {
                    Console.WriteLine("Invalid Input. Please try again.");
                }
            }
            while ((int)c < '0' || (int)c >= i);
            i = 0;
            foreach (var item in ReturnTesters())
            {
                if (int.Parse(c.ToString()) == i)
                {
                    return item;
                }
                i++;
            }
            return null;
        }

        public Trainee ChooseTrainee()
        {
            char c;
            int i;
            do
            {
                i = 0;
                foreach (var item in ReturnTrainees())
                {
                    Console.WriteLine("To choose trainee: " + item.ToString() + "press " + i.ToString());
                    i++;
                }
                c = Console.ReadLine()[0];
                if ((int)c < '0' || (int)c >= i)
                {
                    Console.WriteLine("Invalid Input. Please try again.");
                }
            }
            while ((int)c < '0' || (int)c >= i);
            i = 0;
            foreach (var item in ReturnTrainees())
            {
                if (int.Parse(c.ToString()) == i)
                {
                    return item;
                }
                i++;
            }
            return null;
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

        public void EraseTester()
        {
            try
            {
                FactoryBL.Instance.EraseTester(ChooseTester());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        public void EraseTrainee()
        {
            try
            {
                FactoryBL.Instance.EraseTrainee(ChooseTrainee());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
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
                if (!IsLetter(letter))
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
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            return FactoryBL.Instance.ReturnTrainees();
        }

        public void TestersBusyByTime(DateTime _dateTime)
        {
            if (FactoryBL.Instance.TestersBusyByTime(_dateTime) == null)
            {
                Console.WriteLine("There are no testers busy at this time.");
            }
            else
            {
                foreach (var item in FactoryBL.Instance.TestersBusyByTime(_dateTime))
                {
                    Console.WriteLine(item.ToString() + "\n");
                }
            }
        }

        public void TestersByCity(Address address)
        {
            throw new NotImplementedException();
        }

        public void TestersByDistance(int _distance, Address address)
        {
            if (FactoryBL.Instance.TestersByDistance(_distance, address) == null)
            {
                Console.WriteLine("There are no testers in this distance from this address.");
            }
            else
            {
                foreach (var item in FactoryBL.Instance.TestersByDistance(_distance, address))
                {
                    Console.WriteLine(item.ToString() + "\n");
                }
            }
        }

        public void TestersBySpecialty(VehicleParams vehicle)
        {
            throw new NotImplementedException();
        }

        public void TestersFreeByTime(DateTime dateTime)
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

        public void UpdateTest()
        {
            Test test = ChooseTest();
            char a;
            bool distanceKeep, reverseParking, parking, lookingAtMirrors, junction, reversing, roundAbout, overTaking, grade, turning;
            string testerNote;
            do
            {
                Console.WriteLine("For distanceKeep: If you would like to enter failed, press 0. If you would like to enter passed press 1.");
                a = Console.ReadLine()[0];
                switch (a)
                {
                    case '0':
                        {
                            distanceKeep = false;
                            break;
                        }
                    case '1':
                        {
                            distanceKeep = true;
                            break;
                        }
                    default:
                        break;
                }
                if (a != '0' && a != '1')
                {
                    Console.WriteLine("Invalid input. Please enter again.");
                }
            } while (a != '0' && a != '1');
            do
            {
                Console.WriteLine("For reverseParking: If you would like to enter failed, press 0. If you would like to enter passed press 1.");
                a = Console.ReadLine()[0];
                switch (a)
                {
                    case '0':
                        {
                            reverseParking = false;
                            break;
                        }
                    case '1':
                        {
                            reverseParking = true;
                            break;
                        }
                    default:
                        break;
                }
                if (a != '0' && a != '1')
                {
                    Console.WriteLine("Invalid input. Please enter again.");
                }
            } while (a != '0' && a != '1');
            do
            {
                Console.WriteLine("For parking: If you would like to enter failed, press 0. If you would like to enter passed press 1.");
                a = Console.ReadLine()[0];
                switch (a)
                {
                    case '0':
                        {
                            parking = false;
                            break;
                        }
                    case '1':
                        {
                            parking = true;
                            break;
                        }
                    default:
                        break;
                }
                if (a != '0' && a != '1')
                {
                    Console.WriteLine("Invalid input. Please enter again.");
                }
            } while (a != '0' && a != '1');
            do
            {
                Console.WriteLine("For lookingAtMirrors: If you would like to enter failed, press 0. If you would like to enter passed press 1.");
                a = Console.ReadLine()[0];
                switch (a)
                {
                    case '0':
                        {
                            lookingAtMirrors = false;
                            break;
                        }
                    case '1':
                        {
                            lookingAtMirrors = true;
                            break;
                        }
                    default:
                        break;
                }
                if (a != '0' && a != '1')
                {
                    Console.WriteLine("Invalid input. Please enter again.");
                }
            } while (a != '0' && a != '1');
            do
            {
                Console.WriteLine("For junction: If you would like to enter failed, press 0. If you would like to enter passed press 1.");
                a = Console.ReadLine()[0];
                switch (a)
                {
                    case '0':
                        {
                            junction = false;
                            break;
                        }
                    case '1':
                        {
                            junction = true;
                            break;
                        }
                    default:
                        break;
                }
                if (a != '0' && a != '1')
                {
                    Console.WriteLine("Invalid input. Please enter again.");
                }
            } while (a != '0' && a != '1');
            do
            {
                Console.WriteLine("For reversing: If you would like to enter failed, press 0. If you would like to enter passed press 1.");
                a = Console.ReadLine()[0];
                switch (a)
                {
                    case '0':
                        {
                            reversing = false;
                            break;
                        }
                    case '1':
                        {
                            reversing = true;
                            break;
                        }
                    default:
                        break;
                }
                if (a != '0' && a != '1')
                {
                    Console.WriteLine("Invalid input. Please enter again.");
                }
            } while (a != '0' && a != '1');
            do
            {
                Console.WriteLine("For roundAbout: If you would like to enter failed, press 0. If you would like to enter passed press 1.");
                a = Console.ReadLine()[0];
                switch (a)
                {
                    case '0':
                        {
                            roundAbout = false;
                            break;
                        }
                    case '1':
                        {
                            roundAbout = true;
                            break;
                        }
                    default:
                        break;
                }
                if (a != '0' && a != '1')
                {
                    Console.WriteLine("Invalid input. Please enter again.");
                }
            } while (a != '0' && a != '1');
            do
            {
                Console.WriteLine("For turning: If you would like to enter failed, press 0. If you would like to enter passed press 1.");
                a = Console.ReadLine()[0];
                switch (a)
                {
                    case '0':
                        {
                            turning = false;
                            break;
                        }
                    case '1':
                        {
                            turning = true;
                            break;
                        }
                    default:
                        break;
                }
                if (a != '0' && a != '1')
                {
                    Console.WriteLine("Invalid input. Please enter again.");
                }
            } while (a != '0' && a != '1');
            do
            {
                Console.WriteLine("For overTaking: If you would like to enter failed, press 0. If you would like to enter passed press 1.");
                a = Console.ReadLine()[0];
                switch (a)
                {
                    case '0':
                        {
                            overTaking = false;
                            break;
                        }
                    case '1':
                        {
                            overTaking = true;
                            break;
                        }
                    default:
                        break;
                }
                if (a != '0' && a != '1')
                {
                    Console.WriteLine("Invalid input. Please enter again.");
                }
            } while (a != '0' && a != '1');
            do
            {
                Console.WriteLine("For grade: If you would like to enter failed, press 0. If you would like to enter passed press 1.");
                a = Console.ReadLine()[0];
                switch (a)
                {
                    case '0':
                        {
                            grade = false;
                            break;
                        }
                    case '1':
                        {
                            grade = true;
                            break;
                        }
                    default:
                        break;
                }
                if (a != '0' && a != '1')
                {
                    Console.WriteLine("Invalid input. Please enter again.");
                }
            } while (a != '0' && a != '1');
            Console.WriteLine("Please enter tester's note.");
            testerNote = Console.ReadLine();
            FactoryBL.Instance.UpdateTest(new Test(test, ))
        }  
        public void UpdateTester()
        {
            throw new NotImplementedException();
        }

        public void UpdateTrainee()
        {
            throw new NotImplementedException();
        }
    }
}
