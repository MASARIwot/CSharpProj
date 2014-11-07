using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_8_ch1
{
    public class MyCarculator<T> where T : struct
    {
        
        public MyCarculator() {

        }
        /*
         * Method Of Carculator
         */
        public T ADD(T a, T b) { return Sum(a, b); }
        public T Division(T a, T b) { return DoDivision(a, b); }
        public T Multiplication(T a, T b) { return DoMultiplication(a, b); }
        public T Subtraction(T a, T b) { return DoSubtraction(a, b); }

        /*
         * additional method*s for Carculator operation
         */
        private static dynamic Sum(dynamic a ,dynamic b)
        {
            dynamic sum = a + b;
            return sum;
        }
        private static dynamic DoDivision(dynamic a, dynamic b)
        {
            if (b == 0) throw new DivideByZeroException(); 
            dynamic sum = a / b;
            return sum;
        }
        private static dynamic DoMultiplication(dynamic a, dynamic b)
        {
            dynamic sum = a * b;
            return sum;
        }
        private static dynamic DoSubtraction(dynamic a, dynamic b)
        {
            dynamic sum = a - b;
            return sum;
        }
       

    }
}
