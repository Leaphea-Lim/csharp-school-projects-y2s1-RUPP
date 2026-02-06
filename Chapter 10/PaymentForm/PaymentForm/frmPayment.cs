using System;
using System.Windows.Forms;

namespace PaymentForm
{
    public partial class frmPayment : Form
    {
        // Constructor - initializes the form components
        public frmPayment()
        {
            InitializeComponent();
        }

        // Form Load event - runs when the form first loads
        // Populates all combo boxes with their data
        private void frmPayment_Load(object sender, EventArgs e)
        {
            // Load credit card types - already defined in designer
            // Set default selection to first item (Visa)

            //if (lstCreditCardType.Items.Count > 0)
            //    lstCreditCardType.SelectedIndex = 0;

            lstCreditCardType.Items.Add("Visa");
            lstCreditCardType.Items.Add("Mastercard");
            lstCreditCardType.Items.Add("American Express");
            lstCreditCardType.SelectedIndex = 0;

            // Load months with "Select a month..." as first option
            cboMonth.Items.Clear(); // Clear any existing items
            string[] months = {"Select a month...",
                "January", "February", "March", "April",
                "May", "June", "July", "August",
                "September", "October", "November", "December"};

            // Add each month to the combo box
            foreach (string month in months)
            {
                cboMonth.Items.Add(month);
            }
            cboMonth.SelectedIndex = 0; // Select "Select a month..." as default

            // Load years - current year plus next 8 years
            cboYear.Items.Clear(); // Clear any existing items
            int year = DateTime.Today.Year; // Get current year
            int endYear = year + 8; // Calculate end year (8 years from now)
            cboYear.Items.Add("Select a year..."); // Add prompt text

            // Add each year from current to end year
            while (year < endYear)
            {
                cboYear.Items.Add(year);
                year++;
            }
            cboYear.SelectedIndex = 0; // Select "Select a year..." as default
        }

        // Event handler for OK button click
        // Validates data before saving and closing the form
        private void btnOK_Click(object sender, EventArgs e)
        {
            // Only save and close if all data is valid
            if (IsValidData())
            {
                this.SaveData(); // Save data and set DialogResult
            }
        }

        // Validates all required fields based on selected payment method
        // Returns true if all data is valid, false otherwise
        private bool IsValidData()
        {
            // Only validate credit card fields if Credit Card is selected
            if (rdoCreditCard.Checked)
            {
                // Check if credit card type is selected
                // SelectedIndex = -1 means no selection
                if (lstCreditCardType.SelectedIndex == -1)
                {
                    MessageBox.Show(
                        "You must select a credit card type.",
                        "Entry Error");
                    lstCreditCardType.Focus(); // Move cursor to the field
                    return false;
                }

                // Check if card number is entered
                if (txtCardNumber.Text == "")
                {
                    MessageBox.Show(
                        "You must enter a credit card number.",
                        "Entry Error");
                    txtCardNumber.Focus(); // Move cursor to the field
                    return false;
                }

                // Check if month is selected
                // Index 0 is "Select a month..." which is not valid
                if (cboMonth.SelectedIndex == 0)
                {
                    MessageBox.Show("You must select a month.",
                        "Entry Error");
                    cboMonth.Focus(); // Move cursor to the field
                    return false;
                }

                // Check if year is selected
                // Index 0 is "Select a year..." which is not valid
                if (cboYear.SelectedIndex == 0)
                {
                    MessageBox.Show("You must select a year.",
                        "Entry Error");
                    cboYear.Focus(); // Move cursor to the field
                    return false;
                }
            }
            // If Bill Customer is selected, no validation needed
            return true; // All validation passed
        }

        // Saves payment data by building a formatted string
        // Stores the string in Tag property to pass back to calling form
        private void SaveData()
        {
            string msg = null;

            // Build message based on selected payment method
            if (rdoCreditCard.Checked == true)
            {
                // Format credit card payment information
                msg += "Charge to credit card." + "\n";
                msg += "\n";
                msg += "Card type: " + lstCreditCardType.Text + "\n";
                msg += "Card number: " + txtCardNumber.Text + "\n";
                msg += "Expiration date: "
                    + cboMonth.Text + "/"
                    + cboYear.Text + "\n";
            }
            else
            {
                // Format bill customer information
                msg += "Send bill to customer." + "\n";
                msg += "\n";
            }

            // Add default billing status to message
            bool isDefaultBilling = chkDefault.Checked;
            msg += "Default billing: " + isDefaultBilling;

            // Store formatted message in Tag property
            // Tag property is used to pass data back to the Customer form
            this.Tag = msg;

            // Set DialogResult to OK - closes form and returns OK to caller
            this.DialogResult = DialogResult.OK;
        }

        // Event handler for Credit Card radio button state change
        // Enables/disables credit card fields based on selection
        private void radCreditCard_CheckedChanged(object sender, EventArgs e)
        {
            // Enable credit card fields if Credit Card is selected
            if (rdoCreditCard.Checked)
                EnableControls();
            else
                // Disable credit card fields if Bill Customer is selected
                DisableControls();
        }

        // Enables all credit card input controls
        // Called when Credit Card radio button is selected
        private void EnableControls()
        {
            lstCreditCardType.Enabled = true;
            txtCardNumber.Enabled = true;
            cboMonth.Enabled = true;
            cboYear.Enabled = true;
        }

        // Disables all credit card input controls
        // Called when Bill Customer radio button is selected
        private void DisableControls()
        {
            lstCreditCardType.Enabled = false;
            txtCardNumber.Enabled = false;
            cboMonth.Enabled = false;
            cboYear.Enabled = false;
        }

        // Event handler for Cancel button click
        // Closes the form without saving data
        private void btnCancel_Click(object sender, EventArgs e)
        {
            // Set DialogResult to Cancel - closes form and returns Cancel to caller
            this.DialogResult = DialogResult.Cancel;
        }

    }
}