using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask4
{
     /*
     * 
     * Part For Home Task #5 
     * 
     */
 public   class MyExeptioClass : Exception
 {
     String str;
     public MyExeptioClass(String stri) : base (stri)
 {
         this.str = stri;
     
     }
        public String SameEmail() {
            return "My Super Exeption!!!" + this.str;
        }
    }
}
