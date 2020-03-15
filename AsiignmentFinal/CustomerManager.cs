using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsiignmentFinal
{
    class CustomerManager
    {
        private static int currentCustNo;
        private int maxCustomers;
        private int numCustomers;
        private Customer[] customers;

        public CustomerManager(int seed, int maxCust)
        {
            currentCustNo = seed;
            maxCustomers = maxCust;
            numCustomers = 0;
            customers = new Customer[maxCust];
        }

        public int getMaxCustomer()
        {
            return maxCustomers;
        }

        public void setMaxCustomer(int value)
        {
            maxCustomers = value;
        }

        public void setCurrentCustNo(int value)
        {
            currentCustNo = value;
        }

        public bool addCustomer(string cfName, string lName, string phone)
        {
            if (numCustomers >= maxCustomers)
            {
                return false;
            }
            Customer bb = new Customer(currentCustNo, cfName, lName, phone);
            currentCustNo++;

            customers[numCustomers] = bb;
            numCustomers++;
            Console.WriteLine("Customer successfully added...");
            Console.WriteLine();
            return true;
        }

        private int findCustomer(int cld)
        {
            for (int x = 0; x < numCustomers; x++)
            {
                if (customers[x].getCustomerId() == cld) { return x; }
            }
            return -1;
        }

        public bool customerExist(int cld)
        {
            int loc = findCustomer(cld);
            if (customers[loc].getCustomerId() == -1)
            {
                return false;
            }
            return true;
        }

        public Customer getCustomer(int cld)
        {
            int loc = findCustomer(cld);
            if (customers[loc].getCustomerId() == -1)
            {
                return null;
            }
            return customers[cld];
        }

        public bool deleteCustomer(int cld)
        {
            int loc = findCustomer(cld);
            if (customers[loc].getCustomerId() == -1)
            {
                return false;
            }
            for (int i = 0; i < numCustomers; i++)
            {
                if (customers[i].getCustomerId() == cld)
                {
                    customers[loc] = customers[numCustomers - 1];
                    numCustomers--;
                    Console.WriteLine("Customer with id " + cld + " deleted...");
                }
            }
            return true;
        }

        public string getCustomerList()
        {
            string s = " ";
            for (int x = 0; x < numCustomers; x++)
            {
                s += "\r\n" + customers[x].toString() + "\r\n";
            }
            return s;
        }

    }
}
