namespace calculateLetterGrade
{
    partial class formCalGrade
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
            this.lbNumericGr = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbLetterGr = new System.Windows.Forms.Label();
            this.txtNumericGr = new System.Windows.Forms.TextBox();
            this.txtLetterGr = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbNumericGr
            // 
            this.lbNumericGr.AutoSize = true;
            this.lbNumericGr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNumericGr.Location = new System.Drawing.Point(46, 78);
            this.lbNumericGr.Name = "lbNumericGr";
            this.lbNumericGr.Size = new System.Drawing.Size(183, 29);
            this.lbNumericGr.TabIndex = 0;
            this.lbNumericGr.Text = "Numeric Grade:";
         
            // 
            // lbLetterGr
            // 
            this.lbLetterGr.AutoSize = true;
            this.lbLetterGr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLetterGr.Location = new System.Drawing.Point(46, 142);
            this.lbLetterGr.Name = "lbLetterGr";
            this.lbLetterGr.Size = new System.Drawing.Size(153, 29);
            this.lbLetterGr.TabIndex = 2;
            this.lbLetterGr.Text = "Letter Grade:";
            // 
            // txtNumericGr
            // 
            this.txtNumericGr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNumericGr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumericGr.Location = new System.Drawing.Point(248, 72);
            this.txtNumericGr.Name = "txtNumericGr";
            this.txtNumericGr.Size = new System.Drawing.Size(161, 35);
            this.txtNumericGr.TabIndex = 3;
            // 
            // txtLetterGr
            // 
            this.txtLetterGr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLetterGr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLetterGr.Location = new System.Drawing.Point(248, 140);
            this.txtLetterGr.Name = "txtLetterGr";
            this.txtLetterGr.Size = new System.Drawing.Size(161, 35);
            this.txtLetterGr.TabIndex = 4;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(51, 240);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(148, 86);
            this.btnCalculate.TabIndex = 5;
            this.btnCalculate.Text = "Calculate Letter Grade";
            this.btnCalculate.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(271, 240);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(148, 86);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            //this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.BackColor = System.Drawing.Color.Red;
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            //this.btnExit.Click += new System.EventHandler(this.btnExit_Click_1);
            // 
            // formCalGrade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtLetterGr);
            this.Controls.Add(this.txtNumericGr);
            this.Controls.Add(this.lbLetterGr);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbNumericGr);
            this.Name = "formCalGrade";
            this.Text = "Caculate Letter Grade";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbNumericGr;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbLetterGr;
        private System.Windows.Forms.TextBox txtNumericGr;
        private System.Windows.Forms.TextBox txtLetterGr;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnExit;
    }
}

