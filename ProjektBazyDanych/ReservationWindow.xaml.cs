using System;
using System.Linq;
using System.Windows;

namespace ProjektBazyDanych
{
    /// <summary>
    /// Interaction logic for ReservationWindow.xaml
    /// </summary>
    public partial class ReservationWindow : Window
    {
        private string login;
        private Flights flights;
        private DateTime? dateTime = new DateTime();
        public ReservationWindow(string login, Flights flights, DateTime? dateTime)
        {
            this.login = login;
            this.flights = flights;
            this.dateTime = dateTime;
            InitializeComponent();
        }

        private void reservationButton_Click(object sender, RoutedEventArgs e)
        {
            using (var context = new Database())
            {
                Reservations reservations;
                int reservationID;
                try
                {
                   reservationID = context.Reservations.Max(r => r.ID) + 1;
                } catch (System.InvalidOperationException)
                {
                    reservationID = 0;
                }
                int passengerID = context.Passengers.Where(r => r.user_name == login).Select(r => r.ID).FirstOrDefault();
                if (passengersNumber.SelectedIndex == 0)
                {
                    reservations = new Reservations(reservationID, passengerID, login, flights.ID, dateTime, null);
                    context.Reservations.Add(reservations);
                    context.SaveChanges();
                }
                else if (passengersNumber.SelectedIndex == 1)
                {
                    reservations = new Reservations(reservationID, passengerID, login, flights.ID, dateTime, null);
                    context.Reservations.Add(reservations);
                    reservationID++;
                    var passenger1 = context.Passengers.Where(p => p.passportID == passenger1id.Text).FirstOrDefault();
                    if (passenger1 != null)
                    {
                        context.Reservations.Add(new Reservations(reservationID, passenger1.ID, login, flights.ID, dateTime, null));
                    } else
                    {
                        int newPassengerID = context.Passengers.Max(p => p.ID) + 1;
                        context.Passengers.Add(new Passengers(newPassengerID, passenger1Name.Text, passenger1Surname.Text, passenger1birthdate.SelectedDate.Value, passenger1id.Text, null));
                        context.Reservations.Add(new Reservations(reservationID, newPassengerID, login, flights.ID, dateTime, null));
                        

                    }
                    context.SaveChanges();
                }
                else if (passengersNumber.SelectedIndex == 2)
                {
                    reservations = new Reservations(reservationID, passengerID, login, flights.ID, dateTime, null);
                    context.Reservations.Add(reservations);
                    reservationID++;
                    var passenger1 = context.Passengers.Where(p => p.passportID == passenger1id.Text).FirstOrDefault();
                    if (passenger1 != null)
                    {
                        context.Reservations.Add(new Reservations(reservationID, passenger1.ID, login, flights.ID, dateTime, null));
                    }
                    else
                    {
                        int newPassengerID = context.Passengers.Max(p => p.ID);
                        context.Passengers.Add(new Passengers(newPassengerID, passenger1Name.Text, passenger1Surname.Text, passenger1birthdate.SelectedDate.Value, passenger1id.Text,null));
                        context.Reservations.Add(new Reservations(reservationID, newPassengerID, login, flights.ID, dateTime, null));


                    }
                    reservationID++;
                    var passenger2 = context.Passengers.Where(p => p.passportID == passenger2id.Text).FirstOrDefault();
                    if (passenger2 != null)
                    {
                        context.Reservations.Add(new Reservations(reservationID, passenger2.ID, login, flights.ID, dateTime, null));
                    }
                    else
                    {
                        int newPassengerID = context.Passengers.Max(p => p.ID) + 1;
                        context.Passengers.Add(new Passengers(newPassengerID, passenger2Name.Text, passenger2Surname.Text, passenger2birthdate.SelectedDate.Value, passenger2id.Text,null));
                        context.Reservations.Add(new Reservations(reservationID, newPassengerID, login, flights.ID, dateTime, null));


                    }

                    context.SaveChanges();
                }
            }
        }
    }
}
