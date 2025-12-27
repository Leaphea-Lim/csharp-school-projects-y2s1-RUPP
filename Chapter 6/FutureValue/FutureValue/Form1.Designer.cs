namespace FutureValue
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
            this.lbMonthly_Investment = new System.Windows.Forms.Label();
            this.txtMonthly_Invmest = new System.Windows.Forms.TextBox();
            this.btnCalcucalte = new System.Windows.Forms.Button();
            this.lbYearly_Interest = new System.Windows.Forms.Label();
            this.lbNum_of_Years = new System.Windows.Forms.Label();
            this.lbFuture_Value = new System.Windows.Forms.Label();
            this.txtFuture_Value = new System.Windows.Forms.TextBox();
            this.txtNum_of_Years = new System.Windows.Forms.TextBox();
            this.txtYearly_Interest = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbMonthly_Investment
            // 
            this.lbMonthly_Investment.AutoSize = true;
            this.lbMonthly_Investment.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMonthly_Investment.Location = new System.Drawing.Point(47, 62);
            this.lbMonthly_Investment.Name = "lbMonthly_Investment";
            this.lbMonthly_Investment.Size = new System.Drawing.Size(201, 26);
            this.lbMonthly_Investment.TabIndex = 0;
            this.lbMonthly_Investment.Text = "Monthly Invesment:";
            // 
            // txtMonthly_Invmest
            // 
            this.txtMonthly_Invmest.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMonthly_Invmest.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMonthly_Invmest.Location = new System.Drawing.Point(281, 62);
            this.txtMonthly_Invmest.Name = "txtMonthly_Invmest";
            this.txtMonthly_Invmest.Size = new System.Drawing.Size(128, 32);
            this.txtMonthly_Invmest.TabIndex = 1;
            this.txtMonthly_Invmest.TextChanged += new System.EventHandler(this.ClearFutureValue);
            this.txtMonthly_Invmest.Enter += new System.EventHandler(this.TextBox_Enter);
            this.txtMonthly_Invmest.Leave += new System.EventHandler(this.TextBox_Leave);
            // 
            // btnCalcucalte
            // 
            this.btnCalcucalte.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcucalte.Location = new System.Drawing.Point(98, 323);
            this.btnCalcucalte.Name = "btnCalcucalte";
            this.btnCalcucalte.Size = new System.Drawing.Size(108, 41);
            this.btnCalcucalte.TabIndex = 2;
            this.btnCalcucalte.Text = "Calculate";
            this.btnCalcucalte.UseVisualStyleBackColor = true;
            // 
            // lbYearly_Interest
            // 
            this.lbYearly_Interest.AutoSize = true;
            this.lbYearly_Interest.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbYearly_Interest.Location = new System.Drawing.Point(47, 114);
            this.lbYearly_Interest.Name = "lbYearly_Interest";
            this.lbYearly_Interest.Size = new System.Drawing.Size(211, 26);
            this.lbYearly_Interest.TabIndex = 3;
            this.lbYearly_Interest.Text = "Yearly Interest Rate:";
            // 
            // lbNum_of_Years
            // 
            this.lbNum_of_Years.AutoSize = true;
            this.lbNum_of_Years.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNum_of_Years.Location = new System.Drawing.Point(47, 169);
            this.lbNum_of_Years.Name = "lbNum_of_Years";
            this.lbNum_of_Years.Size = new System.Drawing.Size(184, 26);
            this.lbNum_of_Years.TabIndex = 4;
            this.lbNum_of_Years.Text = "Number of Years:";
            // 
            // lbFuture_Value
            // 
            this.lbFuture_Value.AutoSize = true;
            this.lbFuture_Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFuture_Value.Location = new System.Drawing.Point(47, 225);
            this.lbFuture_Value.Name = "lbFuture_Value";
            this.lbFuture_Value.Size = new System.Drawing.Size(142, 26);
            this.lbFuture_Value.TabIndex = 5;
            this.lbFuture_Value.Text = "Future Value:";
            // 
            // txtFuture_Value
            // 
            this.txtFuture_Value.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFuture_Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFuture_Value.Location = new System.Drawing.Point(281, 225);
            this.txtFuture_Value.Name = "txtFuture_Value";
            this.txtFuture_Value.ReadOnly = true;
            this.txtFuture_Value.Size = new System.Drawing.Size(128, 32);
            this.txtFuture_Value.TabIndex = 6;
            this.txtFuture_Value.TextChanged += new System.EventHandler(this.ClearFutureValue);
            this.txtFuture_Value.Enter += new System.EventHandler(this.TextBox_Enter);
            this.txtFuture_Value.Leave += new System.EventHandler(this.TextBox_Leave);
            // 
            // txtNum_of_Years
            // 
            this.txtNum_of_Years.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNum_of_Years.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNum_of_Years.Location = new System.Drawing.Point(281, 173);
            this.txtNum_of_Years.Name = "txtNum_of_Years";
            this.txtNum_of_Years.Size = new System.Drawing.Size(128, 32);
            this.txtNum_of_Years.TabIndex = 7;
            this.txtNum_of_Years.TextChanged += new System.EventHandler(this.ClearFutureValue);
            this.txtNum_of_Years.Enter += new System.EventHandler(this.TextBox_Enter);
            this.txtNum_of_Years.Leave += new System.EventHandler(this.TextBox_Leave);
            // 
            // txtYearly_Interest
            // 
            this.txtYearly_Interest.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtYearly_Interest.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtYearly_Interest.Location = new System.Drawing.Point(281, 114);
            this.txtYearly_Interest.Name = "txtYearly_Interest";
            this.txtYearly_Interest.Size = new System.Drawing.Size(128, 32);
            this.txtYearly_Interest.TabIndex = 8;
            this.txtYearly_Interest.TextChanged += new System.EventHandler(this.ClearFutureValue);
            this.txtYearly_Interest.Enter += new System.EventHandler(this.TextBox_Enter);
            this.txtYearly_Interest.Leave += new System.EventHandler(this.TextBox_Leave);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Red;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.SystemColors.Control;
            this.btnExit.Location = new System.Drawing.Point(257, 323);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(108, 41);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.txtYearly_Interest);
            this.Controls.Add(this.txtNum_of_Years);
            this.Controls.Add(this.txtFuture_Value);
            this.Controls.Add(this.lbFuture_Value);
            this.Controls.Add(this.lbNum_of_Years);
            this.Controls.Add(this.lbYearly_Interest);
            this.Controls.Add(this.btnCalcucalte);
            this.Controls.Add(this.txtMonthly_Invmest);
            this.Controls.Add(this.lbMonthly_Investment);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "Future Value";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbMonthly_Investment;
        private System.Windows.Forms.TextBox txtMonthly_Invmest;
        private System.Windows.Forms.Button btnCalcucalte;
        private System.Windows.Forms.Label lbYearly_Interest;
        private System.Windows.Forms.Label lbNum_of_Years;
        private System.Windows.Forms.Label lbFuture_Value;
        private System.Windows.Forms.TextBox txtFuture_Value;
        private System.Windows.Forms.TextBox txtNum_of_Years;
        private System.Windows.Forms.TextBox txtYearly_Interest;
        private System.Windows.Forms.Button btnExit;
    }
}

