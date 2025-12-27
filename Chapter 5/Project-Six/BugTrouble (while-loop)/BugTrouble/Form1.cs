using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BugTrouble
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Calc_Click(object sender, EventArgs e)
        {
              // -----------------------------
            // 1. GET VALUES FROM TEXTBOXES
            // -----------------------------

            // Read the house volume typed by the user.
            // Convert.ToDouble() changes text → number.
            double houseVolume = Convert.ToDouble(txt_HouseVolume.Text);

            // Read the number of roaches typed by the user.
            double roaches = Convert.ToDouble(txt_InitialRoaches.Text);


            // -----------------------------
            // 2. SET CONSTANT VALUES
            // -----------------------------

            double roachVolume = 0.002; 
            // Each roach takes up 0.002 cubic feet.

            double weeklyGrowth = 1.95; 
            // This means roaches grow 95% every week.
            // Same as: roaches = roaches * 1.95

            int weeks = 0;
            // Counter to track how many weeks pass.


            // -----------------------------
            // 3. WHILE LOOP (KEEP GROWING ROACHES)
            // -----------------------------

            // The loop runs while the total roach volume is LESS than the volume of the house.
            // roaches * roachVolume = total cubic feet occupied by roaches.
            while (roaches * roachVolume < houseVolume)
            {
                // Roaches increase each week by 95%.
                roaches = roaches * weeklyGrowth;

                // Move one week forward.
                weeks++;
            }


            // -----------------------------
            // 4. OUTPUT RESULTS TO TEXTBOXES
            // -----------------------------

            // Show how many weeks until the house is full.
            txt_Weeks.Text = weeks.ToString();

            // Show total number of roaches when house is full.
            // "N0" formats like: 345,000 (comma-separated)
            txt_TotalRoaches.Text = roaches.ToString("N0");
        }

    }
}
