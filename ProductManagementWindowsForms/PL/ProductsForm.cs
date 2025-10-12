using ProductManagementWindowsForms.BL;
using System.Data;

namespace ProductManagementWindowsForms.PL;
public partial class ProductsForm : Form
{
    Products _products = new Products();
    public ProductsForm ()
    {
        InitializeComponent();
        this.dataGridView1.DataSource = _products.GetAllProducts();
    }

    private void ProductsForm_Load ( object sender, EventArgs e )
    {

    }

    private void groupBox1_Enter ( object sender, EventArgs e )
    {

    }

    private void dataGridView1_CellContentClick ( object sender, DataGridViewCellEventArgs e )
    {

    }

    private void button1_Click ( object sender, EventArgs e )
    {
        AddProductForm addProductForm = new AddProductForm();
        addProductForm.ShowDialog();
    }

    private void groupBox2_Enter ( object sender, EventArgs e )
    {

    }

    private void button8_Click ( object sender, EventArgs e )
    {

    }

    private void button7_Click ( object sender, EventArgs e )
    {

    }

    private void searchTxtBox_TextChanged ( object sender, EventArgs e )
    {
        DataTable dataTable = new DataTable();
        dataTable = _products.SearchProduct(searchTxtBox.Text);

        this.dataGridView1.DataSource = dataTable;
    }

    private void button6_Click ( object sender, EventArgs e )
    {
        if (MessageBox.Show("هل تريد حذف المنتوج المحدد؟", "حذف المنتوج", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
        {
            string productId = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            _products.DeleteProduct(productId);

            MessageBox.Show("تمت عملية الحذف بنجاح", "حذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        else
        {
            MessageBox.Show("تم إلغاء عملية الحذف", "حذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }



    }

}
