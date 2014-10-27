using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class TestClass2
    {
        public struct Mystruct {
            public int var1;
            public int var2;
            public int add() {
                return var1 +var2;
            } 
            
        
        }
        
        public enum colors : byte
        {
            Red, Blue
        }
        public static void exampl_1()
        {
              int i = 3;
              for (i = 0; i < 10; ++i)
              {
              //    Console.WriteLine(i);
              }
              switch(i)
              {
                  case 1:{Console.WriteLine(i + " ololo"); break;}
                  case 2:{Console.WriteLine(i + " ololo2"); break;}
                  default: {break;}
              }
              //*/


            //colors en = colors.Blue;
            Console.WriteLine(colors.Blue);

        }

        public static void exampl_2() { 
            int[] arr1 = new int[10];
            int[] arr2 = new int[3] { 1,2,3};
            int[] arr4 = new int[] { 1, 2, 3 };

            int[] arr3;
                arr3 = new int[3];
            int[,] arr2D = new int[2,3];
            int[,,] arr3D = new int[2,3,5];

        // not typing mass

            

        }

        public static void exampl_3()
        {
            char a = 'd';
            a++;
            Convert.ToChar("ef");
            string s = "Helo world.";
            string strNew = s.Replace('.','!'); 
            
        }
        
        public static void exampl_4() { 

            /*
             * Structure
             */


        
        }




    }
}
