using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeTask8.File
{
    public static class AddFileSearch
    {
         public static string searchEmailInFile(this FileSearch fsch, string email ,string sameNameOfFile,string directory) 
         {
             string[] directoryList = fsch.fileSearch(directory, sameNameOfFile);

             String emails = null;
             foreach (string dir in directoryList)
             {
                 String text = System.IO.File.ReadAllText(dir);
                 if (text.Contains(email)) 
                 { 
                     emails += email + " Dir:" + dir + "\n"; 
                 }
             }
             return emails;

         }/*searchEmailInFile*/

         
    }/*AddFileSearch*/
}
