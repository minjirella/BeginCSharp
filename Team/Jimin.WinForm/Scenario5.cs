using Team.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Team.WinForm
{
    public partial class Scenario5 : Form
    {
        public Scenario5()
        {
            InitializeComponent();
        }
        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            string firstName = textSearchName.Text;

            Customer customer = DataRepository.Customer.GetCustomerByFirstName(firstName);

            List<Customer> customers = new List<Customer>();
            customers.Add(DataRepository.Customer.GetCustomerByFirstName(firstName));
            dataGridView1.DataSource = customers;
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {

            string firstName = textSearchName.Text;
            DateTime billingDate = dateTimePicker1.Value.Date;

            Invoice invoice = DataRepository.Customer.GetInvoiceIdByFirstNameAndBillingDate(firstName, billingDate);
            Customer customer = DataRepository.Customer.GetCustomerByFirstName(firstName);
            txtFirstName.Text = customer.FirstName;
            txtLastName.Text = customer.LastName;
            txtInvoiceId.Text = invoice.InvoiceId.ToString();
            textAddress.Text = invoice.BillingAddress;
            textCity.Text = invoice.BillingCity;
            textState.Text = invoice.BillingState;
            textCountry.Text = invoice.BillingCountry;
            textPostalCode.Text = invoice.BillingPostalCode;
            labelTotal.Text = "Total : " + invoice.Total;

        }

        private void BtnModify_Click(object sender, EventArgs e)
        {
            string firstName = textSearchName.Text;
            DateTime billingDate = dateTimePicker1.Value.Date;
            Invoice invoice = DataRepository.Customer.GetInvoiceIdByFirstNameAndBillingDate(firstName, billingDate);
            invoice.BillingAddress = textAddress.Text;
            invoice.BillingCity = textCity.Text;
            invoice.BillingState = textState.Text;
            invoice.BillingCountry = textCountry.Text;
            invoice.BillingPostalCode = textPostalCode.Text;

            DataRepository.Invoice.Update(invoice);
        }
    }
}
