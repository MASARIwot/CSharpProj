using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
   public class Class1Worck
    {
        public Student structStr;
        enum Day : byte { Man,Tusd,Firs,Thurs,Fri,Sors,SamDat
            
        }
        public struct Student {
            public string name;
            public string surName;
            public string sex;
            public int[,] Day;
            public string printSudent() {
                return ":" + name + ":" + surName + ":" + sex + ":" + Day[1, 1]+ "-"+ Day[1, 0] +"-"+Day[0,1];
            }
            
        }
        public Class1Worck()
        {
         }
        public Class1Worck(string name, string surName, string sex, int[,] Day)
        {
            structStr.name = name;
            structStr.surName = surName;
            structStr.sex = sex;
            structStr.Day = Day;

        }
        public void add(string name,string surName,string sex, int[,] Day) {
            
            structStr.name = name;
            structStr.surName = surName;
            structStr.sex = sex;
            structStr.Day = Day;

      
        }
        public string getName() {
            return (string)structStr.name;
        }
        public void setName(string newName) {
            structStr.name = newName;   
        
        }
        public void setYear(int year)
        {
            structStr.Day[1,1] = year;

        }
        public string toString()
        {
            Console.Write(Day.SamDat);
            return structStr.printSudent();
        }

      
        /*public Boolean equals(Object obj) { 
            return
        }*/

    }
}
