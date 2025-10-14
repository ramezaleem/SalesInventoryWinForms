namespace ProductManagementWindowsForms.PL
{
    partial class CustomersForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomersForm));
            groupBox2 = new GroupBox();
            pictureCustomer = new PictureBox();
            firstCustomer = new Button();
            previousCutomer = new Button();
            nextCustomer = new Button();
            lastCustomer = new Button();
            totalCustomersLabel = new Label();
            lastNameTxt = new TextBox();
            emailTxt = new TextBox();
            phonetxt = new TextBox();
            firstNameText = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox1 = new GroupBox();
            customersList = new DataGridView();
            searchtxt = new TextBox();
            label5 = new Label();
            groupBox3 = new GroupBox();
            insertBtn = new Button();
            cancelBtn = new Button();
            deleteBtn = new Button();
            editBtn = new Button();
            addBtn = new Button();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureCustomer).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)customersList).BeginInit();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(pictureCustomer);
            groupBox2.Controls.Add(firstCustomer);
            groupBox2.Controls.Add(previousCutomer);
            groupBox2.Controls.Add(nextCustomer);
            groupBox2.Controls.Add(lastCustomer);
            groupBox2.Controls.Add(totalCustomersLabel);
            groupBox2.Controls.Add(lastNameTxt);
            groupBox2.Controls.Add(emailTxt);
            groupBox2.Controls.Add(phonetxt);
            groupBox2.Controls.Add(firstNameText);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label1);
            groupBox2.Location = new Point(26, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(557, 312);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "بيانات العميل :";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // pictureCustomer
            // 
            pictureCustomer.BackgroundImageLayout = ImageLayout.None;
            pictureCustomer.Cursor = Cursors.Hand;
            pictureCustomer.Image = (Image)resources.GetObject("pictureCustomer.Image");
            pictureCustomer.Location = new Point(6, 32);
            pictureCustomer.Name = "pictureCustomer";
            pictureCustomer.Size = new Size(193, 189);
            pictureCustomer.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureCustomer.TabIndex = 18;
            pictureCustomer.TabStop = false;
            pictureCustomer.Click += pictureBox1_Click;
            // 
            // firstCustomer
            // 
            firstCustomer.Location = new Point(211, 230);
            firstCustomer.Name = "firstCustomer";
            firstCustomer.Size = new Size(49, 32);
            firstCustomer.TabIndex = 17;
            firstCustomer.Text = ">>||";
            firstCustomer.UseVisualStyleBackColor = true;
            firstCustomer.Click += firstCustomer_Click;
            // 
            // previousCutomer
            // 
            previousCutomer.Location = new Point(269, 230);
            previousCutomer.Name = "previousCutomer";
            previousCutomer.Size = new Size(49, 32);
            previousCutomer.TabIndex = 16;
            previousCutomer.Text = ">>";
            previousCutomer.UseVisualStyleBackColor = true;
            previousCutomer.Click += previousCutomer_Click;
            // 
            // nextCustomer
            // 
            nextCustomer.Location = new Point(444, 230);
            nextCustomer.Name = "nextCustomer";
            nextCustomer.Size = new Size(49, 32);
            nextCustomer.TabIndex = 15;
            nextCustomer.Text = "<<";
            nextCustomer.UseVisualStyleBackColor = true;
            nextCustomer.Click += button3_Click;
            // 
            // lastCustomer
            // 
            lastCustomer.Location = new Point(503, 230);
            lastCustomer.Name = "lastCustomer";
            lastCustomer.Size = new Size(49, 32);
            lastCustomer.TabIndex = 14;
            lastCustomer.Text = "||<<";
            lastCustomer.UseVisualStyleBackColor = true;
            lastCustomer.Click += button2_Click;
            // 
            // totalCustomersLabel
            // 
            totalCustomersLabel.AutoSize = true;
            totalCustomersLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            totalCustomersLabel.Location = new Point(361, 237);
            totalCustomersLabel.Name = "totalCustomersLabel";
            totalCustomersLabel.Size = new Size(41, 17);
            totalCustomersLabel.TabIndex = 13;
            totalCustomersLabel.Text = "Label";
            totalCustomersLabel.Click += label6_Click;
            // 
            // lastNameTxt
            // 
            lastNameTxt.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lastNameTxt.Location = new Point(205, 67);
            lastNameTxt.Name = "lastNameTxt";
            lastNameTxt.Size = new Size(213, 25);
            lastNameTxt.TabIndex = 7;
            lastNameTxt.TextChanged += textBox4_TextChanged;
            lastNameTxt.KeyDown += lastNameTxt_KeyDown;
            // 
            // emailTxt
            // 
            emailTxt.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            emailTxt.Location = new Point(205, 135);
            emailTxt.Name = "emailTxt";
            emailTxt.Size = new Size(213, 25);
            emailTxt.TabIndex = 6;
            emailTxt.TextChanged += textBox3_TextChanged;
            emailTxt.KeyDown += emailTxt_KeyDown;
            // 
            // phonetxt
            // 
            phonetxt.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            phonetxt.Location = new Point(205, 101);
            phonetxt.Name = "phonetxt";
            phonetxt.Size = new Size(213, 25);
            phonetxt.TabIndex = 5;
            phonetxt.KeyDown += phonetxt_KeyDown;
            // 
            // firstNameText
            // 
            firstNameText.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            firstNameText.Location = new Point(205, 33);
            firstNameText.Name = "firstNameText";
            firstNameText.Size = new Size(213, 25);
            firstNameText.TabIndex = 4;
            firstNameText.TextChanged += firstNameText_TextChanged;
            firstNameText.KeyDown += firstNameText_KeyDown;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(457, 71);
            label4.Name = "label4";
            label4.Size = new Size(86, 17);
            label4.TabIndex = 3;
            label4.Text = "الاسم العائلي :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(470, 105);
            label3.Name = "label3";
            label3.Size = new Size(73, 17);
            label3.TabIndex = 2;
            label3.Text = "رقم الهاتف :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(444, 139);
            label2.Name = "label2";
            label2.Size = new Size(99, 17);
            label2.TabIndex = 1;
            label2.Text = "البريد الالكتروني :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(447, 37);
            label1.Name = "label1";
            label1.Size = new Size(96, 17);
            label1.TabIndex = 0;
            label1.Text = "الاسم الشخصي :";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(customersList);
            groupBox1.Controls.Add(searchtxt);
            groupBox1.Controls.Add(label5);
            groupBox1.Location = new Point(589, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(441, 322);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "لائحة جميع العملاء :";
            // 
            // customersList
            // 
            customersList.AllowUserToAddRows = false;
            customersList.AllowUserToDeleteRows = false;
            customersList.AllowUserToResizeRows = false;
            customersList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            customersList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            customersList.Location = new Point(6, 67);
            customersList.MultiSelect = false;
            customersList.Name = "customersList";
            customersList.ReadOnly = true;
            customersList.RowHeadersVisible = false;
            customersList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            customersList.Size = new Size(404, 245);
            customersList.TabIndex = 12;
            customersList.CellClick += customersList_CellClick;
            // 
            // searchtxt
            // 
            searchtxt.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            searchtxt.Location = new Point(6, 33);
            searchtxt.Name = "searchtxt";
            searchtxt.Size = new Size(348, 25);
            searchtxt.TabIndex = 10;
            searchtxt.TextChanged += searchtxt_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(360, 37);
            label5.Name = "label5";
            label5.Size = new Size(63, 17);
            label5.TabIndex = 9;
            label5.Text = "ابحث هنا :";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(insertBtn);
            groupBox3.Controls.Add(cancelBtn);
            groupBox3.Controls.Add(deleteBtn);
            groupBox3.Controls.Add(editBtn);
            groupBox3.Controls.Add(addBtn);
            groupBox3.Location = new Point(26, 330);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(551, 90);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "العمليات المتاحة :";
            // 
            // insertBtn
            // 
            insertBtn.BackColor = Color.FromArgb(255, 224, 192);
            insertBtn.Location = new Point(368, 42);
            insertBtn.Name = "insertBtn";
            insertBtn.Size = new Size(75, 31);
            insertBtn.TabIndex = 4;
            insertBtn.Text = "إضافة";
            insertBtn.UseVisualStyleBackColor = false;
            insertBtn.Click += insertBtn_Click;
            // 
            // cancelBtn
            // 
            cancelBtn.BackColor = Color.Red;
            cancelBtn.ForeColor = Color.White;
            cancelBtn.Location = new Point(53, 42);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(75, 31);
            cancelBtn.TabIndex = 3;
            cancelBtn.Text = "خروج";
            cancelBtn.UseVisualStyleBackColor = false;
            cancelBtn.Click += cancelBtn_Click;
            // 
            // deleteBtn
            // 
            deleteBtn.BackColor = Color.FromArgb(255, 192, 192);
            deleteBtn.Location = new Point(263, 42);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(75, 31);
            deleteBtn.TabIndex = 2;
            deleteBtn.Text = "حذف";
            deleteBtn.UseVisualStyleBackColor = false;
            deleteBtn.Click += deleteBtn_Click;
            // 
            // editBtn
            // 
            editBtn.BackColor = Color.FromArgb(255, 255, 192);
            editBtn.Location = new Point(158, 41);
            editBtn.Name = "editBtn";
            editBtn.Size = new Size(75, 31);
            editBtn.TabIndex = 1;
            editBtn.Text = "تعديل";
            editBtn.UseVisualStyleBackColor = false;
            editBtn.Click += button7_Click;
            // 
            // addBtn
            // 
            addBtn.BackColor = Color.FromArgb(192, 255, 192);
            addBtn.Cursor = Cursors.Hand;
            addBtn.Location = new Point(473, 41);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(75, 31);
            addBtn.TabIndex = 0;
            addBtn.Text = "جديد";
            addBtn.UseVisualStyleBackColor = false;
            addBtn.Click += button6_Click;
            // 
            // CustomersForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1042, 427);
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            Cursor = Cursors.Hand;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "CustomersForm";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "شاشة إدارة العملاء :";
            Load += CustomersForm_Load;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureCustomer).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)customersList).EndInit();
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox2;
        private TextBox lastNameTxt;
        private TextBox emailTxt;
        private TextBox phonetxt;
        private TextBox firstNameText;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox groupBox1;
        private Label label5;
        private TextBox searchtxt;
        private Label totalCustomersLabel;
        private DataGridView customersList;
        private Button lastCustomer;
        private Button nextCustomer;
        private Button firstCustomer;
        private Button previousCutomer;
        private GroupBox groupBox3;
        private Button insertBtn;
        private Button cancelBtn;
        private Button deleteBtn;
        private Button editBtn;
        private Button addBtn;
        private PictureBox pictureCustomer;
    }
}