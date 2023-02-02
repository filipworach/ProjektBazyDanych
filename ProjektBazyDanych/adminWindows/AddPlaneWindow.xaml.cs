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
    /// Logika interakcji dla klasy AddPlaneWindow.xaml
    /// </summary>
    public partial class AddPlaneWindow : Window
    {
        public AddPlaneWindow()
        {
            InitializeComponent();
        }


        private void producentTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void modelTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void rangeTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void addPlaneButton_Click(object sender, RoutedEventArgs e)
        {
            if(rangeTextBox.Text!="" && modelTextBox.Text!="" && producentTextBox.Text!="" && idTextBox.Text != "")
            {
                Planes planeToAdd = new Planes();
                if(int.TryParse(rangeTextBox.Text, out int range))
                {
                    try
                    {
                        using (var context = new Database())
                        {
                            planeToAdd.model = modelTextBox.Text;
                            planeToAdd.producer = producentTextBox.Text;
                            planeToAdd.ID = idTextBox.Text;
                            planeToAdd.max_range = range;
                            context.Planes.Add(planeToAdd);
                            context.SaveChanges();
                        }
                        string messageBoxText = "Dodano Samolot ";
                        string caption = "Potwierdzenie";
                        MessageBoxButton button = MessageBoxButton.OK;
                        MessageBoxImage icon = MessageBoxImage.Information;
                        MessageBoxResult result;
                        result = MessageBox.Show(messageBoxText, caption, button, icon, MessageBoxResult.OK);
                    }
                    catch (Microsoft.EntityFrameworkCore.DbUpdateException g) {
                        string messageBoxText = "Samolot o podanej rejestracji już istnieje";
                        string caption = "Uwaga";
                        MessageBoxButton button = MessageBoxButton.OK;
                        MessageBoxImage icon = MessageBoxImage.Warning;
                        MessageBoxResult result;
                        result = MessageBox.Show(messageBoxText, caption, button, icon, MessageBoxResult.OK);
                    }
                    modelTextBox.Text = "";
                    producentTextBox.Text = "";
                    idTextBox.Text = "";
                    rangeTextBox.Text = "";

                }
                else
                {
                    string messageBoxText = "Zasieg musi byc liczba ";
                    string caption = "Uwaga";
                    MessageBoxButton button = MessageBoxButton.OK;
                    MessageBoxImage icon = MessageBoxImage.Warning;
                    MessageBoxResult result;
                    result = MessageBox.Show(messageBoxText, caption, button, icon, MessageBoxResult.OK);
                }
            }
            else
            {
                string messageBoxText = "Nie wprowadzono wymaganych danych ";
                string caption = "Uwaga";
                MessageBoxButton button = MessageBoxButton.OK;
                MessageBoxImage icon = MessageBoxImage.Warning;
                MessageBoxResult result;
                result = MessageBox.Show(messageBoxText, caption, button, icon, MessageBoxResult.OK);
            }
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
