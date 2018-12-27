using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using BE;

namespace BL
{
    interface IBL
    {
        
        void AddTester(Tester NewTester);
        void EraseTester(Tester _tester);
        void UpdateTester(ref Tester MyTester, Tester _updatedTester);
        void AddTrainee(Trainee NewTrainee);
        void EraseTrainee(Trainee _trainee);
        void UpdateTrainee(ref Trainee MyTrainee, Trainee _updatedTrainee);
        void AddTest(ref Tester tester, Trainee trainee, Address _AddressOfDeparture, DateTime _DateAndTime);
        void UpdateTest(ref Test MyTest, Test _updatedTest);
        void CancelTest(Test _test);
        List<Tester> ReturnTesters();
        List<Trainee> ReturnTrainees();
        List<Test> ReturnTests();
        
    }
}
