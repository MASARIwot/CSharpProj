using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication2
{
    class Program
    {
                
        Program(){
                 }
                   

        static void Main(string[] args)
        {
            InterfaceOfOption studentList = new StudentsList(4);
           //some Students for testing
            studentList.addStudent("Alexandr", "Tretyak", "M", 1990, 12, 26);
            studentList.addStudent("Alexandr1", "Tretyak1", "M1", 1991, 11, 28);
            studentList.addStudent("Alexandr2", "Tretyak2", "M2", 1992, 10, 25);
            studentList.addStudent("Alexandr3", "Tretyak3", "M3", 1993, 12, 24);//*/
            studentList.addStudent("Alexansdr", "Tretyak", "M", 1990, 12, 26);
            studentList.addStudent("Alexandr3", "Tretawdyak3", "Mwd3", 1993, 12, 24);
            Console.WriteLine(studentList.print());
            
            //same console realization
            string str =null;
            while (true)
            {

                str = Console.ReadLine();
                if (str.Equals("dir"))
                {
                    Console.WriteLine("Stop  :Exit:");
                    Console.WriteLine("add   :Add Student:");
                    Console.WriteLine("print :Print All Student:");
                    Console.WriteLine("delet :Del Student");
                    Console.WriteLine("look  :Look By String");
                    Console.WriteLine("lookD :Look By Data");
                    Console.WriteLine("modif :change Student");
                    Console.WriteLine("XXXX :method like chenge name or ... relised in StudentList.class and work");
                }

                if (str.Equals("Stop")) { break; }
                if (str.Equals("add"))
                {
                    
                    string name;
                    string SurName;
                    string Sex;
                    int year;
                    int month;
                    int day;
                    try { 
                        Console.WriteLine("Name: ");
                        name = Console.ReadLine();
                        Console.WriteLine("SurName: ");
                        SurName = Console.ReadLine();
                        Console.WriteLine("Sex: ");
                        Sex = Console.ReadLine();
                        Console.WriteLine("Year: ");
                        year = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Month: ");
                        month = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Day: ");
                        day = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Done");
                        
                        studentList.addStudent(name, SurName, Sex, year, month, day);
                    }
                    catch (FormatException e)
                    {
                       Console.WriteLine( e.ToString());
                    }

                }
                if (str.Equals("print"))
                {
                    Console.WriteLine(studentList.print2());
                }
                if (str.Equals("delet"))
                {
                    try
                    {
                        int ID;
                        Console.WriteLine("ID: ");
                        ID = Convert.ToInt32(Console.ReadLine());
                        studentList.delet(ID);
                    }
                    catch (FormatException e)
                    {
                        Console.WriteLine(e.ToString());
                    }
                }
                if (str.Equals("look"))
                {
                    string name;
                    Console.WriteLine("Name Or SurName...: ");
                    name = Console.ReadLine();
                    Console.WriteLine(studentList.look(name));
                }
                if (str.Equals("lookD"))
                {
                    int year;
                    int month;
                    int day;
                    try
                    {
                        Console.WriteLine("Year: ");
                        year = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Month: ");
                        month = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Day: ");
                        day = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(studentList.lookByData(year, month, day));
                    }
                    catch (FormatException e)
                    {
                        Console.WriteLine(e.ToString());
                    }

                }
                if (str.Equals("modif"))
                {

                    string name;
                    string SurName;
                    string Sex;
                    int year;
                    int month;
                    int day;
                    int ID;
                    try
                    {
                        Console.WriteLine("ID: ");
                        ID = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Name: ");
                        name = Console.ReadLine();
                        Console.WriteLine("SurName: ");
                        SurName = Console.ReadLine();
                        Console.WriteLine("Sex: ");
                        Sex = Console.ReadLine();
                        Console.WriteLine("Year: ");
                        year = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Month: ");
                        month = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Day: ");
                        day = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Done");

                        studentList.changeStudent(ID,name, SurName, Sex, year, month, day);
                    }
                    catch (FormatException e)
                    {
                        Console.WriteLine(e.ToString());
                    }


                }







            }
            
            
        }
    }
}
