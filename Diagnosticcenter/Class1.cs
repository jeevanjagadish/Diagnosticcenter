using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diagnosticcenter
{
    public class Class1
    {
        public static String UserName;
        public Class1(String Username)
        {
            UserName  =  Username;
        }
        public static String getUsername()
        {
            return UserName;
        }
    }
}
