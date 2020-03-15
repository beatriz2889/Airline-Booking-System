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
    public partial class DeleteCustomer : Form
    {
        Home home;
        AirlineCoordinator coordinator;

        public DeleteCustomer(AirlineCoordinator c)
        {
            coordinator = c;
            InitializeComponent();
        }

        public DeleteCustomer(Home h)
        {
            home = h;
            InitializeComponent();
        }


        private void btnBackCustomer_Click(object sender, EventArgs e)
        {
            home.Show();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void DeleteCustomer_Load(object sender, EventArgs e)
        {
            DeleteCustomerList.Text = home.coordinator.customerList();
        }

        public bool checkInteger(TextBox t)
        {
            int a;
            return int.TryParse(t.Text, out a);

        }

        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            if (checkInteger(txtCustomerID))
            {
               int customerId = Convert.ToInt32(txtCustomerID.Text);
               home.coordinator.deleteCustomer(customerId);
                txtCustomerID.Text = "";
                DeleteCustomerList.Text= home.coordinator.customerList();
               lbMessageDeleteCustomer.Text = "Deleted";
            }
            else
            {
                lbErrorDeleteCustomerID.Text = "Pleae enter an interger";
            }
        }

        private void txtCustomerID_Enter(object sender, EventArgs e)
        {
            lbMessageDeleteCustomer.Text = "";
        }
    }
}
