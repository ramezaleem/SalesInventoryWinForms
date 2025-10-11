using ProductManagementWindowsForms.BL;
using System.Data;

namespace ProductManagementWindowsForms.PL;
public partial class LoginForm : Form
{
    Login _login = new Login();
    public LoginForm ()
    {
        InitializeComponent();
    }

    private void LoginForm_Load ( object sender, EventArgs e )
    {

    }

    private void loginBtn_Click ( object sender, EventArgs e )
    {
        DataTable dataTable = _login.LoginUsers(txtId.Text, txtPassword.Text);

        if (dataTable.Rows.Count > 0)
        {
            MainForm.GetMainForm.المستخدمون.Enabled = true;
            MainForm.GetMainForm.العملاءToolStripMenuItem.Enabled = true;
            MainForm.GetMainForm.المنتوجاتToolStripMenuItem.Enabled = true;
            MainForm.GetMainForm.إنشاءنسخةاحتياطيةToolStripMenuItem.Enabled = true;
            MainForm.GetMainForm.استعادةنسخةمحفوظةToolStripMenuItem.Enabled = true;

            this.Close();
        }

        else
            MessageBox.Show("فشل تسجل الدخول :(", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);

    }

    private void cancelBtn_Click ( object sender, EventArgs e )
    {
        this.Close();
    }
}
