using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Class_8_ch1
{
    public class FileSearch
    {
        /// <summary>
        /// This methood return Hashtable<NameOfFile,expansion>
        /// </summary>
        /// <param name="directory"></param>
        /// <returns></returns>
        public static Hashtable fileSearch(string directory)
        {
            try
            {
                DirectoryInfo d = new DirectoryInfo(directory);//Assuming Test is your Folder
                FileInfo[] Files = d.GetFiles(); //Getting All files
                StringBuilder str = new StringBuilder();
                if (Files.Length == 0) { return null; }
                foreach (FileInfo file in Files)
                {
                    str.Append(file.Name);
                    str.Append(" ");
                }

                return createCollectionOfFileName(str.ToString());

            }
            catch (Exception e)
            {
                //Console.WriteLine(e.Message);
                throw new Exception();
            }

        }/*fileSearch()*/
        /// <summary>
        /// this is additional meyhod for (@see) method fileSearch.
        /// it*s create Hashtable<NameOfFile,expansion> from String 
        /// this string he take from method fileSearch
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        private static Hashtable createCollectionOfFileName(string fileName)
        {   
            string[] strArr = fileName.Split(' ');
            //create
            Hashtable resultCollection = new Hashtable();
            for (int i = 0; i < strArr.Length - 1; i++)
            {
                string[] separated = strArr[i].Split('.');
                resultCollection.Add(separated[0], separated[1]);
            }
            return resultCollection;
        }/*createCollectionOfFileName*/
        /// <summary>
        /// This method is serialize information from Hashtable to File
        /// </summary>
        /// <param name="tabelForSave"></param>
        /// <param name="pathName"></param>
        public static void writeInFile(Hashtable tabelForSave, string pathName)
        {
            IFormatter formatter = new BinaryFormatter();
            using (FileStream save = new FileStream(pathName, FileMode.Create))
            {
                formatter.Serialize(save, tabelForSave);
            }



        }



    }
}
