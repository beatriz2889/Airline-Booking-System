using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsiignmentFinal
{
    class Flight
    {
        private int flightNumber;
        private string origin;
        private string destination;
        private int maxSeats;
        private int numPassengers;
        private Customer[] passengers;

        public Flight(int flightNo, string orig, string dest, int mSeats)
        {
            flightNumber = flightNo;
            origin = orig;
            destination = dest;
            maxSeats = mSeats;
            numPassengers = 0;
            passengers = new Customer[mSeats];
        }

        public void setFlightNumber(int value)
        {
            flightNumber = value;
        }

        public void setOrigin(string value)
        {
            origin = value;
        }

        public void setDestination(string value)
        {
            destination = value;
        }

        public void setMaxSeats(int value)
        {
            maxSeats = value;
        }

        public void setNumPassenger(int value)
        {
            numPassengers = value;
        }


        public int getFlightNumber()
        {
            return flightNumber;
        }

        public string getOrigin()
        {
            return origin;
        }

        public string getDestination()
        {
            return destination;
        }

        public int getMaxSeats()
        {
            return maxSeats;
        }

        public int getNumPassenger()
        {
            return numPassengers;
        }

        public bool addPassenger(Customer cust)
        {
            if (numPassengers >= maxSeats) return false;
            for (int x = numPassengers; x < maxSeats; x++)
            {
                passengers[x] = cust;
                numPassengers++;
            }
            return true;
        }

        public int findPassenger(int custId)
        {
            for (int x = 0; x < numPassengers; x++)
            {
                if (passengers[x].getCustomerId() == custId)
                {
                    return x;
                }
            }
            return -1;
        }

        public bool removePassenger(int custId)
        {
            int loc = findPassenger(custId);
            if (passengers[loc].getCustomerId() == -1)
            {
                return false;
            }
            return true;
        }

        public string getPassengerList()
        {
            string s = " ";
            for (int x = 0; x < numPassengers; x++)
            {
                s += "Passenger List: \n" + flightNumber + " " + passengers[x].getFullName() + " " + passengers[x].getPhone();
            }
            return s;
        }

        public string toString()
        {
            return flightNumber + string.Empty.PadLeft(1, '\t') + "     "+ maxSeats + string.Empty.PadLeft(2, '\t') + origin + string.Empty.PadLeft(2, '\t') + destination;
        }

    }
}
