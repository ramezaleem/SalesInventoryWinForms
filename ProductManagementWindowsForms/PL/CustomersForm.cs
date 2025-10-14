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
    public partial class CustomersForm : Form
    {
        BL.CustomersBL CustomersBL = new BL.CustomersBL();

        public CustomersForm()
        {
            InitializeComponent();

            customersList.DataSource = CustomersBL.GetAllCustomers();
            customersList.Columns[0].Visible = false;
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void CustomersForm_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "ملفات الصور | *.JPG; *.PNG; *.GIF;";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureCustomer.Image = Image.FromFile(openFileDialog.FileName);
            }
        }

        private void insertBtn_Click(object sender, EventArgs e)
        {
            try
            {
                MemoryStream memoryStream = new MemoryStream();

                pictureCustomer.Image.Save(memoryStream, pictureCustomer.Image.RawFormat);
                byte[] picture = memoryStream.ToArray();

                CustomersBL.AddCustomer(firstNameText.Text, lastNameTxt.Text, phonetxt.Text, emailTxt.Text, picture);
                MessageBox.Show("تمت الإضافة بنجاح", "الإضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);
                customersList.DataSource = CustomersBL.GetAllCustomers();

            }
            catch
            {
                return;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            firstNameText.Clear();
            lastNameTxt.Clear();
            phonetxt.Clear();
            emailTxt.Clear();
            pictureCustomer.Image = null;
            firstNameText.Focus();
        }

        private void firstNameText_TextChanged(object sender, EventArgs e)
        {
        }

        private void firstNameText_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                lastNameTxt.Focus();
        }

        private void lastNameTxt_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
                phonetxt.Focus();
        }

        private void phonetxt_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
                emailTxt.Focus();
        }

        private void emailTxt_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
                insertBtn.Focus();
        }

        private void customersList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = customersList.Rows[e.RowIndex];

                //     txtId.Text = row.Cells["CustomerId"].Value.ToString();
                firstNameText.Text = row.Cells["الاسم الشخصي"].Value.ToString();
                lastNameTxt.Text = row.Cells["الاسم العائلي"].Value.ToString();
                phonetxt.Text = row.Cells["الهاتف"].Value.ToString();
                emailTxt.Text = row.Cells["البريد الالكتروني"].Value.ToString();

                if (row.Cells["CustomerImage"].Value != DBNull.Value)
                {
                    byte[] imgData = (byte[])row.Cells["CustomerImage"].Value;
                    using (MemoryStream ms = new MemoryStream(imgData))
                    {
                        pictureCustomer.Image = Image.FromStream(ms);
                    }
                }
                else
                {
                    pictureCustomer.Image = null;
                }
            }
        }



    }
}
