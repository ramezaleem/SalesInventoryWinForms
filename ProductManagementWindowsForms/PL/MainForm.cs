namespace ProductManagementWindowsForms.PL;
public partial class MainForm : Form
{
    private static MainForm _mainForm;

    static void MainFormClosed(object sender, FormClosedEventArgs e)
    {
        _mainForm = null;
    }

    public static MainForm GetMainForm
    {
        get
        {
            if (_mainForm == null)
            {
                _mainForm = new MainForm();
                _mainForm.FormClosed += new FormClosedEventHandler(MainFormClosed);
            }
            return _mainForm;
        }
    }

    public MainForm()
    {
        InitializeComponent();

        if (_mainForm == null)
            _mainForm = this;

        this.المستخدمون.Enabled = false;
        this.العملاءToolStripMenuItem.Enabled = false;
        this.المنتوجاتToolStripMenuItem.Enabled = false;
        this.إنشاءنسخةاحتياطيةToolStripMenuItem.Enabled = false;
        this.استعادةنسخةمحفوظةToolStripMenuItem.Enabled = false;

    }

    private void إدارةالمنتوجاتToolStripMenuItem_Click(object sender, EventArgs e)
    {
        ProductsForm productsForm = new ProductsForm();
        productsForm.ShowDialog();
    }

    private void إدارةالعملاءToolStripMenuItem_Click(object sender, EventArgs e)
    {

    }

    private void MainForm_Load(object sender, EventArgs e)
    {

    }

    private void تسجيلالدخولToolStripMenuItem_Click(object sender, EventArgs e)
    {
        LoginForm loginForm = new LoginForm();
        loginForm.ShowDialog();
    }

    private void إضافةمنتججديدToolStripMenuItem_Click(object sender, EventArgs e)
    {
        AddProductForm addProductForm = new AddProductForm();
        addProductForm.ShowDialog();
    }

    private void إدارةالأصنافToolStripMenuItem_Click(object sender, EventArgs e)
    {
        Categories categories = new Categories();
        categories.ShowDialog();
    }
}
