using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using homeTask8;
using System.IO;

///
/// Testing File
/// 

namespace HomeLesson6.TestFo5_2
{
    
    [TestClass]
    public class Test5_1
    {
        List<PersoneInformation> listOfPersone = new List<PersoneInformation>();
        AdministratorList adminList = new AdministratorList();
        public Test5_1()
        {
            adminList.addPersone("GPR1", "ASR7", new DateTime(2008, 3, 12, 7, 40, 0), "0937027294", "email.com", "Same Infor", "44445555666677778888", DateTime.Now);
            adminList.addPersone("FPR2", "BSR6", new DateTime(2009, 9, 13, 7, 10, 0), "0937027294", "email.com", "Same Infor", "11112222333366664444", DateTime.Now);
            adminList.addPersone("CPR3", "CSR5", new DateTime(2010, 8, 13, 7, 40, 0), "0937027294", "email.com", "Same Infor", "88880000777744443333", DateTime.Now);
            adminList.addPersone("DPR4", "DSR4", new DateTime(2011, 7, 14, 7, 30, 0), "0937027294", "email.com", "Same Infor", "99990000222255554444", DateTime.Now);
            
        }
        /*
         * Test creating File Of BinarySerializer
         */
        [TestMethod]
        public void TestBinarySerializerWrite()
        {
            BinaryOrXmlSerializer.binarySerializer(adminList.getList(), "binariSer.dat");
            if ((File.Exists("binariSer.dat"))==false) { Assert.Fail(); }
        }
        /*
        * Test creating File Of XMLSerializer
        */
        [TestMethod]
        public void TestXMLSerializerWrite()
        {
            BinaryOrXmlSerializer.xmlSerializer(adminList.getList(), "Xml.xml");
            if ((File.Exists("Xml.xml") == false)) { Assert.Fail(); }
        }

        /*
        * Test reading File Of XMLSerializer
        */
        [TestMethod]
        public void TestXMLSerializerRead()
        {
            BinaryOrXmlSerializer.xmlSerializer(adminList.getList(), "Xml.xml");
            listOfPersone = BinaryOrXmlSerializer.xmlDeserializer("Xml.xml");
            if (listOfPersone.Capacity != 4) { Assert.Fail(); }
        }
        /*
        * Test reading File Of BinarySerializerSerializer
        */
        [TestMethod]
        public void TestBinarySerializerSerializerRead()
        {
            BinaryOrXmlSerializer.binarySerializer(adminList.getList(), "binariSer.dat");
            listOfPersone = BinaryOrXmlSerializer.binaryDeserializer("binariSer.dat");
            if (listOfPersone.Capacity != 4) { Assert.Fail(); }
        }
        /*
       * Test File Search
       */
        [TestMethod]
        public void TestFileSearch()
        {
            try
            {
                string[] strResult = null;
                strResult = FileSearch.fileSearch(@"D:\Task_2\homeTask8\homeTask8\bin\Debug", "X*");
                Assert.IsTrue(strResult.Length > 0);
                strResult = FileSearch.fileSearch(@"D:\Task_2\homeTask8\homeTask8\bin\Debug", "j*");
                Assert.IsTrue("Did not see sach file".Equals(strResult));
            }
            catch (Exception e)
            { Console.WriteLine(e.Message); }
        }
        /*
         * Test File Search Exwption
         */
        [TestMethod, ExpectedException(typeof(Exception))]
        public void TestFileSearchExption()
        {
            string[] strResult = null;
            strResult = FileSearch.fileSearch(@"D:\Task_2\homeTask8\homeTask8\bin\Debug", "X*");
            strResult = FileSearch.fileSearch(@"D:\Task_2\homeTask8\homeTask8\bin\Debug", "j*");
            
        }

    }
}
