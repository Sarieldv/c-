﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public static class FactoryDAL  //with singleton
    {
        private static IDAL instance = null;
        public static IDAL Instance
        {
            get
            {
                if (instance==null)
                {
                    instance = new Dal_imp();
                }
                return instance;
            }
        }
    }
}
