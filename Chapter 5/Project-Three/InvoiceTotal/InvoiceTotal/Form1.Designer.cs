namespace InvoiceTotal
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
            System.Windows.Forms.Label lbSub_Total;
            this.lbCust_Type = new System.Windows.Forms.Label();
            this.txtCust_Type = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lbTotal = new System.Windows.Forms.Label();
            this.lbDis_Amount = new System.Windows.Forms.Label();
            this.lbDis_Percent = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtDis_Amount = new System.Windows.Forms.TextBox();
            this.txtDis_Percent = new System.Windows.Forms.TextBox();
            this.txtSub_Total = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            lbSub_Total = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbSub_Total
            // 
            lbSub_Total.AutoSize = true;
            lbSub_Total.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lbSub_Total.Location = new System.Drawing.Point(52, 99);
            lbSub_Total.Name = "lbSub_Total";
            lbSub_Total.Size = new System.Drawing.Size(77, 20);
            lbSub_Total.TabIndex = 6;
            lbSub_Total.Text = "Sub Total";
            // 
            // lbCust_Type
            // 
            this.lbCust_Type.AutoSize = true;
            this.lbCust_Type.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCust_Type.Location = new System.Drawing.Point(52, 60);
            this.lbCust_Type.Name = "lbCust_Type";
            this.lbCust_Type.Size = new System.Drawing.Size(116, 20);
            this.lbCust_Type.TabIndex = 0;
            this.lbCust_Type.Text = "Customer Type";
            // 
            // txtCust_Type
            // 
            this.txtCust_Type.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCust_Type.Location = new System.Drawing.Point(243, 58);
            this.txtCust_Type.Name = "txtCust_Type";
            this.txtCust_Type.Size = new System.Drawing.Size(100, 26);
            this.txtCust_Type.TabIndex = 1;
            this.txtCust_Type.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(94, 291);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(96, 42);
            this.btnCalculate.TabIndex = 2;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotal.Location = new System.Drawing.Point(52, 214);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(44, 20);
            this.lbTotal.TabIndex = 3;
            this.lbTotal.Text = "Total";
            // 
            // lbDis_Amount
            // 
            this.lbDis_Amount.AutoSize = true;
            this.lbDis_Amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDis_Amount.Location = new System.Drawing.Point(52, 176);
            this.lbDis_Amount.Name = "lbDis_Amount";
            this.lbDis_Amount.Size = new System.Drawing.Size(132, 20);
            this.lbDis_Amount.TabIndex = 4;
            this.lbDis_Amount.Text = "Discount Amount";
            // 
            // lbDis_Percent
            // 
            this.lbDis_Percent.AutoSize = true;
            this.lbDis_Percent.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDis_Percent.Location = new System.Drawing.Point(52, 137);
            this.lbDis_Percent.Name = "lbDis_Percent";
            this.lbDis_Percent.Size = new System.Drawing.Size(131, 20);
            this.lbDis_Percent.TabIndex = 5;
            this.lbDis_Percent.Text = "Discount Percent";
            // 
            // txtTotal
            // 
            this.txtTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotal.Location = new System.Drawing.Point(243, 208);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(100, 26);
            this.txtTotal.TabIndex = 7;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtDis_Amount
            // 
            this.txtDis_Amount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDis_Amount.Location = new System.Drawing.Point(243, 170);
            this.txtDis_Amount.Name = "txtDis_Amount";
            this.txtDis_Amount.ReadOnly = true;
            this.txtDis_Amount.Size = new System.Drawing.Size(100, 26);
            this.txtDis_Amount.TabIndex = 8;
            this.txtDis_Amount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtDis_Percent
            // 
            this.txtDis_Percent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDis_Percent.Location = new System.Drawing.Point(243, 131);
            this.txtDis_Percent.Name = "txtDis_Percent";
            this.txtDis_Percent.ReadOnly = true;
            this.txtDis_Percent.Size = new System.Drawing.Size(100, 26);
            this.txtDis_Percent.TabIndex = 9;
            this.txtDis_Percent.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtSub_Total
            // 
            this.txtSub_Total.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSub_Total.Location = new System.Drawing.Point(243, 94);
            this.txtSub_Total.Name = "txtSub_Total";
            this.txtSub_Total.Size = new System.Drawing.Size(100, 26);
            this.txtSub_Total.TabIndex = 10;
            this.txtSub_Total.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Red;
            this.btnExit.ForeColor = System.Drawing.SystemColors.Window;
            this.btnExit.Location = new System.Drawing.Point(231, 291);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(96, 42);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 401);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.txtSub_Total);
            this.Controls.Add(this.txtDis_Percent);
            this.Controls.Add(this.txtDis_Amount);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(lbSub_Total);
            this.Controls.Add(this.lbDis_Percent);
            this.Controls.Add(this.lbDis_Amount);
            this.Controls.Add(this.lbTotal);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtCust_Type);
            this.Controls.Add(this.lbCust_Type);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbCust_Type;
        private System.Windows.Forms.TextBox txtCust_Type;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.Label lbDis_Amount;
        private System.Windows.Forms.Label lbDis_Percent;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtDis_Amount;
        private System.Windows.Forms.TextBox txtDis_Percent;
        private System.Windows.Forms.TextBox txtSub_Total;
        private System.Windows.Forms.Button btnExit;
    }
}

