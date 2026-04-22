using System.Net.Sockets;

namespace G_NET_12_OOP02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Quesion 1

            /*
             * الـ Owner و Balance معمولين public → أي حد يغيرهم بدون تحكم 
               مفيش validation في Withdraw → ممكن يسحب أكتر من الرصيد 
            ----------------------------------------------------------------------
            نخليهم private
            نستخدم properties عشان نتحكم فيهم
             * ----------------------------------------------------------------------
             * بيكسر Encapsulation
             * مفيش تحكم على البيانات
             */

            #endregion

            #region Quesion 2

            // Field → متغير عادي
            //Property → فيها logic(get / set)
            //example:
            //    private double price;

            //public double Price
            //{
            //    get { return price; }
            //    set { if (value > 0) price = value; }
            //}

            //public double PriceAfterTax
            //{
            //    get { return price * 1.14; }
            //}

            #endregion

            #region Quesion 3

            //ده اسمه Indexer
            //وبيخليك تتعامل مع الكلاس زي array
            //b) هيعمل ايرور
            //الحل: set
            //{
            //    if (index >= 0 && index < names.Length)
            //        names[index] = value;
            //}
            //c) اه ممكن
            #endregion

            #region Quesion 4

            //a)static → مش تابع object، تابع الكلاس كله
            //Item → لكل object قيمة لوحده
            //b) لأ
            //لأن static method مش شايفة non-static members

            #endregion

            #region Question 5


            Cinema cinema = new Cinema();

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"Enter data for Ticket {i + 1}:");

                Ticket t = new Ticket();

                Console.Write("Movie Name: ");
                t.MovieName = Console.ReadLine();

                Console.Write("Type: ");
                t.Type = (TicketType)int.Parse(Console.ReadLine());

                Console.Write("Seat Row: ");
                char row = char.Parse(Console.ReadLine());

                Console.Write("Seat Number: ");
                int num = int.Parse(Console.ReadLine());

                t.Seat = new SeatLocation { Row = row, Number = num };

                Console.Write("Price: ");
                t.Price = double.Parse(Console.ReadLine());

                cinema.AddTicket(t);
            }

            Console.WriteLine("\nAll Tickets:");

            for (int i = 0; i < 3; i++)
            {
                var t = cinema[i];
                Console.WriteLine($"Ticket #{t.TicketId} | {t.MovieName} | {t.Type} | Seat: {t.Seat.Row}-{t.Seat.Number} | Price: {t.Price} | After Tax: {t.PriceAfterTax}");
            }

            Console.Write("\nSearch Movie: ");
            string name = Console.ReadLine();

            var found = cinema.GetByMovieName(name);

            if (found != null)
                Console.WriteLine($"Found: {found.MovieName}");
            else
                Console.WriteLine("Not Found");

            Console.WriteLine($"\nTotal Tickets: {Ticket.GetTotalTicketsSold()}");

            Console.WriteLine(BookingHelper.GenerateBookingReference());
            Console.WriteLine(BookingHelper.GenerateBookingReference());

            Console.WriteLine(BookingHelper.CalcGroupDiscount(5, 80));

            #endregion

        }
    }
}
