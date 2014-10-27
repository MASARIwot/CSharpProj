using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeTask7.HomeTaskLogic;

namespace HomeTask7
{
    class Program
    {
       // private List<PersoneInformation> listOfPersone2 = new List<PersoneInformation>();

        public static void printFormating(List<PersoneInformation> listOfPersone)
        {
            Console.WriteLine((String.Format("{0,10}||{1,10}||{2,20}||{3,18}||{4,20}||{5,25}||{6,4}||", " Name", " Surname", " Date", " Phone", " Email", "Cart Number", "ID")));
            Console.WriteLine((String.Format("{0,10}||{1,10}||{2,20}||{3,18}||{4,20}||{5,20}||{6,4}||", "-----", "--------", "-----------------", "---------", "---------", "-------------------------","----")));
            int index = 0;
            foreach (PersoneInformation per in listOfPersone)
            {
                Console.Write((String.Format("{0,10}||{1,10}||{2,20}||{3,18}||{4,20}||{5,25}||{6,4}||\n",
                    per.name,
                    per.surName, 
                    String.Format("{0:d}", per.Date), 
                    String.Format("{0:+380 ## ## ## ###}",per.telophone),
                    per.email,
                    String.Format("{0:####-####-####-####-####}", Convert.ToDecimal(per.cartNumber)),
                    index++
                    )));
                  
           }
        }
        public static void testIFormattable(List<PersoneInformation> listOfPersone) 
        {
            Console.WriteLine(listOfPersone[2].ToString("en-GB"));
            Console.WriteLine(listOfPersone[3].ToString("es-ES"));
            Console.WriteLine(listOfPersone[4].ToString("fr-FR"));
        }


        static void Main(string[] args)
        {
            List<PersoneInformation> listOfPersone = new List<PersoneInformation>();
            List<PersoneInformation> listOfPersoneTEST = new List<PersoneInformation>();
            AdministratorList adminList = new AdministratorList();
            adminList.addPersone("GPR1", "ASR7", new DateTime(2008, 3, 12, 7, 40, 0), 937027294, "email.com", "Same Infor",  "44445555666677778888", DateTime.Now);
            adminList.addPersone("FPR2", "BSR6", new DateTime(2009, 9, 13, 7, 10, 0), 0937027294, "email.com", "Same Infor", "11112222333366664444", DateTime.Now);
            adminList.addPersone("CPR3", "CSR5", new DateTime(2010, 8, 13, 7, 40, 0), 0937027294, "email.com", "Same Infor", "88880000777744443333", DateTime.Now);
            adminList.addPersone("DPR4", "DSR4", new DateTime(2011, 7, 14, 7, 30, 0), 0937027294, "email.com", "Same Infor", "99990000222255554444", DateTime.Now);
            adminList.addPersone("CPR5", "DSR4", new DateTime(2007, 6, 14, 7, 20, 0), 0937027294, "email.com", "Same Infor", "12345678912345678954", DateTime.Now);
            adminList.addPersone("BPR6", "GSR2", new DateTime(2006, 5, 15, 7, 40, 0), 0937027294, "email.com", "Same Infor", "95123578654788965458", DateTime.Now);
            adminList.addPersone("APR7", "RSR1", new DateTime(2005, 4, 10, 7, 30, 0), 0937027294, "email.com", "Same Infor", "66554477889955669966", DateTime.Now);
           
            Console.WriteLine("Sort by Name:");
            listOfPersone = adminList.sortByName();
            printFormating(listOfPersone);
            Console.WriteLine("Sort By SurName:");
            try
            {
                adminList.addPersoneWithChecking("AAA", "RSR1", new DateTime(2005, 4, 10, 7, 30, 0), "9374444454", "email.com", "AA 654585", "66554477889955669966", DateTime.Now);
                adminList.addPersoneWithChecking("ffAAA", "RSfR1", new DateTime(2005, 4, 10, 7, 30, 0), "9374444454", "email.com", "AA 654585", "66554477889955669966", DateTime.Now);
            }
            catch (MyExeptioClass e) {
                Console.WriteLine(e.Message);
            }
            listOfPersone = adminList.sortBySurName();
            printFormating(listOfPersone);
            Console.WriteLine("Result Of Search:");
            listOfPersoneTEST = adminList.searchPersone("DSR4");
            foreach (PersoneInformation per in listOfPersoneTEST)
            { 
                Console.WriteLine(per.ToString()); 
            }
            Console.ReadKey();
        }
    }
}
