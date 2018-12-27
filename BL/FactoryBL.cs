using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class FactoryBL
    {
        private static IBL MyBL = null;
        public IBL GetBL
        {
            get
            {
                if (MyBL == null)
                {
                    MyBL = new BL_imp();
                }
                return MyBL;
            }
        }
    }
 }
