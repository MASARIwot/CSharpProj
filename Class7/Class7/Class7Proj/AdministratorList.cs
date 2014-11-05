using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class7
{

    public class AdministratorList
    {
        private List<PersoneInformation> listOfPersone = null;
        public AdministratorList()
        {
            listOfPersone = new List<PersoneInformation>();
           
        }
        /*
         * Method add all persone 
         */
        public void addPersone(string name, string surName, DateTime Date, string phone, string email, string pasportInfo, string cartNumber, DateTime dataOfKart)
        {
            listOfPersone.Add(new PersoneInformation(name, surName, Date, phone, email, pasportInfo, cartNumber, dataOfKart));
        }

        /*
         * (@See) himeTask8.BinaryOrXmlSerializer.cs
         */
        public void serializList(string path) { }
        public List<PersoneInformation> deSerializList(string path) { return null; }


       /*
        * MODIFY Method
        */
        public void modifyName(int index, string name)
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
        public void modifyPhone(int index, string phone)
        {
            listOfPersone[index].phone = phone;

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
        public List<PersoneInformation> getList()
        {            
            return this.listOfPersone;
        }
        public List<PersoneInformation> sortByName()
        {
            listOfPersone.Sort(CompareToName);
            return this.listOfPersone;
        }
        /*
        * Sort Persone By SurName
        */
        public List<PersoneInformation> sortBySurName()
        {
            listOfPersone.Sort(CompareToSurName);
            return this.listOfPersone;
        }
        /*
         * Sort Persone By telefone
         */
        public List<PersoneInformation> sortByPhone()
        {
            listOfPersone.Sort(CompareToPhoneNumber);
            return this.listOfPersone;
        }
        /*
         * Sort Persone By Data
         */
        public List<PersoneInformation> sortByData()
        {
            listOfPersone.Sort(CompareToData);
            return this.listOfPersone;
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
            return one.phone.CompareTo(other.phone);
        }
        private int CompareToData(PersoneInformation one, PersoneInformation other)
        {
            return one.Date.CompareTo(other.Date);
        }


    }
}