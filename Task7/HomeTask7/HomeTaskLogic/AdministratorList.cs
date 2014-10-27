using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Text.RegularExpressions;
using HomeTask7.HomeTaskLogic;

namespace HomeTask7
{
   
  public class AdministratorList 
    {
     private List<PersoneInformation> listOfPersone = null;
     private List<PersoneInformation> listOfPersonesearch = null;
        public AdministratorList() 
        {
            listOfPersone = new List<PersoneInformation>();
            listOfPersonesearch = new List<PersoneInformation>();
        }
        /*
         * Method add all persone 
         */
        public void addPersone(string name, string surName, DateTime Date, int telophone, string email, string pasportInfo, string cartNumber, DateTime dataOfKart)
        {
              listOfPersone.Add(new PersoneInformation(name, surName,  Date,  telophone,  email,  pasportInfo,  cartNumber,  dataOfKart));
        }
        /*
         * This method what checking information before add persone to List<Persone> add return result true/false if persone add or not
         */
        public void addPersoneWithChecking(string name, string surName, DateTime Date, string phone, string email, string pasportInfo, string cartNumber, DateTime dataOfKart)
        {
            if (checkPhone(phone) == false) throw new MyExeptioClass("Iligal phone number : 937027294 or 380937027294");
            if (checkPasport(pasportInfo) == false) throw new MyExeptioClass("Iligal pasport Ifo :A-D  (0-9)<9n");
            listOfPersone.Add(new PersoneInformation(name, surName, Date, phone, email, pasportInfo, cartNumber, dataOfKart));
           
        }
      /*This method search Person for same information Name,Surname,Card,Phone(all what in toString in PersoneInformation)
       * And return List with result
       */
        public  List<PersoneInformation> searchPersone(String samePersoneInfor)
       {
           string pattern = @"" + samePersoneInfor;
           
           Regex newReg = new Regex(pattern);
           foreach(PersoneInformation per in this.listOfPersone) 
           {
               MatchCollection matches = newReg.Matches(per.ToString());
               foreach (Match mat in matches)
               {
                   if (mat.Success == true) { listOfPersonesearch.Add(per); }
               }
               
           }
           return listOfPersonesearch;
       }
      /*chek Phone information
       */
        public bool checkPhone(string phone)
        {
            string str = phone;
            string sPattern = @"(\(\d{3}[380]\))?\d{9}\z";
            //Regex regex = new Regex(@"(\(\d{3}\)-)? \d{3}-d{4}");
            //MatchCollection matches = regex.Matches(s);
            if (System.Text.RegularExpressions.Regex.IsMatch(str, sPattern))
            {return true;}else{return false;}
        }
        /*chek Pasport  information
         */
        public bool checkPasport(String pasportInfo) 
        {
            string sPattern = @"[A-D]\s?\d{6}\z";
            if (System.Text.RegularExpressions.Regex.IsMatch(pasportInfo, sPattern))
            {return true;}else{return false;}
        }

        /*MODIFY method 
         * 
         */
        public void modifyName(int index ,string name)
        {
            listOfPersone[index].name = name;

        }
        public void modifySurName(int index, string SurName)
        {
            listOfPersone[index].surName = SurName;

        }
        public void modifyData(int index, DateTime data)
        {
            listOfPersone[index].Date = data;

        }
        public void modifyPhone(int index, int phone)
        {
            listOfPersone[index].telophone = phone;

        }
        public void modifyEmail(int index, string email)
        {
            listOfPersone[index].email = email;

        }
        public void modifyPasporInfo(int index, string PasporInfo)
        {
            listOfPersone[index].pasportInfo = PasporInfo;

        }
        public void modifyCardNamber(int index, string CardNamber)
        {
            listOfPersone[index].cartNumber = CardNamber;

        }
        public void modifyDataOfKart(int index, DateTime data)
        {
            listOfPersone[index].dataOfKart = data;

        }


        /*Method FOR SORT
         * 
         * Sort Persone By Name
         */
        public List<PersoneInformation> sortByName()
        {   listOfPersone.Sort(CompareToName);
            return listOfPersone;
        }
        /*
        * Sort Persone By SurName
        */
        public List<PersoneInformation> sortBySurName()
        {    listOfPersone.Sort(CompareToSurName);
            return listOfPersone;
        }
        /*
         * Sort Persone By telefone
         */
        public List<PersoneInformation> sortByPhone()
        {   listOfPersone.Sort(CompareToPhoneNumber);
            return listOfPersone;
        }
        /*
         * Sort Persone By Data
         */
        public List<PersoneInformation> sortByData()
        {   listOfPersone.Sort(CompareToData);
            return listOfPersone;
        }
      /*
       * Editional suport of CompareTo to sort
       */
        private int CompareToName(PersoneInformation one, PersoneInformation other)
        {
            return one.name.CompareTo(other.name);
        }
        private int CompareToSurName(PersoneInformation one, PersoneInformation other)
        {
            return one.surName.CompareTo(other.surName);
        }
        private int CompareToPhoneNumber(PersoneInformation one, PersoneInformation other)
        {
            return one.telophone.CompareTo(other.telophone);
        }
        private int CompareToData(PersoneInformation one, PersoneInformation other)
        {
            return one.Date.CompareTo(other.Date);
        }


    }
}
