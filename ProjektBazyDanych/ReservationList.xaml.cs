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

        public ReservationList(List<Reservations> reservations)
        {
            this.reservations = reservations;
            
            InitializeComponent();
            listBox.Items.Clear();
            foreach (Reservations reservation in reservations)
            {
                listBox.Items.Add(reservation.ToString());
            }
            
        }

        private void listBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int index = listBox.SelectedIndex;
            string messageBoxText = "CZy na pewno chcesz anulować rezerawcje ";
        }

        private void deleteReservation_Click(object sender, RoutedEventArgs e)
        {
            int selectedIndex = listBox.SelectedIndex;
            if (selectedIndex > -1) 
            {
                string messageBoxText = "CZy na pewno chcesz anulować rezerawcje ";
                string caption = "Potwierdzenie";
                MessageBoxButton button = MessageBoxButton.YesNo;
                MessageBoxImage icon = MessageBoxImage.Warning;
                MessageBoxResult result;

                result = MessageBox.Show(messageBoxText, caption, button, icon, MessageBoxResult.Yes);

                if (result == MessageBoxResult.Yes) {
                    //TODO USUWANIE REZERAWCJI
                    Reservations reservationToDelete = reservations[selectedIndex];
                    using (var context = new Database()) 
                    {
                        context.Reservations.Attach(reservationToDelete);
                        context.Reservations.Remove(reservationToDelete);
                        context.SaveChanges();
                        reservations.Remove(reservationToDelete);
                        listBox.Items.RemoveAt(selectedIndex);

                    }


                }
            }
        }
    }
}
