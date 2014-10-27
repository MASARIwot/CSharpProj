using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class FirstHome{
        
        static void Main(string[] args){

            /*
             * second Task
             */
            Console.WriteLine("second Task");
            int strConsole;
            while (true)
            {
                 Console.WriteLine("Enter n >100");
                 strConsole = Convert.ToInt32(Console.ReadLine());
                if (strConsole > 100) { break;}
            }
            Console.WriteLine("Result:" + (new Logic()).secondTask(strConsole));
            /*
             * first Task
             */
            Console.WriteLine("first Task");
            Logic forFirstTask = new Logic();
            int afirst;
            int nfirst;
            Console.Write("Enter a ");
            afirst = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("Enter ^n ");
            nfirst = Convert.ToInt32(Console.ReadLine());

            Console.Write("Result Task1 : ");
            Console.Write( forFirstTask.firstTask(afirst, nfirst));
            /*
             * Stop program by writing in console "stop"
             */
            while (true) 
            {
                if (Console.ReadLine().Equals("stop")) { break; }
            }
        }
    }
}
