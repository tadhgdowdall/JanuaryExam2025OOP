using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JanuaryExam2025OOP
{
    internal class VIPTicket : Ticket
    {
        #region Properties
        //properties
        public string AdditionalExtras { get; set; }
        public decimal AdditionalCost { get; set; }
        #endregion


        #region Constructors
        // Constructor inherits values from the base ticket 

        public VIPTicket() { }
        public VIPTicket(string name, decimal price, int availableTickets, string AdditionalExtras, decimal AdditionalCost) : base(name, price, availableTickets) { }
        #endregion
    }
}
