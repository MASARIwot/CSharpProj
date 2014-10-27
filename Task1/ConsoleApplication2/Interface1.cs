using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication2
{
     interface InterfaceOfOption
    {

         void changeStudent(int n, string name, string surName, string sex, int year, int manth, int Day);
         void addStudent(string name, string surName, string sex, int year, int manth, int Day);
         string look(string samInfor); 
         string lookByData(int year, int manth, int Days);
         string print2(); //diferent realization of print
         string print(); //diferent realization of print
         void delet(int i); 
         string getName(int i);
         string getSurname(int i);
         string getSex(int i);
         int[,] getData(int i);
         void setName(string newName , int i);
         void setSurName(string newSurName, int i);
         void setSex(string newSex, int i);
         void setDat(int[,] newDat, int i);        
         string toString(int i);
               
    }
}
