using homeTask8.Delegat;
using homeTask8.File;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using AddFileSearch;

namespace homeTask8
{
    public delegate double MathAction(double x ,double y);
    public  class Program
    {

        
        public static void Main(string[] args) 
        {
            /*
             * Task1
             */
            MyCarculator Carcul = new MyCarculator();
            MathAction delegatList = new MathAction(Carcul.DoAddition);
            delegatList += Carcul.DoDivision;
            delegatList += Carcul.DoMultiplication;
            delegatList += Carcul.DoSubtraction;

            double result = delegatList(5, 6);

            /*
             * Task2
             */
            delegatList = new MathAction(delegate(double x,double y) { return x%y; });
            
            result = delegatList(6,5);
            /*
             * Task3
             */
            FileSearch fileLook =  new FileSearch();
            string str = fileLook.searchEmailInFile("sasha.tretyak@gmail.com", "*", @"D:\Task_2\HomeTask10_Lesso7_1\homeTask8\bin\Debug");
            Console.WriteLine(str);
            


        }/*Main*/


    }/*Program*/
}
