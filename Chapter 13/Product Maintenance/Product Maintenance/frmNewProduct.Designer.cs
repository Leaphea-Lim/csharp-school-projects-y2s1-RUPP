namespace Product_Maintenance
{
    partial class frmNewProduct
    {
        private TextBox txtCode;
        private TextBox txtDescription;
        private TextBox txtPrice;
        private Button btnSave;
        private Button btnCancel;
        private Label lblCode;
        private Label lblDescription;
        private Label lblPrice;

        private void InitializeComponent()
        {
            txtCode = new TextBox();
            txtDescription = new TextBox();
            txtPrice = new TextBox();
            btnSave = new Button();
            btnCancel = new Button();
            lblCode = new Label();
            lblDescription = new Label();
            lblPrice = new Label();
            SuspendLayout();
            // 
            // txtCode
            // 
            txtCode.Location = new Point(162, 30);
            txtCode.Name = "txtCode";
            txtCode.Size = new Size(148, 31);
            txtCode.TabIndex = 1;
            txtCode.Tag = "Code";
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(162, 80);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(148, 31);
            txtDescription.TabIndex = 3;
            txtDescription.Tag = "Description";
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(162, 130);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(148, 31);
            txtPrice.TabIndex = 5;
            txtPrice.Tag = "Price";
            // 
            // btnSave
            // 
            btnSave.BackColor = SystemColors.ActiveCaption;
            btnSave.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(65, 203);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(79, 47);
            btnSave.TabIndex = 6;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(185, 203);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(79, 47);
            btnCancel.TabIndex = 7;
            btnCancel.Text = "Cancel";
            btnCancel.Click += btnCancel_Click;
            // 
            // lblCode
            // 
            lblCode.Location = new Point(30, 30);
            lblCode.Name = "lblCode";
            lblCode.Size = new Size(100, 23);
            lblCode.TabIndex = 0;
            lblCode.Text = "Code:";
            // 
            // lblDescription
            // 
            lblDescription.Location = new Point(30, 80);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(100, 23);
            lblDescription.TabIndex = 2;
            lblDescription.Text = "Description:";
            // 
            // lblPrice
            // 
            lblPrice.Location = new Point(30, 130);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(100, 23);
            lblPrice.TabIndex = 4;
            lblPrice.Text = "Price:";
            // 
            // frmNewProduct
            // 
            ClientSize = new Size(352, 296);
            Controls.Add(lblCode);
            Controls.Add(txtCode);
            Controls.Add(lblDescription);
            Controls.Add(txtDescription);
            Controls.Add(lblPrice);
            Controls.Add(txtPrice);
            Controls.Add(btnSave);
            Controls.Add(btnCancel);
            Name = "frmNewProduct";
            Text = "New Product";
            Load += frmNewProduct_Load;
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
