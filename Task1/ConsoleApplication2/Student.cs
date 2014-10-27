using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication2
{
    public class Student
    {
        public StudentStruct structStr;
        public Student()
        {
           
        }
        public Student(string name, string surName, string sex, int year, int manth, int Days)
        {
            structStr.name = @name;
            structStr.surName = surName;
            structStr.sex = sex;
            int[,] nDay = new int[2, 2];
            nDay[1, 1] = year;
            nDay[1, 0] = manth;
            nDay[0, 1] = Days;
            structStr.Day = nDay;
        }
       
        public struct StudentStruct
        {
            public string @name ;// { get; set;}
            public string surName;
            public string sex ;
            public int[,] Day ;
            public string printSudent()
            {
                return ":" + name + ":" + surName + ":" + sex + ":" + Day[1, 1] + "-" + Day[1, 0] + "-" + Day[0, 1];
            }

        }
               
    }
}
