using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Runtime.Serialization;


namespace Class7
{
    [Serializable()] //we can write [Serializable] and do not  make implementation :IS..+ overload method
    //ISerializable используется для предоставления собственной  сериализации (..бинарной т.п)
    public class PersoneInformation : ISerializable

    {
        public string name          { get; set; }
        public string surName       { get; set; }
        public DateTime Date        { get; set; }
        public string phone         { get; set; }
        public string email         { get; set; }
        public string pasportInfo   { get; set; }
        public string cartNumber    { get; set; }
        public DateTime dataOfKart  { get; set; }


        public PersoneInformation()
        {
        }
      
        public PersoneInformation(string name, string surName, DateTime Date, string phone, string email, string pasportInfo, string cartNumber, DateTime dataOfKart)
        {
            this.cartNumber     = cartNumber;
            this.dataOfKart     = dataOfKart;
            this.Date           = Date;
            this.email          = email;
            this.name           = name;
            this.pasportInfo    = pasportInfo;
            this.surName        = surName;
            this.phone          = phone;

        }

        public override string ToString()
        {
            return " Name :" + name + " SurName :" + surName + " Pasport Info : " + pasportInfo + " Data : " + this.Date + "\n";
        }

        public override bool Equals(object obj)
        {
            if (obj.GetType() != this.GetType()) return false;
            PersoneInformation other = obj as PersoneInformation;

            if (this.cartNumber != other.cartNumber) return false;
            if (this.email != other.email) return false;
            if (!this.phone.Equals(other.phone)) return false;
            else return true;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        /*
         * ISerializable method
         */
        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
             info.AddValue("Name",      this.name);
             info.AddValue("SurName",   this.surName);
             info.AddValue("Date",      this.Date );
             info.AddValue("DateOfCard",this.dataOfKart);
             info.AddValue("Phone",     this.phone);
             info.AddValue("Email",     this.email);
             info.AddValue("PasporInfor",this.pasportInfo);
             info.AddValue("CartNumber",this.cartNumber);
        }

        protected  PersoneInformation(SerializationInfo info, StreamingContext context) 
        {
            this.name        = info.GetString("Name");
            this.surName     = info.GetString("SurName");
            this.Date        = info.GetDateTime("Date");
            this.dataOfKart  = info.GetDateTime("DateOfCard");
            this.phone       = info.GetString("Phone");
            this.email       = info.GetString("Email");
            this.pasportInfo = info.GetString("PasporInfor");
            this.cartNumber  = info.GetString("CartNumber");

        }


       
       public string ToString(String format)
       {
           StringBuilder strBuild = new StringBuilder();
           
           strBuild.Append((String.Format("{0,10}||{1,10}||{2,20}||{3,18}||{4,20}||{5,25}||",
                   this.name,
                   this.surName,
                   String.Format("{0:d}", this.Date),
                   String.Format("{0:+380 ## ## ## ###}", this.phone),
                   this.email,
                   String.Format("{0:####-####-####-####-####}", Convert.ToDecimal(this.cartNumber))
                    )));
           
           return strBuild.ToString();
           
       }
      


    }
}

