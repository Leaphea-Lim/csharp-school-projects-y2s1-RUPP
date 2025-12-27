using System;
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


        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCalcucalte_Click(object sender, EventArgs e)
        {
            // ===== Parse user input =====
            decimal monthlyInvestment;
            decimal yearlyInterest;
            int years;

            // TryParse to prevent errors
            if (!decimal.TryParse(txtMonthly_Invmest.Text, out monthlyInvestment))
            {
                MessageBox.Show("Monthly investment must be a number.");
                return;
            }

            if (!decimal.TryParse(txtYearly_Interest.Text, out yearlyInterest))
            {
                MessageBox.Show("Yearly interest must be a number.");
                return;
            }

            if (!int.TryParse(txtNum_of_Years.Text, out years))
            {
                MessageBox.Show("Years must be a whole number.");
                return;
            }

            // Convert yearly to monthly rate
            decimal monthlyInterestRate = yearlyInterest / 100 / 12;

            // ===== Future Value Calculation using WHILE LOOP =====
            decimal futureValue = 0m;
            int months = years * 12;
            int counter = 0;
            
            while ( counter < months)
            {
                // Add monthly investment
                futureValue += monthlyInvestment;

                // Apply interest
                futureValue += futureValue * monthlyInterestRate;

                counter++;
            }

            // Display result
            txtFuture_Value.Text = futureValue.ToString("$ 0.00");

        }
    }
}
