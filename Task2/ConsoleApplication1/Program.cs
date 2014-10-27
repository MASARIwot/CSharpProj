using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
        
    {
        

        Object[] dewf;
        public void setArr(Class1Worck re)
        {

        }
       public static void Main(string[] args)
        {
           /* TestClass2.exampl_4();
            TestClass2.Mystruct  struct_test = new  TestClass2.Mystruct();// =  new TestClass2();
            struct_test.var1 = 10;
            struct_test.var2 = 25;
            int a = struct_test.add();
            */

           Class1Worck classW = new Class1Worck();
           int[,] someData = new int[2,2];
           someData[1, 1] = 1990;
           someData[1, 0] = 12;
           someData[0, 1] = 26;
           classW.add("Ale","Tr","F",someData);
           Console.WriteLine(classW.toString());
           var Student = new Class1Worck("Ale", "Tr", "F", someData);
           var Student2 = new Class1Worck("Ale2", "Tr2", "F2", someData);
           var Student3 = new Class1Worck("Ale3", "Tr3", "F3", someData); 
           
           
           object[] objArr =  {
                        Student,
                        Student2,
                       Student3
           };
    

           string nameFofind = "Ale2";
           string nameFofind2 = "Ale4";
           string buff;
           
           for (int i = 0; i < 2; i++) {
               classW = (Class1Worck)objArr[i];
             
               buff = classW.getName();
               if (buff == nameFofind) { }
  
           }

 
        }
    }
}
