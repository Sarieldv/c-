using System;
using System.Collections.Generic;
using System.Text;
using BE;

namespace DAL
{
    public interface IDAL
    {
        void AddTester(Tester NewTester );
        void EraseTester(Tester _tester);
        void UpdateTester(ref Tester MyTester, Tester _updatedTester);
        void AddTrainee(Trainee NewTrainee);
        void EraseTrainee(Trainee _trainee);
        void UpdateTrainee(ref Trainee MyTrainee, Trainee _updatedTrainee);
        void AddTest(ref Tester tester, ref Trainee trainee, Address _AddressOfDeparture, DateTime _DateAndTime);
        void UpdateTest(ref Test MyTest, Test _updatedTest);
        void CancelTest(Test _test, ref Tester _tester, ref Trainee _trainee);
        List<Tester> ReturnTesters();
        List<Trainee> ReturnTrainees();
        List<Test> ReturnTests();
    }
}
