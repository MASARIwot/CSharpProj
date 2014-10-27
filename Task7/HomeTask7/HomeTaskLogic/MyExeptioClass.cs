using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask7.HomeTaskLogic
{
    class MyExeptioClass : Exception
     
    {
        String str;
        public MyExeptioClass(String stri): base(stri)
        {
            this.str = stri;
        }
        public String BadPhone()
        {
            return " Bed phone number : 937027294 or 380937027294" + this.str;
        }
    }
}
