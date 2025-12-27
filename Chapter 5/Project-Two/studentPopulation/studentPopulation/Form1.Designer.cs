namespace studentPopulation
{
    partial class txtStu
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
            this.lbNumOfStu = new System.Windows.Forms.Label();
            this.lbAnnualRate = new System.Windows.Forms.Label();
            this.lbNumOfYear = new System.Windows.Forms.Label();
            this.lbProjNumOfStu = new System.Windows.Forms.Label();
            this.txtNumOfStu = new System.Windows.Forms.TextBox();
            this.txtAnnualRate = new System.Windows.Forms.TextBox();
            this.txtNumOfYear = new System.Windows.Forms.TextBox();
            this.txtProjNumOfStu = new System.Windows.Forms.TextBox();
            this.btnResult = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbNumOfStu
            // 
            this.lbNumOfStu.AutoSize = true;
            this.lbNumOfStu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNumOfStu.Location = new System.Drawing.Point(49, 61);
            this.lbNumOfStu.Name = "lbNumOfStu";
            this.lbNumOfStu.Size = new System.Drawing.Size(292, 29);
            this.lbNumOfStu.TabIndex = 0;
            this.lbNumOfStu.Text = "Number of students today:";
            // 
            // lbAnnualRate
            // 
            this.lbAnnualRate.AutoSize = true;
            this.lbAnnualRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAnnualRate.Location = new System.Drawing.Point(49, 115);
            this.lbAnnualRate.Name = "lbAnnualRate";
            this.lbAnnualRate.Size = new System.Drawing.Size(224, 29);
            this.lbAnnualRate.TabIndex = 1;
            this.lbAnnualRate.Text = "Annual growth rate: ";
            // 
            // lbNumOfYear
            // 
            this.lbNumOfYear.AutoSize = true;
            this.lbNumOfYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNumOfYear.Location = new System.Drawing.Point(49, 168);
            this.lbNumOfYear.Name = "lbNumOfYear";
            this.lbNumOfYear.Size = new System.Drawing.Size(196, 29);
            this.lbNumOfYear.TabIndex = 2;
            this.lbNumOfYear.Text = "Number of years:";
            this.lbNumOfYear.Click += new System.EventHandler(this.lbNumOfYear_Click);
            // 
            // lbProjNumOfStu
            // 
            this.lbProjNumOfStu.AutoSize = true;
            this.lbProjNumOfStu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProjNumOfStu.Location = new System.Drawing.Point(49, 222);
            this.lbProjNumOfStu.Name = "lbProjNumOfStu";
            this.lbProjNumOfStu.Size = new System.Drawing.Size(333, 29);
            this.lbProjNumOfStu.TabIndex = 3;
            this.lbProjNumOfStu.Text = "Projected number of students:";
            this.lbProjNumOfStu.Click += new System.EventHandler(this.lbProjNumOfStu_Click);
            // 
            // txtNumOfStu
            // 
            this.txtNumOfStu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNumOfStu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumOfStu.Location = new System.Drawing.Point(403, 63);
            this.txtNumOfStu.Name = "txtNumOfStu";
            this.txtNumOfStu.Size = new System.Drawing.Size(217, 32);
            this.txtNumOfStu.TabIndex = 4;
            this.txtNumOfStu.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtAnnualRate
            // 
            this.txtAnnualRate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAnnualRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAnnualRate.Location = new System.Drawing.Point(403, 114);
            this.txtAnnualRate.Name = "txtAnnualRate";
            this.txtAnnualRate.Size = new System.Drawing.Size(217, 32);
            this.txtAnnualRate.TabIndex = 5;
            this.txtAnnualRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtNumOfYear
            // 
            this.txtNumOfYear.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNumOfYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumOfYear.Location = new System.Drawing.Point(403, 168);
            this.txtNumOfYear.Name = "txtNumOfYear";
            this.txtNumOfYear.Size = new System.Drawing.Size(217, 32);
            this.txtNumOfYear.TabIndex = 6;
            this.txtNumOfYear.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtProjNumOfStu
            // 
            this.txtProjNumOfStu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProjNumOfStu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProjNumOfStu.Location = new System.Drawing.Point(403, 219);
            this.txtProjNumOfStu.Name = "txtProjNumOfStu";
            this.txtProjNumOfStu.ReadOnly = true;
            this.txtProjNumOfStu.Size = new System.Drawing.Size(217, 32);
            this.txtProjNumOfStu.TabIndex = 7;
            this.txtProjNumOfStu.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnResult
            // 
            this.btnResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResult.Location = new System.Drawing.Point(77, 333);
            this.btnResult.Name = "btnResult";
            this.btnResult.Size = new System.Drawing.Size(196, 92);
            this.btnResult.TabIndex = 8;
            this.btnResult.Text = "Project Student Population ";
            this.btnResult.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(403, 333);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(196, 92);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // txtStu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 510);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnResult);
            this.Controls.Add(this.txtProjNumOfStu);
            this.Controls.Add(this.txtNumOfYear);
            this.Controls.Add(this.txtAnnualRate);
            this.Controls.Add(this.txtNumOfStu);
            this.Controls.Add(this.lbProjNumOfStu);
            this.Controls.Add(this.lbNumOfYear);
            this.Controls.Add(this.lbAnnualRate);
            this.Controls.Add(this.lbNumOfStu);
            this.Name = "txtStu";
            this.Text = "Sutdent Population";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbNumOfStu;
        private System.Windows.Forms.Label lbAnnualRate;
        private System.Windows.Forms.Label lbNumOfYear;
        private System.Windows.Forms.Label lbProjNumOfStu;
        private System.Windows.Forms.TextBox txtNumOfStu;
        private System.Windows.Forms.TextBox txtAnnualRate;
        private System.Windows.Forms.TextBox txtNumOfYear;
        private System.Windows.Forms.TextBox txtProjNumOfStu;
        private System.Windows.Forms.Button btnResult;
        private System.Windows.Forms.Button btnExit;
    }
}

