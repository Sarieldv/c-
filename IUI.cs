using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;

namespace UI
{
    interface IUI
    {
        void AddTester();
        void EraseTester();
        void UpdateTester();
        void AddAnotherWeek(Tester tester);
        void RemoveFirstWeek(Tester tester);

        void AddTrainee();
        void EraseTrainee();
        void UpdateTrainee();


        void AddTest();
        void CancelTest();
        void UpdateTest();

        List<Tester> ReturnTesters();
        List<Trainee> ReturnTrainees();
        List<Test> ReturnTests();

        void TestersByDistance(int _distance, Address address);
        void TestersBusyByTime(DateTime _dateTime);
        void TestersFreeByTime(DateTime dateTime);
        void TestersByCity(Address address);
        void TestersBySpecialty(VehicleParams vehicle);
        List<Test> TestsByCondition(Func<Test, bool> _condition);

        //int TestsDone(Trainee _trainee);
        //bool CanDrive(Trainee _trainee, VehicleParams vehicle);

        //List<Test> TestsByDay(DateTime _dateTime);
        //List<Test> TestsByMonth(DateTime _dateTime);

        int CalcDistance(Address address1, Address address2);

        List<List<List<Tester>>> TestersGroupedBySpecialty(bool _extraSorted);
        List<List<Trainee>> TraineesGroupedBySchool(bool _extraSorted);
        List<List<Trainee>> TraineesGroupedByTeacher(bool _extraSorted);
        List<List<Trainee>> TraineesGroupedByTestAmount(bool _extraSorted);

        bool IsLetter(char c);
        bool IsNumber(char c);
        bool IsStringLetters(string str);
        bool IsStringNumbers(string str);
        FullName CorrectWriting(FullName name);
        void GiveOptions();
        Tester ChooseTester();
        Test ChooseTest();
        Trainee ChooseTrainee();

    }
}
