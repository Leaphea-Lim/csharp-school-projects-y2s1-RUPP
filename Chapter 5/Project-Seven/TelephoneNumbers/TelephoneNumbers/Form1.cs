using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TelephoneNumbers
{
    public partial class frmTelephoneConverter : Form
    {
        public frmTelephoneConverter()
        {
            InitializeComponent();

            btnConvert.Click += btnConvert_Click;
            btnExit.Click += btnExit_Click;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            txtNumericOnly.Text = "";
            string input = txtAlphanumeric.Text.ToUpper();
            int length = input.Length;

            for (int i = 0; i < length; i++)
            {
                string ch = input.Substring(i, 1);

                if ("ABC".Contains(ch)) txtNumericOnly.Text += "2";
                else if ("DEF".Contains(ch)) txtNumericOnly.Text += "3";
                else if ("GHI".Contains(ch)) txtNumericOnly.Text += "4";
                else if ("JKL".Contains(ch)) txtNumericOnly.Text += "5";
                else if ("MNO".Contains(ch)) txtNumericOnly.Text += "6";
                else if ("PQRS".Contains(ch)) txtNumericOnly.Text += "7";
                else if ("TUV".Contains(ch)) txtNumericOnly.Text += "8";
                else if ("WXYZ".Contains(ch)) txtNumericOnly.Text += "9";
                else if ("0123456789".Contains(ch)) txtNumericOnly.Text += ch;
            }
        }

    }
}
