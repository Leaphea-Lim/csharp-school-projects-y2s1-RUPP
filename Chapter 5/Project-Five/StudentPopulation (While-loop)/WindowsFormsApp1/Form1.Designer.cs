namespace WindowsFormsApp1
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
            this.lb_NumOfStuToday = new System.Windows.Forms.Label();
            this.txt_NumOfStuToday = new System.Windows.Forms.TextBox();
            this.btn_ProjectStudentPopulation = new System.Windows.Forms.Button();
            this.lb_AnnualGrowthRate = new System.Windows.Forms.Label();
            this.lb_NumOfYears = new System.Windows.Forms.Label();
            this.lb_ProNumOfStu = new System.Windows.Forms.Label();
            this.txt_ProNumOfStu = new System.Windows.Forms.TextBox();
            this.txt_NumOfYears = new System.Windows.Forms.TextBox();
            this.txt_AnnualGrowthRate = new System.Windows.Forms.TextBox();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_NumOfStuToday
            // 
            this.lb_NumOfStuToday.AutoSize = true;
            this.lb_NumOfStuToday.Location = new System.Drawing.Point(61, 56);
            this.lb_NumOfStuToday.Name = "lb_NumOfStuToday";
            this.lb_NumOfStuToday.Size = new System.Drawing.Size(196, 20);
            this.lb_NumOfStuToday.TabIndex = 0;
            this.lb_NumOfStuToday.Text = "Number of students today:";
            // 
            // txt_NumOfStuToday
            // 
            this.txt_NumOfStuToday.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_NumOfStuToday.Location = new System.Drawing.Point(317, 54);
            this.txt_NumOfStuToday.Name = "txt_NumOfStuToday";
            this.txt_NumOfStuToday.Size = new System.Drawing.Size(130, 26);
            this.txt_NumOfStuToday.TabIndex = 1;
            this.txt_NumOfStuToday.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btn_ProjectStudentPopulation
            // 
            this.btn_ProjectStudentPopulation.Location = new System.Drawing.Point(98, 237);
            this.btn_ProjectStudentPopulation.Name = "btn_ProjectStudentPopulation";
            this.btn_ProjectStudentPopulation.Size = new System.Drawing.Size(147, 67);
            this.btn_ProjectStudentPopulation.TabIndex = 2;
            this.btn_ProjectStudentPopulation.Text = "Project Student Population";
            this.btn_ProjectStudentPopulation.UseVisualStyleBackColor = true;
            // 
            // lb_AnnualGrowthRate
            // 
            this.lb_AnnualGrowthRate.AutoSize = true;
            this.lb_AnnualGrowthRate.Location = new System.Drawing.Point(61, 92);
            this.lb_AnnualGrowthRate.Name = "lb_AnnualGrowthRate";
            this.lb_AnnualGrowthRate.Size = new System.Drawing.Size(147, 20);
            this.lb_AnnualGrowthRate.TabIndex = 3;
            this.lb_AnnualGrowthRate.Text = "Anuual growth rate:";
            // 
            // lb_NumOfYears
            // 
            this.lb_NumOfYears.AutoSize = true;
            this.lb_NumOfYears.Location = new System.Drawing.Point(61, 130);
            this.lb_NumOfYears.Name = "lb_NumOfYears";
            this.lb_NumOfYears.Size = new System.Drawing.Size(129, 20);
            this.lb_NumOfYears.TabIndex = 4;
            this.lb_NumOfYears.Text = "Number of years:";
            this.lb_NumOfYears.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lb_ProNumOfStu
            // 
            this.lb_ProNumOfStu.AutoSize = true;
            this.lb_ProNumOfStu.Location = new System.Drawing.Point(61, 170);
            this.lb_ProNumOfStu.Name = "lb_ProNumOfStu";
            this.lb_ProNumOfStu.Size = new System.Drawing.Size(222, 20);
            this.lb_ProNumOfStu.TabIndex = 5;
            this.lb_ProNumOfStu.Text = "Projected number of students:";
            // 
            // txt_ProNumOfStu
            // 
            this.txt_ProNumOfStu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_ProNumOfStu.Location = new System.Drawing.Point(317, 168);
            this.txt_ProNumOfStu.Name = "txt_ProNumOfStu";
            this.txt_ProNumOfStu.ReadOnly = true;
            this.txt_ProNumOfStu.Size = new System.Drawing.Size(130, 26);
            this.txt_ProNumOfStu.TabIndex = 6;
            this.txt_ProNumOfStu.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_NumOfYears
            // 
            this.txt_NumOfYears.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_NumOfYears.Location = new System.Drawing.Point(317, 128);
            this.txt_NumOfYears.Name = "txt_NumOfYears";
            this.txt_NumOfYears.Size = new System.Drawing.Size(130, 26);
            this.txt_NumOfYears.TabIndex = 7;
            this.txt_NumOfYears.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_AnnualGrowthRate
            // 
            this.txt_AnnualGrowthRate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_AnnualGrowthRate.Location = new System.Drawing.Point(317, 90);
            this.txt_AnnualGrowthRate.Name = "txt_AnnualGrowthRate";
            this.txt_AnnualGrowthRate.Size = new System.Drawing.Size(130, 26);
            this.txt_AnnualGrowthRate.TabIndex = 8;
            this.txt_AnnualGrowthRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btn_Exit
            // 
            this.btn_Exit.BackColor = System.Drawing.Color.Red;
            this.btn_Exit.ForeColor = System.Drawing.Color.White;
            this.btn_Exit.Location = new System.Drawing.Point(293, 237);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(114, 67);
            this.btn_Exit.TabIndex = 9;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 361);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.txt_AnnualGrowthRate);
            this.Controls.Add(this.txt_NumOfYears);
            this.Controls.Add(this.txt_ProNumOfStu);
            this.Controls.Add(this.lb_ProNumOfStu);
            this.Controls.Add(this.lb_NumOfYears);
            this.Controls.Add(this.lb_AnnualGrowthRate);
            this.Controls.Add(this.btn_ProjectStudentPopulation);
            this.Controls.Add(this.txt_NumOfStuToday);
            this.Controls.Add(this.lb_NumOfStuToday);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_NumOfStuToday;
        private System.Windows.Forms.TextBox txt_NumOfStuToday;
        private System.Windows.Forms.Button btn_ProjectStudentPopulation;
        private System.Windows.Forms.Label lb_AnnualGrowthRate;
        private System.Windows.Forms.Label lb_NumOfYears;
        private System.Windows.Forms.Label lb_ProNumOfStu;
        private System.Windows.Forms.TextBox txt_ProNumOfStu;
        private System.Windows.Forms.TextBox txt_NumOfYears;
        private System.Windows.Forms.TextBox txt_AnnualGrowthRate;
        private System.Windows.Forms.Button btn_Exit;
    }
}

