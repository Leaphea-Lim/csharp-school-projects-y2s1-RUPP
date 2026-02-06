namespace Product_Maintenance
{
    partial class frmProductMain
    {
        private System.ComponentModel.IContainer components = null;
        private ListBox lstProducts;
        private Button btnAdd;
        private Button btnDelete;
        private Button btnExit;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lstProducts = new ListBox();
            btnAdd = new Button();
            btnDelete = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // lstProducts
            // 
            lstProducts.FormattingEnabled = true;
            lstProducts.ItemHeight = 25;
            lstProducts.Location = new Point(30, 30);
            lstProducts.Name = "lstProducts";
            lstProducts.Size = new Size(520, 304);
            lstProducts.TabIndex = 0;
            lstProducts.SelectedIndexChanged += this.lstProducts_SelectedIndexChanged_1;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(580, 30);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(231, 40);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Add Product...";
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(580, 90);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(231, 40);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Delete Product";
            btnDelete.Click += btnDelete_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Red;
            btnExit.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExit.ForeColor = Color.White;
            btnExit.Location = new Point(580, 150);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(231, 40);
            btnExit.TabIndex = 3;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // frmProductMain
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(852, 407);
            Controls.Add(lstProducts);
            Controls.Add(btnAdd);
            Controls.Add(btnDelete);
            Controls.Add(btnExit);
            Name = "frmProductMain";
            Text = "Product Maintenance";
            Load += Form1_Load;
            ResumeLayout(false);
        }
    }
}
