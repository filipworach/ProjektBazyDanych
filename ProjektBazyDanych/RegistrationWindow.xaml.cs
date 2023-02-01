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
using System.Windows.Shapes;

namespace ProjektBazyDanych
{
    /// <summary>
    /// Interaction logic for RegistrationWindow.xaml
    /// </summary>
    public partial class RegistrationWindow : Window
    {
        private int passengerID;

        public RegistrationWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string newLogin = login.Text;
            string newPassword = password.Password;

            using (var context = new Database())
            {
                if (context.Accounts.Find(newLogin) != null)
                {
                    registrationLabel.Content = "Konto już istnieje";
                }
                else
                {
                    Accounts account = new Accounts(newLogin, newPassword);
                    context.Accounts.Add(account);
                    context.SaveChanges();
                    try
                    {
                        passengerID = context.Passengers.Max(p => p.ID) + 1;
                    }
                    catch (System.InvalidOperationException)                    
                    {
                        passengerID = 0;
                    }
                   
                 
                    Passengers passengers = new Passengers(passengerID, name.Text, surname.Text, date.SelectedDate.Value, idNumber.Text, login.Text);
                    
                    context.Passengers.Add(passengers);
                    context.SaveChanges();

                }
            }
        }
    }
}
