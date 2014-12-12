using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Class_9_ch1
{
     
    public partial class Form1 : Form
    {
        //Delegat
        public delegate void MethodConteiner(ListBox box1,ListBox box2);
        /*
         * event
         */
        public event MethodConteiner onAdd;
        //create instance of FileWorker.class
        FileWorker fileWorker = FileWorker.Instance;
        public Form1()
        {
            InitializeComponent();
        }
        /**************************************_ Button_**************************************/
        private void ButtonSynchronize_Click(object sender, EventArgs e)
        {
            try
            {
                fileWorker.sychronizeDir();
                onAdd(listBoxForDir1, listBoxForDir2);
            }
            catch (FileNotFoundException e3)
            {
                string caption = "Унас проблемка : " + e3.Message;
                string message = "Нет файла : " + e3.Source;
                DialogResult result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            }
            catch (IOException e4) 
            {
                string caption = "Унас проблемка : " + e4.Message;
                string message = "IOException : " + e4.Source;
                DialogResult result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
 
            }
            
        }
        private void ButtonAddDirBox1_Click(object sender, EventArgs e)
        {
           // Get Dir 1
            FolderBrowserDialog profilePath = new FolderBrowserDialog();

            if (profilePath.ShowDialog() == DialogResult.OK)
            {
                string dir1 = profilePath.SelectedPath;
                labelDir1.Text = dir1;
                //add directory
                fileWorker.dir1 = dir1;
                //event
                onAdd(listBoxForDir1, listBoxForDir2);
            }
            else{labelDir1.Text = "Please Specify The Profile Path";}

        }
        private void ButtonAddDirBox2_Click(object sender, EventArgs e)
        {
            //Get Dir 2
            FolderBrowserDialog profilePath = new FolderBrowserDialog();

            if (profilePath.ShowDialog() == DialogResult.OK)
            {
                string dir2 = profilePath.SelectedPath;
                labelDir2.Text = dir2;
                //add directory
                fileWorker.dir2 = dir2;
                //event
                onAdd(listBoxForDir1, listBoxForDir2);
            }
            else{labelDir2.Text = "Please Specify The Profile Path";}

        }
        private void ButtonAddFile_Click(object sender, EventArgs e)
        {
            try
            {
                string strToDelet = textBoxForfileOperation.Text;
                fileWorker.addFileToDirectory((@"\" + strToDelet));
                onAdd(listBoxForDir1, listBoxForDir2);
            }
            catch (UnauthorizedAccessException r)
            {
                string caption = "Унас проблемка : " + r.Message;
                string message = "UnauthorizedAccessException : " + r.Source;
                DialogResult result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
 
            }
        }
        private void ButtonRemoveFile_Click(object sender, EventArgs e)
        {
            string strToDelet = textBoxForfileOperation.Text;
            fileWorker.removeFileFromDir(strToDelet);
            onAdd(listBoxForDir1, listBoxForDir2);
        }
     
        /**************************************_checkBox_**************************************/
        private void checkBox2forDir2_CheckedChanged(object sender, EventArgs e)
        {  
            //Label result Dir For Sychronize TRUE-dir1 FALSE-dir2
            if (checkBox2forDir2.Checked == true) checkBox1ForDir1.Checked = false;
            fileWorker.dirForSychronize = false;
        }

        private void checkBox1ForDir1_CheckedChanged(object sender, EventArgs e)
        {  
            //Label result Dir For Sychronize TRUE-dir1 FALSE-dir2
            if (checkBox1ForDir1.Checked == true) checkBox2forDir2.Checked = false;
            fileWorker.dirForSychronize = true;
        }
        /**************************************_listBox_**************************************/
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //take from listBox name of file to delete  
            //choice label to work with directory: labelDir ->TRUE-dir1 FALSE-dir2
            String strItem;
            strItem = listBoxForDir1.SelectedItem as string;
            textBoxForfileOperation.Text = strItem;
            onAdd(listBoxForDir1, listBoxForDir2);

        }
        private void listBoxForDir2_SelectedIndexChanged(object sender, EventArgs e)
        {
            //take from listBox name of file to delete  
            //choice label to work with directory: labelDir ->TRUE-dir1 FALSE-dir2
            String strItem;
            strItem = listBoxForDir2.SelectedItem as string;
            textBoxForfileOperation.Text = strItem;
            onAdd(listBoxForDir1, listBoxForDir2);

        }
        /**************************************_Additional_**************************************/
        private void labelDir2_Click(object sender, EventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {

           
        }

        

       
    }
}
