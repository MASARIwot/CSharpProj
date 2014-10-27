using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication2
{
    public class StudentsList : InterfaceOfOption 
    {
       private object[] objArrOfStudent;
       private Student stud;
       private int namberOf;
       private int n = 0;

      public StudentsList(int namberOf) {
          this.namberOf = namberOf;
          objArrOfStudent = new object[this.namberOf];
         
       }
        public void changeStudent(int n, string name, string surName, string sex, int year, int manth, int Day)
        {
            objArrOfStudent[n] = (new Student(name, surName, sex, year, manth, Day));
        }
        public void addStudent(string name, string surName, string sex, int year, int manth, int Day)
        {int index = 0;
            if (this.n == this.namberOf)
            {   this.namberOf = this.namberOf+1;
                index = Convert.ToInt32(this.namberOf);
                Array.Resize(ref this.objArrOfStudent, index);
                
            } 
            objArrOfStudent[this.n] = (new Student(name, surName, sex, year, manth, Day));
            this.n++;
            
        }
       
        public string look(string samInfor) {

            foreach (Student stud in objArrOfStudent) {

                if (stud.structStr.name == samInfor) { return stud.structStr.printSudent(); }
                if (stud.structStr.surName == samInfor) { return stud.structStr.printSudent(); }
                if (stud.structStr.sex == samInfor) { return stud.structStr.printSudent(); }
                
            }

            return "did not exist";
        }

        public string lookByData(int year, int manth, int Days)
        {
            int iterator = 0;
            int[,] nDay = new int[2, 2];
            nDay[1, 1] = year;
            nDay[1, 0] = manth;
            nDay[0, 1] = Days;
            foreach (Student stud in objArrOfStudent)
            {
                if (stud.structStr.Day[1, 1] == nDay[1, 1] && stud.structStr.Day[1, 0] == nDay[1, 0] && stud.structStr.Day[0, 1] == nDay[0, 1]) 
                { return stud.structStr.printSudent() + " ID:" + iterator ; }
                iterator++;
            } 

            return "did not exist";
        }

        public string print2() {
            string str2 = null;
            int iterator = 0;
            foreach (Student stud in objArrOfStudent) {
                str2 += (string)stud.structStr.printSudent() + " ID:" + iterator++ + "\n";
                
            }
            return str2;
        }
        public string print()
        {
            string str2 = null;
            for(int ib = 0; ib <  getNamberOfElement(); ib++)
            {  
                str2 += (((Student)objArrOfStudent[ib]).structStr.printSudent() + " ID:" + ib + "\n");

            }
            return str2;
        }

        public void delet(int i) {
            object[] objArrOfStudentBuff = new object[getNamberOfElement() - 1];
            int iterst = 0;
            for (int ib = 0; ib < getNamberOfElement(); ib++)
            {
                if (ib == i) {continue; }
                objArrOfStudentBuff[iterst] = objArrOfStudent[ib];
                iterst++;
               
            }
            setArr(objArrOfStudentBuff);
            this.namberOf = this.namberOf - 1;
            this.n = this.n - 1;
            
        }
        private void setArr(object[] arr) {
            Array.Resize(ref this.objArrOfStudent, arr.Length);
            this.objArrOfStudent = arr;
        }
        private int getNamberOfElement()
        {
            return this.objArrOfStudent.Length;
        }
        public string getName(int i)
        {   stud = (Student)objArrOfStudent[i];
        return stud.structStr.name;
        }
        public string getSurname(int i)
        {   stud = (Student)objArrOfStudent[i];
        return stud.structStr.surName;
        }
        public string getSex(int i)
        {   stud = (Student)objArrOfStudent[i];
            return stud.structStr.sex;
        }
        public int[,] getData(int i)
        {   stud = (Student)objArrOfStudent[i];
            return stud.structStr.Day;
        }
        public void setName(string newName , int i)
        {
            ((Student)objArrOfStudent[i]).structStr.name = newName;
        }
        public void setSurName(string newSurName, int i)
        {
            ((Student)objArrOfStudent[i]).structStr.surName = newSurName;
        }
        public void setSex(string newSex, int i)
        {
            ((Student)objArrOfStudent[i]).structStr.sex = newSex;
        }
        public void setDat(int[,] newDat, int i)
        {
            ((Student)objArrOfStudent[i]).structStr.Day = newDat;
        }
        
        public string toString()
        {   
        return "number of Student" + getNamberOfElement() + "iterators :" + namberOf +","+ n;
        }

    }
}
