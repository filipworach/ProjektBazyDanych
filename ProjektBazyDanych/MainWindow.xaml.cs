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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ProjektBazyDanych
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            Database database = new Database();
            /*            List<Flights> flights = database.Flights.Where(r => r.id == 0).ToList();
            */

            using (var context = new Database())
            {
                //var reservations = context.Reservations.FromSqlRaw("Select * from reservations where flightID = 0").ToList();
                //var reservations = context.Flights.Include(r => r.flight).Include(r=>r.Passenger).Include(r=>r.accounts).ToList();
            }
            

/*            foreach (var f in flights)
            {
                f.Reservations.ForEach(Console.WriteLine);
            }*/


            InitializeComponent();
        }
    }
}
