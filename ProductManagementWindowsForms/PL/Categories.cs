using ProductManagementWindowsForms.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductManagementWindowsForms.PL
{
    public partial class Categories : Form
    {
        SqlConnection sqlConnection = new SqlConnection("Data Source=.;Initial Catalog=Product_DBWinForms;Integrated Security=True;TrustServerCertificate=True;");
        SqlDataAdapter dataAdapter = new SqlDataAdapter();
        DataTable dt = new DataTable();
        public Categories()
        {
            InitializeComponent();
            dataAdapter = new SqlDataAdapter("select CategoryId as 'المعرف', Description as 'الصنف' from Categories", sqlConnection);
            dataAdapter.Fill(dt);
            categoriesList.DataSource = dt;

            txtId.DataBindings.Add("text", dt,"المعرف");
            txtDesc.DataBindings.Add("text", dt, "الصنف");
        }

        private void Categories_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void button7_Click_1(object sender, EventArgs e)
        {

        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
