using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsiignmentFinal
{
    class Customer
    {
        private int customerId;
        private string firstName;
        private string lastName;
        private string phone;

        public Customer(int Id, string fName, string lName, string ph)
        {
            customerId = Id;
            firstName = fName;
            lastName = lName;
            phone = ph;
        }

        public void setId(int newValue)
        {
            customerId = newValue;
        }


        public void setFirstName(string newValue)
        {
            firstName = newValue;
        }

        public void setLastName(string newValue)
        {
            lastName = newValue;
        }

        public void setPhone(string newValue)
        {
            phone = newValue;
        }

        public int getCustomerId()
        {
            return customerId;
        }

        public string getfirstName()
        {
            return firstName;
        }

        public string getlastName()
        {
            return lastName;
        }

        public string getPhone()
        {
            return phone;
        }

        public string getFullName()
        {
            return firstName + " " + lastName;
        }

        public string toString()
        {

            return getCustomerId() + string.Empty.PadLeft(2, '\t') + getFullName() + string.Empty.PadLeft(1, '\t') + getPhone();
        }

    }
}
