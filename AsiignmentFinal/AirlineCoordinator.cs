using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsiignmentFinal
{
    public class AirlineCoordinator
    {

        private FlightManager flightMan;
        private CustomerManager customerMan;
        private BookingManager bookingMan;

        public AirlineCoordinator(int cSeed, int maxCust, int maxFl)
        {
            CustomerManager one = new CustomerManager(cSeed, maxCust);
            customerMan = one;
            FlightManager one1 = new FlightManager(maxFl);
            flightMan = one1;
            BookingManager one2 = new BookingManager(cSeed, maxCust);
            bookingMan = one2;
        }

        public bool addFlight(int flNo, string orig, string dest, int mSeats)
        {
            flightMan.addFlight(flNo, orig, dest, mSeats);
            return true;
        }

        public bool addCustomer(string cfName, string lName, string phone)
        {
            customerMan.addCustomer(cfName, lName, phone);
            return true;
        }

        public string flightList()
        {
            Console.WriteLine("Flight List: ");
            return flightMan.getFlightList();
        }

        public string customerList()
        {
            Console.WriteLine("Customer List: ");
            Console.WriteLine("Number      Name            Phone");
            return customerMan.getCustomerList();
        }

        public bool deleteCustomer(int cld)
        {
            return customerMan.deleteCustomer(cld);
        }

        public bool deleteFlight(int flightNo)
        {
            return flightMan.deleteFlight(flightNo);
        }

        public bool addBooking(int customerId, int flightNum)
        {

            if (!customerMan.customerExist(customerId) || !flightMan.flightExist(flightNum))
            {
                Console.Write("Customer does not exist");
                return false;
            }
            DateTime dateTime = DateTime.Now;
            string dateTimeInfo = dateTime.ToShortDateString() + " " + dateTime.ToShortTimeString();
            return bookingMan.addBooking(dateTimeInfo, customerId, flightNum);
        }

        public string viewBooking()
        {
            return "Customer List: \nNumber     Name         Phone\n" + customerMan.getCustomerList() + "\n\n" + "Flight List: \n" + flightMan.getFlightList() + "\n\n" + bookingMan.viewBookings() + "\n";
        }

    }
}
