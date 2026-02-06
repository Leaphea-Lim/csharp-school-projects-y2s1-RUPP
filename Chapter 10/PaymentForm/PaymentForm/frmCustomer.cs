using System;
using System.Windows.Forms;

namespace PaymentForm
{
    public partial class frmCustomer : Form
    {
        // Track whether data has been saved to prevent data loss
        bool isDataSaved = true;

        // Constructor - initializes the form components
        public frmCustomer()
        {
            InitializeComponent();
        }

        // Form Load event - runs when the form first loads
        // Initializes the customer name dropdown with sample data
        private void Form1_Load(object sender, EventArgs e)
        {
            // Add some initial customer names to the dropdown
            cboCustomerName.Items.Add("Mike Smith");
            cboCustomerName.Items.Add("Nancy Jones");

            // Clear any selection - user must choose or type a name
            cboCustomerName.SelectedIndex = -1;
        }

        // Event handler that fires when text in cboCustomerName changes
        // Marks data as unsaved when user makes changes
        private void DataChanged(object sender, EventArgs e)
        {
            isDataSaved = false;
        }

        // Event handler for Select Payment button click
        // Opens the Payment form as a modal dialog
        private void btnSelectPayment_Click(object sender, EventArgs e)
        {
            // Create an instance of the Payment form
            Form paymentForm = new frmPayment();

            // Show the Payment form as a dialog and get the result
            DialogResult selectedButton = paymentForm.ShowDialog();

            // If user clicked OK, retrieve payment info from Tag property
            // and display it in the lblPayment label
            if (selectedButton == DialogResult.OK)
            {
                lblPayment.Text = (string)paymentForm.Tag;
                isDataSaved = false; // Mark as unsaved since data changed
            }
        }

        // Event handler for Save button click
        // Validates data before saving
        private void btnSave_Click(object sender, EventArgs e)
        {
            // Only save if all data is valid
            if (IsValidData())
            {
                SaveData();
            }
        }

        // Saves the customer data and resets the form
        // Adds new customer names to the dropdown list for future use
        private void SaveData()
        {
            // Get the current customer name
            //string customerName = cboCustomerName.Text.Trim();

            // Check if this name is not already in the list
            // Add it to the dropdown for future selections
            //if (!cboCustomerName.Items.Contains(customerName))
            //{
            //    cboCustomerName.Items.Add(customerName);
            //}

            // Show success message to user
            //MessageBox.Show("Customer data saved successfully!", "Success",
            //    MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Clear all form fields after saving
            //cboCustomerName.Text = ""; // Clear text

            cboCustomerName.SelectedIndex = -1; // Clear selection
            lblPayment.Text = "";
            isDataSaved = true;   // Mark data as saved
            cboCustomerName.Focus(); // Return focus to customer name field for next entry
        }

        // Validates all required fields before saving
        // Returns true if all data is valid, false otherwise
        private bool IsValidData()
        {
            // Check if customer name is empty
            //if (cboCustomerName.Text.Trim() == "")
            if (cboCustomerName.SelectedIndex == -1)
            {
                MessageBox.Show("You must enter a customer name.", "Entry Error");
                cboCustomerName.Focus(); // Move cursor to the empty field
                return false;
            }

            // Check if payment method has been selected
            if (lblPayment.Text == "")
            {
                MessageBox.Show("You must enter a payment.", "Entry Error");
                return false;
            }

            // All validation passed
            return true;
        }

        // Event handler for Exit button click
        // Closes the form
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close(); // Triggers FormClosing event
        }

        // FormClosing event - runs when form is about to close
        // Prevents data loss by prompting user to save unsaved changes
        private void frmCustomer_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Only prompt if there is unsaved data
            if (isDataSaved == false)
            {
                // Build warning message
                string message =
                    "This form contains unsaved data.\n\n" +
                    "Do you want to save it?";

                // Show dialog with Yes/No/Cancel options
                DialogResult button =
                    MessageBox.Show(message, "Customer",
                        MessageBoxButtons.YesNoCancel,
                        MessageBoxIcon.Warning);

                // If user chose Yes, try to save the data
                if (button == DialogResult.Yes)
                {
                    // Only save if data is valid
                    if (IsValidData())
                        this.SaveData();
                    else
                        e.Cancel = true; // Cancel closing if validation fails
                }

                // If user chose Cancel, don't close the form
                if (button == DialogResult.Cancel)
                {
                    e.Cancel = true; // Cancel the form closing event
                }

                // If user chose No, form will close without saving
            }
        }

        private void cboCustomerName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}