namespace ProductManagementWindowsForms.PL;

partial class AddProductForm
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
        label2 = new Label();
        label3 = new Label();
        label4 = new Label();
        label5 = new Label();
        label6 = new Label();
        cmbCategories = new ComboBox();
        txtRef = new TextBox();
        txtDesc = new TextBox();
        txtQuantity = new TextBox();
        txtPrice = new TextBox();
        productImageBox = new PictureBox();
        browseFilesBtn = new Button();
        groupBox1 = new GroupBox();
        cancelBtn = new Button();
        okBtn = new Button();
        ((System.ComponentModel.ISupportInitialize)productImageBox).BeginInit();
        groupBox1.SuspendLayout();
        SuspendLayout();
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(468, 18);
        label1.Name = "label1";
        label1.Size = new Size(89, 17);
        label1.TabIndex = 0;
        label1.Text = "صنف المنتوج :";
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(477, 223);
        label2.Name = "label2";
        label2.Size = new Size(80, 17);
        label2.TabIndex = 1;
        label2.Text = "تمن المنتوج :";
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new Point(466, 177);
        label3.Name = "label3";
        label3.Size = new Size(91, 17);
        label3.TabIndex = 2;
        label3.Text = "الكمية المخزنة :";
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Location = new Point(465, 98);
        label4.Name = "label4";
        label4.Size = new Size(92, 17);
        label4.TabIndex = 3;
        label4.Text = "وصف المنتوج :";
        label4.Click += label4_Click;
        // 
        // label5
        // 
        label5.AutoSize = true;
        label5.Location = new Point(465, 58);
        label5.Name = "label5";
        label5.Size = new Size(92, 17);
        label5.TabIndex = 4;
        label5.Text = "معرف المنتوج :";
        // 
        // label6
        // 
        label6.AutoSize = true;
        label6.Location = new Point(467, 265);
        label6.Name = "label6";
        label6.Size = new Size(90, 17);
        label6.TabIndex = 5;
        label6.Text = "صورة المنتوج :";
        label6.Click += label6_Click;
        // 
        // cmbCategories
        // 
        cmbCategories.DropDownStyle = ComboBoxStyle.DropDownList;
        cmbCategories.FormattingEnabled = true;
        cmbCategories.Location = new Point(220, 14);
        cmbCategories.Name = "cmbCategories";
        cmbCategories.Size = new Size(208, 25);
        cmbCategories.TabIndex = 6;
        // 
        // txtRef
        // 
        txtRef.Location = new Point(220, 54);
        txtRef.Name = "txtRef";
        txtRef.Size = new Size(208, 25);
        txtRef.TabIndex = 0;
        txtRef.Validated += txtRef_Validated;
        // 
        // txtDesc
        // 
        txtDesc.Location = new Point(220, 99);
        txtDesc.Multiline = true;
        txtDesc.Name = "txtDesc";
        txtDesc.ScrollBars = ScrollBars.Vertical;
        txtDesc.Size = new Size(208, 64);
        txtDesc.TabIndex = 1;
        // 
        // txtQuantity
        // 
        txtQuantity.Location = new Point(221, 174);
        txtQuantity.Name = "txtQuantity";
        txtQuantity.Size = new Size(208, 25);
        txtQuantity.TabIndex = 2;
        // 
        // txtPrice
        // 
        txtPrice.Location = new Point(221, 220);
        txtPrice.Name = "txtPrice";
        txtPrice.Size = new Size(208, 25);
        txtPrice.TabIndex = 3;
        txtPrice.TextChanged += textBox4_TextChanged;
        // 
        // productImageBox
        // 
        productImageBox.Image = Properties.Resources.No_Image_Available_Arabic_800x800;
        productImageBox.Location = new Point(221, 265);
        productImageBox.Name = "productImageBox";
        productImageBox.Size = new Size(208, 154);
        productImageBox.SizeMode = PictureBoxSizeMode.StretchImage;
        productImageBox.TabIndex = 11;
        productImageBox.TabStop = false;
        // 
        // browseFilesBtn
        // 
        browseFilesBtn.BackColor = Color.FromArgb(255, 192, 128);
        browseFilesBtn.FlatStyle = FlatStyle.Popup;
        browseFilesBtn.Location = new Point(221, 425);
        browseFilesBtn.Name = "browseFilesBtn";
        browseFilesBtn.Size = new Size(208, 34);
        browseFilesBtn.TabIndex = 4;
        browseFilesBtn.Text = "تحديد ملف الصورة";
        browseFilesBtn.UseVisualStyleBackColor = false;
        browseFilesBtn.Click += browseFilesBtn_Click;
        // 
        // groupBox1
        // 
        groupBox1.Controls.Add(cancelBtn);
        groupBox1.Controls.Add(okBtn);
        groupBox1.Controls.Add(browseFilesBtn);
        groupBox1.Controls.Add(productImageBox);
        groupBox1.Controls.Add(txtPrice);
        groupBox1.Controls.Add(txtQuantity);
        groupBox1.Controls.Add(txtDesc);
        groupBox1.Controls.Add(txtRef);
        groupBox1.Controls.Add(cmbCategories);
        groupBox1.Controls.Add(label6);
        groupBox1.Controls.Add(label5);
        groupBox1.Controls.Add(label4);
        groupBox1.Controls.Add(label3);
        groupBox1.Controls.Add(label2);
        groupBox1.Controls.Add(label1);
        groupBox1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
        groupBox1.Location = new Point(12, 8);
        groupBox1.Name = "groupBox1";
        groupBox1.Size = new Size(686, 502);
        groupBox1.TabIndex = 0;
        groupBox1.TabStop = false;
        groupBox1.Text = "بيانات المنتوج :";
        groupBox1.Enter += groupBox1_Enter;
        // 
        // cancelBtn
        // 
        cancelBtn.BackColor = Color.FromArgb(255, 128, 128);
        cancelBtn.FlatStyle = FlatStyle.Popup;
        cancelBtn.ForeColor = Color.White;
        cancelBtn.Location = new Point(24, 447);
        cancelBtn.Name = "cancelBtn";
        cancelBtn.Size = new Size(75, 33);
        cancelBtn.TabIndex = 14;
        cancelBtn.Text = "إلغاء";
        cancelBtn.UseVisualStyleBackColor = false;
        cancelBtn.Click += cancelBtn_Click;
        // 
        // okBtn
        // 
        okBtn.BackColor = Color.FromArgb(128, 255, 128);
        okBtn.FlatStyle = FlatStyle.Popup;
        okBtn.ForeColor = Color.White;
        okBtn.ImageAlign = ContentAlignment.BottomLeft;
        okBtn.Location = new Point(115, 447);
        okBtn.Name = "okBtn";
        okBtn.Size = new Size(75, 33);
        okBtn.TabIndex = 13;
        okBtn.Text = "موافق";
        okBtn.UseVisualStyleBackColor = false;
        okBtn.Click += okBtn_Click;
        // 
        // AddProductForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(698, 500);
        Controls.Add(groupBox1);
        FormBorderStyle = FormBorderStyle.Fixed3D;
        MaximizeBox = false;
        Name = "AddProductForm";
        RightToLeft = RightToLeft.Yes;
        RightToLeftLayout = true;
        StartPosition = FormStartPosition.CenterScreen;
        Text = "إضافة منتج جديد";
        ((System.ComponentModel.ISupportInitialize)productImageBox).EndInit();
        groupBox1.ResumeLayout(false);
        groupBox1.PerformLayout();
        ResumeLayout(false);
    }

    #endregion

    private Label label1;
    private Label label2;
    private Label label3;
    private Label label4;
    private Label label5;
    private Label label6;
    private Button browseFilesBtn;
    private GroupBox groupBox1;
    private Button cancelBtn;
    public ComboBox cmbCategories;
    public TextBox txtRef;
    public TextBox txtDesc;
    public TextBox txtQuantity;
    public TextBox txtPrice;
    public PictureBox productImageBox;
    public Button okBtn;
}