using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace homeTask8
{
   public sealed class BinaryOrXmlSerializer
    {
       public static void binarySerializer(List<PersoneInformation> lsitIN, string path)
       {   //It cane be SoapFormatter soap = new SoapFormatter();
           /*В отличие от BinaryFormatter, платформа и операционная система 
            * не влияют на успешное восстановление данных, сериализированных с помощью SoapFormatter.
            */
            IFormatter formatter = new BinaryFormatter();
            SerializeItem(path, formatter, lsitIN);
        }
       public static List<PersoneInformation> binaryDeserializer(string path) 
        {
            IFormatter formatter = new BinaryFormatter();
            return DeserializeItem(path, formatter); 
        }
       public static void xmlSerializer(List<PersoneInformation> lsitIN, string path) 
       {
           XmlSerializer serializer = new XmlSerializer(typeof(List<PersoneInformation>));
           using (TextWriter writer = new StreamWriter(path))
           {
               serializer.Serialize(writer, lsitIN); 
           }  
       }
       public static List<PersoneInformation> xmlDeserializer(string path)
       {
           List<PersoneInformation> listOUT = new List<PersoneInformation>();
           XmlSerializer serializer = new XmlSerializer(typeof(List<PersoneInformation>));
           using (FileStream fs = new FileStream(path, FileMode.Open))
          {
              listOUT = (List<PersoneInformation>)serializer.Deserialize(fs);
           
          }
          return listOUT;  
       }

       /*
        *Method For binary method*s 
        */
       private static void SerializeItem(string fileName, IFormatter formatter, List<PersoneInformation> lsitIN)
       {
           FileStream save = null;
           try
           {
               save = new FileStream(fileName, FileMode.Create);
               formatter.Serialize(save, lsitIN);
           }catch (SerializationException e) { }
           finally {if(save != null) save.Close(); }
 
            
        }

        private static List<PersoneInformation> DeserializeItem(string fileName, IFormatter formatter)
        {
            List<PersoneInformation> listOUT = new List<PersoneInformation>();
            using (FileStream read = new FileStream(fileName, FileMode.Open)) 
            {
                listOUT = (List<PersoneInformation>)formatter.Deserialize(read);
            }

            return listOUT;
        }       

    }
}
