using System;
using System.Collections.Generic;
using System.Text;

namespace G_NET_12_OOP02
{
    public static class BookingHelper
    {
        private static int counter = 0;

        public static double CalcGroupDiscount(int numberOfTickets, double pricePerTicket)
        {
            double total = numberOfTickets * pricePerTicket;

            if (numberOfTickets >= 5)
                return total * 0.9;

            return total;
        }

        public static string GenerateBookingReference()
        {
            counter++;
            return $"BK-{counter}";
        }
    }
}
