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
            using (var context = new Database())
            {
                var flightss = context.Reservations.Include(r => r.Passenger).ToList();

                //var reservation = context.Reservations.Include(r => r.Passenger).Include(x => x.Flight).Include(f => f.Account).ToList();
                ReservationList window = new ReservationList(flightss);
                window.Show();
            }


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
                var user = context.Accounts.Find(login);
                string passwordd = password.Password.ToString();
                if (user != null)
                {
                    if (login.Equals(user.user_name) && passwordd.Equals(user.password))
                    {
                        Window1 window = new Window1();
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
            string newLogin = loginTextBox.Text;
            string newPassword = password.Password;
            using (var context = new Database())
            {
                if(context.Accounts.Find(newLogin) != null)
                {
                    loginLabel.Content = "Konto już istnieje";
                } else
                {
                    Accounts account = new Accounts(newLogin, newPassword);
                    context.Accounts.Add(account);
                    context.SaveChanges();
                    
                }
            }
        }
    }
}
