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
        void UpdateTester(ref Tester MyTester, Tester _updatedTester);

        void AddTrainee(Trainee NewTrainee);
        void EraseTrainee(Trainee _trainee);
        void UpdateTrainee(ref Trainee MyTrainee, Trainee _updatedTrainee);
        void UpdateTrainee(Trainee updatedTrainee);

        void AddTest(ref Tester _tester, ref Trainee _trainee, Address _AddressOfDeparture, DateTime _DateAndTime);
        void UpdateTest(ref Test MyTest, Test _updatedTest);
        void CancelTest(Test _test);

        List<Tester> ReturnTesters();
        List<Trainee> ReturnTrainees();
        List<Test> ReturnTests();

        List<Tester> TestersByDistance(int _distance, Address address, List<Tester> _testersList);
        List<Tester> TestersByTime(DateTime _dateTime);
        List<Tester>TestsByCondition (Delegate _condition);

        int TestsDone(Trainee _trainee);
        bool CanDrive(Trainee _trainee);

        List<Test> TestsByTime(DateTime _dateTime, bool _dayOrMonth);
        List<Tester> TestersGroupedBySpecialty(bool _extraSorted);
        List<Trainee> TraineesGroupedBySchool(bool _extraSorted);
        List<Trainee> TraineesGroupedByTeacher(bool _extraSorted);
        List<Trainee> TraineesGroupedByTestAmount(bool _extraSorted);
    }
}
