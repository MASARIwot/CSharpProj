using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Class_8_ch2
{
       
        
    public class Program
    {
        /// <summary>
        /// Serialize information in file
        /// </summary>
        /// <typeparam name="T"> Type Of Infirmation</typeparam>
        /// <param name="lsitIN"> collection</param>
        /// <param name="path">Path to file/dir</param>
        public static void xmlSerializer<T>(UserCollection<T> lsitIN, string path)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(UserCollection<T>));
            using (TextWriter writer = new StreamWriter(path))
            {
                serializer.Serialize(writer, lsitIN);
            }
        }
        /// <summary>
        /// Loade information fro file
        /// </summary>
        /// <typeparam name="T">Type of</typeparam>
        /// <param name="path">Path to file/dir</param>
        /// <returns>UserCollection<T> from file</returns>
        public static UserCollection<T> xmlDeserializer<T>(string path)
        {
            UserCollection<T> listOUT = new UserCollection<T>();
            XmlSerializer serializer = new XmlSerializer(typeof(UserCollection<T>));
            using (FileStream fs = new FileStream(path, FileMode.Open))
            {
                listOUT = (UserCollection<T>)serializer.Deserialize(fs);

            }
            return listOUT;
        }

        /// <summary>
        /// MAIN
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args)
        {
            //Create collection
            UserCollection<int> arr = new UserCollection<int>();
            for (int i = 0; i <10; i++)
            {
                arr.Add(i);
            }
            //Print in different way my  UserCollection
            //1
            Console.WriteLine("Test 1");
            Console.WriteLine(arr.ToStringElement());
            //2
            Console.WriteLine("Test 2");
            foreach (int element in arr)
            {
                Console.WriteLine(element);
            }
            //3 NEXT!
            Console.WriteLine("Test 3");
            while (arr.MoveNext() == true) 
            {
                int element = arr.Current;
                Console.WriteLine(element);
            }
            // 4 BACK!
            Console.WriteLine("Test 4");
            while (arr.MoveBack() == true)
            {
                int element = arr.Current;
                Console.WriteLine(element);
            }
            //Save information in file
            Program.xmlSerializer(arr, "SameTest.xml");
            //Read Information from file
            UserCollection<int> arr2 = new UserCollection<int>();
            arr2 = Program.xmlDeserializer<int>("SameTest.xml");
            Console.WriteLine("Test Fro Resd AND Write in file");
            //Prin information
            Console.WriteLine(arr.ToStringElement());
        }
    }
}
