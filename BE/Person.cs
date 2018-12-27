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
        public string _IDNumber => IDNumber;
        protected FullName Name;
        public FullName _name => Name;
        protected DateTime BirthDate;
        public DateTime _birthDate => BirthDate;
        protected Gender MyGender;
        public Gender _myGender => MyGender;
        protected PhoneNumber MyPhoneNumber;
        public PhoneNumber _myPhoneNumber => MyPhoneNumber;
        protected Address MyAddress;
        public Address _myAddress => MyAddress;
        public int Age()
        {
            return DateTime.Now.Year - _birthDate.Year;
        }
        public abstract override string ToString();
    }
}
