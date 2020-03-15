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
    public partial class Home : Form
    {
        public AirlineCoordinator coordinator;
        public Home()
        {
            InitializeComponent();
        }

        public Home(AirlineCoordinator coordinator)
        {
            this.coordinator = coordinator;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddCustomer customerAdd = new AddCustomer(this);
            Hide();
            customerAdd.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddFlight flightAdd = new AddFlight(this);
            Hide();
            flightAdd.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AddBooking bookingAdd = new AddBooking(this);
            Hide();
            bookingAdd.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ViewCustomer customerView = new ViewCustomer(this);
            Hide();
            customerView.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ViewFlight flightView = new ViewFlight(this);
            Hide();
            flightView.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            ViewBooking bookingView = new ViewBooking(this);
            Hide();
            bookingView.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DeleteCustomer customerDelete = new DeleteCustomer(this);
            Hide();
            customerDelete.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            DeleteFlight flightDelete = new DeleteFlight(this);
            Hide();
            flightDelete.Show();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
    }
}
