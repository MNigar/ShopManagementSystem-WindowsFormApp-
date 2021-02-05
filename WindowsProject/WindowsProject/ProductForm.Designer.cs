namespace WindowsProject
{
    partial class ProductForm
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
            this.dgw_ProductTable = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_UserId = new System.Windows.Forms.Label();
            this.cmb_Category = new System.Windows.Forms.ComboBox();
            this.lbl_PhoneNumber = new System.Windows.Forms.Label();
            this.txb_Count = new System.Windows.Forms.TextBox();
            this.lbl_Price = new System.Windows.Forms.Label();
            this.txb_Price = new System.Windows.Forms.TextBox();
            this.lbl_Category = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.tbx_productName = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_ProductTable)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgw_ProductTable
            // 
            this.dgw_ProductTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_ProductTable.Location = new System.Drawing.Point(132, 13);
            this.dgw_ProductTable.Margin = new System.Windows.Forms.Padding(2);
            this.dgw_ProductTable.Name = "dgw_ProductTable";
            this.dgw_ProductTable.RowHeadersWidth = 62;
            this.dgw_ProductTable.RowTemplate.Height = 28;
            this.dgw_ProductTable.Size = new System.Drawing.Size(536, 200);
            this.dgw_ProductTable.TabIndex = 3;
            this.dgw_ProductTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgw_ProductTable_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_UserId);
            this.groupBox1.Controls.Add(this.cmb_Category);
            this.groupBox1.Controls.Add(this.lbl_PhoneNumber);
            this.groupBox1.Controls.Add(this.txb_Count);
            this.groupBox1.Controls.Add(this.lbl_Price);
            this.groupBox1.Controls.Add(this.txb_Price);
            this.groupBox1.Controls.Add(this.lbl_Category);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.lblName);
            this.groupBox1.Controls.Add(this.tbx_productName);
            this.groupBox1.Location = new System.Drawing.Point(132, 218);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(435, 220);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // lbl_UserId
            // 
            this.lbl_UserId.AutoSize = true;
            this.lbl_UserId.Location = new System.Drawing.Point(15, 187);
            this.lbl_UserId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_UserId.Name = "lbl_UserId";
            this.lbl_UserId.Size = new System.Drawing.Size(39, 13);
            this.lbl_UserId.TabIndex = 4;
            this.lbl_UserId.Text = "USerid";
            this.lbl_UserId.Visible = false;
            // 
            // cmb_Category
            // 
            this.cmb_Category.FormattingEnabled = true;
            this.cmb_Category.Location = new System.Drawing.Point(107, 63);
            this.cmb_Category.Margin = new System.Windows.Forms.Padding(2);
            this.cmb_Category.Name = "cmb_Category";
            this.cmb_Category.Size = new System.Drawing.Size(201, 21);
            this.cmb_Category.TabIndex = 16;
            // 
            // lbl_PhoneNumber
            // 
            this.lbl_PhoneNumber.AutoSize = true;
            this.lbl_PhoneNumber.Location = new System.Drawing.Point(16, 139);
            this.lbl_PhoneNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_PhoneNumber.Name = "lbl_PhoneNumber";
            this.lbl_PhoneNumber.Size = new System.Drawing.Size(25, 13);
            this.lbl_PhoneNumber.TabIndex = 10;
            this.lbl_PhoneNumber.Text = "Say";
            // 
            // txb_Count
            // 
            this.txb_Count.Location = new System.Drawing.Point(107, 135);
            this.txb_Count.Margin = new System.Windows.Forms.Padding(2);
            this.txb_Count.Name = "txb_Count";
            this.txb_Count.Size = new System.Drawing.Size(201, 20);
            this.txb_Count.TabIndex = 11;
            // 
            // lbl_Price
            // 
            this.lbl_Price.AutoSize = true;
            this.lbl_Price.Location = new System.Drawing.Point(16, 102);
            this.lbl_Price.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Price.Name = "lbl_Price";
            this.lbl_Price.Size = new System.Drawing.Size(39, 13);
            this.lbl_Price.TabIndex = 8;
            this.lbl_Price.Text = "Qiymət";
            // 
            // txb_Price
            // 
            this.txb_Price.Location = new System.Drawing.Point(107, 98);
            this.txb_Price.Margin = new System.Windows.Forms.Padding(2);
            this.txb_Price.Name = "txb_Price";
            this.txb_Price.Size = new System.Drawing.Size(201, 20);
            this.txb_Price.TabIndex = 9;
            // 
            // lbl_Category
            // 
            this.lbl_Category.AutoSize = true;
            this.lbl_Category.Location = new System.Drawing.Point(16, 68);
            this.lbl_Category.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Category.Name = "lbl_Category";
            this.lbl_Category.Size = new System.Drawing.Size(57, 13);
            this.lbl_Category.TabIndex = 6;
            this.lbl_Category.Text = "Kateqoriya";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(161, 170);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(76, 30);
            this.button1.TabIndex = 5;
            this.button1.Text = "Əlavə Edin";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(16, 30);
            this.lblName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(58, 13);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Məhsul adı";
            // 
            // tbx_productName
            // 
            this.tbx_productName.Location = new System.Drawing.Point(107, 26);
            this.tbx_productName.Margin = new System.Windows.Forms.Padding(2);
            this.tbx_productName.Name = "tbx_productName";
            this.tbx_productName.Size = new System.Drawing.Size(201, 20);
            this.tbx_productName.TabIndex = 4;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(572, 320);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(201, 20);
            this.textBox1.TabIndex = 17;
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dgw_ProductTable);
            this.Controls.Add(this.groupBox1);
            this.Name = "ProductForm";
            this.Text = "ProductForm";
            this.Load += new System.EventHandler(this.ProductForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgw_ProductTable)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgw_ProductTable;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_UserId;
        private System.Windows.Forms.ComboBox cmb_Category;
        private System.Windows.Forms.Label lbl_PhoneNumber;
        private System.Windows.Forms.TextBox txb_Count;
        private System.Windows.Forms.Label lbl_Price;
        private System.Windows.Forms.TextBox txb_Price;
        private System.Windows.Forms.Label lbl_Category;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox tbx_productName;
        private System.Windows.Forms.TextBox textBox1;
    }
}