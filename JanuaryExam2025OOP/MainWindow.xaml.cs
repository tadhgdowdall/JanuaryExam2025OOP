/*https://github.com/tadhgdowdall/JanuaryExam2025OOP */


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

namespace JanuaryExam2025OOP
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // Creates a list for all events
        private List<Event> Events;


        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Events = GetData();
        }


        //Create a list of Event Objects.
        private List<Event> GetData()
        {

            // Creating 2 event objects
            Event Oasis = new Event() { Name = "Oasis Croke Park", EventDate = new DateTime(2025, 06, 20), TypeOfEvent = EventType.Music };
            Event ElectricPicnic = new Event() { Name = "Electric Picnic", EventDate = new DateTime(2025, 08, 20), TypeOfEvent = EventType.Music };

            Ticket EarlyBird = new Ticket() { Name = "Early Bird", Price = 100m, AvailableTickets = 100 };
            Ticket Platinium = new Ticket() { Name = "Platinium", Price = 150m, AvailableTickets = 100 };
        

            return new List<Event>() { Oasis, ElectricPicnic};
        }



    }
}
