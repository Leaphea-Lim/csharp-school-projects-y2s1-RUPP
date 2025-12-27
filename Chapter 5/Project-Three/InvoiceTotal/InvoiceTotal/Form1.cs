using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InvoiceTotal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            btnCalculate.Click += btnCalculate_Click;
            btnExit.Click += btnExit_Click;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //event One
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            string customerType = txtCust_Type.Text;
            decimal subtotal = Convert.ToDecimal(txtSub_Total.Text);
            decimal discountPercent = .0m;

            if (customerType == "R")
            {
                if (subtotal < 100) discountPercent = .0m;
                else if (subtotal >= 100 && subtotal < 250) discountPercent = .1m;
                else if (subtotal >= 250 && subtotal < 500) discountPercent = .25m;
             
            }
            else if (customerType == "C")
            {
                if (subtotal < 250) discountPercent = .2m;
                else discountPercent = .3m;
            }
            else
            {
                discountPercent = .4m;
            }

            decimal discountAmount = subtotal * discountPercent;
            decimal invoiceTotal = subtotal - discountAmount;

            txtDis_Percent.Text = discountPercent.ToString("p1");
            txtDis_Amount.Text = discountAmount.ToString("c");
            txtTotal.Text = invoiceTotal.ToString("c");

            txtCust_Type.Focus();
        }
    }
}
