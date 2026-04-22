using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Text;

namespace G_NET_12_OOP02
{
    public class Ticket
    {
        private string movieName;
        private double price;

        public string MovieName
        {
            get { return movieName; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    movieName = value;
            }
        }

        public TicketType Type { get; set; }
        public SeatLocation Seat { get; set; }

        public double Price
        {
            get { return price; }
            set
            {
                if (value > 0)
                    price = value;
            }
        }

        public double PriceAfterTax
        {
            get { return price * 1.14; }
        }
   private static int ticketCounter = 0;

        public int TicketId { get; }

        public Ticket()
        {
            ticketCounter++;
            TicketId = ticketCounter;
        }

        public static int GetTotalTicketsSold()
        {
            return ticketCounter;
        }
    }
}
