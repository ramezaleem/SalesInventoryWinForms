namespace ProductManagementWindowsForms.PL
{
    partial class Categories
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            groupBox1 = new GroupBox();
            label3 = new Label();
            lastBtn = new Button();
            nextBtn = new Button();
            previousBtn = new Button();
            firstBtn = new Button();
            txtDesc = new TextBox();
            txtId = new TextBox();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            exitBtn = new Button();
            exportCurrentPDFBtn = new Button();
            exportAllPDFBtn = new Button();
            printCurrentBtn = new Button();
            printAllBtn = new Button();
            deleteBtn = new Button();
            updateBtn = new Button();
            insertBtn = new Button();
            addBtn = new Button();
            categoriesList = new DataGridView();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)categoriesList).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(lastBtn);
            groupBox1.Controls.Add(nextBtn);
            groupBox1.Controls.Add(previousBtn);
            groupBox1.Controls.Add(firstBtn);
            groupBox1.Controls.Add(txtDesc);
            groupBox1.Controls.Add(txtId);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 29);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(541, 239);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "بيانات الصنف :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(246, 200);
            label3.Name = "label3";
            label3.Size = new Size(41, 17);
            label3.TabIndex = 8;
            label3.Text = "Label";
            // 
            // lastBtn
            // 
            lastBtn.Location = new Point(31, 198);
            lastBtn.Name = "lastBtn";
            lastBtn.Size = new Size(75, 23);
            lastBtn.TabIndex = 7;
            lastBtn.Text = ">>||";
            lastBtn.UseVisualStyleBackColor = true;
            // 
            // nextBtn
            // 
            nextBtn.Location = new Point(123, 198);
            nextBtn.Name = "nextBtn";
            nextBtn.Size = new Size(75, 23);
            nextBtn.TabIndex = 6;
            nextBtn.Text = ">>";
            nextBtn.UseVisualStyleBackColor = true;
            // 
            // previousBtn
            // 
            previousBtn.Location = new Point(341, 198);
            previousBtn.Name = "previousBtn";
            previousBtn.Size = new Size(75, 23);
            previousBtn.TabIndex = 5;
            previousBtn.Text = "<<";
            previousBtn.UseVisualStyleBackColor = true;
            // 
            // firstBtn
            // 
            firstBtn.Location = new Point(432, 198);
            firstBtn.Name = "firstBtn";
            firstBtn.Size = new Size(75, 23);
            firstBtn.TabIndex = 4;
            firstBtn.Text = "||<<";
            firstBtn.UseVisualStyleBackColor = true;
            // 
            // txtDesc
            // 
            txtDesc.Location = new Point(25, 74);
            txtDesc.Multiline = true;
            txtDesc.Name = "txtDesc";
            txtDesc.ReadOnly = true;
            txtDesc.ScrollBars = ScrollBars.Vertical;
            txtDesc.Size = new Size(377, 82);
            txtDesc.TabIndex = 3;
            // 
            // txtId
            // 
            txtId.Location = new Point(246, 32);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(156, 23);
            txtId.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(438, 78);
            label2.Name = "label2";
            label2.Size = new Size(81, 15);
            label2.TabIndex = 1;
            label2.Text = "وصف الصنف :";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(438, 36);
            label1.Name = "label1";
            label1.Size = new Size(81, 15);
            label1.TabIndex = 0;
            label1.Text = "معرف الصنف :";
            label1.Click += label1_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(exitBtn);
            groupBox2.Controls.Add(exportCurrentPDFBtn);
            groupBox2.Controls.Add(exportAllPDFBtn);
            groupBox2.Controls.Add(printCurrentBtn);
            groupBox2.Controls.Add(printAllBtn);
            groupBox2.Controls.Add(deleteBtn);
            groupBox2.Controls.Add(updateBtn);
            groupBox2.Controls.Add(insertBtn);
            groupBox2.Controls.Add(addBtn);
            groupBox2.Location = new Point(12, 294);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(971, 133);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "العمليات المتاحة :";
            // 
            // exitBtn
            // 
            exitBtn.BackColor = Color.Red;
            exitBtn.ForeColor = Color.White;
            exitBtn.Location = new Point(223, 73);
            exitBtn.Name = "exitBtn";
            exitBtn.Size = new Size(181, 36);
            exitBtn.TabIndex = 17;
            exitBtn.Text = "خروج";
            exitBtn.UseVisualStyleBackColor = false;
            // 
            // exportCurrentPDFBtn
            // 
            exportCurrentPDFBtn.BackColor = Color.FromArgb(255, 224, 192);
            exportCurrentPDFBtn.Location = new Point(784, 73);
            exportCurrentPDFBtn.Name = "exportCurrentPDFBtn";
            exportCurrentPDFBtn.Size = new Size(181, 36);
            exportCurrentPDFBtn.TabIndex = 16;
            exportCurrentPDFBtn.Text = "حفظ الملف الحالي في ملف PDF";
            exportCurrentPDFBtn.UseVisualStyleBackColor = false;
            // 
            // exportAllPDFBtn
            // 
            exportAllPDFBtn.BackColor = Color.FromArgb(255, 224, 192);
            exportAllPDFBtn.Location = new Point(410, 73);
            exportAllPDFBtn.Name = "exportAllPDFBtn";
            exportAllPDFBtn.Size = new Size(181, 36);
            exportAllPDFBtn.TabIndex = 15;
            exportAllPDFBtn.Text = "حفظ كل الأصناف في ملف PDF";
            exportAllPDFBtn.UseVisualStyleBackColor = false;
            exportAllPDFBtn.Click += button7_Click_1;
            // 
            // printCurrentBtn
            // 
            printCurrentBtn.BackColor = Color.FromArgb(192, 192, 255);
            printCurrentBtn.Location = new Point(597, 73);
            printCurrentBtn.Name = "printCurrentBtn";
            printCurrentBtn.Size = new Size(181, 36);
            printCurrentBtn.TabIndex = 14;
            printCurrentBtn.Text = "طباعة الصنف الحالي";
            printCurrentBtn.UseVisualStyleBackColor = false;
            // 
            // printAllBtn
            // 
            printAllBtn.BackColor = Color.FromArgb(192, 192, 255);
            printAllBtn.Location = new Point(36, 22);
            printAllBtn.Name = "printAllBtn";
            printAllBtn.Size = new Size(181, 36);
            printAllBtn.TabIndex = 13;
            printAllBtn.Text = "طباعة كل الأصناف";
            printAllBtn.UseVisualStyleBackColor = false;
            printAllBtn.Click += button5_Click;
            // 
            // deleteBtn
            // 
            deleteBtn.BackColor = Color.FromArgb(255, 192, 192);
            deleteBtn.Location = new Point(223, 24);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(181, 36);
            deleteBtn.TabIndex = 12;
            deleteBtn.Text = "حذف";
            deleteBtn.UseVisualStyleBackColor = false;
            deleteBtn.Click += deleteBtn_Click;
            // 
            // updateBtn
            // 
            updateBtn.BackColor = Color.FromArgb(255, 255, 128);
            updateBtn.Location = new Point(410, 24);
            updateBtn.Name = "updateBtn";
            updateBtn.Size = new Size(181, 36);
            updateBtn.TabIndex = 11;
            updateBtn.Text = "تعديل";
            updateBtn.UseVisualStyleBackColor = false;
            // 
            // insertBtn
            // 
            insertBtn.BackColor = Color.FromArgb(255, 192, 128);
            insertBtn.Location = new Point(597, 24);
            insertBtn.Name = "insertBtn";
            insertBtn.Size = new Size(181, 36);
            insertBtn.TabIndex = 10;
            insertBtn.Text = "إضافة";
            insertBtn.UseVisualStyleBackColor = false;
            // 
            // addBtn
            // 
            addBtn.BackColor = Color.FromArgb(128, 255, 128);
            addBtn.Location = new Point(784, 22);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(181, 36);
            addBtn.TabIndex = 9;
            addBtn.Text = "جديد";
            addBtn.UseVisualStyleBackColor = false;
            // 
            // categoriesList
            // 
            categoriesList.AllowUserToAddRows = false;
            categoriesList.AllowUserToDeleteRows = false;
            categoriesList.AllowUserToResizeColumns = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(224, 224, 224);
            categoriesList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            categoriesList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            categoriesList.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            categoriesList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            categoriesList.DefaultCellStyle = dataGridViewCellStyle2;
            categoriesList.Location = new Point(559, 26);
            categoriesList.MultiSelect = false;
            categoriesList.Name = "categoriesList";
            categoriesList.RowHeadersVisible = false;
            categoriesList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            categoriesList.Size = new Size(424, 242);
            categoriesList.TabIndex = 2;
            categoriesList.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Categories
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(995, 428);
            Controls.Add(categoriesList);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Categories";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "إدارة الأصناف :";
            Load += Categories_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)categoriesList).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label2;
        private Label label1;
        private TextBox txtDesc;
        private TextBox txtId;
        private Label label3;
        private Button lastBtn;
        private Button nextBtn;
        private Button previousBtn;
        private Button firstBtn;
        private GroupBox groupBox2;
        private Button updateBtn;
        private Button insertBtn;
        private Button addBtn;
        private Button deleteBtn;
        private Button printAllBtn;
        private Button printCurrentBtn;
        private Button exportAllPDFBtn;
        private Button exportCurrentPDFBtn;
        private Button exitBtn;
        private DataGridView categoriesList;
    }
}