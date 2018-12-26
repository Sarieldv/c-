using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public abstract class Person
    {

        protected string IDNumber;
        public string _IDNumber
        {
            get => IDNumber;
            set
            {
                int input = int.Parse(value);
                int Sum = 0;
                int Temp = input / 10;
                for (int i = 0; i < 8; i++)
                {
                    Sum += ((Temp % 10) * (2 ^ (i % 2))) / 10 + ((Temp % 10) * (2 ^ (i % 2))) % 10;
                    Temp /= 10;
                }
                Temp = (((Sum / 10) * 10 + 10) - Sum) % 10;
                if (Temp == input % 10)
                    IDNumber = value;
                else
                    throw new NotImplementedException();

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
