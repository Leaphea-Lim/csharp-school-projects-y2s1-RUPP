namespace InvoiceTotal
{
    partial class InvTotal_Title
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
            this.lbSubTotal = new System.Windows.Forms.Label();
            this.txtSubTotal = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lbTotal = new System.Windows.Forms.Label();
            this.lbDisAmount = new System.Windows.Forms.Label();
            this.lbDisPercent = new System.Windows.Forms.Label();
            this.txtDisPercent = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtDisAmount = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbSubTotal
            // 
            this.lbSubTotal.AutoSize = true;
            this.lbSubTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSubTotal.Location = new System.Drawing.Point(74, 59);
            this.lbSubTotal.Name = "lbSubTotal";
            this.lbSubTotal.Size = new System.Drawing.Size(93, 22);
            this.lbSubTotal.TabIndex = 0;
            this.lbSubTotal.Text = "Sub Total:";
            //this.lbSubTotal.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtSubTotal
            // 
            this.txtSubTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSubTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubTotal.Location = new System.Drawing.Point(284, 53);
            this.txtSubTotal.Name = "txtSubTotal";
            this.txtSubTotal.Size = new System.Drawing.Size(154, 28);
            this.txtSubTotal.TabIndex = 1;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(117, 275);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(108, 38);
            this.btnCalculate.TabIndex = 2;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotal.Location = new System.Drawing.Point(74, 202);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(56, 22);
            this.lbTotal.TabIndex = 3;
            this.lbTotal.Text = "Total:";
            // 
            // lbDisAmount
            // 
            this.lbDisAmount.AutoSize = true;
            this.lbDisAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDisAmount.Location = new System.Drawing.Point(74, 152);
            this.lbDisAmount.Name = "lbDisAmount";
            this.lbDisAmount.Size = new System.Drawing.Size(151, 22);
            this.lbDisAmount.TabIndex = 4;
            this.lbDisAmount.Text = "Discount Amount:";
            // 
            // lbDisPercent
            // 
            this.lbDisPercent.AutoSize = true;
            this.lbDisPercent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDisPercent.Location = new System.Drawing.Point(74, 103);
            this.lbDisPercent.Name = "lbDisPercent";
            this.lbDisPercent.Size = new System.Drawing.Size(152, 22);
            this.lbDisPercent.TabIndex = 5;
            this.lbDisPercent.Text = "Discount Percent:";
            // 
            // txtDisPercent
            // 
            this.txtDisPercent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDisPercent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDisPercent.Location = new System.Drawing.Point(284, 99);
            this.txtDisPercent.Name = "txtDisPercent";
            this.txtDisPercent.ReadOnly = true;
            this.txtDisPercent.Size = new System.Drawing.Size(154, 28);
            this.txtDisPercent.TabIndex = 6;
            // 
            // txtTotal
            // 
            this.txtTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(284, 202);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(154, 28);
            this.txtTotal.TabIndex = 7;
            // 
            // txtDisAmount
            // 
            this.txtDisAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDisAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDisAmount.Location = new System.Drawing.Point(284, 150);
            this.txtDisAmount.Name = "txtDisAmount";
            this.txtDisAmount.ReadOnly = true;
            this.txtDisAmount.Size = new System.Drawing.Size(154, 28);
            this.txtDisAmount.TabIndex = 8;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(284, 275);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(108, 38);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // InvTotal_Title
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 374);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.txtDisAmount);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtDisPercent);
            this.Controls.Add(this.lbDisPercent);
            this.Controls.Add(this.lbDisAmount);
            this.Controls.Add(this.lbTotal);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtSubTotal);
            this.Controls.Add(this.lbSubTotal);
            this.Name = "InvTotal_Title";
            this.Text = "Invoice Total";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbSubTotal;
        private System.Windows.Forms.TextBox txtSubTotal;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.Label lbDisAmount;
        private System.Windows.Forms.Label lbDisPercent;
        private System.Windows.Forms.TextBox txtDisPercent;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtDisAmount;
        private System.Windows.Forms.Button btnExit;
    }
}

