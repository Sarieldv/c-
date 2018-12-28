using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class FullName
    {
        public readonly string FirstName;
        public readonly string LastName;
        FullName(string _firstName, string _lastName)
        {
            FirstName = _firstName;
            LastName = _lastName;
        }
        public override string ToString()
        {
            return FirstName + " " + LastName;
        }
    }

}
