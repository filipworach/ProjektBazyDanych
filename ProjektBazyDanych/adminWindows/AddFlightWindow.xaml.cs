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

namespace ProjektBazyDanych.adminWindows
{
    /// <summary>
    /// Logika interakcji dla klasy AddFlightWindow.xaml
    /// </summary>
    public partial class AddFlightWindow : Window
    {
        private List<Connections> connections;
        private List<Planes> planes;
        private List<Pilots> pilots;

        public AddFlightWindow()
        {
            using (var context = new Database())
            {
                connections = context.Connections.Include(r => r.departureCity).Include(y => y.arrivalCity).ToList();
                planes = context.Planes.ToList();
                pilots = context.Pilots.ToList();
            }





            InitializeComponent();
            if(connections.Count<1 && planes.Count<1 && pilots.Count < 2)
            {
                //TODO BLAD ZA MALO W BAZIE DANYCH
            }


            firstPilotCB.ItemsSource = pilots;
            firstPilotCB.SelectedIndex = 0;
            secondPilotCB.ItemsSource = pilots;
            secondPilotCB.SelectedIndex = 1;
            planeCB.ItemsSource = planes;
            planeCB.SelectedIndex = 0;
            connectionCB.ItemsSource = connections;
            connectionCB.SelectedIndex = 0;
        }

        private void firstPilotCB_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void secondPilotCB_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void connectionCB_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void planeCB_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void addFlightButton_Click(object sender, RoutedEventArgs e)
        {
            using (var context = new Database())
            {

            }
        }
    }
}
