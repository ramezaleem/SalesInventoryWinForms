using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductManagementWindowsForms.PL
{
    public partial class ProductsList : Form
    {
        BL.Products Products = new BL.Products();
        public ProductsList()
        {
            InitializeComponent();
            this.productsListDGV.DataSource = Products.GetAllProducts();
        }

        private void productsListDGV_DoubleClick(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
