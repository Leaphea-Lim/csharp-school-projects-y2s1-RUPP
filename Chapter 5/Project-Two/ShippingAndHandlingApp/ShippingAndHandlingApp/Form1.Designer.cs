namespace ShippingAndHandlingApp
{
    partial class shipping_handling
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
            this.lbOrderTotal = new System.Windows.Forms.Label();
            this.txtOrderTotal = new System.Windows.Forms.TextBox();
            this.btnCalGrandTotal = new System.Windows.Forms.Button();
            this.lbCustType = new System.Windows.Forms.Label();
            this.lbShipCosts = new System.Windows.Forms.Label();
            this.lbSalesTax = new System.Windows.Forms.Label();
            this.lbGrandTotal = new System.Windows.Forms.Label();
            this.txtCustType = new System.Windows.Forms.TextBox();
            this.txtShipCosts = new System.Windows.Forms.TextBox();
            this.txtSalesTax = new System.Windows.Forms.TextBox();
            this.txtGrandTotal = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbOrderTotal
            // 
            this.lbOrderTotal.AutoSize = true;
            this.lbOrderTotal.Font = new System.Drawing.Font("Lexend Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOrderTotal.Location = new System.Drawing.Point(63, 70);
            this.lbOrderTotal.Name = "lbOrderTotal";
            this.lbOrderTotal.Size = new System.Drawing.Size(108, 29);
            this.lbOrderTotal.TabIndex = 0;
            this.lbOrderTotal.Text = "Order Total";
            // 
            // txtOrderTotal
            // 
            this.txtOrderTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOrderTotal.Font = new System.Drawing.Font("Lexend", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOrderTotal.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtOrderTotal.Location = new System.Drawing.Point(527, 68);
            this.txtOrderTotal.Name = "txtOrderTotal";
            this.txtOrderTotal.Size = new System.Drawing.Size(160, 30);
            this.txtOrderTotal.TabIndex = 1;
            this.txtOrderTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnCalGrandTotal
            // 
            this.btnCalGrandTotal.Font = new System.Drawing.Font("Lexend", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalGrandTotal.Location = new System.Drawing.Point(146, 343);
            this.btnCalGrandTotal.Name = "btnCalGrandTotal";
            this.btnCalGrandTotal.Size = new System.Drawing.Size(217, 48);
            this.btnCalGrandTotal.TabIndex = 2;
            this.btnCalGrandTotal.Text = "Calculate Grand Total";
            this.btnCalGrandTotal.UseVisualStyleBackColor = true;
            // 
            // lbCustType
            // 
            this.lbCustType.AutoSize = true;
            this.lbCustType.Font = new System.Drawing.Font("Lexend Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCustType.Location = new System.Drawing.Point(63, 116);
            this.lbCustType.Name = "lbCustType";
            this.lbCustType.Size = new System.Drawing.Size(414, 29);
            this.lbCustType.TabIndex = 3;
            this.lbCustType.Text = "Customer Type ( P=Preferred, N=non-Preferred)";
            // 
            // lbShipCosts
            // 
            this.lbShipCosts.AutoSize = true;
            this.lbShipCosts.Font = new System.Drawing.Font("Lexend Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbShipCosts.Location = new System.Drawing.Point(63, 166);
            this.lbShipCosts.Name = "lbShipCosts";
            this.lbShipCosts.Size = new System.Drawing.Size(406, 29);
            this.lbShipCosts.TabIndex = 4;
            this.lbShipCosts.Text = "Shipping Costs (Free for Preferred Customers)";
            // 
            // lbSalesTax
            // 
            this.lbSalesTax.AutoSize = true;
            this.lbSalesTax.Font = new System.Drawing.Font("Lexend Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSalesTax.Location = new System.Drawing.Point(63, 214);
            this.lbSalesTax.Name = "lbSalesTax";
            this.lbSalesTax.Size = new System.Drawing.Size(133, 29);
            this.lbSalesTax.TabIndex = 5;
            this.lbSalesTax.Text = "Sales Tax (7%)";
            // 
            // lbGrandTotal
            // 
            this.lbGrandTotal.AutoSize = true;
            this.lbGrandTotal.Font = new System.Drawing.Font("Lexend Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGrandTotal.Location = new System.Drawing.Point(63, 261);
            this.lbGrandTotal.Name = "lbGrandTotal";
            this.lbGrandTotal.Size = new System.Drawing.Size(112, 29);
            this.lbGrandTotal.TabIndex = 6;
            this.lbGrandTotal.Text = "Grand Total";
            // 
            // txtCustType
            // 
            this.txtCustType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCustType.Font = new System.Drawing.Font("Lexend", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustType.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtCustType.Location = new System.Drawing.Point(527, 115);
            this.txtCustType.Name = "txtCustType";
            this.txtCustType.Size = new System.Drawing.Size(160, 30);
            this.txtCustType.TabIndex = 7;
            this.txtCustType.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtShipCosts
            // 
            this.txtShipCosts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtShipCosts.Font = new System.Drawing.Font("Lexend", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtShipCosts.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtShipCosts.Location = new System.Drawing.Point(527, 164);
            this.txtShipCosts.Name = "txtShipCosts";
            this.txtShipCosts.ReadOnly = true;
            this.txtShipCosts.Size = new System.Drawing.Size(160, 30);
            this.txtShipCosts.TabIndex = 8;
            this.txtShipCosts.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtSalesTax
            // 
            this.txtSalesTax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSalesTax.Font = new System.Drawing.Font("Lexend", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalesTax.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtSalesTax.Location = new System.Drawing.Point(527, 213);
            this.txtSalesTax.Name = "txtSalesTax";
            this.txtSalesTax.ReadOnly = true;
            this.txtSalesTax.Size = new System.Drawing.Size(160, 30);
            this.txtSalesTax.TabIndex = 9;
            this.txtSalesTax.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtGrandTotal
            // 
            this.txtGrandTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtGrandTotal.Font = new System.Drawing.Font("Lexend", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGrandTotal.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtGrandTotal.Location = new System.Drawing.Point(527, 264);
            this.txtGrandTotal.Name = "txtGrandTotal";
            this.txtGrandTotal.ReadOnly = true;
            this.txtGrandTotal.Size = new System.Drawing.Size(160, 30);
            this.txtGrandTotal.TabIndex = 10;
            this.txtGrandTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Red;
            this.btnExit.Font = new System.Drawing.Font("Lexend", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.SystemColors.Control;
            this.btnExit.Location = new System.Drawing.Point(407, 343);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(124, 48);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            // 
            // shipping_handling
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.txtGrandTotal);
            this.Controls.Add(this.txtSalesTax);
            this.Controls.Add(this.txtShipCosts);
            this.Controls.Add(this.txtCustType);
            this.Controls.Add(this.lbGrandTotal);
            this.Controls.Add(this.lbSalesTax);
            this.Controls.Add(this.lbShipCosts);
            this.Controls.Add(this.lbCustType);
            this.Controls.Add(this.btnCalGrandTotal);
            this.Controls.Add(this.txtOrderTotal);
            this.Controls.Add(this.lbOrderTotal);
            this.Name = "shipping_handling";
            this.Text = "Shipping & Handling";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbOrderTotal;
        private System.Windows.Forms.TextBox txtOrderTotal;
        private System.Windows.Forms.Button btnCalGrandTotal;
        private System.Windows.Forms.Label lbCustType;
        private System.Windows.Forms.Label lbShipCosts;
        private System.Windows.Forms.Label lbSalesTax;
        private System.Windows.Forms.Label lbGrandTotal;
        private System.Windows.Forms.TextBox txtCustType;
        private System.Windows.Forms.TextBox txtShipCosts;
        private System.Windows.Forms.TextBox txtSalesTax;
        private System.Windows.Forms.TextBox txtGrandTotal;
        private System.Windows.Forms.Button btnExit;
    }
}

