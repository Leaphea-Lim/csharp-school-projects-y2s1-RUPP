using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShippingAndHandlingApp
{
    public partial class shipping_handling : Form
    {
        public shipping_handling()
        {
            InitializeComponent();

            btnCalGrandTotal.Click += btnCalGrandTotal_Click;
            btnExit.Click += btnExit_Click;
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnCalGrandTotal_Click(object sender, EventArgs e)
        {
            //validate order total

            //កន្លែងនេះអត់ assign variable orderTotal ក៏វានៅតែដំណើរការ ព្រោះ​ពេលប្រើ 'out' C# វា assign អោយតែម្តង
            if (!decimal.TryParse(txtOrderTotal.Text, out decimal orderTotal) || orderTotal < 0)
            {
                MessageBox.Show("Please enter a valid Order Total.");
                return;
            }

            //validate Customer Type
            string customerType = txtCustType.Text.Trim().ToUpper();

            if (customerType != "P" && customerType != "N")
            {
                MessageBox.Show("Customer Type must be P (Preferred) or N (Non-Preferred).");
                return;
            }

            decimal shipping = 0m;

            if (customerType == "P")
            {
                //free shipping for preferred customer
                shipping = 0m;
            }
            else
            {
                //non-preferred customer shipping price ranges

                if (orderTotal >= 0 && orderTotal <= 25)
                {
                    shipping = 5.00m;
                }
                else if (orderTotal <= 500)
                {
                    shipping = 8.00m;
                }
                else if (orderTotal <= 1000)
                {
                    shipping = 10.00m;
                }
                else if (orderTotal <= 5000)
                {
                    shipping = 15.00m;
                }
                else 
                {
                    shipping = 20.00m;
                }
            }

            //sale Tax = 7% of (Order Total + Shipping)
            decimal salesTax = (orderTotal + shipping) * 0.07m;

            //Grand Total 
            decimal grandTotal = orderTotal + shipping + salesTax;

            //Display Results (formatted as currency)
            txtShipCosts.Text = shipping.ToString("C");
            txtSalesTax.Text = salesTax.ToString("C");
            txtGrandTotal.Text = grandTotal.ToString("C");

        }
    }
}