using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsiignmentFinal
{
    class BookingManager
    {
        private static int bookingNum;
        private int numBookings;
        private int maxBooking;
        private Booking[] booking;


        public BookingManager(int seed, int maxBooking)
        {
            bookingNum = seed;
            this.numBookings = 0;
            this.maxBooking = maxBooking;
            booking = new Booking[maxBooking];
        }


        public bool addBooking(string date, int custId, int flightId)
        {
            if (numBookings >= maxBooking)
            {
                return false;
            }
            bookingNum++;
            Booking b = new Booking(bookingNum, date);

            booking[numBookings] = b;
            numBookings++;
            Console.Write("Booking successfully added...");
            Console.WriteLine();
            return true;
        }

        public string viewBookings()
        {
            string s = "";
            for (int x = 0; x < numBookings; x++)
            {
                s += booking[x].toString() + "\n";
            }
            return s;
        }

    }
}
