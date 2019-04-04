using System;
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

namespace _312576j2Problems
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int x; int m; int n;
            int.TryParse(xInput.Text, out x);   
            int.TryParse(mInput.Text, out m);
            //To get n
            n = m - (x % m);
            //to see if n is a modular inverse
            if ((x * n) % m == 1)
            {
                lblOutput.Content = n.ToString();
            }
            else if (n >= m)
            {
                lblOutput.Content = "no such int is possible";
            }
            else
            {
                MessageBox.Show("broke");
            }
            /*
            int y;
            int w = 1;
            //x = 4;
            //m = 17;
            //the modular inverse of x is the unique integer n
            //For example, 4 ¥13 = 52 = 17 ¥ 3 +1, so the remainder when 52 is divided by 17 is 1, and
            //thus 13 is the inverse of 4 modulo 17.

            n = m * (x - 1) + 1;
            y = x * n;
            w = y % m;
            int j = 1;
            j = m % 3;
            
            
            
            int output = n;
            MessageBox.Show(n.ToString());

            //MessageBox.Show(n.ToString());
            //MessageBox.Show((x * n).ToString());

           
            //MessageBox.Show(n.ToString());
            */
        }
    }
}
