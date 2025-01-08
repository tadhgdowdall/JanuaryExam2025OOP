/*
Student Name = Tadhg Dowdall
Student Number = S00250843
Date = 08/01/2025


https://github.com/tadhgdowdall/JanuaryExam2025OOP */


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
        // Creates a list for all events, Ticket Types, VIP Types
        private List<Event> Events;
        private List<Ticket> Tickets;
        private List<VIPTicket> VIPTicket;


        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Events = GetEventData();
            Tickets = GetEventTicket();
            VIPTicket = GetVIPTicket();


            lbxEvents.ItemsSource = Events;

        }


        /// <summary>
        /// Methods for Creating Event Lists, Ticket lists, VIP lists
        /// </summary>
        /// <returns></returns>

        //Create a list of Event Objects.
        private List<Event> GetEventData()
        {

            // Creating 2 event objects
            Event Oasis = new Event() { Name = "Oasis Croke Park", EventDate = new DateTime(2025, 06, 20), TypeOfEvent = EventType.Music };
            Event ElectricPicnic = new Event() { Name = "Electric Picnic", EventDate = new DateTime(2025, 08, 20), TypeOfEvent = EventType.Music };

            Ticket EarlyBird = new Ticket() { Name = "Early Bird", Price = 100m, AvailableTickets = 100 };
            Ticket Platinium = new Ticket() { Name = "Platinium", Price = 150m, AvailableTickets = 100 };

            VIPTicket TicketAndHotelPackage = new VIPTicket() { Price = 150m, AdditionalCost = 100m, AdditionalExtras = "4* Hotel", AvailableTickets = 100 };
            VIPTicket WeekendTicket = new VIPTicket() { Price = 200m, AdditionalCost = 100m, AdditionalExtras = "With Camping", AvailableTickets = 100 };


            return new List<Event>() { Oasis, ElectricPicnic };
        }


        // Returns List of Tickets
        private List<Ticket> GetEventTicket()
        {



            Ticket EarlyBird = new Ticket() { Name = "Early Bird", Price = 100m, AvailableTickets = 100 };
            Ticket Platinium = new Ticket() { Name = "Platinium", Price = 150m, AvailableTickets = 100 };

            return new List<Ticket>() { EarlyBird, Platinium };
        }


        // Returns list of vip tickets
        private List<VIPTicket> GetVIPTicket()
        {
            // Creating VIP Ticket Objects

            VIPTicket TicketAndHotelPackage = new VIPTicket() { Price = 150m, AdditionalCost = 100m, AdditionalExtras = "4* Hotel", AvailableTickets = 100 };
            VIPTicket WeekendTicket = new VIPTicket() { Price = 200m, AdditionalCost = 100m, AdditionalExtras = "With Camping", AvailableTickets = 100 };


            return new List<VIPTicket>() { TicketAndHotelPackage, WeekendTicket };
        }

        private void lbxEvents_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // If a user is has selected clicked on an event. It needs to update the appropriate tickets to the right
            lbxTickets.ItemsSource = Tickets;
     
        }

        private void btnBook_Click(object sender, RoutedEventArgs e)
        {
            string ticketAmount = tblkNumberOfTickets.Text;

            if (string.IsNullOrWhiteSpace(ticketAmount))
            {
                MessageBox.Show("Ticket Amount is required ");
                return;
            }
        }


        private void tbxSearch_KeyUp(object sender, KeyEventArgs e)
        {
            //read what is in box
            string searchTerm = tbxSearch.Text;


            // If the search box is empty display all events
            if (string.IsNullOrEmpty(searchTerm)){
                Events = GetEventData();
                lbxEvents.ItemsSource = Events;
            }

                

        }
    }
}
