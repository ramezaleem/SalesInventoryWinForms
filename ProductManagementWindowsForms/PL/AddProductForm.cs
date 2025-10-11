using ProductManagementWindowsForms.BL;

namespace ProductManagementWindowsForms.PL;
public partial class AddProductForm : Form
{
    Products _products = new Products();
    public AddProductForm ()
    {
        InitializeComponent();

        cmbCategories.DataSource = _products.GetAllProducts();
        cmbCategories.DisplayMember = "Description";
        cmbCategories.ValueMember = "CategoryId";
    }

    private void groupBox1_Enter ( object sender, EventArgs e )
    {

    }

    private void label4_Click ( object sender, EventArgs e )
    {

    }

    private void textBox4_TextChanged ( object sender, EventArgs e )
    {

    }

    private void label6_Click ( object sender, EventArgs e )
    {

    }

    private void browseFilesBtn_Click ( object sender, EventArgs e )
    {
        OpenFileDialog openFileDialog = new OpenFileDialog();
        openFileDialog.Filter = "ملفات الصور | *.JPG; *.PNG; *.GIF;";

        if (openFileDialog.ShowDialog() == DialogResult.OK)
        {
            productImageBox.Image = Image.FromFile(openFileDialog.FileName);
        }
    }

    private void cmbCategories_SelectedIndexChanged ( object sender, EventArgs e )
    {


    }

    private void okBtn_Click ( object sender, EventArgs e )
    {
        MemoryStream memoryStream = new MemoryStream();
        productImageBox.Image.Save(memoryStream, productImageBox.Image.RawFormat);

        byte[] byteImage = memoryStream.ToArray();

        _products.AddProduct(Convert.ToInt32(cmbCategories.SelectedValue), txtDesc.Text,
            txtRef.Text, Convert.ToInt32(txtQuantity.Text), txtPrice.Text, byteImage);

        MessageBox.Show("تمت الإضافة بنجاح", "عملية الإضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);

    }
}
