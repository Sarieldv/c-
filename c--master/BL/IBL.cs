using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using BE;

namespace BL
{
    public interface IBL
    {
        void AddTester(Tester NewTester);
        void EraseTester(Tester _tester);
        void UpdateTester(Tester updatedTester);

        void AddTrainee(Trainee NewTrainee);
        void EraseTrainee(Trainee _trainee);
        void UpdateTrainee(Trainee updatedTrainee);
        void GetTest(Trainee trainee, Address address, DateTime dateTime);


        void AddTest(Test NewTest);
        void CancelTest(Test _test);
        void UpdateTest(Test updatedTest);

        List<Tester> ReturnTesters();
        List<Trainee> ReturnTrainees();
        List<Test> ReturnTests();

        List<Tester> TestersByDistance(int _distance, Address address, List<Tester> _testersList);
        List<Tester> TestersByTime(DateTime _dateTime);
        List<Tester>TestsByCondition (Delegate _condition);

        int TestsDone(Trainee _trainee);
        bool CanDrive(Trainee _trainee);

        List<Test> TestsByTime(DateTime _dateTime, bool _dayOrMonth);

        int CalcDistance(Address address1, Address address2);

        List<Tester> TestersGroupedBySpecialty(bool _extraSorted);
        List<Tester> TestersGroupedByCity(bool _extraSorted);
        List<Trainee> TraineesGroupedBySchool(bool _extraSorted);
        List<Trainee> TraineesGroupedByTeacher(bool _extraSorted);
        List<Trainee> TraineesGroupedByTestAmount(bool _extraSorted);
    }
}
