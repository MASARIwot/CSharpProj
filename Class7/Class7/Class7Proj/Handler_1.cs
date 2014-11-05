using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Class7
{
    public class Handler_1 :EventArgs
    {
        
        public void message(int limitOfByte, string fileName, byte[] array, List<PersoneInformation> lsitIN) 
        {
            string caption = "Записать Файл размером? : " + array.Length;
            string message = "Размер больше чем : " + limitOfByte + ": не запишеt - We will lose same date";
            DialogResult result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //check answer
            if (result == DialogResult.No)
            {
                return;
            }
            else
            {
                try
                {
                    BinaryFormatter bform = new BinaryFormatter();
                    using (MemoryStream ms = new MemoryStream())
                    {// Remove element from List<PersoneInformation> while list size will less that #limitOfByte#
                        while (array.Length > limitOfByte)
                        {
                            int size = lsitIN.Capacity;
                            lsitIN.Remove(lsitIN[1]);
                            bform.Serialize(ms, lsitIN);
                            array = ms.GetBuffer();
                        }
                        /*Write*/
                        File.WriteAllBytes(fileName, array);

                    }
                }
                catch (ArgumentOutOfRangeException e) { Console.WriteLine( e.Message); }


            }/*else*/


        }/*message*/
    }
}
