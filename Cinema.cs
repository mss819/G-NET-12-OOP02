using System;
using System.Collections.Generic;
using System.Text;

namespace G_NET_12_OOP02
{
    public class Cinema
    {
        private Ticket[] tickets = new Ticket[20];

        public Ticket this[int index]
        {
            get
            {
                if (index >= 0 && index < tickets.Length)
                    return tickets[index];
                return null;
            }
            set
            {
                if (index >= 0 && index < tickets.Length)
                    tickets[index] = value;
            }
        }

        public Ticket GetByMovieName(string name)
        {
            foreach (var t in tickets)
            {
                if (t != null && t.MovieName == name)
                    return t;
            }
            return null;
        }

        public bool AddTicket(Ticket t)
        {
            for (int i = 0; i < tickets.Length; i++)
            {
                if (tickets[i] == null)
                {
                    tickets[i] = t;
                    return true;
                }
            }
            return false;
        }
    }
}
