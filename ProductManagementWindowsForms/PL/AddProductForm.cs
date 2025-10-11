namespace ProductManagementWindowsForms.PL;
public partial class AddProductForm : Form
{
    public AddProductForm ()
    {
        InitializeComponent();
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
            pictureBox1.Image = Image.FromFile(openFileDialog.FileName);
        }
    }
}
