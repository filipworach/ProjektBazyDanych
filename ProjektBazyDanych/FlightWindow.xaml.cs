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
    /// Interaction logic for FlightWindow.xaml
    /// </summary>
    public partial class FlightWindow : Window
    {
        private List<Flights> flightsList;
        private string login;
      
        public FlightWindow(string login)
        {
            this.login = login;
            InitializeComponent();
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
  
            
            using (var context = new Database())
            {
                string param1 = departureList.SelectedItem.ToString().Substring(37);
                string param2 = arrivalList.SelectedItem.ToString().Substring(37);
                var departureID = context.Cities.Where(c => c.city == param1).Select(c => c.ID).FirstOrDefault();
                var arrivalID = context.Cities.Where(c => c.city == param2).Select(c => c.ID).FirstOrDefault();

                var connectionID = context.Connections.Where(c => c.arrival_cityID == arrivalID && c.departure_cityID == departureID).Select(c => c.ID).FirstOrDefault();
                var date = dateOfFlight.SelectedDate.Value;
                
                flightsList = context.Flights.Where(f => f.connectionID == connectionID && f.departure_date > date).ToList();
                foreach (var flight in flightsList)
                    listOfAvailableFligths.Items.Add(flight.ToString());
            }
        }

        private void reservationButton_Click(object sender, RoutedEventArgs e)
        {
            var id = listOfAvailableFligths.SelectedIndex;
            Flights flight = flightsList[id];
            ReservationWindow reservationWindow = new ReservationWindow(login, flight, dateOfFlight.SelectedDate);
            reservationWindow.Show();
        }
    }
}
