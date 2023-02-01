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
    /// Logika interakcji dla klasy addCityWindow.xaml
    /// </summary>
    public partial class addCityWindow : Window
    {
        public addCityWindow()
        {
            InitializeComponent();
        }



        private void addCityButton_Click(object sender, RoutedEventArgs e)
        {
            if (countryTextBox.Text != "" && cityTextBox.Text != "")
            {
                var city = new Cities();
                using (var context = new Database())
                {
                    city.country = countryTextBox.Text;
                    city.city = cityTextBox.Text;
                    context.Cities.Add(city);
                    context.SaveChanges();
                }
                string messageBoxText = "Dodano miasto ";
                string caption = "Potwierdzenie";
                MessageBoxButton button = MessageBoxButton.OK;
                MessageBoxImage icon = MessageBoxImage.Information;
                MessageBoxResult result;

                result = MessageBox.Show(messageBoxText, caption, button, icon, MessageBoxResult.OK);

                countryTextBox.Text = "";
                cityTextBox.Text = "";
            }
            else {
                string messageBoxText = "Nie podano danych ";
                string caption = "Uwaga";
                MessageBoxButton button = MessageBoxButton.OK;
                MessageBoxImage icon = MessageBoxImage.Warning;
                MessageBoxResult result;

                result = MessageBox.Show(messageBoxText, caption, button, icon, MessageBoxResult.OK);
            }
        }

        private void loginTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
