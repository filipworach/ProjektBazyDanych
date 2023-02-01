using Microsoft.EntityFrameworkCore;
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

namespace ProjektBazyDanych
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            Database database = new Database();
            /*            List<Flights> flights = database.Flights.Where(r => r.id == 0).ToList();
            */
          


            /*            foreach (var f in flights)
                        {
                            f.Reservations.ForEach(Console.WriteLine);
                        }*/


            InitializeComponent();
            
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            using (var context = new Database())
            {
                string login = loginTextBox.Text;
                //var user = context.Accounts.Find(login);
                var user = context.Accounts.Include(r => r.Reservations).ThenInclude(y=>y.Passenger).FirstOrDefault(x => x.user_name == login);
                string passwordd = password.Password.ToString();
                if (user != null)
                {
                    if (login.Equals(user.user_name) && passwordd.Equals(user.password))
                    {
                        Window1 window = new Window1(user);
                        window.Show(); ;
                        this.Close();
                    }
                    else
                    {
                        loginLabel.Content = "Podano błędny login lub hasło";
                    }
                }
                else
                {
                    loginLabel.Content = "Podano błędny login lub hasło";
                }
            }
        }

        private void loginTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            loginLabel.Content = "";
        }

        private void registerButton_Click(object sender, RoutedEventArgs e)
        {
            RegistrationWindow registrationWindow = new RegistrationWindow();
            registrationWindow.Show();

           
        }
    }
}
