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

namespace ProjektBazyDanych.adminWindows
{
    /// <summary>
    /// Logika interakcji dla klasy AddConnectionWindow.xaml
    /// </summary>
    public partial class AddConnectionWindow : Window
    {
        List<Cities> cities;
        public AddConnectionWindow()
        {
            using (var context = new Database())
            {
                cities = context.Cities.ToList();
            }

            if (cities.Count < 2) {
                string messageBoxText = "Za malo miast w bazie danych. Wymagane co najmniej 2 ";
                string caption = "Uwaga";
                MessageBoxButton button = MessageBoxButton.OK;
                MessageBoxImage icon = MessageBoxImage.Warning;
                MessageBoxResult result;
                result = MessageBox.Show(messageBoxText, caption, button, icon, MessageBoxResult.OK);
                this.Close();
            }

            InitializeComponent();
            firstCityComboBox.ItemsSource = cities;
            firstCityComboBox.SelectedIndex = 0;

            secondCityComboBox.ItemsSource = cities;
            secondCityComboBox.SelectedIndex = 1;
        }

        private void firstCityComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
        }

        private void _SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
        private void secondCityComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void addConnectionButton_Click(object sender, RoutedEventArgs e)
        {
            if (firstCityComboBox.SelectedIndex == secondCityComboBox.SelectedIndex)
            {
                string messageBoxText = "Nie mozna utworzyc polaczenia do tych samych miast ";
                string caption = "Uwaga";
                MessageBoxButton button = MessageBoxButton.OK;
                MessageBoxImage icon = MessageBoxImage.Warning;
                MessageBoxResult result;
                result = MessageBox.Show(messageBoxText, caption, button, icon, MessageBoxResult.OK);
            }
            else {
                using (var context = new Database())
                {
                    Connections connectionToAdd = new Connections();
                    connectionToAdd.departure_cityID = cities[firstCityComboBox.SelectedIndex].ID;
                    connectionToAdd.arrival_cityID = cities[secondCityComboBox.SelectedIndex].ID;
                    context.Connections.Add(connectionToAdd);
                    context.SaveChanges();
                }
                string messageBoxText = "Dodano Polaczenie ";
                string caption = "Potwierdzenie";
                MessageBoxButton button = MessageBoxButton.OK;
                MessageBoxImage icon = MessageBoxImage.Information;
                MessageBoxResult result;
                result = MessageBox.Show(messageBoxText, caption, button, icon, MessageBoxResult.OK);
            }
        }
    }
}
