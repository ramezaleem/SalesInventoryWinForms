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
        BindingManagerBase binding;
        SqlCommandBuilder SqlCommandBuilder;
        BL.Products products = new BL.Products();

        public Categories()
        {
            InitializeComponent();
            dataAdapter = new SqlDataAdapter("select CategoryId as 'المعرف', Description as 'الصنف' from Categories", sqlConnection);
            dataAdapter.Fill(dt);
            categoriesList.DataSource = dt;

            txtId.DataBindings.Add("text", dt, "المعرف");
            txtDesc.DataBindings.Add("text", dt, "الصنف");
            binding = this.BindingContext[dt];
            positionLabel.Text = (binding.Position + 1) + " / " + binding.Count;
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
            if (binding.Count == 0)
            {
                MessageBox.Show("لا يوجد بيانات للحذف.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("هل تريد حذف هذا السجل؟", "تأكيد الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string id = dt.Rows[binding.Position][0].ToString();

                using (sqlConnection)
                {
                    sqlConnection.Open();
                    SqlCommand cmd = new SqlCommand("DELETE FROM Categories WHERE CategoryId = @Id", sqlConnection);
                    cmd.Parameters.AddWithValue("@Id", id);
                    cmd.ExecuteNonQuery();
                }

                dt.Rows.RemoveAt(binding.Position);

                categoriesList.Refresh(); 

                MessageBox.Show("Deleted Successfully!", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);

                positionLabel.Text = (binding.Position + 1) + " / " + binding.Count;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void firstBtn_Click(object sender, EventArgs e)
        {
            binding.Position = 0;
            positionLabel.Text = (binding.Position + 1) + " / " + binding.Count;
        }

        private void lastBtn_Click(object sender, EventArgs e)
        {
            binding.Position = binding.Count;
            positionLabel.Text = (binding.Position + 1) + " / " + binding.Count;
        }

        private void previousBtn_Click(object sender, EventArgs e)
        {

            binding.Position -= 1;
            positionLabel.Text = (binding.Position + 1) + " / " + binding.Count;
        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            binding.Position += 1;
            positionLabel.Text = (binding.Position + 1) + " / " + binding.Count;
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            binding.AddNew();

            addBtn.Enabled = false;
            insertBtn.Enabled = true;

            txtDesc.ReadOnly = false;

            int id = 1;
            if (dt.Rows.Count > 0)
                id = Convert.ToInt32(dt.Rows[dt.Rows.Count - 1][0]) + 1;

            txtId.Text = id.ToString();
            txtDesc.Focus();

            positionLabel.Text = (binding.Position + 1) + " / " + binding.Count;
        }

        private void insertBtn_Click(object sender, EventArgs e)
        {
            binding.EndCurrentEdit();
            SqlCommandBuilder = new SqlCommandBuilder(dataAdapter);

            dataAdapter.Update(dt);

            MessageBox.Show("Added Successfully!", "Add", MessageBoxButtons.OK, MessageBoxIcon.Information);


            addBtn.Enabled = false;
            insertBtn.Enabled = true;
            txtDesc.ReadOnly = false;

            int id = Convert.ToInt32(dt.Rows[dt.Rows.Count - 1][0]) + 1;
            txtId.Text = id.ToString();

            positionLabel.Text = (binding.Position + 1) + " / " + binding.Count;
        }



    }
}
