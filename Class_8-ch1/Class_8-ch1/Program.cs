using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_8_ch1
{
    public class Program
    {
        public static List<DictionaryEntry> sort(Hashtable dirs)
        {
            var result = new List<DictionaryEntry>(dirs.Count);
            foreach (DictionaryEntry entry in dirs)
            {
                result.Add(entry);
            }
            result.Sort(
                (x, y) =>
                {
                    IComparable comparable = x.Value as IComparable;
                    if (comparable != null)
                    {
                        return comparable.CompareTo(y.Value);
                    }
                    return 0;
                });

            return result;
                     

        }

        

        public static void Main(string[] args)
        {
            /*Part 1*/
            Hashtable dirs = new Hashtable();
            try
            {
                /*Search all file*s*/
                dirs = FileSearch.fileSearch(@"D:\Task_2\Class_8-ch1\Class_8-ch1\bin\Debug\ForTest");
                /*Save in File*/
                FileSearch.writeInFile(dirs, "Result");
                /* Sort Hashtable!*/
                var result = sort(dirs);
                foreach (DictionaryEntry entry in result)
                {
                    Console.WriteLine(entry.Key.ToString() + ":" + entry.Value.ToString());
                }
              
            }
            catch (Exception e)
            { Console.WriteLine(e.Message); }


            /*Part 2*/

            Console.ReadKey();

        }
    }
}
