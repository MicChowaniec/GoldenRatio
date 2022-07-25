using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace GoldenRatio
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public string biggerValueText;
        public string smallerValueText;
        public string insertBoxText;
        decimal golden = 1.61803398875m;
       
        private static readonly Regex _regex = new Regex("[^0-9.-]+");

        public MainWindow()
        {
            InitializeComponent();
        biggerValueText = "0";
        smallerValueText = "0";
        insertBoxText = "0";

        biggerValue.Text = biggerValueText;
        smallerValue.Text = smallerValueText;

        }
      

        private void insertBox_LostFocus(object sender, RoutedEventArgs e)
        {
            insertBoxText = insertBox.Text;
            UpdateValues(insertBoxText);
        }

         public void UpdateValues(string value)
        { 
            
        decimal temp = Convert.ToDecimal(value);
        decimal bigger = Math.Round(temp * golden, 2);
        decimal smaller = Math.Round(temp / golden, 2);
        biggerValueText = bigger.ToString();
        smallerValueText = smaller.ToString();
            
            try  
            {
                    biggerValue.Text = biggerValueText;
                    smallerValue.Text = smallerValueText;
            }
            catch ( NullReferenceException e)
            {
                    biggerValue.Text = biggerValueText;
                    smallerValue.Text = smallerValueText;
            }
            finally
            {
                    biggerValue.Text = biggerValueText;
                    smallerValue.Text = smallerValueText;

            }
            }



        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                this.DragMove();
            }
        }

        private void setSmaller_Click(object sender, RoutedEventArgs e)
        {
            insertBox.Text = smallerValue.Text ;
            insertBoxText = insertBox.Text;
            UpdateValues(insertBoxText);
                
        }



        private void x_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void setBigger_Click(object sender, RoutedEventArgs e)
        {
            insertBox.Text = biggerValue.Text;
            insertBoxText = insertBox.Text;
            UpdateValues(insertBoxText);
        }
    }
}
