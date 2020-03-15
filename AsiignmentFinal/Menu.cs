using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsiignmentFinal
{
    class Menu
    {
        public static void showMenu()
        {
            Console.WriteLine("XYZ Airlines Limited.\nPlease select a choice from the menu below");
            Console.WriteLine();
            Console.WriteLine("1: Add Flight\n2: Add Customer\n3: View Flights\n4: View Customers\n5: Delete Customers\n6: Delete Flight\n7: Add Booking\n8: View Bookings\n9: Exit");
        }

        public static int getChoice()
        {
            int input;
            showMenu();
            while (!int.TryParse(Console.ReadLine(), out input) && (input > 7))
            {
                showMenu();
            }
            return input;
        }

        public static void addFlight(AirlineCoordinator f)
        {
            Console.Write("Please enter the flight number: ");
            int flightNumber = 0;
            Int32.TryParse(Console.ReadLine(), out flightNumber);
            while (flightNumber == 0)
            {
                Console.Write("Please enter a valid flight number: ");
                Int32.TryParse(Console.ReadLine(), out flightNumber);
            }

            Console.Write("Please enter the maximum number of seats: ");
            int maxSeats = 0;
            Int32.TryParse(Console.ReadLine(), out maxSeats);
            while (maxSeats == 0)
            {
                Console.Write("Please enter a valid maximum number of seats: ");
                Int32.TryParse(Console.ReadLine(), out maxSeats);
            }

            Console.Write("Please enter the port of origin: ");
            string origin = "";
            origin = Console.ReadLine();
            while (origin == "")
            {
                Console.Write("Please enter a valid port of origin: ");
                origin = Console.ReadLine();
            }

            Console.Write("Please enter the destination port: ");
            string destination = "";
            destination = Console.ReadLine();
            while (destination == "")
            {
                Console.Write("Please enter a valid destination port: ");
                destination = Console.ReadLine();
            }

            f.addFlight(flightNumber, origin, destination, maxSeats);
        }

        public static void addCustomer(AirlineCoordinator f)
        {
            Console.Write("Please enter the customer's first name: ");
            string firstName = Console.ReadLine();
            Console.Write("Please enter the customer's last Name: ");
            string lastName = Console.ReadLine();
            Console.Write("Please enter the customer's phone: ");
            string phoneNumber = Console.ReadLine();

            f.addCustomer(firstName, lastName, phoneNumber);
        }

        public static void viewFlight(AirlineCoordinator f)
        {
            Console.WriteLine(f.flightList());
        }

        public static void viewCustomer(AirlineCoordinator f)
        {
            Console.WriteLine(f.customerList());
        }

        public static void deleteCustomer(AirlineCoordinator f)
        {
            viewCustomer(f);
            Console.Write("Please enter a customer id to delete: ");
            int cld;
            if (Int32.TryParse(Console.ReadLine(), out cld))
            {
                f.deleteCustomer(cld);
            }
        }

        public static void deleteFlight(AirlineCoordinator f)
        {
            viewFlight(f);
            Console.Write("Please enter a flight id to delete: ");
            int fNo;
            if (Int32.TryParse(Console.ReadLine(), out fNo))
            {
                f.deleteFlight(fNo);
            }
        }

        public static void addBooking(AirlineCoordinator f)
        {
            Console.WriteLine(f.customerList());
            Console.WriteLine(f.flightList());
            Console.Write("Please enter a customerid: ");
            int customerId = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please enter a flight number: ");
            int flightId = Convert.ToInt32(Console.ReadLine());


            f.addBooking(customerId, flightId);
        }

        public static void viewBooking(AirlineCoordinator f)
        {
            Console.Write(f.viewBooking() + f.flightList());
        }

        public static void exit(AirlineCoordinator f)
        {
            Console.Write("Goodbye... Thank you for using our system");
        }

    }
}
