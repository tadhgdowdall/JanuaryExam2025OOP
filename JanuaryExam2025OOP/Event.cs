using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JanuaryExam2025OOP
{
    // Event type with set values 
    public enum EventType { Music, Comedy, Theatre}

    internal class Event : IComparable<Event>
    {

        #region Properties
        //Properties 
        public string  Name { get; set; }
        public DateTime EventDate { get; set; }
        public List<Ticket> Tickets{ get; set; }
        public EventType TypeOfEvent { get; set; }
        #endregion

        #region Constructors
       

        public Event(string name, DateTime eventDate, List<Ticket> tickets, EventType typeOfEvent)
        {
            Name = name;
            EventDate = eventDate;
            Tickets = tickets;
            TypeOfEvent = typeOfEvent;
        }
        public Event() { }


        #endregion

        #region Methods
        //Methods 
        //Used to sort a list of event items but by EventDate
        public int CompareTo(Event other)
        {
            return this.EventDate.Day.CompareTo(other.EventDate.Day);
        }
        #endregion


    }
}
