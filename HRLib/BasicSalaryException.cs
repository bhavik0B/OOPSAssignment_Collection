using System;
using System.Collections.Generic;
using System.Text;

namespace HRLib
{
    public class BasicSalaryException:Exception
    {
        public BasicSalaryException(string msg):base(msg){}
    }
}
