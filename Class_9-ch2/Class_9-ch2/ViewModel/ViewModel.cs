using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace Class_9_ch2
{
    public class ViewModel : ViewModelBase
    {
      

        //Binding
        public string firstNumber {  get; private set; }
        public string enteredValue { get; private set; }
        private string _resultOfOperation;
        private string _enteredTask;

        #region Enum - Position of current operation

        state CurrentState;
        /// <summary>
        ///Position of current operation
        /// </summary>
        enum state
        {
            substraction,  /* - */
            addiction,     /* + */
            multiplication,/* * */
            divide,        /* / */
            nonstate       /*non*/
        }
        #endregion

        /// <summary>
        /// Init same information
        /// </summary>
        public ViewModel()
        {
            EnteredTask = " ";
            CurrentState = state.nonstate;
        }

        //Обробка кнопок загрузив + mvvm light
        //Button
        private ICommand _buttonCalculate;
        private ICommand _buttonADD;
        private ICommand _buttonRemove;
        private ICommand _buttonDevide;
        private ICommand _buttonMultiply;
        private ICommand _button1;
        private ICommand _button2;
        private ICommand _button3;
        private ICommand _button4;
        private ICommand _button5;
        private ICommand _button6;
        private ICommand _button7;
        private ICommand _button8;
        private ICommand _button9;
        private ICommand _button0;
        private ICommand _buttonPoint;
        private ICommand _buttonC;

       #region TextBox,Label
        //Оповіщаємо про зміну значення в класі, наше вікно
        //Entered Operation SEE -> LABEL
        public string EnteredTask 
        {
            get { return _enteredTask; }
            set 
            {
                _enteredTask = value;
                RaisePropertyChanged( () => EnteredTask );
            } 
        }
        //Зміна/підрахкнок операції-результат
        //Result of operation or same additional result SEE -> TEXTBOX
        public string ResultOfOperation
        {
            get {return _resultOfOperation;}
            set
            { 
                _resultOfOperation = value;
                RaisePropertyChanged(() => ResultOfOperation);
            }
        }
        #endregion

       #region Button C or =
        /// <summary>
        /// CLR ALL information
        /// </summary>
       public ICommand ButtonC
       {//тернарний оператор
           get
           {
               return _buttonC ?? (_buttonC = new RelayCommand(
                 () => /*Lyambda*/
                 {
                     CurrentState = state.nonstate;
                     firstNumber = "";
                     EnteredTask = "";
                     enteredValue = "";
                     ResultOfOperation = "";
                 }
                   ));
           }
       }/*ButtonRemove*/
       /// <summary>
       /// Обробка події при нажиманні на кнопку * = *
       /// </summary>
       public ICommand ButtonCalculate
       {//тернарний оператор
           get
           {
               return _buttonCalculate ?? (_buttonCalculate = new RelayCommand(
                 () => /*Lyambda*/
                 {
                     try
                     {
                         if (CurrentState == state.addiction) 
                         {
                             //Off Position of current operation
                             CurrentState = state.nonstate;
                             double buff1 = double.Parse(firstNumber);
                             double buff2 = double.Parse(enteredValue);
                             //Set Result to text fild
                             ResultOfOperation = Convert.ToString(buff1 + buff2);
                             //Set result to  label
                             EnteredTask = ResultOfOperation.ToString();
                             //save result for next operation If it will be need
                             firstNumber = Convert.ToString(ResultOfOperation);
                             //Clear entered Value of last operation 
                             enteredValue = null;
                         }
                         if (CurrentState == state.substraction) 
                         {
                             CurrentState = state.nonstate;
                             double buff1 = double.Parse(firstNumber);
                             double buff2 = double.Parse(enteredValue);
                             ResultOfOperation = Convert.ToString(buff1 - buff2);
                             EnteredTask = ResultOfOperation.ToString();
                             firstNumber = Convert.ToString(ResultOfOperation);
                             enteredValue = null;
                         }
                         if (CurrentState == state.multiplication) 
                         {
                             CurrentState = state.nonstate;
                             double buff1 = double.Parse(firstNumber);
                             double buff2 = double.Parse(enteredValue);
                             ResultOfOperation = Convert.ToString(buff1 * buff2);
                             EnteredTask = ResultOfOperation.ToString();
                             firstNumber = Convert.ToString(ResultOfOperation);
                             enteredValue = null;
                         }
                         if (CurrentState == state.divide) 
                         {
                             CurrentState = state.nonstate;
                             double buff1 = double.Parse(firstNumber);
                             double buff2 = double.Parse(enteredValue);
                             if (buff2 == 0) { MessageBox.Show(" input incorrect data"); }
                             ResultOfOperation = Convert.ToString(buff1 / buff2);
                             EnteredTask = ResultOfOperation.ToString();
                             firstNumber = Convert.ToString(ResultOfOperation);
                             enteredValue = null;
                                                         
                         }
                
                     }
                     catch (Exception)
                     {
                         MessageBox.Show("Try input incorrect data");
                     }
                     
                 }
                   ));
           }
       }/*Calculate*/
       #endregion

       #region Editional Button /*-+
       public ICommand ButtonRemove
       {//тернарний оператор
           get
           {
               return _buttonRemove ?? (_buttonRemove = new RelayCommand(
                 () => /*Lyambda*/
                 {
                     CurrentState = state.substraction;
                     if (enteredValue != null)
                     firstNumber = enteredValue; //save value
                     ResultOfOperation = (""); //clear texBox for next operation
                     EnteredTask += enteredValue + "-";//print operation to label
                     enteredValue = null;//clear entered Value.for next operation
                 }
                   ));
           }
       }/*ButtonRemove*/
       public ICommand ButtonMultiply
       {//тернарний оператор
           get
           {
               return _buttonMultiply ?? (_buttonMultiply = new RelayCommand(
                 () => /*Lyambda*/
                 {
                     CurrentState = state.multiplication;
                     if (enteredValue != null)
                     firstNumber = enteredValue;
                    ResultOfOperation = ("");
                     EnteredTask += enteredValue + "*";
                     enteredValue = null;
                 }
                   ));
           }
       }/*ButtonDevide*/
       public ICommand ButtonDevide
       {//тернарний оператор
           get
           {
               return _buttonDevide ?? (_buttonDevide = new RelayCommand(
                 () => /*Lyambda*/
                 {
                     CurrentState = state.divide;
                     if (enteredValue != null)
                     firstNumber = enteredValue;
                     ResultOfOperation = ("");
                     EnteredTask += enteredValue + "/";
                     enteredValue = null;
                 }
                   ));
           }
       }/*ButtonDevide*/
       public ICommand ButtonADD
       {//тернарний оператор
           get
           {
               return _buttonADD ?? (_buttonADD = new RelayCommand(
                 () => /*Lyambda*/
                 {
                     CurrentState = state.addiction;
                     if (enteredValue != null)
                     firstNumber = enteredValue;
                     ResultOfOperation = ("");
                     EnteredTask += enteredValue + "+";
                     enteredValue = null;
                 }
                   ));
           }
       }/*ButtonADD*/
       #endregion

       #region Button 0-9
       public ICommand Button0 
       {
           get
           {
               return _button0 ?? (_button0 = new RelayCommand(
                  () => /*Lyambda*/
                  {
                      //SameLogik 
                      enteredValue += "0"; // create value
                      ResultOfOperation += "0"; // to see what we print
                  }
                   ));
           }
       }/*Button0*/
       public ICommand Button1
       {
           get
           {
               return _button1 ?? (_button1 = new RelayCommand(
                  () => /*Lyambda*/
                  {
                      //SameLogik 
                      enteredValue += "1";
                      ResultOfOperation += "1";
                  }
                   ));
           }
       }//Button1
       public ICommand Button2
       {
           get
           {
               return _button2 ?? (_button2 = new RelayCommand(
                  () => /*Lyambda*/
                  {
                      //SameLogik 
                      enteredValue += "2";
                      ResultOfOperation += "2";
                  }
                   ));
           }
       }//Button2
       public ICommand Button3
       {
           get
           {
               return _button3 ?? (_button3 = new RelayCommand(
                  () => /*Lyambda*/
                  {
                      //SameLogik
                      enteredValue += "3";
                      ResultOfOperation += "3";
                  }
                   ));
           }
       }//Button3
       public ICommand Button4
       {
           get
           {
               return _button4 ?? (_button4 = new RelayCommand(
                  () => /*Lyambda*/
                  {
                      //SameLogik  
                      enteredValue += "4";
                      ResultOfOperation += "4";
                  }
                   ));
           }
       }//Button4
       public ICommand Button5
       {
           get
           {
               return _button5 ?? (_button5 = new RelayCommand(
                  () => /*Lyambda*/
                  {
                      //SameLogik  
                      enteredValue += "5";
                      ResultOfOperation += "5";
                  }
                   ));
           }
       }//Button5
       public ICommand Button6
       {
           get
           {
               return _button6 ?? (_button6 = new RelayCommand(
                  () => /*Lyambda*/
                  {
                      //SameLogik  
                      enteredValue += "6";
                      ResultOfOperation += "6";
                  }
                   ));
           }
       }//Button6
       public ICommand Button7
       {
           get
           {
               return _button7 ?? (_button7 = new RelayCommand(
                  () => /*Lyambda*/
                  {
                      //SameLogik  
                      enteredValue += "7";
                      ResultOfOperation += "7";
                  }
                   ));
           }
       }//Button7
       public ICommand Button8
       {
           get
           {
               return _button8 ?? (_button8 = new RelayCommand(
                  () => /*Lyambda*/
                  {
                      //SameLogik 
                      enteredValue += "8";
                      ResultOfOperation += "8";
                  }
                   ));
           }
       }//Button7
       public ICommand Button9
       {
           get
           {
               return _button9 ?? (_button9 = new RelayCommand(
                  () => /*Lyambda*/
                  {
                      //SameLogik 
                      enteredValue += "9";
                      ResultOfOperation += "9";
                  }
                   ));
           }
       }//Button7
        public ICommand ButtonPoint
       {
           get
           {
               return _buttonPoint ?? (_buttonPoint = new RelayCommand(
                  () => /*Lyambda*/
                  {
                      //SameLogik 
                      enteredValue += ".";
                      ResultOfOperation += ".";
                  }
                   ));
           }
       }//Button7
        
       #endregion

    }
}
