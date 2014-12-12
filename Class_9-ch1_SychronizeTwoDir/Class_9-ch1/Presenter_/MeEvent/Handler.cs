using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_9_ch1.MeEvent
{
    public class Handler : EventArgs
    {
        FileWorker fileWorker = FileWorker.Instance;
        /// <summary>
        /// this method(Event) is refresh ListBox for directory 1 and 2
        /// </summary>
        /// <param name="box1">System.Windows.Forms.ListBox listBoxForDir1</param>
        /// <param name="box2">System.Windows.Forms.ListBox listBoxForDir2</param>
        public void message(System.Windows.Forms.ListBox box1, System.Windows.Forms.ListBox box2) 
        {
            ArrayList arrStr ;
            if (fileWorker.dir1 != null) {
                arrStr = fileWorker.fileSearch(fileWorker.dir1);
                if (arrStr == null) { box1.Items.Add("non"); }
                box1.Items.Clear();
                foreach (string st in arrStr)
                {
                    box1.Items.Add(st.ToString().Replace((fileWorker.dir1), " "));
                }
            }
            if (fileWorker.dir2 != null)
            {
                arrStr = fileWorker.fileSearch(fileWorker.dir2);
                if (arrStr == null) { box2.Items.Add("non"); }
                box2.Items.Clear();
                foreach (string st in arrStr)
                {
                    box2.Items.Add(st.ToString().Replace((fileWorker.dir2), " "));
                }
            }

        }

        
    }
}
