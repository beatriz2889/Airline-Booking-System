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
    public partial class ViewBooking : Form
    {
        Home home;

        public ViewBooking(Home h)
        {
            home = h;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            home.Show();
            this.Close();
        }

        private void ViewBooking_Load(object sender, EventArgs e)
        {
            if(home.coordinator.viewBooking() == null)
            {
                txtBookingListView.Text = "No Booking Avialable";   
            }
            txtBookingListView.Text = home.coordinator.viewBooking();
        }
    }
}
