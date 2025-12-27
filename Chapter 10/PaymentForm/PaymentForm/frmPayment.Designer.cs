namespace PaymentForm
{
    partial class frmPayment
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
            this.grpPayment = new System.Windows.Forms.GroupBox();
            this.radCreditCard = new System.Windows.Forms.RadioButton();
            this.radBillCustomer = new System.Windows.Forms.RadioButton();
            this.lb_crctype = new System.Windows.Forms.Label();
            this.lblCardNumber = new System.Windows.Forms.Label();
            this.lblExpirationDate = new System.Windows.Forms.Label();
            this.txtCardNumber = new System.Windows.Forms.TextBox();
            this.cboCardType = new System.Windows.Forms.ComboBox();
            this.cboMonth = new System.Windows.Forms.ComboBox();
            this.cboYear = new System.Windows.Forms.ComboBox();
            this.chkDefaultBilling = new System.Windows.Forms.CheckBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.grpPayment.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpPayment
            // 
            this.grpPayment.Controls.Add(this.radCreditCard);
            this.grpPayment.Controls.Add(this.radBillCustomer);
            this.grpPayment.Location = new System.Drawing.Point(30, 30);
            this.grpPayment.Name = "grpPayment";
            this.grpPayment.Size = new System.Drawing.Size(450, 70);
            this.grpPayment.TabIndex = 0;
            this.grpPayment.TabStop = false;
            this.grpPayment.Text = "Billing";
            // 
            // radCreditCard
            // 
            this.radCreditCard.AutoSize = true;
            this.radCreditCard.Checked = true;
            this.radCreditCard.Location = new System.Drawing.Point(20, 30);
            this.radCreditCard.Name = "radCreditCard";
            this.radCreditCard.Size = new System.Drawing.Size(111, 24);
            this.radCreditCard.TabIndex = 0;
            this.radCreditCard.TabStop = true;
            this.radCreditCard.Text = "Credit card";
            this.radCreditCard.UseVisualStyleBackColor = true;
            this.radCreditCard.CheckedChanged += new System.EventHandler(this.radCreditCard_CheckedChanged);
            // 
            // radBillCustomer
            // 
            this.radBillCustomer.AutoSize = true;
            this.radBillCustomer.Location = new System.Drawing.Point(250, 30);
            this.radBillCustomer.Name = "radBillCustomer";
            this.radBillCustomer.Size = new System.Drawing.Size(124, 24);
            this.radBillCustomer.TabIndex = 1;
            this.radBillCustomer.Text = "Bill customer";
            this.radBillCustomer.UseVisualStyleBackColor = true;
            // 
            // lb_crctype
            // 
            this.lb_crctype.AutoSize = true;
            this.lb_crctype.Location = new System.Drawing.Point(50, 120);
            this.lb_crctype.Name = "lb_crctype";
            this.lb_crctype.Size = new System.Drawing.Size(124, 20);
            this.lb_crctype.TabIndex = 1;
            this.lb_crctype.Text = "Credit card type:";
            // 
            // lblCardNumber
            // 
            this.lblCardNumber.AutoSize = true;
            this.lblCardNumber.Location = new System.Drawing.Point(50, 170);
            this.lblCardNumber.Name = "lblCardNumber";
            this.lblCardNumber.Size = new System.Drawing.Size(105, 20);
            this.lblCardNumber.TabIndex = 2;
            this.lblCardNumber.Text = "Card number:";
            // 
            // lblExpirationDate
            // 
            this.lblExpirationDate.AutoSize = true;
            this.lblExpirationDate.Location = new System.Drawing.Point(50, 220);
            this.lblExpirationDate.Name = "lblExpirationDate";
            this.lblExpirationDate.Size = new System.Drawing.Size(119, 20);
            this.lblExpirationDate.TabIndex = 3;
            this.lblExpirationDate.Text = "Expiration date:";
            // 
            // txtCardNumber
            // 
            this.txtCardNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCardNumber.Location = new System.Drawing.Point(190, 168);
            this.txtCardNumber.Name = "txtCardNumber";
            this.txtCardNumber.Size = new System.Drawing.Size(290, 26);
            this.txtCardNumber.TabIndex = 4;
            // 
            // cboCardType
            // 
            this.cboCardType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCardType.FormattingEnabled = true;
            this.cboCardType.Items.AddRange(new object[] {
            "Visa",
            "Mastercard",
            "American Express"});
            this.cboCardType.Location = new System.Drawing.Point(190, 117);
            this.cboCardType.Name = "cboCardType";
            this.cboCardType.Size = new System.Drawing.Size(290, 28);
            this.cboCardType.TabIndex = 5;
            // 
            // cboMonth
            // 
            this.cboMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMonth.FormattingEnabled = true;
            this.cboMonth.Location = new System.Drawing.Point(190, 217);
            this.cboMonth.Name = "cboMonth";
            this.cboMonth.Size = new System.Drawing.Size(135, 28);
            this.cboMonth.TabIndex = 6;
            // 
            // cboYear
            // 
            this.cboYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboYear.FormattingEnabled = true;
            this.cboYear.Location = new System.Drawing.Point(345, 217);
            this.cboYear.Name = "cboYear";
            this.cboYear.Size = new System.Drawing.Size(135, 28);
            this.cboYear.TabIndex = 7;
            // 
            // chkDefaultBilling
            // 
            this.chkDefaultBilling.AutoSize = true;
            this.chkDefaultBilling.Checked = true;
            this.chkDefaultBilling.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkDefaultBilling.Location = new System.Drawing.Point(50, 270);
            this.chkDefaultBilling.Name = "chkDefaultBilling";
            this.chkDefaultBilling.Size = new System.Drawing.Size(235, 24);
            this.chkDefaultBilling.TabIndex = 8;
            this.chkDefaultBilling.Text = "Set as default billing method";
            this.chkDefaultBilling.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(270, 320);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(100, 35);
            this.btnOK.TabIndex = 9;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(380, 320);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 35);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmPayment
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(554, 420);
            this.ControlBox = false;
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.chkDefaultBilling);
            this.Controls.Add(this.cboYear);
            this.Controls.Add(this.cboMonth);
            this.Controls.Add(this.cboCardType);
            this.Controls.Add(this.txtCardNumber);
            this.Controls.Add(this.lblExpirationDate);
            this.Controls.Add(this.lblCardNumber);
            this.Controls.Add(this.lb_crctype);
            this.Controls.Add(this.grpPayment);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frmPayment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Payment";
            this.Load += new System.EventHandler(this.frmPayment_Load);
            this.grpPayment.ResumeLayout(false);
            this.grpPayment.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpPayment;
        private System.Windows.Forms.RadioButton radCreditCard;
        private System.Windows.Forms.RadioButton radBillCustomer;
        private System.Windows.Forms.Label lb_crctype;
        private System.Windows.Forms.Label lblCardNumber;
        private System.Windows.Forms.Label lblExpirationDate;
        private System.Windows.Forms.TextBox txtCardNumber;
        private System.Windows.Forms.ComboBox cboCardType;
        private System.Windows.Forms.ComboBox cboMonth;
        private System.Windows.Forms.ComboBox cboYear;
        private System.Windows.Forms.CheckBox chkDefaultBilling;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
    }
}