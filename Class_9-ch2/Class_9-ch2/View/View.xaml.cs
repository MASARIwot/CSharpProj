using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Class_9_ch2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class View : Window
    {
        private static volatile List<Thickness>  position = new List<Thickness>();
        private Thickness ButtonLocationFromWindow;
        public View()
        {
            InitializeComponent();
            //init List<Thickness> Posit
           
            buttonLocation();

        }

       #region Mix Logic
        /// <summary>
        /// Get Buttoms Location to List
        /// </summary>
        private void buttonLocation() 
        {
            try
            {
             ButtonLocationFromWindow = Button1.Margin;
            position.Add(ButtonLocationFromWindow);
             ButtonLocationFromWindow = Button2.Margin;
            position.Add(ButtonLocationFromWindow);
             ButtonLocationFromWindow = Button3.Margin;
            position.Add(ButtonLocationFromWindow);
             ButtonLocationFromWindow = Button4.Margin;
            position.Add(ButtonLocationFromWindow);
             ButtonLocationFromWindow = Button5.Margin;
            position.Add(ButtonLocationFromWindow);
             ButtonLocationFromWindow = Button6.Margin;
            position.Add(ButtonLocationFromWindow);
             ButtonLocationFromWindow = Button7.Margin;
            position.Add(ButtonLocationFromWindow);
             ButtonLocationFromWindow = Button8.Margin;
            position.Add(ButtonLocationFromWindow);
             ButtonLocationFromWindow = Button9.Margin;
            position.Add(ButtonLocationFromWindow);
             ButtonLocationFromWindow = ButtonADD.Margin;
            position.Add(ButtonLocationFromWindow);
             ButtonLocationFromWindow = ButtonDevide.Margin;
            position.Add(ButtonLocationFromWindow);
             ButtonLocationFromWindow = ButtonMultiply.Margin;
            position.Add(ButtonLocationFromWindow);
             ButtonLocationFromWindow = ButtonRemove.Margin;
            position.Add(ButtonLocationFromWindow);
             ButtonLocationFromWindow = ButtonP.Margin;
            position.Add(ButtonLocationFromWindow);
            }
            catch (Exception e)
            {
                MessageBox.Show("Same Problem 1" + e.Message);
            }

        }
        /// <summary>
        /// Mix List for random location
        /// </summary>
        /// <typeparam name="t">Type of List</typeparam>
        /// <param name="list">List ot Mix</param>
        private static void MakeMixList<t>(IList<t> list)
        {
            Random r = new Random();
            //List<t> position2 = new List<t>();
            SortedList<int, t> mixedList = new SortedList<int, t>();
            foreach (t item in list)
                mixedList.Add(r.Next(), item);

            list.Clear();
            for (int i = 0; i < mixedList.Count; i++)
            {
                list.Add(mixedList.Values[i]);
            }
            //mixedList.Clear(); 
            
        }
        /// <summary>
        /// Set Button for new position
        /// </summary>
       private void setPosition() 
        {

            try
            {
                
                MakeMixList<Thickness>(position);
                Button1.Margin = position[0];
                Button2.Margin = position[1];
                Button3.Margin = position[2];
                Button4.Margin = position[3];
                Button5.Margin = position[4];
                Button6.Margin = position[5];
                Button7.Margin = position[6];
                Button8.Margin = position[7];
                Button9.Margin = position[8];
                ButtonADD.Margin = position[9];
                ButtonDevide.Margin = position[10];
                ButtonMultiply.Margin = position[11];
                ButtonRemove.Margin = position[12];
                ButtonP.Margin = position[13];
            }catch (Exception e)
                     {
                         MessageBox.Show("Same Problem 2" + e.Message);
                     }
            
        }
        #endregion

       #region Button
       private void Button_Click(object sender, RoutedEventArgs e)
        {
            setPosition();

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            setPosition();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            setPosition();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            setPosition();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            setPosition();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            setPosition();
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            setPosition();
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            setPosition();
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            setPosition();
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            setPosition();
        }

        private void Button_Click_10(object sender, RoutedEventArgs e)
        {
            setPosition();
        }

        private void Button_Click_11(object sender, RoutedEventArgs e)
        {
            setPosition();
        }

        private void Button_Click_12(object sender, RoutedEventArgs e)
        {
            setPosition();
        }

        private void Button_Click_13(object sender, RoutedEventArgs e)
        {
            setPosition();
        }

       #endregion

    }
}
