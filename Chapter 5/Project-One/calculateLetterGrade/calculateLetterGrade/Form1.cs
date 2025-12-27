using System;
using System.Windows.Forms;

namespace calculateLetterGrade
{
    public partial class formCalGrade : Form
    {
        public formCalGrade()
        {
            InitializeComponent();

            // connect buttons with event handlers
            btnCalculate.Click += btnCalculate_Click;
            btnExit.Click += btnExit_Click;

            // Set letter grade textbox to read-only
            txtLetterGr.ReadOnly = true;
        }

        private void btnCalculate_Click (object sender, EventArgs e)
        {
            double numericGrade;

            // Validate number input
            
            if ( double.TryParse(txtNumericGr.Text, out numericGrade))
            {
                string letterGrade = "";

                if (numericGrade >= 90) letterGrade = "A";
                else if (numericGrade >= 80) letterGrade = "B";
                else if (numericGrade >= 70) letterGrade = "C";
                else if (numericGrade >= 60) letterGrade = "D";
                else if (numericGrade >= 50) letterGrade = "E";
                else letterGrade = "F";

                txtLetterGr.Text = letterGrade;
            }
            else
            {
                MessageBox.Show("Please enter a valid numeric grade.", "Input Error");
                txtLetterGr.Focus();
            }

        }

        private void btnExit_Click(object sender, EventArgs e) { 
            this.Close();
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {

        }
    }
}
