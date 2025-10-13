namespace ProductManagementWindowsForms.PL;

partial class ProductsForm
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose ( bool disposing )
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
        label1 = new Label();
        searchTxtBox = new TextBox();
        groupBox1 = new GroupBox();
        dataGridView1 = new DataGridView();
        groupBox2 = new GroupBox();
        button9 = new Button();
        button8 = new Button();
        button7 = new Button();
        button6 = new Button();
        button5 = new Button();
        button4 = new Button();
        button2 = new Button();
        button1 = new Button();
        groupBox1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
        groupBox2.SuspendLayout();
        SuspendLayout();
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
        label1.Location = new Point(144, 30);
        label1.Name = "label1";
        label1.Size = new Size(208, 17);
        label1.TabIndex = 0;
        label1.Text = "قم بإدخال الكلمات المراد البحث عنها :";
        // 
        // searchTxtBox
        // 
        searchTxtBox.AccessibleName = "";
        searchTxtBox.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
        searchTxtBox.Location = new Point(370, 26);
        searchTxtBox.Name = "searchTxtBox";
        searchTxtBox.Size = new Size(363, 25);
        searchTxtBox.TabIndex = 1;
        searchTxtBox.TextChanged += searchTxtBox_TextChanged;
        // 
        // groupBox1
        // 
        groupBox1.Controls.Add(dataGridView1);
        groupBox1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
        groupBox1.Location = new Point(12, 75);
        groupBox1.Name = "groupBox1";
        groupBox1.Size = new Size(983, 238);
        groupBox1.TabIndex = 2;
        groupBox1.TabStop = false;
        groupBox1.Text = "قائمة المنتوجات :";
        groupBox1.Enter += groupBox1_Enter;
        // 
        // dataGridView1
        // 
        dataGridView1.AllowUserToAddRows = false;
        dataGridView1.AllowUserToDeleteRows = false;
        dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGridView1.Location = new Point(-124, 24);
        dataGridView1.Name = "dataGridView1";
        dataGridView1.ReadOnly = true;
        dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dataGridView1.Size = new Size(1107, 214);
        dataGridView1.TabIndex = 0;
        dataGridView1.CellContentClick += dataGridView1_CellContentClick;
        // 
        // groupBox2
        // 
        groupBox2.Controls.Add(button9);
        groupBox2.Controls.Add(button8);
        groupBox2.Controls.Add(button7);
        groupBox2.Controls.Add(button6);
        groupBox2.Controls.Add(button5);
        groupBox2.Controls.Add(button4);
        groupBox2.Controls.Add(button2);
        groupBox2.Controls.Add(button1);
        groupBox2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
        groupBox2.Location = new Point(12, 338);
        groupBox2.Name = "groupBox2";
        groupBox2.Size = new Size(983, 127);
        groupBox2.TabIndex = 3;
        groupBox2.TabStop = false;
        groupBox2.Text = "العمليات المتاحة :";
        groupBox2.Enter += groupBox2_Enter;
        // 
        // button9
        // 
        button9.BackColor = Color.FromArgb(128, 128, 255);
        button9.Location = new Point(192, 40);
        button9.Name = "button9";
        button9.Size = new Size(118, 32);
        button9.TabIndex = 8;
        button9.Text = "طباعة المنتوج";
        button9.UseVisualStyleBackColor = false;
        // 
        // button8
        // 
        button8.BackColor = Color.FromArgb(224, 224, 224);
        button8.Location = new Point(494, 89);
        button8.Name = "button8";
        button8.Size = new Size(289, 32);
        button8.TabIndex = 7;
        button8.Text = "حفظ اللائحة في ملف اكسيل";
        button8.UseVisualStyleBackColor = false;
        button8.Click += button8_Click;
        // 
        // button7
        // 
        button7.BackColor = Color.FromArgb(128, 255, 255);
        button7.Location = new Point(343, 89);
        button7.Name = "button7";
        button7.Size = new Size(118, 32);
        button7.TabIndex = 6;
        button7.Text = "خروج";
        button7.UseVisualStyleBackColor = false;
        button7.Click += button7_Click;
        // 
        // button6
        // 
        button6.BackColor = Color.FromArgb(255, 128, 128);
        button6.Location = new Point(670, 40);
        button6.Name = "button6";
        button6.Size = new Size(129, 32);
        button6.TabIndex = 5;
        button6.Text = "حذف المنتوج الحدد";
        button6.UseVisualStyleBackColor = false;
        button6.Click += button6_Click;
        // 
        // button5
        // 
        button5.BackColor = Color.FromArgb(255, 192, 128);
        button5.Location = new Point(494, 40);
        button5.Name = "button5";
        button5.Size = new Size(143, 32);
        button5.TabIndex = 4;
        button5.Text = "تعديل بيانات المنتوج";
        button5.UseVisualStyleBackColor = false;
        button5.Click += button5_Click;
        // 
        // button4
        // 
        button4.BackColor = Color.FromArgb(192, 192, 255);
        button4.Location = new Point(6, 40);
        button4.Name = "button4";
        button4.Size = new Size(153, 32);
        button4.TabIndex = 3;
        button4.Text = "طباعة كل المنتوجات";
        button4.UseVisualStyleBackColor = false;
        // 
        // button2
        // 
        button2.BackColor = Color.FromArgb(255, 128, 255);
        button2.Location = new Point(343, 40);
        button2.Name = "button2";
        button2.Size = new Size(118, 32);
        button2.TabIndex = 1;
        button2.Text = "صورة المنتوج";
        button2.UseVisualStyleBackColor = false;
        // 
        // button1
        // 
        button1.BackColor = Color.FromArgb(128, 255, 128);
        button1.Location = new Point(832, 40);
        button1.Name = "button1";
        button1.Size = new Size(118, 32);
        button1.TabIndex = 0;
        button1.Text = "إضافة منتوج جديد";
        button1.UseVisualStyleBackColor = false;
        button1.Click += button1_Click;
        // 
        // ProductsForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1007, 477);
        Controls.Add(groupBox2);
        Controls.Add(groupBox1);
        Controls.Add(searchTxtBox);
        Controls.Add(label1);
        FormBorderStyle = FormBorderStyle.Fixed3D;
        MaximizeBox = false;
        Name = "ProductsForm";
        RightToLeft = RightToLeft.Yes;
        RightToLeftLayout = true;
        StartPosition = FormStartPosition.CenterScreen;
        Text = "نافذة إدارة المنتوجات";
        Load += ProductsForm_Load;
        groupBox1.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
        groupBox2.ResumeLayout(false);
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label label1;
    private TextBox searchTxtBox;
    private GroupBox groupBox1;
    private DataGridView dataGridView1;
    private GroupBox groupBox2;
    private Button button1;
    private Button button8;
    private Button button7;
    private Button button6;
    private Button button5;
    private Button button4;
    private Button button2;
    private Button button9;
}