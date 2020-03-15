using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsiignmentFinal
{
    class Booking
    {
        private int bookingNum;
        private string date;

        public Booking(int booking, string date)
        {
            bookingNum = booking;
            this.date = date;
        }

        public void setDate(string value)
        {
            date = value;
        }

        public string getDate()
        {
            return date;
        }

        public int getBookingNum()
        {
            return bookingNum;
        }

        public string toString()
        {
            string s = "Booking Number: " + getBookingNum() + "\nDate: " + getDate();
            return s;
        }

    }
}
