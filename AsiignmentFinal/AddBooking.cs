using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsiignmentFinal
{
    public partial class AddBooking : Form
    {
        Home home;

        public AddBooking(Home h)
        {
            home = h;
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        public bool checkInteger(TextBox t)
        {
            int a;
            return int.TryParse(t.Text, out a);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkInteger(txtCustomerID))
            {
                int customerId = Convert.ToInt32(txtCustomerID.Text);
                if (checkInteger(txtFlightID))
                {
                    int flightNum = Convert.ToInt32(txtFlightID.Text);
                    home.coordinator.addBooking(customerId, flightNum);
                    lbMessageAddBooking.Text = "Booking Added";
                    txtCustomerID.Text = "";
                    txtFlightID.Text = "";
                }
                else
                {
                    lbErrorFlightID.Text = "Please add interger!";
                }
            }
            else
            {
                lbErrorCustomerID.Text = "Please add interger!";
            }

        }

        private void btnBackAddBooking_Click(object sender, EventArgs e)
        {
            home.Show();
            this.Close();
        }

        private void AddBooking_Load(object sender, EventArgs e)
        {
            flightListView.Text = home.coordinator.customerList();
            customerListView.Text = home.coordinator.flightList();

        }
        private void txtCustomerID_TextChanged(object sender, EventArgs e)
        {
            lbMessageAddBooking.Text = "";
        }

        private void txtCustomerID_Enter(object sender, EventArgs e)
        {
            lbMessageAddBooking.Text = "";
        }

        private void txtFlightID_Enter(object sender, EventArgs e)
        {
            lbMessageAddBooking.Text = "";

        }
    }
}
