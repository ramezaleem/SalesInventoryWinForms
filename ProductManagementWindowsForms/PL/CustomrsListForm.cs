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
    public partial class CustomrsListForm : Form
    {
        BL.CustomersBL customersBL = new BL.CustomersBL();

        public CustomrsListForm()
        {
            InitializeComponent();

            this.customersListDGVForm.DataSource = customersBL.GetAllCustomers();
            this.customersListDGVForm.Columns[0].Visible = false;
            this.customersListDGVForm.Columns[5].Visible = true;
        }

        private void customersListDGVForm_DoubleClick(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
