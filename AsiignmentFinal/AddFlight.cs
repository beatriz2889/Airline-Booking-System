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
    public partial class AddFlight : Form
    {
        Home home;
        AirlineCoordinator coordinator;

        public AddFlight(AirlineCoordinator c)
        {
            this.coordinator = c;
            InitializeComponent();
        }

        public AddFlight(Home h)
        {
            home = h;
            InitializeComponent();
        }

        private void btnBackCustomer_Click(object sender, EventArgs e)
        {
            home.Show();
            this.Close();
        }

        public bool checkInteger(TextBox t)
        {
            int a;
            return int.TryParse(t.Text, out a);

        }

        private void btnAddFlight_Click(object sender, EventArgs e)
        {
            if (checkInteger(txtFlightNumber))
            {
                int flightNum = Convert.ToInt32(txtFlightNumber.Text);
                if (checkInteger(txtMaxSeatNo))
                {
                    int maxFlightSeat = Convert.ToInt32(txtMaxSeatNo.Text);
                    string portOfOrigin = txtPortOfOrigin.Text;
                    string destinationPort = txtDestinationPort.Text;

                    home.coordinator.addFlight(flightNum, portOfOrigin, destinationPort, maxFlightSeat);
                    lbMessageAddFlight.Text = "Flight added";
                    txtPortOfOrigin.Text = "";
                    txtDestinationPort.Text = "";
                    txtMaxSeatNo.Text = "";
                    txtFlightNumber.Text = "";

                }
                else
                {
                    lbErrorMaxSeat.Text = "Please enter integers!!!";
                }
            }
            else
            {
                lbErrorFlightNumber.Text = "Please enter integers!!!";
            }
 
        }

        private void AddFlight_Load(object sender, EventArgs e)
        {

        }

        private void txtFlightNumber_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtFlightNumber_Enter(object sender, EventArgs e)
        {
            lbMessageAddFlight.Text = "";
        }

        private void txtMaxSeatNo_Enter(object sender, EventArgs e)
        {
            lbMessageAddFlight.Text = "";
        }

        private void txtPortOfOrigin_Enter(object sender, EventArgs e)
        {
            lbMessageAddFlight.Text = "";
        }

        private void txtDestinationPort_Enter(object sender, EventArgs e)
        {
            lbMessageAddFlight.Text = "";
        }
    }
}
