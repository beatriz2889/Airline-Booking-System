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
    public partial class DeleteFlight : Form
    {
        Home home;
      
        public DeleteFlight(Home h)
        {
            home = h;
            InitializeComponent();
        }

        private void btnBackFlight_Click(object sender, EventArgs e)
        {
            home.Show();
            this.Close();
        }

        private void DeleteFlight_Load(object sender, EventArgs e)
        {
            deleteFlightList.Text = home.coordinator.flightList();
        }

        public bool checkInteger(TextBox t)
        {
            int a;
            return int.TryParse(t.Text, out a);

        }

        private void btnDeleteFlight_Click(object sender, EventArgs e)
        {
            if (checkInteger(txtFlightID))
            {
                int flightNum = Convert.ToInt32(txtFlightID.Text);
                home.coordinator.deleteFlight(flightNum);
            }
            else
            {
                lbErrorDeleteFlightID.Text = "Please enter an interger";
            }
            
        }

        private void txtFlightID_Enter(object sender, EventArgs e)
        {
            lbMessageDeleteFlight.Text = "";
        }
    }
}
