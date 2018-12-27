using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class WeeklyWorkHours : IEnumerable
    {
        HoursInDay[] MyWeek = new HoursInDay[5];

        public IEnumerator GetEnumerator()
        {
            return MyWeek.GetEnumerator();
        }
    }
}
