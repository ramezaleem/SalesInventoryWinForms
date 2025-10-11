namespace ProductManagementWindowsForms.PL;

partial class LoginForm
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
    private void InitializeComponent ()
    {
        label1 = new Label();
        label2 = new Label();
        txtId = new TextBox();
        txtPassword = new TextBox();
        loginBtn = new Button();
        cancelBtn = new Button();
        SuspendLayout();
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
        label1.ForeColor = Color.Black;
        label1.Location = new Point(54, 38);
        label1.Name = "label1";
        label1.Size = new Size(110, 21);
        label1.TabIndex = 0;
        label1.Text = "اسم المستخدم :";
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
        label2.ForeColor = Color.Black;
        label2.Location = new Point(54, 94);
        label2.Name = "label2";
        label2.Size = new Size(91, 21);
        label2.TabIndex = 1;
        label2.Text = "كلمة المرور :";
        // 
        // txtId
        // 
        txtId.Location = new Point(190, 35);
        txtId.Name = "txtId";
        txtId.Size = new Size(310, 27);
        txtId.TabIndex = 2;
        // 
        // txtPassword
        // 
        txtPassword.Location = new Point(190, 91);
        txtPassword.Name = "txtPassword";
        txtPassword.Size = new Size(310, 27);
        txtPassword.TabIndex = 3;
        // 
        // loginBtn
        // 
        loginBtn.BackColor = Color.FromArgb(128, 255, 128);
        loginBtn.FlatStyle = FlatStyle.Popup;
        loginBtn.ForeColor = Color.White;
        loginBtn.ImageAlign = ContentAlignment.BottomLeft;
        loginBtn.Location = new Point(425, 153);
        loginBtn.Name = "loginBtn";
        loginBtn.Size = new Size(75, 29);
        loginBtn.TabIndex = 4;
        loginBtn.Text = "دخول";
        loginBtn.UseVisualStyleBackColor = false;
        loginBtn.Click += loginBtn_Click;
        // 
        // cancelBtn
        // 
        cancelBtn.BackColor = Color.FromArgb(255, 128, 128);
        cancelBtn.FlatStyle = FlatStyle.Popup;
        cancelBtn.ForeColor = Color.White;
        cancelBtn.Location = new Point(334, 153);
        cancelBtn.Name = "cancelBtn";
        cancelBtn.Size = new Size(75, 29);
        cancelBtn.TabIndex = 5;
        cancelBtn.Text = "إلغاء";
        cancelBtn.UseVisualStyleBackColor = false;
        cancelBtn.Click += cancelBtn_Click;
        // 
        // LoginForm
        // 
        AutoScaleDimensions = new SizeF(9F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = SystemColors.AppWorkspace;
        ClientSize = new Size(537, 212);
        Controls.Add(cancelBtn);
        Controls.Add(loginBtn);
        Controls.Add(txtPassword);
        Controls.Add(txtId);
        Controls.Add(label2);
        Controls.Add(label1);
        Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
        ForeColor = Color.White;
        Margin = new Padding(4);
        MaximizeBox = false;
        MinimizeBox = false;
        Name = "LoginForm";
        RightToLeft = RightToLeft.Yes;
        RightToLeftLayout = true;
        StartPosition = FormStartPosition.CenterScreen;
        Text = "تسجيل الدخول :";
        Load += LoginForm_Load;
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label label1;
    private Label label2;
    private TextBox txtId;
    private TextBox txtPassword;
    private Button loginBtn;
    private Button cancelBtn;
}