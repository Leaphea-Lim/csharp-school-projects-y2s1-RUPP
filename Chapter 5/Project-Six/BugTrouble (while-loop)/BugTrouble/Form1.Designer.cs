namespace BugTrouble
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lb_HouseVolume = new System.Windows.Forms.Label();
            this.txt_HouseVolume = new System.Windows.Forms.TextBox();
            this.btn_Calc = new System.Windows.Forms.Button();
            this.lb_InitialRoaches = new System.Windows.Forms.Label();
            this.lb_Weeks = new System.Windows.Forms.Label();
            this.lb_TotalRoaches = new System.Windows.Forms.Label();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.txt_InitialRoaches = new System.Windows.Forms.TextBox();
            this.txt_Weeks = new System.Windows.Forms.TextBox();
            this.txt_TotalRoaches = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lb_HouseVolume
            // 
            this.lb_HouseVolume.AutoSize = true;
            this.lb_HouseVolume.Location = new System.Drawing.Point(35, 42);
            this.lb_HouseVolume.Name = "lb_HouseVolume";
            this.lb_HouseVolume.Size = new System.Drawing.Size(252, 20);
            this.lb_HouseVolume.TabIndex = 0;
            this.lb_HouseVolume.Text = "Volumn of your house in cubic feet";
            // 
            // txt_HouseVolume
            // 
            this.txt_HouseVolume.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_HouseVolume.Location = new System.Drawing.Point(380, 40);
            this.txt_HouseVolume.Name = "txt_HouseVolume";
            this.txt_HouseVolume.Size = new System.Drawing.Size(154, 26);
            this.txt_HouseVolume.TabIndex = 1;
            // 
            // btn_Calc
            // 
            this.btn_Calc.Location = new System.Drawing.Point(41, 225);
            this.btn_Calc.Name = "btn_Calc";
            this.btn_Calc.Size = new System.Drawing.Size(246, 45);
            this.btn_Calc.TabIndex = 2;
            this.btn_Calc.Text = "Calculate when house is full";
            this.btn_Calc.UseVisualStyleBackColor = true;
            this.btn_Calc.Click += new System.EventHandler(this.btn_Calc_Click);

            // 
            // lb_InitialRoaches
            // 
            this.lb_InitialRoaches.AutoSize = true;
            this.lb_InitialRoaches.Location = new System.Drawing.Point(35, 81);
            this.lb_InitialRoaches.Name = "lb_InitialRoaches";
            this.lb_InitialRoaches.Size = new System.Drawing.Size(242, 20);
            this.lb_InitialRoaches.TabIndex = 3;
            this.lb_InitialRoaches.Text = "Number of roaches in your house";
            // 
            // lb_Weeks
            // 
            this.lb_Weeks.AutoSize = true;
            this.lb_Weeks.Location = new System.Drawing.Point(35, 120);
            this.lb_Weeks.Name = "lb_Weeks";
            this.lb_Weeks.Size = new System.Drawing.Size(178, 20);
            this.lb_Weeks.TabIndex = 4;
            this.lb_Weeks.Text = "Weeks until house is full";
            // 
            // lb_TotalRoaches
            // 
            this.lb_TotalRoaches.AutoSize = true;
            this.lb_TotalRoaches.Location = new System.Drawing.Point(36, 161);
            this.lb_TotalRoaches.Name = "lb_TotalRoaches";
            this.lb_TotalRoaches.Size = new System.Drawing.Size(181, 20);
            this.lb_TotalRoaches.TabIndex = 5;
            this.lb_TotalRoaches.Text = "Total number of roaches";
            // 
            // btn_Exit
            // 
            this.btn_Exit.Location = new System.Drawing.Point(380, 225);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(159, 42);
            this.btn_Exit.TabIndex = 6;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);

            // 
            // txt_InitialRoaches
            // 
            this.txt_InitialRoaches.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_InitialRoaches.Location = new System.Drawing.Point(380, 79);
            this.txt_InitialRoaches.Name = "txt_InitialRoaches";
            this.txt_InitialRoaches.Size = new System.Drawing.Size(154, 26);
            this.txt_InitialRoaches.TabIndex = 7;
            // 
            // txt_Weeks
            // 
            this.txt_Weeks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Weeks.Location = new System.Drawing.Point(380, 118);
            this.txt_Weeks.Name = "txt_Weeks";
            this.txt_Weeks.Size = new System.Drawing.Size(154, 26);
            this.txt_Weeks.TabIndex = 8;
            // 
            // txt_TotalRoaches
            // 
            this.txt_TotalRoaches.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_TotalRoaches.Location = new System.Drawing.Point(380, 159);
            this.txt_TotalRoaches.Name = "txt_TotalRoaches";
            this.txt_TotalRoaches.ReadOnly = true;
            this.txt_TotalRoaches.Size = new System.Drawing.Size(154, 26);
            this.txt_TotalRoaches.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 318);
            this.Controls.Add(this.txt_TotalRoaches);
            this.Controls.Add(this.txt_Weeks);
            this.Controls.Add(this.txt_InitialRoaches);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.lb_TotalRoaches);
            this.Controls.Add(this.lb_Weeks);
            this.Controls.Add(this.lb_InitialRoaches);
            this.Controls.Add(this.btn_Calc);
            this.Controls.Add(this.txt_HouseVolume);
            this.Controls.Add(this.lb_HouseVolume);
            this.Name = "Form1";
            this.Text = "Bug Trouble";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_HouseVolume;
        private System.Windows.Forms.TextBox txt_HouseVolume;
        private System.Windows.Forms.Button btn_Calc;
        private System.Windows.Forms.Label lb_InitialRoaches;
        private System.Windows.Forms.Label lb_Weeks;
        private System.Windows.Forms.Label lb_TotalRoaches;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.TextBox txt_InitialRoaches;
        private System.Windows.Forms.TextBox txt_Weeks;
        private System.Windows.Forms.TextBox txt_TotalRoaches;
    }
}

