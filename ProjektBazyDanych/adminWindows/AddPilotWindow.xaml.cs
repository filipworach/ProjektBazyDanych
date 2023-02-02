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
    /// Logika interakcji dla klasy AddPilotWindow.xaml
    /// </summary>
    public partial class AddPilotWindow : Window
    {
        public AddPilotWindow()
        {
            InitializeComponent();
        }

        private void surNameTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void nameTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void addPilotButton_Click(object sender, RoutedEventArgs e)
        {
            using (var context = new Database())
            {
                Pilots pilotToAdd = new Pilots();
                pilotToAdd.first_name = nameTextBox.Text;
                pilotToAdd.last_name = surNameTextBox.Text;
                pilotToAdd.hire_date = hireDate.DisplayDate;

                context.Pilots.Add(pilotToAdd);
                context.SaveChanges();

                string messageBoxText = "Dodano Pilota ";
                string caption = "Potwierdzenie";
                MessageBoxButton button = MessageBoxButton.OK;
                MessageBoxImage icon = MessageBoxImage.Information;
                MessageBoxResult result;

                result = MessageBox.Show(messageBoxText, caption, button, icon, MessageBoxResult.OK);
                nameTextBox.Text = "";
                surNameTextBox.Text = "";
                
            }
        }
    }
}
