namespace ProductManagementWindowsForms.PL
{
    partial class ProductsList
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
            productsListDGV = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)productsListDGV).BeginInit();
            SuspendLayout();
            // 
            // productsListDGV
            // 
            productsListDGV.AllowUserToAddRows = false;
            productsListDGV.AllowUserToDeleteRows = false;
            productsListDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            productsListDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            productsListDGV.Dock = DockStyle.Fill;
            productsListDGV.Location = new Point(0, 0);
            productsListDGV.Name = "productsListDGV";
            productsListDGV.ReadOnly = true;
            productsListDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            productsListDGV.Size = new Size(800, 450);
            productsListDGV.TabIndex = 0;
            productsListDGV.DoubleClick += productsListDGV_DoubleClick;
            // 
            // ProductsList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(productsListDGV);
            Name = "ProductsList";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "لائحة جميع المنتجات :";
            ((System.ComponentModel.ISupportInitialize)productsListDGV).EndInit();
            ResumeLayout(false);
        }

        #endregion

        public DataGridView productsListDGV;
    }
}