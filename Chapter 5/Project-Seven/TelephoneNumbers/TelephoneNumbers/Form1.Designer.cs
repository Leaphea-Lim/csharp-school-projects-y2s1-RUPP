namespace TelephoneNumbers
{
    partial class frmTelephoneConverter
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
            this.txtAlphanumeric = new System.Windows.Forms.TextBox();
            this.lblAlphanumeric = new System.Windows.Forms.Label();
            this.btnConvert = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblNumericOnly = new System.Windows.Forms.Label();
            this.txtNumericOnly = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtAlphanumeric
            // 
            this.txtAlphanumeric.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAlphanumeric.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAlphanumeric.Location = new System.Drawing.Point(314, 54);
            this.txtAlphanumeric.Name = "txtAlphanumeric";
            this.txtAlphanumeric.Size = new System.Drawing.Size(166, 32);
            this.txtAlphanumeric.TabIndex = 0;
            // 
            // lblAlphanumeric
            // 
            this.lblAlphanumeric.AutoSize = true;
            this.lblAlphanumeric.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlphanumeric.Location = new System.Drawing.Point(50, 59);
            this.lblAlphanumeric.Name = "lblAlphanumeric";
            this.lblAlphanumeric.Size = new System.Drawing.Size(230, 26);
            this.lblAlphanumeric.TabIndex = 1;
            this.lblAlphanumeric.Text = "Alphanumeric Number";
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(55, 199);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(201, 61);
            this.btnConvert.TabIndex = 2;
            this.btnConvert.Text = "Convert to Numeric only";
            this.btnConvert.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(356, 199);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(124, 61);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // lblNumericOnly
            // 
            this.lblNumericOnly.AutoSize = true;
            this.lblNumericOnly.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumericOnly.Location = new System.Drawing.Point(50, 115);
            this.lblNumericOnly.Name = "lblNumericOnly";
            this.lblNumericOnly.Size = new System.Drawing.Size(145, 26);
            this.lblNumericOnly.TabIndex = 4;
            this.lblNumericOnly.Text = "Numeric Only";
            // 
            // txtNumericOnly
            // 
            this.txtNumericOnly.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNumericOnly.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumericOnly.Location = new System.Drawing.Point(314, 116);
            this.txtNumericOnly.Name = "txtNumericOnly";
            this.txtNumericOnly.ReadOnly = true;
            this.txtNumericOnly.Size = new System.Drawing.Size(166, 32);
            this.txtNumericOnly.TabIndex = 5;
            // 
            // frmTelephoneConverter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 322);
            this.Controls.Add(this.txtNumericOnly);
            this.Controls.Add(this.lblNumericOnly);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.lblAlphanumeric);
            this.Controls.Add(this.txtAlphanumeric);
            this.Name = "frmTelephoneConverter";
            this.Text = "Telephone Converter";
            //this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAlphanumeric;
        private System.Windows.Forms.Label lblAlphanumeric;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblNumericOnly;
        private System.Windows.Forms.TextBox txtNumericOnly;
    }
}

