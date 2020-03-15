using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsiignmentFinal
{
    class FlightManager
    {
        private int maxFlights;
        private int numFlights;
        private Flight[] flight;

        public FlightManager(int maxFlt)
        {
            maxFlights = maxFlt;
            numFlights = 0;
            flight = new Flight[maxFlt];
        }

        public void setMaxFlights(int value)
        {
            maxFlights = value;
        }

        public bool addFlight(int flNo, string origin, string dest, int maxSeats)
        {
            if (numFlights >= maxFlights)
            {
                Console.WriteLine("Flight was not added...");
                Console.WriteLine();
                Console.Write("Press any key to return to the main menu: ");
                return false;
            }

            Flight bb = new Flight(flNo, origin, dest, maxSeats);
            flight[numFlights] = bb;
            numFlights++;
            Console.WriteLine("Flight successfully added...");
            Console.WriteLine();
            Console.Write("Press any key to return to the main menu: ");
            return true;
        }

        private int findFlight(int flightNo)
        {
            for (int x = 0; x < numFlights; x++)
            {
                if (flight[x].getFlightNumber() == flightNo)
                {
                    return x;
                }
            }
            Console.WriteLine("Flight Does not Exist");
            return -1;
        }

        public bool flightExist(int flightNo)
        {
            if (flight[findFlight(flightNo)].getFlightNumber() == -1)
            {
                return false;
            }
            return true;
        }

        public Flight getFlight(int flightNo)
        {
            if (flight[findFlight(flightNo)].getFlightNumber() == -1)
            {
                return null;
            }
            return flight[flightNo];
        }

        public bool deleteFlight(int flightNo)
        {
            if (flight[findFlight(flightNo)].getFlightNumber() == -1)
            {
                return false;
            }
            for (int i = 0; i < numFlights; i++)
            {
                if (flight[i].getFlightNumber() == flightNo)
                {
                    flight[i] = flight[numFlights - 1];
                    numFlights--;
                    Console.WriteLine("Flight successful deleted");
                }
            }

            return true;
        }

        public string getFlightList()
        {
            string s = "";
            for (int x = 0; x < numFlights; x++)
            {
                s += "\r\n" + flight[x].toString() + "\r\n";
            }
            return s;
        }

    }
}
