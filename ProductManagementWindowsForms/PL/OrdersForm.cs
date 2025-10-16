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
    public partial class OrdersForm : Form
    {
        BL.OrdersBL orders = new BL.OrdersBL();

        public OrdersForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void OrdersForm_Load(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.orderNoTxtBox.Text = orders.GetLastOrderId().Rows[0][0].ToString();
            this.addNewSaleBtn.Enabled = false;
            this.saveNewSaleBtn.Enabled = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CustomrsListForm form = new CustomrsListForm();
            form.ShowDialog();

            this.customerIdTxtBox.Text = form.customersListDGVForm.CurrentRow.Cells[0].Value.ToString();
            this.firstNameTxtBox.Text = form.customersListDGVForm.CurrentRow.Cells[1].Value.ToString();
            this.lastNameTxtBox.Text = form.customersListDGVForm.CurrentRow.Cells[2].Value.ToString();
            this.telTxtBox.Text = form.customersListDGVForm.CurrentRow.Cells[3].Value.ToString();
            this.emailTxtBox.Text = form.customersListDGVForm.CurrentRow.Cells[4].Value.ToString();

            object imageCellValue = form.customersListDGVForm.CurrentRow.Cells[5].Value;

            if (imageCellValue != DBNull.Value && imageCellValue is byte[] customerImageBytes && customerImageBytes.Length > 0)
            {
                using (MemoryStream memoryStream = new MemoryStream(customerImageBytes))
                {
                    cutomerPicture.Image = Image.FromStream(memoryStream);
                }
            }
            else
            {
                cutomerPicture.Image = new Bitmap(1, 1); // صورة شفافة بديلة في حالة عدم وجود صورة
            }
        }



    }
}
