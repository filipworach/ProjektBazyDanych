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
using System.Windows.Shapes;

namespace ProjektBazyDanych
{
    /// <summary>
    /// Logika interakcji dla klasy Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        Accounts account;
        public Window1(Accounts account)
        {   
            this.account = account;
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {//loty
            using (var context = new Database())
            { 
                FlightWindow flightWindow = new FlightWindow();
                flightWindow.Show();
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {//rezerwacje
            using (var context = new Database())
            {
            }
    }
}
