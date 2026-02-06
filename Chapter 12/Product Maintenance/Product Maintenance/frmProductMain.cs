using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Product_Maintenance
{
    public partial class frmProductMain : Form
    {
        private List<Product> products = null;

        public frmProductMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            products = ProductDB.GetProducts();
            FillProductListBox();
        }

        private void FillProductListBox()
        {
            lstProducts.Items.Clear();
            foreach (Product p in products)
            {
                lstProducts.Items.Add(p.GetDisplayText("\t"));
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmNewProduct newForm = new frmNewProduct();
            Product product = newForm.GetNewProduct();

            if (product != null)
            {
                products.Add(product);
                ProductDB.SaveProducts(products);
                FillProductListBox();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int i = lstProducts.SelectedIndex;
            if (i != -1)
            {
                Product product = products[i];
                string message =
                    "Are you sure you want to delete " +
                    product.Description + "?";

                DialogResult button =
                    MessageBox.Show(message, "Confirm Delete",
                    MessageBoxButtons.YesNo);

                if (button == DialogResult.Yes)
                {
                    products.Remove(product);
                    ProductDB.SaveProducts(products);
                    FillProductListBox();
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
