using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class7
{
   public class Program
    {
        public static void Main(string[] args)
        {
            List<PersoneInformation> listOfPersone = new List<PersoneInformation>();
            AdministratorList adminList = new AdministratorList();
            adminList.addPersone("GPR1", "ASR7", new DateTime(2008, 3, 12, 7, 40, 0), "0937027294", "email.com", "Same Infor", "44445555666677778888", DateTime.Now);
            adminList.addPersone("FPR2", "BSR6", new DateTime(2009, 9, 13, 7, 10, 0), "0937027294", "email.com", "Same Infor", "11112222333366664444", DateTime.Now);
            adminList.addPersone("CPR3", "CSR5", new DateTime(2010, 8, 13, 7, 40, 0), "0937027294", "email.com", "Same Infor", "88880000777744443333", DateTime.Now);
            adminList.addPersone("DPR4", "DSR4", new DateTime(2011, 7, 14, 7, 30, 0), "0937027294", "email.com", "Same Infor", "99990000222255554444", DateTime.Now);
            adminList.addPersone("CPR5", "DSR4", new DateTime(2007, 6, 14, 7, 20, 0), "0937027294", "email.com", "Same Infor", "12345678912345678954", DateTime.Now);
            adminList.addPersone("BPR6", "GSR2", new DateTime(2006, 5, 15, 7, 40, 0), "0937027294", "email.com", "Same Infor", "95123578654788965458", DateTime.Now);
            adminList.addPersone("APR7", "RSR1", new DateTime(2005, 4, 10, 7, 30, 0), "0937027294", "email.com", "Same Infor", "66554477889955669966", DateTime.Now);


            ClassCounter count = new ClassCounter();
            Handler_1 handler1 = new Handler_1();
            //Подписались на событие
            count.onCount += handler1.message;
            //Limit of size
            count.limitOfByte = 1024;
            //start
            count.binarySerialize("binariSer.dat",adminList.getList());
            //read
            try
            {
                listOfPersone = count.binaryDeserializer("binariSer.dat");
                foreach (PersoneInformation per in listOfPersone)
                {
                    Console.Write(per.ToString("format"));
                    Console.WriteLine();
                }
            }
            catch (NullReferenceException e) { Console.WriteLine(e.Message); }
            Console.ReadKey(); 

        }
    }
}
