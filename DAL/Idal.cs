using System;
using System.Collections.Generic;
using System.Text;
using BE;

namespace DAL
{
    interface Idal
    {
        void AddTester(Tester NewTester );
        void EraseTester(string _IDNumber);
        void UpdateTester(ref Tester MyTester);
        void AddTrainee(Trainee NewTrainee);
        void EraseTrainee(string _IDNumber);
        void UpdateTrainee(ref Trainee MyTrainee);
        void AddTest(Tester tester, Trainee trainee, Address _AddressOfDeparture, DateTime _DateAndTime);
        void UpdateTest(ref Test MyTest);
        List<Tester> ReturnTesters();
        List<Trainee> ReturnTrainees();
        List<Test> ReturnTests();
    }
}
