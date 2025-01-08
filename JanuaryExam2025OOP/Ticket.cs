using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JanuaryExam2025OOP
{

    internal class Ticket
    {
        #region Properties
        //properties
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int AvailableTickets { get; set; }
        #endregion

        #region Constructors 
        //constructors
        public Ticket() { }

        public Ticket (string name, decimal price, int availableTickets)
        {
            Name = name;
            Price = price;
            AvailableTickets = availableTickets;
        }   

        public Ticket(string name, decimal price) : this(name, price, 0) { }
        #endregion


    }
}
