using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeTask8
{
    public class FileSearch
    {
               
        public static string[] fileSearch(string directory, string name)
        {
            try
            {
                string[] dirs = (Directory.GetFiles(directory, name));
                if (dirs.Length == 0) { string[] dirs2 = { "Did not see sach file"}; return dirs2; }
                return dirs;
               
            }
            catch (Exception e)
            {
               throw new Exception();
            }
            
        }/*fileSearch()*/

       

    }
}
