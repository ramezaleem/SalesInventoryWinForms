namespace ProductManagementWindowsForms.PL;

partial class MainForm
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
        menuStrip1 = new MenuStrip();
        ملفToolStripMenuItem = new ToolStripMenuItem();
        تسجيلالدخولToolStripMenuItem = new ToolStripMenuItem();
        إنشاءنسخةاحتياطيةToolStripMenuItem = new ToolStripMenuItem();
        استعادةنسخةمحفوظةToolStripMenuItem = new ToolStripMenuItem();
        تسجيلالخروجToolStripMenuItem = new ToolStripMenuItem();
        المنتوجاتToolStripMenuItem = new ToolStripMenuItem();
        إضافةمنتججديدToolStripMenuItem = new ToolStripMenuItem();
        إدارةالمنتوجاتToolStripMenuItem = new ToolStripMenuItem();
        toolStripSeparator1 = new ToolStripSeparator();
        إدارةالأصنافToolStripMenuItem = new ToolStripMenuItem();
        العملاءToolStripMenuItem = new ToolStripMenuItem();
        إضافةعميلجديدToolStripMenuItem = new ToolStripMenuItem();
        إدارةالعملاءToolStripMenuItem = new ToolStripMenuItem();
        toolStripSeparator2 = new ToolStripSeparator();
        إضافةبيعجديدToolStripMenuItem = new ToolStripMenuItem();
        إدارةالمبيعاتToolStripMenuItem = new ToolStripMenuItem();
        المستخدمون = new ToolStripMenuItem();
        إضافةمستخدمجديدToolStripMenuItem = new ToolStripMenuItem();
        إدارةالمستخدمونToolStripMenuItem = new ToolStripMenuItem();
        menuStrip1.SuspendLayout();
        SuspendLayout();
        // 
        // menuStrip1
        // 
        menuStrip1.Items.AddRange(new ToolStripItem[] { ملفToolStripMenuItem, المنتوجاتToolStripMenuItem, العملاءToolStripMenuItem, المستخدمون });
        menuStrip1.Location = new Point(0, 0);
        menuStrip1.Name = "menuStrip1";
        menuStrip1.Size = new Size(640, 24);
        menuStrip1.TabIndex = 1;
        menuStrip1.Text = "menuStrip1";
        // 
        // ملفToolStripMenuItem
        // 
        ملفToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { تسجيلالدخولToolStripMenuItem, إنشاءنسخةاحتياطيةToolStripMenuItem, استعادةنسخةمحفوظةToolStripMenuItem, تسجيلالخروجToolStripMenuItem });
        ملفToolStripMenuItem.Name = "ملفToolStripMenuItem";
        ملفToolStripMenuItem.Size = new Size(42, 20);
        ملفToolStripMenuItem.Text = "ملف";
        // 
        // تسجيلالدخولToolStripMenuItem
        // 
        تسجيلالدخولToolStripMenuItem.Name = "تسجيلالدخولToolStripMenuItem";
        تسجيلالدخولToolStripMenuItem.Size = new Size(188, 22);
        تسجيلالدخولToolStripMenuItem.Text = "تسجيل الدخول";
        تسجيلالدخولToolStripMenuItem.Click += تسجيلالدخولToolStripMenuItem_Click;
        // 
        // إنشاءنسخةاحتياطيةToolStripMenuItem
        // 
        إنشاءنسخةاحتياطيةToolStripMenuItem.Name = "إنشاءنسخةاحتياطيةToolStripMenuItem";
        إنشاءنسخةاحتياطيةToolStripMenuItem.Size = new Size(188, 22);
        إنشاءنسخةاحتياطيةToolStripMenuItem.Text = "إنشاء نسخة احتياطية";
        // 
        // استعادةنسخةمحفوظةToolStripMenuItem
        // 
        استعادةنسخةمحفوظةToolStripMenuItem.Name = "استعادةنسخةمحفوظةToolStripMenuItem";
        استعادةنسخةمحفوظةToolStripMenuItem.Size = new Size(188, 22);
        استعادةنسخةمحفوظةToolStripMenuItem.Text = "استعادة نسخة محفوظة";
        // 
        // تسجيلالخروجToolStripMenuItem
        // 
        تسجيلالخروجToolStripMenuItem.Name = "تسجيلالخروجToolStripMenuItem";
        تسجيلالخروجToolStripMenuItem.Size = new Size(188, 22);
        تسجيلالخروجToolStripMenuItem.Text = "تسجيل الخروج";
        // 
        // المنتوجاتToolStripMenuItem
        // 
        المنتوجاتToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { إضافةمنتججديدToolStripMenuItem, إدارةالمنتوجاتToolStripMenuItem, toolStripSeparator1, إدارةالأصنافToolStripMenuItem });
        المنتوجاتToolStripMenuItem.Name = "المنتوجاتToolStripMenuItem";
        المنتوجاتToolStripMenuItem.Size = new Size(68, 20);
        المنتوجاتToolStripMenuItem.Text = "المنتوجات";
        // 
        // إضافةمنتججديدToolStripMenuItem
        // 
        إضافةمنتججديدToolStripMenuItem.Name = "إضافةمنتججديدToolStripMenuItem";
        إضافةمنتججديدToolStripMenuItem.Size = new Size(180, 22);
        إضافةمنتججديدToolStripMenuItem.Text = "إضافة منتج جديد";
        إضافةمنتججديدToolStripMenuItem.Click += إضافةمنتججديدToolStripMenuItem_Click;
        // 
        // إدارةالمنتوجاتToolStripMenuItem
        // 
        إدارةالمنتوجاتToolStripMenuItem.Name = "إدارةالمنتوجاتToolStripMenuItem";
        إدارةالمنتوجاتToolStripMenuItem.Size = new Size(180, 22);
        إدارةالمنتوجاتToolStripMenuItem.Text = "إدارة المنتوجات";
        إدارةالمنتوجاتToolStripMenuItem.Click += إدارةالمنتوجاتToolStripMenuItem_Click;
        // 
        // toolStripSeparator1
        // 
        toolStripSeparator1.Name = "toolStripSeparator1";
        toolStripSeparator1.Size = new Size(177, 6);
        // 
        // إدارةالأصنافToolStripMenuItem
        // 
        إدارةالأصنافToolStripMenuItem.Name = "إدارةالأصنافToolStripMenuItem";
        إدارةالأصنافToolStripMenuItem.Size = new Size(180, 22);
        إدارةالأصنافToolStripMenuItem.Text = "إدارة الأصناف";
        // 
        // العملاءToolStripMenuItem
        // 
        العملاءToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { إضافةعميلجديدToolStripMenuItem, إدارةالعملاءToolStripMenuItem, toolStripSeparator2, إضافةبيعجديدToolStripMenuItem, إدارةالمبيعاتToolStripMenuItem });
        العملاءToolStripMenuItem.Name = "العملاءToolStripMenuItem";
        العملاءToolStripMenuItem.Size = new Size(52, 20);
        العملاءToolStripMenuItem.Text = "العملاء";
        // 
        // إضافةعميلجديدToolStripMenuItem
        // 
        إضافةعميلجديدToolStripMenuItem.Name = "إضافةعميلجديدToolStripMenuItem";
        إضافةعميلجديدToolStripMenuItem.Size = new Size(159, 22);
        إضافةعميلجديدToolStripMenuItem.Text = "إضافة عميل جديد";
        // 
        // إدارةالعملاءToolStripMenuItem
        // 
        إدارةالعملاءToolStripMenuItem.Name = "إدارةالعملاءToolStripMenuItem";
        إدارةالعملاءToolStripMenuItem.Size = new Size(159, 22);
        إدارةالعملاءToolStripMenuItem.Text = "إدارة العملاء";
        إدارةالعملاءToolStripMenuItem.Click += إدارةالعملاءToolStripMenuItem_Click;
        // 
        // toolStripSeparator2
        // 
        toolStripSeparator2.Name = "toolStripSeparator2";
        toolStripSeparator2.Size = new Size(156, 6);
        // 
        // إضافةبيعجديدToolStripMenuItem
        // 
        إضافةبيعجديدToolStripMenuItem.Name = "إضافةبيعجديدToolStripMenuItem";
        إضافةبيعجديدToolStripMenuItem.Size = new Size(159, 22);
        إضافةبيعجديدToolStripMenuItem.Text = "إضافة بيع جديد";
        // 
        // إدارةالمبيعاتToolStripMenuItem
        // 
        إدارةالمبيعاتToolStripMenuItem.Name = "إدارةالمبيعاتToolStripMenuItem";
        إدارةالمبيعاتToolStripMenuItem.Size = new Size(159, 22);
        إدارةالمبيعاتToolStripMenuItem.Text = "إدارة المبيعات";
        // 
        // المستخدمون
        // 
        المستخدمون.DropDownItems.AddRange(new ToolStripItem[] { إضافةمستخدمجديدToolStripMenuItem, إدارةالمستخدمونToolStripMenuItem });
        المستخدمون.Name = "المستخدمون";
        المستخدمون.Size = new Size(81, 20);
        المستخدمون.Text = "المستخدمون";
        // 
        // إضافةمستخدمجديدToolStripMenuItem
        // 
        إضافةمستخدمجديدToolStripMenuItem.Name = "إضافةمستخدمجديدToolStripMenuItem";
        إضافةمستخدمجديدToolStripMenuItem.Size = new Size(174, 22);
        إضافةمستخدمجديدToolStripMenuItem.Text = "إضافة مستخدم جديد";
        // 
        // إدارةالمستخدمونToolStripMenuItem
        // 
        إدارةالمستخدمونToolStripMenuItem.Name = "إدارةالمستخدمونToolStripMenuItem";
        إدارةالمستخدمونToolStripMenuItem.Size = new Size(174, 22);
        إدارةالمستخدمونToolStripMenuItem.Text = "إدارة المستخدمين";
        // 
        // MainForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.White;
        ClientSize = new Size(640, 285);
        Controls.Add(menuStrip1);
        IsMdiContainer = true;
        MainMenuStrip = menuStrip1;
        Name = "MainForm";
        RightToLeft = RightToLeft.Yes;
        RightToLeftLayout = true;
        StartPosition = FormStartPosition.CenterScreen;
        Text = "برنامج إدارة المبيعات ( التسخة التجريبية )";
        WindowState = FormWindowState.Maximized;
        Load += MainForm_Load;
        menuStrip1.ResumeLayout(false);
        menuStrip1.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion
    private ToolStripMenuItem إدارةالمنتوجاتToolStripMenuItem;
    private ToolStripMenuItem إضافةمنتججديدToolStripMenuItem;
    private ToolStripSeparator toolStripSeparator1;
    private ToolStripMenuItem إدارةالأصنافToolStripMenuItem;
    private ToolStripMenuItem إضافةعميلجديدToolStripMenuItem;
    private ToolStripMenuItem إدارةالعملاءToolStripMenuItem;
    private ToolStripMenuItem إضافةبيعجديدToolStripMenuItem;
    private ToolStripMenuItem إدارةالمبيعاتToolStripMenuItem;
    private ToolStripSeparator toolStripSeparator2;
    private ToolStripMenuItem إضافةمستخدمجديدToolStripMenuItem;
    private ToolStripMenuItem إدارةالمستخدمونToolStripMenuItem;
    public MenuStrip menuStrip1;
    public ToolStripMenuItem ملفToolStripMenuItem;
    public ToolStripMenuItem المنتوجاتToolStripMenuItem;
    public ToolStripMenuItem العملاءToolStripMenuItem;
    public ToolStripMenuItem المستخدمون;
    public ToolStripMenuItem تسجيلالدخولToolStripMenuItem;
    public ToolStripMenuItem إنشاءنسخةاحتياطيةToolStripMenuItem;
    public ToolStripMenuItem استعادةنسخةمحفوظةToolStripMenuItem;
    public ToolStripMenuItem تسجيلالخروجToolStripMenuItem;
}