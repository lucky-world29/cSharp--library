using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NIT_LAB
{
    public partial class Form10_9 : Form
    {
        public Form10_9(string category, string subcategory, string product)
        {
            InitializeComponent();
            lblCategory.Text = "Category: " + category;
            lblSubcategory.Text = "Subcategory: " + subcategory;
            lblProduct.Text = "Product: " + product;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
