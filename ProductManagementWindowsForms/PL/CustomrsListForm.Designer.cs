namespace ProductManagementWindowsForms.PL
{
    partial class CustomrsListForm
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
            customersListDGVForm = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)customersListDGVForm).BeginInit();
            SuspendLayout();
            // 
            // customersListDGVForm
            // 
            customersListDGVForm.AllowUserToAddRows = false;
            customersListDGVForm.AllowUserToDeleteRows = false;
            customersListDGVForm.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            customersListDGVForm.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            customersListDGVForm.Dock = DockStyle.Fill;
            customersListDGVForm.Location = new Point(0, 0);
            customersListDGVForm.Name = "customersListDGVForm";
            customersListDGVForm.ReadOnly = true;
            customersListDGVForm.Size = new Size(800, 450);
            customersListDGVForm.TabIndex = 0;
            customersListDGVForm.DoubleClick += customersListDGVForm_DoubleClick;
            // 
            // CustomrsListForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(customersListDGVForm);
            Name = "CustomrsListForm";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "لائحة جميع العملاء :";
            ((System.ComponentModel.ISupportInitialize)customersListDGVForm).EndInit();
            ResumeLayout(false);
        }

        #endregion

        public DataGridView customersListDGVForm;
    }
}