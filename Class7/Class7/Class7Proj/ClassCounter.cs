using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Class7
{
   public class ClassCounter
    {
        /*
         * delegate
         */
        public delegate void MethodConteiner(int limitOfByte, string fileName, byte[] array, List<PersoneInformation> lsitIN);
        /*
         * event
         */
        public event MethodConteiner onCount;
       /*
        * Limit off size
        */
       public  int limitOfByte { get; set; }
       /*
        * Serialize
        */
       public  void binarySerialize(string fileName, List<PersoneInformation> lsitIN)
       {
          BinaryFormatter bform = new BinaryFormatter();
          using(MemoryStream ms = new MemoryStream())
          { 

           bform.Serialize(ms, lsitIN);
           //get byte array of Serialize Object
           byte[] array = ms.GetBuffer();
           //if size of writing information more that #limitOfByte# it will call Event
           if (limitOfByte != 0) {
               if(array.Length >= limitOfByte)
               {
                   if (onCount != null)
                   {//Event -> (see) Handler_1.class->Method: message
                       onCount(limitOfByte,fileName, array, lsitIN);
                   }
               } else { File.WriteAllBytes(fileName, array); }
           }else{ File.WriteAllBytes(fileName, array); }
          }

       }
       /*
        * Deserialize
        */
       public  List<PersoneInformation> binaryDeserializer(string path)
       {
           IFormatter formatter = new BinaryFormatter();
           return DeserializeItem(path, formatter);
       }


       private  List<PersoneInformation> DeserializeItem(string fileName, IFormatter formatter)
       {
           try
           {
               List<PersoneInformation> listOUT = new List<PersoneInformation>();
               using (FileStream read = new FileStream(fileName, FileMode.Open))
               {
                   listOUT = (List<PersoneInformation>)formatter.Deserialize(read);
                   return listOUT;
               }
           }
           catch (FileNotFoundException e) { Console.WriteLine(e.Message);  return null; }
          
       }       



       
    }
}
