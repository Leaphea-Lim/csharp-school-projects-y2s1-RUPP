using System;
using System.Drawing;
using System.Windows.Forms;

namespace FutureValue
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            btnCalcucalte.Click += btnCalcucalte_Click;
            btnExit.Click += btnExit_Click;

            // Connect textboxes to clear future value when changed
            txtMonthly_Invmest.TextChanged += ClearFutureValue;
            txtYearly_Interest.TextChanged += ClearFutureValue;
            txtNum_of_Years.TextChanged += ClearFutureValue;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCalcucalte_Click(object sender, EventArgs e)
        {
            decimal monthlyInvestment;
            decimal yearlyInterest;
            int years;

            // Validate Monthly Investment
            if (txtMonthly_Invmest.Text == "")
            {
                MessageBox.Show("Monthly Investment is required.", "Entry Error");
                txtMonthly_Invmest.Focus();
            }
            else if (!decimal.TryParse(txtMonthly_Invmest.Text, out monthlyInvestment))
            {
                MessageBox.Show("Monthly Investment must be a numeric value.", "Entry Error");
                txtMonthly_Invmest.SelectAll();
                txtMonthly_Invmest.Focus();
            }
            else if (monthlyInvestment <= 0)
            {
                MessageBox.Show("Monthly Investment must be greater than 0.", "Entry Error");
                txtMonthly_Invmest.SelectAll();
                txtMonthly_Invmest.Focus();
            }

            // Validate Yearly Interest Rate
            else if (txtYearly_Interest.Text == "")
            {
                MessageBox.Show("Yearly Interest Rate is required.", "Entry Error");
                txtYearly_Interest.Focus();
            }
            else if (!decimal.TryParse(txtYearly_Interest.Text, out yearlyInterest))
            {
                MessageBox.Show("Yearly Interest Rate must be a numeric value.", "Entry Error");
                txtYearly_Interest.SelectAll();
                txtYearly_Interest.Focus();
            }
            else if (yearlyInterest <= 0)
            {
                MessageBox.Show("Yearly Interest Rate must be greater than 0.", "Entry Error");
                txtYearly_Interest.SelectAll();
                txtYearly_Interest.Focus();
            }
            else if (yearlyInterest > 20)
            {
                MessageBox.Show("Yearly Interest Rate must be less than or equal to 20.", "Entry Error");
                txtYearly_Interest.SelectAll();
                txtYearly_Interest.Focus();
            }

            // Validate Number of Years
            else if (txtNum_of_Years.Text == "")
            {
                MessageBox.Show("Number of Years is required.", "Entry Error");
                txtNum_of_Years.Focus();
            }
            else if (!int.TryParse(txtNum_of_Years.Text, out years))
            {
                MessageBox.Show("Number of Years must be an integer.", "Entry Error");
                txtNum_of_Years.SelectAll();
                txtNum_of_Years.Focus();
            }
            else if (years <= 0)
            {
                MessageBox.Show("Number of Years must be greater than 0.", "Entry Error");
                txtNum_of_Years.SelectAll();
                txtNum_of_Years.Focus();
            }
            else if (years > 50)
            {
                MessageBox.Show("Number of Years must be less than or equal to 50.", "Entry Error");
                txtNum_of_Years.SelectAll();
                txtNum_of_Years.Focus();
            }
            else
            {
                // All data is valid - perform calculation
                decimal monthlyInterestRate = yearlyInterest / 100 / 12;
                int months = years * 12;
                decimal futureValue = 0m;

                // Calculate future value using while loop
                int i = 0;
                while (i < months)
                {
                    futureValue = (futureValue + monthlyInvestment) * (1 + monthlyInterestRate);
                    i++;
                }

                // Display the result
                txtFuture_Value.Text = futureValue.ToString("c");
            }
        }

        private void ClearFutureValue(object sender, EventArgs e)
        {
            txtFuture_Value.Text = "";
        }

        private void TextBox_Enter(object sender, EventArgs e)
        {
            if (sender is TextBox textBox)
            {
                textBox.BackColor = Color.LightYellow;
            }
        }

        private void TextBox_Leave(object sender, EventArgs e)
        {
            if (sender is TextBox textBox)
            {
                textBox.BackColor = Color.White;
            }
        }
    }
}