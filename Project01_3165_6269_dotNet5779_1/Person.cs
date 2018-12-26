using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    abstract class Person
    {

        protected int IDNumber;
        public int _IDNumber
        {
            get => IDNumber;
            set
            {
                int Sum = 0;
                int Temp = value / 10;
                for (int i = 0; i < 8; i++)
                {
                    Sum += ((Temp % 10) * (2 ^ (i % 2))) / 10 + ((Temp % 10) * (2 ^ (i % 2))) % 10;
                    Temp /= 10;
                }
                Temp = (((Sum / 10) * 10 + 10) - Sum) % 10;
                if (Temp == value % 10)
                    IDNumber = value;
                else


            }
        }

        protected FullName Name;
        protected DateTime BirthDate;
        protected Gender MyGender;
        protected int PhoneNumber;
        protected Address MyAddress;
        public abstract override string ToString();
    }
}
}
