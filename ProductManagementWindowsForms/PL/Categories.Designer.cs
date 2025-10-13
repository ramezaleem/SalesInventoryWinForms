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
            groupBox1 = new GroupBox();
            label1 = new Label();
            label2 = new Label();
            txtRef = new TextBox();
            txtDesc = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            label3 = new Label();
            groupBox2 = new GroupBox();
            addBtn = new Button();
            insertBtn = new Button();
            updateBtn = new Button();
            deleteBtn = new Button();
            groupBox3 = new GroupBox();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(button4);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(txtDesc);
            groupBox1.Controls.Add(txtRef);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 29);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(776, 239);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "بيانات الصنف :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(651, 41);
            label1.Name = "label1";
            label1.Size = new Size(81, 15);
            label1.TabIndex = 0;
            label1.Text = "معرف الصنف :";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(651, 83);
            label2.Name = "label2";
            label2.Size = new Size(81, 15);
            label2.TabIndex = 1;
            label2.Text = "وصف الصنف :";
            label2.Click += label2_Click;
            // 
            // txtRef
            // 
            txtRef.Location = new Point(459, 37);
            txtRef.Name = "txtRef";
            txtRef.ReadOnly = true;
            txtRef.Size = new Size(156, 23);
            txtRef.TabIndex = 2;
            // 
            // txtDesc
            // 
            txtDesc.Location = new Point(238, 79);
            txtDesc.Multiline = true;
            txtDesc.Name = "txtDesc";
            txtDesc.ReadOnly = true;
            txtDesc.ScrollBars = ScrollBars.Vertical;
            txtDesc.Size = new Size(377, 82);
            txtDesc.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(669, 196);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 4;
            button1.Text = "||<<";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(578, 196);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 5;
            button2.Text = "<<";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(268, 196);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 7;
            button3.Text = ">>||";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(360, 196);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 6;
            button4.Text = ">>";
            button4.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(483, 198);
            label3.Name = "label3";
            label3.Size = new Size(41, 17);
            label3.TabIndex = 8;
            label3.Text = "Label";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button9);
            groupBox2.Controls.Add(button8);
            groupBox2.Controls.Add(button7);
            groupBox2.Controls.Add(button6);
            groupBox2.Controls.Add(button5);
            groupBox2.Controls.Add(deleteBtn);
            groupBox2.Controls.Add(updateBtn);
            groupBox2.Controls.Add(insertBtn);
            groupBox2.Controls.Add(addBtn);
            groupBox2.Location = new Point(12, 294);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(776, 97);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "العمليات المتاحة :";
            // 
            // addBtn
            // 
            addBtn.BackColor = Color.FromArgb(128, 255, 128);
            addBtn.Location = new Point(678, 40);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(82, 23);
            addBtn.TabIndex = 9;
            addBtn.Text = "جديد";
            addBtn.UseVisualStyleBackColor = false;
            // 
            // insertBtn
            // 
            insertBtn.BackColor = Color.FromArgb(255, 192, 128);
            insertBtn.Location = new Point(597, 40);
            insertBtn.Name = "insertBtn";
            insertBtn.Size = new Size(75, 23);
            insertBtn.TabIndex = 10;
            insertBtn.Text = "إضافة";
            insertBtn.UseVisualStyleBackColor = false;
            // 
            // updateBtn
            // 
            updateBtn.BackColor = Color.FromArgb(255, 255, 128);
            updateBtn.Location = new Point(435, 40);
            updateBtn.Name = "updateBtn";
            updateBtn.Size = new Size(75, 23);
            updateBtn.TabIndex = 11;
            updateBtn.Text = "تعديل";
            updateBtn.UseVisualStyleBackColor = false;
            // 
            // deleteBtn
            // 
            deleteBtn.BackColor = Color.FromArgb(255, 192, 192);
            deleteBtn.Location = new Point(516, 40);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(75, 23);
            deleteBtn.TabIndex = 12;
            deleteBtn.Text = "حذف";
            deleteBtn.UseVisualStyleBackColor = false;
            // 
            // groupBox3
            // 
            groupBox3.Location = new Point(12, 411);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(776, 158);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "لائحة الأصناف :";
            groupBox3.Enter += groupBox3_Enter;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(192, 192, 255);
            button5.Location = new Point(311, 40);
            button5.Name = "button5";
            button5.Size = new Size(118, 23);
            button5.TabIndex = 13;
            button5.Text = "طباعة كل الأصناف";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.FromArgb(192, 192, 255);
            button6.Location = new Point(187, 40);
            button6.Name = "button6";
            button6.Size = new Size(118, 23);
            button6.TabIndex = 14;
            button6.Text = "طباعة الصنف الحالي";
            button6.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            button7.BackColor = Color.FromArgb(255, 224, 192);
            button7.Location = new Point(0, 40);
            button7.Name = "button7";
            button7.Size = new Size(181, 23);
            button7.TabIndex = 15;
            button7.Text = "حفظ كل الأصناف في ملف PDF";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click_1;
            // 
            // button8
            // 
            button8.BackColor = Color.FromArgb(255, 224, 192);
            button8.Location = new Point(579, 69);
            button8.Name = "button8";
            button8.Size = new Size(181, 28);
            button8.TabIndex = 16;
            button8.Text = "حفظ الملف الحالي في ملف PDF";
            button8.UseVisualStyleBackColor = false;
            // 
            // button9
            // 
            button9.BackColor = Color.Red;
            button9.ForeColor = Color.White;
            button9.Location = new Point(490, 69);
            button9.Name = "button9";
            button9.Size = new Size(83, 28);
            button9.TabIndex = 17;
            button9.Text = "خروج";
            button9.UseVisualStyleBackColor = false;
            // 
            // Categories
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 586);
            Controls.Add(groupBox3);
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
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label2;
        private Label label1;
        private TextBox txtDesc;
        private TextBox txtRef;
        private Label label3;
        private Button button3;
        private Button button4;
        private Button button2;
        private Button button1;
        private GroupBox groupBox2;
        private Button updateBtn;
        private Button insertBtn;
        private Button addBtn;
        private Button deleteBtn;
        private GroupBox groupBox3;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
    }
}