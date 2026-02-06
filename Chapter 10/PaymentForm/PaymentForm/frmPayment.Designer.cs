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
            this.rdoCreditCard = new System.Windows.Forms.RadioButton();
            this.rdoBillCustomer = new System.Windows.Forms.RadioButton();
            this.lb_crctype = new System.Windows.Forms.Label();
            this.lblCardNumber = new System.Windows.Forms.Label();
            this.lblExpirationDate = new System.Windows.Forms.Label();
            this.txtCardNumber = new System.Windows.Forms.TextBox();
            this.lstCreditCardType = new System.Windows.Forms.ComboBox();
            this.cboMonth = new System.Windows.Forms.ComboBox();
            this.cboYear = new System.Windows.Forms.ComboBox();
            this.chkDefault = new System.Windows.Forms.CheckBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.grpPayment.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpPayment
            // 
            this.grpPayment.Controls.Add(this.rdoCreditCard);
            this.grpPayment.Controls.Add(this.rdoBillCustomer);
            this.grpPayment.Location = new System.Drawing.Point(30, 30);
            this.grpPayment.Name = "grpPayment";
            this.grpPayment.Size = new System.Drawing.Size(450, 70);
            this.grpPayment.TabIndex = 0;
            this.grpPayment.TabStop = false;
            this.grpPayment.Text = "Billing";
            // 
            // rdoCreditCard
            // 
            this.rdoCreditCard.AutoSize = true;
            this.rdoCreditCard.Checked = true;
            this.rdoCreditCard.Location = new System.Drawing.Point(20, 30);
            this.rdoCreditCard.Name = "rdoCreditCard";
            this.rdoCreditCard.Size = new System.Drawing.Size(111, 24);
            this.rdoCreditCard.TabIndex = 0;
            this.rdoCreditCard.TabStop = true;
            this.rdoCreditCard.Text = "Credit card";
            this.rdoCreditCard.UseVisualStyleBackColor = true;
            this.rdoCreditCard.CheckedChanged += new System.EventHandler(this.radCreditCard_CheckedChanged);
            // 
            // rdoBillCustomer
            // 
            this.rdoBillCustomer.AutoSize = true;
            this.rdoBillCustomer.Location = new System.Drawing.Point(250, 30);
            this.rdoBillCustomer.Name = "rdoBillCustomer";
            this.rdoBillCustomer.Size = new System.Drawing.Size(124, 24);
            this.rdoBillCustomer.TabIndex = 1;
            this.rdoBillCustomer.Text = "Bill customer";
            this.rdoBillCustomer.UseVisualStyleBackColor = true;
            this.rdoBillCustomer.CheckedChanged += new System.EventHandler(this.radBillCustomer_CheckedChanged);
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
            // lstCreditCardType
            // 
            this.lstCreditCardType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstCreditCardType.FormattingEnabled = true;
            this.lstCreditCardType.Items.AddRange(new object[] {
            "Visa",
            "Mastercard",
            "American Express"});
            this.lstCreditCardType.Location = new System.Drawing.Point(190, 117);
            this.lstCreditCardType.Name = "lstCreditCardType";
            this.lstCreditCardType.Size = new System.Drawing.Size(290, 28);
            this.lstCreditCardType.TabIndex = 5;
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
            // chkDefault
            // 
            this.chkDefault.AutoSize = true;
            this.chkDefault.Checked = true;
            this.chkDefault.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkDefault.Location = new System.Drawing.Point(50, 270);
            this.chkDefault.Name = "chkDefault";
            this.chkDefault.Size = new System.Drawing.Size(235, 24);
            this.chkDefault.TabIndex = 8;
            this.chkDefault.Text = "Set as default billing method";
            this.chkDefault.UseVisualStyleBackColor = true;
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
            this.Controls.Add(this.chkDefault);
            this.Controls.Add(this.cboYear);
            this.Controls.Add(this.cboMonth);
            this.Controls.Add(this.lstCreditCardType);
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
        private System.Windows.Forms.RadioButton rdoCreditCard;
        private System.Windows.Forms.RadioButton rdoBillCustomer;
        private System.Windows.Forms.Label lb_crctype;
        private System.Windows.Forms.Label lblCardNumber;
        private System.Windows.Forms.Label lblExpirationDate;
        private System.Windows.Forms.TextBox txtCardNumber;
        private System.Windows.Forms.ComboBox lstCreditCardType;
        private System.Windows.Forms.ComboBox cboMonth;
        private System.Windows.Forms.ComboBox cboYear;
        private System.Windows.Forms.CheckBox chkDefault;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
    }
}