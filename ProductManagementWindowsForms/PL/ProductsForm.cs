using ProductManagementWindowsForms.BL;
using System.Data;

namespace ProductManagementWindowsForms.PL;
public partial class ProductsForm : Form
{
    Products _products = new Products();
    public ProductsForm()
    {
        InitializeComponent();
        this.dataGridView1.DataSource = _products.GetAllProducts();
    }

    private void ProductsForm_Load(object sender, EventArgs e)
    {

    }

    private void groupBox1_Enter(object sender, EventArgs e)
    {

    }

    private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {

    }

    private void button1_Click(object sender, EventArgs e)
    {
        AddProductForm addProductForm = new AddProductForm();
        addProductForm.ShowDialog();
        dataGridView1.DataSource = _products.GetAllProducts();
    }


    private void groupBox2_Enter(object sender, EventArgs e)
    {

    }

    private void button8_Click(object sender, EventArgs e)
    {

    }

    private void button7_Click(object sender, EventArgs e)
    {
        this.Close();
    }

    private void searchTxtBox_TextChanged(object sender, EventArgs e)
    {
        DataTable dataTable = new DataTable();
        dataTable = _products.SearchProduct(searchTxtBox.Text);

        this.dataGridView1.DataSource = dataTable;
    }

    private void button6_Click(object sender, EventArgs e)
    {
        if (MessageBox.Show("هل تريد حذف المنتوج المحدد؟", "حذف المنتوج", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
        {
            string productId = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            _products.DeleteProduct(productId);

            MessageBox.Show("تمت عملية الحذف بنجاح", "حذف", MessageBoxButtons.OK, MessageBoxIcon.Information);

            dataGridView1.DataSource = _products.GetAllProducts();
        }
        else
        {
            MessageBox.Show("تم إلغاء عملية الحذف", "حذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }

    private void button5_Click(object sender, EventArgs e)
    {
        AddProductForm addProduct = new AddProductForm();

        if (dataGridView1.CurrentRow != null)
        {
            addProduct.txtRef.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            addProduct.txtDesc.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            addProduct.txtQuantity.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            addProduct.txtPrice.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            addProduct.cmbCategories.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();

            addProduct.Text = "تحديث المنتوج : " + dataGridView1.CurrentRow.Cells[1].Value.ToString();
            addProduct.okBtn.Text = "تحديث";
            addProduct.state = "update";
            addProduct.txtRef.ReadOnly = true;

            try
            {
                byte[] imageData = (byte[])_products.GetProductImage(this.dataGridView1.CurrentRow.Cells[0].Value.ToString()).Rows[0][0];

                if (imageData != null && imageData.Length > 0)
                {
                    using (MemoryStream ms = new MemoryStream(imageData))
                    {
                        addProduct.productImageBox.Image = Image.FromStream(ms);
                    }
                }
                else
                {
                    addProduct.productImageBox.Image = null;
                }
            }
            catch
            {
                addProduct.productImageBox.Image = null;
            }
        }

        addProduct.ShowDialog();
        dataGridView1.DataSource = _products.GetAllProducts();
    }

    private void button2_Click(object sender, EventArgs e)
    {
        if (dataGridView1.CurrentRow == null) return;

        var imageRow = _products.GetProductImage(dataGridView1.CurrentRow.Cells[0].Value.ToString());
        if (imageRow.Rows.Count == 0 || imageRow.Rows[0][0] == DBNull.Value) return;

        byte[] imageData = (byte[])imageRow.Rows[0][0];

        ProductImagePreview productImage = new ProductImagePreview();

        using (MemoryStream ms = new MemoryStream(imageData))
        {
            productImage.pictureBox1.Image = Image.FromStream(ms);
        }

        productImage.ShowDialog();
    }


}
