using ProjektBazyDanych.adminWindows;
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
    /// Logika interakcji dla klasy adminWindow.xaml
    /// </summary>
    public partial class adminWindow : Window
    {
        public adminWindow()
        {
            InitializeComponent();
        }

        private void addCityWindow_Click(object sender, RoutedEventArgs e)
        {
            addCityWindow window = new addCityWindow();
            window.Show();
        }

        private void addConnectionWindow_Click(object sender, RoutedEventArgs e)
        {
            AddConnectionWindow window = new AddConnectionWindow();
            window.Show();

        }

        private void addPilotWindow_Click(object sender, RoutedEventArgs e)
        {
            AddPilotWindow window = new AddPilotWindow();
            window.Show();
        }

        private void addPlaneWindow_Click(object sender, RoutedEventArgs e)
        {
            AddPlaneWindow window = new AddPlaneWindow();
            window.Show();
        }

        private void addFlightButton_Click(object sender, RoutedEventArgs e)
        {
            AddFlightWindow window = new AddFlightWindow();
            window.Show();
        }
    }
}
