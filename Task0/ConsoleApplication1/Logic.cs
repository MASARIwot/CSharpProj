using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Logic{

        public Logic(){

        }
        /*
         * This is for Task 1
         * return a!+a^n
         */
        public int firstTask(int a ,int n){
            return factorial(a) + powMY(a, n);
        }
        /*
         * This is for Task 2
         * return int 1x5y->1y5x
         */
        public int secondTask(int n){
            
            StringBuilder strBild = new StringBuilder();
            strBild.Append(Convert.ToString(n));
            /*
             * Take first element
             */
            char str2 = strBild[1];
            /*
             * Take last element
             */
            char str3 = strBild[strBild.Length - 1];
            /*
             * changes elements
             */
            strBild[strBild.Length - 1] = str2;
            strBild[1] = str3;

        return Convert.ToInt32(strBild.ToString());
        }
        /*
         * Factorial with for()..
         * return n!
         */
        private  int factorialOld(int n){
            int res = 1;
            for (int i = 2; i <= n; i++)
            {
                res *= i;
            }
            return res;
        }
        /*
         * Factorial with recursion
         * return n!
         */
        private  int factorial(int i){
            int result;

            if (i == 1) return 1;
            result = factorial(i - 1) * i;
            return result;
        }
        /*
         * return a^n
         */
        private int powMY(int a , int n){
            int iterator = 0;
            int k = 1;
            while (iterator != n)
            {
                iterator++;
                k *= a;
                
            }
            return k;
        }
       
    }
}
