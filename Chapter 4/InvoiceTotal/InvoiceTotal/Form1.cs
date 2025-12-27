using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace InvoiceTotal
{
    public partial class InvTotal_Title : Form
    {
        public InvTotal_Title()
        {
            InitializeComponent();

            btnCalculate.Click += btnCalculate_Click;
            btnExit.Click += btnExit_Click;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // Get the subtotal
            decimal subTotal = Convert.ToDecimal(txtSubTotal.Text);
            // Determine the discount percent
            decimal discountPercent = 0.0m;
            if (subTotal >= 500)
                discountPercent = 0.2m;
            else if (subTotal >= 250)
                discountPercent = 0.15m;
            else if (subTotal >= 100)
                discountPercent = 0.1m;
            // Calculate the discount amount and total
            decimal discountAmount = Math.Round(subTotal * discountPercent, 2);
            decimal total = subTotal - discountAmount;
            // Display the results
            txtDisPercent.Text = discountPercent.ToString("p1");
            txtDisAmount.Text = discountAmount.ToString("c");
            txtTotal.Text = total.ToString("c");
        }
    }
}
