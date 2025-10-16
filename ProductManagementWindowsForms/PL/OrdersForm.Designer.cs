namespace ProductManagementWindowsForms.PL
{
    partial class OrdersForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrdersForm));
            groupBox1 = new GroupBox();
            dateOfOrder = new DateTimePicker();
            salesmanName = new TextBox();
            OrderDescTxtBox = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            orderNoTxtBox = new TextBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            cutomerPicture = new PictureBox();
            emailTxtBox = new TextBox();
            telTxtBox = new TextBox();
            lastNameTxtBox = new TextBox();
            firstNameTxtBox = new TextBox();
            button1 = new Button();
            customerIdTxtBox = new TextBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label2 = new Label();
            groupBox3 = new GroupBox();
            ordersListDataGridView = new DataGridView();
            deleteSelectionRowBtn = new Button();
            label10 = new Label();
            SumTxtBox = new TextBox();
            addNewSaleBtn = new Button();
            button5 = new Button();
            printSaleBtn = new Button();
            saveNewSaleBtn = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)cutomerPicture).BeginInit();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ordersListDataGridView).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dateOfOrder);
            groupBox1.Controls.Add(salesmanName);
            groupBox1.Controls.Add(OrderDescTxtBox);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(orderNoTxtBox);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(20, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(477, 226);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "بيانات الفاتورة :";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // dateOfOrder
            // 
            dateOfOrder.Location = new Point(67, 150);
            dateOfOrder.Name = "dateOfOrder";
            dateOfOrder.Size = new Size(292, 23);
            dateOfOrder.TabIndex = 1;
            dateOfOrder.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // salesmanName
            // 
            salesmanName.BorderStyle = BorderStyle.FixedSingle;
            salesmanName.Location = new Point(67, 183);
            salesmanName.Name = "salesmanName";
            salesmanName.ReadOnly = true;
            salesmanName.Size = new Size(292, 23);
            salesmanName.TabIndex = 8;
            // 
            // OrderDescTxtBox
            // 
            OrderDescTxtBox.Location = new Point(67, 64);
            OrderDescTxtBox.Multiline = true;
            OrderDescTxtBox.Name = "OrderDescTxtBox";
            OrderDescTxtBox.ScrollBars = ScrollBars.Vertical;
            OrderDescTxtBox.Size = new Size(292, 72);
            OrderDescTxtBox.TabIndex = 0;
            OrderDescTxtBox.TextChanged += textBox2_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(372, 67);
            label5.Name = "label5";
            label5.Size = new Size(92, 17);
            label5.TabIndex = 5;
            label5.Text = "وصف الفاتورة :";
            label5.Click += label5_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(396, 153);
            label4.Name = "label4";
            label4.Size = new Size(68, 17);
            label4.TabIndex = 4;
            label4.Text = "تاريخ البيع :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(396, 186);
            label3.Name = "label3";
            label3.Size = new Size(68, 17);
            label3.TabIndex = 3;
            label3.Text = "اسم البائع :";
            label3.Click += label3_Click;
            // 
            // orderNoTxtBox
            // 
            orderNoTxtBox.BorderStyle = BorderStyle.FixedSingle;
            orderNoTxtBox.Location = new Point(175, 36);
            orderNoTxtBox.Name = "orderNoTxtBox";
            orderNoTxtBox.ReadOnly = true;
            orderNoTxtBox.Size = new Size(184, 23);
            orderNoTxtBox.TabIndex = 1;
            orderNoTxtBox.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(386, 39);
            label1.Name = "label1";
            label1.Size = new Size(78, 17);
            label1.TabIndex = 1;
            label1.Text = "رقم الفاتورة :";
            label1.Click += label1_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(cutomerPicture);
            groupBox2.Controls.Add(emailTxtBox);
            groupBox2.Controls.Add(telTxtBox);
            groupBox2.Controls.Add(lastNameTxtBox);
            groupBox2.Controls.Add(firstNameTxtBox);
            groupBox2.Controls.Add(button1);
            groupBox2.Controls.Add(customerIdTxtBox);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label2);
            groupBox2.Location = new Point(514, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(510, 226);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "بيانات العميل :";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // cutomerPicture
            // 
            cutomerPicture.BackgroundImage = (Image)resources.GetObject("cutomerPicture.BackgroundImage");
            cutomerPicture.Image = (Image)resources.GetObject("cutomerPicture.Image");
            cutomerPicture.Location = new Point(0, 39);
            cutomerPicture.Name = "cutomerPicture";
            cutomerPicture.Size = new Size(166, 170);
            cutomerPicture.SizeMode = PictureBoxSizeMode.StretchImage;
            cutomerPicture.TabIndex = 19;
            cutomerPicture.TabStop = false;
            // 
            // emailTxtBox
            // 
            emailTxtBox.BorderStyle = BorderStyle.FixedSingle;
            emailTxtBox.Location = new Point(185, 186);
            emailTxtBox.Name = "emailTxtBox";
            emailTxtBox.ReadOnly = true;
            emailTxtBox.Size = new Size(208, 23);
            emailTxtBox.TabIndex = 18;
            // 
            // telTxtBox
            // 
            telTxtBox.BorderStyle = BorderStyle.FixedSingle;
            telTxtBox.Location = new Point(185, 147);
            telTxtBox.Name = "telTxtBox";
            telTxtBox.ReadOnly = true;
            telTxtBox.Size = new Size(208, 23);
            telTxtBox.TabIndex = 17;
            // 
            // lastNameTxtBox
            // 
            lastNameTxtBox.BorderStyle = BorderStyle.FixedSingle;
            lastNameTxtBox.Location = new Point(185, 110);
            lastNameTxtBox.Name = "lastNameTxtBox";
            lastNameTxtBox.ReadOnly = true;
            lastNameTxtBox.Size = new Size(208, 23);
            lastNameTxtBox.TabIndex = 16;
            // 
            // firstNameTxtBox
            // 
            firstNameTxtBox.BorderStyle = BorderStyle.FixedSingle;
            firstNameTxtBox.Location = new Point(185, 74);
            firstNameTxtBox.Name = "firstNameTxtBox";
            firstNameTxtBox.ReadOnly = true;
            firstNameTxtBox.Size = new Size(208, 23);
            firstNameTxtBox.TabIndex = 10;
            // 
            // button1
            // 
            button1.BackColor = Color.Black;
            button1.ForeColor = Color.White;
            button1.Location = new Point(185, 39);
            button1.Name = "button1";
            button1.Size = new Size(57, 23);
            button1.TabIndex = 0;
            button1.Text = "...";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // customerIdTxtBox
            // 
            customerIdTxtBox.BorderStyle = BorderStyle.FixedSingle;
            customerIdTxtBox.Location = new Point(248, 39);
            customerIdTxtBox.Name = "customerIdTxtBox";
            customerIdTxtBox.ReadOnly = true;
            customerIdTxtBox.Size = new Size(145, 23);
            customerIdTxtBox.TabIndex = 10;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(416, 77);
            label9.Name = "label9";
            label9.Size = new Size(96, 17);
            label9.TabIndex = 14;
            label9.Text = "الاسم الشخصي :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(426, 113);
            label8.Name = "label8";
            label8.Size = new Size(86, 17);
            label8.TabIndex = 13;
            label8.Text = "الاسم العائلي :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(439, 150);
            label7.Name = "label7";
            label7.Size = new Size(73, 17);
            label7.TabIndex = 12;
            label7.Text = "رقم الهاتف :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(417, 189);
            label6.Name = "label6";
            label6.Size = new Size(95, 17);
            label6.TabIndex = 11;
            label6.Text = "البريد الاكتروني :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(423, 42);
            label2.Name = "label2";
            label2.Size = new Size(89, 17);
            label2.TabIndex = 10;
            label2.Text = "معرف العميل :";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(ordersListDataGridView);
            groupBox3.Location = new Point(20, 244);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(1004, 212);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "المنتجات :";
            // 
            // ordersListDataGridView
            // 
            ordersListDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ordersListDataGridView.Location = new Point(0, 22);
            ordersListDataGridView.Name = "ordersListDataGridView";
            ordersListDataGridView.ReadOnly = true;
            ordersListDataGridView.Size = new Size(1004, 184);
            ordersListDataGridView.TabIndex = 0;
            // 
            // deleteSelectionRowBtn
            // 
            deleteSelectionRowBtn.BackColor = Color.FromArgb(255, 192, 192);
            deleteSelectionRowBtn.Enabled = false;
            deleteSelectionRowBtn.Location = new Point(20, 473);
            deleteSelectionRowBtn.Name = "deleteSelectionRowBtn";
            deleteSelectionRowBtn.Size = new Size(132, 23);
            deleteSelectionRowBtn.TabIndex = 3;
            deleteSelectionRowBtn.Text = "حذف السطر المحدد ";
            deleteSelectionRowBtn.UseVisualStyleBackColor = false;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(735, 476);
            label10.Name = "label10";
            label10.Size = new Size(62, 17);
            label10.TabIndex = 20;
            label10.Text = "المجموع :";
            label10.Click += label10_Click;
            // 
            // SumTxtBox
            // 
            SumTxtBox.BackColor = Color.FromArgb(192, 255, 255);
            SumTxtBox.BorderStyle = BorderStyle.FixedSingle;
            SumTxtBox.Location = new Point(816, 473);
            SumTxtBox.Name = "SumTxtBox";
            SumTxtBox.ReadOnly = true;
            SumTxtBox.Size = new Size(208, 23);
            SumTxtBox.TabIndex = 20;
            SumTxtBox.TextChanged += textBox9_TextChanged;
            // 
            // addNewSaleBtn
            // 
            addNewSaleBtn.BackColor = Color.FromArgb(192, 255, 192);
            addNewSaleBtn.Location = new Point(267, 566);
            addNewSaleBtn.Name = "addNewSaleBtn";
            addNewSaleBtn.Size = new Size(98, 33);
            addNewSaleBtn.TabIndex = 21;
            addNewSaleBtn.Text = "مبيعة جديدة";
            addNewSaleBtn.UseVisualStyleBackColor = false;
            addNewSaleBtn.Click += button3_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.Red;
            button5.ForeColor = Color.White;
            button5.Location = new Point(663, 566);
            button5.Name = "button5";
            button5.Size = new Size(98, 33);
            button5.TabIndex = 23;
            button5.Text = "خروج";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // printSaleBtn
            // 
            printSaleBtn.BackColor = Color.FromArgb(192, 192, 255);
            printSaleBtn.Enabled = false;
            printSaleBtn.Location = new Point(531, 566);
            printSaleBtn.Name = "printSaleBtn";
            printSaleBtn.Size = new Size(98, 33);
            printSaleBtn.TabIndex = 24;
            printSaleBtn.Text = "طباعة الفاتورة";
            printSaleBtn.UseVisualStyleBackColor = false;
            // 
            // saveNewSaleBtn
            // 
            saveNewSaleBtn.BackColor = Color.FromArgb(255, 255, 192);
            saveNewSaleBtn.Enabled = false;
            saveNewSaleBtn.Location = new Point(399, 566);
            saveNewSaleBtn.Name = "saveNewSaleBtn";
            saveNewSaleBtn.Size = new Size(98, 33);
            saveNewSaleBtn.TabIndex = 25;
            saveNewSaleBtn.Text = "حفظ المبيعة";
            saveNewSaleBtn.UseVisualStyleBackColor = false;
            // 
            // OrdersForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1044, 627);
            Controls.Add(saveNewSaleBtn);
            Controls.Add(printSaleBtn);
            Controls.Add(button5);
            Controls.Add(addNewSaleBtn);
            Controls.Add(SumTxtBox);
            Controls.Add(label10);
            Controls.Add(deleteSelectionRowBtn);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "OrdersForm";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "الشاشة الرئيسية لعملية البيع :";
            Load += OrdersForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)cutomerPicture).EndInit();
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ordersListDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private TextBox orderNoTxtBox;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox OrderDescTxtBox;
        private DateTimePicker dateOfOrder;
        private TextBox salesmanName;
        private GroupBox groupBox2;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label2;
        private PictureBox cutomerPicture;
        private TextBox emailTxtBox;
        private TextBox telTxtBox;
        private TextBox lastNameTxtBox;
        private TextBox firstNameTxtBox;
        private Button button1;
        private TextBox customerIdTxtBox;
        private GroupBox groupBox3;
        private DataGridView ordersListDataGridView;
        private Button deleteSelectionRowBtn;
        private Label label10;
        private TextBox SumTxtBox;
        private Button addNewSaleBtn;
        private Button button5;
        private Button printSaleBtn;
        private Button saveNewSaleBtn;
    }
}