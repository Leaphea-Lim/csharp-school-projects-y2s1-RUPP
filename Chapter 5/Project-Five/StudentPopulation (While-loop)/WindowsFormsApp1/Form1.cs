using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            btn_Exit.Click += btn_Exit_Click;
            btn_ProjectStudentPopulation.Click += btn_ProjectStudentPopulation_Click;
        }

        private void btn_Exit_Click (object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_ProjectStudentPopulation_Click (object sender, EventArgs e)
        {
            // 1. Get the values from the textboxes
            // Trim() removes extra spaces
            int studentsToday = int.Parse(txt_NumOfStuToday.Text.Trim());
            double annualGrowthRate = double.Parse(txt_AnnualGrowthRate.Text.Trim());
            int numYears = int.Parse(txt_NumOfYears.Text.Trim());

            // Convert percent to decimal (e.g., 5% → 0.05)
            double growth = annualGrowthRate / 100;

            // Start with today's students
            double projectedStudents = studentsToday;

            // Counter for while loop
            int year = 1;

            // 2. While loop runs for the number of years
            //    Apply compounding population growth each year
            while (year <= numYears)
            {
                // Add growth for this year
                projectedStudents = projectedStudents * (1 + growth);

                // Move to next year
                year++;
            }

            // 3. Display result in the output textbox
            txt_ProNumOfStu.Text = projectedStudents.ToString("N0");
            // "N0" formats number like 3,450 (no decimals)
        }
    }


}
