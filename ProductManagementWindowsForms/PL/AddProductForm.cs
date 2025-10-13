using ProductManagementWindowsForms.BL;
using ProductManagementWindowsForms.DAL;
using System.Data;
using System.Data.SqlClient;

namespace ProductManagementWindowsForms.PL;
public partial class AddProductForm : Form
{
    public string state = "add";
    Products product = new Products();
    DataAccessLayer accessLayer = new DataAccessLayer();
    public AddProductForm()
    {
        InitializeComponent();

        cmbCategories.DataSource = product.GetAllCategories();
        cmbCategories.DisplayMember = "Description";
        cmbCategories.ValueMember = "CategoryId";
    }

    private void groupBox1_Enter(object sender, EventArgs e)
    {

    }

    private void label4_Click(object sender, EventArgs e)
    {

    }

    private void textBox4_TextChanged(object sender, EventArgs e)
    {

    }

    private void label6_Click(object sender, EventArgs e)
    {

    }

    private void browseFilesBtn_Click(object sender, EventArgs e)
    {
        OpenFileDialog openFileDialog = new OpenFileDialog();
        openFileDialog.Filter = "ملفات الصور | *.JPG; *.PNG; *.GIF;";

        if (openFileDialog.ShowDialog() == DialogResult.OK)
        {
            productImageBox.Image = Image.FromFile(openFileDialog.FileName);
        }
    }

    private void cmbCategories_SelectedIndexChanged(object sender, EventArgs e)
    {


    }

    private void okBtn_Click(object sender, EventArgs e)
    {
        try
        {
            MemoryStream memoryStream = new MemoryStream();
            productImageBox.Image.Save(memoryStream, productImageBox.Image.RawFormat);
            byte[] byteImage = memoryStream.ToArray();

            if (state == "add") // وضع الإضافة
            {
                product.AddProduct(
                    Convert.ToInt32(cmbCategories.SelectedValue),
                    txtDesc.Text,
                    txtRef.Text,
                    Convert.ToInt32(txtQuantity.Text),
                    txtPrice.Text,
                    byteImage
                );

                MessageBox.Show("تمت الإضافة بنجاح", "عملية الإضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (state == "update") // وضع التحديث
            {
                product.UpdateProduct(
                    Convert.ToInt32(cmbCategories.SelectedValue),
                    txtDesc.Text,
                    txtRef.Text,   // الـ Primary Key مش هيتغير
                    Convert.ToInt32(txtQuantity.Text),
                    txtPrice.Text,
                    byteImage
                );

                MessageBox.Show("تم التحديث بنجاح", "عملية التحديث", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            this.Close(); // قفل الفورم بعد العملية
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void txtRef_Validated(object sender, EventArgs e)
    {
        if (state == "add")
        {
            DataTable dataTable = new DataTable();

            dataTable = product.VerifyProductId(txtRef.Text);

            if (dataTable.Rows.Count > 0)
            {
                MessageBox.Show("هذا المعرف موجود مسبقا", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtRef.Focus();
                txtRef.SelectionStart = 0;
                txtRef.SelectionLength = txtRef.TextLength;
            }
        }

    }

    private void cancelBtn_Click(object sender, EventArgs e)
    {
        this.Close();
    }
}
