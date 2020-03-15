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
    public partial class AddCustomer : Form
    {
        Home home;

        public AddCustomer(Home h)
        {
            home = h;
            InitializeComponent();
        }

        private void btnBackCustomer_Click(object sender, EventArgs e)
        {
            home.Show();
            this.Close();
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            string firstName = txtFirstName.Text;
            string lastName = txtLastName.Text;
            string phoneNumber = txtPhoneNumber.Text;
            home.coordinator.addCustomer(firstName, lastName, phoneNumber);
            lbMessageAdd.Text = "Successfully Added";
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtPhoneNumber.Text = "";

        }

        private void AddCustomer_Load(object sender, EventArgs e)
        {

        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtPhoneNumber_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void AddCustomer_Enter(object sender, EventArgs e)
        {
            lbMessageAdd.Text = "";
        }

        private void txtFirstName_Enter(object sender, EventArgs e)
        {
            lbMessageAdd.Text = "";
        }

        private void txtLastName_Enter(object sender, EventArgs e)
        {
            lbMessageAdd.Text = "";
        }

        private void txtPhoneNumber_Enter(object sender, EventArgs e)
        {
            lbMessageAdd.Text = "";
        }
    }
}
