using Class_9_ch1.MeEvent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Class_9_ch1
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
          
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Form1 imba = new Form1();
            Handler handler1 = new Handler();
            //Подписались на событие
            imba.onAdd += handler1.message;
            Application.Run(imba);
            

        }
    }
}
