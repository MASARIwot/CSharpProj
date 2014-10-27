using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;


namespace HomeTask7
{
    public class PersoneInformation : IFormattable
      {
        public string name          {get;set;}
        public string surName       {get;set;}
        public DateTime Date        {get;set;}
        public int telophone        {get;set;}
        public string  phone        {get;set;}
        public string email         {get;set;}
        public string pasportInfo   {get;set;}
        public string cartNumber    {get;set;}
        public DateTime dataOfKart  {get;set;}
        

       public PersoneInformation() { 
       }
       public PersoneInformation(string name, string surName, DateTime Date, int telophone, string email, string pasportInfo, string cartNumber, DateTime dataOfKart)
       {
           this.cartNumber   = cartNumber;
           this.dataOfKart   = dataOfKart;
           this.Date         = Date;
           this.email        = email;
           this.name         = name;
           this.pasportInfo  = pasportInfo;
           this.surName      = surName;
           this.telophone    = telophone;
       }
       public PersoneInformation(string name, string surName, DateTime Date, string phone, string email, string pasportInfo, string cartNumber, DateTime dataOfKart)
       {
           this.cartNumber  = cartNumber;
           this.dataOfKart  = dataOfKart;
           this.Date        = Date;
           this.email       = email;
           this.name        = name;
           this.pasportInfo = pasportInfo;
           this.surName     = surName;
           this.phone       = phone;
           
       }

       public override string ToString()
       {
           return " Name :" + name + " SurName :" + surName + " Pasport Info : " + pasportInfo + " Data : "+ this.Date + "\n";
       }

       public override bool Equals(object obj)
       {
           if (obj.GetType() != this.GetType()) return false;
           PersoneInformation other = obj as PersoneInformation;

           if (this.cartNumber  != other.cartNumber)return false;
           if (this.email       != other.email)     return false;
           if (this.telophone   != other.telophone) return false;
           else return true;
       }
       
       public override int GetHashCode()
       {
           return base.GetHashCode();
       }


       public string ToString(string format)
       {
           return this.ToString(format, CultureInfo.CurrentCulture);
       }
       public string ToString(string format, IFormatProvider formatProvider)
       {
           StringBuilder strBuild = new StringBuilder();
           strBuild.AppendLine();
           strBuild.Append((String.Format("{0,10}||{1,10}||{2,20}||{3,18}||{4,20}||{5,25}||", " Name", " Surname", " Date", " Phone", " Email", "Cart Number")));
           strBuild.AppendLine();
           strBuild.Append((String.Format("{0,10}||{1,10}||{2,20}||{3,18}||{4,20}||{5,20}||", "-----", "--------", "-----------------", "---------", "---------", "-------------------------")));
           strBuild.AppendLine();

           DateTime dateResult;
           //"fr-FR"
           try
           {
               formatProvider = System.Globalization.CultureInfo.CreateSpecificCulture("format");
           }
           catch (CultureNotFoundException e) { 
              // Console.WriteLine(e.Message); 
           }
           DateTimeStyles styles = DateTimeStyles.AdjustToUniversal | DateTimeStyles.AssumeLocal;

           if (DateTime.TryParse(this.Date.ToString(), formatProvider, styles, out dateResult)) { 
           }
           else return "Error of TryParse Data to sach parama ";


           strBuild.Append((String.Format("{0,10}||{1,10}||{2,20}||{3,18}||{4,20}||{5,25}||",
                   this.name,
                   this.surName,
                   dateResult,
                   String.Format("{0:+380 ## ## ## ###}", this.telophone),
                   this.email,
                   String.Format("{0:####-####-####-####-####}", Convert.ToDecimal(this.cartNumber))
                    )));
           strBuild.AppendLine();
           strBuild.Append((String.Format("{0,10}||{1,10}||{2,20}||{3,18}||{4,20}||{5,20}||", "-----", "--------", "-----------------", "---------", "---------", "-------------------------")));
           strBuild.AppendLine();
           return strBuild.ToString();
           
       }
      }
}

