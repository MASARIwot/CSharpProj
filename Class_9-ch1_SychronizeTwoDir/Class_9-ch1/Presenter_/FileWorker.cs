using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_9_ch1
{
    /// <summary>
    /// This class is work with Form.-> Business Logic class
    /// </summary>
    public sealed class FileWorker
    {
        /********************_Singelton_************************************/
        private static volatile FileWorker instance;

        /// <summary>
        /// Get Instance of Class
        /// </summary>
        public static FileWorker Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new FileWorker();
                }
                return instance;
            }
        }
        /********************_Singelton_************************************/
        //Dir for file Synchronize
        public string dir1 { get; set; }
        public string dir2 { get; set; }
        
        //Label result Dir For Sychronize TRUE-dir1 FALSE-dir2
        public bool dirForSychronize { get; set; }
        //File to Delet
        public string fileToDelet { get; set; }
        //File to ADD
        public string fileToADD { get; set; }
        public FileWorker() 
        {

        }
        /// <summary>
        /// This method is ADD File from choice directory
        /// (see)FileWorker.dirForSychronize {get set}
        /// </summary>
        /// <param name="nameOfFile">Name Of File To ADD</param>
        public void addFileToDirectory(string nameOfFile) 
        {
            ArrayList arrDir1 = getfileName(dir1);
            ArrayList arrDir2 = getfileName(dir2);
            try
            {
                if (dirForSychronize == true)
                {
                    if (!arrDir1.Contains(nameOfFile)) { File.Create((dir1 + nameOfFile)); }
                }
                else if (dirForSychronize == false)
                {
                    if (!arrDir2.Contains(nameOfFile)) { File.Create((dir2 + nameOfFile)); }
                }
            }
            catch (UnauthorizedAccessException rr) { throw new UnauthorizedAccessException(rr.Message); }

        }
        /// <summary>
        ///  This method is delet File from choice directory
        ///  (see)FileWorker.dirForSychronize {get set}
        /// </summary>
        /// <param name="fileForDelet">Name Of File to Delet</param>
        public void removeFileFromDir(string fileForDelet)
        {
            ArrayList arrDir1 = getfileName(dir1);
            ArrayList arrDir2 = getfileName(dir2);
            try
            { //Label result Dir For dirForSychronize = TRUE-dir1 FALSE-dir2
                if (dirForSychronize == true)
                {
                    if (arrDir1.Contains(fileForDelet)) { File.Delete((dir1+fileForDelet)); }
                }
                else if (dirForSychronize == false)
                {
                    if (arrDir2.Contains(fileForDelet)) { File.Delete((dir2 + fileForDelet)); }
                }

            }
            catch (FileNotFoundException e) { throw new FileNotFoundException(e.FileName); }

        }
        /// <summary>
        /// This method is sychronize directory
        /// (see)FileWorker.dirForSychronize {get set} if TRUE-dir1 , FALSE-dir2
        /// </summary>
        public void sychronizeDir() 
        {
            ArrayList arrDir1 = getfileName(dir1);
            ArrayList arrDir2 = getfileName(dir2);
            //Label result Dir For dirForSychronize = TRUE-dir1 FALSE-dir2
            try
            {
                if (dirForSychronize == true)
                {
                    for (int i = 0; i < arrDir1.Count; i++)
                    {
                        if (!arrDir2.Contains(arrDir1[i])) { File.Copy((dir1 + arrDir1[i]), (dir2 + arrDir1[i])); } 
                    }
                    for (int i = 0; i < arrDir2.Count; i++)
                    {
                        if (!arrDir1.Contains(arrDir2[i])) { File.Delete((dir2 + arrDir2[i])); }
                    }
                }
                else if (dirForSychronize == false)
                {
                    for (int i = 0; i < arrDir2.Count; i++)
                    {
                        if (!arrDir1.Contains(arrDir2[i])) { File.Copy((dir2 + arrDir2[i]), (dir1 + arrDir2[i])); }
                    }
                    for (int i = 0; i < arrDir1.Count; i++)
                    {
                        if (!arrDir2.Contains(arrDir1[i])) { File.Delete((dir1 + arrDir1[i])); }
                    }
                }

            }
            catch (FileNotFoundException e) { throw new FileNotFoundException(e.FileName); }
            catch (IOException e2) { throw new IOException(e2.Message); }
       
        }
        /// <summary>
        /// Additional method*s get*s file name from directory
        /// </summary>
        /// <param name="directory">directory(path)</param>
        /// <returns></returns>
        private ArrayList getfileName(string directory)
        {
            ArrayList arrStrResult = new ArrayList();
            if (directory != null)
            {
                foreach (string st in fileSearch(directory))
                {
                    arrStrResult.Add(st.ToString().Replace((directory), " "));
                }

            }
            return arrStrResult;
        }
        /// <summary>
        /// Get ArrayList of File from dir
        /// </summary>
        /// <param name="directory">Directory for looking file</param>
        /// <returns>ArrayList of File</returns>
        public  ArrayList fileSearch(string directory)
        {
            ArrayList arrOfFile = new ArrayList();
            try
            {
                if (directory == null) { arrOfFile.Add("Non"); return arrOfFile; }
                string[] dirs = (Directory.GetFiles(directory));
                if (dirs.Length == 0) { arrOfFile.Add("Non"); return arrOfFile; /*throw new ArgumentNullException();*/ }
                //string[] -> to -> arrayList
                arrOfFile.AddRange(dirs);

                return arrOfFile;
            }
            catch (IOException e)
            {
                throw new IOException();
            }

        }/*fileSearch()*/





    }
}
