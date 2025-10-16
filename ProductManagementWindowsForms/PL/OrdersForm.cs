using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductManagementWindowsForms.PL
{
    public partial class OrdersForm : Form
    {
        BL.OrdersBL orders = new BL.OrdersBL();
        DataTable dataTable = new DataTable();

        void CreateTable()
        {
            dataTable.Columns.Add("معرف المنتوج");
            dataTable.Columns.Add("اسم المنتوج");
            dataTable.Columns.Add("القمن");
            dataTable.Columns.Add("الكمية");
            dataTable.Columns.Add("المبلع");
            dataTable.Columns.Add("نسبة الخصم (%)");
            dataTable.Columns.Add("المبلغ الإجمالي");

            ordersListDataGridView.DataSource = dataTable;

            //ResizeDGV(); // استدعاء resize بعد ما الأعمدة اتكونت
        }

        //void ResizeDGV()
        //{
        //    if (ordersListDataGridView.Columns == null || ordersListDataGridView.Columns.Count == 0)
        //        return;

        //    ordersListDataGridView.RowHeadersWidth = 91;

        //    void SetWidth(int index, int width)
        //    {
        //        if (index >= 0 &&
        //            ordersListDataGridView.Columns.Count > index &&
        //            ordersListDataGridView.Columns[index] != null)
        //        {
        //            ordersListDataGridView.Columns[index].Width = width;
        //        }
        //    }

        //    SetWidth(0, 91);
        //    SetWidth(1, 293);
        //    SetWidth(2, 91);
        //    SetWidth(3, 91);
        //    SetWidth(4, 91);
        //    SetWidth(5, 91);
        //    SetWidth(6, 144);
        //}

        void CalculateAmount()
        {
            int price = int.TryParse(priceTxtBox.Text, out int p) ? p : 0;
            int quantity = int.TryParse(quanitiyTxtBox.Text, out int q) ? q : 0;

            int amount = price * quantity;
            amountTxtBox.Text = amount.ToString();
        }


        public OrdersForm()
        {
            InitializeComponent();
            CreateTable();
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
                MessageBox.Show("هذا العميل ليس لديه صورة", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cutomerPicture.Image = new Bitmap(1, 1); // صورة شفافة بديلة في حالة عدم وجود صورة
            }
        }

        private void ordersListDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ordersListDataGridView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void browseProductsBtn_Click(object sender, EventArgs e)
        {
            ProductsList form = new ProductsList();
            form.ShowDialog();
            quanitiyTxtBox.Focus();
        }

        private void quanitiyTxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void priceTxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char decimalSeparator = Convert.ToChar(CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator);

            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != decimalSeparator)
            {
                e.Handled = true;
            }
        }

        private void priceTxtBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && priceTxtBox.Text != string.Empty)
            {
                priceTxtBox.Focus();
            }
        }

        private void quanitiyTxtBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && quanitiyTxtBox.Text != string.Empty)
            {
                quanitiyTxtBox.Focus();
            }
        }

        private void priceTxtBox_KeyUp(object sender, KeyEventArgs e)
        {
            CalculateAmount();
        }

        private void quanitiyTxtBox_KeyUp(object sender, KeyEventArgs e)
        {
            CalculateAmount();

        }



    }
}
