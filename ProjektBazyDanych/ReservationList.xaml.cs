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
    /// Logika interakcji dla klasy ReservationList.xaml
    /// </summary>


    
    public partial class ReservationList : Window
    {
        private List<Reservations> reservations = new List<Reservations>();
        public static List<Reservations> rezerwacje = new List<Reservations>() {
        new Reservations(1, 1, "Kulej", 1, DateTime.MaxValue, 0),
        new Reservations(2, 3, "Filip", 1, DateTime.MaxValue, 0),
        };

        public ReservationList(List<Reservations> reservations)
        {
            this.reservations = reservations;
            
            InitializeComponent();

            foreach(Reservations reservation in reservations)
            {
                listBox.Items.Add(reservation.ToString());
            }
            
        }

        private void listBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void deleteReservation_Click(object sender, RoutedEventArgs e)
        {
            if (listBox.SelectedIndex > 0) 
            {
                string messageBoxText = "CZy na pewno chcesz anulować rezerawcje ";
                string caption = "Potwierdzenie";
                MessageBoxButton button = MessageBoxButton.YesNo;
                MessageBoxImage icon = MessageBoxImage.Warning;
                MessageBoxResult result;

                result = MessageBox.Show(messageBoxText, caption, button, icon, MessageBoxResult.Yes);

                if (result == MessageBoxResult.Yes) {
                    //TODO USUWANIE REZERAWCJI
                    
                }
            }
        }
    }
}
